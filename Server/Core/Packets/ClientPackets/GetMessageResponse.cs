﻿using System;
using xServer.Core.Networking;


namespace xServer.Core.Packets.ClientPackets
{
    [Serializable]
    public class GetMessageResponse : IPacket
    {
        public string Message { get; set; }
        public string Sender { get; set; }

        public GetMessageResponse()
        {

        }
        public GetMessageResponse(string message, string sender)
        {
            this.Sender = sender;
            this.Message = message;
        }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}
