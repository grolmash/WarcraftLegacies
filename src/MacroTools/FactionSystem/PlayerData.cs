using System;
using System.Collections.Generic;
using MacroTools.Extensions;
using static War3Api.Common;

namespace MacroTools.FactionSystem
{
  /// <summary>
  /// Provides extra information about players that is not already tracked by the Warcraft 3 engine.
  /// </summary>
  internal sealed class PlayerData
  {
    /// <summary>
    /// Fired when the player leaves a team.
    /// </summary>
    public event EventHandler<PlayerChangeTeamEventArgs>? PlayerLeftTeam;
    
    /// <summary>
    /// Fired when the player joins a team.
    /// </summary>
    public event EventHandler<PlayerChangeTeamEventArgs>? PlayerJoinedTeam;

    /// <summary>
    /// Fired when the player changes their <see cref="Faction"/>.
    /// </summary>
    public event EventHandler<PlayerFactionChangeEventArgs> ChangedFaction;
    
    private static readonly Dictionary<int, PlayerData> ById = new();
    private readonly Dictionary<int, int> _objectLevels = new();

    private readonly Dictionary<int, int> _objectLimits = new();
    private float _baseIncome; //Gold per minute
    private float _bonusIncome;
    private int _controlPointCount;

    private Team? _team;
    private Faction? _faction;

    private float _partialGold; //Just used for income calculations
    private float _partialLumber;

    private PlayerData(player player)
    {
      Player = player;
    }

    private player Player { get; }

    /// <summary>
    /// Controls who the player is allied to.
    /// </summary>
    public Team? Team
    {
      get => _team;
      set
      {
        if (_team != null)
        {
          _team?.RemovePlayer(Player);
          PlayerLeftTeam?.Invoke(this, new PlayerChangeTeamEventArgs(Player, _team));
        }

        if (value == null) return;
        var prevTeam = _team;
        _team = value;
        value.AddPlayer(Player);
        PlayerJoinedTeam?.Invoke(this, new PlayerChangeTeamEventArgs(Player, prevTeam));
      }
    }
    
    /// <summary>
    ///   Controls name, available objects, color, and icon.
    /// </summary>
    public Faction? Faction
    {
      get => _faction;
      set
      {
        var prevFaction = Faction;

        //Unapply old faction
        if (_faction != null)
        {
          _faction = null;
          if (prevFaction != null)
            prevFaction.Player = null; //Referential integrity
        }

        //Apply new faction
        if (value != null)
        {
          if (value.Player == null)
          {
            if (value.StartingUnits != null)
            {
              foreach (var unit in value.StartingUnits) 
                unit.Rescue(Player);
              value.StartingUnits.Clear();
            }
            
            Player.SetColor(value.PlayerColor, true);
            _faction = value;
            //Enforce referential integrity
            if (value.Player != Player)
              value.Player = Player;
          }
          else
          {
            throw new Exception(
              $"Attempted to assign player {GetPlayerName(Player)} to already occupied faction with name {value.Name}");
          }
        }

        FactionChange?.Invoke(this, new PlayerFactionChangeEventArgs(Player, prevFaction));
        ChangedFaction?.Invoke(this, new PlayerFactionChangeEventArgs(Player, prevFaction));
      }
    }

    public float LumberIncome { get; set; }

    /// <summary>
    ///   Gold per second gained from all sources.
    /// </summary>
    public float TotalIncome => BaseIncome + BonusIncome;

    /// <summary>
    ///   Gold per second gained from secondary sources like Forsaken's plagued buildings.
    /// </summary>
    public float BonusIncome
    {
      get => _bonusIncome;
      set
      {
        _bonusIncome = value;
        IncomeChanged?.Invoke(this, this);
      }
    }

    /// <summary>
    ///   Gold per second gained from primary sources like Control Points.
    /// </summary>
    public float BaseIncome
    {
      get => _baseIncome;
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(
            $"Tried to assign a negative {nameof(BaseIncome)} value to {GetPlayerName(Player)}.");

        _baseIncome = value;
        IncomeChanged?.Invoke(this, this);
      }
    }

    public int ControlPointCount
    {
      get => _controlPointCount;
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(
            $"Tried to assign a negative {nameof(ControlPointCount)} to + {GetPlayerName(Player)}");

        _controlPointCount = value;
      }
    }

    /// <summary>
    /// Fired when the player's income changes.
    /// </summary>
    public event EventHandler<PlayerData>? IncomeChanged;

    /// <summary>
    /// Fired when any player changes <see cref="Faction"/>.
    /// Todo: remove this and use the instance version instead.
    /// </summary>
    public static event EventHandler<PlayerFactionChangeEventArgs>? FactionChange;

    public int GetObjectLevel(int obj)
    {
      return _objectLevels[obj];
    }

    public void SetObjectLevel(int obj, int level)
    {
      _objectLevels[obj] = level;
      SetPlayerTechResearched(Player, obj, level);
    }

    public int GetObjectLimit(int id)
    {
      return _objectLimits.TryGetValue(id, out var limit) ? limit : 0;
    }

    private void SetObjectLimit(int id, int limit)
    {
      _objectLimits[id] = limit;
      SetObjectLevel(id, Math.Min(GetPlayerTechCount(Player, id, true), limit));
      if (limit >= Faction.UNLIMITED)
        SetPlayerTechMaxAllowed(Player, id, -1);
      else if (limit <= 0)
        SetPlayerTechMaxAllowed(Player, id, 0);
      else
        SetPlayerTechMaxAllowed(Player, id, limit);
    }

    public void ModObjectLimit(int id, int limit)
    {
      SetObjectLimit(id, GetObjectLimit(id) + limit);
    }

    public void AddGold(float x)
    {
      var fullGold = (float) Math.Floor(x);
      var remainderGold = x - fullGold;

      SetPlayerState(Player, PLAYER_STATE_RESOURCE_GOLD,
        GetPlayerState(Player, PLAYER_STATE_RESOURCE_GOLD) + R2I(fullGold));
      _partialGold += remainderGold;

      while (true)
      {
        if (_partialGold < 1) break;

        _partialGold -= 1;
        SetPlayerState(Player, PLAYER_STATE_RESOURCE_GOLD, GetPlayerState(Player, PLAYER_STATE_RESOURCE_GOLD) + 1);
      }
    }

    public void AddLumber(float x)
    {
      var fullLumber = (float) Math.Floor(x);
      var remainderLumber = x - fullLumber;

      SetPlayerState(Player, PLAYER_STATE_RESOURCE_LUMBER,
        GetPlayerState(Player, PLAYER_STATE_RESOURCE_LUMBER) + R2I(fullLumber));
      _partialLumber += remainderLumber;

      while (true)
      {
        if (_partialLumber < 1) break;

        _partialLumber -= 1;
        SetPlayerState(Player, PLAYER_STATE_RESOURCE_LUMBER, GetPlayerState(Player, PLAYER_STATE_RESOURCE_LUMBER) + 1);
      }
    }

    /// <summary>
    ///   Retrieves the <see cref="PlayerData" /> object which contains information about the given <see cref="player" />.
    /// </summary>
    public static PlayerData ByHandle(player whichPlayer)
    {
      if (ById.TryGetValue(GetPlayerId(whichPlayer), out var person)) return person;

      var newPerson = new PlayerData(whichPlayer);
      Register(newPerson);
      return newPerson;
    }

    /// <summary>
    ///   Register a <see cref="PlayerData" /> to the Person system.
    /// </summary>
    private static void Register(PlayerData playerData)
    {
      ById.Add(GetPlayerId(playerData.Player), playerData);
    }
  }
}