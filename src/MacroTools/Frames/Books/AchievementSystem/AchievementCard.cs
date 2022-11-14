using MacroTools.AchievementSystem;
using static War3Api.Common;

namespace MacroTools.Frames.Books.AchievementSystem
{
  public sealed class AchievementCard : Card
  {
    private const float BoxWidth = 0.20f;
    private const float BoxHeight = 0.152f;

    /// <summary>
    /// Initializes a new instance of the <see cref="AchievementCard"/> class.
    /// </summary>
    /// <param name="achievement">The <see cref="Achievement"/> being represented.</param>
    /// <param name="parent"><inheritdoc /></param>
    public AchievementCard(Achievement achievement, Frame parent) : base(parent, BoxWidth, BoxHeight)
    {
      var icon = new Frame("BACKDROP", "ArtifactIcon", this)
      {
        Width = 0.04f,
        Height = 0.04f,
        Texture = achievement.Icon,
        Visible = true
      };
      icon.SetPoint(FRAMEPOINT_LEFT, this, FRAMEPOINT_LEFT, 0.015f, -0.0090f);
      AddFrame(icon);

      var title = new TextFrame("ArtifactItemTitle", this, 0)
      {
        Text = achievement.Title,
        Width = BoxWidth - 0.04f,
        Height = 0,
        Visible = true
      };
      title.SetPoint(FRAMEPOINT_CENTER, this, FRAMEPOINT_CENTER, 0, 0.0255f);
      AddFrame(title);

      var text = new TextFrame("ArtifactItemOwnerText", this, 0);
      text.SetPoint(FRAMEPOINT_TOPLEFT, icon, FRAMEPOINT_TOPRIGHT, 0.007f, 0);
      text.SetPoint(FRAMEPOINT_BOTTOMLEFT, icon, FRAMEPOINT_BOTTOMRIGHT, 0.007f, 0);
      text.SetPoint(FRAMEPOINT_RIGHT, this, FRAMEPOINT_RIGHT, -0.007f, 0);
      text.Text = achievement.Description + (achievement.IsComplete ? " (Complete)" : " NotComplete");
      text.Visible = true;
      AddFrame(text);
    }
  }
}