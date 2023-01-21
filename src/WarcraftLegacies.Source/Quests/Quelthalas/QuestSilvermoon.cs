using System.Collections.Generic;
using MacroTools;
using MacroTools.ControlPointSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.LegendSystem;
using MacroTools.ObjectiveSystem.Objectives.ControlPointBased;
using MacroTools.ObjectiveSystem.Objectives.FactionBased;
using MacroTools.ObjectiveSystem.Objectives.TimeBased;
using MacroTools.ObjectiveSystem.Objectives.UnitBased;
using MacroTools.QuestSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Quelthalas
{
  /// <summary>
  /// Kill the Trolls attacking Silvermoon.
  /// </summary>
  public sealed class QuestSilvermoon : QuestData
  {
    private readonly unit _elvenRunestone;
    private readonly Capital _silvermoon;
    private readonly Capital _sunwell;
    private readonly List<unit> _rescueUnits;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestSilvermoon"/> class.
    /// </summary>
    public QuestSilvermoon(Rectangle rescueRect, unit elvenRunestone, PreplacedUnitSystem preplacedUnitSystem,
      Capital silvermoon, Capital sunwell) : base("The Siege of Silvermoon",
      "The Amani Trolls have been harassing Silvermoon since it's founding, but their defensive position within their jungle has made the prospect of an all-out assault too costly. Today, however, the Amani begins their largest siege yet. They leave us no choice; we must scour Zul'aman if the High Elves are to prosper.",
      "ReplaceableTextures\\CommandButtons\\BTNForestTrollTrapper.blp")
    {
      _elvenRunestone = elvenRunestone;
      _silvermoon = silvermoon;
      _sunwell = sunwell;
      AddObjective(new ObjectiveKillUnit(
        preplacedUnitSystem.GetUnit(Constants.UNIT_O00O_CHIEFTAN_OF_THE_AMANI_TRIBE_CREEP_ZUL_AMAN)));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.Instance.GetFromUnitType(Constants.UNIT_N01V_ZUL_AMAN_20GOLD_MIN)));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.Instance.GetFromUnitType(Constants.UNIT_N01L_EVERSONG_WOODS_20GOLD_MIN)));
      AddObjective(new ObjectiveUpgrade(Constants.UNIT_H03T_PALACE_QUEL_THALAS_T3, Constants.UNIT_H033_STEADING_QUEL_THALAS_T1));
      AddObjective(new ObjectiveExpire(1480));
      AddObjective(new ObjectiveSelfExists());
      ResearchId = Constants.UPGRADE_R02U_QUEST_COMPLETED_THE_SIEGE_OF_SILVERMOON;
      _rescueUnits = rescueRect.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures);
      Required = true;
      ResearchId = Constants.UPGRADE_R02U_QUEST_COMPLETED_THE_SIEGE_OF_SILVERMOON;
    }
    
    /// <inheritdoc />
    protected override string RewardFlavour =>
      "The Amani trolls have been eliminated, settling a racial feud that had persisted for millenia.";

    /// <inheritdoc />
    protected override string RewardDescription =>
      "Control of all units in Silvermoon and enable Anasterian to be trained at the Altar";

    /// <inheritdoc />
    protected override void OnFail(Faction completingFaction) => 
      Player(PLAYER_NEUTRAL_AGGRESSIVE).RescueGroup(_rescueUnits);

    /// <inheritdoc />
    protected override void OnComplete(Faction completingFaction)
    {
      completingFaction.Player.RescueGroup(_rescueUnits);
      if (UnitAlive(_elvenRunestone))
        _silvermoon.Unit?.SetInvulnerable(true);
      _sunwell.Unit?.SetInvulnerable(true);
      if (GetLocalPlayer() == completingFaction.Player)
        PlayThematicMusic("war3mapImported\\SilvermoonTheme.mp3");
    }
  }
}