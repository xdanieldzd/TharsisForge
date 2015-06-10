using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using EO4SaveEdit.Extensions;

namespace EO4SaveEdit.FileHandlers
{
    public class CharacterListing
    {
        public Class Class { get; set; }
        public byte Unknown1 { get; set; }
        public string Name { get; set; }
        public byte Level { get; set; }
        public PortraitType Portrait { get; set; }

        public CharacterListing(BinaryReader reader)
        {
            Class = (Class)reader.ReadByte();
            Unknown1 = reader.ReadByte();
            Name = Encoding.GetEncoding(932).GetString(reader.ReadBytes(20)).SjisToAscii().TrimEnd('\0');
            Level = reader.ReadByte();
            Portrait = (PortraitType)reader.ReadByte();
        }
    }

    public class GuildCardCharacter
    {
        public PortraitType Portrait { get; set; }
        public byte Level { get; set; }
        public Class Class { get; set; }
        public Class Subclass { get; set; }
        public EquipmentSlot WeaponSlot { get; set; }
        public EquipmentSlot EquipmentSlot { get; set; }
        public EquipmentSlot ArmorSlot1 { get; set; }
        public EquipmentSlot ArmorSlot2 { get; set; }
        public Stats CumulativeStats { get; set; }
        public ushort CurrentHP { get; set; }
        public ushort CurrentTP { get; set; }
        public string Name { get; set; }
        public byte[] MainSkillLevels { get; set; }
        public byte[] SubSkillLevels { get; set; }

        public bool IsValid
        {
            get { return (Level != 0); }
            set { Level = 0; }
        }

        public GuildCardCharacter()
        {
            Portrait = PortraitType.Male;
            Level = 1;
            Class = Class.Landsknecht;
            Subclass = Class.None;
            WeaponSlot = new EquipmentSlot();
            EquipmentSlot = new EquipmentSlot();
            ArmorSlot1 = new EquipmentSlot();
            ArmorSlot2 = new EquipmentSlot();
            CumulativeStats = new Stats();
            CurrentHP = (ushort)CumulativeStats.HP;
            CurrentTP = (ushort)CumulativeStats.TP;
            Name = "NoName";
            MainSkillLevels = new byte[25];
            SubSkillLevels = new byte[25];
        }

        public GuildCardCharacter(BinaryReader reader)
        {
            Portrait = (PortraitType)reader.ReadByte();
            Level = reader.ReadByte();
            Class = (Class)reader.ReadByte();
            Subclass = (Class)reader.ReadByte();
            WeaponSlot = new EquipmentSlot(reader);
            EquipmentSlot = new EquipmentSlot(reader);
            ArmorSlot1 = new EquipmentSlot(reader);
            ArmorSlot2 = new EquipmentSlot(reader);
            CumulativeStats = new Stats(reader);
            CurrentHP = reader.ReadUInt16();
            CurrentTP = reader.ReadUInt16();
            Name = Encoding.GetEncoding(932).GetString(reader.ReadBytes(18)).TrimEnd('\0').SjisToAscii();
            MainSkillLevels = reader.ReadBytes(25);
            SubSkillLevels = reader.ReadBytes(25);
        }
    }

    public class Achievements
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

        public Achievements(BinaryReader reader)
        {
            RawValue = reader.ReadUInt32();
        }

        private void SetBits(int shift, int bitCount, int bitsSet)
        {
            int mask = MakeMask(shift, bitCount);
            int data = MakeMask(shift, bitsSet);
            RawValue = (uint)((RawValue & (uint)~mask) | (uint)data);
        }

        private byte GetBits(int shift, int bitCount)
        {
            int mask = 0;
            for (int i = 0; i < bitCount; i++) mask |= (1 << i);
            return (byte)((RawValue >> shift) & mask);
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
            mask <<= shift;
            return mask;
        }
    }

    public class GuildCard
    {
        public uint UnknownStreetPass1 { get; set; }
        public uint UnknownStreetPass2 { get; set; }
        public uint UnknownStreetPass3 { get; set; }
        public CharacterListing[] CharacterListings { get; set; }
        public CharacterListing UnknownUnusedCharacterListing { get; set; }
        public GuildCardCharacter GuildCardCharacter { get; set; }
        public string GuildName { get; set; }
        public string SkyshipName { get; set; }
        public string Message { get; set; }
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

        public GuildCard(BinaryReader reader)
        {
            UnknownStreetPass1 = reader.ReadUInt32();
            UnknownStreetPass2 = reader.ReadUInt32();
            UnknownStreetPass3 = reader.ReadUInt32();
            CharacterListings = new CharacterListing[5];
            for (int i = 0; i < CharacterListings.Length; i++) CharacterListings[i] = new CharacterListing(reader);
            UnknownUnusedCharacterListing = new CharacterListing(reader);
            GuildCardCharacter = new GuildCardCharacter(reader);
            GuildName = Encoding.GetEncoding(932).GetString(reader.ReadBytes(16)).TrimEnd('\0').SjisToAscii();
            SkyshipName = Encoding.GetEncoding(932).GetString(reader.ReadBytes(16)).TrimEnd('\0').SjisToAscii();
            Message = Encoding.GetEncoding(932).GetString(reader.ReadBytes(32)).TrimEnd('\0').SjisToAscii();
            EnemyDiscoveryRaw = reader.ReadUInt32();
            ItemDiscoveryRaw = reader.ReadUInt32();
            MaxLevel = reader.ReadUInt32();
            VenturedDays = reader.ReadUInt32();
            Walked = reader.ReadUInt32();
            EnemiesHunted = reader.ReadUInt32();
            TotalEn = reader.ReadUInt32();
            Achievement = new Achievements(reader);
            Background = reader.ReadByte();
            TreasureMap = reader.ReadByte();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
        }
    }

    public class Mori4GdCard : BaseMori4File
    {
        public const string ExpectedFileSignature = "MOR4GILD";

        public GuildCard[] GuildCards { get; set; }

        public Mori4GdCard(BinaryReader reader)
            : base(reader)
        {
            GuildCards = new GuildCard[40];
            for (int i = 0; i < GuildCards.Length; i++) GuildCards[i] = new GuildCard(reader);
        }
    }
}
