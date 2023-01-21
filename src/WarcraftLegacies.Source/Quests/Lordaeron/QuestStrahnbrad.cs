﻿using System.Collections.Generic;
using MacroTools.ControlPointSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives.ControlPointBased;
using MacroTools.ObjectiveSystem.Objectives.FactionBased;
using MacroTools.ObjectiveSystem.Objectives.TimeBased;
using MacroTools.QuestSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Lordaeron
{
  /// <summary>
  /// Capture Strahnbrad's control point to gain control of the village.
  /// </summary>
  public sealed class QuestStrahnbrad : QuestData
  {
    private readonly List<unit> _rescueUnits;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestStrahnbrad"/> class.
    /// </summary>
    /// <param name="rescueRect"></param>
    public QuestStrahnbrad(Rectangle rescueRect) : base("The Defense of Strahnbrad",
      "The Strahnbrad is under attack by some brigands, clear them out",
      "ReplaceableTextures\\CommandButtons\\BTNFarm.blp")
    {
      AddObjective(
        new ObjectiveControlPoint(
          ControlPointManager.Instance.GetFromUnitType(Constants.UNIT_N01C_STRAHNBRAD_10GOLD_MIN)));
      AddObjective(new ObjectiveExpire(1170));
      AddObjective(new ObjectiveSelfExists());
      _rescueUnits = rescueRect.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures);
      Required = true;
    }

    /// <inheritdoc/>
    protected override string RewardFlavour => "Strahnbrad has been liberated.";

    /// <inheritdoc/>
    protected override string RewardDescription => "Control of all buildings in Strahnbrad";

    /// <inheritdoc/>
    protected override void OnFail(Faction completingFaction)
    {
      Player(PLAYER_NEUTRAL_AGGRESSIVE).RescueGroup(_rescueUnits);
    }

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      if (completingFaction.Player != null)
        completingFaction.Player.RescueGroup(_rescueUnits);
    }
  }
}