﻿using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.Wrappers;
using WCSharp.Buffs;
using static War3Api.Common;

namespace MacroTools.Buffs
{
  /// <summary>
  /// Increases the owner's income by an amount, and destroys the unit when its trade center dies.
  /// </summary>
  public sealed class TraderBuff : PassiveBuff
  {
    private readonly int _goldIncomeBonus;
    private readonly int _lumberIncomeBonus;
    private readonly TriggerWrapper _tradeCenterDiesTrigger = new();

    public TraderBuff(unit caster, unit target, int goldIncomeBonus, int lumberIncomeBonus, unit tradeCenter) : base(
      caster, target)
    {
      _goldIncomeBonus = goldIncomeBonus;
      _lumberIncomeBonus = lumberIncomeBonus;
      _tradeCenterDiesTrigger.RegisterUnitEvent(tradeCenter, EVENT_UNIT_DEATH);
      _tradeCenterDiesTrigger.AddAction(TradeCenterDies);
      Duration = float.MaxValue;
    }

    private void TradeCenterDies()
    {
      KillUnit(Target);
    }

    public override void OnApply()
    {
      CastingPlayer.AddBonusIncome(_goldIncomeBonus);
      CastingPlayer.AddLumberIncome(_lumberIncomeBonus);
    }

    public override void OnDispose()
    {
      CastingPlayer.AddBonusIncome(-_goldIncomeBonus);
      CastingPlayer.AddLumberIncome(-_lumberIncomeBonus);
      _tradeCenterDiesTrigger.Dispose();
    }
  }
}