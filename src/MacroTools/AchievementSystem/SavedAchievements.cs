using System.Collections.Generic;
using WCSharp.SaveLoad;

namespace MacroTools.AchievementSystem
{
  public class SavedAchievements : Saveable
  {
    public List<int> CompletedAchievementIds { get; set; } = new();
  }
}