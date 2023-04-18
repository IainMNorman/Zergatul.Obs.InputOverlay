using Earthware.PrimeGskMirror.GamepadHandler.RawInput.Device;

namespace Earthware.PrimeGskMirror.GamepadHandler.Events;

public readonly struct DeviceEvent
{
    public RawDevice Device { get; }
    public bool Attached { get; }

    public DeviceEvent(RawDevice device, bool attached)
    {
        Device = device;
        Attached = attached;
    }
}