using Earthware.PrimeGskMirror.GamepadHandler.XInput;

using Microsoft.Extensions.Logging;

using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

using Websocket.Client;
using Websocket.Client.Logging;

namespace Earthware.PrimeGskMirror.GamepadHandler;

public class GamepadHandler : IGamePadHandler
{
    private readonly IXInputHandler xinput;
    private readonly ILogger<WebSocketHandler> logger;
    private WebsocketClient client;
    private static int ypos;
    private static int leftStickYValue;
    private bool moving;
    private static readonly ManualResetEvent ExitEvent = new(false);

    public GamepadHandler(IXInputHandler xinput, ILogger<WebSocketHandler> logger)
    {
        this.xinput = xinput;
        this.logger = logger;
        this.xinput.OnStateChanged += XInputStateChanged;
        ypos = 1920;
        leftStickYValue = 0;
        this.moving = false;
        SetupClient();
    }

    private void SetupClient()
    {
        var url = new Uri("ws://127.0.0.1:4455");

        using (client = new WebsocketClient(url))
        {
            client.Name = "GamepadHandler";
            client.ReconnectTimeout = null;
            client.ErrorReconnectTimeout = TimeSpan.FromSeconds(1);

            client.ReconnectionHappened.Subscribe(info =>
            {
                logger.LogInformation($"Reconnection happened, type: {info.Type}, url: {client.Url}");
            });

            client.DisconnectionHappened.Subscribe(info =>
            {
                logger.LogWarning($"Disconnection happened, type: {info.Type}");
                logger.LogWarning($"Desc: {info.CloseStatusDescription}");
            });

            client.ReconnectionHappened.Subscribe(info =>
            {
                logger.LogInformation($"Reconnection happened, type: {info.Type}");
            });

            //client.MessageReceived.Subscribe(msg =>
            //{
            //    logger.LogInformation($"Message received: {msg}");
            //});

            Connect();
        }
    }

    private void Connect()
    {
        logger.LogInformation("Starting...");
        client.Start().Wait();
        Task.Run(() => Identify(client));
        logger.LogInformation("Started.");
        
        Task.Run(() => SendMove(client));
        ExitEvent.WaitOne();
    }

    private async Task SendMove(IWebsocketClient client)
    {
        logger.LogInformation("Send move started");

        while (true)
        {
            await Task.Delay(33);
            var currentLeftStickYValue = leftStickYValue;
            if (currentLeftStickYValue > 100 || currentLeftStickYValue < -100)
            {
                //logger.LogInformation(ypos.ToString());
                var currentYpos = ypos;

                var moveBy = currentLeftStickYValue / 1000;

                currentYpos += moveBy;
                await Move(client, currentYpos);

                ypos = currentYpos;
            }
        }
    }

    private async Task Move(IWebsocketClient client, int yPos)
    {
        //logger.LogInformation("Moving to " + yPos.ToString());
        client.Send($$"""
                {
                  "op": 8,
                  "d": {
                    "requestId": "{{Guid.NewGuid()}}",
                    "requests": [
                        {
                            "requestType": "SetSceneItemTransform",
                            "requestData": {
                              "sceneName": "Output",
                              "sceneItemId": 1,
                              "sceneItemTransform": {
                                  "cropRight": {{yPos}}
                              }
                            }
                        },
                        {
                            "requestType": "SetSceneItemTransform",
                            "requestData": {
                              "sceneName": "Output",
                              "sceneItemId": 13,
                              "sceneItemTransform": {
                                  "positionX": {{(1920 * 2) - yPos - 240}}
                              }
                            }
                        }
                    ]
                  }
                }
                """);
    }

    private async Task StartProjector(IWebsocketClient client)
    {
        client.Send("""
                {
                  "op": 6,
                  "d": {
                    "requestType": "OpenSourceProjector",
                    "requestId": "f819dcf0-89cc-11eb-8f0e-382c4ac93b9c",
                    "requestData": {
                      "sourceName": "Output",
                      "monitorIndex": 0
                      }
                  }
                }
                """);
    }

    private async Task Identify(IWebsocketClient client)
    {
        await Task.Delay(500);

        client.Send("""
                {
                  "op": 1,
                  "d": {
                    "rpcVersion": 1
                  },
                 "eventSubscriptions": 1
                }
                """);        

        logger.LogInformation($"Connected to OBS and Identified");

        await Task.Delay(1000);

        await Move(client, ypos);

        await Task.Delay(1000);

        await StartProjector(client);
    }

    private void XInputStateChanged(GamepadState state)
    {
        leftStickYValue = state.LeftStickY;
    }
}
