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

        public static Dictionary<byte, string> VolumeLevels = new Dictionary<byte, string>()
        {
            { 0x00, "Mute" },
            { 0x01, "Low" },
            { 0x02, "Mid" },
            { 0x03, "Max" }
        };

        public static Dictionary<byte, string> MessageSpeeds = new Dictionary<byte, string>()
        {
            { 0x00, "No Wait" },
            { 0x01, "Fast" },
            { 0x02, "Normal" },
            { 0x03, "Slow" }
        };

        public static Dictionary<byte, string> BattleSpeeds = new Dictionary<byte, string>()
        {
            { 0x00, "Wait" },
            { 0x01, "Fast" },
            { 0x02, "Normal" },
            { 0x03, "Slow" }
        };

        public static Dictionary<byte, string> DifficultyLevels = new Dictionary<byte, string>()
        {
            { 0x00, "Normal" },
            { 0x01, "Casual" }
        };

        public static Dictionary<byte, string> CameraSettings = new Dictionary<byte, string>()
        {
            { 0x00, "Normal" },
            { 0x01, "Reverse" }
        };

        public string Signature { get; set; }
        public byte SEVolume { get; set; }
        public byte BGMVolume { get; set; }
        public byte MessageSpeed { get; set; }
        public byte BattleSpeed { get; set; }
        public byte AutoMapEnable { get; set; }
        public byte BGMTestUnlocked { get; set; }
        public byte Difficulty { get; set; }
        public byte CameraLeftRight { get; set; }
        public byte CameraUpDown { get; set; }
        public byte Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }

        public Mori4Option(Stream stream) : base(stream) { }

        public override void ReadFromStream(Stream stream)
        {
            base.ReadFromStream(stream);

            BinaryReader reader = new BinaryReader(stream);

            Signature = Encoding.ASCII.GetString(reader.ReadBytes(4));
            SEVolume = reader.ReadByte();
            BGMVolume = reader.ReadByte();
            MessageSpeed = reader.ReadByte();
            BattleSpeed = reader.ReadByte();
            AutoMapEnable = reader.ReadByte();
            BGMTestUnlocked = reader.ReadByte();
            Difficulty = reader.ReadByte();
            CameraLeftRight = reader.ReadByte();
            CameraUpDown = reader.ReadByte();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadUInt16();
        }

        public override void WriteToStream(Stream stream)
        {
            base.WriteToStream(stream);

            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(Encoding.ASCII.GetBytes(Signature));
            writer.Write(SEVolume);
            writer.Write(BGMVolume);
            writer.Write(MessageSpeed);
            writer.Write(BattleSpeed);
            writer.Write(AutoMapEnable);
            writer.Write(BGMTestUnlocked);
            writer.Write(Difficulty);
            writer.Write(CameraLeftRight);
            writer.Write(CameraUpDown);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }
}
