namespace ShapesLib;

public class Triangle : Shape
{
    public readonly double _a;

    public readonly double _b;

    public readonly double _c;

    public Triangle(double a, double b, double c)
    {
        var sumOfTwoSidesIsGreaterThanThird = 
            a + b > c && a + c > b && c + b > a;
        if(sumOfTwoSidesIsGreaterThanThird)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        else
        {
            throw new ArgumentException("Triangle is not exist");
        }
    }

    public override double GetArea()
    {
        double p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    public bool IsRectangular()
    {
        double eps = 1e-9;
        double hypotenuse = Math.Max(Math.Max(_a, _b), _c);
        double rectanularArea = (_a * _b * _c) / (2 * hypotenuse);
        return Math.Abs(GetArea() - rectanularArea) < eps;
    }
}