using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Fel_Horde
{
  public sealed class QuestFelHordeKillIronforge : QuestData
  {
    private const int UNIT_LIMIT = 4;
    private static readonly int UnittypeId = FourCC("nina");
    private static readonly int BuildingId = FourCC("o030");

    public QuestFelHordeKillIronforge() : base("Felsteel Refining",
      "The smiths of Ironforge have long been put to use crafting goods and war machinery. In the hands of the Fel Horde, they could be used to smelt and refine the ultimate metal: Felsteel.",
      "ReplaceableTextures\\CommandButtons\\BTNInfernalFlameCannon.blp")
    {
      AddObjective(new ObjectiveCapitalDead(LegendIronforge.LegendGreatforge));
      ResearchId = FourCC("R011");
    }
    
    protected override string RewardFlavour =>
      "The Great Forge has been annihilated. The Fel Horde's peons immediately salvage its intact refineries and put them to purpose in the creation of Felsteel.";

    protected override string RewardDescription => "Learn to train " + I2S(UNIT_LIMIT) + " " +
                                                       GetObjectName(UnittypeId) + "s from the " +
                                                       GetObjectName(BuildingId) + " and acquire Felsteel Plating";
    
    protected override void OnAdd(Faction whichFaction)
    {
      whichFaction.ModObjectLimit(UnittypeId, UNIT_LIMIT);
    }
  }
}