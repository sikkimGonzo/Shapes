using ShapesTests.ShapesTestData;
using static ShapesTests.ShapesTestData.TriangleTestData;
using ShapesLib.Exceptions;
using ShapesLib;

namespace ShapesLib.Tests;

public class TriangleTests
{
    [Theory(DisplayName = "Площадь треугольника вычисляется верно")]
    [MemberData(memberName: nameof(TrianglesAndAreasData), MemberType = typeof(TriangleTestData))]
    public void GetTriangleArea(double edgeA, double edgeB, double edgeC, double area)
    {
        bool expected = true;

        Shape shape = new Triangle(edgeA, edgeB, edgeC);

        Assert.Equal(expected, Math.Abs(area - shape.GetArea()) < ShapeCalculationAccuracy.Eps);
    }

    [Theory(DisplayName = "При вводе некорректных значений сторон вызывается TriangleDoesNotExistException")]
    [MemberData(memberName: nameof(NonExistentTrianglesData), MemberType = typeof(TriangleTestData))]
    public void IncorrectArguments(double edgeA, double edgeB, double edgeC)
    {
        Assert.Throws<TriangleDoesNotExistException>(() => new Triangle(edgeA, edgeB, edgeC));
    }

    [Theory(DisplayName = "Треугольник является прямоугольным")]
    [MemberData(memberName: nameof(RectangularTrianglesData), MemberType = typeof(TriangleTestData))]
    public void IsRectangular(double edgeA, double edgeB, double edgeC)
    {
        bool expected = true;

        Triangle triangle = new Triangle(edgeA, edgeB, edgeC);

        Assert.Equal(expected, triangle.IsRectangular());
    }
}