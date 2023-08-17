using ShapesLib.Exceptions;

namespace ShapesLib;

public class Triangle : Shape
{
    public double EdgeA { get; init; }

    public double EdgeB { get; init; }

    public double EdgeC { get; init; }

    public Triangle(double edgeA, double edgeB, double edgeC)
    {
        var sumOfTwoSidesIsGreaterThanThird = 
            edgeA + edgeB > edgeC && edgeA + edgeC > edgeB && edgeC + edgeB > edgeA;
        if(sumOfTwoSidesIsGreaterThanThird)
        {
            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
        }
        else
        {
            throw new TriangleDoesNotExistException(edgeA, edgeB, edgeC);
        }
    }

    public override double GetArea()
    {
        double p = (EdgeA + EdgeB + EdgeC) / 2;
        return Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
    }

    public bool IsRectangular()
    {
        double hypotenuse = Math.Max(Math.Max(EdgeA, EdgeB), EdgeC);
        double legA = Math.Min(Math.Min(EdgeA, EdgeB), EdgeC);
        double legB = Math.Min(Math.Max(EdgeA, EdgeB), EdgeC);
        double legSquareSum = Math.Pow(legA, 2) + Math.Pow(legB, 2);
        return Math.Abs(Math.Pow(hypotenuse, 2) - legSquareSum) < ShapeCalculationAccuracy.Eps;
    }
}