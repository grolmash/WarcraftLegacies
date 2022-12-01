﻿using MacroTools.Powers;
using WCSharp.Buffs;
using static War3Api.Common;

namespace MacroTools.Buffs
{
  /// <summary>
  /// Increases the owner's oil income. The owner must have an instance of <see cref="OilPower"/>.
  /// </summary>
  public sealed class OilProducerBuff : PassiveBuff
  {
    private readonly float _incomePerSecond;
    private readonly OilPower _oilPower;
    private trigger? _castTrigger;

    /// <summary>
    /// Construct an <see cref="OilUserBuff"/>.
    /// </summary>
    /// <param name="target">The unit with the buff.</param>
    /// <param name="incomePerSecond">How much oil to give the owner per second.</param>
    /// <param name="oilPower">The power providing oil to the unit with the buff.</param>
    public OilProducerBuff(unit target, float incomePerSecond, OilPower oilPower) : base(target, target)
    {
      _incomePerSecond = incomePerSecond;
      _oilPower = oilPower;
      _oilPower.AmountChanged += OnOilAmountChanged;

      Duration = float.MaxValue;
    }

    private void OnOilAmountChanged(object? sender, OilPower oilPower)
    {
      SetUnitState(Target, UNIT_STATE_MANA, _oilPower.Amount);
    }

    private void OnCast()
    {
      var triggerUnit = GetTriggerUnit();
      var triggerSpell = GetSpellAbilityId();
      var manaCost =
        BlzGetUnitAbilityManaCost(triggerUnit, triggerSpell, GetUnitAbilityLevel(triggerUnit, triggerSpell) - 1);
      _oilPower.Amount -= manaCost;
      SetUnitState(Target, UNIT_STATE_MANA, _oilPower.Amount);
    }

    /// <inheritdoc/>
    public override void OnApply()
    {
      _castTrigger = CreateTrigger();
      _oilPower.Income += _incomePerSecond;
      TriggerRegisterUnitEvent(_castTrigger, Target, EVENT_UNIT_SPELL_EFFECT);
      TriggerAddAction(_castTrigger, OnCast);
      SetUnitState(Target, UNIT_STATE_MANA, _oilPower.Amount);
    }

    /// <inheritdoc/>
    public override void OnDispose()
    {
      DestroyTrigger(_castTrigger);
      _oilPower.Income -= _incomePerSecond;
      _oilPower.AmountChanged -= OnOilAmountChanged;
    }
  }
}