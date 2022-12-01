﻿using System;
using MacroTools.Augments;
using MacroTools.BookSystem.Augments;
using static War3Api.Common;

namespace MacroTools.Cheats
{
   public static class CheatAugment
   {
      private const string Command = "-augment";

      private static void Actions()
      {
         try
         {
            if (!TestMode.CheatCondition()) return;
            var triggerPlayer = GetTriggerPlayer();
            var augmentSelectionWindow = new AugmentPage
            {
               Visible = true,
               Width = 0.5f,
               Height = 0.39f
            };
            augmentSelectionWindow.SetAbsPoint(FRAMEPOINT_CENTER, 0.4f, 0.36f);
            augmentSelectionWindow.AddAugments(AugmentSystem.GetRandomAugments(triggerPlayer, 3));
            augmentSelectionWindow.PageNumber = 1;
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex);
         }
         finally
         {
            DisplayTextToPlayer(GetTriggerPlayer(), 0, 0, "|cffD27575CHEAT:|r Attempted to display Augment selection window.");
         }
      }

      public static void Setup()
      {
         var trig = CreateTrigger();
         foreach (var player in WCSharp.Shared.Util.EnumeratePlayers()) TriggerRegisterPlayerChatEvent(trig, player, Command, false);
         TriggerAddAction(trig, Actions);
      }
   }
}