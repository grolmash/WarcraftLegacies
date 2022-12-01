using System.Collections.Generic;
using WCSharp.Events;
using static War3Api.Common;

namespace MacroTools.Cheats
{
  public static class CheatBuild
  {
    private const string Command = "-build ";
    private static readonly List<player> PlayersWithCheat = new();

    private static bool IsCheatActive(player whichPlayer)
    {
      return PlayersWithCheat.Contains(whichPlayer);
    }

    private static void SetCheatActive(player whichPlayer, bool isActive)
    {
      if (isActive && !PlayersWithCheat.Contains(whichPlayer))
      {
        PlayersWithCheat.Add(whichPlayer);
        return;
      }

      if (!isActive && PlayersWithCheat.Contains(whichPlayer)) PlayersWithCheat.Remove(whichPlayer);
    }

    private static void Build()
    {
      if (GetIssuedOrderId() == 851976 && IsCheatActive(GetTriggerPlayer()))
      {
        UnitSetUpgradeProgress(GetTriggerUnit(), 100);
        UnitSetConstructionProgress(GetTriggerUnit(), 100);
      }
    }

    private static void Actions()
    {
      if (!TestMode.CheatCondition()) return;

      var enteredString = GetEventPlayerChatString();
      var p = GetTriggerPlayer();
      var parameter = SubString(enteredString, StringLength(Command), StringLength(enteredString));

      if (parameter == "on")
      {
        SetCheatActive(p, true);
        DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r Instant build activated.");
      }

      else if (parameter == "off")
      {
        SetCheatActive(p, false);
        DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r Instant build deactivated.");
      }
    }

    public static void Setup()
    {
      trigger trig = CreateTrigger();
      foreach (var player in WCSharp.Shared.Util.EnumeratePlayers()) TriggerRegisterPlayerChatEvent(trig, player, Command, false);

      TriggerAddAction(trig, Actions);

      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeReceivesOrder, Build);
    }
  }
}