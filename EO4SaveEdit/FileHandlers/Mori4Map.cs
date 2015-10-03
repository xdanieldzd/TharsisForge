using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.ComponentModel;

using EO4SaveEdit.Extensions;

namespace EO4SaveEdit.FileHandlers
{
    [Flags]
    public enum MapTile : byte
    {
        None = 0x00,
        GreenFloor = 0x01,
        BlueFloor = 0x02,
        YellowFloor = 0x03,
        OrangeFloor = 0x04,

        FloorTypeMask = 0x07,
        SouthWallMask = 0x08,
        EastWallMask = 0x10,
    }

    public enum MapObjectType : byte
    {
        [Description("None")]
        None = 0x00,
        [Description("Door (Open)")]
        OpenDoor = 0x01,
        [Description("Door (Closed)")]
        ClosedDoor = 0x02,
        [Description("Stairs (Up)")]
        StairsUp = 0x03,
        [Description("Stairs (Down)")]
        StairsDown = 0x04,
        [Description("Note")]
        Note = 0x05,
        [Description("Event (E)")]
        EventTile = 0x06,
        [Description("Exclamation Mark")]
        ExclamationTile = 0x07,
        [Description("Question Mark")]
        QuestionMarkTile = 0x08,
        [Description("Treasure Chest")]
        TreasureChest = 0x09,
        [Description("Resources (Take)")]
        ResourceTake = 0x0A,
        [Description("Resources (Cut)")]
        ResourceCut = 0x0B,
        [Description("Resources (Mine)")]
        ResourceMine = 0x0C,
        [Description("Skyship")]
        Skyship = 0x0D,
        [Description("Passage (North)")]
        PassageNorth = 0x0E,
        [Description("Passage (South)")]
        PassageSouth = 0x0F,
        [Description("Passage (North/South)")]
        PassageNorthSouth = 0x10,
        [Description("Circle")]
        Circle = 0x11,
        [Description("Passage (West)")]
        PassageWest = 0x12,
        [Description("Passage (East)")]
        PassageEast = 0x13,
        [Description("Passage (West/East)")]
        PassageWestEast = 0x14,
        [Description("Person")]
        PersonTile = 0x15,
        [Description("Blue Circle")]
        BlueCircle = 0x16,
        [Description("Sparkle")]
        Sparkle = 0x17,
        [Description("Star")]
        Star = 0x18,
        [Description("Diamond (Red)")]
        RedDiamondShape = 0x19,
        [Description("Circle Mark (Red)")]
        RedCircleMark = 0x1A,
        [Description("Failure Mark (Red)")]
        RedFailureMark = 0x1B,
        [Description("Checkmark (Red)")]
        RedCheckmark = 0x1C,
        [Description("Exclamation Mark (Red)")]
        RedExclamationMark = 0x1D,
        [Description("Question Mark (Red)")]
        RedQuestionMark = 0x1E,
        [Description("Number 1")]
        Number1 = 0x1F,
        [Description("Number 2")]
        Number2 = 0x20,
        [Description("Number 3")]
        Number3 = 0x21,
        [Description("Number 4")]
        Number4 = 0x22,
        [Description("Number 5")]
        Number5 = 0x23,
        [Description("Number 6")]
        Number6 = 0x24,
        [Description("Number 7")]
        Number7 = 0x25,
        [Description("Number 8")]
        Number8 = 0x26,
        [Description("Number 9")]
        Number9 = 0x27,
        [Description("Number 0")]
        Number0 = 0x28,
        [Description("Auto-walk (North)")]
        AutoArrowNorth = 0xB4,
        [Description("Auto-walk (South)")]
        AutoArrowSouth = 0xB5,
        [Description("Auto-walk (West)")]
        AutoArrowWest = 0xB6,
        [Description("Auto-walk (East)")]
        AutoArrowEast = 0xB7
    }

    [System.Diagnostics.DebuggerDisplay("Type:{Type},X:{XPosition},Y:{YPosition},Padding:{Padding}")]
    public class MapObject : DataChunk, IMapPlaceable
    {
        [DisplayName("Object Type"), Description("Type of this object."), Category("Data")]
        [TypeConverter(typeof(DescriptionEnumConverter))]
        public MapObjectType Type { get; set; }
        public bool ShouldSerializeType() { return !(this.Type == (dynamic)base.originalValues["Type"]); }
        public void ResetType() { this.Type = (dynamic)base.originalValues["Type"]; }

