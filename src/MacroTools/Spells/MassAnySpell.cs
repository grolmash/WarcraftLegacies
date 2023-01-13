﻿using MacroTools.SpellSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace MacroTools.Spells
{
  public class MassAnySpell : Spell
  {
    public int DummyAbilityId { get; init; }
    
    public string DummyAbilityOrderString { get; init; }
    
    public float Radius { get; init; }
    
    public DummyCast.CastFilter CastFilter { get; init; }
    
    public SpellTargetType TargetType { get; init; } = SpellTargetType.None;

    /// <summary>
    /// Determines where the spell's dummmy units spawn when they cast <see cref="DummyAbilityId"/>.
    /// </summary>
    public DummyCastOriginType DummyCastOriginType { get; init; } = DummyCastOriginType.Target;
    
    public MassAnySpell(int id) : base(id)
    {
    }

    public override void OnCast(unit caster, unit target, Point targetPoint)
    {
      var center = TargetType == SpellTargetType.None ? new Point(GetUnitX(caster), GetUnitY(caster)) : targetPoint;
      DummyCast.DummyCastOnUnitsInCircle(caster, DummyAbilityId, DummyAbilityOrderString, GetAbilityLevel(caster),
        center, Radius, CastFilter, DummyCastOriginType);
    }
  }
}