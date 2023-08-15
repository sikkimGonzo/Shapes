namespace ShapesLib;

public class Circle : Shape
{
    public double Radius { get; init; }

    public Circle(double radius)
    {
        if(radius > 0)
        {
            Radius = radius;
        }
        else
        {
            throw new ArgumentException("Circle is not exist");
        }
    }

    public override double GetArea()
        => Math.Pow(Radius, 2) * Math.PI;
}