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
      if (legend is not LegendaryHero cenarius) 
        return;
      cenarius.UnitType = LegendDruids.UnittypeCenariusGhost;
      cenarius.PermaDies = false;
      cenarius.ClearUnitDependencies();
      cenarius.ForceCreate(DruidsSetup.Druids.Player, new Point(Regions.Cenarius.Center.X, Regions.Cenarius.Center.Y),
        270);
    }

    public static void Setup(LegendDruids legendDruids)
    {
      legendDruids.Cenarius.PermanentlyDied += Dies;
      legendDruids.Cenarius.DeathMessage =
        "Cenarius, Demigod of the Night Elves, has fallen. His spirit lives on, a mere echo of his former self.";
    }
  }
}