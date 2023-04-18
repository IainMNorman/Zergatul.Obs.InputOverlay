using Earthware.PrimeGskMirror.GamepadHandler.Events;
using Earthware.PrimeGskMirror.GamepadHandler.RawInput.Device;

using System;
using System.Collections.Generic;

namespace Earthware.PrimeGskMirror.GamepadHandler.RawInput;

public interface IRawDeviceInput : IDisposable
{
    IReadOnlyDictionary<IntPtr, RawDevice> Devices { get; }
    event Action<ButtonEvent> ButtonAction;
    event Action<MoveEvent> MoveAction;
    event Action<AxisEvent> AxisAction;
    event Action<DeviceEvent> DeviceAction;
}