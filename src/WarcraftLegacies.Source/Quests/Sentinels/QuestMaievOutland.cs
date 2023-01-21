﻿using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.LegendSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.ObjectiveSystem.Objectives.UnitBased;
using MacroTools.QuestSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Sentinels
{
  public sealed class QuestMaievOutland : QuestData
  {
    private readonly LegendaryHero _maiev;
    private readonly Capital _vaultOfTheWardens;
    private readonly List<unit> _rescueUnits = new();
    
    /// <summary>
    /// Initializes a new instance of the <see cref="QuestMaievOutland"/> class
    /// </summary>
    public QuestMaievOutland(Rectangle rescueRect, LegendaryHero maiev, Capital vaultOfTheWardens) : base("Driven by Vengeance",
      "Maiev drive for vengeance leads her to chase Illidan all the way to other worlds.",
      "ReplaceableTextures\\CommandButtons\\BTNMaievArmor.blp")
    {
      _maiev = maiev;
      _vaultOfTheWardens = vaultOfTheWardens;
      AddObjective(new ObjectiveCastSpell(Constants.ABILITY_A0J5_CHASE_ILLIDAN_TO_OUTLAND_SENTINEL, true));
      AddObjective(new ObjectiveControlLegend(maiev, true));
      AddObjective(new ObjectiveControlCapital(vaultOfTheWardens, true));

      foreach (var unit in CreateGroup().EnumUnitsInRect(rescueRect).EmptyToList())
      {
        SetUnitInvulnerable(unit, true);
        ShowUnit(unit, false);
        _rescueUnits.Add(unit);
      }
      Required = true;
    }

    /// <inheritdoc/>
    protected override string RewardDescription => "Control of Maiev's Outland outpost and moves Maiev to Outland";

    /// <inheritdoc/>
    protected override string RewardFlavour => "Maiev's Outland outpost have been constructed.";
    
    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      _maiev.Unit?.SetPosition(new Point(-5252, -27597));
      _vaultOfTheWardens.Unit?.RemoveAbility(Constants.ABILITY_A0J5_CHASE_ILLIDAN_TO_OUTLAND_SENTINEL);
      foreach (var unit in _rescueUnits) unit.Rescue(completingFaction.Player);
    }
  }
}