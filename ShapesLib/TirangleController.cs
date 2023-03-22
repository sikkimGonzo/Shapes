namespace ShapesLib;

public class TirangleController : ShapeController
{
    private readonly ITriangle _triangle;

    public TirangleController(ITriangle triangle) : base(triangle)
    {
        _triangle = triangle;
    }

    public bool IsRectangular()
    {
        return _triangle.IsRectangular();
    }
}