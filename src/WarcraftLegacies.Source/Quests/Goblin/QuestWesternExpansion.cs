using System.Collections.Generic;
using MacroTools.LegendSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Goblin
{
  public sealed class QuestWesternExpansion : QuestData
  {
    /// <inheritdoc/>
    protected override string RewardFlavour =>
      "The western shores are now clear of pesky elves, our business expansion can continue and our Zeppelins can fly safe.";

    /// <inheritdoc/>
    protected override string RewardDescription => $"Learn to train {GetObjectName(Constants.UNIT_H091_WAR_ZEPPELIN_GOBLIN)}s";

    public QuestWesternExpansion(IEnumerable<Capital> capitalTargets) : base("Western Expansion",
      "Feathermoon Stronghold and Auberdine give the Elves a grip on the western shore of Kalimdor. We need to destroy them to clear a way for our business expansion west!",
      "ReplaceableTextures\\CommandButtons\\BTNNightElfShipyard.blp")
    {
      foreach (var capital in capitalTargets)
        AddObjective(new ObjectiveCapitalDead(capital));
      ResearchId = Constants.UPGRADE_R07Y_QUEST_COMPLETED_WESTERN_EXPANSION;
    }
  }
}