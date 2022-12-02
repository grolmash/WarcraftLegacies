using System;
using System.Collections.Generic;
using System.Linq;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.GameLogic
{
  /// <summary>
  /// Put players into their appropriate teams once everybody has finished picking their faction.
  /// </summary>
  public static class FinalizeTeams
  {
    private static void SetupTeams(IEnumerable<player> allPlayers)
    {
      var selectedFactions = allPlayers
        .Select(x => x.GetFaction())
        .Where(x => x?.Status == FactionStatus.Undefeated)
        .OrderBy(x => x?.PossibleTeams.Count());
      foreach (var faction in selectedFactions) 
        faction?.Player?.SetTeam(GetBestTeamForFaction(faction));
    }

    private static Team GetBestTeamForFaction(Faction faction)
    {
      var bestNonEmptyTeam = faction.PossibleTeams.Where(x => x.Size != 0).MinBy(x => x.Size);
      return bestNonEmptyTeam ?? faction.PossibleTeams.First();
    }

    private static void Action()
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
          var selectedFaction = unselectedFactions[random.Next(0, unselectedFactions.Count - 1)];
          player.SetFaction(selectedFaction);
          selectedFaction.Status = FactionStatus.Undefeated;
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Failed to finalize teams for player {GetPlayerName(player)}: {ex}");
        }
      }
      SetupTeams(allPlayers);
    }


    /// <summary>
    ///   After a short delay, removes players from the game if their slot is unoccupied.
    /// </summary>
    public static void Setup()
    {
      var trig = CreateTrigger();
      TriggerRegisterTimerEvent(trig, 10, false);
      TriggerAddAction(trig, Action);
    }
  }
}