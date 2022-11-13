using FluentAssertions;
using War3Api.Object;
using War3Net.Build;
using Xunit;
using Xunit.Abstractions;

namespace WarcraftLegacies.Test;

public sealed class MapDataTests
{
  private readonly ITestOutputHelper _testOutputHelper;

  public MapDataTests(ITestOutputHelper testOutputHelper)
  {
    _testOutputHelper = testOutputHelper;
  }

  private const string BaseMapPath = @"..\..\..\..\..\maps\source.w3x";
  
  [Theory]
  [MemberData(nameof(UnitData))]
  public void AllBuildingsMentionUnitsTheyTrain(Unit unit)
  {
    if (!unit.StatsIsABuilding || !unit.IsTechtreeUnitsTrainedModified || !unit.IsTextTooltipExtendedModified)
    {
      _testOutputHelper.WriteLine(unit.TextName);
      _testOutputHelper.WriteLine(unit.StatsIsABuilding.ToString());
      _testOutputHelper.WriteLine(unit.IsTechtreeUnitsTrainedModified.ToString());
      _testOutputHelper.WriteLine(unit.IsTextTooltipExtendedModified.ToString());
      return;
    }
      
    var tooltipExtended = unit.TextTooltipExtended;
    foreach (var trainedUnit in unit.TechtreeUnitsTrained)
    {
      if (trainedUnit.IsTextNameModified)
      {
        _testOutputHelper.WriteLine(trainedUnit.TextName);
        tooltipExtended.Should().Contain(trainedUnit.TextName);
      }
    }
  }

  public static IEnumerable<object[]>? UnitData
  {
    get
    {
      var map = Map.Open(BaseMapPath);
      return GetObjectDatabaseFromMap(map).GetUnits()?.Select(x => new object[]
      {
        x
      }).ToList();
    }
  }
  
  private static ObjectDatabase GetObjectDatabaseFromMap(Map map)
  {
    var objectDatabase = new ObjectDatabase();
    if (map.UnitObjectData != null) objectDatabase.AddObjects(map.UnitObjectData);
    return objectDatabase;
  }
}