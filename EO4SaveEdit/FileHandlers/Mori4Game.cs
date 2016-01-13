using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using EO4SaveEdit.Extensions;

namespace EO4SaveEdit.FileHandlers
{
    [Flags]
    public enum BaseFlags : byte
    {
        Bit0 = 0x01,
        InParty = 0x02,
        Bit2 = 0x04,
        Bit3 = 0x08,
        Bit4 = 0x10,
        IsGuildCardCharacter = 0x20,
        Bit6 = 0x40,
        Bit7 = 0x80
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

    [Flags]
    public enum StatusAilments : ushort
    {
        None = 0x0000,

        Dead = 0x0001,
        Petrified = 0x0002,
        Asleep = 0x0004,
        Panicked = 0x0008,
        Bit4 = 0x0010,
        Poisoned = 0x0020,
        Blindness = 0x0040,
        Cursed = 0x0080,
        Paralyzed = 0x0100,
        Bit9 = 0x0200,
        HeadBind = 0x0400,
        ArmBind = 0x0800,
        LegBind = 0x1000,
        Bit13 = 0x2000,
        Bit14 = 0x4000,
        Bit15 = 0x8000
    }

    public enum ForgeEffect : byte
    {
        None = 0x00,

        HP = 0x01,
        TP = 0x02,
        STR = 0x03,
        TEC = 0x04,
        VIT = 0x05,
        AGI = 0x06,
        LUC = 0x07,
        SPD = 0x08,
        BRS = 0x09,
        ATK = 0x0A,
        ELM = 0x0B,
        HIT = 0x0C,
        CRI = 0x0D,
        Fire = 0x0E,
        Ice = 0x0F,
        Volt = 0x10,
        Piercing = 0x11,
        Splashing = 0x12,
        Blind = 0x13,
        Sleep = 0x14,
        Poison = 0x15,
        Panic = 0x16,
        Paralyze = 0x17,
        Stun = 0x18,
        Petrify = 0x19,
        Death = 0x1A,
        Curse = 0x1B,
        HeadBind = 0x1C,
        ArmBind = 0x1D,
        LegBind = 0x1E,
        SlashResist = 0x1F,
        BashResist = 0x20,
        PierceResist = 0x21
    }

    [Flags]
    public enum UnlockStatus : byte
    {
        Locked = 0x00,

        // TODO: not fully understood... Set to 0x41 or 0x45 to unlock any monster, 0x01 or 0x05 for any item, I guess?
        Unlocked = 0x01,
        UnknownBit1 = 0x02,
        NotMarkedNew = 0x04,
        Bit3 = 0x08,
        Bit4 = 0x10,
        Bit5 = 0x20,
        UnlockedConditionalDrop = 0x40,
        Bit7 = 0x80
    }

    public class Item : DataChunk
    {
        public ushort ItemID { get; set; }
        public byte NumForgeableSlots { get; set; }
        public ForgeEffect EffectSlot1 { get; set; }
        public ForgeEffect EffectSlot2 { get; set; }
        public ForgeEffect EffectSlot3 { get; set; }
        public ForgeEffect EffectSlot4 { get; set; }
        public ForgeEffect EffectSlot5 { get; set; }
        public ForgeEffect EffectSlot6 { get; set; }
        public ForgeEffect EffectSlot7 { get; set; }
        public ForgeEffect EffectSlot8 { get; set; }
        public byte Unknown { get; set; }

        public Item(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            ItemID = reader.ReadUInt16();
            NumForgeableSlots = reader.ReadByte();
            EffectSlot1 = (ForgeEffect)reader.ReadByte();
            EffectSlot2 = (ForgeEffect)reader.ReadByte();
            EffectSlot3 = (ForgeEffect)reader.ReadByte();
            EffectSlot4 = (ForgeEffect)reader.ReadByte();
            EffectSlot5 = (ForgeEffect)reader.ReadByte();
            EffectSlot6 = (ForgeEffect)reader.ReadByte();
            EffectSlot7 = (ForgeEffect)reader.ReadByte();
            EffectSlot8 = (ForgeEffect)reader.ReadByte();
            Unknown = reader.ReadByte();
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(ItemID);
            writer.Write(NumForgeableSlots);
            writer.Write((byte)EffectSlot1);
            writer.Write((byte)EffectSlot2);
            writer.Write((byte)EffectSlot3);
            writer.Write((byte)EffectSlot4);
            writer.Write((byte)EffectSlot5);
            writer.Write((byte)EffectSlot6);
            writer.Write((byte)EffectSlot7);
            writer.Write((byte)EffectSlot8);
            writer.Write(Unknown);
        }
    }

