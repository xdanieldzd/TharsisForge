using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using EO4SaveEdit.Extensions;

namespace EO4SaveEdit.FileHandlers
{
    public class CharacterListing : DataChunk
    {
        public Class Class { get; set; }
        public byte Unknown1 { get; set; }
        byte[] name;
        public byte Level { get; set; }
        public byte Portrait { get; set; }

        public string Name
        {
            get { return Encoding.GetEncoding(932).GetString(name).SjisToAscii().TrimEnd('\0'); }
            set { name = value.GetSjisBytes(20); }
        }

        public CharacterListing(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            Class = (Class)reader.ReadByte();
            Unknown1 = reader.ReadByte();
            name = reader.ReadBytes(20);
            Level = reader.ReadByte();
            Portrait = reader.ReadByte();
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write((byte)Class);
            writer.Write(Unknown1);
            writer.Write(name);
            writer.Write(Level);
            writer.Write(Portrait);
        }
    }

    public class GuildCardCharacter : DataChunk
    {
        public byte Portrait { get; set; }
        public byte Level { get; set; }
        public Class Class { get; set; }
        public Class Subclass { get; set; }
        public Item WeaponSlot { get; set; }
        public Item EquipmentSlot { get; set; }
        public Item ArmorSlot1 { get; set; }
        public Item ArmorSlot2 { get; set; }
        public Stats CumulativeStats { get; set; }
        public ushort CurrentHP { get; set; }
        public ushort CurrentTP { get; set; }
        byte[] name;
        public byte[] MainSkillLevels { get; set; }
        public byte[] SubSkillLevels { get; set; }

        public string Name
        {
            get { return Encoding.GetEncoding(932).GetString(name).SjisToAscii().TrimEnd('\0'); }
            set { name = value.GetSjisBytes(18); }
        }

        public GuildCardCharacter(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            Portrait = reader.ReadByte();
            Level = reader.ReadByte();
            Class = (Class)reader.ReadByte();
            Subclass = (Class)reader.ReadByte();
            WeaponSlot = new Item(stream);
            EquipmentSlot = new Item(stream);
            ArmorSlot1 = new Item(stream);
            ArmorSlot2 = new Item(stream);
            CumulativeStats = new Stats(stream);
            CurrentHP = reader.ReadUInt16();
            CurrentTP = reader.ReadUInt16();
            name = reader.ReadBytes(18);
            MainSkillLevels = reader.ReadBytes(25);
            SubSkillLevels = reader.ReadBytes(25);
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(Portrait);
            writer.Write(Level);
            writer.Write((byte)Class);
            writer.Write((byte)Subclass);
            WeaponSlot.WriteToStream(stream);
            EquipmentSlot.WriteToStream(stream);
            ArmorSlot1.WriteToStream(stream);
            ArmorSlot2.WriteToStream(stream);
            CumulativeStats.WriteToStream(stream);
            writer.Write(CurrentHP);
            writer.Write(CurrentTP);
            writer.Write(name);
            writer.Write(MainSkillLevels);
            writer.Write(SubSkillLevels);
        }
    }

    public class Achievements : DataChunk
    {
        public uint RawValue { get; private set; }

        public bool HasVesselsAlly
        {
            get { return (bool)(GetBits(0, 1) != 0); }
            set { SetBits(0, 1, Convert.ToInt32(value)); }
        }

        public bool HasSentinelsAlly
        {
            get { return (bool)(GetBits(1, 1) != 0); }
            set { SetBits(1, 1, Convert.ToInt32(value)); }
        }

        public bool HasKnightsAlly
        {
            get { return (bool)(GetBits(2, 1) != 0); }
            set { SetBits(2, 1, Convert.ToInt32(value)); }
        }

        public bool HasYggdrasilsHope
        {
            get { return (bool)(GetBits(3, 1) != 0); }
            set { SetBits(3, 1, Convert.ToInt32(value)); }
        }

        public bool HasInsectSlayer
        {
            get { return (bool)(GetBits(4, 1) != 0); }
            set { SetBits(4, 1, Convert.ToInt32(value)); }
        }

        public bool HasExplorersPride
        {
            get { return (bool)(GetBits(5, 1) != 0); }
            set { SetBits(5, 1, Convert.ToInt32(value)); }
        }

        public byte BurstSkillCompletion
        {
            get { return NumBits(GetBits(6, 3)); }
            set { SetBits(6, 3, value); }
        }

        public byte TreasureChestCompletion
        {
            get { return NumBits(GetBits(9, 3)); }
            set { SetBits(9, 3, value); }
        }

        public byte QuestCompletion
        {
            get { return NumBits(GetBits(12, 3)); }
            set { SetBits(12, 3, value); }
        }

        public byte RareBreedCompletion
        {
            get { return NumBits(GetBits(15, 3)); }
            set { SetBits(15, 3, value); }
        }

        public byte FoodCompletion
        {
            get { return NumBits(GetBits(18, 3)); }
            set { SetBits(18, 3, value); }
        }

        public byte MonsterCompletion
        {
            get { return NumBits(GetBits(21, 3)); }
            set { SetBits(21, 3, value); }
        }

        public byte MaterialCompletion
        {
            get { return NumBits(GetBits(24, 3)); }
            set { SetBits(24, 3, value); }
        }

        public byte HiddenTreasureCompletion
        {
            get { return NumBits(GetBits(27, 3)); }
            set { SetBits(27, 3, value); }
        }

