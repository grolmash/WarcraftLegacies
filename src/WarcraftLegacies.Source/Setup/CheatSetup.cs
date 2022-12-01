﻿using MacroTools.Cheats;
using MacroTools.CommandSystem;
using WarcraftLegacies.Source.Cheats;

namespace WarcraftLegacies.Source.Setup
{
  public static class CheatSetup
  {
    public static void Setup()
    {
      TestMode.Setup();
      CheatBuild.Setup();
      CheatControl.Setup();
      CheatFaction.Setup();
      CheatFood.Setup();
      CheatGold.Setup();
      CheatHasResearch.Setup();
      CheatHp.Setup();
      CheatKick.Setup();
      CheatLevel.Setup();
      CheatLumber.Setup();
      CheatMana.Setup();
      CheatMp.Setup();
      CheatNocd.Setup();
      CheatOwner.Setup();
      CheatRemove.Setup();
      CheatSkipCinematic.Setup();
      CheatSpawn.Setup();
      CheatTele.Setup();
      CheatTime.Setup();
      CheatUncontrol.Setup();
      CheatVision.Setup();
      CheatCompleteQuest.Setup();
      CheatAddRandomAugment.Setup();
      CheatAugment.Setup();
      CommandManager.Register(new CommandTeam());
      CommandManager.Register(new CommandAddSpell());
      CommandManager.Register(new CommandSetResearchLevel());
      CommandManager.Register(new CommandDestroy());
      CommandManager.Register(new CheatGod());
    }
  }
}