using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EO4SaveEdit.FileHandlers
{
    public class Mori4Option : BaseMori4File
    {
        public const string ExpectedFileSignature = "MOR4OPTI";

        public string Signature { get; set; }
        public byte Option1 { get; set; }
        public byte Option2 { get; set; }
        public byte Option3 { get; set; }
        public byte Option4 { get; set; }
        public byte Option5 { get; set; }
        public byte Option6 { get; set; }
        public byte Option7 { get; set; }
        public byte Option8 { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }

        public Mori4Option(BinaryReader reader)
            : base(reader)
        {
            Signature = Encoding.ASCII.GetString(reader.ReadBytes(4));
            Option1 = reader.ReadByte();
            Option2 = reader.ReadByte();
            Option3 = reader.ReadByte();
            Option4 = reader.ReadByte();
            Option5 = reader.ReadByte();
            Option6 = reader.ReadByte();
            Option7 = reader.ReadByte();
            Option8 = reader.ReadByte();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
        }
    }
}
