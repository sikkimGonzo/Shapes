using System.Net;

namespace ShapesLib.Exceptions;
public class CircleDoesNotExistException : Exception
{
    public CircleDoesNotExistException(double radius, Exception? innerException = null)
        : base($"Круг с радиусом {radius} не существует", innerException)
    {
        Radius = radius;
    }
    
    public double Radius { get; }
}