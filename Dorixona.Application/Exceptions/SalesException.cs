namespace Dorixona.Application.Exceptions;

public sealed class SalesException : Exception
{
    public SalesException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
