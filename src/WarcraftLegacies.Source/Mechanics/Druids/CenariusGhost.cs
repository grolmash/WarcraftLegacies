using MacroTools.LegendSystem;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WarcraftLegacies.Source.Setup.Legends;
using WCSharp.Shared.Data;

namespace WarcraftLegacies.Source.Mechanics.Druids
{
  public static class CenariusGhost
  {
    private static void Dies(object? sender, Legend legend)
    {
      var cenarius = LegendDruids.LegendCenarius;
      if (cenarius == legend && legend.UnitType == LegendDruids.UnittypeCenariusAlive)
      {
        cenarius.UnitType = LegendDruids.UnittypeCenariusGhost;
        cenarius.PermaDies = false;
        cenarius.ClearUnitDependencies();
        cenarius.ForceCreate(DruidsSetup.Druids.Player, new Point(Regions.Cenarius.Center.X, Regions.Cenarius.Center.Y),
          270);
      }
    }

    public static void Setup()
    {
      LegendDruids.LegendCenarius.OnLegendPermaDeath += Dies;
      LegendDruids.LegendCenarius.DeathMessage =
        "Cenarius, Demigod of the Night Elves, has fallen. His spirit lives on, a mere echo of his former self.";
    }
  }
}