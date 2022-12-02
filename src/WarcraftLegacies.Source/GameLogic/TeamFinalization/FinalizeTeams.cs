using System;
using System.Linq;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.GameLogic.TeamFinalization
{
  /// <summary>
  /// Put players into their appropriate teams once everybody has finished picking their faction.
  /// </summary>
  public static class FinalizeTeams
  {
    private static void Action()
    {
      var random = new Random();
      var allFactions = FactionManager.GetAllFactions();

      foreach (var player in WCSharp.Shared.Util.EnumeratePlayers())
      {
        try
        {
          if (GetPlayerSlotState(player) == PLAYER_SLOT_STATE_EMPTY) continue;
          var playerFaction = player.GetFaction();
          if (playerFaction == null)
          {
            var unselectedFactions = allFactions.Where(x => x.Status == FactionStatus.Unselected).ToList();
            var selectedFaction = unselectedFactions[random.Next(0, unselectedFactions.Count - 1)];
            player.SetFaction(selectedFaction);
            selectedFaction.Status = FactionStatus.Undefeated;
          }

          var possibleTeams = player.GetFaction()!.PossibleTeams!.ToList();
          player.SetTeam(possibleTeams[random.Next(0, possibleTeams.Count - 1)]);
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Failed to finalize teams for player {GetPlayerName(player)}: {ex}");
        }
      }
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