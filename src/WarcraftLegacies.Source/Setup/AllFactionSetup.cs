﻿using MacroTools;
using WarcraftLegacies.Source.Setup.FactionSetup;

namespace WarcraftLegacies.Source.Setup
{
  public static class AllFactionSetup
  {
    public static void Setup(PreplacedUnitSystem preplacedUnitSystem, ArtifactSetup artifactSetup, TeamSetup teamSetup)
    {
      ScourgeSetup.Setup(preplacedUnitSystem, artifactSetup.HelmOfDomination);
      LegionSetup.Setup(preplacedUnitSystem);
      LordaeronSetup.Setup(preplacedUnitSystem);
      DalaranSetup.Setup(preplacedUnitSystem);
      QuelthalasSetup.Setup(preplacedUnitSystem);
      SentinelsSetup.Setup(preplacedUnitSystem);
      DruidsSetup.Setup(preplacedUnitSystem);
      FelHordeSetup.Setup(preplacedUnitSystem);
      FrostwolfSetup.Setup(preplacedUnitSystem);
      WarsongSetup.Setup(preplacedUnitSystem);
      StormwindSetup.Setup();
      IronforgeSetup.Setup(preplacedUnitSystem);
      KultirasSetup.Setup(preplacedUnitSystem);
      IllidariSetup.Setup();
      IllidanSetup.Setup();
      GilneasSetup.Setup();
      ZandalarSetup.Setup(preplacedUnitSystem);
      GoblinSetup.Setup();
      ScarletSetup.Setup(preplacedUnitSystem);
      ForsakenSetup.Setup();
      DraeneiSetup.Setup();
      DragonmawSetup.Setup();
    }
  }
}