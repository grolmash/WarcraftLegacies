using System;
using System.Collections.Generic;
using MacroTools.Augments;
using MacroTools.Extensions;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using MacroTools.Wrappers;
using WCSharp.Events;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace MacroTools.FactionSystem
{
  /// <summary>
  ///   Represents a faction in the Azeroth Wars universe, such as Lordaeron, Stormwind, or the Frostwolf Clan.
  ///   Governs techtrees and quests.
  /// </summary>
  public sealed class Faction
  {
    /// <summary>
    ///   Signifies unlimited unit production.
    /// </summary>
    public const int UNLIMITED = 200;

    /// <summary>
    ///   The gold cost value of a hero.
    /// </summary>
    public const int HeroCost = 100;

    /// <summary>
    ///   How much gold and lumber is refunded from units that get refunded when a player leaves.
    /// </summary>
    private const float RefundMultiplier = 1;

    /// <summary>
    ///   How much experience is transferred from heroes that leave the game.
    /// </summary>
    private const float ExperienceTransferMultiplier = 1;

    /// <summary>
    ///   The amount of food <see cref="Faction" />s can have by default.
    /// </summary>
    private const int FoodMaximumDefault = 150;

    private readonly Dictionary<int, int> _abilityAvailabilities = new();
    private readonly List<Augment> _augments = new();

    private readonly int _defeatedResearch;
    private readonly List<unit> _goldMines = new();

    private readonly Dictionary<int, int> _objectLevels = new();
    private readonly Dictionary<int, int> _objectLimits = new();
    private readonly List<Power> _powers = new();
    private readonly Dictionary<string, QuestData> _questsByName = new();
    private int _foodMaximum;
    private string _icon;
    private string _name;
    private player? _player;
    private FactionStatus _status = FactionStatus.Unselected;
    private int _undefeatedResearch;
    private int _xp; //Stored by DistributeUnits and given out again by DistributeResources

    /// <summary>
    ///   Fired when the <see cref="Faction" /> gains a <see cref="Power" />.
    /// </summary>
    public EventHandler<FactionPowerEventArgs>? PowerAdded;

    /// <summary>
    ///   Fired when the <see cref="Faction" /> loses a <see cref="Power" />.
    /// </summary>
    public EventHandler<FactionPowerEventArgs>? PowerRemoved;

    /// <summary>
    /// Fired when the <see cref="Faction"/>'s status changes.
    /// </summary>
    public EventHandler<Faction>? ScoreStatusChanged;
    
    /// <summary>
    /// The units that this <see cref="Faction"/> starts with.
    /// </summary>
    public List<unit>? StartingUnits { get; private set; }

    /// <summary>
    /// Where the player's camera should be moved when they pick this faction.
    /// </summary>
    public Point CameraStartPosition { get; set; }
    
    static Faction()
    {
      PlayerUnitEvents.Register(ResearchEvent.IsFinished, () =>
      {
        var faction = FactionManager.GetFromPlayer(GetTriggerPlayer());
        faction?.SetObjectLevel(GetResearched(), GetPlayerTechCount(GetTriggerPlayer(), GetResearched(), false));
      });
    }

    public Faction(string name, playercolor playerColor, string prefixCol, string icon)
    {
      _name = name;
      PlayerColor = playerColor;
      PrefixCol = prefixCol;
      _icon = icon;
      FoodMaximum = FoodMaximumDefault;
    }

    /// <summary>
    ///   Displayed to the <see cref="Faction" /> when the game starts.
    /// </summary>
    public string? IntroText { get; init; }

    public int StartingGold { get; set; }

    public int StartingLumber { get; set; }

    public playercolor PlayerColor { get; }

    public float Gold
    {
      get => I2R(GetPlayerState(Player, PLAYER_STATE_RESOURCE_GOLD));
      set => SetPlayerState(Player, PLAYER_STATE_RESOURCE_GOLD, R2I(value));
    }

    public float Lumber
    {
      get => I2R(GetPlayerState(Player, PLAYER_STATE_RESOURCE_LUMBER));
      set => SetPlayerState(Player, PLAYER_STATE_RESOURCE_LUMBER, R2I(value));
    }

    /// <summary>
    ///   The <see cref="Faction" />'s food limit.
    ///   A <see cref="player" /> with this Faction can never exceed this amount of food.
    /// </summary>
    public int FoodMaximum
    {
      get => _foodMaximum;
      set
      {
        _foodMaximum = value;
        if (Player != null) SetPlayerState(Player, PLAYER_STATE_FOOD_CAP_CEILING, value);
      }
    }

    /// <summary>
    ///   Music that will play for the Faction at the start of the game.
    /// </summary>
    public string CinematicMusic { get; init; }

    /// <summary>
    /// The current game state of the <see cref="Faction"/>.
    /// </summary>
    public FactionStatus Status
    {
      get => _status;
      set
      {
        //Change defeated/undefeated researches
        foreach (var player in WCSharp.Shared.Util.EnumeratePlayers())
          if (value == FactionStatus.Defeated)
          {
            SetPlayerTechResearched(player, _defeatedResearch, 1);
            SetPlayerTechResearched(player, _undefeatedResearch, 0);
          }

        //Remove player from game if necessary
        if (value == FactionStatus.Defeated && Player != null)
        {
          FogModifierStart(CreateFogModifierRect(Player, FOG_OF_WAR_VISIBLE,
            WCSharp.Shared.Data.Rectangle.WorldBounds.Rect, false, false));
          RemovePlayer(Player, PLAYER_GAME_RESULT_DEFEAT);
          SetPlayerState(Player, PLAYER_STATE_OBSERVER, 1);
          Leave();
        }

        _status = value;
        StatusChanged?.Invoke(this, this);
        ScoreStatusChanged?.Invoke(this, this);
      }
    }

    public string ColoredName => PrefixCol + _name + "|r";

    public string PrefixCol { get; }

    public string Name
    {
      get => _name;
      set
      {
        var formerName = _name;
        _name = value;
        NameChanged?.Invoke(this, new FactionNameChangeEventArgs(this, formerName));
      }
    }

    public string Icon
    {
      get => _icon;
      set
      {
        _icon = value;
        IconChanged?.Invoke(this, this);
      }
    }


    /// <summary>
    ///   The <see cref="player" /> currently occupying this <see cref="Faction" />.
    /// </summary>
    public player? Player
    {
      get => _player;
      set
      {
        if (Player != null)
        {
          Player.GetTeam()?.UnallyPlayer(Player);
          HideAllQuests();
          UnapplyObjects();
          UnapplyPowers();
        }

        _player = value;
        //Maintain referential integrity
        //Todo: this seems a bit silly
        if (value == null) return;

        if (value.GetFaction() != this)
          value.SetFaction(this);

        Player?.GetTeam()?.AllyPlayer(value);
        ApplyObjects();
        ApplyPowers();
        ShowAllQuests();
        SetPlayerState(Player, PLAYER_STATE_FOOD_CAP_CEILING, _foodMaximum);
      }
    }

    public QuestData? StartingQuest { get; set; }

    /// <summary>
    ///   This research is enabled for every player while this <see cref="Faction" /> is not defeated.
    /// </summary>
    public int UndefeatedResearch
    {
      set
      {
        if (_undefeatedResearch != 0) return;
        _undefeatedResearch = value;
        foreach (var player in WCSharp.Shared.Util.EnumeratePlayers()) SetPlayerTechResearched(player, _undefeatedResearch, 1);
      }
      get => _undefeatedResearch;
    }

    /// <summary>
    ///   This research is enabled for every player while this <see cref="Faction" /> is defeated.
    /// </summary>
    public int DefeatedResearch
    {
      init
      {
        if (_defeatedResearch != 0) return;
        _defeatedResearch = value;
        foreach (var player in WCSharp.Shared.Util.EnumeratePlayers()) SetPlayerTechResearched(player, _defeatedResearch, 0);
      }
    }

    private void ApplyPowers()
    {
      if (Player == null) return;
      foreach (var power in _powers)
        power.OnAdd(Player);
    }

    private void UnapplyPowers()
    {
      if (Player == null) return;
      foreach (var power in _powers)
        power.OnRemove(Player);
    }

    /// <summary>
    ///   Fires when the <see cref="Faction" /> joins a new <see cref="Team" />.
    /// </summary>
    public event EventHandler<Faction>? JoinedTeam;

    /// <summary>
    ///   Fires when the <see cref="Faction" /> changes its name.
    /// </summary>
    public event EventHandler<FactionNameChangeEventArgs>? NameChanged;

    /// <summary>
    /// Fired after the <see cref="Faction"/> leaves the game.
    /// </summary>
    public event EventHandler<Faction>? LeftGame;
    
    /// <summary>
    /// Fired when the <see cref="Faction"/>'s has changed.
    /// </summary>
    public event EventHandler<Faction>? IconChanged;
    
    /// <summary>
    /// Fired after the <see cref="Faction"/>'s status has changed.
    /// </summary>
    public event EventHandler<Faction>? StatusChanged;

    /// <summary>
    ///   Returns all unit types which this <see cref="Faction" /> can only train a limited number of.
    /// </summary>
    public IEnumerable<int> GetLimitedObjects()
    {
      return _objectLimits.Keys;
    }

    /// <summary>
    ///   Returns the maximum number of times the Faction can train a unit, build a building, or research a research.
    /// </summary>
    /// <param name="whichObject">The object ID of a unit, building, or research.</param>
    public int GetObjectLimit(int whichObject)
    {
      return _objectLimits[whichObject];
    }

    //Adds this Faction's object limits and levels to its active Person
    private void ApplyObjects()
    {
      foreach (var (key, value) in _objectLimits)
        Player?.ModObjectLimit(key, value);

      foreach (var (key, value) in _objectLevels)
        Player?.SetObjectLevel(key, value);

      foreach (var (key, value) in _abilityAvailabilities)
        Player?.SetAbilityAvailability(key, value > 0);
    }

    //Removes this Faction's object limits and levels from its active Person
    private void UnapplyObjects()
    {
      foreach (var (key, value) in _objectLimits)
        Player?.ModObjectLimit(key, -value);

      foreach (var (key, _) in _objectLevels)
        Player?.SetObjectLevel(key, 0);

      foreach (var (key, value) in _abilityAvailabilities)
        Player?.SetAbilityAvailability(key, true);
    }

    /// <summary>
    ///   Registers a gold mine as belonging to this <see cref="Faction" />.
    ///   When the Faction leaves the game, all of their goldmines are removed.
    /// </summary>
    public void AddGoldMine(unit whichUnit)
    {
      _goldMines.Add(whichUnit);
    }

    /// <summary>
    ///   Adds a <see cref="Augment" /> to this <see cref="Faction" />.
    /// </summary>
    /// <param name="augment"></param>
    public void AddAugment(Augment augment)
    {
      _augments.Add(augment);
      augment.OnAdd(this);
    }

    /// <summary>
    ///   Adds a <see cref="Power" /> to this <see cref="Faction" />.
    /// </summary>
    public void AddPower(Power power)
    {
      _powers.Add(power);
      if (Player != null) power.OnAdd(Player);
      PowerAdded?.Invoke(this, new FactionPowerEventArgs(this, power));
    }

    /// <summary>
    ///   Removes a <see cref="Power" /> from this <see cref="Faction" />.
    /// </summary>
    public void RemovePower(Power power)
    {
      _powers.Remove(power);
      if (Player != null) power.OnRemove(Player);
      PowerRemoved?.Invoke(this, new FactionPowerEventArgs(this, power));
    }

    /// <summary>
    ///   Gets the first <see cref="Power" /> this <see cref="Faction" /> has with the provided type.
    /// </summary>
    public T GetPowerByType<T>() where T : Power
    {
      foreach (var power in _powers)
        if (power.GetType() == typeof(T))
          return (T)power;

      throw new Exception($"{_name} doesn't have a Power with the type {typeof(T).Name}.");
    }

    /// <summary>
    ///   Unallies the <see cref="Faction" /> from all of its allies, creating a new <see cref="Team" />
    ///   based on its name.
    /// </summary>
    public void Unally()
    {
      if (!(Player?.GetTeam()?.Size > 1)) return;
      var newTeamName = Name + " Pact";
      if (FactionManager.TeamWithNameExists(newTeamName))
      {
        Player.SetTeam(FactionManager.GetTeamByName(newTeamName));
        return;
      }

      var newTeam = new Team(newTeamName);
      FactionManager.Register(newTeam);
      Player.SetTeam(newTeam);
    }

    /// <summary>
    ///   Shows all of the Faction's quest, rendering them in the quest log,
    ///   showing them on the minimap, and showing them on the map.
    /// </summary>
    private void ShowAllQuests()
    {
      foreach (var quest in _questsByName.Values)
      {
        if (GetLocalPlayer() == Player) quest.ShowLocal();

        quest.ShowSync();
      }
    }

    //Hides all of the Faction)s quests.
    private void HideAllQuests()
    {
      foreach (var quest in _questsByName.Values)
      {
        if (GetLocalPlayer() == Player) quest.HideLocal();

        quest.HideSync();
      }
    }

    private void OnQuestProgressChanged(object? sender, QuestProgressChangedEventArgs args)
    {
      try
      {
        args.Quest.ApplyFactionProgress(this, args.Quest.Progress, args.FormerProgress);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
      }
    }

    public QuestData AddQuest(QuestData questData)
    {
      questData.Add(this);
      _questsByName.Add(questData.Title, questData);
      if (GetLocalPlayer() == Player)
        questData.ShowLocal();
      questData.ShowSync();
      questData.ProgressChanged += OnQuestProgressChanged;
      return questData;
    }

    /// <summary>
    ///   Changes the ability's availability by the provided amount.
    ///   If the availability is higher than 0, the <see cref="player" /> with this <see cref="Faction" />
    ///   can see and use it.
    /// </summary>
    public void ModAbilityAvailability(int ability, int value)
    {
      if (_abilityAvailabilities.ContainsKey(ability))
        _abilityAvailabilities[ability] += value;
      else
        _abilityAvailabilities[ability] = value;
      Player?.SetAbilityAvailability(ability, value > 0);
    }

    public int GetObjectLevel(int obj)
    {
      return _objectLevels[obj];
    }

    public void SetObjectLevel(int obj, int level)
    {
      _objectLevels[obj] = level;
      Player?.SetObjectLevel(obj, level);
    }

    /// <summary>
    ///   Changes the limit of the given object that the <see cref="Faction" /> can train, build, or research.
    /// </summary>
    /// <param name="objectId">The object ID to modify the limit of.</param>
    /// <param name="limit">The amount to adjust the limit by.</param>
    public void ModObjectLimit(int objectId, int limit)
    {
      if (_objectLimits.ContainsKey(objectId))
        _objectLimits[objectId] += limit;
      else
        _objectLimits.Add(objectId, limit);

      //If a player has this Faction, adjust their techtree as well
      Player?.ModObjectLimit(objectId, limit);

      if (_objectLimits[objectId] == 0)
        _objectLimits.Remove(objectId);
    }

    /// <summary>
    ///   Causes the <see cref="Faction" />'s <see cref="player" /> to lose everything they control,
    ///   without distributing it to members of their <see cref="Team" />.
    /// </summary>
    public void Obliterate()
    {
      //Take away resources
      SetPlayerState(Player, PLAYER_STATE_RESOURCE_GOLD, 0);
      SetPlayerState(Player, PLAYER_STATE_RESOURCE_LUMBER, 0);

      //Give all units to Neutral Victim
      foreach (var unit in new GroupWrapper().EnumUnitsOfPlayer(Player).EmptyToList())
      {
        var tempUnitType = UnitType.GetFromHandle(unit);
        if (!UnitAlive(unit))
          RemoveUnit(unit);

        if (!tempUnitType?.Meta == true)
          SetUnitOwner(unit, Player(GetBJPlayerNeutralVictim()), false);
      }
    }

    /// <summary>
    ///   Returns all <see cref="Power" />s this <see cref="Faction" /> has.
    /// </summary>
    public IEnumerable<Power> GetAllPowers()
    {
      foreach (var power in _powers) yield return power;
    }

    private void DistributeExperience(IEnumerable<player> playersToDistributeTo)
    {
      if (Player?.GetTeam() == null) return;
      foreach (var ally in playersToDistributeTo)
      {
        var allyHeroes = new GroupWrapper().EnumUnitsOfPlayer(ally).EmptyToList()
          .FindAll(unit => IsUnitType(unit, UNIT_TYPE_HERO));
        foreach (var hero in allyHeroes)
          AddHeroXP(hero, R2I(_xp / (Player.GetTeam().Size - 1) / allyHeroes.Count * ExperienceTransferMultiplier), true);
      }

      _xp = 0;
    }

    private void DistributeResources(List<player> playersToDistributeTo)
    {
      foreach (var player in playersToDistributeTo)
      {
        player.AdjustPlayerState(PLAYER_STATE_RESOURCE_GOLD, (int)(Gold / playersToDistributeTo.Count));
        player.AdjustPlayerState(PLAYER_STATE_RESOURCE_LUMBER, (int)(Lumber / playersToDistributeTo.Count));
      }

      Gold = 0;
      Lumber = 0;
    }

    private void DistributeUnits(IReadOnlyList<player> playersToDistributeTo)
    {
      if (Player?.GetTeam() == null) return;
      var playerUnits = new GroupWrapper().EnumUnitsOfPlayer(Player).EmptyToList();

      foreach (var unit in playerUnits)
      {
        var loopUnitType = UnitType.GetFromHandle(unit);
        //Refund gold and experience of heroes
        if (IsUnitType(unit, UNIT_TYPE_HERO))
        {
          Player?.AddGold(HeroCost);
          _xp += GetHeroXP(unit);
          //Subtract hero's starting XP from refunded XP
          if (Legend.GetFromUnit(unit) != null) _xp -= Legend.GetFromUnit(unit)!.StartingXp;

          unit.DropAllItems();
          RemoveUnit(unit);
          //Refund gold and lumber of refundable units
        }
        else if (!IsUnitType(unit, UNIT_TYPE_STRUCTURE))
        {
          Gold += loopUnitType.GoldCost * RefundMultiplier;
          Lumber += loopUnitType.LumberCost * RefundMultiplier;
          unit.DropAllItems();
          RemoveUnit(unit);
        }
        //Transfer the ownership of everything else
        else if (loopUnitType.Meta == false)
        {
          SetUnitOwner(unit,
            Player?.GetTeam()?.Size > 1
              ? playersToDistributeTo[GetRandomInt(0, playersToDistributeTo.Count-1)]
              : Player(GetBJPlayerNeutralVictim()), false);
        }
      }
    }

    /// <summary>
    ///   This should get used any time a player exits the game without being defeated;
    ///   IE they left, went afk, became an observer, or triggered an event that causes this.
    /// </summary>
    private void Leave()
    {
      if (Player?.GetTeam()?.Size > 1 && GameTime.GetGameTime() > 60)
      {
        var eligiblePlayers = Player.GetTeam()?.GetAllPlayers();
        eligiblePlayers?.Remove(Player);
        DistributeUnits(eligiblePlayers);
        DistributeResources(eligiblePlayers);
        DistributeExperience(eligiblePlayers);
      }
      else
      {
        RemoveGoldMines();
        Obliterate();
      }

      LeftGame?.Invoke(this, this);
    }

    private void RemoveGoldMines()
    {
      foreach (var unit in _goldMines) KillUnit(unit);
      _goldMines.Clear();
    }

    /// <summary>
    ///   Attempts to retrieve a <see cref="QuestData" /> belonging to this <see cref="Faction" /> with the given title.
    /// </summary>
    public QuestData GetQuestByTitle(string parameter)
    {
      return _questsByName[parameter];
    }

    /// <summary>
    /// Marks all of the provided player's units as starting units for this faction. This hides them until the faction is picked.
    /// </summary>
    public void ConfigureStartingFeatures(player player)
    {
      StartingUnits = new GroupWrapper().EnumUnitsOfPlayer(player).EmptyToList();
      foreach (var unit in StartingUnits) 
        ShowUnit(unit, false);
      CameraStartPosition = new Point(GetStartLocationX(GetPlayerStartLocation(player)), GetStartLocationY(GetPlayerStartLocation(player)));
    }
  }
}