using MacroTools.FactionSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup.FactionSetup
{
  public static class TwilightSetup
  {
    public static Faction? TwilightsHammer { get; private set; }

    public static void Setup(TeamSetup teamSetup)
    {
      TwilightsHammer = new Faction("Twilight", PLAYER_COLOR_LAVENDER, "|cff9178a8",
        "ReplaceableTextures\\CommandButtons\\BTNChogall.blp")
      {
        StartingGold = 150,
        StartingLumber = 350,
        PossibleTeams = new[]
        {
          teamSetup.OldGods
        }
      };

      TwilightsHammer.ModObjectLimit(FourCC("o039"), Faction.UNLIMITED); //Great Hall
      TwilightsHammer.ModObjectLimit(FourCC("o03A"), Faction.UNLIMITED); //Stronghold
      TwilightsHammer.ModObjectLimit(FourCC("o03B"), Faction.UNLIMITED); //Fortress
      TwilightsHammer.ModObjectLimit(FourCC("o03C"), Faction.UNLIMITED); //Altar of Storms
      TwilightsHammer.ModObjectLimit(FourCC("o03D"), Faction.UNLIMITED); //Barracks
      TwilightsHammer.ModObjectLimit(FourCC("o03J"), Faction.UNLIMITED); //War Mill
      TwilightsHammer.ModObjectLimit(FourCC("o03E"), Faction.UNLIMITED); //Spirit Lodge
      TwilightsHammer.ModObjectLimit(FourCC("o03F"), Faction.UNLIMITED); //Bestiary
      TwilightsHammer.ModObjectLimit(FourCC("o03I"), Faction.UNLIMITED); //Shipyard
      TwilightsHammer.ModObjectLimit(FourCC("o03G"), Faction.UNLIMITED); //Watch Tower
      TwilightsHammer.ModObjectLimit(FourCC("o03H"), Faction.UNLIMITED); //Improved Watch Tower
      TwilightsHammer.ModObjectLimit(FourCC("u00Y"), Faction.UNLIMITED); //Shop
      TwilightsHammer.ModObjectLimit(FourCC("o03K"), Faction.UNLIMITED); //Burrow

      TwilightsHammer.ModObjectLimit(FourCC("n051"), 4); //Black Drake
      TwilightsHammer.ModObjectLimit(FourCC("o04J"), 8); //WindRider
      TwilightsHammer.ModObjectLimit(FourCC("n07X"), Faction.UNLIMITED); //Fel Orc Warlock
      TwilightsHammer.ModObjectLimit(FourCC("o01H"), Faction.UNLIMITED); //Fel Orc Grunt
      TwilightsHammer.ModObjectLimit(FourCC("o04B"), Faction.UNLIMITED); //Fel Orc Peon
      TwilightsHammer.ModObjectLimit(FourCC("n083"), Faction.UNLIMITED); //Horde Cavarly
      TwilightsHammer.ModObjectLimit(FourCC("o04I"), 6); //Executioner
      TwilightsHammer.ModObjectLimit(FourCC("o04K"), 6); //Demolisher
      TwilightsHammer.ModObjectLimit(FourCC("n09O"), 6); //DK
      TwilightsHammer.ModObjectLimit(FourCC("u01T"), Faction.UNLIMITED); //Necrolyte
      TwilightsHammer.ModObjectLimit(FourCC("n087"), Faction.UNLIMITED); //Phase Grenadier
      TwilightsHammer.ModObjectLimit(FourCC("obot"), 12); //Transport Ship
      TwilightsHammer.ModObjectLimit(FourCC("odes"), 12); //Orc Frigate
      TwilightsHammer.ModObjectLimit(FourCC("ojgn"), 6); //Juggernaught

      TwilightsHammer.ModObjectLimit(FourCC("O01P"), 1); //Chogall
      TwilightsHammer.ModObjectLimit(FourCC("H08Q"), 1); //Azil
      TwilightsHammer.ModObjectLimit(FourCC("U01S"), 1); //Feludius
      TwilightsHammer.ModObjectLimit(FourCC("O04H"), 1); //ignacius


      TwilightsHammer.ModObjectLimit(FourCC("R023"), Faction.UNLIMITED); //Spiritual Infusion
      TwilightsHammer.ModObjectLimit(FourCC("Rosp"), Faction.UNLIMITED); //Spiked Barricades
      TwilightsHammer.ModObjectLimit(FourCC("R06X"), Faction.UNLIMITED); //Magic Training
      TwilightsHammer.ModObjectLimit(FourCC("R06Z"), Faction.UNLIMITED); //Herald Training

      FactionManager.Register(TwilightsHammer);
    }
  }
}