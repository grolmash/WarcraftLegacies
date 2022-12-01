using MacroTools.ArtifactSystem;
using MacroTools.FactionSystem;
using static War3Api.Common;

namespace MacroTools.QuestSystem.UtilityStructs
{
  /// <summary>
  /// Completes when a particular <see cref="Legend"/> has a particular <see cref="Artifact"/>.
  /// </summary>
  public sealed class ObjectiveLegendHasArtifact : Objective
  {
    private readonly Artifact _targetArtifact;
    private readonly Legend _targetLegend;

    /// <summary>
    /// Initializes a new instance of the <see cref="ObjectiveLegendHasArtifact"/> class.
    /// </summary>
    public ObjectiveLegendHasArtifact(Legend targetLegend, Artifact targetArtifact)
    {
      Description = $"{targetLegend.Name} has {GetItemName(targetArtifact.Item)}";
      _targetLegend = targetLegend;
      _targetArtifact = targetArtifact;
      targetArtifact.PickedUp += OnPickedUp;
    }

    internal override void OnAdd(Faction whichFaction)
    {
      if (_targetArtifact.OwningUnit != null && _targetArtifact.OwningUnit == _targetLegend.Unit) 
        Progress = QuestProgress.Complete;
    }

    private void OnPickedUp(object? sender, Artifact artifact)
    {
      Progress =_targetArtifact.OwningUnit != null && _targetArtifact.OwningUnit == _targetLegend.Unit
        ? QuestProgress.Complete
        : QuestProgress.Incomplete;
    }
  }
}