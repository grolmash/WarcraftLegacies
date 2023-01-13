﻿using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives.FactionBased;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.Legends;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Ironforge
{
  /// <summary>
  /// Ironforge allies with the Dark Iron and gets cool stuff.
  /// </summary>
  public sealed class QuestDarkIron : QuestData
  {
    private const int HeroId = Constants.UNIT_H03G_EMPEROR_OF_BLACKROCK_IRONFORGE;
    private readonly List<unit> _rescueUnits;
    
    /// <summary>
    /// Initializes a new instance of the <see cref="QuestDarkIron"/> class.
    /// </summary>
    public QuestDarkIron(Rectangle shadowforgeCity) : base("Dark Iron Alliance",
      "The Dark Iron dwarves are renegades. Bring Magni to their capital to open negotiations for an alliance.",
      "ReplaceableTextures\\CommandButtons\\BTNRPGDarkIron.blp")
    {
      AddObjective(new ObjectiveCapitalDead(LegendFelHorde.LegendBlacktemple));
      AddObjective(new ObjectiveLegendInRect(LegendIronforge.LegendMagni, shadowforgeCity,
        "Shadowforge City"));
      AddObjective(new ObjectiveSelfExists());
      ResearchId = Constants.UPGRADE_R01A_QUEST_COMPLETED_DARK_IRON_ALLIANCE;
      _rescueUnits = shadowforgeCity.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures);
    }

    /// <inheritdoc />
    protected override string RewardFlavour =>
      "The peace talk were succesful, The Dark Iron will join the Dwarven Empire.";

    /// <inheritdoc />
    protected override string RewardDescription =>
      "You gain control of Shadowforge City and can train the hero Dagran Thaurassian from the Altar of Fortitude";

    /// <inheritdoc />
    protected override void OnComplete(Faction completingFaction)
    {
      completingFaction.Player?.RescueGroup(_rescueUnits);
    }
    
    /// <inheritdoc />
    protected override void OnFail(Faction failingFaction)
    {
      Player(PLAYER_NEUTRAL_AGGRESSIVE).RescueGroup(_rescueUnits);
    }

    /// <inheritdoc />
    protected override void OnAdd(Faction whichFaction)
    {
      whichFaction.ModObjectLimit(HeroId, 1);
    }
  }
}