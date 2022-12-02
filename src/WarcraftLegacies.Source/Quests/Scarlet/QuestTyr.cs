using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Scarlet
{
  public sealed class QuestTyr : QuestData
  {
    private readonly List<unit> _rescueUnits = new();

    public QuestTyr(Rectangle rescueRect) : base("The Scarlet Enclave",
      "The legions at Tyr's Hand remain neutral for the moment, but when the time is right, they will align themselves with the Scarlet Crusade.",
      "ReplaceableTextures\\CommandButtons\\BTNCastle.blp")
    {
      AddObjective(new ObjectiveTime(1000));
      AddObjective(new ObjectiveSelfExists());
      ResearchId = FourCC("R03R");

      foreach (var unit in CreateGroup().EnumUnitsInRect(rescueRect).EmptyToList())
        if (GetOwningPlayer(unit) == Player(PLAYER_NEUTRAL_PASSIVE))
        {
          SetUnitInvulnerable(unit, true);
          _rescueUnits.Add(unit);
        }
    }

    protected override string CompletionPopup =>
      "Tyr's Hand has joined the war and its military is now free to assist the Alliance.";

    protected override string RewardDescription => "Control of all units in Tyr's Hand";

    protected override void OnFail(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(completingFaction.Player);
    }
  }
}