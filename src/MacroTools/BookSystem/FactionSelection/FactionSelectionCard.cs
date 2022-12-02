using MacroTools.FactionSystem;
using MacroTools.Frames;
using static War3Api.Common;

namespace MacroTools.BookSystem.FactionSelection
{
  public sealed class FactionSelectionCard : Card
  {
    private readonly Faction _faction;
    private Button _chooseButton;
    private const float BoxWidth = 0.13f;
    private const float BoxHeight = 0.086f;

    public FactionSelectionCard(Faction faction, Frame parent) : base(parent, BoxWidth, BoxHeight)
    {
      _faction = faction;
      var icon = new Frame("BACKDROP", "ArtifactIcon", this)
      {
        Width = 0.04f,
        Height = 0.04f,
        Texture = faction.Icon
      };
      icon.SetPoint(FRAMEPOINT_LEFT, this, FRAMEPOINT_LEFT, 0.015f, -0.0090f);
      AddFrame(icon);

      var title = new TextFrame("ArtifactItemTitle", this, 0)
      {
        Text = faction.Name,
        Width = BoxWidth - 0.04f,
        Height = 0
      };
      title.SetPoint(FRAMEPOINT_CENTER, this, FRAMEPOINT_CENTER, 0, 0.0255f);
      AddFrame(title);
      
      _chooseButton = new Button("ScriptDialogButton", this, 0)
      {
        Width = 0.062f,
        Height = 0.027f,
        Text = "Choose",
        Visible = false,
      };
      _chooseButton.SetPoint(FRAMEPOINT_LEFT, this, FRAMEPOINT_LEFT, 0.057f, -0.009f);
      AddFrame(_chooseButton);
    }
  }
}