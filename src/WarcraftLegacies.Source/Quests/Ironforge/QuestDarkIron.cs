using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
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
    private readonly List<unit> _rescueUnits = new();
    
    /// <summary>
    /// Initializes a new instance of the <see cref="QuestDarkIron"/> class.
    /// </summary>
    public QuestDarkIron(Rectangle shadowforgeCity) : base("Dark Iron Alliance",
      "The Dark Iron dwarves are renegades. Bring Magni to their capital to open negotiations for an alliance.",
      "ReplaceableTextures\\CommandButtons\\BTNRPGDarkIron.blp")
    {
      AddObjective(new ObjectiveControlLegend(LegendFelHorde.LegendBlacktemple, false));
      AddObjective(new ObjectiveLegendInRect(LegendIronforge.LegendMagni, Regions.Shadowforge_gate,
        "Shadowforge"));
      AddObjective(new ObjectiveSelfExists());
      ResearchId = Constants.UPGRADE_R01A_QUEST_COMPLETED_DARK_IRON_ALLIANCE;
      foreach (var unit in CreateGroup().EnumUnitsInRect(shadowforgeCity).EmptyToList())
        if (unit.OwningPlayer() == Player(PLAYER_NEUTRAL_PASSIVE))
        {
          unit.SetInvulnerable(true);
          _rescueUnits.Add(unit);
          if (!IsUnitType(unit, UNIT_TYPE_STRUCTURE))
          {
            unit.Show(false);
          }
        }
    }

    /// <inheritdoc />
    protected override string CompletionPopup =>
      "The peace talk were succesful, The Dark Iron will join the Dwarven Empire.";

    /// <inheritdoc />
    protected override string RewardDescription =>
      "You gain control of Shadowforge City and can train the hero Dagran Thaurassian from the Altar of Fortitude";

    /// <inheritdoc />
    protected override void OnComplete(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) 
        unit.Rescue(completingFaction.Player ?? Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }
    
    /// <inheritdoc />
    protected override void OnFail(Faction failingFaction)
    {
      foreach (var unit in _rescueUnits) 
        unit.Rescue(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    /// <inheritdoc />
    protected override void OnAdd(Faction whichFaction)
    {
      whichFaction.ModObjectLimit(HeroId, 1);
    }
  }
}