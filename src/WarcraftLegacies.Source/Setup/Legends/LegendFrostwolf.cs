﻿using MacroTools;
using MacroTools.LegendSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup.Legends
{
  public static class LegendFrostwolf
  {
    public static LegendaryHero? LegendCairne { get; private set; }
    public static LegendaryHero? LegendThrall { get; private set; }
    public static LegendaryHero? LegendRexxar { get; private set; }
    public static LegendaryHero? LegendVolJin { get; private set; }
    public static Capital? LegendThunderbluff { get; private set; }
    public static Capital? LegendDarkspearhold { get; private set; }

    public static void Setup(PreplacedUnitSystem preplacedUnitSystem)
    {
      LegendCairne = new LegendaryHero("Cairne Bloodhoof")
      {
        UnitType = FourCC("Ocbh"),
        DeathMessage =
          "Cairne's spirit has passed on from this world. The Tauren have already begun to revere their fallen ancestor.",
        StartingXp = 1000
      };
      LegendaryHeroManager.Register(LegendCairne);

      LegendThrall = new LegendaryHero("Thrall")
      {
        UnitType = Constants.UNIT_OTHR_WARCHIEF_OF_THE_HORDE_FROSTWOLF,
        StartingArtifactItemTypeIds = new[]
        {
          Constants.ITEM_I004_THE_DOOMHAMMER
        }
      };
      LegendaryHeroManager.Register(LegendThrall);

      LegendThunderbluff = new Capital
      {
        Unit = preplacedUnitSystem.GetUnit(FourCC("o00J")),
        DeathMessage =
          "The mesas of Thunderbluff have been swept clean of the Tauren. The Bloodhoof are without a home."
      };
      CapitalManager.Register(LegendThunderbluff);

      LegendDarkspearhold = new Capital
      {
        Unit = preplacedUnitSystem.GetUnit(FourCC("o02D"))
      };
      CapitalManager.Register(LegendDarkspearhold);

      LegendRexxar = new LegendaryHero("Rexxar")
      {
        UnitType = FourCC("Orex"),
        StartingXp = 1800
      };
      LegendaryHeroManager.Register(LegendRexxar);

      LegendVolJin = new LegendaryHero("Vol'jin")
      {
        UnitType = Constants.UNIT_ORKN_CHIEFTAIN_OF_THE_DARKSPEAR_TRIBE_FROSTWOLF,
      };
      LegendaryHeroManager.Register(LegendVolJin);
    }
  }
}