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
    
    private void SetupTeams(IEnumerable<player> allPlayers)
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

    private void Action()
    {
      var random = new Random();
      var allFactions = FactionManager.GetAllFactions();

      var allPlayers = WCSharp.Shared.Util.EnumeratePlayers().ToList();
      foreach (var player in allPlayers)
      {
        try
        {
          if (GetPlayerSlotState(player) == PLAYER_SLOT_STATE_EMPTY) continue;
          var playerFaction = player.GetFaction();
          if (playerFaction != null)
            continue;
          var unselectedFactions = allFactions.Where(x => x.Status == FactionStatus.Unselected).ToList();
          if (unselectedFactions.Count == 0)
            throw new Exception($"There were no unselected factions left to give to {GetPlayerName(player)}.");
          var selectedFaction = unselectedFactions[random.Next(unselectedFactions.Count)];
          player.SetFaction(selectedFaction);
          selectedFaction.Status = FactionStatus.Undefeated;
          SetupTeams(allPlayers);
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Failed to finalize teams for player {GetPlayerName(player)}: {ex}");
        }
      }
    }
  }
}