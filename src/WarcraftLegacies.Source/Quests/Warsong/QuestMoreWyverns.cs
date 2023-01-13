using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Warsong
{
  public sealed class QuestMoreWyverns : QuestData
  {
    private const int LIMIT_CHANGE = 2;
    
    private static readonly int UnittypeId = FourCC("owyv");

    public QuestMoreWyverns() : base("Perfect Warriors",
      "The prowess and savagery of the Sentinels is to be respected - and feared. They must be eliminated.",
      "ReplaceableTextures\\CommandButtons\\BTNArcher.blp")
    {
      AddObjective(new ObjectiveCapitalDead(LegendSentinels.Feathermoon));
      AddObjective(new ObjectiveCapitalDead(LegendSentinels.Auberdine));
    }
    
    protected override string RewardFlavour =>
      "The Sentinels have been eliminated. Warchief Thrall breathes a sigh of relief, knowing that his people are safe - for now.";

    protected override string RewardDescription =>
      $"Learn to train {I2S(LIMIT_CHANGE)} additional {GetObjectName(UnittypeId)}s";

    protected override void OnComplete(Faction completingFaction)
    {
      completingFaction.ModObjectLimit(UnittypeId, LIMIT_CHANGE);
      completingFaction.DisplayUnitLimit(UnittypeId);
    }
  }
}