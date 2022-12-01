﻿using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Zandalar
{

  /// <summary>
  /// Capture <see cref="LegendNeutral.Gundrak"/> to unlock a new unit
  /// </summary>
  public sealed class QuestGundrak : QuestData
  {
    private const int _gundrakResearch = Constants.UPGRADE_R02Q_QUEST_COMPLETED_THE_DRAKKARI_FORTRESS_WARSONG;
    private const int _warlordId = Constants.UNIT_NFTK_WARLORD_WARSONG;
    private const int _trollShrineId = Constants.UNIT_O04X_LOA_SHRINE_ZANDALAR;


    /// <summary>
    /// Initializes a new instance of the <see cref="QuestGundrak"/> class
    /// </summary>
    public QuestGundrak() : base("The Drakkari Fortress",
      "The Drakkari troll of Gundrak believe their fortress to be impregnable. Capture it to gain their loyalty.",
      "ReplaceableTextures\\CommandButtons\\BTNTerrorTroll.blp")
    {
      AddObjective(new ObjectiveControlLegend(LegendNeutral.Gundrak, false));
      
    }

    /// <inheritdoc/>
    protected override string CompletionPopup =>
      "Gundrak has fallen. The Drakkari trolls lend their might to the Zandalari.";

    /// <inheritdoc/>
    protected override string RewardDescription =>
      $"300 gold and the ability to train {GetObjectName(_warlordId)}s from the {GetObjectName(_trollShrineId)}.";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      if (completingFaction.Player != null)
      {
        SetPlayerTechResearched(completingFaction.Player, _gundrakResearch, 1);
        completingFaction.Player.AdjustPlayerState(PLAYER_STATE_RESOURCE_GOLD, 300);
      }
    }

    /// <inheritdoc/>
    protected override void OnAdd(Faction whichFaction)
    {
      whichFaction.ModObjectLimit(_gundrakResearch, Faction.UNLIMITED);
    }
  }
}