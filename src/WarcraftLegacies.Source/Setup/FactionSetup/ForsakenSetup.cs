﻿using MacroTools.FactionSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup.FactionSetup
{
  public static class ForsakenSetup
  {
    public static Faction? Forsaken { get; private set; }
    
    public static void Setup(TeamSetup teamSetup)
    {
      Forsaken = new Faction("Cult", PLAYER_COLOR_LIGHT_BLUE, "|cff8080ff",
        "ReplaceableTextures\\CommandButtons\\BTNAcolyte.blp")
      {
        StartingGold = 0,
        StartingLumber = 100,
        PossibleTeams = new[]
        {
          teamSetup.Forsaken,
          teamSetup.Scourge,
          teamSetup.Legion
        }
      };

      //Buildings
      Forsaken.ModObjectLimit(FourCC("h089"), Faction.UNLIMITED); //Necropolis
      Forsaken.ModObjectLimit(FourCC("h08A"), Faction.UNLIMITED); //Halls of the Dead
      Forsaken.ModObjectLimit(FourCC("h08B"), Faction.UNLIMITED); //Black Citadel
      Forsaken.ModObjectLimit(FourCC("h08C"), Faction.UNLIMITED); //Ziggurat
      Forsaken.ModObjectLimit(FourCC("h08D"), Faction.UNLIMITED); //Spirit Tower
      Forsaken.ModObjectLimit(FourCC("h08E"), Faction.UNLIMITED); //Nerubian Tower
      Forsaken.ModObjectLimit(FourCC("u010"), Faction.UNLIMITED); //Altar of Darkness
      Forsaken.ModObjectLimit(FourCC("u011"), Faction.UNLIMITED); //Crypt
      Forsaken.ModObjectLimit(FourCC("u01J"), Faction.UNLIMITED); //Graveyard
      Forsaken.ModObjectLimit(FourCC("u016"), Faction.UNLIMITED); //Slaughterhouse
      Forsaken.ModObjectLimit(FourCC("u01W"), Faction.UNLIMITED); //Royal Sepulcur
      Forsaken.ModObjectLimit(FourCC("u014"), Faction.UNLIMITED); //Temple of the Damned
      Forsaken.ModObjectLimit(FourCC("u017"), Faction.UNLIMITED); //Tomb of Relics
      Forsaken.ModObjectLimit(FourCC("u01A"), Faction.UNLIMITED); //Undead Shipyard
      Forsaken.ModObjectLimit(FourCC("h08F"), Faction.UNLIMITED); //Improved Spirit Tower

      //Units
      Forsaken.ModObjectLimit(FourCC("u01K"), Faction.UNLIMITED); //Acolyte
      Forsaken.ModObjectLimit(FourCC("h08O"), Faction.UNLIMITED); //Ghoul
      Forsaken.ModObjectLimit(FourCC("h08N"), Faction.UNLIMITED); //Abomination
      Forsaken.ModObjectLimit(FourCC("u01P"), 6); //Plague Catapult
      Forsaken.ModObjectLimit(FourCC("n07S"), Faction.UNLIMITED); //Deadeye
      Forsaken.ModObjectLimit(FourCC("h08P"), Faction.UNLIMITED); //Sorceress
      Forsaken.ModObjectLimit(FourCC("u01R"), Faction.UNLIMITED); //Apothecary

      Forsaken.ModObjectLimit(FourCC("u02G"), 12); //Undercity Guardian
      Forsaken.ModObjectLimit(FourCC("n07V"), 6); //Elder Banshee
      Forsaken.ModObjectLimit(FourCC("o05H"), 8); //PlagueFlyer
      Forsaken.ModObjectLimit(FourCC("n0BY"), 6); //dread knight
      Forsaken.ModObjectLimit(FourCC("u01V"), 2); //Valyr
      Forsaken.ModObjectLimit(FourCC("ubot"), Faction.UNLIMITED); //Undead Transport Ship
      Forsaken.ModObjectLimit(FourCC("udes"), Faction.UNLIMITED); //Undead Frigate
      Forsaken.ModObjectLimit(FourCC("uubs"), 6); //Undead Battleship
      Forsaken.ModObjectLimit(Constants.UNIT_N07W_PLAGUE_REVENANT_FORSAKEN, 12);

      Forsaken.ModObjectLimit(FourCC("U01O"), 1); //Putress
      Forsaken.ModObjectLimit(FourCC("Usyl"), 1); //Sylvanas
      Forsaken.ModObjectLimit(FourCC("U02I"), 1); //Farenell

      //Upgrades
      Forsaken.ModObjectLimit(FourCC("Ruba"), Faction.UNLIMITED); //Banshee Adept Training
      Forsaken.ModObjectLimit(FourCC("R05C"), Faction.UNLIMITED); //Banshee Adept Training
      Forsaken.ModObjectLimit(FourCC("R051"), Faction.UNLIMITED); //Apotechary Training
      Forsaken.ModObjectLimit(FourCC("R02X"), Faction.UNLIMITED); // Open Scholomance
      Forsaken.ModObjectLimit(FourCC("R02A"), Faction.UNLIMITED); //Chaos Infusion
      Forsaken.ModObjectLimit(Constants.UPGRADE_R08T_SPLIT_SOUL_FORSAKEN, Faction.UNLIMITED);

      Forsaken.ConfigureStartingFeatures(Player(9));
      FactionManager.Register(Forsaken);
    }
  }
}