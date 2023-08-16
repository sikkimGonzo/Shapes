using ShapesLib.Exceptions;

namespace ShapesTests.ShapesTestData;

public static class CirclesTestData
{
    public static readonly IEnumerable<object[]> NonExistentCirclesData =
        new[]
        {
            new object[] {0},
            new object[] {-4},
			new object[] {-0.3}
        };

    public static readonly IEnumerable<object[]> CirclesAndAreasData =
        new[]
        {
            new object[] {5, 78.5398163397},
            new object[] {3, 28.2743338823},
			new object[] {0.3, 0.2827433388}
        };
}