using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EO4SaveEdit.FileHandlers
{
    public class FileHeader : DataChunk
    {
        public static List<string> ValidSignatures = new List<string>()
        {
            "MOR4GAME",
            "MOR4GILD", 
            "MOR4MAPA", 
            "MOR4OPTI"
        };

        public string Signature { get; set; }
        public uint Unknown1 { get; set; }
        public uint ChunkSize { get; set; }
        public Timestamp LastSavedTime { get; set; }
        public ushort Unknown2 { get; set; }
        public byte[] UnknownData { get; set; }

        public FileHeader(Stream stream)
        {
            this.ReadFromStream(stream);
        }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            Signature = Encoding.ASCII.GetString(reader.ReadBytes(8));
            Unknown1 = reader.ReadUInt32();
            ChunkSize = reader.ReadUInt32();
            LastSavedTime = new Timestamp(stream);
            Unknown2 = reader.ReadUInt16();
            UnknownData = reader.ReadBytes(98);
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(Encoding.ASCII.GetBytes(Signature));
            writer.Write(Unknown1);
            writer.Write(ChunkSize);
            LastSavedTime.WriteToStream(stream);
            writer.Write(Unknown2);
            writer.Write(UnknownData);
        }
    }

    public class Timestamp : DataChunk
    {
        public ushort Year { get; set; }
        public ushort Unknown1 { get; set; }
        public byte Month { get; set; }
        public byte Day { get; set; }
        public byte Unknown2 { get; set; }
        public byte Hour { get; set; }
        public byte Minute { get; set; }
        public byte Second { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }

        public DateTime DateTime
        {
            get { return new DateTime(Year, Month, Day, Hour, Minute, Second, DateTimeKind.Local); }
            set
            {
                Year = (ushort)value.Year;
                Month = (byte)value.Month;
                Day = (byte)value.Day;
                Hour = (byte)value.Hour;
                Minute = (byte)value.Minute;
                Second = (byte)value.Second;
            }
        }

        public Timestamp(Stream stream)
        {
            this.ReadFromStream(stream);
        }

        public override void ReadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            Year = reader.ReadUInt16();
            Unknown1 = reader.ReadUInt16();
            Month = reader.ReadByte();
            Day = reader.ReadByte();
            Unknown2 = reader.ReadByte();
            Hour = reader.ReadByte();
            Minute = reader.ReadByte();
            Second = reader.ReadByte();
            Unknown3 = reader.ReadByte();
            Unknown4 = reader.ReadByte();
        }

        public override void WriteToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(Year);
            writer.Write(Unknown1);
            writer.Write(Month);
            writer.Write(Day);
            writer.Write(Unknown2);
            writer.Write(Hour);
            writer.Write(Minute);
            writer.Write(Second);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class BaseMori4File : DataChunk
    {
        public string Filename { get; private set; }

        public FileHeader FileHeader { get; set; }

        public BaseMori4File(Stream stream)
            : base()
        {
            this.ReadFromStream(stream);
        }

        public override void ReadFromStream(Stream stream)
        {
            Filename = (stream is FileStream ? (stream as FileStream).Name : "Unknown");
            FileHeader = new FileHeader(stream);
        }

        public override void WriteToStream(Stream stream)
        {
            FileHeader.WriteToStream(stream);
        }
    }
}
