﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xLightClient.Core.Networking;
using xLightClient.Core.Registry;

namespace xLightClient.Core.Packets.ClientPackets
{
    [Serializable]
    public class GetRegistryKeysResponse : IPacket
    {
        public RegSeekerMatch[] Matches { get; set; }

        public string RootKey { get; set; }

        public bool IsError { get; set; }
        public string ErrorMsg { get; set; }

        public GetRegistryKeysResponse()
        { }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}
