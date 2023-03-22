namespace ShapesLib;

public class CircleController : ShapeController
{
    private readonly ICircle _circle;

    public CircleController(ICircle circle) : base(circle)
    {
        _circle = circle;
    }
}