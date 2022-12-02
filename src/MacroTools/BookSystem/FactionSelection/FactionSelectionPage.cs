using System;
using MacroTools.FactionSystem;

namespace MacroTools.BookSystem.FactionSelection
{
  public sealed class FactionSelectionPage : Page
  {
    public FactionSelectionPage()
    {
      Rows = 4;
      Columns = 5;
      YOffsetTop = 0.06f;
      YOffsetBot = 0.05f;
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
    }
  }
}