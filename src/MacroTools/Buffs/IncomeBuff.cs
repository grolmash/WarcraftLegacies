﻿using MacroTools.Extensions;
using MacroTools.FactionSystem;
using WCSharp.Buffs;
using static War3Api.Common;

namespace MacroTools.Buffs
{
  /// <summary>
  /// Increases the owning player's income.
  /// </summary>
  public sealed class IncomeBuff : PassiveBuff
  {
    private readonly int _bonusIncome;

    public IncomeBuff(unit caster, unit target, int bonusIncome) : base(caster, target)
    {
      _bonusIncome = bonusIncome;
      Duration = float.MaxValue;
    }

    public override StackResult OnStack(Buff newStack)
    {
      return StackResult.Consume;
    }

    public override void OnApply()
    {
      CastingPlayer.AddBonusIncome(_bonusIncome);
    }

    public override void OnDispose()
    {
      CastingPlayer.AddBonusIncome(-_bonusIncome);
    }
  }
}