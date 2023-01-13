using MacroTools.Extensions;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace MacroTools.Cheats
{
  public static class CheatControl
  {
    private const string Command = "-control ";

    private static void Actions()
    {
      if (!TestMode.CheatCondition())
      {
        return;
      }

      string enteredString = GetEventPlayerChatString();
      player p = GetTriggerPlayer();
      GetPlayerId(p);
      string parameter = SubString(enteredString, StringLength(Command), StringLength(enteredString));
      if (parameter == "all")
      {
        foreach (var player in WCSharp.Shared.Util.EnumeratePlayers())
        {
          GetTriggerPlayer().SetAllianceState(player, AllianceState.AlliedAdvUnits);
          player.SetAllianceState(GetTriggerPlayer(), AllianceState.AlliedAdvUnits);
        }

        DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r Granted control of all players.");
      }
      else
      {
        Player(S2I(parameter)).SetAllianceState(GetTriggerPlayer(), AllianceState.AlliedAdvUnits);
        GetTriggerPlayer().SetAllianceState(Player(S2I(parameter)), AllianceState.AlliedAdvUnits);
        DisplayTextToPlayer(p, 0, 0,
          "|cffD27575CHEAT:|r Granted control of player " + GetPlayerName(Player(S2I(parameter))) + ".");
      }
    }

    public static void Setup()
    {
      trigger trig = CreateTrigger();
      foreach (var player in WCSharp.Shared.Util.EnumeratePlayers())
      {
        TriggerRegisterPlayerChatEvent(trig, player, Command, false);
      }

      TriggerAddAction(trig, Actions);
    }
  }
}