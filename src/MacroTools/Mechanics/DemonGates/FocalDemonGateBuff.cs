﻿using MacroTools.Extensions;
using WCSharp.Buffs;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace MacroTools.Mechanics.DemonGates
{
  /// <summary>
  /// Units spawned at Demon Gates spawn at the Focal Demon Gate instead, if one exists.
  /// </summary>
  public sealed class FocalDemonGateBuff : PassiveBuff
  {
    /// <summary>
    /// The <see cref="FocalDemonGateBuff"/>. There can only ever be up to one in the game at a time.
    /// </summary>
    public static FocalDemonGateBuff? Instance { get; private set; }

    private const float FacingOffset = -45f; //Demon gate model is spun around weirdly so this reverses that for code
    private const float SpawnDistance = 300f; //How far away from the gate to spawn units

    /// <summary>
    /// Where units spawned by the <see cref="FocalDemonGateBuff"/> should appear.
    /// </summary>
    public Point SpawnPoint
    {
      get
      {
        var targetPosition = Target.GetPosition();
        var offsetPosition =
          WCSharp.Shared.Util.PositionWithPolarOffset(targetPosition.X, targetPosition.Y, SpawnDistance,
            Target.GetFacing() + FacingOffset);
        return new Point(offsetPosition.x, offsetPosition.y);
      }
    }

    /// <summary>
    /// Where units spawned by the <see cref="FocalDemonGateBuff"/> should be ordered to move.
    /// </summary>
    public Point RallyPoint => Target.GetRallyPoint();

    /// <summary>
    /// Initializes a new instance of the <see cref="FocalDemonGateBuff"/> class.
    /// </summary>
    /// <param name="target"><inheritdoc /></param>
    public FocalDemonGateBuff(unit target) : base(target, target) => Duration = float.MaxValue;

    /// <inheritdoc />
    public override void OnApply()
    {
      if (Instance != null)
        KillUnit(Instance.Target);
      Instance = this;
      Target.IssueOrder("setrally", SpawnPoint);
    }
  }
}