using System.Collections.Generic;
using System.Linq;
using MacroTools.FactionSystem;

namespace WarcraftLegacies.Source.GameLogic.TeamFinalization
{
  public sealed class PossibleTeam
  {
    public List<Faction> Factions { get; }
    
    /// <summary>
    /// The concrete <see cref="Team"/> that this <see cref="PossibleTeam"/> represents.
    /// </summary>
    public Team RealTeam { get; }

    /// <summary>
    /// The number of <see cref="Faction"/>s in the possible <see cref="Team"/>.
    /// </summary>
    public int Size => Factions.Count;

    public PossibleTeam(Team realTeam, IEnumerable<Faction> factions)
    {
      RealTeam = realTeam;
      Factions = factions.ToList();
    }

    public PossibleTeam(Team realTeam)
    {
      RealTeam = realTeam;
      Factions = new List<Faction>();
    }

    public void Add(Faction faction)
    {
      Factions.Add(faction);
    }
  }
}