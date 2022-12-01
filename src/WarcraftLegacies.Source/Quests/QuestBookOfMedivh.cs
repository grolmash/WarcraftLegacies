﻿using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WarcraftLegacies.Source.Setup;
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
    private readonly bool _isLegion;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestBookOfMedivh"/> class.
    /// </summary>
    /// <param name="bookOfMedivhPedestal">The pedestal which has the Book on it.</param>
    /// <param name="isLegion">If set to true, any hero of any level can complete the objective.</param>
    public QuestBookOfMedivh(unit bookOfMedivhPedestal, bool isLegion) : base("Book of Medivh",
      "The last remaining spellbook written by Medivh, the Last Guardian, is held securely within the dungeons of Dalaran. The spells within its pages could bring us great power.",
      @"ReplaceableTextures\CommandButtons\BTNBookOfTheDead.blp")
    {
      _isLegion = isLegion;
      _objectiveWithCompletingUnit = isLegion
        ? new ObjectiveAnyUnitInRect(Regions.Book_Retrieval, "the Book of Medivh's pedestal", true)
        : new ObjectiveHeroWithLevelInRect(12, Regions.Book_Retrieval, "the Book of Medivh's pedestal");
      if (_objectiveWithCompletingUnit is Objective objective) 
        AddObjective(objective);
      AddObjective(new ObjectiveNoOtherPlayerGetsArtifact(ArtifactSetup.BookOfMedivh));
      _bookOfMedivhPedestal = bookOfMedivhPedestal;
      Required = isLegion;
    }

    /// <inheritdoc/>
    protected override string RewardDescription => _isLegion
      ? "The Book of Medivh, which can be used to summon the full might of the Burning Legion"
      : "The Book of Medivh";

    /// <inheritdoc/>
    protected override string CompletionPopup => _isLegion
      ? $"{_objectiveWithCompletingUnit.CompletingUnitName} has retrieved the Book of Medivh from its pedestal. With its power, we can summon the full might of the Burning Legion from the depths of the Twisting Nether."
      : $"{_objectiveWithCompletingUnit.CompletingUnitName} has retrieved the Book of Medivh from its pedestal, and now prepares to harness its untold power.";

    /// <inheritdoc/>
    protected override string FailurePopup => 
      "Another faction has has retrieved the Book of Medivh from its pedestal. Hopefully they do not turn its nefarious power against us.";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      if (ArtifactSetup.BookOfMedivh != null)
        _objectiveWithCompletingUnit.CompletingUnit?.AddItemSafe(ArtifactSetup.BookOfMedivh.Item);
      _bookOfMedivhPedestal.Kill();
    }
  }
}