﻿using MacroTools;
using MacroTools.PassiveAbilitySystem;
using MacroTools.Spells.Slipstream;
using MacroTools.SpellSystem;
using WCSharp.Shared.Data;

namespace WarcraftLegacies.Source.Setup.Spells
{
  /// <summary>
  /// Responsible for setting up all Illidari <see cref="Spell"/>s and <see cref="PassiveAbility"/>s.
  /// </summary>
  public static class IllidariSpellSetup
  {
    /// <summary>
    /// Sets up all Illidari <see cref="Spell"/>s and <see cref="PassiveAbility"/>s.
    /// </summary>
    public static void Setup()
    {
      
      SpellSystem.Register(new SlipstreamSpellSpecificLocation(Constants.ABILITY_A07D_PORTAL_TO_BLACK_TEMPLE_ILLIDAN)
      {
        PortalUnitTypeId = Constants.UNIT_N0D9_SLIPSTREAM_PORTAL_STORMWIND_KHADGAR,
        OpeningDelay = 5,
        ClosingDelay = 10,
        TargetLocation = new Point(5030, -30000),
        Color = new Color(255, 255, 250, 255)
      });
    }
  }
}