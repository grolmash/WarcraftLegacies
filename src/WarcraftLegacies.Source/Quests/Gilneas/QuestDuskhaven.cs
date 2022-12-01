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
  /// Capture control points close to Duskhaven to gain control of it.
  /// </summary>
  public class QuestDuskhaven : QuestData
  {
    private List<unit> _rescueUnits { get;}

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestDuskhaven"/> class.
    /// </summary>
    public QuestDuskhaven() : base("Duskhaven", "The next town is located at the western coast of Gilneas.", "ReplaceableTextures\\CommandButtons\\BTNGilneasTownHall.blp")
    {
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N031_DUSKHAVEN_20GOLD_MIN)));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N06V_BLACKWALD_10GOLD_MIN)));
      AddObjective(new ObjectiveExpire(1200));
      AddObjective(new ObjectiveSelfExists());
      _rescueUnits = Regions.GilneasUnlock4.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures);
      Required = true;
    }

    /// <inheritdoc/>
    protected override string CompletionPopup => "Duskhaven has been liberated.";

    /// <inheritdoc/>
    protected override string RewardDescription => "Control of all buildings in Duskhaven.";

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
