using MacroTools.Extensions;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Commands
{
  /// <summary>
  ///   Revokes an invitation sent to a player from the sending player's <see cref="Team" />.
  /// </summary>
  public static class UninviteCommand
  {
    private const string Command = "-uninvite ";
    
    private static void Actions()
    {
      var enteredString = GetEventPlayerChatString();
      var triggerPlayer = GetTriggerPlayer();

      if (SubString(enteredString, 0, StringLength(Command)) != Command) return;
      var content = SubString(enteredString, StringLength(Command), StringLength(enteredString));
      content = StringCase(content, false);

      if (FactionManager.FactionWithNameExists(content))
      {
        var targetFaction = FactionManager.GetFromName(content);
        if (targetFaction.Player != null)
          triggerPlayer.GetTeam()?.Uninvite(targetFaction.Player);
        else
          DisplayTextToPlayer(triggerPlayer, 0, 0,
            $"There is no player with the Faction {targetFaction.ColoredName}.");
      }
      else
      {
        DisplayTextToPlayer(triggerPlayer, 0, 0, $"There is no Faction with the name {content}.");
      }
    }

    public static void Setup()
    {
      var trig = CreateTrigger();
      foreach (var player in WCSharp.Shared.Util.EnumeratePlayers()) TriggerRegisterPlayerChatEvent(trig, player, Command, false);

      TriggerAddAction(trig, Actions);
    }
  }
}