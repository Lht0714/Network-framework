//This code create by CodeEngine

using System;
using Google.ProtocolBuffers;
using System.Collections;
namespace SPacket.SocketInstance
{
    /// <summary>
    /// µ•≥ÈCD
    /// </summary>
    public class CG_ASK_GAIN_FELLOWHandler : Ipacket
    {
        public uint Execute(PacketDistributed ipacket)
        {
            CG_ASK_GAIN_FELLOW packet = (CG_ASK_GAIN_FELLOW)ipacket;
            if (null == packet) return (uint)PACKET_EXE.PACKET_EXE_ERROR;
            //enter your logic
            return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
        }
    }
}
