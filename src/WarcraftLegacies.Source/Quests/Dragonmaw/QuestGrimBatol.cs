﻿using System.Collections.Generic;
using MacroTools.ControlPointSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using MacroTools.Wrappers;
using WarcraftLegacies.Source.Setup.Legends;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Dragonmaw
{
  public sealed class QuestGrimBatol : QuestData
  {
    private readonly unit _grimBatol;
    private readonly List<unit> _rescueUnits = new();
    private readonly unit _waygateA;
    private readonly unit _waygateB;

    public QuestGrimBatol(Rectangle rescueRect, unit grimBatol, unit waygateA, unit waygateB) : base(
      "The Cursed Fortress",
      "The mountain fortress of Grim Batol will be the perfect stronghold for the Dragonmaw clan. It has served well in the past and will do so again.",
      "ReplaceableTextures\\CommandButtons\\BTNDarkIronLair.blp")
    {
      _grimBatol = grimBatol;
      _waygateA = waygateA;
      _waygateB = waygateB;
      AddObjective(new ObjectiveLegendDead(LegendNeutral.Vaelastrasz));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(FourCC("n03X"))));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(FourCC("n09F"))));
      AddObjective(new ObjectiveExpire(480));
      AddObjective(new ObjectiveSelfExists());
      ResearchId = Constants.UPGRADE_R06Y_QUEST_COMPLETED_THE_CURSED_FORTRESS;

      foreach (var unit in new GroupWrapper().EnumUnitsInRect(rescueRect).EmptyToList())
        if (GetOwningPlayer(unit) == Player(PLAYER_NEUTRAL_PASSIVE))
        {
          SetUnitInvulnerable(unit, true);
          _rescueUnits.Add(unit);
        }

      Required = true;
    }

    //Todo: bad flavour
    protected override string CompletionPopup =>
      "Grim Batol is now under our control, and its military is now free to assist the Dragonmaw.";

    protected override string RewardDescription =>
      "Control of all units in Grim Batol";

    protected override void OnFail(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete(Faction completingFaction)
    {
      SetUnitOwner(_grimBatol, completingFaction.Player, true);
      WaygateActivate(_waygateA, true);
      WaygateActivate(_waygateB, true);
      foreach (var unit in _rescueUnits) unit.Rescue(completingFaction.Player);
    }
  }
}