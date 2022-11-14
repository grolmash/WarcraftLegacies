using System;
using System.Collections.Generic;
using System.Linq;
using MacroTools.AchievementSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace MacroTools.Frames.Books.AchievementSystem
{
  public sealed class AchievementBook : Book<AchievementPage>
  {
    private const float BottomButtonYOffset = 0.015f;
    private const float BottomButtonXOffset = 0.02f;
    private const float BookWidth = 0.65f;
    private const float BookHeight = 0.37f;
    
    private static bool _initialized;
    private readonly Dictionary<Achievement, AchievementPage> _pagesByAchievement = new();
    private static AchievementBook? _instance;
    
    private AchievementBook(float width, float height, float bottomButtonXOffset, float bottomButtonYOffset) : base(width,
      height, bottomButtonXOffset, bottomButtonYOffset)
    {
      AddPagesAndAchievements();
      BookTitle = "Achievements";
      LauncherParent = BlzGetFrameByName("UpperButtonBarChatButton", 0);
      Position = new Point(0.4f, 0.38f);
    }

    private void AddPagesAndAchievements()
    {
      var firstPage = AddPage();
      firstPage.Visible = true;
      AddAllAchievements();
    }
    
    public static void Initialize()
    {
      if (_initialized) return;
      LoadToc(@"ArtifactSystem.toc");
      LoadToc(@"ui\framedef\framedef.toc");
      _instance = new AchievementBook(BookWidth, BookHeight, BottomButtonXOffset, BottomButtonYOffset);
      _initialized = true;
    }
    
    private void AddAllAchievements()
    {
      foreach (var achievement in AchievementManager.GetAllAchievements())
        AddAchievement(achievement);
    }
    
    private void AddAchievement(Achievement achievement)
    {
      var lastPage = Pages.Last();
      if (lastPage.CardCount >= lastPage.CardLimit)
      {
        AddPage();
        lastPage = Pages.Last();
      }
      lastPage.AddAchievement(achievement);
      _pagesByAchievement.Add(achievement, lastPage);
    }
    
    private static void LoadToc(string tocFilePath)
    {
      if (!BlzLoadTOCFile(tocFilePath)) throw new Exception($"Failed to load TOC {tocFilePath}");
    }
  }
}