namespace ShapesLib;

public class Circle : Shape
{
    public readonly double _radius;

    public Circle(double radius)
    {
        if(radius > 0)
        {
            _radius = radius;
        }
        else
        {
            throw new ArgumentException("Circle is not exist");
        }
    }

    public override double GetArea()
        => Math.Pow(_radius, 2) * Math.PI;
}