using System;
using System.Collections.Generic;
using System.Linq;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace MacroTools.FactionSelectionSystem
{
  /// <summary>
  /// Responsible for allowing players to pick their faction before the game starts.
  /// </summary>
  public sealed class FactionSelectionManager
  {
    private readonly IEnumerable<FactionSelection> _factionSelections;

    /// <summary>
    /// Returns all factions that can be selected along with the player currently selecting them.
    /// </summary>
    public IEnumerable<FactionSelection> GetAllFactionSelections() =>
      _factionSelections.ToList().AsReadOnly();

    /// <summary>
    /// Fired when faction selection has finished.
    /// </summary>
    public event EventHandler? Finished;

    /// <summary>
    /// Initializes a new instance of the <see cref="FactionSelectionManager"/> class.
    /// </summary>
    /// <param name="factions">All factions that are eligible for selection.</param>
    public FactionSelectionManager(IEnumerable<Faction> factions)
    {
      _factionSelections = factions.Select(x => new FactionSelection
      {
        Faction = x,
        Player = GetPlayerSlotState(x.PriorityPicker) == PLAYER_SLOT_STATE_PLAYING ? x.PriorityPicker : null
      });
      foreach (var factionSelection in _factionSelections)
      {
        Console.WriteLine("register event");
        factionSelection.Selected += OnFactionSelected;
      }
    }

    /// <summary>
    ///   After a delay, organize players into their <see cref="Faction"/>s and <see cref="Team"/>s.
    /// </summary>
    public void Run()
    {
      var trig = CreateTrigger();
      TriggerRegisterTimerEvent(trig, 10, false);
      TriggerAddAction(trig, FinalizeLobby);
    }

    private void SetupTeams()
    {
      foreach (var factionSelection in GetAllFactionSelections())
      {
        factionSelection.Player?.SetFaction(factionSelection.Faction);
        factionSelection.Player?.SetTeam(GetBestTeamForFaction(factionSelection.Faction));
      }
    }

    private static Team GetBestTeamForFaction(Faction faction)
    {
      var bestNonEmptyTeam = faction.PossibleTeams.Where(x => x.Size != 0).OrderBy(x => x.Size).FirstOrDefault();
      return bestNonEmptyTeam ?? faction.PossibleTeams.First();
    }

    private void EnsureAllPlayersHaveFactions(List<player> allPlayers)
    {
      var random = new Random();
      foreach (var player in allPlayers)
      {
        if (GetPlayerSlotState(player) == PLAYER_SLOT_STATE_EMPTY) continue;
        var playerFaction = player.GetFaction();
        if (playerFaction != null)
          continue;
        var unselectedFactions = GetAllFactionSelections()
          .Where(x => x.Player == null)
          .ToList();
        if (unselectedFactions.Count == 0)
          throw new Exception($"There were no unselected factions left to give to {GetPlayerName(player)}.");
        var selectedFaction = unselectedFactions[random.Next(unselectedFactions.Count)];
        selectedFaction.SelectForPlayer(player);
      }
    }

    private void FinalizeLobby()
    {
      try
      {
        var allPlayers = WCSharp.Shared.Util.EnumeratePlayers().ToList();
        EnsureAllPlayersHaveFactions(allPlayers);
        SetupTeams();
        Finished?.Invoke(this, EventArgs.Empty);
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Failed to run {nameof(FinalizeLobby)}: {ex}");
      }
    }

    private void OnFactionSelected(object? sender, FactionSelection selectedFaction)
    {
      try
      {
        Console.WriteLine("AAAAA");
        foreach (var factionSelection in _factionSelections.Where(x =>
                   x.Player != null && x.Player == selectedFaction.Player && x != selectedFaction))
          factionSelection.SelectForPlayer(null);
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Failed to execute {nameof(OnFactionSelected)}: {ex}");
      }
    }
  }
}