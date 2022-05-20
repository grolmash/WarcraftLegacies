using System;
using System.Collections.Generic;
using War3Api.Object;
using War3Net.Build;

namespace AzerothWarsCSharp.Launcher
{
  public static class IntegrityChecker
  {
    public static void CheckAbilityIntegrity(Map map)
    {
      List<Ability> abilities = new();
      var objectDatabase = GetObjectDatabaseFromMap(map);
      var units = objectDatabase.GetUnits();
      foreach (var unit in units)
      {
        if (unit.IsAbilitiesNormalModified)
        {
          foreach (var ability in unit.AbilitiesNormal)
          {
            abilities.Add(ability);
          }
        }
        if (unit.IsAbilitiesHeroModified)
        {
          foreach (var ability in unit.AbilitiesNormal)
          {
            abilities.Add(ability);
          }
        }
      }

      foreach (var ability in abilities)
      {
        Console.WriteLine(ability.TextName);
      }
    }
    
    private static ObjectDatabase GetObjectDatabaseFromMap(Map map)
    {
      var objectDatabase = new ObjectDatabase();
      if (map.AbilityObjectData != null) objectDatabase.AddObjects(map.AbilityObjectData);
      if (map.BuffObjectData != null) objectDatabase.AddObjects(map.BuffObjectData);
      //if (map.DestructableObjectData != null) objectDatabase.AddObjects(map.DestructableObjectData);
      if (map.DoodadObjectData != null) objectDatabase.AddObjects(map.DoodadObjectData);
      if (map.ItemObjectData != null) objectDatabase.AddObjects(map.ItemObjectData);
      if (map.UnitObjectData != null) objectDatabase.AddObjects(map.UnitObjectData);
      if (map.UpgradeObjectData != null) objectDatabase.AddObjects(map.UpgradeObjectData);
      return objectDatabase;
    }
  }
}