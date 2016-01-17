using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

using EO4SaveEdit.Extensions;

namespace EO4SaveEdit
{
    /* Temp stuff to get names etc from RomFS, so that the editor won't require RomFS! */
    /* SUPER UGLY, I know, but it's just for ripping stuff out of somewhere else! It's not supposed to be "production-quality code" or what have you */
    /* Yeah, yeah, adding more and more to this, it's still temporary! */
    static class RomFSDataDumper
    {
        public static List<string> ReadNameTable(string file)
        {
            List<string> nameTable = new List<string>();
            using (BinaryReader reader = new BinaryReader(File.OpenRead(file)))
            {
                List<ushort> nameLengths = new List<ushort>();

                ushort numNames = reader.ReadUInt16();
                for (int i = 0; i < numNames; i++) nameLengths.Add(reader.ReadUInt16());

                ushort lastLen = 0;
                foreach (ushort length in nameLengths)
                {
                    nameTable.Add(Encoding.GetEncoding(932).GetString(reader.ReadBytes(length - lastLen)).TrimEnd('\0').SjisToAscii());
                    lastLen = length;
                }
            }
            return nameTable;
        }

        public static void DumpItemData(string inPathEnglish, string inPathJapanese, string inPathData, string outPath)
        {
            List<string> nameTableEng = ReadNameTable(inPathEnglish);
            List<string> nameTableJpn = ReadNameTable(inPathJapanese);
            if (nameTableEng.Count != nameTableJpn.Count) throw new Exception();

            List<int> numEffectSlots = new List<int>();

            using (BinaryReader reader = new BinaryReader(File.OpenRead(inPathData)))
            {
                for (int i = 0; i < nameTableEng.Count; i++)
                {
                    reader.BaseStream.Seek(0x2E, SeekOrigin.Current);
                    int forgeableSlots = reader.ReadByte();
                    int existingSlots = 0;
                    for (int j = 0; j < 8; j++)
                        if (reader.ReadByte() != 0)
                            existingSlots++;
                    numEffectSlots.Add(existingSlots + forgeableSlots);
                    reader.BaseStream.Seek(0x09, SeekOrigin.Current);
                }
            }

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(File.CreateText(outPath), settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Table");
                for (int i = 0; i < nameTableEng.Count; i++)
                {
                    writer.WriteStartElement("Item");
                    {
                        writer.WriteAttributeString("NumSlots", numEffectSlots[i].ToString());

                        writer.WriteStartElement("Name");
                        {
                            writer.WriteAttributeString("Language", "English");
                            writer.WriteValue(nameTableEng[i]);
                        }
                        writer.WriteEndElement();

                        writer.WriteStartElement("Name");
                        {
                            writer.WriteAttributeString("Language", "Japanese");
                            writer.WriteValue(nameTableJpn[i]);
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static void DumpSkillData(string inPathEnglish, string inPathJapanese, string inPathMaxLevel, string inPathNameIds, string outPath)
        {
            List<string> nameTableEng = ReadNameTable(inPathEnglish);
            List<string> nameTableJpn = ReadNameTable(inPathJapanese);
            if (nameTableEng.Count != nameTableJpn.Count) throw new Exception();

            List<byte> nameIds = new List<byte>();
            List<byte> maxLevels = new List<byte>();

            List<Tuple<FileHandlers.Class, byte, Dictionary<SaveLanguages, string>>> skills = new List<Tuple<FileHandlers.Class, byte, Dictionary<SaveLanguages, string>>>();

            using (BinaryReader reader = new BinaryReader(File.OpenRead(inPathNameIds)))
            {
                for (int i = 0; i < 0xFA; i++)
                {
                    nameIds.Add(reader.ReadByte());
                    reader.BaseStream.Seek(0x33, SeekOrigin.Current);
                }
            }

            using (BinaryReader reader = new BinaryReader(File.OpenRead(inPathMaxLevel)))
            {
                reader.BaseStream.Seek(0x178 * 2, SeekOrigin.Begin);
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    maxLevels.Add(reader.ReadByte());
                    reader.BaseStream.Seek(0x177, SeekOrigin.Current);
                }
            }

            FileHandlers.Class[] classes = (FileHandlers.Class[])Enum.GetValues(typeof(FileHandlers.Class));

            int n = 0;
            for (int i = 0; i < 0xA; i++)   //classes
            {
                for (int j = 0; j < 0x19; j++)  //skills
                {
                    Dictionary<SaveLanguages, string> names = new Dictionary<SaveLanguages, string>();
                    names.Add(SaveLanguages.English, nameTableEng[nameIds[n]]);
                    names.Add(SaveLanguages.Japanese, nameTableJpn[nameIds[n]]);
                    skills.Add(new Tuple<FileHandlers.Class, byte, Dictionary<SaveLanguages, string>>(classes[i], maxLevels[n], names));
                    n++;
                }
            }

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(File.CreateText(outPath), settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Table");
                for (int i = 0; i < classes.Length - 1; i++)
                {
                    List<Tuple<FileHandlers.Class, byte, Dictionary<SaveLanguages, string>>> classSkill = skills.Where(x => x.Item1 == classes[i]).ToList();

                    writer.WriteStartElement("Class");
                    writer.WriteAttributeString("Value", classes[i].ToString());
                    foreach (Tuple<FileHandlers.Class, byte, Dictionary<SaveLanguages, string>> skill in classSkill)
                    {
                        writer.WriteStartElement("Skill");
                        writer.WriteAttributeString("MaxLevel", skill.Item2.ToString());
                        foreach (KeyValuePair<SaveLanguages, string> name in skill.Item3)
                        {
                            writer.WriteStartElement("Name");
                            {
                                writer.WriteAttributeString("Language", name.Key.ToString());
                                writer.WriteValue(name.Value);
                            }
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static void DumpTreasureMapData(string inPathEnglish, string inPathJapanese, string outPath)
        {
            List<string> nameTableEng = ReadNameTable(inPathEnglish);
            List<string> nameTableJpn = ReadNameTable(inPathJapanese);
            if (nameTableEng.Count != nameTableJpn.Count) throw new Exception();

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(File.CreateText(outPath), settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Table");
                for (int i = 0; i < nameTableEng.Count; i++)
                {
                    writer.WriteStartElement("Map");
                    {
                        writer.WriteStartElement("Name");
                        {
                            writer.WriteAttributeString("Language", "English");
                            writer.WriteValue(nameTableEng[i]);
                        }
                        writer.WriteEndElement();

                        writer.WriteStartElement("Name");
                        {
                            writer.WriteAttributeString("Language", "Japanese");
                            writer.WriteValue(nameTableJpn[i]);
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static void DumpUseItemData(string inPathEnglish, string inPathJapanese, string outPath)
        {
            List<string> nameTableEng = ReadNameTable(inPathEnglish);
            List<string> nameTableJpn = ReadNameTable(inPathJapanese);
            if (nameTableEng.Count != nameTableJpn.Count) throw new Exception();

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(File.CreateText(outPath), settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Table");
                for (int i = 0; i < nameTableEng.Count; i++)
                {
                    writer.WriteStartElement("Item");
                    {
                        writer.WriteStartElement("Name");
                        {
                            writer.WriteAttributeString("Language", "English");
                            writer.WriteValue(nameTableEng[i]);
                        }
                        writer.WriteEndElement();

                        writer.WriteStartElement("Name");
                        {
                            writer.WriteAttributeString("Language", "Japanese");
                            writer.WriteValue(nameTableJpn[i]);
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

    }
}
