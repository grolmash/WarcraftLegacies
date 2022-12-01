using System.Collections.Generic;
using MacroTools;
using WarcraftLegacies.Source.Quests.Draenei;
using WarcraftLegacies.Source.Setup.FactionSetup;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup.QuestSetup
{
  public static class DraeneiQuestSetup
  {
    public static void Setup(PreplacedUnitSystem preplacedUnitSystem)
    {
      var draenei = DraeneiSetup.Draenei;

      var questExiled = new QuestExiled
      {
        GoldMine = preplacedUnitSystem.GetUnit(FourCC("ngol"), Regions.TempestKeep.Center),
        KilledOnFail = new List<unit>
        {
          preplacedUnitSystem.GetUnit(Constants.UNIT_O02P_CRYSTAL_HALL_DRAENEI)
        },
        TheExodar = preplacedUnitSystem.GetUnit(Constants.UNIT_H09W_THE_EXODAR)
      };
      draenei.StartingQuest = draenei.AddQuest(questExiled);
      draenei.AddQuest(new QuestWarnBase(Regions.Halaar, "Halaar", "ReplaceableTextures\\CommandButtons\\BTNCallToArms.blp"));
      draenei.AddQuest(new QuestWarnBase(Regions.Shattrah, "Shattrah", "ReplaceableTextures\\CommandButtons\\BTNCallToArms.blp"));
      draenei.AddQuest(new QuestWarnBase(Regions.Farahlon, "Farahlon", "ReplaceableTextures\\CommandButtons\\BTNCallToArms.blp"));
      draenei.AddQuest(new QuestSurvivorsShattrah());
      draenei.AddQuest(new QuestFirstWave(preplacedUnitSystem));
      draenei.AddQuest(new QuestBrokenOne());
      draenei.AddQuest(new QuestShipArgus(
        questExiled,
        preplacedUnitSystem.GetUnit(Constants.UNIT_H03V_ENTRANCE_PORTAL, Regions.OutlandToArgus.Center),
        preplacedUnitSystem.GetUnit(Constants.UNIT_H03V_ENTRANCE_PORTAL, Regions.TempestKeepSpawn.Center)
        ));
      draenei.AddQuest(new QuestTriumvirate());
    }
  }
}