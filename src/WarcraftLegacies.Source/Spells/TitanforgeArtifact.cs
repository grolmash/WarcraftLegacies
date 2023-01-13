using System;
using MacroTools.ArtifactSystem;
using MacroTools.Extensions;
using MacroTools.SpellSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Spells
{
  /// <summary>
  /// Makes a held <see cref="Artifact"/> stronger permanently.
  /// </summary>
  public sealed class TitanForgeArtifact : Spell
  {
    private readonly int _goldCost;
    private readonly int _lumberCost;

    /// <inheritdoc />
    public TitanForgeArtifact(int id, int goldCost, int lumberCost) : base(id)
    {
      _goldCost = goldCost;
      _lumberCost = lumberCost;
    }
    
    /// <inheritdoc />
    public override void OnCast(unit caster, unit target, Point targetPoint)
    {
      try
      {
        var heldItem = UnitItemInSlot(GetTriggerUnit(), 0);
        if (heldItem == null)
        {
          Refund(GetTriggerPlayer());
          return;
        }

        var heldArtifact = ArtifactManager.GetFromTypeId(GetItemTypeId(heldItem));
        if (heldArtifact != null && !heldArtifact.Titanforged)
        {
          heldArtifact.Titanforge();
          return;
        }

        Refund(GetTriggerPlayer());
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
      }
    }

    private void Refund(player whichPlayer)
    {
      whichPlayer.AddGold(_goldCost);
      whichPlayer.AddLumber(_lumberCost);
    }
  }
}