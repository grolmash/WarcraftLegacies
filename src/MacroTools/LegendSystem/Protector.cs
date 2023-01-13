﻿using System;
using MacroTools.Wrappers;
using static War3Api.Common;

namespace MacroTools.LegendSystem
{
  /// <summary>
  /// A unit bestowing invulnerability on a <see cref="Legend"/>.
  /// </summary>
  internal sealed class Protector
  {
    public Protector(unit unit)
    {
      var deathTrigger = new TriggerWrapper();
      deathTrigger.RegisterUnitEvent(unit, EVENT_UNIT_DEATH);
      deathTrigger.AddAction(() =>
      {
        ProtectorDied?.Invoke(this, this);
      });
    }

    internal event EventHandler<Protector>? ProtectorDied;
  }
}