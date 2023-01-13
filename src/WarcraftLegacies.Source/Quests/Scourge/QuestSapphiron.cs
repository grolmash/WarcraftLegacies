using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.ObjectiveSystem.Objectives.UnitBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Scourge
{
  public sealed class QuestSapphiron : QuestData
  {
    private static readonly int SapphironId = FourCC("ubdd");
    private static readonly int SapphironResearch = FourCC("R025");
    
    public QuestSapphiron(unit sapphiron) : base("Sapphiron", "Kill Sapphiron the Blue Dragon to have Kel'Tuzad reanimate her as a Frost Wyrm. Sapphiron can be found in Northrend.", "ReplaceableTextures\\CommandButtons\\BTNFrostWyrm.blp")
    {
      AddObjective(new ObjectiveKillUnit(sapphiron));
      AddObjective(new ObjectiveControlLegend(LegendScourge.Kelthuzad, false));
    }
    
    protected override string RewardFlavour =>
      "Sapphiron has been slain, and has been reanimated as a mighty Frost Wyrm under the command of the Scourge.";

    protected override string RewardDescription => "The demihero Sapphiron";

    protected override void OnComplete(Faction completingFaction)
    {
      CreateUnit(completingFaction.Player, SapphironId, GetUnitX(GetTriggerUnit()), GetUnitY(GetTriggerUnit()),
        GetUnitFacing(GetTriggerUnit()));
      SetPlayerTechResearched(completingFaction.Player, SapphironResearch, 1);
    }

    protected override void OnAdd(Faction whichFaction)
    {
      whichFaction.ModObjectLimit(SapphironResearch, Faction.UNLIMITED);
    }
  }
}