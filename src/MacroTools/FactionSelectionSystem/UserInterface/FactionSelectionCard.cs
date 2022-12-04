using MacroTools.BookSystem;
using MacroTools.Frames;
using static War3Api.Common;

namespace MacroTools.FactionSelectionSystem.UserInterface
{
  public sealed class FactionSelectionCard : Card
  {
    private readonly FactionSelection _factionSelection;
    private const float BoxWidth = 0.138f;
    private const float BoxHeight = 0.08f;
    private readonly Button _chooseButton;
    private readonly TextFrame _ownerDescription;
    
    public FactionSelectionCard(FactionSelection factionSelection, Frame parent) : base(parent, BoxWidth, BoxHeight)
    {
      _factionSelection = factionSelection;
      var icon = new Frame("BACKDROP", "ArtifactIcon", this)
      {
        Width = 0.04f,
        Height = 0.04f,
        Texture = factionSelection.Faction.Icon
      };
      icon.SetPoint(FRAMEPOINT_LEFT, this, FRAMEPOINT_LEFT, 0.015f, -0.0090f);
      AddFrame(icon);

      var title = new TextFrame("ArtifactItemTitle", this, 0)
      {
        Text = factionSelection.Faction.ColoredName,
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
        OnClick = _ =>
        {
          factionSelection.SelectForPlayer(GetTriggerPlayer());
        }
      };
      _chooseButton.SetPoint(FRAMEPOINT_LEFT, this, FRAMEPOINT_LEFT, 0.057f, -0.009f);
      AddFrame(_chooseButton);

      _ownerDescription = new TextFrame("ArtifactItemOwnerText", this, 0);
      _ownerDescription.SetPoint(FRAMEPOINT_TOPLEFT, icon, FRAMEPOINT_TOPRIGHT, 0.007f, 0);
      _ownerDescription.SetPoint(FRAMEPOINT_BOTTOMLEFT, icon, FRAMEPOINT_BOTTOMRIGHT, 0.007f, 0);
      _ownerDescription.SetPoint(FRAMEPOINT_RIGHT, this, FRAMEPOINT_RIGHT, -0.007f, 0);
      AddFrame(_ownerDescription);

      ReRender();
      factionSelection.Selected += (_, _) => ReRender();
    }

    private void ReRender()
    {
      if (_factionSelection.Player != null)
      {
        _ownerDescription.Text = GetPlayerName(_factionSelection.Player);
        _ownerDescription.Visible = true;
        _chooseButton.Visible = false;
      }
      else
      {
        _ownerDescription.Visible = false;
        _chooseButton.Visible = true;
      }
    }
  }
}