    public class ItemAmount : DataChunk
    {
        public byte Amount { get; set; }

        public ItemAmount(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            Amount = (byte)stream.ReadByte();
        }

        public override void WriteToStream(Stream stream)
        {
            stream.WriteByte(Amount);
        }
    }

    [System.Diagnostics.DebuggerDisplay("HP:{HP},TP:{TP},STR:{STR},VIT:{VIT},AGI:{AGI},LUC:{LUC},TEC:{TEC},Unk:{Unknown}")]
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
        public const int NameLengthEng = 18, GuildNameLengthEng = 18;
        public const int NameLengthJpn = 12, GuildNameLengthJpn = 16;

        int nameLength, guildNameLength;

        public BaseFlags BaseFlags { get; set; }
        public byte Portrait { get; set; }
        public byte ID { get; set; }
        public byte Level { get; set; }
        public Class Class { get; set; }
        public Class Subclass { get; set; }
        public StatusAilments StatusAilments { get; set; }
        public Item WeaponSlot { get; set; }
        public Item EquipmentSlot { get; set; }
        public Item ArmorSlot1 { get; set; }
        public Item ArmorSlot2 { get; set; }
        public uint Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        public uint Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        public Stats BaseStats { get; set; }                        // Base stats
        public Stats CumulativeStatsAfterSkills { get; set; }       // Stats after any Skill-based buffs (TP Boost, etc.)
        public Stats CumulativeStatsAfterEquipment { get; set; }    // Stats after any buffs from Equipment (forge effects)
        public Stats CumulativeStatsAfterUnknown1 { get; set; }     // Usually same as after Equipment...? Maybe temporary buffs/debuffs?
        public Stats CumulativeStatsAfterUnknown2 { get; set; }     // Usually same as after Equipment...? Maybe temporary buffs/debuffs?
        public Stats CumulativeStatsAfterUnknown3 { get; set; }     // Usually same as after Equipment...? Maybe temporary buffs/debuffs?
        public ushort CurrentHP { get; set; }
        public ushort CurrentTP { get; set; }
        public uint CurrentEXP { get; set; }
        byte[] name;
        public ushort NamePadding { get; set; }
        public byte UnknownTotalSkillPoints { get; set; }
        public byte AvailableSkillPoints { get; set; }
        public byte[] MainSkillLevels { get; set; }
        public byte[] SubSkillLevels { get; set; }
        public ushort Unknown6 { get; set; }
        public byte BookSTRModifier { get; set; }
        public byte BookVITModifier { get; set; }
        public byte BookAGIModifier { get; set; }
        public byte BookLUCModifier { get; set; }
        public byte BookTECModifier { get; set; }
        public byte Unknown7 { get; set; }
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
        public byte DuplicateID { get; set; }
        public byte PartySlot { get; set; }
        public byte Unknown19 { get; set; }
        byte[] originGuildName;
        public byte[] Unknown20 { get; set; }

        public bool IsGuildCardCharacter
        {
            get { return ((BaseFlags & FileHandlers.BaseFlags.IsGuildCardCharacter) == FileHandlers.BaseFlags.IsGuildCardCharacter); }
            set
            {
                BaseFlags &= ~BaseFlags.IsGuildCardCharacter;
                if (value) BaseFlags |= FileHandlers.BaseFlags.IsGuildCardCharacter;
            }
        }

        public string Name
        {
            get { return Encoding.GetEncoding(932).GetString(name).SjisToAscii().TrimEnd('\0'); }
            set { name = value.GetSjisBytes(nameLength); }
        }

        public string OriginGuildName
        {
            get { return Encoding.GetEncoding(932).GetString(originGuildName).SjisToAscii().TrimEnd('\0'); }
            set { originGuildName = value.GetSjisBytes(guildNameLength); }
        }

