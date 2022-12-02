﻿using MacroTools.FactionSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup.FactionSetup
{
  /// <summary>
  /// Responsible for setting up and containing the Dragonmaw faction.
  /// </summary>
  public static class DragonmawSetup
  {
    /// <summary>
    /// Orc clan obsessed with dragons.
    /// </summary>
    public static Faction? Dragonmaw { get; private set; }

    /// <summary>
    /// up the Dragonmaw faction.
    /// </summary>
    public static void Setup()
    {
      Dragonmaw = new Faction("Dragonmaw", PLAYER_COLOR_WHEAT, "|C00FFFC01",
        "ReplaceableTextures\\CommandButtons\\BTNRedDragon.blp")
      {
        StartingGold = 250,
        StartingLumber = 500,
        IntroText = @"You are playing as the Fragmented |cffe4bc00Dragonmaw Clan.
                    |r
Your current situation is dire, the Dwarves of Ironforge will soon attack whatever is left of your clan.

Your best chance of survival is escaping to Kalimdor, Warlord Zaela has heard of a new horde forming there. 

The portal to Kalimdor will take 9 mins to summon and will only last for 60 seconds, be ready to escape when it is.

Until then, plunder as much as you can from the surrounding lands."
      };

      Dragonmaw.ModObjectLimit(FourCC("o063"), Faction.UNLIMITED); //Great Hall
      Dragonmaw.ModObjectLimit(FourCC("o064"), Faction.UNLIMITED); //Stronghold
      Dragonmaw.ModObjectLimit(FourCC("o065"), Faction.UNLIMITED); //Fortress
      Dragonmaw.ModObjectLimit(FourCC("o066"), Faction.UNLIMITED); //Altar of Storms
      Dragonmaw.ModObjectLimit(FourCC("o067"), Faction.UNLIMITED); //Barracks
      Dragonmaw.ModObjectLimit(FourCC("o068"), Faction.UNLIMITED); //War Mill
      Dragonmaw.ModObjectLimit(FourCC("o069"), Faction.UNLIMITED); //Spirit Lodge
      Dragonmaw.ModObjectLimit(FourCC("o05J"), Faction.UNLIMITED); //Bestiary
      Dragonmaw.ModObjectLimit(FourCC("o06D"), Faction.UNLIMITED); //Shipyard
      Dragonmaw.ModObjectLimit(FourCC("o06B"), Faction.UNLIMITED); //Watch Tower
      Dragonmaw.ModObjectLimit(FourCC("o06A"), Faction.UNLIMITED); //Improved Watch Tower
      Dragonmaw.ModObjectLimit(FourCC("u02N"), Faction.UNLIMITED); //Shop
      Dragonmaw.ModObjectLimit(FourCC("o06C"), Faction.UNLIMITED); //Burrow

      Dragonmaw.ModObjectLimit(FourCC("n0CP"), 2); //Black Drake
      Dragonmaw.ModObjectLimit(FourCC("o05M"), 8); //WindRider
      Dragonmaw.ModObjectLimit(FourCC("n07X"), Faction.UNLIMITED); //Fel Orc Warlock
      Dragonmaw.ModObjectLimit(FourCC("o05K"), Faction.UNLIMITED); //Fel Orc Grunt
      Dragonmaw.ModObjectLimit(FourCC("o05P"), Faction.UNLIMITED); //Fel Orc Peon
      Dragonmaw.ModObjectLimit(FourCC("n0CQ"), Faction.UNLIMITED); //Fel Orc Peon
      Dragonmaw.ModObjectLimit(FourCC("o04I"), 6); //Executioner
      Dragonmaw.ModObjectLimit(FourCC("o04K"), 6); //Demolisher
      Dragonmaw.ModObjectLimit(FourCC("n09O"), 6); //DK
      Dragonmaw.ModObjectLimit(FourCC("u01T"), Faction.UNLIMITED); //Necrolyte
      Dragonmaw.ModObjectLimit(FourCC("o05L"), Faction.UNLIMITED); //Phase Grenadier
      Dragonmaw.ModObjectLimit(FourCC("obot"), Faction.UNLIMITED); //Transport Ship
      Dragonmaw.ModObjectLimit(FourCC("odes"), Faction.UNLIMITED); //Orc Frigate
      Dragonmaw.ModObjectLimit(FourCC("ojgn"), 6); //Juggernaught

      Dragonmaw.ModObjectLimit(FourCC("O01Q"), 1); //Nekrosh
      Dragonmaw.ModObjectLimit(FourCC("O05S"), 1); //Zaela
      Dragonmaw.ModObjectLimit(FourCC("O06F"), 1); //Gorfax

      Dragonmaw.ModObjectLimit(FourCC("R023"), Faction.UNLIMITED); //Spiritual Infusion
      Dragonmaw.ModObjectLimit(FourCC("Rosp"), Faction.UNLIMITED); //Spiked Barricades
      Dragonmaw.ModObjectLimit(FourCC("R06X"), Faction.UNLIMITED); //Magic Training
      Dragonmaw.ModObjectLimit(FourCC("R06Z"), Faction.UNLIMITED); //Herald Training
      
      Dragonmaw.ConfigureStartingFeatures(Player(16));
    }
  }
}