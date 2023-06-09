using ShapesLib;

namespace ShapesLib.Tests;

public class CircleTests
{
    [Fact]
    public void AreaIsDouble()
    {
        double radius = 4;
        double expected = 50.27;

        ShapeController circle = new ShapeController(new Circle(radius));

        Assert.Equal(expected, Math.Round(circle.GetArea(), 2));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void IsCorrectInput(double radius)
    {
        ShapeController circle = new ShapeController(new Circle(radius));

        bool expected = false;

        Assert.Equal(expected, circle.IsCorrectInput());
    }
}