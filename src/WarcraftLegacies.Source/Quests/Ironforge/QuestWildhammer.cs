﻿using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.LegendSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Ironforge
{
  /// <summary>
  /// A quest for Ironforge to acquire Aerie Peak.
  /// </summary>
  public sealed class QuestWildhammer : QuestData
  {
    private readonly List<unit> _rescueUnits;
    private const int HeroId = Constants.UNIT_H028_THANE_OF_AERIE_PEAK_IRONFORGE;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestWildhammer"/> class.
    /// </summary>
    public QuestWildhammer(LegendaryHero magni) : base("Wildhammer Alliance",
      "The Wildhammer dwarves roam freely over the peaks of the Hinterlands. An audience with Magni himself might earn their cooperation.",
      "ReplaceableTextures\\CommandButtons\\BTNHeroGriffonWarrior.blp")
    {
      AddObjective(new ObjectiveLegendInRect(magni, Regions.Aerie_Peak, "Aerie Peak"));
      ResearchId = Constants.UPGRADE_R01C_QUEST_COMPLETED_WILDHAMMER_ALLIANCE;
      _rescueUnits = Regions.Aerie_Peak.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures);
    }
    
    /// <inheritdoc />
    protected override string RewardFlavour =>
      "Magni has spoken with Falstad Wildhammer and secured an alliance with the Wildhammer Clan.";

    /// <inheritdoc />
    protected override string RewardDescription =>
      $"Gain control of Aerie Peak, learn to train Falstad Wildhammer from the {GetObjectName(Constants.UNIT_H07B_ALTAR_OF_FORTITUDE_IRONFORGE_ALTAR)}, and gain the ability to research {GetObjectName(Constants.UPGRADE_R02K_GRYPHON_SUPERIOR_BREED_KHAZ_MODAN)} at the {GetObjectName(Constants.UNIT_HGRA_GRYPHON_AVIARY_IRONFORGE_SPECIALIST)}.";

    /// <inheritdoc />
    protected override void OnComplete(Faction completingFaction)
    {
      completingFaction.Player.RescueGroup(_rescueUnits);
    }
    
    /// <inheritdoc />
    protected override void OnFail(Faction completingFaction)
    {
      Player(PLAYER_NEUTRAL_AGGRESSIVE).RescueGroup(_rescueUnits);
    }

    /// <inheritdoc />
    protected override void OnAdd(Faction whichFaction)
    {
      whichFaction.ModObjectLimit(ResearchId, Faction.UNLIMITED);
      whichFaction.ModObjectLimit(HeroId, 1);
    }
  }
}