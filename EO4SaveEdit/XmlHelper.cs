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
        public static Dictionary<ushort, int> NumForgeSlots { get; private set; }
        public static Dictionary<ushort, string> ItemNames { get; private set; }
        public static Dictionary<ushort, string> TreasureMapNames { get; private set; }
        public static Dictionary<Class, Tuple<byte, string>[]> SkillData { get; private set; }

        static XmlHelper()
        {
            XmlDocument xmlDoc = new XmlDocument();

            ItemNames = new Dictionary<ushort, string>();

            xmlDoc.Load("Data\\EquipmentData.xml");
            NumForgeSlots = new Dictionary<ushort, int>();
            for (ushort i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                XmlNode node = xmlDoc.DocumentElement.ChildNodes[i];
                NumForgeSlots.Add(i, int.Parse(node.Attributes["NumSlots"].InnerText));
                ItemNames.Add(i, node.InnerText);
            }

            xmlDoc.Load("Data\\ItemData.xml");
            for (ushort i = 1, j = 925; i < xmlDoc.DocumentElement.ChildNodes.Count; i++, j++)
                ItemNames.Add(j, xmlDoc.DocumentElement.ChildNodes[i].InnerText);

            xmlDoc.Load("Data\\TreasureMapData.xml");
            TreasureMapNames = new Dictionary<ushort, string>();
            for (ushort i = 1; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
                TreasureMapNames.Add(i, xmlDoc.DocumentElement.ChildNodes[i].InnerText);

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
