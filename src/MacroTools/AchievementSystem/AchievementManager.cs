using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static War3Api.Common;
using WCSharp.SaveLoad;
using WCSharp.Shared;

namespace MacroTools.AchievementSystem
{
  public static class AchievementManager
  {
    private static readonly List<Achievement> Achievements = new();

    private static SaveSystem<SavedAchievements>? SavedAchievements;
    
    public static ReadOnlyCollection<Achievement> GetAllAchievements() => Achievements.AsReadOnly();
    
    public static void Register(Achievement achievement)
    {
      Achievements.Add(achievement);
    }

    public static void LoadSavedAchievements()
    {
      foreach (var player in Util.EnumeratePlayers())
      {
        SavedAchievements?.Load(player);
      }
    }

    public static void SaveAchievementId(int id, player whichPlayer)
    {
      Console.WriteLine("a");
      if (!SavesByPlayer.ContainsKey(whichPlayer))
      {
        SavesByPlayer.Add(whichPlayer, new SavedAchievements());
        Console.WriteLine("b");
      }
      
      Console.WriteLine("c");
      SavesByPlayer[whichPlayer].CompletedAchievementIds.Add(id);
      Console.WriteLine("d");
      SavedAchievements.Save(SavesByPlayer[whichPlayer]);
      Console.WriteLine("e");
    }

    public static void Setup()
    {
      SavedAchievements = new SaveSystem<SavedAchievements>(new SaveSystemOptions
      {
        SaveFolder = "Achievements",
        Salt = "CoolBeans",
        Hash1 = 5784787,
        Hash2 = 2889641,
        BindSavesToPlayerName = true,
      });
      SavedAchievements.OnSaveLoaded += OnSaveLoaded;
      LoadSavedAchievements();
    }

    private static void OnSaveLoaded(SavedAchievements save, bool isemptysave)
    {
      SavesByPlayer[save.GetPlayer()] = save;
    }

    public static Dictionary<player, SavedAchievements> SavesByPlayer { get; set; } = new();
  }
}