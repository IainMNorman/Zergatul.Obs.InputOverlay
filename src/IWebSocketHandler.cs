using System;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace Earthware.PrimeGskMirror.GamepadHandler;

public interface IWebSocketHandler : IDisposable
{
    Task HandleWebSocket(WebSocket ws);
}