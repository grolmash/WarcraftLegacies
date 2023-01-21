﻿using System.Collections.Generic;
using MacroTools;
using MacroTools.ControlPointSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives.ControlPointBased;
using MacroTools.ObjectiveSystem.Objectives.FactionBased;
using MacroTools.ObjectiveSystem.Objectives.TimeBased;
using MacroTools.ObjectiveSystem.Objectives.UnitBased;
using MacroTools.QuestSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Frostwolf
{
  public sealed class QuestStonemaul : QuestData
  {
    private readonly List<unit> _rescueUnits = new();

    public QuestStonemaul(PreplacedUnitSystem preplacedUnitSystem, Rectangle rescueRect) : base("The Chieftain's Challenge",
      "Rexxar is having trouble with a beligerent Ogre Warlord, slay the Chieftain to gain the heroe's allegiance.",
      "ReplaceableTextures\\CommandButtons\\BTNOneHeadedOgre.blp")
    {
      AddObjective(new ObjectiveControlPoint(ControlPointManager.Instance.GetFromUnitType(Constants.UNIT_N022_STONEMAUL_20GOLD_MIN)));
      AddObjective(new ObjectiveUnitIsDead(preplacedUnitSystem.GetUnit(Constants.UNIT_NOGA_STONEMAUL_WARCHIEF_KOR_GALL)));
      AddObjective(new ObjectiveExpire(1327));
      AddObjective(new ObjectiveSelfExists());
      ResearchId = Constants.UPGRADE_R03S_QUEST_COMPLETED_THE_CHIEFTAIN_S_CHALLENGE_FROSTWOLF;
      foreach (var unit in CreateGroup().EnumUnitsInRect(rescueRect).EmptyToList())
        if (GetOwningPlayer(unit) == Player(PLAYER_NEUTRAL_PASSIVE))
        {
          SetUnitInvulnerable(unit, true);
          _rescueUnits.Add(unit);
        }

      Required = true;
    }

    //Todo: bad flavour
    /// <inheritdoc/>
    protected override string RewardFlavour =>
      "Korghal has been defeated, Rexxar has joined the Frostwolf!";

    /// <inheritdoc/>
    protected override string RewardDescription => "Control of all buildings in Stonemaul and Rexxar is now trainable at the Altar";

    /// <inheritdoc/>
    protected override void OnFail(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(completingFaction.Player);
    }
  }
}