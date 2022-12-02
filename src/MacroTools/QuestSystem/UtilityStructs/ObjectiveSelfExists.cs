using MacroTools.FactionSystem;

namespace MacroTools.QuestSystem.UtilityStructs
{
  public sealed class ObjectiveSelfExists : Objective
  {
    public ObjectiveSelfExists()
    {
      Progress = QuestProgress.Complete;
      ShowsInQuestLog = false;
    }

    internal override void OnAdd(Faction whichFaction)
    {
      Progress = QuestProgress.Complete;
      whichFaction.ScoreStatusChanged += OnAnyFactionScoreStatusChanged;
    }

    private void OnAnyFactionScoreStatusChanged(object? sender, Faction faction)
    {
      if (faction.Status == FactionStatus.Defeated) Progress = QuestProgress.Failed;
    }
  }
}