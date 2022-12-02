namespace MacroTools.FactionSystem
{
  /// <summary>
  /// The state that a <see cref="Faction"/> is currently in.
  /// </summary>
  public enum FactionStatus
  {
    /// <summary>
    /// Nobody has selected the <see cref="Faction"/> yet.
    /// </summary>
    Unselected,
    
    /// <summary>
    /// The faction has been selected.
    /// </summary>
    Undefeated,
    
    /// <summary>
    /// The faction has been selected and not yet defeated.
    /// </summary>
    Defeated
  }
}