using System.Collections.Generic;
using WCSharp.Events;
using static War3Api.Common;

namespace MacroTools.Cheats
{
  public static class CheatNocd
  {
    private const string Command = "-nocd ";
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

    private static void Spell()
    {
      if (IsCheatActive(GetTriggerPlayer()))
        BlzEndUnitAbilityCooldown(GetTriggerUnit(), GetSpellAbilityId());
    }

    private static void Actions()
    {
      if (!TestMode.CheatCondition()) return;
      string enteredString = GetEventPlayerChatString();
      player p = GetTriggerPlayer();
      string parameter = SubString(enteredString, StringLength(Command), StringLength(enteredString));

      if (parameter == "on")
      {
        SetCheatActive(p, true);
        DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r No cooldowns activated.");
      }
      else if (parameter == "off")
      {
        SetCheatActive(p, false);
        DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r No cooldowns deactivated.");
      }
    }

    public static void Setup()
    {
      trigger trig = CreateTrigger();
      foreach (var player in WCSharp.Shared.Util.EnumeratePlayers()) TriggerRegisterPlayerChatEvent(trig, player, Command, false);
      TriggerAddAction(trig, Actions);

      PlayerUnitEvents.Register(UnitTypeEvent.SpellEndCast, Spell);
    }
  }
}