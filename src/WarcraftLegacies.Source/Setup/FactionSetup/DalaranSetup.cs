﻿using MacroTools;
using MacroTools.FactionSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup.FactionSetup
{
  public static class DalaranSetup
  {
    public static Faction? Dalaran { get; private set; }

    public static void Setup(PreplacedUnitSystem preplacedUnitSystem)
    {
      Dalaran = new Faction("Dalaran", PLAYER_COLOR_PINK, "|c00e55bb0",
        "ReplaceableTextures\\CommandButtons\\BTNJaina.blp")
      {
        UndefeatedResearch = FourCC("R05N"),
        StartingGold = 150,
        StartingLumber = 500,
        CinematicMusic = "SadMystery",
        IntroText = @"You are playing as the wise |cffff8080Mages of Dalaran|r.

Your first order of business is to reclaim Dalaran and Shadowfang Keep, which have been encircled by monsters.

Once your territory is secured, you will need to prepare for the Plague of Undeath and the invasion of the Burning Legion. Lordaeron will surely need your help.

Your mages are the finest in Azeroth, be sure to utilize them alongside your heroes to turn the tide of battle."
      };

      //Structures
      Dalaran.ModObjectLimit(FourCC("h065"), Faction.UNLIMITED); //Refuge
      Dalaran.ModObjectLimit(FourCC("h066"), Faction.UNLIMITED); //Conclave
      Dalaran.ModObjectLimit(FourCC("h068"), Faction.UNLIMITED); //Observatory
      Dalaran.ModObjectLimit(FourCC("h063"), Faction.UNLIMITED); //Granary
      Dalaran.ModObjectLimit(FourCC("h044"), Faction.UNLIMITED); //Altar of Knowledge
      Dalaran.ModObjectLimit(FourCC("h069"), Faction.UNLIMITED); //Barracks
      Dalaran.ModObjectLimit(FourCC("h02N"), Faction.UNLIMITED); //Trade Quarters
      Dalaran.ModObjectLimit(FourCC("h036"), Faction.UNLIMITED); //Arcane Sanctuary
      Dalaran.ModObjectLimit(FourCC("h078"), Faction.UNLIMITED); //Scout Tower
      Dalaran.ModObjectLimit(FourCC("h079"), Faction.UNLIMITED); //Arcane Tower
      Dalaran.ModObjectLimit(FourCC("h07A"), Faction.UNLIMITED); //Arcane Tower (Improved)
      Dalaran.ModObjectLimit(FourCC("hvlt"), Faction.UNLIMITED); //Arcane Vault
      Dalaran.ModObjectLimit(FourCC("h076"), Faction.UNLIMITED); //Alliance Shipyard
      Dalaran.ModObjectLimit(FourCC("ndgt"), Faction.UNLIMITED); //Dalaran Tower
      Dalaran.ModObjectLimit(FourCC("n004"), Faction.UNLIMITED); //Dalaran Tower (Improved)
      Dalaran.ModObjectLimit(FourCC("h067"), Faction.UNLIMITED); //Laboratory
      Dalaran.ModObjectLimit(FourCC("n0AO"), 2); //Way Gate

      //Units
      Dalaran.ModObjectLimit(FourCC("h022"), Faction.UNLIMITED); //Shaper
      Dalaran.ModObjectLimit(FourCC("hbot"), Faction.UNLIMITED); //Alliance Transport Ship
      Dalaran.ModObjectLimit(FourCC("hdes"), Faction.UNLIMITED); //Alliance Frigate
      Dalaran.ModObjectLimit(FourCC("hbsh"), 6); //Alliance Battle Ship
      Dalaran.ModObjectLimit(FourCC("nhym"), Faction.UNLIMITED); //Hydromancer
      Dalaran.ModObjectLimit(FourCC("h032"), Faction.UNLIMITED); //Battlemage
      Dalaran.ModObjectLimit(FourCC("h02D"), Faction.UNLIMITED); //Geomancer
      Dalaran.ModObjectLimit(FourCC("h01I"), Faction.UNLIMITED); //Arcanist
      Dalaran.ModObjectLimit(FourCC("n007"), 6); //Kirin Tor
      Dalaran.ModObjectLimit(FourCC("n096"), 6); //Earth Golem
      Dalaran.ModObjectLimit(FourCC("n03E"), Faction.UNLIMITED); //Pyromancer
      Dalaran.ModObjectLimit(FourCC("n0AK"), Faction.UNLIMITED); //Sludge Flinger
      Dalaran.ModObjectLimit(FourCC("o02U"), 6); //Crystal Artillery


      //Demi-heroes
      Dalaran.ModObjectLimit(FourCC("njks"), 1); //Jailor Kassan
      Dalaran.ModObjectLimit(FourCC("Hjai"), 1); //jaina
      Dalaran.ModObjectLimit(FourCC("Hant"), 1); //antonidas

      //Upgrades
      Dalaran.ModObjectLimit(FourCC("R01I"), Faction.UNLIMITED); //Arcanist Adept Training
      Dalaran.ModObjectLimit(FourCC("R01V"), Faction.UNLIMITED); //Geomancer Adept Training
      Dalaran.ModObjectLimit(FourCC("R00E"), Faction.UNLIMITED); //Hydromancer Adept Training
      Dalaran.ModObjectLimit(FourCC("R01L"), Faction.UNLIMITED); //Magic Sentry
      Dalaran.ModObjectLimit(FourCC("R00K"), Faction.UNLIMITED); //Power Infusion
      Dalaran.ModObjectLimit(FourCC("R00D"), Faction.UNLIMITED); //Pyromancer Adept Training
      Dalaran.ModObjectLimit(FourCC("Rhac"), Faction.UNLIMITED); //Improved Masonry
      Dalaran.ModObjectLimit(FourCC("R06J"), Faction.UNLIMITED); //Improved Ooze
      Dalaran.ModObjectLimit(FourCC("R061"), Faction.UNLIMITED); //Improved Forked Lightning
      Dalaran.ModObjectLimit(FourCC("R06O"), Faction.UNLIMITED); //Improved Phase Blade
      Dalaran.ModObjectLimit(FourCC("R00J"), Faction.UNLIMITED); //Combat Tomes

      Dalaran.ModAbilityAvailability(Constants.ABILITY_A0GG_SPELL_SHIELD_SPELL_BOOK_ORANGE_KIRIN_TOR, -1); //Todo: should be global
      Dalaran.ModAbilityAvailability(Constants.ABILITY_A0WG_SPELL_SHIELD_SPELL_BOOK_ORANGE_ANTONIDAS_RED_LICH_KING, -1);
      Dalaran.ModAbilityAvailability(Constants.ABILITY_A0UG_PHASE_BLADE_AUTO_CAST_ORANGE_BARRACKS_OFF, -1); //Todo: should have a system for this
      Dalaran.SetObjectLevel(Constants.UPGRADE_R01L_MAGIC_SENTRY_DALARAN, 1);
      Dalaran.SetObjectLevel(Constants.UPGRADE_RHSE_MAGIC_SENTRY_PURPLE_GREEN_DARK_GREEN_RESEARCH, 1);
      Dalaran.ModAbilityAvailability(Constants.ABILITY_A0GA_SUMMON_GARRISON_LORDAERON, -1);
      Dalaran.ModAbilityAvailability(Constants.ABILITY_A0GD_SUMMON_GARRISON_STORMWIND, -1);
      Dalaran.ModAbilityAvailability(Constants.ABILITY_A0K5_DWARVEN_MASONRY_CASTLES_YELLOW, -1);

      Dalaran.AddGoldMine(preplacedUnitSystem.GetUnit(FourCC("ngol"), new Point(9204, 2471)));
      
      Dalaran.ConfigureStartingFeatures(Player(7));
      FactionManager.Register(Dalaran);
    }
  }
}