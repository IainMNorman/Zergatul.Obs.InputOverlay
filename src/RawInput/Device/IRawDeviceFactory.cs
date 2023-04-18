using System;

namespace Earthware.PrimeGskMirror.GamepadHandler.RawInput.Device;

public interface IRawDeviceFactory : IDisposable
{
    RawDevice FromHDevice(IntPtr hDevice);
}