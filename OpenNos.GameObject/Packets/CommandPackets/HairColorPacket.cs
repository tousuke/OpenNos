﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject
{
    [PacketHeader("$HairColor")]
    public class HairColorPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public HairColorType HairColor { get; set; }

        #endregion
    }
}