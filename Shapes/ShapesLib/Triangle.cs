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
            throw new ArgumentException("Triangle is not exist");
        }
    }

    public override double GetArea()
    {
        double p = (EdgeA + EdgeB + EdgeC) / 2;
        return Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
    }

    public bool IsRectangular()
    {
        double eps = 1e-9;
        double hypotenuse = Math.Max(Math.Max(EdgeA, EdgeB), EdgeC);
        double rectanularArea = (EdgeA * EdgeB * EdgeC) / (2 * hypotenuse);
        return Math.Abs(GetArea() - rectanularArea) < eps;
    }
}