// See https://aka.ms/new-console-template for more information





using System.Runtime.Serialization;

public class CapienzaException : Exception
{
    public CapienzaException()
    {
    }

    public CapienzaException(string? message) : base(message)
    {
    }

    public CapienzaException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected CapienzaException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}