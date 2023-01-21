using MacroTools.FactionSystem;
using MacroTools.LegendSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.FactionSetup;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Scourge
{
  public sealed class QuestKelthuzadLich : QuestData
  {
    private readonly LegendaryHero _kelthuzad;
    private const int UnittypeKelthuzadLich = Constants.UNIT_UKTL_ARCHLICH_OF_THE_SCOURGE_SCOURGE_LICH;

    public QuestKelthuzadLich(Capital sunwell, LegendaryHero kelthuzad) : base("Into the Realm Eternal",
      "Kel'thuzad is the leader of the Cult of the Damned and an extraordinarily powerful necromancer. If he were to be brought to the Sunwell and submerged in its waters, he would be reanimated as an immortal Lich.",
      "ReplaceableTextures\\CommandButtons\\BTNLichVersion2.blp")
    {
      _kelthuzad = kelthuzad;
      AddObjective(new ObjectiveControlCapital(sunwell, false));
      AddObjective(new ObjectiveLegendInRect(kelthuzad, Regions.Sunwell, "The Sunwell"));
      Required = true;
    }

    /// <inheritdoc />
    protected override string RewardFlavour
    {
      get
      {
        var completionPopup =
          "Kel'thuzad has been reanimated and empowered through the unlimited magical energies of the Sunwell.";
        if (LegionSetup.Legion != null)
          completionPopup += " He now has the ability to summon the Burning Legion.";
        return completionPopup;
      }
    }

    /// <inheritdoc />
    protected override string RewardDescription => "Kel'thuzad becomes a Lich";

    /// <inheritdoc />
    protected override void OnComplete(Faction completingFaction)
    {
      _kelthuzad.UnitType = UnittypeKelthuzadLich;
      _kelthuzad.PermaDies = false;
      SetUnitState(_kelthuzad.Unit, UNIT_STATE_LIFE,
        GetUnitState(_kelthuzad.Unit, UNIT_STATE_MAX_LIFE));
      SetUnitState(_kelthuzad.Unit, UNIT_STATE_MANA,
        GetUnitState(_kelthuzad.Unit, UNIT_STATE_MAX_MANA));
      DestroyEffect(AddSpecialEffect("war3mapImported\\Soul Beam Blue.mdx",
        GetUnitX(_kelthuzad.Unit),
        GetUnitY(_kelthuzad.Unit)));
      DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\FrostNova\\FrostNovaTarget.mdl",
        GetUnitX(_kelthuzad.Unit), GetUnitY(_kelthuzad.Unit)));
    }
  }
}