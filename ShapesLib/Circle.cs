using ShapesLib;

public class Circle : IShape, ICircle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        if(!IsCorrectInput())
        {
            throw new ArgumentException();
        }
        return Math.Pow(Radius, 2) * Math.PI;
    }

    public bool IsCorrectInput()
    {
        return Radius > 0;
    }
}