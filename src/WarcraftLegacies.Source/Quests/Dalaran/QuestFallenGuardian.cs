using MacroTools.ControlPointSystem;
using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives.ControlPointBased;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Dalaran
{
  public sealed class QuestFallenGuardian : QuestData
  {
    private static readonly int MedivhId = FourCC("Haah");

    public QuestFallenGuardian() : base("The Fallen Guardian",
      "Medivh's body was corrupted by Sargeras at conception. Now that he is dead, the secrets of the Tomb of Sargeras and Karazhan combined might allow the mages of Dalaran to cleanse his spirit.",
      "ReplaceableTextures\\CommandButtons\\BTNMedivh.blp")
    {
      AddObjective(new ObjectiveControlCapital(LegendNeutral.Karazhan, false));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.Instance.GetFromUnitType(FourCC("n00J"))));
      ResearchId = FourCC("R04K");
    }

    protected override string RewardFlavour =>
      "Medivh's spirit has been cleansed of Sargeras' influence, allowing him to return to Azeroth for a time.";

    protected override string RewardDescription => "You can summon Medivh from the Altar of Knowledge";

    protected override void OnAdd(Faction whichFaction)
    {
      whichFaction.ModObjectLimit(MedivhId, 1);
    }
  }
}