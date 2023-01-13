using MacroTools.QuestSystem;

namespace MacroTools.ObjectiveSystem.Objectives.QuestBased
{
  public sealed class ObjectiveDontCompleteQuest : Objective
  {
    public ObjectiveDontCompleteQuest(QuestData target)
    {
      Description = "Do not complete the quest " + target.Title;
      target.ProgressChanged += OnQuestProgressChanged;
      Progress = QuestProgress.Complete;
    }

    private void OnQuestProgressChanged(object? sender, QuestProgressChangedEventArgs args)
    {
      if (args.Quest.Progress == QuestProgress.Complete) 
        Progress = QuestProgress.Failed;
    }
  }
}