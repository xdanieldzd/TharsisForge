using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EO4SaveEdit.FileHandlers
{
    public class FileHeader
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

        public FileHeader(BinaryReader reader)
        {
            Signature = Encoding.ASCII.GetString(reader.ReadBytes(8));
            Unknown1 = reader.ReadUInt32();
            ChunkSize = reader.ReadUInt32();
            LastSavedTime = new Timestamp(reader);
            Unknown2 = reader.ReadUInt16();
            UnknownData = reader.ReadBytes(98);
        }
    }

    public class Timestamp
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

        public Timestamp(BinaryReader reader)
        {
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
    }

    public class BaseMori4File
    {
        public string Filename { get; private set; }

        public FileHeader FileHeader { get; set; }

        public BaseMori4File(BinaryReader reader)
        {
            Filename = (reader.BaseStream is FileStream ? (reader.BaseStream as FileStream).Name : "Unknown");
            FileHeader = new FileHeader(reader);
        }
    }
}
