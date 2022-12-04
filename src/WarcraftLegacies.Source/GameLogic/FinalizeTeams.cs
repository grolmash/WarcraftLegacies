using System;
using System.Collections.Generic;
using System.Linq;
using MacroTools.FactionSelectionSystem;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.GameLogic
{
  /// <summary>
  /// Put players into their appropriate teams once everybody has finished picking their faction.
  /// </summary>
  public sealed class FinalizeTeams
  {
    private readonly FactionSelectionManager _factionSelectionManager;

    /// <summary>
    /// Initializes a new instance of the <see cref="FinalizeTeams"/> class.
    /// </summary>
    /// <param name="factionSelectionManager"></param>
    public FinalizeTeams(FactionSelectionManager factionSelectionManager)
    {
      _factionSelectionManager = factionSelectionManager;
    }

    /// <summary>
    ///   After a short delay, removes players from the game if their slot is unoccupied.
    /// </summary>
    public void Run()
    {
      var trig = CreateTrigger();
      TriggerRegisterTimerEvent(trig, 10, false);
      TriggerAddAction(trig, Action);
    }

    private void SetupTeams()
    {
      foreach (var factionSelection in _factionSelectionManager.GetAllFactionSelections())
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
        var unselectedFactions = _factionSelectionManager.GetAllFactionSelections()
          .Where(x => x.Player == null)
          .Select(x => x.Faction)
          .ToList();
        if (unselectedFactions.Count == 0)
          throw new Exception($"There were no unselected factions left to give to {GetPlayerName(player)}.");
        var selectedFaction = unselectedFactions[random.Next(unselectedFactions.Count)];
        player.SetFaction(selectedFaction);
        selectedFaction.Status = FactionStatus.Undefeated;
      }
    }

    private void Action()
    {
      try
      {
        var allPlayers = WCSharp.Shared.Util.EnumeratePlayers().ToList();
        EnsureAllPlayersHaveFactions(allPlayers);
        SetupTeams();
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Failed to run {nameof(FinalizeTeams)}: {ex}");
      }
    }
  }
}