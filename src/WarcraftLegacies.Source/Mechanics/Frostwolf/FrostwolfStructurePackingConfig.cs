﻿using MacroTools.Mechanics;

namespace WarcraftLegacies.Source.Mechanics.Frostwolf
{
  /// <summary>
  /// Config file for setting up the packable structures for the Frostwolf faction
  /// </summary>
  public sealed class FrostwolftructurePackingConfig
  {
    /// <summary>
    /// Setup each packable structure for the Frostwolf faction
    /// </summary>
    public static void Setup()
    {
      StructurePacking.PackableStructure.Register(Constants.UNIT_OGRE_GREAT_HALL_FROSTWOLF, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A00O_UNPACK_GREAT_HALL_PACK_KODO,"buildings\\Orc\\GreatHall\\GreatHall.mdx");
      StructurePacking.PackableStructure.Register(Constants.UNIT_OSTR_STRONGHOLD_FROSTWOLF, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A0EU_UNPACK_STRONGHOLD_PACK_KODO, "buildings\\Orc\\GreatHall\\GreatHall.mdx");
      StructurePacking.PackableStructure.Register(Constants.UNIT_OFRT_FORTRESS_FROSTWOLF, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A0ET_UNPACK_FORTRESS_PACK_KODO, "buildings\\Orc\\GreatHall\\GreatHall.mdx");
      StructurePacking.PackableStructure.Register(Constants.UNIT_OFOR_WAR_MILL_FROSTWOLF, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A0D9_UNPACK_WAR_MILL_PACK_KODO, "buildings\\Orc\\WarMill\\WarMill.mdx");
      StructurePacking.PackableStructure.Register(Constants.UNIT_OALT_ALTAR_OF_STORMS_FROSTWOLF, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A0E4_UNPACK_ALTAR_OF_STORMS_PACK_KODO, "buildings\\Orc\\AltarofStorms\\AltarofStorms.mdx");
      StructurePacking.PackableStructure.Register(Constants.UNIT_OBAR_WAR_CAMP_FROSTWOLF, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A02U_UNPACK_WAR_CAMP_PACK_KODO, "buildings\\Orc\\OrcBarracks\\OrcBarracks.mdx");
      StructurePacking.PackableStructure.Register(Constants.UNIT_OTTO_TAUREN_TOTEM_FROSTWOLF, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A09Z_UNPACK_TAUREN_TOTEM_PACK_KODO, "buildings\\Orc\\TaurenTotem\\TaurenTotem.mdx");
      StructurePacking.PackableStructure.Register(Constants.UNIT_OSLD_SPIRIT_LODGE_FROSTWOLF, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A09H_UNPACK_SPIRIT_LODGE_PACK_KODO, "buildings\\Orc\\SpiritLodge\\SpiritLodge.mdx");
      StructurePacking.PackableStructure.Register(Constants.UNIT_OTRB_BURROW_FROSTWOLF, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A0EV_UNPACK_BURROW_PACK_KODO, "buildings\\Orc\\TrollBurrow\\TrollBurrow.mdx");
      StructurePacking.PackableStructure.Register(Constants.UNIT_OSHY_HORDE_PIER_FROSTWOLF, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A0EX_UNPACK_HORDE_PIER_PACK_KODO, "buildings\\other\\GoblinShipyard\\GoblinShipyard.mdx");
      StructurePacking.PackableStructure.Register(Constants.UNIT_O01M_ENGINEER_S_GUILD_GOBLIN, Constants.UNIT_OOSC_PACK_KODO_FROSTWOLF, Constants.ABILITY_A07D_UNPACK_GOBLIN_LABORATORY_PACK_KODO, "war3mapImported\\Building_GoblinOutpost.mdl");
    }
  }
}