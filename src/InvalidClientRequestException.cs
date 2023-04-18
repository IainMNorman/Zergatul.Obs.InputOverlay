using System;

namespace Earthware.PrimeGskMirror.GamepadHandler;

public class InvalidClientRequestException : Exception
{
    public InvalidClientRequestException()
        : base()
    {

    }

    public InvalidClientRequestException(string message)
        : base(message)
    {

    }
}