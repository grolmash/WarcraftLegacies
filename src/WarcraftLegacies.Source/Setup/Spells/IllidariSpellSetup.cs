﻿using MacroTools.PassiveAbilities;
using MacroTools.PassiveAbilitySystem;
using MacroTools.SpellSystem;

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
      PassiveAbilityManager.Register(new TakeExtraDamageOnWater(new[]
      {
        Constants.UNIT_NMYR_NAGA_MYRMIDON_ILLIDARI,
        Constants.UNIT_NNSW_NAGA_SIREN_ILLIDARI,
        Constants.UNIT_NMSC_MUR_GUL_SHADOWCASTER_ILLIDARI,
        Constants.UNIT_NNSU_SUMMONER_ILLIDARI,
        Constants.UNIT_NSNP_SNAP_DRAGON_ILLIDARI,
        Constants.UNIT_NNRG_NAGA_ROYAL_GUARD_ILLIDARI,
        Constants.UNIT_NHYC_DRAGON_TURTLE_ILLIDARI,
        Constants.UNIT_EILL_THE_BETRAYER_NAGA,
        Constants.UNIT_HVSH_SEA_WITCH,
        Constants.UNIT_E015_DEMON_HUNTER_NAGA,
        Constants.UNIT_U00S_HIGH_WARLORD_NAGA,
        Constants.UNIT_NMPE_MUR_GUL_SLAVE_ILLIDARI_NZOTH_WORKER,
        Constants.UNIT_O061_CLIFFRUNNER_MURLOC,
        Constants.UNIT_NTRH_SEA_TURTLE_HATCHLING_VASSAL_TORTOLLA,
        Constants.UNIT_NTRS_SEA_TURTLE_VASSAL_TORTOLLA,
        Constants.UNIT_H04U_DEMIGOD_DRUIDS
      }, Constants.ABILITY_A01G_AMPHIBIAN_NAGA_ABILITY)
      {
        DamageMultiplier = 3
      });
    }
  }
}