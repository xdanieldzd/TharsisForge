using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EO4SaveEdit.FileHandlers
{
    [Flags]
    public enum PortraitType : byte
    {
        // Gender incorrect for some classes & story charas (ex. Kibagami)
        Male = 0x00,
        Female = 0x01,
        AltDesign = 0x02,
        AltColor = 0x04,
        Special = 0x08
    }

    public enum Class : byte
    {
        Landsknecht = 0x00,
        Nightseeker = 0x01,
        Fortress = 0x02,
        Sniper = 0x03,
        Medic = 0x04,
        Runemaster = 0x05,
        Dancer = 0x06,
        Arcanist = 0x07,
        Bushi = 0x08,
        Imperial = 0x09,

        None = 0xFF
    }

    public class EquipmentSlot
    {
        public ushort ItemID { get; set; }
        public byte NumForgeableSlots { get; set; }
        public byte EffectSlot1 { get; set; }
        public byte EffectSlot2 { get; set; }
        public byte EffectSlot3 { get; set; }
        public byte EffectSlot4 { get; set; }
        public byte EffectSlot5 { get; set; }
        public uint Unknown { get; set; }

        public EquipmentSlot(BinaryReader reader)
        {
            ItemID = reader.ReadUInt16();
            NumForgeableSlots = reader.ReadByte();
            EffectSlot1 = reader.ReadByte();
            EffectSlot2 = reader.ReadByte();
            EffectSlot3 = reader.ReadByte();
            EffectSlot4 = reader.ReadByte();
            EffectSlot5 = reader.ReadByte();
            Unknown = reader.ReadUInt32();
        }
    }

    public class Stats
    {
        public uint HP { get; set; }
        public uint TP { get; set; }
        public ushort STR { get; set; }
        public ushort VIT { get; set; }
        public ushort AGI { get; set; }
        public ushort LUC { get; set; }
        public ushort TEC { get; set; }
        public ushort Unknown { get; set; }

        public Stats(BinaryReader reader)
        {
            HP = reader.ReadUInt32();
            TP = reader.ReadUInt32();
            STR = reader.ReadUInt16();
            VIT = reader.ReadUInt16();
            AGI = reader.ReadUInt16();
            LUC = reader.ReadUInt16();
            TEC = reader.ReadUInt16();
            Unknown = reader.ReadUInt16();
        }
    }

    public class Character
    {
        public byte Unknown1 { get; set; }
        public PortraitType Portrait { get; set; }
        public byte ID { get; set; }
        public byte UnknownStatus { get; set; }
        public Class Class { get; set; }
        public Class Subclass { get; set; }
        public ushort Unknown2 { get; set; }
        public EquipmentSlot WeaponSlot { get; set; }
        public EquipmentSlot EquipmentSlot { get; set; }
        public EquipmentSlot ArmorSlot1 { get; set; }
        public EquipmentSlot ArmorSlot2 { get; set; }
        public uint Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public Stats BaseStats { get; set; }
        public Stats CumulativeStatsAfterSkills { get; set; }
        public Stats CumulativeStatsAfterArmor2 { get; set; }
        public Stats CumulativeStatsAfterArmor1 { get; set; }
        public Stats CumulativeStatsAfterEquipment { get; set; }
        public Stats CumulativeStatsAfterWeapon { get; set; }
        public ushort CurrentHP { get; set; }
        public ushort CurrentTP { get; set; }
        public uint CurrentEXP { get; set; }
        public string Name { get; set; }
        public ushort UnknownTotalSkillPoints { get; set; }
        public byte[] MainSkillLevels { get; set; }
        public byte[] SubSkillLevels { get; set; }
        public byte Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public byte Unknown14 { get; set; }
        public byte Unknown15 { get; set; }
        public byte Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        public byte Unknown20 { get; set; }
        public byte Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public byte Unknown24 { get; set; }
        public byte DuplicateID { get; set; }
        public byte PartySlot { get; set; }
        public byte Unknown25 { get; set; }
        public string OriginGuildName { get; set; }
        // ...
        // ...

        public Character(BinaryReader reader)
        {
            Unknown1 = reader.ReadByte();
            Portrait = (PortraitType)reader.ReadByte();
            ID = reader.ReadByte();
            UnknownStatus = reader.ReadByte();
            Class = (Class)reader.ReadByte();
            Subclass = (Class)reader.ReadByte();
            Unknown2 = reader.ReadUInt16();
            WeaponSlot = new EquipmentSlot(reader);
            EquipmentSlot = new EquipmentSlot(reader);
            ArmorSlot1 = new EquipmentSlot(reader);
            ArmorSlot2 = new EquipmentSlot(reader);
            Unknown3 = reader.ReadUInt32();
            Unknown4 = reader.ReadUInt32();
            Unknown5 = reader.ReadUInt32();
            Unknown6 = reader.ReadUInt32();
            Unknown7 = reader.ReadUInt32();
            BaseStats = new Stats(reader);
            CumulativeStatsAfterSkills = new Stats(reader);
            CumulativeStatsAfterArmor2 = new Stats(reader);
            CumulativeStatsAfterArmor1 = new Stats(reader);
            CumulativeStatsAfterEquipment = new Stats(reader);
            CumulativeStatsAfterWeapon = new Stats(reader);
            CurrentHP = reader.ReadUInt16();
            CurrentTP = reader.ReadUInt16();
            CurrentEXP = reader.ReadUInt32();
            Name = Encoding.GetEncoding(932).GetString(reader.ReadBytes(20)).TrimEnd('\0');
            UnknownTotalSkillPoints = reader.ReadUInt16();
            MainSkillLevels = reader.ReadBytes(26);
            SubSkillLevels = reader.ReadBytes(26);
            Unknown8 = reader.ReadByte();
            Unknown9 = reader.ReadByte();
            Unknown10 = reader.ReadByte();
            Unknown11 = reader.ReadByte();
            Unknown12 = reader.ReadByte();
            Unknown13 = reader.ReadByte();
            Unknown14 = reader.ReadByte();
            Unknown15 = reader.ReadByte();
            Unknown16 = reader.ReadByte();
            Unknown17 = reader.ReadByte();
            Unknown18 = reader.ReadByte();
            Unknown19 = reader.ReadByte();
            Unknown20 = reader.ReadByte();
            Unknown21 = reader.ReadByte();
            Unknown22 = reader.ReadByte();
            Unknown23 = reader.ReadByte();
            Unknown24 = reader.ReadByte();
            DuplicateID = reader.ReadByte();
            PartySlot = reader.ReadByte();
            Unknown25 = reader.ReadByte();
            OriginGuildName = Encoding.GetEncoding(932).GetString(reader.ReadBytes(18)).TrimEnd('\0');
            //...
            reader.BaseStream.Seek(0x30, SeekOrigin.Current);   //temp
        }
    }

    public class Mori4Game : BaseMori4File
    {
        public string SignatureGAME { get; set; }

        public string SignaturePRTY { get; set; }
        //
        public Character[] Characters { get; set; }
        //

        public Mori4Game(BinaryReader reader)
            : base(reader)
        {
            SignatureGAME = Encoding.ASCII.GetString(reader.ReadBytes(4));
            reader.BaseStream.Seek(0xC, SeekOrigin.Current);    //temp

            SignaturePRTY = Encoding.ASCII.GetString(reader.ReadBytes(4));
            reader.BaseStream.Seek(0x30, SeekOrigin.Current);   //temp

            Characters = new Character[30];
            for (int i = 0; i < Characters.Length; i++) Characters[i] = new Character(reader);
        }
    }
}