        [DisplayName("X Position"), Description("X position on map."), Category("Data")]
        public byte XPosition { get; set; }
        public bool ShouldSerializeXPosition() { return !(this.XPosition == (dynamic)base.originalValues["XPosition"]); }
        public void ResetXPosition() { this.XPosition = (dynamic)base.originalValues["XPosition"]; }

        [DisplayName("Y Position"), Description("Y position on map."), Category("Data")]
        public byte YPosition { get; set; }
        public bool ShouldSerializeYPosition() { return !(this.YPosition == (dynamic)base.originalValues["YPosition"]); }
        public void ResetYPosition() { this.YPosition = (dynamic)base.originalValues["YPosition"]; }

        [DisplayName("Padding"), Description("Padding, leave as zero."), Category("Misc")]
        public byte Padding { get; set; }
        public bool ShouldSerializePadding() { return !(this.Padding == (dynamic)base.originalValues["Padding"]); }
        public void ResetPadding() { this.Padding = (dynamic)base.originalValues["Padding"]; }

        public MapObject(Stream stream)
        {
            this.ReadFromStream(stream);
        }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            Type = (MapObjectType)reader.ReadByte();
            XPosition = reader.ReadByte();
            YPosition = reader.ReadByte();
            Padding = reader.ReadByte();

            base.GetOriginalValues();
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write((byte)Type);
            writer.Write(XPosition);
            writer.Write(YPosition);
            writer.Write(Padding);

            base.GetOriginalValues();
        }

