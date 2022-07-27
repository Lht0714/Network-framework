//This code create by CodeEngine

using System;
 using Google.ProtocolBuffers;
 using System.Collections;
using UnityEngine;

namespace SPacket.SocketInstance
 {
    /// <summary>
    /// 单抽 GC
    /// </summary>
     public class GC_ASK_GAIN_FELLOW_RETHandler : Ipacket
     {
         public uint Execute(PacketDistributed ipacket)
         {
             GC_ASK_GAIN_FELLOW_RET packet = (GC_ASK_GAIN_FELLOW_RET)ipacket;
             if (null == packet) return (uint)PACKET_EXE.PACKET_EXE_ERROR;

             int fellowId = packet.Fellowid;
             int fellowSatrLevel = packet.Fellowstarlevel;
             UInt64 fellowGuid = packet.Fellowguid;
            PlayerDataManager.Instance.FellowContainer.GetFellowByGuid(fellowGuid);
            //if (PartnerFrameLogic_Gamble.Instance())
            //{
            //    //播放特效
            //    if (BackCamerControll.Instance() != null)
            //    {
            //        BackCamerControll.Instance().PlaySceneEffect(137);
            //    }

            //    GameManager.gameManager.SoundManager.PlaySoundEffect(117);  //box

            //    PartnerFrameLogic_Gamble.Instance().UpdateMainInfo();
            //    PartnerFrameLogic_Gamble.Instance().UpdateGainPartner(fellowId, fellowSatrLevel, fellowGuid);
            //}
            Debug.Log("这是抽奖返回的消息：：：：：" + packet.Fellowid);
           // MessageCenter.Instance.OnBroadCast(MsgID.InitCurtList, fellow);

            //enter your logic
            return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
         }
     }
 }
//CG_ASK_GAIN_FELLOW fellowPacket = (CG_ASK_GAIN_FELLOW)PacketDistributed.CreatePacket(MessageID.PACKET_CG_ASK_GAIN_FELLOW);
//fellowPacket.SetGainTypee(3);
//fellowPacket.SendPacket();
