using System;
using System.Runtime.InteropServices;

namespace Earthware.PrimeGskMirror.GamepadHandler;

public class WinApiException : Exception
{
    public WinApiException()
        : this(null)
    {

    }

    public WinApiException(string message)
        : base(message)
    {
        HResult = Marshal.GetLastWin32Error();
    }
}