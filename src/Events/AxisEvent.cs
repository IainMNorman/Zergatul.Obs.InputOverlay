using Earthware.PrimeGskMirror.GamepadHandler.RawInput.Device;

namespace Earthware.PrimeGskMirror.GamepadHandler.Events;

public readonly struct AxisEvent
{
    public RawGamepadDevice Gamepad { get; }
    public Axis Axis { get; }

    public AxisEvent(RawGamepadDevice gamepad, Axis axis)
    {
        Gamepad = gamepad;
        Axis = axis;
    }
}