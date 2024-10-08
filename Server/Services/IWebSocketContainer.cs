﻿using System.Net.WebSockets;

namespace Wbskt.Server.Services
{
    public interface IWebSocketContainer
    {
        Task Listen(WebSocket webSocket, Guid channelSubscriberId, int clientId);

        void SendMessage(Guid channelSubscriberId, string message);
    }
}
