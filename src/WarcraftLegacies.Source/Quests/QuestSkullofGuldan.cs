﻿using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WarcraftLegacies.Source.Setup;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests
{
  /// <summary>
  /// Any player approaches the Book of Medivh to acquire it.
  /// </summary>
  public sealed class QuestSkullOfGuldan : QuestData
  {
    private readonly IHasCompletingUnit _objectiveWithCompletingUnit;
    private readonly unit _skullOfGuldanBuilding;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestSkullOfGuldan"/> class.
    /// </summary>
    /// <param name="skullOfGuldanBuilding">The pedestal with the Skull.</param>
    /// <param name="isInterested">If set to true, any hero of any level can complete the objective.</param>
    public QuestSkullOfGuldan(unit skullOfGuldanBuilding, bool isInterested) : base("The Skull of Gul'dan",
      "Khadgar managed to claim the Skull of Gul'dan and find the Book of Medivh in Outland, which Ner'zhul had left behind when he escaped through a portal. Khadgar used both artifacts to close the Dark Portal. As it crumbled, he sent the artifacts back to Azeroth via gryphon rider, which ended up in the hands of the Kirin Tor in Dalaran.",
      "ReplaceableTextures\\CommandButtons\\BTNGuldanSkull.blp")
    {
      _objectiveWithCompletingUnit = isInterested
        ? new ObjectiveAnyUnitInRect(Regions.SkullOfGuldan, "The Skull of Gul'dan's pedestal", true)
        : new ObjectiveHeroWithLevelInRect(12, Regions.SkullOfGuldan, "The Skull of Gul'dan's pedestal");
      if (_objectiveWithCompletingUnit is Objective objective)
        AddObjective(objective);
      AddObjective(new ObjectiveNoOtherPlayerGetsArtifact(ArtifactSetup.ArtifactSkullofguldan));
      AddObjective(new ObjectiveLegendDead(LegendDalaran.LegendDalaranCapital));
      _skullOfGuldanBuilding = skullOfGuldanBuilding;
    }

    /// <inheritdoc/>
    protected override string RewardDescription => "The Skull of Gul'dan";

    /// <inheritdoc/>
    protected override string CompletionPopup => $"{_objectiveWithCompletingUnit.CompletingUnitName} has retrieved the Skull of Gul'dan from its pedestal.";

    /// <inheritdoc/>
    protected override string FailurePopup => 
      "Another faction has has retrieved the Skull of Gul'dan from its pedestal. Hopefully they do not turn its nefarious power against us.";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      if (ArtifactSetup.BookOfMedivh != null)
        _objectiveWithCompletingUnit.CompletingUnit?.AddItemSafe(ArtifactSetup.ArtifactSkullofguldan.Item);
      _skullOfGuldanBuilding.Kill();
    }
  }
}