        public Point GetPosition()
        {
            return new Point(XPosition, YPosition);
        }
    }

    [System.Diagnostics.DebuggerDisplay("Description:{Description},X:{XPosition},Y:{YPosition},Padding:{Padding}")]
    public class MapNote : DataChunk, IMapPlaceable
    {
        byte[] description;

        [DisplayName("Unknown"), Description("Probably padding, leave as zero."), Category("Misc")]
        public ushort Unknown1 { get; set; }
        public bool ShouldSerializeUnknown1() { return !(this.Unknown1 == (dynamic)base.originalValues["Unknown1"]); }
        public void ResetUnknown1() { this.Unknown1 = (dynamic)base.originalValues["Unknown1"]; }

        [DisplayName("X Position"), Description("X position on map."), Category("Data")]
        public byte XPosition { get; set; }
        public bool ShouldSerializeXPosition() { return !(this.XPosition == (dynamic)base.originalValues["XPosition"]); }
        public void ResetXPosition() { this.XPosition = (dynamic)base.originalValues["XPosition"]; }

        [DisplayName("Y Position"), Description("Y position on map."), Category("Data")]
        public byte YPosition { get; set; }
        public bool ShouldSerializeYPosition() { return !(this.YPosition == (dynamic)base.originalValues["YPosition"]); }
        public void ResetYPosition() { this.YPosition = (dynamic)base.originalValues["YPosition"]; }

        [DisplayName("Padding"), Description("Padding, leave as zero."), Category("Misc")]
        public uint Padding { get; set; }
        public bool ShouldSerializePadding() { return !(this.Padding == (dynamic)base.originalValues["Padding"]); }
        public void ResetPadding() { this.Padding = (dynamic)base.originalValues["Padding"]; }

        [DisplayName("Note Text"), Description("Text of this note."), Category("Data")]
        public string Description
        {
            get { return Encoding.GetEncoding(932).GetString(description).SjisToAscii().TrimEnd('\0'); }
            set { description = value.GetSjisBytes(32); }
        }
        public bool ShouldSerializeDescription() { return !(this.Description == (dynamic)base.originalValues["Description"]); }
        public void ResetDescription() { this.Description = (dynamic)base.originalValues["Description"]; }

        public MapNote(Stream stream)
        {
            this.ReadFromStream(stream);
        }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            description = reader.ReadBytes(32);
            Unknown1 = reader.ReadUInt16();
            XPosition = reader.ReadByte();
            YPosition = reader.ReadByte();
            Padding = reader.ReadUInt32();

            base.GetOriginalValues();
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(description);
            writer.Write(Unknown1);
            writer.Write(XPosition);
            writer.Write(YPosition);
            writer.Write(Padding);

            base.GetOriginalValues();
        }

        public Point GetPosition()
        {
            return new Point(XPosition, YPosition);
        }
    }

    public class MapLayer : DataChunk
    {
        int numObjects, numNotes, height, width;

        public MapObject[] Objects { get; set; }
        public MapNote[] Notes { get; set; }
        public byte[,] TilesYX { get; set; }

        public MapLayer(Stream stream, int numObjects, int numNotes, int height, int width)
        {
            this.numObjects = numObjects;
            this.numNotes = numNotes;
            this.height = height;
            this.width = width;

            this.ReadFromStream(stream);
        }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            Objects = new MapObject[numObjects];
            for (int i = 0; i < Objects.Length; i++) Objects[i] = new MapObject(stream);

            Notes = new MapNote[numNotes];
            for (int i = 0; i < Notes.Length; i++) Notes[i] = new MapNote(stream);

            TilesYX = new byte[height, width];
            Buffer.BlockCopy(reader.ReadBytes(height * width), 0, TilesYX, 0, height * width);

            stream.Seek((stream.Position % 2), SeekOrigin.Current);
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            foreach (MapObject mapObject in Objects) mapObject.WriteToStream(stream);
            foreach (MapNote mapNote in Notes) mapNote.WriteToStream(stream);
            for (int y = 0; y < TilesYX.GetLength(0); y++)
                for (int x = 0; x < TilesYX.GetLength(1); x++)
                    writer.Write(TilesYX[y, x]);

            stream.Seek((stream.Position % 2), SeekOrigin.Current);
        }
    }

    public class StratumMap : DataChunk
    {
        public byte[,] BaseTilesYX { get; set; }
        public MapLayer[] HeightLayers { get; set; }

        public StratumMap(Stream stream)
        {
            this.ReadFromStream(stream);
        }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            BaseTilesYX = new byte[20, 25];
            Buffer.BlockCopy(reader.ReadBytes(20 * 25), 0, BaseTilesYX, 0, 20 * 25);

            HeightLayers = new MapLayer[3];
            for (int i = 0; i < HeightLayers.Length; i++) HeightLayers[i] = new MapLayer(stream, 80, 32, 20, 25);
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            for (int y = 0; y < BaseTilesYX.GetLength(0); y++)
                for (int x = 0; x < BaseTilesYX.GetLength(1); x++)
                    writer.Write(BaseTilesYX[y, x]);

            foreach (MapLayer heightLayer in HeightLayers) heightLayer.WriteToStream(stream);
        }
    }

    public class Mori4Map : BaseMori4File
    {
        public const string ExpectedFileSignature = "MOR4MAPA";

        public string Signature { get; set; }

        public MapLayer[] MazeMaps { get; set; }
        public MapLayer[] CaveMaps { get; set; }
        public StratumMap[] StratumMaps { get; set; }

        public Mori4Map(Stream stream) : base(stream) { }

        public override void ReadFromStream(Stream stream)
        {
            base.ReadFromStream(stream);

            BinaryReader reader = new BinaryReader(stream);

            Signature = Encoding.ASCII.GetString(reader.ReadBytes(4));

            MazeMaps = new MapLayer[16];
            for (int i = 0; i < MazeMaps.Length; i++) MazeMaps[i] = new MapLayer(stream, 160, 32, 30, 35);

            CaveMaps = new MapLayer[13];
            for (int i = 0; i < CaveMaps.Length; i++) CaveMaps[i] = new MapLayer(stream, 64, 16, 15, 15);

            StratumMaps = new StratumMap[4];
            for (int i = 0; i < StratumMaps.Length; i++) StratumMaps[i] = new StratumMap(stream);
        }

        public override void WriteToStream(Stream stream)
        {
            base.WriteToStream(stream);

            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(Encoding.ASCII.GetBytes(Signature));

            foreach (MapLayer mazeMap in MazeMaps) mazeMap.WriteToStream(stream);
            foreach (MapLayer caveMap in CaveMaps) caveMap.WriteToStream(stream);
            foreach (StratumMap stratumMap in StratumMaps) stratumMap.WriteToStream(stream);
        }
    }

    public interface IMapPlaceable
    {
        Point GetPosition();
    }
}
