﻿using static War3Api.Common;

namespace MacroTools.ResearchSystems
{
  /// <summary>
  /// A <see cref="Research"/> that does nothing when researched.
  /// </summary>
  public sealed class BasicResearch : Research
  {
    /// <inheritdoc />
    public BasicResearch(int researchTypeId, int goldCost, int lumberCost) : base(researchTypeId, goldCost, lumberCost)
    {
    }

    /// <inheritdoc />
    public override void OnResearch(player researchingPlayer)
    {
    }
  }
}