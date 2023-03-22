using ShapesLib;

public class Shape : IShape
{
    private readonly IShape _shape;

    public Shape(IShape shape)
    {
        _shape = shape;
    }

    public double GetArea()
    {
        return _shape.GetArea();
    }

    public bool IsCorrectInput()
    {
        return _shape.IsCorrectInput();
    }
}