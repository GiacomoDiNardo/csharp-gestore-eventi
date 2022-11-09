// See https://aka.ms/new-console-template for more information





using System.Runtime.Serialization;

[Serializable]
internal class TitoloException : Exception
{
    public TitoloException()
    {
    }

    public TitoloException(string? message) : base(message)
    {
    }

    public TitoloException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected TitoloException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}