        public Character(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            if (SaveDataHandler.SaveLanguage == SaveLanguages.English)
            {
                nameLength = NameLengthEng;
                guildNameLength = GuildNameLengthEng;
            }
            else if (SaveDataHandler.SaveLanguage == SaveLanguages.Japanese)
            {
                nameLength = NameLengthJpn;
                guildNameLength = GuildNameLengthJpn;
            }
            else
                throw new Exception("Unknown language");

            BaseFlags = (BaseFlags)reader.ReadByte();
            Portrait = reader.ReadByte();
            ID = reader.ReadByte();
            Level = reader.ReadByte();
            Class = (Class)reader.ReadByte();
            Subclass = (Class)reader.ReadByte();
            StatusAilments = (StatusAilments)reader.ReadUInt16();
            WeaponSlot = new Item(stream);
            EquipmentSlot = new Item(stream);
            ArmorSlot1 = new Item(stream);
            ArmorSlot2 = new Item(stream);
            Unknown1 = reader.ReadUInt32();
            Unknown2 = reader.ReadUInt32();
            Unknown3 = reader.ReadUInt32();
            Unknown4 = reader.ReadUInt32();
            Unknown5 = reader.ReadUInt32();
            BaseStats = new Stats(stream);
            CumulativeStatsAfterSkills = new Stats(stream);
            CumulativeStatsAfterEquipment = new Stats(stream);
            CumulativeStatsAfterUnknown1 = new Stats(stream);
            CumulativeStatsAfterUnknown2 = new Stats(stream);
            CumulativeStatsAfterUnknown3 = new Stats(stream);
            CurrentHP = reader.ReadUInt16();
            CurrentTP = reader.ReadUInt16();
            CurrentEXP = reader.ReadUInt32();
            name = reader.ReadBytes(nameLength);
            NamePadding = reader.ReadUInt16();
            UnknownTotalSkillPoints = reader.ReadByte();
            AvailableSkillPoints = reader.ReadByte();
            MainSkillLevels = reader.ReadBytes(25);
            SubSkillLevels = reader.ReadBytes(25);
            Unknown6 = reader.ReadUInt16();
            BookSTRModifier = reader.ReadByte();
            BookVITModifier = reader.ReadByte();
            BookAGIModifier = reader.ReadByte();
            BookLUCModifier = reader.ReadByte();
            BookTECModifier = reader.ReadByte();
            Unknown7 = reader.ReadByte();
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
            DuplicateID = reader.ReadByte();
            PartySlot = reader.ReadByte();
            Unknown19 = reader.ReadByte();
            originGuildName = reader.ReadBytes(guildNameLength);
            Unknown20 = reader.ReadBytes(48);
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write((byte)BaseFlags);
            writer.Write(Portrait);
            writer.Write(ID);
            writer.Write(Level);
            writer.Write((byte)Class);
            writer.Write((byte)Subclass);
            writer.Write((ushort)StatusAilments);
            WeaponSlot.WriteToStream(stream);
            EquipmentSlot.WriteToStream(stream);
            ArmorSlot1.WriteToStream(stream);
            ArmorSlot2.WriteToStream(stream);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.Write(Unknown5);
            BaseStats.WriteToStream(stream);
            CumulativeStatsAfterSkills.WriteToStream(stream);
            CumulativeStatsAfterEquipment.WriteToStream(stream);
            CumulativeStatsAfterUnknown1.WriteToStream(stream);
            CumulativeStatsAfterUnknown2.WriteToStream(stream);
            CumulativeStatsAfterUnknown3.WriteToStream(stream);
            writer.Write(CurrentHP);
            writer.Write(CurrentTP);
            writer.Write(CurrentEXP);
            writer.Write(name);
            writer.Write(NamePadding);
            writer.Write(UnknownTotalSkillPoints);
            writer.Write(AvailableSkillPoints);
            writer.Write(MainSkillLevels);
            writer.Write(SubSkillLevels);
            writer.Write(Unknown6);
            writer.Write(BookSTRModifier);
            writer.Write(BookVITModifier);
            writer.Write(BookAGIModifier);
            writer.Write(BookLUCModifier);
            writer.Write(BookTECModifier);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
            writer.Write(Unknown9);
            writer.Write(Unknown10);
            writer.Write(Unknown11);
            writer.Write(Unknown12);
            writer.Write(Unknown13);
            writer.Write(Unknown14);
            writer.Write(Unknown15);
            writer.Write(Unknown16);
            writer.Write(Unknown17);
            writer.Write(Unknown18);
            writer.Write(DuplicateID);
            writer.Write(PartySlot);
            writer.Write(Unknown19);
            writer.Write(originGuildName);
            writer.Write(Unknown20);
        }
    }

