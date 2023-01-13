using MacroTools.Extensions;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace MacroTools.SpellSystem
{
  /// <summary>
  /// Provides methods for casting abilities through a dummy unit.
  /// </summary>
  public static class DummyCast
  {
    private static readonly group TempGroup = CreateGroup();

    public delegate bool CastFilter(unit caster, unit target);

    public static void ChannelOnPoint(unit caster, int abilityId, string orderId, int level, Point targetPoint, float duration)
    {
      CreateUnit(GetOwningPlayer(caster), DummyCaster.UnitTypeId, targetPoint.X, targetPoint.Y, 0)
        .AddAbility(abilityId)
        .IssueOrder(orderId)
        .SetTimedLife(duration);
    }
    
    public static void DummyChannelInstantFromPoint(player whichPlayer, int abilId, string orderId, int level,
      float x, float y, float duration)
    {
      unit u = CreateUnit(whichPlayer, DummyCaster.UnitTypeId, x, y, 0);
      UnitAddAbility(u, abilId);
      IssueImmediateOrder(u, orderId);
      UnitApplyTimedLife(u, FourCC("BTLF"), duration);
    }

    /// <summary>
    /// Causes the specified ability to be cast from the specified object at the specified target.
    /// </summary>
    public static void DummyCastUnit(unit caster, int abilId, string orderId, int level, unit target, DummyCastOriginType originType)
    {
      var originPoint = originType == DummyCastOriginType.Caster ? caster.GetPosition() : target.GetPosition();
      DummyCaster.DummyUnit
        .SetOwner(caster.OwningPlayer())
        .SetPosition(originPoint)
        .AddAbility(abilId)
        .SetAbilityLevel(abilId, level)
        .IssueOrder(orderId, target)
        .RemoveAbility(abilId);
    }

    public static void DummyCastPoint(player whichPlayer, int abilId, string orderId, int level, float x, float y)
    {
      SetUnitOwner(DummyCaster.DummyUnit, whichPlayer, false);
      SetUnitX(DummyCaster.DummyUnit, x);
      SetUnitY(DummyCaster.DummyUnit, y);
      UnitAddAbility(DummyCaster.DummyUnit, abilId);
      SetUnitAbilityLevel(DummyCaster.DummyUnit, abilId, level);
      IssuePointOrder(DummyCaster.DummyUnit, orderId, x, y);
      UnitRemoveAbility(DummyCaster.DummyUnit, abilId);
    }

    public static void DummyCastInstant(player whichPlayer, int abilId, string orderId, int level, float x, float y)
    {
      SetUnitOwner(DummyCaster.DummyUnit, whichPlayer, false);
      SetUnitX(DummyCaster.DummyUnit, x);
      SetUnitY(DummyCaster.DummyUnit, y);
      UnitAddAbility(DummyCaster.DummyUnit, abilId);
      SetUnitAbilityLevel(DummyCaster.DummyUnit, abilId, level);
      IssueImmediateOrder(DummyCaster.DummyUnit, orderId);
      UnitRemoveAbility(DummyCaster.DummyUnit, abilId);
    }

    public static void DummyCastUnitFromPoint(player whichPlayer, int abilId, string orderId, int level, unit u,
      float originX, float originY)
    {
      SetUnitOwner(DummyCaster.DummyUnit, whichPlayer, false);
      SetUnitX(DummyCaster.DummyUnit, originX);
      SetUnitY(DummyCaster.DummyUnit, originY);
      UnitAddAbility(DummyCaster.DummyUnit, abilId);
      SetUnitAbilityLevel(DummyCaster.DummyUnit, abilId, level);
      IssueTargetOrder(DummyCaster.DummyUnit, orderId, u);
      UnitRemoveAbility(DummyCaster.DummyUnit, abilId);
    }

    public static void DummyCastFromPointOnUnitsInCircle(unit caster, int abilId, string orderId, int level,
      float targetX, float targetY, float radius, float originX, float originY, CastFilter castFilter)
    {
      unit u;
      GroupEnumUnitsInRange(TempGroup, targetX, targetY, radius, null);
      while (true)
      {
        u = FirstOfGroup(TempGroup);
        if (u == null)
        {
          break;
        }

        if (castFilter(caster, u))
        {
          DummyCastUnitFromPoint(GetOwningPlayer(caster), abilId, orderId, level, u, originX, originY);
        }

        GroupRemoveUnit(TempGroup, u);
      }
    }

    public static void DummyCastUnitId(player whichPlayer, int abilId, int orderId, int level, unit u)
    {
      SetUnitOwner(DummyCaster.DummyUnit, whichPlayer, false);
      SetUnitX(DummyCaster.DummyUnit, GetUnitX(u));
      SetUnitY(DummyCaster.DummyUnit, GetUnitY(u));
      UnitAddAbility(DummyCaster.DummyUnit, abilId);
      SetUnitAbilityLevel(DummyCaster.DummyUnit, abilId, level);
      IssueTargetOrderById(DummyCaster.DummyUnit, orderId, u);
      UnitRemoveAbility(DummyCaster.DummyUnit, abilId);
    }

    public static void DummyCastOnUnitsInCircle(unit caster, int abilId, string orderId, int level, Point center,
      float radius, CastFilter castFilter, DummyCastOriginType originType)
    {
      foreach (var target in CreateGroup()
                 .EnumUnitsInRange(center, radius).EmptyToList()
                 .FindAll(unit => castFilter(caster, unit)))
      {
        DummyCastUnit(caster, abilId, orderId, level, target, originType);
      }
    }
  }
}