﻿using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using System.Collections.Generic;
using static War3Api.Common;
using MacroTools.Extensions;
using MacroTools.ControlPointSystem;
using MacroTools.ObjectiveSystem.Objectives.ControlPointBased;
using MacroTools.ObjectiveSystem.Objectives.FactionBased;
using MacroTools.ObjectiveSystem.Objectives.TimeBased;

namespace WarcraftLegacies.Source.Quests.Gilneas
{
  /// <summary>
  /// Capture control points close to Keel Harbor to gain control of it.
  /// </summary>
  public class QuestKeelHarbor: QuestData
  {
    private List<unit> _rescueUnits { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestKeelHarbor"/> class.
    /// </summary>
    public QuestKeelHarbor() : base("Keel Harbor", "The final village is the coastal harbor near the capital.", "ReplaceableTextures\\CommandButtons\\BTNGilneasShipyard.blp")
    {
      AddObjective(new ObjectiveControlPoint(ControlPointManager.Instance.GetFromUnitType(Constants.UNIT_N08X_KEEL_HARBOR_10GOLD_MIN)));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.Instance.GetFromUnitType(Constants.UNIT_N031_DUSKHAVEN_20GOLD_MIN)));
      AddObjective(new ObjectiveExpire(1200));
      AddObjective(new ObjectiveSelfExists());
      _rescueUnits = Regions.GilneasUnlock3.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures);
      Required = true;
    }

    /// <inheritdoc/>
    protected override string RewardFlavour => "Keel Harbor has been liberated.";

    /// <inheritdoc/>
    protected override string RewardDescription => "Control of all buildings in Keel Harbor.";

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
