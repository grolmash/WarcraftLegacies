using System;
using MacroTools.QuestSystem;
using static War3Api.Common;

namespace MacroTools.AchievementSystem
{
  public abstract class Achievement
  {
    public abstract int Id { get; }
    
    public abstract string Title { get; }
    
    public abstract string Description { get; }
    
    public abstract string Icon { get; }

    public bool IsComplete = true;

    public void AddObjective(Objective objective)
    {
      objective.ProgressChanged += (_, _) =>
      {
        try
        {
          AchievementManager.SaveAchievementId(Id, Player(0));
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex);
        }
      };
    }
  }
}