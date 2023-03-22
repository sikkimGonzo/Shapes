using ShapesLib;

namespace ShapesLib.Tests;

public class TriangleTests
{
    [Fact]
    public void AreaIsDouble()
    {
        double a = 2;
        double b = 3;
        double c = 4;
        double expected = 2.90;

        ShapeController triangle = new ShapeController(new Triangle(a, b, c));

        Assert.Equal(expected, Math.Round(triangle.GetArea(), 2));
    }

    [Theory]
    [InlineData(1, 2, 0)]
    [InlineData(1, 0, 2)]
    [InlineData(0, 2, 3)]
    [InlineData(1, 0, 0)]
    [InlineData(0, 0, 3)]
    [InlineData(0, 2, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(2, 3, 5)]
    [InlineData(5, 2, 3)]
    [InlineData(5, 3, 2)]
    [InlineData(-1 , 3, 4)]
    [InlineData(-1 , 3, -4)]
    [InlineData(-1 , -3, -4)]
    public void IsCorrectInput(double a, double b, double c)
    {
        bool expected = false;

        ShapeController triangle = new ShapeController(new Triangle(a, b, c));

        Assert.Equal(expected, triangle.IsCorrectInput());
    }

    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 4, 3)]
    [InlineData(4, 3, 5)]
    [InlineData(3, 5, 4)]
    [InlineData(4, 5, 3)]
    [InlineData(5, 3, 4)]
    [InlineData(10, 6, 8)]
    [InlineData(8, 10, 6)]
    public void IsRectangular(double a, double b, double c)
    {
        bool expected = true;

        TirangleController tc = new TirangleController(new Triangle(a, b, c));

        Assert.Equal(expected, tc.IsRectangular());
    }
}