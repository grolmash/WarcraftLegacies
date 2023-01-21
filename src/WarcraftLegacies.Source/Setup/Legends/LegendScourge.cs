﻿using MacroTools;
using MacroTools.Extensions;
using MacroTools.LegendSystem;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WCSharp.Shared.Data;
using static War3Api.Common;
using static War3Api.Blizzard;
#pragma warning disable CS1591

namespace WarcraftLegacies.Source.Setup.Legends
{
  /// <summary>
  /// Responsible for setting up and managing all <see cref="ScourgeSetup.Scourge"/> <see cref="Legend"/>s.
  /// </summary>
  public sealed class LegendScourge : IRegistersLegends
  {
    public LegendaryHero Kelthuzad { get; }
    public LegendaryHero Anubarak { get; }
    public LegendaryHero Rivendare { get; }
    public LegendaryHero Arthas { get; }
    public Capital TheFrozenThrone { get; }
    public Capital Utgarde { get; }

    /// <summary>
    /// Sets up <see cref="LegendScourge"/>.
    /// </summary>
    /// <param name="preplacedUnitSystem">A system for finding preplaced units on the map.</param>
    public LegendScourge(PreplacedUnitSystem preplacedUnitSystem)
    {
      Kelthuzad = new LegendaryHero("Kel'thuzad")
      {
        UnitType = FourCC("U001"),
        PermaDies = true,
        DeathSfx = "Abilities\\Spells\\Undead\\DeathCoil\\DeathCoilSpecialArt.mdl",
        StartingXp = 1000
      };

      Anubarak = new LegendaryHero("Anub'arak")
      {
        UnitType = FourCC("Uanb")
      };

      Rivendare = new LegendaryHero("Baron Rivendare")
      {
        UnitType = FourCC("U00A"),
        StartingXp = 1000
      };

      Arthas = new LegendaryHero("Arthas Menethil")
      {
        UnitType = Constants.UNIT_UEAR_CHAMPION_OF_THE_SCOURGE_SCOURGE,
        StartingXp = 7000
      };

      Utgarde = new Capital
      {
        Unit = preplacedUnitSystem.GetUnit(FourCC("h00O")),
        Capturable = true
      };

      TheFrozenThrone = new Capital
      {
        Unit = preplacedUnitSystem.GetUnit(FourCC("u000")),
        Hivemind = true,
        DeathMessage =
          "The great Lich King has been destroyed. With no central mind to command them, the forces of the Undead have gone rogue."
      };
      TheFrozenThrone.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_N094_ICECROWN_OBELISK_RED, new Point(-3655, 20220)));
      TheFrozenThrone.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_N094_ICECROWN_OBELISK_RED, new Point(-3015, 20762)));
      TheFrozenThrone.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_N094_ICECROWN_OBELISK_RED, new Point(-3643, 22588)));
      TheFrozenThrone.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_N094_ICECROWN_OBELISK_RED, new Point(-3638, 23374)));
      CreateTrigger()
        .RegisterUnitEvent(TheFrozenThrone.Unit, EVENT_UNIT_CHANGE_OWNER)
        .AddAction(() =>
      {
        if (TheFrozenThrone.Unit.OwningPlayer() != Player(bj_PLAYER_NEUTRAL_VICTIM))
          TheFrozenThrone.Unit.SetOwner(Player(bj_PLAYER_NEUTRAL_VICTIM));
      });
    }

    /// <inheritdoc />
    public void RegisterLegends()
    {
      LegendaryHeroManager.Register(Kelthuzad);
      LegendaryHeroManager.Register(Anubarak);
      LegendaryHeroManager.Register(Rivendare);
      LegendaryHeroManager.Register(Arthas);
      CapitalManager.Register(TheFrozenThrone);
      CapitalManager.Register(Utgarde);
    }
  }
}