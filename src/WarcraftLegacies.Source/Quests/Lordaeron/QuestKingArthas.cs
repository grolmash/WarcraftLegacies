﻿using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WarcraftLegacies.Source.Setup;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Lordaeron
{
  /// <summary>
  /// Destroying the Lich King while Arthas is under Lordaeron's control and Capital Palace is alive will result in Arthas becoming King of Lordaeron.
  /// </summary>
  public sealed class QuestKingArthas : QuestData
  {
    private readonly unit _terenas;
    private const int CompletionExperienceBonus = 2000;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestKingArthas"/> class.
    /// </summary>
    public QuestKingArthas(unit terenas) : base("Line of Succession",
      "Arthas Menethil is the one true heir of the Kingdom of Lordaeron. The only thing standing in the way of his coronation is the world-ending threat of the Scourge.",
      "ReplaceableTextures\\CommandButtons\\BTNArthas.blp")
    {
      AddObjective(new ObjectiveLegendNotPermanentlyDead(LegendLordaeron.CapitalPalace));
      AddObjective(new ObjectiveControlLegend(LegendLordaeron.Arthas, true));
      AddObjective(new ObjectiveLegendDead(LegendScourge.LegendLichking));
      AddObjective(new ObjectiveLegendInRect(LegendLordaeron.Arthas, Regions.King_Arthas_crown, "King Terenas"));
      ResearchId = Constants.UPGRADE_R08A_QUEST_COMPLETED_LINE_OF_SUCCESSION;
      _terenas = terenas;
      Required = true;
    }

    /// <inheritdoc/>
    protected override string CompletionPopup =>
      "With the Lich King eliminated, the Kingdom of Lordaeron is free of its greatest threat. King Terenas Menethil proudly abdicates in favor of his son.";

    /// <inheritdoc/>
    protected override string RewardDescription =>
      $"Arthas gains {CompletionExperienceBonus} experience and the Crown of Lordaeron, and he can no longer permanently die";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      BlzSetUnitName(LegendLordaeron.Arthas.Unit, "King of Lordaeron");
      BlzSetUnitName(_terenas, "King Emeritus Terenas Menethil");
      RemoveUnit(_terenas);
      AddHeroXP(LegendLordaeron.Arthas.Unit, CompletionExperienceBonus, true);
      LegendLordaeron.Arthas.Unit?.AddItemSafe(ArtifactSetup.ArtifactCrownlordaeron.Item);
      LegendLordaeron.Arthas.ClearUnitDependencies();
    }
  }
}