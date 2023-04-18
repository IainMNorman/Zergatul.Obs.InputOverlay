using System;

namespace Earthware.PrimeGskMirror.GamepadHandler.XInput;

public interface IXInputHandler : IDisposable
{
    event Action<GamepadState> OnStateChanged;
}