using MacroTools;
using MacroTools.ArtifactSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WarcraftLegacies.Source.Setup.Legends;
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

    /// <summary>
    /// Sets up <see cref="HelmOfDominationDropsWhenScourgeLeaves"/>.
    /// </summary>
    public static void Setup(Artifact helmOfDomination)
    {
      if (LegendScourge.LegendLichking == null)
        throw new SystemNotInitializedException(nameof(LegendScourge));
      if (ScourgeSetup.Scourge == null)
        throw new SystemNotInitializedException(nameof(ScourgeSetup));

      _deathTrigger = CreateTrigger()
        .RegisterUnitEvent(LegendScourge.LegendLichking.Unit, EVENT_UNIT_DEATH)
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
      _deathTrigger.Destroy();
      if (ScourgeSetup.Scourge != null)
        ScourgeSetup.Scourge.LeftGame -= OnScourgeLeaveGame;
    }

    private static void CheckHelmOfDomination()
    {
      if (LegendScourge.LegendLichking?.Unit == null)
        return;

      var lichKingPosition = LegendScourge.LegendLichking.Unit.GetPosition();
      LegendScourge.LegendLichking.Unit.DropAllItems();
      _helmOfDomination.Item.SetPosition(new Point(lichKingPosition.X - 55,
        lichKingPosition.Y + 30));
    }
  }
}