        public Achievements(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);
            RawValue = reader.ReadUInt32();
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(RawValue);
        }

        private void SetBits(int shift, int bitCount, int bitsSet)
        {
            RawValue = (uint)((RawValue & (uint)~(MakeMask(shift, bitCount) << shift)) | (uint)(MakeMask(shift, bitsSet) << shift));
        }

        private byte GetBits(int shift, int bitCount)
        {
            return (byte)((RawValue >> shift) & MakeMask(shift, bitCount));
        }

        private byte NumBits(byte bits)
        {
            byte count = 0;
            while (bits != 0)
            {
                count++;
                bits &= (byte)(bits - 1);
            }
            return count;
        }

        private int MakeMask(int shift, int count)
        {
            int mask = 0;
            for (int i = 0; i < count; i++) mask |= (1 << i);
            return mask;
        }
    }

    public class GuildCard : DataChunk
    {
        public uint UnknownStreetPass1 { get; set; }
        public uint UnknownStreetPass2 { get; set; }
        public uint UnknownStreetPass3 { get; set; }
        public CharacterListing[] CharacterListings { get; set; }
        public CharacterListing UnknownUnusedCharacterListing { get; set; }
        public GuildCardCharacter GuildCardCharacter { get; set; }
        byte[] guildName;
        byte[] skyshipName;
        byte[] message;
        public uint EnemyDiscoveryRaw { get; set; }
        public uint ItemDiscoveryRaw { get; set; }
        public uint MaxLevel { get; set; }
        public uint VenturedDays { get; set; }
        public uint Walked { get; set; }
        public uint EnemiesHunted { get; set; }
        public uint TotalEn { get; set; }
        public Achievements Achievement { get; set; }
        public byte Background { get; set; }
        public byte TreasureMap { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }

        public string GuildName
        {
            get { return Encoding.GetEncoding(932).GetString(guildName).SjisToAscii().TrimEnd('\0'); }
            set { guildName = value.GetSjisBytes(16); }
        }

        public string SkyshipName
        {
            get { return Encoding.GetEncoding(932).GetString(skyshipName).SjisToAscii().TrimEnd('\0'); }
            set { skyshipName = value.GetSjisBytes(16); }
        }

        public string Message
        {
            get { return Encoding.GetEncoding(932).GetString(message).SjisToAscii().TrimEnd('\0'); }
            set { message = value.GetSjisBytes(32); }
        }

        public decimal EnemyDiscovery
        {
            get { return (decimal)(EnemyDiscoveryRaw / 100.0); }
            set { EnemyDiscoveryRaw = (uint)(value * 100); }
        }

        public decimal ItemDiscovery
        {
            get { return (decimal)(ItemDiscoveryRaw / 100.0); }
            set { ItemDiscoveryRaw = (uint)(value * 100); }
        }

        public GuildCard(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            UnknownStreetPass1 = reader.ReadUInt32();
            UnknownStreetPass2 = reader.ReadUInt32();
            UnknownStreetPass3 = reader.ReadUInt32();
            CharacterListings = new CharacterListing[5];
            for (int i = 0; i < CharacterListings.Length; i++) CharacterListings[i] = new CharacterListing(stream);
            UnknownUnusedCharacterListing = new CharacterListing(stream);
            GuildCardCharacter = new GuildCardCharacter(stream);
            guildName = reader.ReadBytes(16);
            skyshipName = reader.ReadBytes(16);
            message = reader.ReadBytes(32);
            EnemyDiscoveryRaw = reader.ReadUInt32();
            ItemDiscoveryRaw = reader.ReadUInt32();
            MaxLevel = reader.ReadUInt32();
            VenturedDays = reader.ReadUInt32();
            Walked = reader.ReadUInt32();
            EnemiesHunted = reader.ReadUInt32();
            TotalEn = reader.ReadUInt32();
            Achievement = new Achievements(stream);
            Background = reader.ReadByte();
            TreasureMap = reader.ReadByte();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(UnknownStreetPass1);
            writer.Write(UnknownStreetPass2);
            writer.Write(UnknownStreetPass3);
            foreach (CharacterListing charaListing in CharacterListings) charaListing.WriteToStream(stream);
            UnknownUnusedCharacterListing.WriteToStream(stream);
            GuildCardCharacter.WriteToStream(stream);
            writer.Write(guildName);
            writer.Write(skyshipName);
            writer.Write(message);
            writer.Write(EnemyDiscoveryRaw);
            writer.Write(ItemDiscoveryRaw);
            writer.Write(MaxLevel);
            writer.Write(VenturedDays);
            writer.Write(Walked);
            writer.Write(EnemiesHunted);
            writer.Write(TotalEn);
            Achievement.WriteToStream(stream);
            writer.Write(Background);
            writer.Write(TreasureMap);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class Mori4GdCard : BaseMori4File
    {
        public const string ExpectedFileSignature = "MOR4GILD";

        public GuildCard[] GuildCards { get; set; }

        public Mori4GdCard(Stream stream) : base(stream) { }

        public override void ReadFromStream(Stream stream)
        {
            base.ReadFromStream(stream);

            GuildCards = new GuildCard[40];
            for (int i = 0; i < GuildCards.Length; i++) GuildCards[i] = new GuildCard(stream);
        }

        public override void WriteToStream(Stream stream)
        {
            base.WriteToStream(stream);

            foreach (GuildCard guildCard in GuildCards) guildCard.WriteToStream(stream);
        }
    }
}
