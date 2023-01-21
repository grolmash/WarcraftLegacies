﻿using MacroTools;
using MacroTools.Extensions;
using MacroTools.LegendSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;
#pragma warning disable CS1591

namespace WarcraftLegacies.Source.Setup.Legends
{
  /// <summary>
  /// Responsible for creating and storing all Lordaeron <see cref="Legend"/>s.
  /// </summary>
  public sealed class LegendLordaeron : IRegistersLegends
  {
    public LegendaryHero Terenas { get; }
    public LegendaryHero Uther { get; }
    public LegendaryHero Arthas { get; }
    public LegendaryHero Mograine { get; }
    public LegendaryHero Garithos { get; }
    public LegendaryHero Goodchild { get; }
    public Capital CapitalPalace { get; }
    public Capital Stratholme { get; }
    public Capital TyrsHand { get; }

    /// <summary>
    /// Sets up all Lordaeron <see cref="Legend"/>s.
    /// </summary>
    public LegendLordaeron(PreplacedUnitSystem preplacedUnitSystem, ArtifactSetup artifactSetup)
    {
      Terenas = new LegendaryHero("Terenas Menethil")
      {
        Unit = preplacedUnitSystem.GetUnit(Constants.UNIT_NEMI_KING_TERENAS_MENETHIL_LORDAERON)
      };
      CreateTrigger()
       .RegisterUnitEvent(Terenas.Unit, EVENT_UNIT_DEATH)
       .AddAction(() =>
       {
         artifactSetup.CrownOfLordaeron.Item.SetPosition(Regions.King_Arthas_crown.Center);
       });

      Mograine = new LegendaryHero("Alexandros Mograine")
      {
        UnitType = Constants.UNIT_H01J_THE_ASHBRINGER_LORDAERON,
        StartingXp = 2800
      };

      Garithos = new LegendaryHero("Garithos")
      {
        UnitType = Constants.UNIT_HLGR_GRAND_MARSHAL_SCARLET,
        StartingXp = 2800
      };

      Goodchild = new LegendaryHero("High Commander Goodchilde")
      {
        UnitType = Constants.UNIT_E000_IMPROVED_ANCIENT_PROTECTOR_DRUID_TOWER,
        StartingXp = 2800
      };

      CapitalPalace = new Capital
      {
        Unit = preplacedUnitSystem.GetUnit(Constants.UNIT_H000_CAPITAL_PALACE_LORDAERON),
        DeathMessage = "The capital city of Lordaeron has been razed, and King Terenas is dead."
      };
      CapitalPalace.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H006_IMPROVED_GUARD_TOWER_LORDAERON_TOWER, new Point(8686, 8862)));
      CapitalPalace.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H006_IMPROVED_GUARD_TOWER_LORDAERON_TOWER, new Point(9476, 8843)));
      CapitalPalace.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H007_IMPROVED_CANNON_TOWER_LORDAERON_TOWER, new Point(8638, 9342)));
      CapitalPalace.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H007_IMPROVED_CANNON_TOWER_LORDAERON_TOWER, new Point(9545, 9372)));
      CreateTrigger()
        .RegisterUnitEvent(CapitalPalace.Unit, EVENT_UNIT_DEATH)
        .AddAction(() =>
        {
          Terenas.Unit.Kill();
          SetDoodadAnimation(Regions.King_Arthas_crown.Center.X, Regions.King_Arthas_crown.Center.Y, 200,
            FourCC("Ysaw"), false, "hide", false);
          SetDoodadAnimation(Regions.King_Arthas_crown.Center.X, Regions.King_Arthas_crown.Center.Y, 200,
            FourCC("D044"), false, "hide", false);
          SetDoodadAnimation(Regions.King_Arthas_crown.Center.X, Regions.King_Arthas_crown.Center.Y, 200,
            FourCC("YObb"), false, "hide", false);
          SetDoodadAnimationRect(Regions.Terenas.Rect, FourCC("YScr"), "show", false);
          DestroyTrigger(GetTriggeringTrigger());
        });

      Stratholme = new Capital
      {
        Unit = preplacedUnitSystem.GetUnit(Constants.UNIT_H01G_STRATHOLME_CASTLE_LORDAERON_OTHER),
        DeathMessage = "The majestic city of Stratholme has been destroyed."
      };
      Stratholme.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H006_IMPROVED_GUARD_TOWER_LORDAERON_TOWER, new Point(14067, 12242)));
      Stratholme.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H006_IMPROVED_GUARD_TOWER_LORDAERON_TOWER, new Point(14553, 11593)));
      Stratholme.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H006_IMPROVED_GUARD_TOWER_LORDAERON_TOWER, new Point(15359, 11612)));

      TyrsHand = new Capital
      {
        Unit = preplacedUnitSystem.GetUnit(Constants.UNIT_H030_TYR_S_HAND_CITADEL_LORDAERON_OTHER),
        DeathMessage = "Tyr's Hand, the bastion of human power in Lordaeron, has fallen."
      };
      TyrsHand.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_HCTW_CANNON_TOWER_LORDAERON_TOWER, new Point(20652, 8057)));
      TyrsHand.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H007_IMPROVED_CANNON_TOWER_LORDAERON_TOWER, new Point(20024, 8123)));
      TyrsHand.AddProtector(preplacedUnitSystem.GetUnit(Constants.UNIT_H007_IMPROVED_CANNON_TOWER_LORDAERON_TOWER, new Point(20042, 7420)));

      Uther = new LegendaryHero("Uther the Lightbringer")
      {
        UnitType = Constants.UNIT_HUTH_LEADER_OF_THE_SILVER_HAND_LORDAERON,
        DeathMessage =
          "Uther the Lightbringer makes his last stand, perishing in the defense of the light. Lordaeron, and humanity itself, has lost one of its finest exemplars in this dark hour.",
        PlayerColor = PLAYER_COLOR_LIGHT_BLUE,
        StartingXp = 1000
      };

      Arthas = new LegendaryHero("Arthas Menethil")
      {
        UnitType = Constants.UNIT_HART_CROWN_PRINCE_OF_LORDAERON_LORDAERON
      };
    }

    /// <inheritdoc />
    public void RegisterLegends()
    {
      LegendaryHeroManager.Register(Terenas);
      LegendaryHeroManager.Register(Uther);
      LegendaryHeroManager.Register(Arthas);
      LegendaryHeroManager.Register(Mograine);
      LegendaryHeroManager.Register(Garithos);
      LegendaryHeroManager.Register(Goodchild);
      CapitalManager.Register(CapitalPalace);
      CapitalManager.Register(Stratholme);
      CapitalManager.Register(TyrsHand);
    }
  }
}