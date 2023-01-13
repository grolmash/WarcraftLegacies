﻿using System;
using System.Collections.Generic;
using MacroTools.Extensions;
using static War3Api.Common;

namespace MacroTools.ResearchSystems
{
  /// <summary>
  /// Provides a wrapper for vanilla WC3 researches that can be used to give them additional effects.
  /// </summary>
  public abstract class Research
  {
    /// <summary>
    /// A collection of <see cref="Research"/>es this <see cref="Research"/> is incompatible with.
    /// </summary>
    public IEnumerable<Research> IncompatibleWith = Array.Empty<Research>();
    
    /// <summary>
    /// The amount of gold the research costs. Unfortunately this is hard-coded.
    /// </summary>
    public int GoldCost { get; }
    
    /// <summary>
    /// The amount of lumber the research costs. Unfortunately this is hard-coded.
    /// </summary>
    public int LumberCost { get; }

    /// <summary>
    /// The ID of the Warcraft 3 research object.
    /// </summary>
    public int ResearchTypeId { get; }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Research"/> class.
    /// </summary>
    protected Research(int researchTypeId, int goldCost, int lumberCost)
    {
      ResearchTypeId = researchTypeId;
      GoldCost = goldCost;
      LumberCost = lumberCost;
    }

    /// <summary>
    /// Invoked when a player gains the research
    /// </summary>
    public abstract void OnResearch(player researchingPlayer);

    /// <summary>
    /// Unresearches the research and returns all gold and lumber spent on it.
    /// </summary>
    /// <param name="researchingPlayer"></param>
    public void Refund(player researchingPlayer)
    {
      researchingPlayer.DisplayRefundedResearch(ResearchTypeId);
      researchingPlayer.AddGold(GoldCost);
      researchingPlayer.AddLumber(LumberCost);
      researchingPlayer.SetObjectLevel(ResearchTypeId, Math.Min(0, researchingPlayer.GetObjectLimit(ResearchTypeId)));
    }
  }
}