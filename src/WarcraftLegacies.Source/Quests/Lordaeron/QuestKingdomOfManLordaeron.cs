﻿using MacroTools.ArtifactSystem;
using MacroTools.ControlPointSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Lordaeron
{
  /// <summary>
  ///  Lordaeron has to kill the lich king, acquire various artifacts and control certain control points to get stronger units and a powered up Arthas.
  /// </summary>
  public sealed class QuestKingdomOfManLordaeron : QuestData
  {
    private readonly Artifact _crownOfLordaeron;
    private readonly Artifact _crownOfStormwind;
    private const int RewardResearchId = Constants.UPGRADE_R01N_ARATHORIAN_LEGACY_LORDAERON_STORMWIND_QUEST;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestKingdomOfManLordaeron"/> class.
    /// </summary>
    public QuestKingdomOfManLordaeron(Artifact crownOfLordaeron, Artifact crownOfStormwind) : base("Kingdom of Man",
      "Before the First War, all of humanity was united under the banner of the Arathorian Empire. Reclaim its greatness by uniting mankind once again.",
      "ReplaceableTextures\\CommandButtons\\BTNFireKingCrown.blp")
    {
      _crownOfLordaeron = crownOfLordaeron;
      _crownOfStormwind = crownOfStormwind;
      AddObjective(new ObjectiveControlLegend(LegendLordaeron.Arthas, true));
      AddObjective(new ObjectiveAcquireArtifact(crownOfLordaeron));
      AddObjective(new ObjectiveAcquireArtifact(crownOfStormwind));
      AddObjective(new ObjectiveLegendDead(LegendScourge.LegendLichking));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N010_STORMWIND_CITY_30GOLD_MIN)));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N01G_LORDAERON_CITY_30GOLD_MIN)));
      Global = true;
    }

    /// <inheritdoc/>
    protected override string CompletionPopup =>
      "The people of the Eastern Kingdoms have been united under the banner of Lordaeron. Long live High King Arthas Menethil!";

    /// <inheritdoc/>
    protected override string RewardDescription =>
      "You gain a research improving all of your units, the Crowns of Lordaeron and Stormwind are merged, and Arthas becomes High King";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      SetPlayerTechResearched(completingFaction.Player, RewardResearchId, 1);
      completingFaction.Player?.DisplayResearchAcquired(RewardResearchId, 1);
      
      if (LegendLordaeron.Arthas != null)
      {
        LegendLordaeron.Arthas.UnitType = Constants.UNIT_HARF_HIGH_KING_LORDAERON_HIGH_KING;
        LegendLordaeron.Arthas.ClearUnitDependencies();
      }

      var crownHolder = _crownOfStormwind.OwningUnit;
      
      ArtifactManager.Destroy(_crownOfLordaeron);
      ArtifactManager.Destroy(_crownOfStormwind);

      var crownOfTheEasternKingdoms = new Artifact(CreateItem(Constants.ITEM_I00U_CROWN_OF_THE_EASTERN_KINGDOMS, 0, 0))
      {
        LocationType = ArtifactLocationType.Hidden,
        LocationDescription = "Stormwind and Lordaeron Quest"
      };
      ArtifactManager.Register(crownOfTheEasternKingdoms);
      crownHolder?.AddItemSafe(crownOfTheEasternKingdoms.Item);
    }

    /// <inheritdoc/>
    protected override void OnAdd(Faction whichFaction)
    {
      whichFaction.ModObjectLimit(RewardResearchId, Faction.UNLIMITED);
    }
  }
}