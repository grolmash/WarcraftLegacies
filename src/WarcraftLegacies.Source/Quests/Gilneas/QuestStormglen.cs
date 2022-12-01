﻿using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using System.Collections.Generic;
using static War3Api.Common;
using MacroTools.Extensions;
using MacroTools.QuestSystem.UtilityStructs;
using MacroTools.ControlPointSystem;

namespace WarcraftLegacies.Source.Quests.Gilneas
{
  /// <summary>
  /// Capture control points close to Stormglen to gain control of it.
  /// </summary>
  public class QuestStormglen : QuestData
  {
    private List<unit> _rescueUnits { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestKeelHarbor"/> class.
    /// </summary>
    public QuestStormglen() : base("Stormglen", "The next village is right next to the Blackwald, south west of Tempest Reach. We will need to purify the forest too.", "ReplaceableTextures\\CommandButtons\\BTNGilneasWizardTower.blp")
    {
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N06V_BLACKWALD_10GOLD_MIN)));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N084_TEMPEST_REACH_10GOLD_MIN)));
      AddObjective(new ObjectiveExpire(950));
      AddObjective(new ObjectiveSelfExists());
      _rescueUnits = Regions.GilneasUnlock2.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures);
      Required = true;
    }

    /// <inheritdoc/>
    protected override string CompletionPopup => "Stormglen Village has been liberated.";

    /// <inheritdoc/>
    protected override string RewardDescription => "Control of all buildings in Stormglen Village";

    /// <inheritdoc/>
    protected override void OnComplete(Faction whichFaction)
    {
      whichFaction.Player?.RescueGroup(_rescueUnits);
    }

    /// <inheritdoc/>
    protected override void OnFail(Faction whichFaction)
    {
      Player(PLAYER_NEUTRAL_AGGRESSIVE).RescueGroup(_rescueUnits);
    }
  }
}
