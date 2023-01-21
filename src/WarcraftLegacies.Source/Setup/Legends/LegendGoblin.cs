﻿using MacroTools;
using MacroTools.LegendSystem;
#pragma warning disable CS1591

namespace WarcraftLegacies.Source.Setup.Legends
{
  public sealed class LegendGoblin : IRegistersLegends
  {
    public LegendaryHero Gallywix { get; }
    public LegendaryHero Noggenfogger { get; }
    public LegendaryHero Gazlowe { get; }
    public Capital KezanTradingCenter { get; }

    public LegendGoblin(PreplacedUnitSystem preplacedUnitSystem)
    {
      Gallywix = new LegendaryHero("Gallywix")
      {
        UnitType = Constants.UNIT_O04N_TRADE_PRINCE_OF_THE_BILGEWATER_CARTEL_GOBLIN
      };

      Noggenfogger = new LegendaryHero("Noggenfogger")
      {
        UnitType = Constants.UNIT_NALC_BARON_OF_GADGETZAN_GOBLIN,
        StartingXp = 800
      };

      Gazlowe = new LegendaryHero("Gazlowe")
      {
        UnitType = Constants.UNIT_NTIN_CHIEF_ENGINEER_GOBLIN,
        StartingXp = 1800
      };

      KezanTradingCenter = new Capital
      {
        Unit = preplacedUnitSystem.GetUnit(Constants.UNIT_O04M_KEZAN_TRADING_CENTER_GOBLIN_SPECIAL),
        DeathMessage = "The Trade center for the Goblin Empire has fallen."
      };
      KezanTradingCenter.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_O05I_MISSILE_BATTERY_GOBLIN_TOWER));
    }

    /// <inheritdoc />
    public void RegisterLegends()
    {
      LegendaryHeroManager.Register(Gallywix);
      LegendaryHeroManager.Register(Noggenfogger);
      LegendaryHeroManager.Register(Gazlowe);
      CapitalManager.Register(KezanTradingCenter);
    }
  }
}