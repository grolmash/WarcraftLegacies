using System;
using MacroTools.BookSystem;

namespace MacroTools.FactionSelectionSystem.UserInterface
{
  public sealed class FactionSelectionPage : Page
  {
    public FactionSelectionManager Manager { get; set; }
    
    public FactionSelectionPage()
    {
      Rows = 4;
      Columns = 5;
      YOffsetTop = 0.042f;
      YOffsetBot = 0.05f;
    }

    /// <summary>
    ///   Renders a Faction on this FactionPage as a FactionCard.
    /// </summary>
    public void AddFactionSelection(FactionSelection factionSelection)
    {
      if (CardCount >= CardLimit)
        throw new Exception($"FactionPage is already at the card limit of {CardLimit} cards.");
      var factionCard = new FactionSelectionCard(factionSelection, this);
      PositionFrameAtIndex(factionCard, Cards.Count);
      Cards.Add(factionCard);
      AddFrame(factionCard);
    }
  }
}