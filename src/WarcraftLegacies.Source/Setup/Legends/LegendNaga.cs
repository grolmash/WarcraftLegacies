﻿using MacroTools.LegendSystem;
using static War3Api.Common;
#pragma warning disable CS1591

namespace WarcraftLegacies.Source.Setup.Legends
{
  public sealed class LegendNaga : IRegistersLegends
  {
    public LegendaryHero Illidan { get; }
    public LegendaryHero Vashj { get; }
    public LegendaryHero Najentus { get; }
    public LegendaryHero Azshara { get; }
    public LegendaryHero Altruis { get; }
    public LegendaryHero Akama { get; }

    public LegendNaga()
    {
      Illidan = new LegendaryHero("Illidan")
      {
        UnitType = Constants.UNIT_EEVI_BETRAYER_ILLIDARI,
        PlayerColor = PLAYER_COLOR_PURPLE
      };

      Vashj = new LegendaryHero("Lady Vashj")
      {
        UnitType = FourCC("Hvsh"),
      };

      Azshara = new LegendaryHero("Azshara")
      {
        UnitType = FourCC("H08U")
      };

      Najentus = new LegendaryHero("Warlord Najentus")
      {
        UnitType = FourCC("U00S"),
        StartingXp = 2800
      };

      Altruis = new LegendaryHero("Altruis")
      {
        UnitType = FourCC("E015")
      };

      Akama = new LegendaryHero("Akama")
      {
        UnitType = FourCC("Naka"),
        StartingXp = 4000
      };
    }

    /// <inheritdoc />
    public void RegisterLegends()
    {
      LegendaryHeroManager.Register(Illidan);
      LegendaryHeroManager.Register(Vashj);
      LegendaryHeroManager.Register(Najentus);
      LegendaryHeroManager.Register(Azshara);
      LegendaryHeroManager.Register(Altruis);
      LegendaryHeroManager.Register(Akama);
    }
  }
}