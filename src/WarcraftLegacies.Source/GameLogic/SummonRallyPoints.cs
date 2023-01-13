﻿using MacroTools.Extensions;
using WCSharp.Events;
using static War3Api.Common;

namespace WarcraftLegacies.Source.GameLogic
{
  /// <summary>
  /// When units are summoned by buildings, send them to attack-move towards their rally points.
  /// </summary>
  public static class SummonRallyPoints
  {
    /// <summary>
    /// Sets up <see cref="SummonRallyPoints"/>.
    /// </summary>
    public static void Setup()
    {
      PlayerUnitEvents.Register(UnitTypeEvent.IsSummoned, () =>
      {
        var summoningUnit = GetSummoningUnit();
        if (summoningUnit.IsType(UNIT_TYPE_STRUCTURE))
          GetSummonedUnit().IssueOrder("attack", summoningUnit.GetRallyPoint());
      });
    }
  }
}