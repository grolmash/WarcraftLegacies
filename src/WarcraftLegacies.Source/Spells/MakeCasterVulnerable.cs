﻿using MacroTools.Extensions;
using MacroTools.SpellSystem;
using War3Api;
using WCSharp.Shared.Data;

namespace WarcraftLegacies.Source.Spells
{
  /// <summary>
  /// When cast, the caster becomes vulnerable.
  /// </summary>
  public sealed class MakeCasterVulnerable : Spell
  {
    /// <inheritdoc />
    public MakeCasterVulnerable(int id) : base(id)
    {
    }
    
    /// <inheritdoc />
    public override void OnStartCast(Common.unit caster, Common.unit target, Point targetPoint) => 
      caster.SetInvulnerable(false);
  }
}