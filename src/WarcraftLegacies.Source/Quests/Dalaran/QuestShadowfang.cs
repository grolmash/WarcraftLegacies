﻿using System.Collections.Generic;
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
  /// Kill a wolf to unlock a base.
  /// </summary>
  public sealed class QuestShadowfang : QuestData
  {
    private readonly List<unit> _rescueUnits;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestShadowfang"/> class.
    /// </summary>
    /// <param name="rescueRect">Units in this region will start invulnerable and be rescued when the quest completes.</param>
    /// <param name="direwolfToKill">This unit must be killed to complete the quest.</param>
    public QuestShadowfang(Rectangle rescueRect, unit direwolfToKill) : base("Shadows of Silverpine Forest",
      "The woods of Silverspine are unsafe for travellers, they need to be investigated",
      "ReplaceableTextures\\CommandButtons\\BTNworgen.blp")
    {
      AddObjective(new ObjectiveKillUnit(direwolfToKill));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N01D_SILVERPINE_FOREST_15GOLD_MIN)));
      AddObjective(new ObjectiveExpire(1444));
      AddObjective(new ObjectiveSelfExists());
      _rescueUnits = rescueRect.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures);
      Required = true;
    }

    /// <inheritdoc />
    protected override string CompletionPopup =>
      "Shadowfang has been liberated, and its military is now free to assist Dalaran.";

    /// <inheritdoc />
    protected override string RewardDescription => "Control of all units in Shadowfang";

    /// <inheritdoc />
    protected override void OnFail(Faction completingFaction) => 
      Player(PLAYER_NEUTRAL_AGGRESSIVE).RescueGroup(_rescueUnits);

    /// <inheritdoc />
    protected override void OnComplete(Faction completingFaction) =>
      completingFaction.Player?.RescueGroup(_rescueUnits);
  }
}