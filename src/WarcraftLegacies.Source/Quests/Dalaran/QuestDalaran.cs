using System.Collections.Generic;
using MacroTools.ControlPointSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Dalaran
{
  /// <summary>
  /// Dalaran acquires the city of Dalaran.
  /// </summary>
  public sealed class QuestDalaran : QuestData
  {
    private readonly List<unit> _rescueUnits = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestDalaran"/> class.
    /// </summary>
    /// <param name="rescueRects">Units inside these rectangles start invulnerable and are rescued when the quest ends.</param>
    /// <param name="prerequisites">These quests must be completed before this one can be completed.</param>
    public QuestDalaran(IEnumerable<Rectangle> rescueRects, IEnumerable<QuestData> prerequisites) : base("Outskirts",
      "The territories of Dalaran are fragmented, secure the lands and protect Dalaran citizens .",
      "ReplaceableTextures\\CommandButtons\\BTNArcaneCastle.blp")
    {
      foreach (var prerequisite in prerequisites) 
        AddObjective(new ObjectiveCompleteQuest(prerequisite));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N018_DURNHOLDE_15GOLD_MIN)));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N01I_CAER_DARROW_15GOLD_MIN)));
      AddObjective(new ObjectiveUpgrade(Constants.UNIT_H068_OBSERVATORY_DALARAN, Constants.UNIT_H065_REFUGE_DALARAN));
      AddObjective(new ObjectiveExpire(1445));
      AddObjective(new ObjectiveSelfExists());
      ResearchId = Constants.UPGRADE_R038_QUEST_COMPLETED_OUTSKIRTS;

      foreach (var rectangle in rescueRects)
        _rescueUnits.AddRange(rectangle.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures,
          unit => unit.GetTypeId() != Constants.UNIT_N0DK_SKULL_OF_GUL_DAN_PEDESTAL));
      Required = true;
    }

    /// <inheritdoc/>
    protected override string CompletionPopup =>
      "Dalaran outskirs are now secure, the mages will join Dalaran.";

    /// <inheritdoc/>
    protected override string RewardDescription =>
      "Control of all units in Dalaran and enables Antonidas to be trained at the Altar";

    /// <inheritdoc/>
    protected override void OnFail(Faction completingFaction) => 
      Player(PLAYER_NEUTRAL_AGGRESSIVE).RescueGroup(_rescueUnits);

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      completingFaction.Player?.RescueGroup(_rescueUnits);
      if (GetLocalPlayer() == completingFaction.Player) 
        PlayThematicMusic("war3mapImported\\DalaranTheme.mp3");
    }
  }
}