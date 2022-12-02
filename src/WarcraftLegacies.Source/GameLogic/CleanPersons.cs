using MacroTools.Cheats;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.GameLogic
{
  /// <summary>
  /// Responsible for ensuring that unoccupied player slots do not persist in the game.
  /// </summary>
  public static class CleanPersons
  {
    /// <summary>
    ///   After a short delay, removes players from the game if their slot is unoccupied.
    /// </summary>
    public static void Setup()
    {
      var trig = CreateTrigger();
      TriggerRegisterTimerEvent(trig, 2, false);
      TriggerAddAction(trig, () =>
      {
        if (TestMode.AreCheatsActive) return;

        foreach (var player in WCSharp.Shared.Util.EnumeratePlayers())
        {
          var playerFaction = player.GetFaction();
          if (playerFaction == null) continue;
          if (GetPlayerSlotState(player) != PLAYER_SLOT_STATE_PLAYING &&
              playerFaction.Status == FactionStatus.Undefeated)
            playerFaction.Status = FactionStatus.Defeated;
        }
      });
    }
  }
}