﻿using System;
using System.Collections.Generic;
using System.Linq;
using static War3Api.Common;

namespace MacroTools.ResearchSystems
{
  /// <summary>
  /// Responsible for registering <see cref="Research"/>es.
  /// </summary>
  public static class ResearchManager
  {
    private static readonly Dictionary<int, Research> ByTypeId = new();

    /// <summary>
    /// Registers a <see cref="Research"/>, causing its <see cref="Research.OnResearch"/> function to be executed when researched.
    /// </summary>
    public static void Register(Research research)
    {
      if (ByTypeId.ContainsKey(research.ResearchTypeId))
        throw new InvalidOperationException($"{GetObjectName(research.ResearchTypeId)} has already been registered.");
      ByTypeId.Add(research.ResearchTypeId, research);
    }
    
    /// <summary>
    /// Registers a set of incompatible researches to the system, causing the reseaches contained within to be
    /// mutually exclusive.
    /// </summary>
    public static void RegisterIncompatibleSet(params int[] researchTypeIds)
    {
      var researches = researchTypeIds.Select(x => new BasicResearch(x, 0, 0) as Research).ToArray();
      RegisterIncompatibleSet(researches);
    }

    /// <summary>
    /// Registers a set of incompatible researches to the system, causing the reseaches contained within to be
    /// mutually exclusive.
    /// </summary>
    public static void RegisterIncompatibleSet(params Research[] researches)
    {
      foreach (var outerResearch in researches)
      {
        outerResearch.IncompatibleWith = researches.Where(x => x != outerResearch);
        Register(outerResearch);
      }
    }

    /// <summary>
    /// Returns the <see cref="Research"/> with the matching type ID.
    /// </summary>
    public static Research? GetFromTypeId(int researchTypeId) =>
      ByTypeId.ContainsKey(researchTypeId) ? ByTypeId[researchTypeId] : null;
  }
}