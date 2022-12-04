using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Mechanics.Quelthalas
{
  public static class SilvermoonDies
  {
    private static void Dies()
    {
      SetUnitInvulnerable(LegendQuelthalas.LegendSunwell.Unit, false);
    }

    public static void Setup()
    {
      var trig = CreateTrigger();
      TriggerRegisterUnitEvent(trig, LegendQuelthalas.LegendSunwell.Unit, EVENT_UNIT_DEATH);
      TriggerAddAction(trig, Dies);
    }
  }
}