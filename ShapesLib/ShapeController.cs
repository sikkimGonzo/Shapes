using ShapesLib;

public class ShapeController
{
    private readonly IShape _shape;

    public ShapeController(IShape shape)
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