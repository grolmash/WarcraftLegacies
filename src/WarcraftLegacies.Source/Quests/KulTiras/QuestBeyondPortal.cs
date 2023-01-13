﻿using MacroTools.ObjectiveSystem.Objectives.FactionBased;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.Legends;

namespace WarcraftLegacies.Source.Quests.KulTiras
{
  /// <summary>
  /// Varuious Fel Horde buildings must be destroyed or controlled to unlock Fusillier. 
  /// </summary>
  public sealed class QuestBeyondPortal : QuestData
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="QuestBeyondPortal"/> class.
    /// </summary>
    public QuestBeyondPortal() : base("Beyond the Dark Portal",
      "The Orc threat from Draenor still looms over all. Eliminate every trace of the Orcs and their bases.",
      "ReplaceableTextures\\CommandButtons\\BTNDarkPortal.blp")
    {
      AddObjective(new ObjectiveCapitalDead(LegendFelHorde.LegendBlacktemple));
      AddObjective(new ObjectiveCapitalDead(LegendFelHorde.LegendHellfirecitadel));
      AddObjective(new ObjectiveCapitalDead(LegendFelHorde.LegendBlackrockspire));
      AddObjective(new ObjectiveSelfExists());
      ResearchId = Constants.UPGRADE_R085_QUEST_COMPLETED_BEYOND_THE_DARK_PORTAL;
    }

    /// <inheritdoc/>
    protected override string RewardFlavour => "The orcs are no more and we can now train Fusillier.";

    /// <inheritdoc/>
    protected override string RewardDescription => "You will be able to train Fusillier from the Castle";
  }
}