using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit
{
    public static class XmlHelper
    {
        public static Dictionary<ushort, string> EquipmentNames { get; private set; }
        public static Dictionary<ushort, int> NumForgeSlots { get; private set; }
        public static Dictionary<ushort, string> AllItemNames { get; private set; }
        public static Dictionary<byte, string> TreasureMapNames { get; private set; }
        public static Dictionary<Class, Tuple<byte, string>[]> SkillData { get; private set; }

        static XmlHelper()
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("Data\\EquipmentData.xml");
            EquipmentNames = new Dictionary<ushort, string>();
            NumForgeSlots = new Dictionary<ushort, int>();
            for (ushort i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                XmlNode node = xmlDoc.DocumentElement.ChildNodes[i];
                EquipmentNames.Add(i, node.InnerText);
                NumForgeSlots.Add(i, int.Parse(node.Attributes["NumSlots"].InnerText));
            }

            xmlDoc.Load("Data\\ItemData.xml");
            AllItemNames = new Dictionary<ushort, string>();
            AllItemNames = AllItemNames.Concat(EquipmentNames).ToDictionary(x => x.Key, y => y.Value);
            for (ushort i = 1, j = 925; i < xmlDoc.DocumentElement.ChildNodes.Count; i++, j++)
                AllItemNames.Add(j, xmlDoc.DocumentElement.ChildNodes[i].InnerText);

            xmlDoc.Load("Data\\TreasureMapData.xml");
            TreasureMapNames = new Dictionary<byte, string>();
            for (byte i = 1; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
                TreasureMapNames.Add((byte)(i - 1), xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            TreasureMapNames.Add(byte.MaxValue, xmlDoc.DocumentElement.ChildNodes[0].InnerText);

            xmlDoc.Load("Data\\SkillData.xml");
            SkillData = new Dictionary<Class, Tuple<byte, string>[]>();
            foreach (XmlNode classNode in xmlDoc.DocumentElement.ChildNodes)
            {
                Tuple<byte, string>[] classSkills = new Tuple<byte, string>[classNode.ChildNodes.Count];
                for (int i = 0; i < classSkills.Length; i++)
                    classSkills[i] = new Tuple<byte, string>(byte.Parse(classNode.ChildNodes[i].Attributes["MaxLevel"].InnerText), classNode.ChildNodes[i].InnerText);
                SkillData[(Class)Enum.Parse(typeof(Class), classNode.Attributes["Name"].InnerText)] = classSkills;
            }
        }
    }
}
