using System.Collections.Generic;
using System.Linq;
using MacroTools.FactionSystem;

namespace MacroTools.FactionSelectionSystem
{
  public sealed class FactionSelectionManager
  {
    private readonly IEnumerable<FactionSelection> _factionSelections;

    public FactionSelectionManager(IEnumerable<Faction> factions)
    {
      _factionSelections = factions.Select(x => new FactionSelection
      {
        Faction = x,
        Player = x.PriorityPicker
      });
      foreach (var factionSelection in _factionSelections) 
        factionSelection.Selected += OnFactionSelected;
    }

    private void OnFactionSelected(object? sender, FactionSelection selectedFaction)
    {
      foreach (var factionSelection in _factionSelections.Where(x =>
                 x.Player != null && x.Player == selectedFaction.Player && x != selectedFaction))
        factionSelection.SelectForPlayer(null);
    }

    public IEnumerable<FactionSelection> GetAllFactionSelections() => 
      _factionSelections.ToList().AsReadOnly();
  }
}