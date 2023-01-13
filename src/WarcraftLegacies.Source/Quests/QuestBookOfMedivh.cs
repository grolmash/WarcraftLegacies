﻿using MacroTools.ArtifactSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem;
using MacroTools.ObjectiveSystem.Objectives.ArtifactBased;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.ObjectiveSystem.Objectives.UnitBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests
{
  /// <summary>
  /// Any player approaches the Book of Medivh to acquire it.
  /// </summary>
  public sealed class QuestBookOfMedivh : QuestData
  {
    private readonly IHasCompletingUnit _objectiveWithCompletingUnit;
    private readonly unit _bookOfMedivhPedestal;
    private readonly bool _bypassLevelRequirement;
    private readonly Artifact _bookOfMedivh;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestBookOfMedivh"/> class.
    /// </summary>
    /// <param name="bookOfMedivhPedestal">The pedestal which has the Book on it.</param>
    /// <param name="bookOfMedivh">Reward for completing the quest.</param>
    /// <param name="bypassLevelRequirement">If set to true, any hero of any level can complete the objective.</param>
    /// <param name="bypassDestructionRequirement">If true, Dalaran does not need to be destroyed to complete the quest.</param>
    public QuestBookOfMedivh(unit bookOfMedivhPedestal, Artifact bookOfMedivh, bool bypassLevelRequirement = false, bool bypassDestructionRequirement = false) : base("Book of Medivh",
      "The last remaining spellbook written by Medivh, the Last Guardian, is held securely within the dungeons of Dalaran. The spells within its pages could bring us great power.",
      @"ReplaceableTextures\CommandButtons\BTNBookOfTheDead.blp")
    {
      _bypassLevelRequirement = bypassLevelRequirement;
      _bookOfMedivh = bookOfMedivh;
       _objectiveWithCompletingUnit = bypassLevelRequirement
         ? new ObjectiveAnyUnitInRect(Regions.BookRetrieval, "the Book of Medivh's pedestal", true)
         : new ObjectiveHeroWithLevelInRect(12, Regions.BookRetrieval, "the Book of Medivh's pedestal");
      if (_objectiveWithCompletingUnit is Objective objective) 
        AddObjective(objective);
      AddObjective(new ObjectiveNoOtherPlayerGetsArtifact(bookOfMedivh));
      if (!bypassDestructionRequirement)
        AddObjective(new ObjectiveCapitalDead(LegendDalaran.LegendDalaranCapital));
      _bookOfMedivhPedestal = bookOfMedivhPedestal;
      Required = bypassLevelRequirement;
    }

    /// <inheritdoc/>
    protected override string RewardDescription => _bypassLevelRequirement
      ? "The Book of Medivh, which can be used to summon the full might of the Burning Legion"
      : "The Book of Medivh";

    /// <inheritdoc/>
    protected override string RewardFlavour => _bypassLevelRequirement
      ? $"{_objectiveWithCompletingUnit.CompletingUnitName} has retrieved the Book of Medivh from its pedestal. With its power, we can summon the full might of the Burning Legion from the depths of the Twisting Nether."
      : $"{_objectiveWithCompletingUnit.CompletingUnitName} has retrieved the Book of Medivh from its pedestal, and now prepares to harness its untold power.";

    /// <inheritdoc/>
    protected override string PenaltyFlavour => 
      "Another faction has retrieved the Book of Medivh from its pedestal. Hopefully they do not turn its nefarious power against us.";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      _objectiveWithCompletingUnit.CompletingUnit?.AddItemSafe(_bookOfMedivh.Item);
      _bookOfMedivhPedestal.Kill();
    }
  }
}