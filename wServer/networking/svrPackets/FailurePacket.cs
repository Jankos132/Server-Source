﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wServer.networking.svrPackets
{
    public class FailurePacket : ServerPacket
    {
        public string Message { get; set; }

        public override PacketID ID { get { return PacketID.Failure; } }
        public override Packet CreateInstance() { return new FailurePacket(); }

        protected override void Read(NReader rdr)
        {
            Message = rdr.ReadUTF();
        }

        protected override void Write(NWriter wtr)
        {
            wtr.WriteUTF(Message);
        }
    }
}
