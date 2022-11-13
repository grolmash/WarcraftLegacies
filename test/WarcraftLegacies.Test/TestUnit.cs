using War3Api.Object;

namespace WarcraftLegacies.Test
{
  public sealed class TestUnit
  {
    public Unit Unit { get; }

    public TestUnit(Unit unit)
    {
      Unit = unit;
    }

    public override string ToString() => Unit.IsTextNameModified ? Unit.TextName : Unit.NewId.ToString();
  }
}