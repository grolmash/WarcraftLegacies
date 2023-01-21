﻿using System.Collections.Generic;
using MacroTools;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives.FactionBased;
using MacroTools.ObjectiveSystem.Objectives.TimeBased;
using MacroTools.ObjectiveSystem.Objectives.UnitBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.Legends;
using WCSharp.Shared.Data;
using static War3Api.Common;


namespace WarcraftLegacies.Source.Quests.Frostwolf
{
  /// <summary>
  /// Kill the centaur leader in Mulgore and bring <see cref="LegendFrostwolf.Cairne"/> to <see cref="LegendFrostwolf.ThunderBluff"/> to unlock it
  /// </summary>
  public sealed class QuestThunderBluff : QuestData
  {
    private readonly List<unit> _rescueUnits;

    /// <inheritdoc />
    public QuestThunderBluff(PreplacedUnitSystem preplacedUnitSystem, Rectangle rescueRect) : base("The Long March",
      "The Tauren have been wandering for too long. The plains of Mulgore would offer respite from this endless journey.",
      "ReplaceableTextures\\CommandButtons\\BTNCentaurKhan.blp")
    {
      AddObjective(new ObjectiveUnitIsDead(preplacedUnitSystem.GetUnit(FourCC("ncnk"), rescueRect.Center)));
      AddObjective(new ObjectiveAnyUnitInRect(rescueRect, "Thunder Bluff", true));
      AddObjective(new ObjectiveExpire(1455));
      AddObjective(new ObjectiveSelfExists());
      ResearchId = Constants.UPGRADE_R05I_QUEST_COMPLETED_THE_LONG_MARCH; 
      _rescueUnits = rescueRect.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures);
      Required = true;
    }

    //todo: bad flavour
    /// <inheritdoc />
    protected override string RewardFlavour => "The long march of the Tauren clans has ended, and they have joined forces with the Horde.";

    /// <inheritdoc />
    protected override string RewardDescription => "Control of Thunder Bluff";

    /// <inheritdoc />
    protected override void OnFail(Faction completingFaction)
    {
      Player(PLAYER_NEUTRAL_AGGRESSIVE).RescueGroup(_rescueUnits);
    }

    /// <inheritdoc />
    protected override void OnComplete(Faction completingFaction)
    {
      if (completingFaction.Player != null)
      { 
        completingFaction.Player.RescueGroup(_rescueUnits);
        if (GetLocalPlayer() == completingFaction.Player) 
          PlayThematicMusic("war3mapImported\\TaurenTheme.mp3");
      }
    }
  }
}