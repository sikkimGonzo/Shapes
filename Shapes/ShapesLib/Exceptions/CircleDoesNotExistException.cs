using System.Net;

namespace ShapesLib.Exceptions;
public class CircleDoesNotExistException : Exception
{
    public CircleDoesNotExistException(Exception? innerException = null)
        : base("Круг с такими параметрами не существует", innerException)
    {
    }
    
}