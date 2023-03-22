using ShapesLib;

public class Triangle : ITriangle
{
    public double A { get; set; }

    public double B { get; set; }

    public double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public bool IsCorrectInput()
    {
        bool sumOfTwoSidesIsGreaterThanThird = A + B > C && A + C > B && B + C > A;
        bool eachArgIsGreaterThanZero = A > 0 && B > 0 && C > 0;
        return sumOfTwoSidesIsGreaterThanThird && eachArgIsGreaterThanZero;
    }

    public bool IsRectangular()
    {
        if(!IsCorrectInput())
        {
            throw new ArgumentException();
        }
        double hypotenuse = Math.Max(Math.Max(A, B), C);
        return GetArea() == (A * B * C) / (2 * hypotenuse);
    }

    public double GetArea()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
