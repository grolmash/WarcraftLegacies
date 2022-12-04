using System;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace MacroTools.FactionSelectionSystem
{
  public sealed class FactionSelection
  {
    public player? Player { get; set; }
    
    public Faction Faction { get; set; }

    public event EventHandler<FactionSelection>? Selected;
    
    public void SelectForPlayer(player? whichPlayer)
    {
      Player = whichPlayer;
      Selected?.Invoke(this, this);
    }
  }
}