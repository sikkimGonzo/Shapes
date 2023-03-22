using ShapesLib;

// Класс для демонстрации DI шаблона
// В целом можно обойтись созданием объектов через IShape
public class Shape
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
