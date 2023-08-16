using ShapesLib;
using ShapesLib.Exceptions;

namespace ShapesTests.ShapesTestData;

public static class TriangleTestData
{
    public static readonly IEnumerable<object[]> NonExistentTrianglesData =
		new[]
		{
			new object[] { 0, 0, 0},
			new object[] { 2, 0, 0},
			new object[] { 0, 2, 0},
			new object[] { 0, 0, 2},
			new object[] { 2, 3, 0},
			new object[] { 0, 2, 3},
			new object[] { 2, 0, 3},
			new object[] { 1, 2, 3},
			new object[] { 1, 3, 2},
			new object[] { 2, 1, 3},
            new object[] { 2, 3, 1},
			new object[] { 3, 1, 2},
			new object[] { 3, 2, 1},
			new object[] { -2, 1, 3},
			new object[] { 2, -1, 3},
			new object[] { 2, 1, -3},
			new object[] { -1, -1, -5},          
		};
    
    public static readonly IEnumerable<object[]> TrianglesAndAreasData =
        new[]
        {
            new object[] {5.5, 6.1, 8.4, 16.7570880525},
            new object[] {4, 2, 3, 2.9047375097},
			new object[] {5, 5, 5, 10.8253175473}
        };

    public static readonly IEnumerable<object[]> RectangularTrianglesData =
        new[]
        {
            new object[] {6, 8, 10},
            new object[] {4, 3, 5},
        };
}