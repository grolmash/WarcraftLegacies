﻿using System.Collections.Generic;
using WarcraftLegacies.Source.Quests.Sentinels;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WCSharp.Shared.Data;

namespace WarcraftLegacies.Source.Setup.QuestSetup
{
  public static class SentinelsQuestSetup
  {
    public static void Setup()
    {
      var sentinels = SentinelsSetup.Sentinels;

      sentinels.StartingQuest = sentinels.AddQuest(new QuestAstranaar(new List<Rectangle>
        {
          Regions.AstranaarUnlock, Regions.TeldrassilUnlock1, Regions.TeldrassilUnlock2
        }
      ));
      sentinels.AddQuest(new QuestFeathermoon(Regions.FeathermoonUnlock));
      sentinels.AddQuest(new QuestSentinelsKillWarsong());
      sentinels.AddQuest(new QuestSentinelsKillFrostwolf());
      //sentinels.AddQuest(new QuestMaievOutland(Regions.MaievStartUnlock));
      sentinels.AddQuest(new QuestScepterOfTheQueenSentinels(Regions.HighBourne));
      sentinels.AddQuest(new QuestVaultoftheWardens());
    }
  }
}