using System.Linq;
using MacroTools.BookSystem;
using MacroTools.FactionSystem;
using WCSharp.Shared.Data;

namespace MacroTools.FactionSelectionSystem.UserInterface
{
  /// <summary>
  /// Allows all players to choose a <see cref="Faction"/> at the start of the game.
  /// </summary>
  public sealed class FactionSelectionBook : Book<FactionSelectionPage>
  {
    private static FactionSelectionBook? _instance;
    private readonly FactionSelectionManager _manager;

    /// <summary>
    /// Initializes a new instance of the <see cref="FactionSelectionBook"/> class.
    /// </summary>
    private FactionSelectionBook(FactionSelectionManager manager) : base(0.75f, 0.39f, 0.02f, 0.015f)
    {
      _manager = manager;
      var firstPage = AddPage();
      firstPage.Visible = true;
      Title = "Choose your faction";
      Position = new Point(0.36f, 0.35f);
      AddAllFactionSelections();
      ExitButton.Dispose();
      manager.Finished += (_, _) =>
      {
        _instance?.Dispose();
        _instance = null;
      };
    }

    /// <summary>
    /// Displays the <see cref="FactionSelectionBook"/> to all players.
    /// </summary>
    public static void Display(FactionSelectionManager manager)
    {
      _instance = new FactionSelectionBook(manager);
      _instance.Visible = true;
    }
    
    private void AddAllFactionSelections()
    {
      foreach (var faction in _manager.GetAllFactionSelections())
        AddFactionSelection(faction);
    }

    private void AddFactionSelection(FactionSelection factionSelection)
    {
      var lastPage = Pages.Last();
      if (lastPage.CardCount >= lastPage.CardLimit)
      {
        AddPage();
        lastPage = Pages.Last();
        lastPage.Manager = _manager;
      }

      lastPage.AddFactionSelection(factionSelection);
    }
  }
}