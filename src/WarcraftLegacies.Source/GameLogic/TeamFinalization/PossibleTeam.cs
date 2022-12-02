using System.Collections.Generic;
using MacroTools.FactionSystem;

namespace WarcraftLegacies.Source.GameLogic.TeamFinalization
{
  public sealed class PossibleTeam
  {
    public List<Faction> Factions { get; }

    public int Size => Factions.Count;

    public PossibleTeam(List<Faction> factions)
    {
      Factions = factions;
    }
  }
}