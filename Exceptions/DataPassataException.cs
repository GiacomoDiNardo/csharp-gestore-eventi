// See https://aka.ms/new-console-template for more information





using System.Runtime.Serialization;

[Serializable]
internal class DataPassataException : Exception
{
    public DataPassataException()
    {
    }

    public DataPassataException(string? message) : base(message)
    {
    }

    public DataPassataException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected DataPassataException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}