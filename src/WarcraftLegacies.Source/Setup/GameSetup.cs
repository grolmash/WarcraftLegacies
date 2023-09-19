﻿using MacroTools;
using MacroTools.CommandSystem;
using MacroTools.ControlPointSystem;
using MacroTools.FactionSystem;
using MacroTools.Mechanics;
using MacroTools.PassiveAbilitySystem;
using MacroTools.UserInterface;
using WarcraftLegacies.Source.ArtifactBehaviour;
using WarcraftLegacies.Source.GameLogic;
using WarcraftLegacies.Source.GameLogic.GameEnd;
using WarcraftLegacies.Source.Mechanics.Druids;
using WarcraftLegacies.Source.Mechanics.Frostwolf;
using WarcraftLegacies.Source.Mechanics.Scourge;
using WarcraftLegacies.Source.Mechanics.Scourge.Blight;
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
      var introSeconds = 30;
      var displayIntroText = new DisplayIntroText((introSeconds / 2) - 5);
      var cinematicMode = new CinematicMode(introSeconds + 2, displayIntroText);
      var gameTime = new GameTime(introSeconds);
      SetupControlPointManager();
      var preplacedUnitSystem = new PreplacedUnitSystem();
      SoundLibrary.Setup();
      var artifactSetup = new ArtifactSetup(preplacedUnitSystem);
      var allLegendSetup = new AllLegendSetup(preplacedUnitSystem, artifactSetup);
      allLegendSetup.RegisterLegends(preplacedUnitSystem);
      ShoreSetup.Setup();
      ControlPointSetup.Setup();
      InstanceSetup.Setup(preplacedUnitSystem);
      TeamSetup.Setup();
      AllFactionSetup.Setup(preplacedUnitSystem, artifactSetup);
      SharedFactionConfigSetup.Setup();
      PlayerSetup.Setup();
      new FactionChoiceDialogPresenter(GoblinSetup.Goblin, ZandalarSetup.Zandalar).Run(Player(8), introSeconds);
      new FactionChoiceDialogPresenter(IllidariSetup.Illidari, SunfurySetup.Sunfury).Run(Player(15), introSeconds);
      new FactionChoiceDialogPresenter(DalaranSetup.Dalaran, GilneasSetup.Gilneas).Run(Player(7), introSeconds);
      NeutralHostileSetup.Setup();
      AllQuestSetup.Setup(preplacedUnitSystem, artifactSetup, allLegendSetup);
      ObserverSetup.Setup(new[] { Player(21) });
      SpellsSetup.Setup();
      var commandManager = new CommandManager();
      CommandSetup.Setup(commandManager);
      ControlPointVictory.Setup();
      FactionMultiboard.Setup();
      BookSetup.Setup();
      HintConfig.Setup();
      WaygateManager.Setup(Constants.UNIT_N0AO_WAY_GATE_DALARAN_OTHER);
      BlightSystem.Setup(ScourgeSetup.Scourge);
      BlightSetup.Setup(preplacedUnitSystem);
      QuestMenuSetup.Setup();
      cinematicMode.StartTimer();
      gameTime.StartTimer();
      CheatSetup.Setup(commandManager, cinematicMode);
      DialogueSetup.Setup(preplacedUnitSystem, allLegendSetup);
      MapFlagSetup.Setup();
      InfoQuests.Setup();
      DestructibleSetup.Setup(preplacedUnitSystem);
      ResearchSetup.Setup(preplacedUnitSystem);
      PatronSystem.Setup(preplacedUnitSystem);
      OpenAllianceVote.Setup(introSeconds);
      AugmentSetup.Setup();
      RockSetup.Setup();
      TurnResearchSetup.Setup();
      UnitTypeConfig.Setup();
      ShipyardBanZonesSetup.Setup();
      BlockerSetup.Setup();
      NeutralVictimAndPassiveSetup.Setup();
      GateSetup.Setup();
      StartingResources.Setup(introSeconds - 2);
      StartingQuestPopup.Setup(introSeconds + 3);
      RefundZeroLimitUnits.Setup();
      HeroGlowFix.Setup();
      CleanPersons.Setup();
      PlayerLeaves.Setup();
      FloatingTextSetup.Setup(introSeconds, 10);
      AmbianceSetup.Setup();
      PassiveAbilityManager.InitializePreplacedUnits();
      IncompatibleResearchSetup.Setup();
      DemonGateSetup.Setup();
      SummonRallyPoints.Setup();
      RemoveUnusedAreas.Run();
      EyeOfSargerasCooldowns.Setup();
      CapturableUnitSetup.Setup(preplacedUnitSystem);
      EyeOfSargerasPickup.Setup();
      SacrificeAcolyte.Setup();
      IntegrityChecker.Setup(true);
      PeonsStartHarvestingShips.Setup(preplacedUnitSystem);
      DarkPortalControlNexusSetup.Setup(preplacedUnitSystem);
      BlackPortalControlNexusSetup.Setup(preplacedUnitSystem);
      CenariusGhost.Setup(allLegendSetup.Druids);
      HelmOfDominationDropsWhenScourgeLeaves.Setup(artifactSetup.HelmOfDomination, allLegendSetup.Scourge.TheFrozenThrone);
      TagSummonedUnits.Setup();
    }

    private static void SetupControlPointManager()
    {
      ControlPointManager.Instance = new ControlPointManager
      {
        StartingMaxHitPoints = 1900,
        HostileStartingCurrentHitPoints = 1000,
        RegenerationAbility = Constants.ABILITY_A0UT_CP_LIFE_REGEN,
        PiercingResistanceAbility = Constants.ABILITY_A13X_PIERCING_RESISTANCE_CONTROL_POINT_TOWER,
        IncreaseControlLevelAbilityTypeId = Constants.ABILITY_A0A8_FORTIFY_CONTROL_POINTS_SHARED,
        ControlLevelSettings = new ControlLevelSettings
        {
          DefaultDefenderUnitTypeId = Constants.UNIT_H03W_CONTROL_POINT_DEFENDER_LORDAERON,
          DamageBase = 18,
          DamagePerControlLevel = 1,
          ArmorPerControlLevel = 1,
          HitPointsPerControlLevel = 70,
          ControlLevelMaximum = 20
        }
      };
    }
  }
}