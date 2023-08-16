using System.Net;

namespace ShapesLib.Exceptions;
public class TriangleDoesNotExistException : Exception
{
    public TriangleDoesNotExistException(Exception? innerException = null)
        : base("Треугольник с такими параметрами не существует", innerException)
    {
    }
    
}