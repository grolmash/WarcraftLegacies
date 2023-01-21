using MacroTools.FactionSystem;
using MacroTools.LegendSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;

namespace WarcraftLegacies.Source.Quests.Legion
{
  public sealed class QuestLegionCaptureSunwell : QuestData
  {
    public QuestLegionCaptureSunwell(Capital sunwell) : base("Fall of Silvermoon",
      "The Sunwell is the source of the High Elves' immortality and magical prowess. Under control of the Scourge, it would be the source of immense necromantic power.",
      "ReplaceableTextures\\CommandButtons\\BTNOrbOfCorruption.blp")
    {
      AddObjective(new ObjectiveControlCapital(sunwell, false));
      ResearchId = Constants.UPGRADE_R054_STOLEN_POWER_LEGION_QUEST;
    }

    /// <inheritdoc/>
    protected override string RewardFlavour =>
      "The Sunwell has been captured by the Scourge. It now writhes with necromantic energy.";

    /// <inheritdoc/>
    protected override string RewardDescription => "A research improving your Dreadlords";

    /// <inheritdoc/>
    protected override void OnAdd(Faction whichFaction)
    {
      whichFaction.ModObjectLimit(ResearchId, Faction.UNLIMITED);
    }
  }
}