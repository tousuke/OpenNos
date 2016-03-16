//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Npc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Npc()
        {
            this.shop = new HashSet<Shop>();
            this.teleporter = new HashSet<Teleporter>();
        }
    
        public short NpcId { get; set; }
        public string Name { get; set; }
        public short Vnum { get; set; }
        public short MapId { get; set; }
        public short MapX { get; set; }
        public short MapY { get; set; }
        public short Speed { get; set; }
        public bool Move { get; set; }
        public short Dialog { get; set; }
        public short Position { get; set; }
        public bool IsSitting { get; set; }
        public byte Level { get; set; }
        public byte AttackClass { get; set; }
        public byte AttackUpgrade { get; set; }
        public short DamageMinimum { get; set; }
        public short DamageMaximum { get; set; }
        public short Concentrate { get; set; }
        public byte Element { get; set; }
        public short ElementRate { get; set; }
        public short CriticalRate { get; set; }
        public short CriticalLuckRate { get; set; }
        public short CloseDefence { get; set; }
        public short DefenceDodge { get; set; }
        public short MagicDefence { get; set; }
        public byte DefenceUpgrade { get; set; }
        public short DistanceDefence { get; set; }
        public short DistanceDefenceDodge { get; set; }
        public short FireResistance { get; set; }
        public short WaterResistance { get; set; }
        public short LightResistance { get; set; }
        public short DarkResistance { get; set; }
        public short Effect { get; set; }
        public short EffectDelay { get; set; }
    
        public virtual Map map { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop> shop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teleporter> teleporter { get; set; }
    }
}
