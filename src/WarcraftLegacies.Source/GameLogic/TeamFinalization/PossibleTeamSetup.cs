using System.Collections.Generic;
using System.Linq;
using MacroTools.FactionSystem;

namespace WarcraftLegacies.Source.GameLogic.TeamFinalization
{
  /// <summary>
  /// Resposible figuring out the best possible team setup to start the game with.
  /// </summary>
  public sealed class PossibleTeamSetup
  {
    private readonly List<PossibleTeam> _teams = new();

    /// <summary>
    /// Returns the team setup which has the most equal number of players on each team.
    /// </summary>
    public static PossibleTeamSetup GetBestTeamSetup(List<Faction> factions) => 
      GetAllTeamCombinations(factions).OrderBy(TeamSetupScore).Last();

    private static IEnumerable<PossibleTeamSetup> GetAllTeamCombinations(List<Faction> factions)
    {
      var allTeams = factions.SelectMany(x => x.PossibleTeams);
    } 
    
    private static int TeamSetupScore(PossibleTeamSetup possibleTeamSetup)
    {
      var orderedTeams = possibleTeamSetup._teams.OrderBy(team => team.Size).ToList();
      return orderedTeams.Last().Size - orderedTeams.First().Size;
    }
  }
}