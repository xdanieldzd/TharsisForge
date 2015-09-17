using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using EO4SaveEdit.Extensions;

namespace EO4SaveEdit.FileHandlers
{
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

    public class Item : DataChunk
    {
        public ushort ItemID { get; set; }
        public byte NumForgeableSlots { get; set; }
        public byte[] EffectSlots { get; set; }
        public byte Unknown { get; set; }

        public Item(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            ItemID = reader.ReadUInt16();
            NumForgeableSlots = reader.ReadByte();
            EffectSlots = new byte[8];
            for (int i = 0; i < EffectSlots.Length; i++) EffectSlots[i] = reader.ReadByte();
            Unknown = reader.ReadByte();
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(ItemID);
            writer.Write(NumForgeableSlots);
            writer.Write(EffectSlots);
            writer.Write(Unknown);
        }
    }

    public class Stats : DataChunk
    {
        public uint HP { get; set; }
        public uint TP { get; set; }
        public ushort STR { get; set; }
        public ushort VIT { get; set; }
        public ushort AGI { get; set; }
        public ushort LUC { get; set; }
        public ushort TEC { get; set; }
        public ushort Unknown { get; set; }

        public Stats(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            HP = reader.ReadUInt32();
            TP = reader.ReadUInt32();
            STR = reader.ReadUInt16();
            VIT = reader.ReadUInt16();
            AGI = reader.ReadUInt16();
            LUC = reader.ReadUInt16();
            TEC = reader.ReadUInt16();
            Unknown = reader.ReadUInt16();
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(HP);
            writer.Write(TP);
            writer.Write(STR);
            writer.Write(VIT);
            writer.Write(AGI);
            writer.Write(LUC);
            writer.Write(TEC);
            writer.Write(Unknown);
        }
    }

    public class Character : DataChunk
    {
        public byte Unknown1 { get; set; }
        public byte Portrait { get; set; }
        public byte ID { get; set; }
        public byte Level { get; set; }
        public Class Class { get; set; }
        public Class Subclass { get; set; }
        public ushort Unknown2 { get; set; }
        public Item WeaponSlot { get; set; }
        public Item EquipmentSlot { get; set; }
        public Item ArmorSlot1 { get; set; }
        public Item ArmorSlot2 { get; set; }
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
        byte[] name;
        public ushort Unknown8 { get; set; }
        public ushort UnknownTotalSkillPoints { get; set; }
        public byte[] MainSkillLevels { get; set; }
        public byte[] SubSkillLevels { get; set; }
        public ushort Unknown9 { get; set; }
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
        public byte Unknown25 { get; set; }
        public byte Unknown26 { get; set; }
        public byte DuplicateID { get; set; }
        public byte PartySlot { get; set; }
        public byte Unknown27 { get; set; }
        byte[] originGuildName;
        public byte[] Unknown28 { get; set; }

        public string Name
        {
            get { return Encoding.GetEncoding(932).GetString(name).SjisToAscii().TrimEnd('\0'); }
            set { name = value.GetSjisBytes(18); }
        }

        public string OriginGuildName
        {
            get { return Encoding.GetEncoding(932).GetString(originGuildName).SjisToAscii().TrimEnd('\0'); }
            set { originGuildName = value.GetSjisBytes(18); }
        }

