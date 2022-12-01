using static War3Api.Common;

namespace MacroTools.Cheats
{
  public static class CheatHasResearch
  {
    private const string Command = "-hasresearch ";

    private static void CheckResearch(player p, string parameter)
    {
      var obj = FourCC(parameter);
      DisplayTextToPlayer(p, 0, 0,
        "|cffD27575CHEAT:|r Level of research " + GetObjectName(obj) + ": " + I2S(GetPlayerTechCount(p, obj, true)));
    }

    private static void Actions()
    {
      if (!TestMode.CheatCondition()) return;

      var enteredString = GetEventPlayerChatString();
      var parameter = SubString(enteredString, StringLength(Command), StringLength(enteredString));
      CheckResearch(GetTriggerPlayer(), parameter);
    }

    public static void Setup()
    {
      var trig = CreateTrigger();
      foreach (var player in WCSharp.Shared.Util.EnumeratePlayers()) TriggerRegisterPlayerChatEvent(trig, player, Command, false);

      TriggerAddAction(trig, Actions);
    }
  }
}