using ShapesTests.ShapesTestData;
using static ShapesTests.ShapesTestData.CirclesTestData;
using ShapesLib.Exceptions;
using ShapesLib;

namespace ShapesLib.Tests;

public class CircleTests
{
    [Theory(DisplayName = "Площадь круга вычисляется верно")]
    [MemberData(memberName: nameof(CirclesAndAreasData), MemberType = typeof(CirclesTestData))]
    public void GetArea(double radius, double area)
    {
        bool expected = true;

        Shape shape = new Circle(radius);

        Assert.Equal(expected, Math.Abs(shape.GetArea() - area) < ShapeCalculationAccuracy.Eps);
    }

    [Theory(DisplayName = "При вводе некорректного значения радиуса вызывается CircleDoesNotExistException")]
    [MemberData(memberName: nameof(NonExistentCirclesData), MemberType = typeof(CirclesTestData))]
    public void IncorrectArguments(double radius)
    {
        Assert.Throws<CircleDoesNotExistException>(() => new Circle(radius));
    }
}