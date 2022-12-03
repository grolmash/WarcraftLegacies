﻿using MacroTools;
using MacroTools.FactionSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup.FactionSetup
{
  public static class DruidsSetup
  {
    public static Faction? Druids { get; private set; }

    public static void Setup(TeamSetup teamSetup, PreplacedUnitSystem preplacedUnitSystem)
    {
      Druids = new Faction("Druids", PLAYER_COLOR_BROWN, "|c004e2a04",
        "ReplaceableTextures\\CommandButtons\\BTNFurion.blp")
      {
        UndefeatedResearch = FourCC("R06E"),
        StartingGold = 150,
        StartingLumber = 500,
        CinematicMusic = "DarkAgents",
        PossibleTeams = new[]
        {
          teamSetup.NightElves,
          teamSetup.GrandAlliance
        }
      };

      Druids.ModObjectLimit(FourCC("etol"), Faction.UNLIMITED); //Tree of Life
      Druids.ModObjectLimit(FourCC("etoa"), Faction.UNLIMITED); //Tree of Ages
      Druids.ModObjectLimit(FourCC("etoe"), Faction.UNLIMITED); //Tree of Eternity
      Druids.ModObjectLimit(FourCC("emow"), Faction.UNLIMITED); //Moon Well
      Druids.ModObjectLimit(FourCC("eate"), Faction.UNLIMITED); //Altar of Elders
      Druids.ModObjectLimit(FourCC("eaoe"), Faction.UNLIMITED); //Ancient of Lore
      Druids.ModObjectLimit(FourCC("eaow"), Faction.UNLIMITED); //Ancient of Wind
      Druids.ModObjectLimit(FourCC("eaom"), Faction.UNLIMITED); //Ancient of war
      Druids.ModObjectLimit(FourCC("etrp"), Faction.UNLIMITED); //Ancient Protector
      Druids.ModObjectLimit(FourCC("e010"), Faction.UNLIMITED); //Hunter)s Hall
      Druids.ModObjectLimit(FourCC("e019"), Faction.UNLIMITED); //Ancient of Wonders
      Druids.ModObjectLimit(FourCC("eshy"), Faction.UNLIMITED); //Night Elf Shipyard
      Druids.ModObjectLimit(FourCC("e000"), Faction.UNLIMITED); //Improved Ancient Protector

      Druids.ModObjectLimit(FourCC("ewsp"), Faction.UNLIMITED); //Wisp
      Druids.ModObjectLimit(FourCC("edry"), Faction.UNLIMITED); //Dryad
      Druids.ModObjectLimit(FourCC("edot"), Faction.UNLIMITED); //Druid of the Talon
      Druids.ModObjectLimit(FourCC("emtg"), 12); //Mountain Giant
      Druids.ModObjectLimit(FourCC("efdr"), 6); //Faerie Dragon
      Druids.ModObjectLimit(FourCC("edoc"), Faction.UNLIMITED); //Druid of the Claw
      Druids.ModObjectLimit(FourCC("edcm"), Faction.UNLIMITED); //Druid of the Claw bear form
      Druids.ModObjectLimit(FourCC("e00N"), 6); //Keeper of the Grove
      Druids.ModObjectLimit(FourCC("n05H"), Faction.UNLIMITED); //Furbolg
      Druids.ModObjectLimit(FourCC("n065"), 6); //Green Dragon
      Druids.ModObjectLimit(FourCC("etrs"), Faction.UNLIMITED); //Night Elf Transport Ship
      Druids.ModObjectLimit(FourCC("edes"), Faction.UNLIMITED); //Night Elf Frigate
      Druids.ModObjectLimit(FourCC("ebsh"), 6); //Night Elf Battleship

      Druids.ModObjectLimit(FourCC("Ecen"), 1); //Cenarius
      Druids.ModObjectLimit(FourCC("E00H"), 1); //Cenarius
      Druids.ModObjectLimit(FourCC("E00K"), 1); //Tortolla
      Druids.ModObjectLimit(FourCC("Efur"), 1); //Furion

      Druids.ModObjectLimit(FourCC("Redt"), Faction.UNLIMITED); //Druid of the Talon Adept Training
      Druids.ModObjectLimit(FourCC("Renb"), Faction.UNLIMITED); //Nature)s Blessing
      Druids.ModObjectLimit(FourCC("Rers"), Faction.UNLIMITED); //Resistant Skin
      Druids.ModObjectLimit(FourCC("Reuv"), Faction.UNLIMITED); //Ultravision
      Druids.ModObjectLimit(FourCC("Rews"), Faction.UNLIMITED); //Well Spring
      Druids.ModObjectLimit(FourCC("R01H"), Faction.UNLIMITED); //Malorne)s Power Infusion
      Druids.ModObjectLimit(FourCC("Redc"), Faction.UNLIMITED); //Druid of the Claw Adept Training
      Druids.ModObjectLimit(FourCC("R04E"), Faction.UNLIMITED); //Ysera)s Gift
      Druids.ModObjectLimit(FourCC("R02G"), Faction.UNLIMITED); //Emerald Flames
      Druids.ModObjectLimit(FourCC("R05X"), Faction.UNLIMITED); //Blessing of Ursoc
      Druids.ModObjectLimit(FourCC("R002"), Faction.UNLIMITED); //Blackwald Enhancement
      Druids.ModObjectLimit(FourCC("R00A"), Faction.UNLIMITED); //Improved Thorns
      Druids.ModObjectLimit(FourCC("R02T"), Faction.UNLIMITED); //Improved Moonwells
      Druids.ModObjectLimit(FourCC("R033"), Faction.UNLIMITED); //Limber Timber
      Druids.ModObjectLimit(FourCC("R046"), Faction.UNLIMITED); //Grasping Vines
      Druids.ModObjectLimit(FourCC("R047"), Faction.UNLIMITED); //Crippling Poison
      Druids.ModObjectLimit(FourCC("R048"), Faction.UNLIMITED); //Deadly Poison
      Druids.ModObjectLimit(FourCC("R008"), Faction.UNLIMITED); //Improved Natures FuryR015
      Druids.ModObjectLimit(FourCC("R015"), Constants.UPGRADE_R015_IMPROVED_MANA_FLARE_DRUIDS);

      Druids.SetObjectLevel(Constants.UPGRADE_REWS_WELL_SPRING, 1);
      
      Druids.AddGoldMine(preplacedUnitSystem.GetUnit(FourCC("ngol"), new Point(-10967, 7196)));
      Druids.ConfigureStartingFeatures(Player(11));
      
      FactionManager.Register(Druids);
    }
  }
}