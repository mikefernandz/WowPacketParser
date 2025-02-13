using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V9_0_1_36216.UpdateFields.V9_1_0_39185
{
    public class ArenaCooldown : IArenaCooldown
    {
        public int SpellID { get; set; }
        public int Charges { get; set; }
        public uint Flags { get; set; }
        public uint StartTime { get; set; }
        public uint EndTime { get; set; }
        public uint NextChargeTime { get; set; }
        public byte MaxCharges { get; set; }
    }
}

