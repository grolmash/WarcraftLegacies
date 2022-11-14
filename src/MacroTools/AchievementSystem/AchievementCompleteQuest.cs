using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;

namespace MacroTools.AchievementSystem
{
  public sealed class AchievementCompleteQuest : Achievement
  {
    private readonly QuestData _quest;

    public override int Id => 0;
    public override string Title => _quest.Title;
    public override string Description => $"Complete the quest {_quest.Title}";
    public override string Icon => _quest.Icon;

    public AchievementCompleteQuest(QuestData quest)
    {
      _quest = quest;
      AddObjective(new ObjectiveCompleteQuest(quest));
    }
  }
}