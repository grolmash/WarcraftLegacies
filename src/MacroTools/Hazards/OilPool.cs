﻿using MacroTools.Extensions;
using MacroTools.Powers;
using MacroTools.SpellSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace MacroTools.Hazards
{
  /// <summary>
  /// A pool of oil that can be harvested for oil.
  /// </summary>
  public sealed class OilPool : Hazard
  {
    /// <summary>
    /// The <see cref="OilPower"/> that generated this <see cref="OilPool"/>.
    /// </summary>
    public OilPower OilPower { get; }

    private readonly effect _effectOil;
    private readonly effect _effectCircle;

    /// <inheritdoc />
    public override bool Active { get; set; } = true;

    /// <summary>
    /// The amount of oil left in the pool.
    /// </summary>
    public int OilAmount { get; set; }

    /// <summary>
    /// Initializes a new instance of the OilPool class.
    /// </summary>
    /// <param name="owner">The player that owns the oil pool. Only this player can see it.</param>
    /// <param name="position">Where the oil pool should be.</param>
    /// <param name="effectPath">A path to a model representing the oil pool.</param>
    /// <param name="oilPower">Where to put any oil harvested.</param>
    public OilPool(player owner, Point position, string effectPath, OilPower oilPower) : base(null, position.X,
      position.Y)
    {
      OilPower = oilPower;
      _effectOil = AddSpecialEffect(owner == GetLocalPlayer() ? effectPath : "", position.X, position.Y)
        .SetScale(2);
      _effectCircle = AddSpecialEffect(owner == GetLocalPlayer() ? @"buildings\other\CircleOfPower\CircleOfPower" : "",
          position.X, position.Y)
        .SetScale(2)
        .SetHeight(Libraries.Environment.GetPositionZ(position))
        .SetColor(Player(20));
    }

    /// <inheritdoc />
    protected override void OnDispose()
    {
      _effectOil.Destroy();
      _effectCircle.Destroy();
    }
  }
}