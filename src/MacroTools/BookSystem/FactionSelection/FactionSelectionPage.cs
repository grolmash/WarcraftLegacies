using System;
using System.Collections.Generic;
using MacroTools.FactionSystem;

namespace MacroTools.BookSystem.FactionSelection
{
  public sealed class FactionSelectionPage : Page
  {
    private readonly Dictionary<Faction, FactionSelectionCard> _cardsByFaction = new();
    
    public FactionSelectionPage()
    {
      Rows = 4;
      Columns = 4;
      YOffsetTop = 0.045f;
      YOffsetBot = 0.05f;
    }

    /// <summary>
    /// Unrenders a <see cref="Faction"/> from this <see cref="FactionSelectionPage"/>.
    /// </summary>
    public void RemoveFaction(Faction faction)
    {
      if (_cardsByFaction.TryGetValue(faction, out var factionCard))
      {
        Cards.Remove(factionCard);
        _cardsByFaction.Remove(faction);
        factionCard.Dispose();
      }
    }
    
    /// <summary>
    ///   Renders a Faction on this FactionPage as a FactionCard.
    /// </summary>
    public void AddFaction(Faction faction)
    {
      if (CardCount >= CardLimit)
        throw new Exception($"FactionPage is already at the card limit of {CardLimit} cards.");
      var factionCard = new FactionSelectionCard(faction, this);
      PositionFrameAtIndex(factionCard, Cards.Count);
      Cards.Add(factionCard);
      AddFrame(factionCard);
      _cardsByFaction.Add(faction, factionCard);
    }
  }
}