using MacroTools;
using WarcraftLegacies.Source.Setup.FactionSetup;

namespace WarcraftLegacies.Source.Setup
{
  public static class AllFactionSetup
  {
    public static void Setup(PreplacedUnitSystem preplacedUnitSystem, ArtifactSetup artifactSetup, TeamSetup teamSetup)
    {
      ScourgeSetup.Setup(teamSetup, preplacedUnitSystem, artifactSetup.HelmOfDomination);
      LegionSetup.Setup(teamSetup, preplacedUnitSystem);
      LordaeronSetup.Setup(teamSetup, preplacedUnitSystem);
      DalaranSetup.Setup(teamSetup, preplacedUnitSystem);
      QuelthalasSetup.Setup(teamSetup, preplacedUnitSystem);
      SentinelsSetup.Setup(teamSetup, preplacedUnitSystem);
      DruidsSetup.Setup(teamSetup, preplacedUnitSystem);
      FelHordeSetup.Setup(teamSetup, preplacedUnitSystem);
      FrostwolfSetup.Setup(teamSetup, preplacedUnitSystem);
      WarsongSetup.Setup(teamSetup, preplacedUnitSystem);
      StormwindSetup.Setup(teamSetup);
      IronforgeSetup.Setup(teamSetup, preplacedUnitSystem);
      KultirasSetup.Setup(teamSetup, preplacedUnitSystem);
      IllidanSetup.Setup(teamSetup);
      GilneasSetup.Setup(teamSetup);
      ZandalarSetup.Setup(teamSetup, preplacedUnitSystem);
      GoblinSetup.Setup(teamSetup);
      ScarletSetup.Setup(teamSetup, preplacedUnitSystem);
      ForsakenSetup.Setup(teamSetup);
      DraeneiSetup.Setup(teamSetup);
      DragonmawSetup.Setup(teamSetup);
      CthunSetup.Setup(teamSetup);
      TwilightSetup.Setup(teamSetup);
    }
  }
}