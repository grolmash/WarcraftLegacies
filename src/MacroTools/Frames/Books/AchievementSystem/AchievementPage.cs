using System;
using System.Collections.Generic;
using MacroTools.AchievementSystem;

namespace MacroTools.Frames.Books.AchievementSystem
{
  public sealed class AchievementPage : Page
  {
    private readonly Dictionary<Achievement, AchievementCard> _cardsByArtifact = new();

    public AchievementPage()
    {
      Rows = 2;
      Columns = 3;
      YOffsetTop = 0.025f;
      YOffsetBot = 0.05f;
    }

    /// <summary>
    ///   Renders an Artifact on this MenuPage as an ArtifactCard.
    /// </summary>
    public void AddAchievement(Achievement achievement)
    {
      if (CardCount >= CardLimit)
        throw new Exception($"ArtifactPage is already at the card limit of {CardLimit} cards.");
      var achievementCard = new AchievementCard(achievement, this);
      PositionFrameAtIndex(achievementCard, Cards.Count);
      Cards.Add(achievementCard);
      AddFrame(achievementCard);
      _cardsByArtifact.Add(achievement, achievementCard);
    }
  }
}