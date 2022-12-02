using System;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace MacroTools.Cheats
{
  public static class CheatKick
  {
    private const string Command = "-kick ";
    private static string? _parameter;

    private static void Actions()
    {
      try
      {
        if (!TestMode.CheatCondition()) return;

        string enteredString = GetEventPlayerChatString();
        player p = GetTriggerPlayer();

        _parameter = SubString(enteredString, StringLength(Command), StringLength(enteredString));
        var kickId = S2I(_parameter);

        var faction = PlayerData.ByHandle(Player(kickId)).Faction;
        if (faction != null)
          faction.Status = FactionStatus.Defeated;
        DisplayTextToPlayer(p, 0, 0,
          "|cffD27575CHEAT:|r Attempted to kick player " + GetPlayerName(Player(kickId)) + ".");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
      }
    }

    public static void Setup()
    {
      trigger trig = CreateTrigger();
      foreach (var player in WCSharp.Shared.Util.EnumeratePlayers()) TriggerRegisterPlayerChatEvent(trig, player, Command, false);

      TriggerAddAction(trig, Actions);
    }
  }
}