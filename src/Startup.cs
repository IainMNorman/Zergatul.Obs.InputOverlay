using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net;
using Earthware.PrimeGskMirror.GamepadHandler.RawInput.Device;
using Earthware.PrimeGskMirror.GamepadHandler.XInput;
using Earthware.PrimeGskMirror.GamepadHandler.RawInput;
using System.Net.WebSockets;

namespace Earthware.PrimeGskMirror.GamepadHandler;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IWebSocketHandler, WebSocketHandler>();
        services.AddSingleton<IRawDeviceInput, RawDeviceInput>();
        services.AddSingleton<IRawDeviceFactory, RawDeviceFactory>();
        services.AddSingleton<IXInputHandler, XInputHandler>();
        services.AddSingleton<IGamePadHandler, GamepadHandler>();

        services.AddLogging(builder =>
        {
            builder.ClearProviders();
            builder.AddConsole();
        });
    }

    public void Configure(IApplicationBuilder app, IHostApplicationLifetime hostAppLifetime, IGamePadHandler gamePadHandler)
    {
        string[] addresses = app.ServerFeatures.Get<IServerAddressesFeature>().Addresses.ToArray();

        app.UseDefaultFiles();
        app.UseStaticFiles();    
    }

    private bool OriginMatch(string origin1, string origin2)
    {
        Uri uri1 = new Uri(origin1);
        Uri uri2 = new Uri(origin2);
        return uri1.Scheme == uri2.Scheme && string.Equals(uri1.Host, uri2.Host, StringComparison.OrdinalIgnoreCase) && uri1.Port == uri2.Port;
    }
}