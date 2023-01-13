﻿using System.Linq;
using MacroTools.ControlPointSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace WarcraftLegacies.Source.GameLogic.GameEnd
{
  /// <summary>
  ///   When a Team gets a certain number of <see cref="ControlPoint" />s they win.
  /// </summary>
  public static class ControlPointVictory
  {
    /// <summary>
    /// The number of <see cref="ControlPoint"/>s a <see cref="Team"/> must acquire to win the game.
    /// </summary>
    public const int CpsVictory = 90;
    
    private const int CpsWarning = 80; //How many Control Points to start the warning at
    private const string VictoryColor = "|cff911499";
    private static bool _gameWon;

    /// <summary>
    /// Sets up <see cref="ControlPointVictory"/>.
    /// </summary>
    public static void Setup()
    {
      foreach (var controlPoint in ControlPointManager.Instance.GetAllControlPoints())
        controlPoint.ChangedOwner += ControlPointOwnerChanges;
    }
    
    private static int GetTeamControlPoints(Team whichTeam) => 
      whichTeam.GetAllFactions().Where(faction => faction.Player != null).Sum(faction => faction.Player.GetControlPointCount());

    private static void TeamWarning(Team whichTeam, int controlPoints) =>
      DisplayTextToPlayer(GetLocalPlayer(), 0, 0,
        $"\n{VictoryColor}TEAM VICTORY IMMINENT|r\n{whichTeam.Name} has captured {controlPoints} out of {CpsVictory} Control Points required to win the game!");

    private static void ControlPointOwnerChanges(object? sender,
      ControlPointOwnerChangeEventArgs controlPointOwnerChangeEventArgs)
    {
      if (_gameWon) 
        return;
      var newOwnerTeam = controlPointOwnerChangeEventArgs.ControlPoint.Owner.GetTeam();
      var formerOwnerTeam = controlPointOwnerChangeEventArgs.FormerOwner.GetTeam();
      if (newOwnerTeam == null || newOwnerTeam == formerOwnerTeam) return;
      var teamControlPoints = GetTeamControlPoints(newOwnerTeam);
      if (teamControlPoints >= CpsVictory)
        TeamVictory(newOwnerTeam);
      else if (teamControlPoints > CpsWarning) 
        TeamWarning(newOwnerTeam, teamControlPoints);
    }

    private static void TeamVictory(Team whichTeam)
    {
      ClearTextMessages();
      DisplayTextToPlayer(GetLocalPlayer(), 0, 0,
        $"{VictoryColor}\nTEAM VICTORY!|r\nThe {whichTeam.Name} has won the game! You may choose to continue playing.");
      PlayThematicMusic(whichTeam.VictoryMusic);
      _gameWon = true;
    }
  }
}
