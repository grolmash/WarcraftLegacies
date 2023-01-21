﻿using MacroTools;
using MacroTools.Spells;
using MacroTools.Spells.Slipstream;
using MacroTools.SpellSystem;
using WCSharp.Shared.Data;

namespace WarcraftLegacies.Source.Setup.Spells
{
  public static class LegionSpellSetup
  {
    public static void Setup()
    {
      var darkPact = new DarkPact(Constants.ABILITY_A0A0_DARK_PACT_LEGION_ARCHIMONDE);
      SpellSystem.Register(darkPact);
      
      var inspireMadness = new InspireMadness(Constants.ABILITY_A10M_INSPIRE_MADNESS_LEGION_TICHONDRIUS)
      {
        Radius = 400,
        CountBase = 2,
        CountLevel = 4,
        Duration = 16,
        Effect = @"war3mapImported\Call of Dread Purple.mdx",
        EffectScale = 1.1f,
        EffectTarget = @"Abilities\Spells\Other\Charm\CharmTarget.mdl",
        EffectScaleTarget = 0.5f
      };
      SpellSystem.Register(inspireMadness);
      
      var summonBurningLegion = new SummonLegionSpell(Constants.ABILITY_A00J_SUMMON_THE_BURNING_LEGION_ALL_FACTIONS,
        Constants.ABILITY_A0KZ_SPELL_IMMUNITY_LEGION_SUMMON)
      {
      };
      SpellSystem.Register(summonBurningLegion);

      //Northrend
      SpellSystem.Register(new SlipstreamSpellSpecificLocation(Constants.ABILITY_A0UB_OPEN_A_PORTAL_TO_NORTHREND_LEGION_NORTHREND)
      {
        PortalUnitTypeId = Constants.UNIT_N0D9_SLIPSTREAM_PORTAL_STORMWIND_KHADGAR,
        OpeningDelay = 10,
        ClosingDelay = 5,
        TargetLocation = new Point(3578, 20707),
        Color = new Color(55, 50, 250, 255)
      });

      //Alterac
      SpellSystem.Register(new SlipstreamSpellSpecificLocation(Constants.ABILITY_A0UC_OPEN_A_PORTAL_TO_ALTERAC_LEGION_ALTERAC)
      {
        PortalUnitTypeId = Constants.UNIT_N0D9_SLIPSTREAM_PORTAL_STORMWIND_KHADGAR,
        OpeningDelay = 10,
        ClosingDelay = 5,
        TargetLocation = new Point(11366, 5802),
        Color = new Color(155, 250, 50, 255)
      });
    }
  }
}