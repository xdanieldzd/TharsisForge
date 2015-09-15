using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
    }

    public enum MapObjectType : byte
    {
        None = 0x00,
        OpenDoor = 0x01,
        ClosedDoor = 0x02,
        StairsUp = 0x03,
        StairsDown = 0x04,
        Note = 0x05,
        EventTile = 0x06,
        ExclamationTile = 0x07,
        QuestionMarkTile = 0x08,
        TreasureChest = 0x09,
        ResourceTake = 0x0A,
        ResourceCut = 0x0B,
        ResourceMine = 0x0C,
        Skyship = 0x0D,
        PassageNorth = 0x0E,
        PassageSouth = 0x0F,
        PassageNorthSouth = 0x10,
        Circle = 0x11,
        PassageWest = 0x12,
        PassageEast = 0x13,
        PassageWestEast = 0x14,
        PersonTile = 0x15,
        BlueCircle = 0x16,
        Sparkle = 0x17,
        Star = 0x18,
        RedDiamondShape = 0x19,
        RedCircleMark = 0x1A,
        RedFailureMark = 0x1B,
        RedCheckmark = 0x1C,
        RedExclamationMark = 0x1D,
        RedQuestionMark = 0x1E,
        Number1 = 0x1F,
        Number2 = 0x20,
        Number3 = 0x21,
        Number4 = 0x22,
        Number5 = 0x23,
        Number6 = 0x24,
        Number7 = 0x25,
        Number8 = 0x26,
        Number9 = 0x27,
        Number0 = 0x28,

        AutoArrowNorth = 0xB4,
        AutoArrowSouth = 0xB5,
        AutoArrowWest = 0xB6,
        AutoArrowEast = 0xB7
    }

    [System.Diagnostics.DebuggerDisplay("Type:{Type},X:{XPosition},Y:{YPosition},Padding:{Padding}")]
    public class MapObject : DataChunk
    {
        public MapObjectType Type { get; set; }
        public byte XPosition { get; set; }
        public byte YPosition { get; set; }
        public byte Padding { get; set; }

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
        }
    }

    [System.Diagnostics.DebuggerDisplay("Type:{Description},X:{XPosition},Y:{YPosition},Padding:{Padding}")]
    public class MapNote : DataChunk
    {
        public string Description { get; set; }
        public byte XPosition { get; set; }
        public byte YPosition { get; set; }
        public uint Padding { get; set; }

        public MapNote(Stream stream)
        {
            this.ReadFromStream(stream);
        }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            Description = Encoding.GetEncoding(932).GetString(reader.ReadBytes(34)).TrimEnd('\0');
            XPosition = reader.ReadByte();
            YPosition = reader.ReadByte();
            Padding = reader.ReadUInt32();
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
    }
}
