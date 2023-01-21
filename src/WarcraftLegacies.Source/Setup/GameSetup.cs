﻿using MacroTools;
using MacroTools.ControlPointSystem;
using MacroTools.Mechanics;
using MacroTools.PassiveAbilitySystem;
using MacroTools.UserInterface;
using WarcraftLegacies.Source.ArtifactBehaviour;
using WarcraftLegacies.Source.GameLogic;
using WarcraftLegacies.Source.GameLogic.GameEnd;
using WarcraftLegacies.Source.Mechanics.Druids;
using WarcraftLegacies.Source.Mechanics.Frostwolf;
using WarcraftLegacies.Source.Mechanics.Neutral;
using WarcraftLegacies.Source.Mechanics.Quelthalas;
using WarcraftLegacies.Source.Mechanics.Scourge;
using WarcraftLegacies.Source.Mechanics.Scourge.Blight;
using WarcraftLegacies.Source.Rocks;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WarcraftLegacies.Source.UnitTypes;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup
{
  /// <summary>
  /// Responsible for setting up the entire game.
  /// </summary>
  public static class GameSetup
  {
    /// <summary>
    /// Initialize the entire game.
    /// </summary>
    public static void Setup()
    {
      ControlPointManager.Instance = new ControlPointManager
      {
        MaxHitpoints = 1600,
        IncreaseControlLevelAbilityTypeId = Constants.ABILITY_A0A8_FORTIFY_CONTROL_POINTS_SHARED,
        ControlLevelSettings = new ControlLevelSettings
        {
          DefaultDefenderUnitTypeId = Constants.UNIT_H03W_CONTROL_POINT_DEFENDER_LORDAERON,
          DamageBase = 12,
          DamagePerControlLevel = 1,
          ArmorPerControlLevel = 1,
          HitPointsPerControlLevel = 80,
          ControlLevelMaximum = 20
        }
      };
      var preplacedUnitSystem = new PreplacedUnitSystem();
      SoundLibrary.Setup();
      var artifactSetup = new ArtifactSetup(preplacedUnitSystem);
      var allLegendSetup = new AllLegendSetup(preplacedUnitSystem, artifactSetup);
      allLegendSetup.RegisterLegends();
      ShoreSetup.Setup();
      ControlPointSetup.Setup();
      InstanceSetup.Setup(preplacedUnitSystem);
      TeamSetup.Setup();
      AllFactionSetup.Setup(preplacedUnitSystem, artifactSetup);
      SharedFactionConfigSetup.Setup();
      PlayerSetup.Setup();
      NeutralHostileSetup.Setup();
      AllQuestSetup.Setup(preplacedUnitSystem, artifactSetup, allLegendSetup);
      ObserverSetup.Setup(new[] { Player(21) });
      SpellsSetup.Setup();
      CheatSetup.Setup();
      CommandSetup.Setup();
      ControlPointVictory.Setup();
      SilvermoonDies.Setup(allLegendSetup.Quelthalas.Sunwell);
      GameTime.Setup();
      FactionMultiboard.Setup();
      BookSetup.Setup();
      HintConfig.Setup();
      WaygateManager.Setup(Constants.UNIT_N0AO_WAY_GATE_DALARAN_OTHER);
      BlightSystem.Setup(ScourgeSetup.Scourge);
      BlightSetup.Setup(preplacedUnitSystem);
      QuestMenuSetup.Setup();
      CinematicMode.Start(59);
      DialogueSetup.Setup(preplacedUnitSystem, allLegendSetup);
      DisplayIntroText.Setup(10);
      GameSettings.Setup();
      InfoQuests.Setup();
      DestructibleSetup.Setup(preplacedUnitSystem);
      ResearchSetup.Setup(preplacedUnitSystem);
      PatronSystem.Setup(preplacedUnitSystem);
      OpenAllianceVote.Setup();
      AugmentSetup.Setup();
      RockSetup.Setup();
      TurnResearchSetup.Setup();
      UnitTypeConfig.Setup();
      ShipyardBanZones.Setup(new[]
      {
        Regions.CaerDarrowShipyard,
        Regions.Arathi_Ships,
        Regions.Auberdine_Ships,
        Regions.Kali_Ships,
        Regions.Dustwallow_Ships,
        Regions.STV_Ships,
        Regions.Fenris_ships,
        Regions.Auberdine_Ships_2,
        Regions.Outland_Ships,
        Regions.Northern_Kali_Ships,
        Regions.Stromwind_antiship,
        Regions.StratholmeShipyard,
        Regions.Gilneas_Canals,
        Regions.TwistingNether,
        Regions.Dun_Morogh_Ships,
        Regions.Northrend_ships,
        Regions.Desolace_Ships,
        Regions.South_EK_Ships,
        Regions.IcecrownShipyard,
        Regions.Loch_Modan_Ships,
        Regions.Quel_Ships_1,
        Regions.Quel_Ships_2,
        Regions.Quel_Ships_3
      });
      BlockerSetup.Setup();
      NeutralVictimAndPassiveSetup.Setup();
      GateSetup.Setup();
      StartingResources.Setup();
      StartingQuestPopup.Setup(63);
      RefundZeroLimitUnits.Setup();
      HeroGlowFix.Setup();
      CleanPersons.Setup();
      PlayerLeaves.Setup();
      FloatingTextSetup.Setup(60, 10);
      AmbianceSetup.Setup();
      PassiveAbilityManager.InitializePreplacedUnits();
      IncompatibleResearchSetup.Setup();
      DemonGateSetup.Setup();
      SummonRallyPoints.Setup();
      RemoveUnusedAreas.Run();
      EyeOfSargerasCooldowns.Setup();
      CapturableUnitSetup.Setup(preplacedUnitSystem);
      GilneasGateTowers.Setup(preplacedUnitSystem);
      EyeOfSargerasPickup.Setup();
      SacrificeAcolyte.Setup();
      IntegrityChecker.Setup(true);
      PeonsStartHarvestingShips.Setup(preplacedUnitSystem);
      DarkPortalControlNexusSetup.Setup(preplacedUnitSystem);
      BlackPortalControlNexusSetup.Setup(preplacedUnitSystem);
      CenariusGhost.Setup(allLegendSetup.Druids);
      HelmOfDominationDropsWhenScourgeLeaves.Setup(artifactSetup.HelmOfDomination, allLegendSetup.Scourge.TheFrozenThrone);
    }
  }
}