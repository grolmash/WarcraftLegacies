﻿using MacroTools.Extensions;
using MacroTools.FactionSystem;
using WCSharp.Events;
using static War3Api.Common;

namespace MacroTools.ResearchSystems
{
  /// <summary>
  /// Provides an easy way to force a research's level to always be equal to that of another.
  /// </summary>
  public static class ParentChildResearchSystem
  {
    /// <summary>
    /// Once registered, the child research will always have its level set to the same level as the parent research
    /// when the parent research is researched.
    /// </summary>
    public static void Register(int parentResearch, int childResearch)
    {
      PlayerUnitEvents.Register(ResearchEvent.IsFinished, () =>
      {
        var triggerFaction = GetTriggerPlayer().GetFaction();
        triggerFaction?.ModObjectLimit(childResearch, 1);
        triggerFaction?.SetObjectLevel(childResearch, triggerFaction.GetObjectLevel(parentResearch));
      }, parentResearch);
    }
  }
}