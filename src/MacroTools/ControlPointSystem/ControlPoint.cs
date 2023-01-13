using System;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace MacroTools.ControlPointSystem
{
  /// <summary>
  ///   An immobile and permanent unit on the map.
  ///   Increases the income of the controlling <see cref="Faction" />.
  ///   When a <see cref="ControlPoint" /> is reduced below a certain health threshold, it changes ownership to the attacker.
  /// </summary>
  public sealed class ControlPoint
  {
    private float _controlLevel;

    /// <summary>
    ///   Invoked when the <see cref="ControlPoint" /> changes its owner.
    /// </summary>
    public event EventHandler<ControlPointOwnerChangeEventArgs>? ChangedOwner;

    /// <summary>
    /// Fired when the <see cref="ControlLevel"/> of this <see cref="ControlPoint"/> changes.
    /// </summary>
    public event EventHandler? ControlLevelChanged;
    
    /// <summary>
    /// A tower that appears on the <see cref="ControlPoint"/> when its <see cref="ControlLevel"/> exceeds 0.
    /// </summary>
    public unit? Defender { get; internal set; }
    
    /// <summary>
    /// The owner of the <see cref="ControlPoint"/>.
    /// </summary>
    public player Owner => GetOwningPlayer(Unit);

    /// <summary>
    ///   How much gold this <see cref="ControlPoint" /> grants per minute.
    /// </summary>
    public float Value { get; }

    /// <summary>
    /// The unit type ID of the <see cref="ControlPoint"/>.
    /// </summary>
    public int UnitType => GetUnitTypeId(Unit);

    /// <summary>
    /// A user-friendly name for the <see cref="ControlPoint"/>.
    /// </summary>
    public string Name => GetUnitName(Unit);

    /// <summary>
    /// The unit representing the <see cref="ControlPoint"/>.
    /// </summary>
    public unit Unit { get; }
    
    /// <summary>
    /// When <see cref="ControlLevel"/> is higher than 0, the <see cref="ControlPoint"/> becomes a tower with
    /// attack damage and hit points based on its <see cref="ControlLevel"/>.
    /// </summary>
    public float ControlLevel
    {
      get => _controlLevel;
      set
      {
        _controlLevel = value;
        ControlLevelChanged?.Invoke(this, EventArgs.Empty);
      }
    }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="ControlPoint"/> class.
    /// </summary>
    /// <param name="representingUnit">The unit representing the <see cref="ControlPoint"/>.</param>
    /// <param name="value">The gold income granted by the <see cref="ControlPoint"/>.</param>
    public ControlPoint(unit representingUnit, float value)
    {
      Unit = representingUnit;
      Value = value;
    }

    /// <summary>
    /// Invokes the <see cref="ChangedOwner"/> event with the provided arguments.
    /// </summary>
    public void SignalOwnershipChange(ControlPointOwnerChangeEventArgs args) => ChangedOwner?.Invoke(this, args);
  }
}