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
        public byte Unknown2 { get; set; }
        public string Name { get; set; }
        public byte Level { get; set; }
        public PortraitType Portrait { get; set; }

        public CharacterListing(BinaryReader reader)
        {
            Class = (Class)reader.ReadByte();
            Unknown2 = reader.ReadByte();
            Name = Encoding.GetEncoding(932).GetString(reader.ReadBytes(20)).SjisToAscii().TrimEnd('\0');
            Level = reader.ReadByte();
            Portrait = (PortraitType)reader.ReadByte();
        }
    }

    public class StreetPassCharacter
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

        public StreetPassCharacter(BinaryReader reader)
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

    public class GuildCard
    {
        public uint Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        public uint Unknown3 { get; set; }
        public CharacterListing[] CharacterListings { get; set; }
        public CharacterListing UnknownUnusedCharacterListing { get; set; }
        public StreetPassCharacter StreetPassCharacter { get; set; }
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
        // TODO: Achievements & treasure map be below?
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }

        public double EnemyDiscovery
        {
            get { return GetPercentageFromUint(EnemyDiscoveryRaw); }
            set { throw new NotImplementedException(); }
        }
        public double ItemDiscovery
        {
            get { return GetPercentageFromUint(ItemDiscoveryRaw); }
            set { throw new NotImplementedException(); }
        }

        public GuildCard(BinaryReader reader)
        {
            Unknown1 = reader.ReadUInt32();
            Unknown2 = reader.ReadUInt32();
            Unknown3 = reader.ReadUInt32();
            CharacterListings = new CharacterListing[5];
            for (int i = 0; i < CharacterListings.Length; i++) CharacterListings[i] = new CharacterListing(reader);
            UnknownUnusedCharacterListing = new CharacterListing(reader);
            StreetPassCharacter = new StreetPassCharacter(reader);
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
            Unknown6 = reader.ReadUInt32();
            Unknown7 = reader.ReadUInt32();
        }

        private double GetPercentageFromUint(uint raw)
        {
            return (double)Math.Round(((raw / 100) % 1000) + (0.01 * (raw % 100)), 2);
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
