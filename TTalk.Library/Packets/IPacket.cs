﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTalk.Library.Packets
{
    public interface IPacket
    {
        public int Id { get; }

        

        public static IPacket FromByteArray(byte[] data)
        {
            return new PacketReader(data).Read();
        }
    }
}
