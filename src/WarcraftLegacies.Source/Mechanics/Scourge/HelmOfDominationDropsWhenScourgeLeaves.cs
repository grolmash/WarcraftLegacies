using MacroTools;
using MacroTools.ArtifactSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.LegendSystem;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Mechanics.Scourge
{
  /// <summary>
  ///  When Scourge leaves the game, drop the Helm of Domination to an easily accessible position since the default position is hard to see.
  /// </summary>
  public static class HelmOfDominationDropsWhenScourgeLeaves
  {
    private static Artifact? _helmOfDomination;
    private static trigger? _deathTrigger;
    private static Capital? _lichKing;

    /// <summary>
    /// Sets up <see cref="HelmOfDominationDropsWhenScourgeLeaves"/>.
    /// </summary>
    public static void Setup(Artifact helmOfDomination, Capital lichKing)
    {
      if (ScourgeSetup.Scourge == null)
        throw new SystemNotInitializedException(nameof(ScourgeSetup));

      _lichKing = lichKing;

      _deathTrigger = CreateTrigger()
        .RegisterUnitEvent(lichKing.Unit, EVENT_UNIT_DEATH)
        .AddAction(() =>
        {
          CheckHelmOfDomination();
          UnregisterEvents();
        });

      ScourgeSetup.Scourge.LeftGame += OnScourgeLeaveGame;
      _helmOfDomination = helmOfDomination;
    }

    private static void OnScourgeLeaveGame(object? sender, Faction faction)
    {
      CheckHelmOfDomination();
      UnregisterEvents();
    }

    private static void UnregisterEvents()
    {
      _deathTrigger?.Destroy();
      if (ScourgeSetup.Scourge != null)
        ScourgeSetup.Scourge.LeftGame -= OnScourgeLeaveGame;
    }

    private static void CheckHelmOfDomination()
    {
      if (_lichKing?.Unit == null)
        return;

      var lichKingPosition = _lichKing.Unit.GetPosition();
      _lichKing.Unit.DropAllItems();
      _helmOfDomination?.Item.SetPosition(new Point(lichKingPosition.X - 55,
        lichKingPosition.Y + 30));
    }
  }
}