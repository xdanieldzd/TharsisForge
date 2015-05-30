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
    static class RomFSDataDumper
    {
        public static void DumpItemData(string inPathNames, string inPathData, string outPath)
        {
            List<ushort> nameLengths = new List<ushort>();

            List<string> nameTable = new List<string>();
            List<int> numEffectSlots = new List<int>();

            using (BinaryReader reader = new BinaryReader(File.OpenRead(inPathNames)))
            {
                ushort numNames = reader.ReadUInt16();
                for (int i = 0; i < numNames; i++) nameLengths.Add(reader.ReadUInt16());

                ushort lastLen = 0;
                foreach (ushort length in nameLengths)
                {
                    nameTable.Add(Encoding.GetEncoding(932).GetString(reader.ReadBytes(length - lastLen)).TrimEnd('\0').SjisToAscii());
                    lastLen = length;
                }
            }

            using (BinaryReader reader = new BinaryReader(File.OpenRead(inPathData)))
            {
                for (int i = 0; i < nameTable.Count; i++)
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
                for (int i = 0; i < nameTable.Count; i++)
                {
                    writer.WriteStartElement("Item");
                    writer.WriteAttributeString("NumSlots", numEffectSlots[i].ToString());
                    writer.WriteValue(nameTable[i]);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
