using System.Collections.Generic;
using System.Linq;
using MacroTools.FactionSystem;
using WCSharp.Shared.Data;

namespace MacroTools.BookSystem.FactionSelection
{
  /// <summary>
  /// Allows all players to choose a <see cref="Faction"/> at the start of the game.
  /// </summary>
  public sealed class FactionSelectionBook : Book<FactionSelectionPage>
  {
    private readonly Dictionary<Faction, FactionSelectionPage> _pagesByFaction = new();
    
    /// <summary>
    /// Initializes a new instance of the <see cref="FactionSelectionBook"/> class.
    /// </summary>
    private FactionSelectionBook() : base(0.75f, 0.39f, 0.02f, 0.015f)
    {
      var firstPage = AddPage();
      firstPage.Visible = true;
      Title = "Choose your faction";
      Position = new Point(0.36f, 0.35f);
      AddAllFactions();
    }

    /// <summary>
    /// Displays the <see cref="FactionSelectionBook"/> to all players.
    /// </summary>
    public static void Display()
    {
      var book = new FactionSelectionBook();
      book.Visible = true;
    }
    
    private void AddAllFactions()
    {
      foreach (var faction in FactionManager.GetAllFactions())
        AddFaction(faction);
    }

    private void ReRender()
    {
      foreach (var page in Pages)
      {
        page.Visible = false; //This avoids a crash to desktop when rerendering a Book that a player has open.
        page.Dispose();
      }
      _pagesByFaction.Clear();
      Pages.Clear();
      AddPagesAndPowers();
    }

    private void AddPagesAndPowers()
    {
      var firstPage = AddPage();
      firstPage.Visible = true;
    }

    private void AddFaction(Faction faction)
    {
      var lastPage = Pages.Last();
      if (lastPage.CardCount >= lastPage.CardLimit)
      {
        AddPage();
        lastPage = Pages.Last();
      }

      lastPage.AddFaction(faction);
      _pagesByFaction.Add(faction, lastPage);
    }
  }
}