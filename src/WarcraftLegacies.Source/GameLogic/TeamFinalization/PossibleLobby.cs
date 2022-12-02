using System.Collections.Generic;
using System.Linq;
using MacroTools.FactionSystem;

namespace WarcraftLegacies.Source.GameLogic.TeamFinalization
{
  /// <summary>
  /// Resposible figuring out the best possible team setup to start the game with.
  /// </summary>
  public sealed class PossibleLobby
  {
    /// <summary>
    /// The configuration for the possible teams forming this possible lobby.
    /// </summary>
    public List<PossibleTeam> Teams { get; } = new();

    /// <summary>
    /// Returns the team setup which has the most equal number of players on each team.
    /// </summary>
    public static PossibleLobby GetBestPossibleLobby(List<Faction> factions) =>
      GetAllPossibleLobbies(factions).OrderBy(PossibleLobbyScore).Last();

    private static IEnumerable<PossibleLobby> GetAllPossibleLobbies(List<Faction> factions)
    {
      var possibleTeams = GetAllPossibleTeams(factions).ToList();
      var possibleLobby = new PossibleLobby();
      foreach (var outerTeam in possibleTeams)
      {
        possibleLobby.Teams.Add(outerTeam);
        foreach (var innerTeam in possibleTeams)
        {
          possibleLobby.Teams.Add(innerTeam);
          yield return possibleLobby;
        }
      }
    }

    private static IEnumerable<PossibleTeam> GetAllPossibleTeams(List<Faction> factions)
    {
      foreach (var team in factions.SelectMany(x => x.PossibleTeams))
      {
        var possibleTeam = new PossibleTeam(team);
        foreach (var outerFaction in factions)
        {
          if (outerFaction.PossibleTeams.Contains(team))
            possibleTeam.Add(outerFaction);
          foreach (var innerFaction in factions)
          {
            if (innerFaction.PossibleTeams.Contains(team))
              possibleTeam.Add(innerFaction);
            yield return possibleTeam;
          }
        }
      }
    }

    private static int PossibleLobbyScore(PossibleLobby possibleLobby)
    {
      var orderedTeams = possibleLobby.Teams.OrderBy(team => team.Size).ToList();
      return orderedTeams.Last().Size - orderedTeams.First().Size;
    }
  }
}