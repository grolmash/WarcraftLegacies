using static War3Api.Common;

namespace WarcraftLegacies.Source.GameLogic
{
  /// <summary>
  /// Display intro text to all players after some period of time has elapsed.
  /// </summary>
  public static class DisplayIntroText
  {
    /// <summary>
    /// Displays intro text to all players after some period of time has elapsed.
    /// </summary>
    public static void Setup()
    {
      DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, 51, @"|cffffcc00Warcraft Legacies|r
|cffaaaaaaJoin our Discord:|r discord.gg/pnWZs69
|cffff0000Support our Patreon:|r https://www.patreon.com/lordsebas
");
    }
  }
}