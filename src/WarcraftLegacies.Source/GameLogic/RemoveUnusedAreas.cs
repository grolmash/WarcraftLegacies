﻿using MacroTools.Extensions;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.GameLogic
{
  /// <summary>
  /// Removes units in areas of the map that are not currently in use.
  /// </summary>
  public static class RemoveUnusedAreas
  {
    /// <summary>
    /// Runs <see cref="RemoveUnusedAreas"/>.
    /// </summary>
    public static void Run()
    {
      var areas = new Rectangle[]
      {
        Regions.TempestKeepHide2
      };
      foreach (var area in areas)
      {
        foreach (var unit in CreateGroup().EnumUnitsInRect(area).EmptyToList())
          unit.Remove();
        EnumDestructablesInRect(area.Rect, null, () => { RemoveDestructable(GetEnumDestructable()); });
      }
    }
  }
}