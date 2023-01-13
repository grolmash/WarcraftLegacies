﻿using MacroTools;
using MacroTools.LegendSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup.Legends
{
  public static class LegendQuelthalas
  {
    public static LegendaryHero LegendAnasterian { get; private set; }
    public static LegendaryHero LegendRommath { get; private set; }
    public static LegendaryHero LegendJennalla { get; private set; }
    public static LegendaryHero LegendSylvanas { get; private set; }
    public static LegendaryHero LegendKael { get; private set; }
    public static LegendaryHero LegendLorthemar { get; private set; }
    public static LegendaryHero LegendKiljaeden { get; private set; }
    public static LegendaryHero LegendPathaleon { get; private set; }
    public static Capital LegendSilvermoon { get; private set; }
    public static Capital LegendSunwell { get; private set; }

    public static void Setup(PreplacedUnitSystem preplacedUnitSystem)
    {
      LegendSilvermoon = new Capital()
      {
        Unit = preplacedUnitSystem.GetUnit(FourCC("h003")),
        DeathMessage = "The grand city of the high elves, Silvermoon, has been crushed by her enemies."
      };
      CapitalManager.Register(LegendSilvermoon);
      LegendSilvermoon.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H00D_ELVEN_RUNESTONE_QUEL_THALAS_TOWER, new Point(20479, 17477)));
      LegendSilvermoon.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H00D_ELVEN_RUNESTONE_QUEL_THALAS_TOWER, new Point(17415, 13196)));

      LegendSunwell = new Capital
      {
        Unit = preplacedUnitSystem.GetUnit(Constants.UNIT_N001_THE_SUNWELL_QUEL_THALAS_OTHER),
        Capturable = true
      };
      CapitalManager.Register(LegendSunwell);
      LegendSunwell.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H00D_ELVEN_RUNESTONE_QUEL_THALAS_TOWER, new Point(20479, 17477)));
      LegendSunwell.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H00D_ELVEN_RUNESTONE_QUEL_THALAS_TOWER, new Point(17415, 13196)));

      LegendAnasterian = new LegendaryHero("Anasterian Sunstrider")
      {
        UnitType = Constants.UNIT_H00Q_KING_OF_QUEL_THALAS_QUEL_THALAS,
        PlayerColor = PLAYER_COLOR_MAROON,
        StartingXp = 1000,
        StartingArtifactItemTypeIds = new[]
        {
          Constants.ITEM_I00J_FELO_MELORN
        }
      };
      LegendAnasterian.AddUnitDependency(LegendSunwell.Unit);
      LegendaryHeroManager.Register(LegendAnasterian);

      LegendRommath = new LegendaryHero("Grand Magister Rommath")
      {
        UnitType = Constants.UNIT_H04F_ARCHMAGE_GREEN,
        StartingXp = 1800
      };
      LegendaryHeroManager.Register(LegendRommath);

      LegendJennalla = new LegendaryHero("Jennalla")
      {
        UnitType = Constants.UNIT_H02B_ARCANE_PHANTOM_KHADGAR
      };
      LegendaryHeroManager.Register(LegendJennalla);

      LegendPathaleon = new LegendaryHero("Pathaleon")
      {
        UnitType = Constants.UNIT_H098_SUNFURY_MASTERMIND_HIGH_ELVES,
        StartingXp = 1800
      };
      LegendaryHeroManager.Register(LegendPathaleon);

      LegendSylvanas = new LegendaryHero("Sylvanas Windrunner")
      {
        UnitType = Constants.UNIT_HVWD_RANGER_GENERAL_OF_SILVERMOON_QUEL_THALAS,
        PlayerColor = PLAYER_COLOR_GREEN
      };
      LegendaryHeroManager.Register(LegendSylvanas);

      LegendKael = new LegendaryHero("Kael'thas Sunstrider")
      {
        PlayerColor = PLAYER_COLOR_RED,
        UnitType = Constants.UNIT_HKAL_PRINCE_OF_QUEL_THALAS_QUEL_THALAS,
        StartingXp = 1800
      };
      LegendaryHeroManager.Register(LegendKael);

      LegendLorthemar = new LegendaryHero("Lor'themar Theron")
      {
        UnitType = Constants.UNIT_H02E_REGENT_OF_QUEL_THALAS_QUEL_THALAS_VASSAL,
        StartingXp = 2800
      };
      LegendaryHeroManager.Register(LegendLorthemar);

      LegendKiljaeden = new LegendaryHero("Kil'jaeden")
      {
        UnitType = Constants.UNIT_U004_THE_DECEIVER_LEGION,
        PermaDies = true,
        StartingXp = 10800,
        DeathMessage =
          "Kil'jaeden the Deceiver has been annihilated, but it is too late for the Blood Elves, who will continue to live and die with demonic taint coursing through their veins."
      };
      LegendaryHeroManager.Register(LegendKiljaeden);
    }
  }
}