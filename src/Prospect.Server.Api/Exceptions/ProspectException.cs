using System.Runtime.Serialization;

namespace LaCunaServer.Server.Api.Exceptions;

public class LaCunaServerException : Exception
{
    public LaCunaServerException()
    {
    }

    protected LaCunaServerException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public LaCunaServerException(string message) : base(message)
    {
    }

    public LaCunaServerException(string message, Exception innerException) : base(message, innerException)
    {
    }
}