    [System.Diagnostics.DebuggerDisplay("{UnlockStatus}")]
    public class DictionaryUnlocks : DataChunk
    {
        public UnlockStatus UnlockStatus { get; set; }

        public DictionaryUnlocks(Stream stream) { this.ReadFromStream(stream); }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            UnlockStatus = (UnlockStatus)reader.ReadByte();
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write((byte)UnlockStatus);
        }
    }

    public class Mori4Game : BaseMori4File
    {
        public const string ExpectedFileSignature = "MOR4GAME";

        public static List<string> MonthNames = new List<string>()
        {
            "Emperor",
            "Dormouse",
            "Taurus",
            "Tiger",
            "Lapin",
            "Uroboros",
            "Serpent",
            "Stallion",
            "Aries",
            "Capuchin",
            "Phoenix",
            "Demiurge",
            "Khrysaor",
            "Summoner"
        };

        public string SignatureGAME { get; set; }
        public uint Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public ushort Unknown5 { get; set; }
        public string SignaturePRTY { get; set; }
        public byte Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        public uint Unknown11 { get; set; }
        public uint Unknown12 { get; set; }
        public uint Unknown13 { get; set; }
        public uint Unknown14 { get; set; }
        public uint Unknown15 { get; set; }
        public uint Unknown16 { get; set; }
        public uint CurrentEn { get; set; }
        public uint TotalDays { get; set; }
        public ushort TimeOfDay { get; set; }
        public ushort BurstValue { get; set; }
        public Character[] Characters { get; set; }
        public Character UnknownUnusedCharacter { get; set; }
        //...
        byte[] guildName { get; set; }
        byte[] skyshipName { get; set; }
        public byte Unknown20 { get; set; }
        public byte Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public Item[] InventoryItems { get; set; }
        public Item[] KeyItems { get; set; }
        public Item[] StorageItems { get; set; }
        public ItemAmount[] StorageItemAmounts { get; set; }
        //...
        public ItemAmount[] BerundMaterialAmounts { get; set; }
        //...
        public DictionaryUnlocks[] ItemCompendiumUnlocks { get; set; }
        public DictionaryUnlocks[] MonstrousCodexUnlocks { get; set; }
        //...

        public int CurrentYear
        {
            get { return (int)(TotalDays / 365); }
            set { TotalDays = (uint)((value * 365) + (TotalDays % 365)); }
        }

        public int CurrentMonth
        {
            get { return (int)((TotalDays % 365) / 28); }
            set { TotalDays = (uint)((CurrentYear * 365) + (value * 28) + (CurrentDay % 28)); }
        }

        public int CurrentDay
        {
            get { return (int)((TotalDays % 365) % 28); }
            set { TotalDays = (uint)((CurrentYear * 365) + (CurrentMonth * 28) + (value % 28)); }
        }

        public string DayName
        {
            get { return string.Format("{0} {1}", MonthNames[CurrentMonth], (CurrentDay + 1)); }
        }

        public int BurstPoints
        {
            get { return (BurstValue / 100); }
            set { BurstValue = (ushort)((value * 100) + BurstGauge); }
        }

        public int BurstGauge
        {
            get { return (BurstValue % 100); }
            set { BurstValue = (ushort)((BurstPoints * 100) + (value % 100)); }
        }

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
            Unknown1 = reader.ReadUInt32();
            Unknown2 = reader.ReadUInt16();
            Unknown3 = reader.ReadUInt16();
            Unknown4 = reader.ReadUInt16();
            Unknown5 = reader.ReadUInt16();
            SignaturePRTY = Encoding.ASCII.GetString(reader.ReadBytes(4));
            Unknown6 = reader.ReadByte();
            Unknown7 = reader.ReadByte();
            Unknown8 = reader.ReadUInt16();
            Unknown9 = reader.ReadUInt32();
            Unknown10 = reader.ReadUInt32();
            Unknown11 = reader.ReadUInt32();
            Unknown12 = reader.ReadUInt32();
            Unknown13 = reader.ReadUInt32();
            Unknown14 = reader.ReadUInt32();
            Unknown15 = reader.ReadUInt32();
            Unknown16 = reader.ReadUInt32();
            CurrentEn = reader.ReadUInt32();
            TotalDays = reader.ReadUInt32();    /* http://etrian.wikia.com/wiki/Time */
            TimeOfDay = reader.ReadUInt16();
            BurstValue = reader.ReadUInt16();
            Characters = new Character[30];
            for (int i = 0; i < Characters.Length; i++) Characters[i] = new Character(stream);
            UnknownUnusedCharacter = new Character(stream);
            //...
            reader.BaseStream.Seek(0x60, SeekOrigin.Current);
            guildName = reader.ReadBytes(18);
            skyshipName = reader.ReadBytes(18);
            Unknown20 = reader.ReadByte();
            Unknown21 = reader.ReadByte();
            Unknown22 = reader.ReadByte();
            Unknown23 = reader.ReadByte();
            InventoryItems = new Item[60];
            for (int i = 0; i < InventoryItems.Length; i++) InventoryItems[i] = new Item(stream);
            KeyItems = new Item[60];
            for (int i = 0; i < KeyItems.Length; i++) KeyItems[i] = new Item(stream);
            StorageItems = new Item[99];
            for (int i = 0; i < StorageItems.Length; i++) StorageItems[i] = new Item(stream);
            StorageItemAmounts = new ItemAmount[99];
            for (int i = 0; i < StorageItemAmounts.Length; i++) StorageItemAmounts[i] = new ItemAmount(stream);
            //...
            reader.BaseStream.Seek(0x3519, SeekOrigin.Current);
            BerundMaterialAmounts = new ItemAmount[400];
            for (int i = 0; i < BerundMaterialAmounts.Length; i++) BerundMaterialAmounts[i] = new ItemAmount(stream);
            //...
            reader.BaseStream.Seek(0xB10, SeekOrigin.Current);
            ItemCompendiumUnlocks = new DictionaryUnlocks[400];
            for (int i = 0; i < ItemCompendiumUnlocks.Length; i++) ItemCompendiumUnlocks[i] = new DictionaryUnlocks(stream);
            MonstrousCodexUnlocks = new DictionaryUnlocks[256];
            for (int i = 0; i < MonstrousCodexUnlocks.Length; i++) MonstrousCodexUnlocks[i] = new DictionaryUnlocks(stream);
            //...
        }

        public override void WriteToStream(Stream stream)
        {
            base.WriteToStream(stream);

            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(Encoding.ASCII.GetBytes(SignatureGAME));
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.Write(Unknown5);
            writer.Write(Encoding.ASCII.GetBytes(SignaturePRTY));
            writer.Write(Unknown6);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
            writer.Write(Unknown9);
            writer.Write(Unknown10);
            writer.Write(Unknown11);
            writer.Write(Unknown12);
            writer.Write(Unknown13);
            writer.Write(Unknown14);
            writer.Write(Unknown15);
            writer.Write(Unknown16);
            writer.Write(CurrentEn);
            writer.Write(TotalDays);
            writer.Write(TimeOfDay);
            writer.Write(BurstValue);
            foreach (Character character in Characters) character.WriteToStream(stream);
            UnknownUnusedCharacter.WriteToStream(stream);
            //...
            writer.BaseStream.Seek(0x60, SeekOrigin.Current);
            writer.Write(guildName);
            writer.Write(skyshipName);
            writer.Write(Unknown20);
            writer.Write(Unknown21);
            writer.Write(Unknown22);
            writer.Write(Unknown23);
            foreach (Item inventoryItem in InventoryItems) inventoryItem.WriteToStream(stream);
            foreach (Item keyItem in KeyItems) keyItem.WriteToStream(stream);
            foreach (Item storageItem in StorageItems) storageItem.WriteToStream(stream);
            foreach (ItemAmount storageItemAmount in StorageItemAmounts) storageItemAmount.WriteToStream(stream);
            //...
            writer.BaseStream.Seek(0x3519, SeekOrigin.Current);
            foreach (ItemAmount berundMaterialAmount in BerundMaterialAmounts) berundMaterialAmount.WriteToStream(stream);
            //...
            writer.BaseStream.Seek(0xB10, SeekOrigin.Current);
            foreach (DictionaryUnlocks itemCompendiumUnlock in ItemCompendiumUnlocks) itemCompendiumUnlock.WriteToStream(stream);
            foreach (DictionaryUnlocks monstrousCodexUnlock in MonstrousCodexUnlocks) monstrousCodexUnlock.WriteToStream(stream);
            //...
        }
    }
}
