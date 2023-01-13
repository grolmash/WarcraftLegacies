﻿using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Sentinels
{
  /// <summary>
  /// Destroy Orgrimmar to unlock the Watcher Bastion as a building.
  /// </summary>
  public sealed class QuestSentinelsKillWarsong : QuestData
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="QuestSentinelsKillWarsong"/> class.
    /// </summary>
    public QuestSentinelsKillWarsong() : base("Green-skinned Brutes",
      "The Warsong Clan has arrived near Ashenvale and begun threatening the wilds. These invaders must be repelled.",
      "ReplaceableTextures\\CommandButtons\\BTNRaider.blp")
    {
      AddObjective(new ObjectiveCapitalDead(LegendWarsong.Orgrimmar));
      ResearchId = Constants.UPGRADE_R007_QUEST_COMPLETED_GREEN_SKINNED_BRUTES_SENTINELS;
      Required = true;
    }

    /// <inheritdoc/>
    protected override string RewardFlavour =>
      "The Warsong presence on Kalimdor has been eliminated. The land has been protected from their misbegotten race.";

    /// <inheritdoc/>
    protected override string RewardDescription => "Allows the construction of the Watcher's Bastion";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      SetPlayerTechResearched(completingFaction.Player, ResearchId, 1);
    }

    /// <inheritdoc/>
    protected override void OnAdd(Faction whichFaction)
    {
      whichFaction.ModObjectLimit(ResearchId, Faction.UNLIMITED);
    }
  }
}