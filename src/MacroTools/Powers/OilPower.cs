﻿using System;
using System.Collections.Generic;
using System.Linq;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.Hazards;
using MacroTools.SpellSystem;
using WCSharp.Events;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace MacroTools.Powers
{
  /// <summary>
  /// Gives the ability to store Oil as an additional resource.
  /// </summary>
  public sealed class OilPower : Power
  {
    private static readonly PeriodicTrigger<OilIncomePeriodicAction> OilIncomePeriodicTrigger = new(1f);
    private float _amount;
    private float _income;
    private OilIncomePeriodicAction? _oilIncomePeriodicAction;
    private readonly List<OilPool> _oilPools = new();
    private readonly List<player> _owners = new();
    private timer? _oilTimer;

    /// <summary>
    /// Fired when the amount of oil stored changes.
    /// </summary>
    public EventHandler<OilPower>? AmountChanged;

    /// <summary>
    /// Initializes a new instance of the <see cref="OilPower"/> class.
    /// </summary>
    public OilPower()
    {
      RefreshDescription();
    }

    /// <summary>
    /// The amount of oil the <see cref="OilPower"/> has.
    /// </summary>
    public float Amount
    {
      get => _amount;
      set
      {
        _amount = value;
        AmountChanged?.Invoke(this, this);
        RefreshDescription();
      }
    }

    /// <summary>
    /// The amount of oil the <see cref="OilPower"/> gains per second.
    /// </summary>
    public float Income
    {
      get => _income;
      set
      {
        _income = value;
        RefreshDescription();
      }
    }

    /// <summary>
    /// The maximum number of oil pools that will generate on the map.
    /// </summary>
    public int MaximumOilPoolCount { get; init; }

    /// <summary>
    /// The number of oil pools that are spawned at the start of the game.
    /// </summary>
    public int StartingOilPoolCount { get; init; } = 1;

    /// <summary>
    /// The maximum amount of oil that a given <see cref="OilPool"/> can start with.
    /// </summary>
    public int OilPoolMaximumValue { get; init; }

    /// <summary>
    /// The minimum amount of oil that a given <see cref="OilPool"/> can start with.
    /// </summary>
    public int OilPoolMinimumValue { get; init; }

    /// <summary>
    /// Returns all <see cref="OilPool"/>s managed by this <see cref="OilPower"/>.
    /// </summary>
    public IEnumerable<OilPool> GetAllOilPools() => _oilPools.AsReadOnly();

    /// <inheritdoc/>
    public override void OnAdd(player whichPlayer)
    {
      _owners.Add(whichPlayer);
      _oilIncomePeriodicAction = new OilIncomePeriodicAction(this);
      OilIncomePeriodicTrigger.Add(_oilIncomePeriodicAction);

      _oilTimer = CreateTimer().Start(300, true, GenerateOilPool);
      for (var i = 0; i < StartingOilPoolCount; i++)
        GenerateOilPool();
    }

    /// <inheritdoc/>
    public override void OnRemove(player whichPlayer)
    {
      if (_oilIncomePeriodicAction == null) return;
      _oilIncomePeriodicAction.Active = false;
      _oilIncomePeriodicAction = null;
      _owners.Remove(whichPlayer);
      _oilTimer?.Destroy();
    }

    private void GenerateOilPool()
    {
      if (_oilPools.Count > 0)
      {
        for (var i = _oilPools.Count; i-- > 0;)
        {
          if (_oilPools[i].OilAmount <= 0)
            _oilPools.Remove(_oilPools[i]);
        }
      }

      if (_oilPools.Count >= MaximumOilPoolCount)
        return;
      var randomPoint = GetRandomPointAtSea();
      var oilPool = new OilPool(_owners.First(), randomPoint, "Tar Pool.mdx", this)
      {
        Active = true,
        Duration = float.MaxValue,
        OilAmount = GetRandomInt(OilPoolMinimumValue, OilPoolMaximumValue)
      };
      HazardSystem.Add(oilPool);
      _oilPools.Add(oilPool);
    }

    private void RefreshDescription()
    {
      Description =
        $"You can harvest oil and use it to enhance your mechanical units.|n|cffffcc00Oil:|r {Amount}|n|cffffcc00Income:|r {Income}";
    }

    private static Point GetRandomPointAtSea()
    {
      Point randomPoint;
      do
      {
        randomPoint = Rectangle.WorldBounds.GetRandomPoint();
      } while (IsTerrainPathable(randomPoint.X, randomPoint.Y, PATHING_TYPE_FLOATABILITY) ||
               !IsTerrainPathable(randomPoint.X, randomPoint.Y, PATHING_TYPE_WALKABILITY) || 
               GetTerrainType(randomPoint.X, randomPoint.Y) != FourCC("Gsqd"));

      return randomPoint;
    }
  }
}