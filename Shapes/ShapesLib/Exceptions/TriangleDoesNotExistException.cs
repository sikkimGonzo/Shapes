using System.Net;

namespace ShapesLib.Exceptions;
public class TriangleDoesNotExistException : Exception
{
    public TriangleDoesNotExistException(double edgeA, double edgeB, double edgeC, Exception? innerException = null)
        : base($"Треугольник со сторонами {edgeA}, {edgeB}, {edgeC} не существует", innerException)
    {
        EdgeA = edgeA;
        EdgeB = edgeB;
        EdgeA = edgeC;
    }
    
    public double EdgeA { get; }

    public double EdgeB { get; }

    public double EdgeC { get; }    
}