        public Character(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            Unknown1 = reader.ReadByte();
            Portrait = reader.ReadByte();
            ID = reader.ReadByte();
            Level = reader.ReadByte();
            Class = (Class)reader.ReadByte();
            Subclass = (Class)reader.ReadByte();
            Unknown2 = reader.ReadUInt16();
            WeaponSlot = new Item(stream);
            EquipmentSlot = new Item(stream);
            ArmorSlot1 = new Item(stream);
            ArmorSlot2 = new Item(stream);
            Unknown3 = reader.ReadUInt32();
            Unknown4 = reader.ReadUInt32();
            Unknown5 = reader.ReadUInt32();
            Unknown6 = reader.ReadUInt32();
            Unknown7 = reader.ReadUInt32();
            BaseStats = new Stats(stream);
            CumulativeStatsAfterSkills = new Stats(stream);
            CumulativeStatsAfterArmor2 = new Stats(stream);
            CumulativeStatsAfterArmor1 = new Stats(stream);
            CumulativeStatsAfterEquipment = new Stats(stream);
            CumulativeStatsAfterWeapon = new Stats(stream);
            CurrentHP = reader.ReadUInt16();
            CurrentTP = reader.ReadUInt16();
            CurrentEXP = reader.ReadUInt32();
            name = reader.ReadBytes(18);
            Unknown8 = reader.ReadUInt16();
            UnknownTotalSkillPoints = reader.ReadUInt16();
            MainSkillLevels = reader.ReadBytes(25);
            SubSkillLevels = reader.ReadBytes(25);
            Unknown9 = reader.ReadUInt16();
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
            Unknown25 = reader.ReadByte();
            Unknown26 = reader.ReadByte();
            DuplicateID = reader.ReadByte();
            PartySlot = reader.ReadByte();
            Unknown27 = reader.ReadByte();
            originGuildName = reader.ReadBytes(18);
            Unknown28 = reader.ReadBytes(48);
        }
    }

    public class Mori4Game : BaseMori4File
    {
        public const string ExpectedFileSignature = "MOR4GAME";

        public string SignatureGAME { get; set; }

        public string SignaturePRTY { get; set; }
        //...
        public Character[] Characters { get; set; }
        public Character UnknownUnusedCharacter { get; set; }
        //...
        byte[] guildName { get; set; }
        byte[] skyshipName { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public Item[] InventoryItems { get; set; }
        public Item[] KeyItems { get; set; }
        public Item[] StorageItems { get; set; }
        public byte[] StorageItemAmounts { get; set; }
        //...

        public string GuildName
        {
            get { return Encoding.GetEncoding(932).GetString(guildName).SjisToAscii().TrimEnd('\0'); }
            set { guildName = value.GetSjisBytes(18); }
        }

        public string SkyshipName
        {
            get { return Encoding.GetEncoding(932).GetString(skyshipName).SjisToAscii().TrimEnd('\0'); }
            set { skyshipName = value.GetSjisBytes(18); }
        }

        public Mori4Game(Stream stream) : base(stream) { }

        public override void ReadFromStream(Stream stream)
        {
            base.ReadFromStream(stream);

            BinaryReader reader = new BinaryReader(stream);

            SignatureGAME = Encoding.ASCII.GetString(reader.ReadBytes(4));
            reader.BaseStream.Seek(0xC, SeekOrigin.Current);    //temp

            SignaturePRTY = Encoding.ASCII.GetString(reader.ReadBytes(4));
            reader.BaseStream.Seek(0x30, SeekOrigin.Current);   //temp

            Characters = new Character[30];
            for (int i = 0; i < Characters.Length; i++) Characters[i] = new Character(stream);
            UnknownUnusedCharacter = new Character(stream);

            reader.BaseStream.Seek(0x60, SeekOrigin.Current);
            guildName = reader.ReadBytes(18);
            skyshipName = reader.ReadBytes(18);
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadByte();
            Unknown4 = reader.ReadByte();
            InventoryItems = new Item[60];
            for (int i = 0; i < InventoryItems.Length; i++) InventoryItems[i] = new Item(stream);
            KeyItems = new Item[60];
            for (int i = 0; i < KeyItems.Length; i++) KeyItems[i] = new Item(stream);
            StorageItems = new Item[99];
            for (int i = 0; i < StorageItems.Length; i++) StorageItems[i] = new Item(stream);
            StorageItemAmounts = new byte[99];
            for (int i = 0; i < StorageItemAmounts.Length; i++) StorageItemAmounts[i] = reader.ReadByte();
        }
    }
}
