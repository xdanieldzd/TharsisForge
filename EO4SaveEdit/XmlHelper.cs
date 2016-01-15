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
        public static Dictionary<SaveLanguages, Dictionary<ushort, string>> EquipmentNames { get; private set; }
        public static Dictionary<SaveLanguages, Dictionary<ushort, int>> NumForgeSlots { get; private set; }
        public static Dictionary<SaveLanguages, Dictionary<ushort, string>> AllItemNames { get; private set; }
        public static Dictionary<SaveLanguages, Dictionary<byte, string>> TreasureMapNames { get; private set; }
        public static Dictionary<SaveLanguages, Dictionary<Class, Tuple<byte, string>[]>> SkillData { get; private set; }
        public static Dictionary<SaveLanguages, Dictionary<Class, string>> ClassNames { get; private set; }

        //TODO: rework & rewrite to store both languages in one file, like class names?

        static XmlHelper()
        {
            EquipmentNames = new Dictionary<SaveLanguages, Dictionary<ushort, string>>();
            NumForgeSlots = new Dictionary<SaveLanguages, Dictionary<ushort, int>>();
            LoadEquipmentData("Data\\EquipmentDataEng.xml", SaveLanguages.English);
            LoadEquipmentData("Data\\EquipmentDataJpn.xml", SaveLanguages.Japanese);

            AllItemNames = new Dictionary<SaveLanguages, Dictionary<ushort, string>>();
            LoadItemData("Data\\ItemDataEng.xml", SaveLanguages.English);
            LoadItemData("Data\\ItemDataJpn.xml", SaveLanguages.Japanese);

            TreasureMapNames = new Dictionary<SaveLanguages, Dictionary<byte, string>>();
            LoadTreasureMapData("Data\\TreasureMapDataEng.xml", SaveLanguages.English);
            LoadTreasureMapData("Data\\TreasureMapDataJpn.xml", SaveLanguages.Japanese);

            SkillData = new Dictionary<SaveLanguages, Dictionary<Class, Tuple<byte, string>[]>>();
            LoadSkillData("Data\\SkillDataEng.xml", SaveLanguages.English);
            LoadSkillData("Data\\SkillDataJpn.xml", SaveLanguages.Japanese);

            ClassNames = new Dictionary<SaveLanguages, Dictionary<Class, string>>();
            LoadClassNames("Data\\ClassNames.xml");
        }

        static void LoadEquipmentData(string filePath, SaveLanguages lang)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            EquipmentNames[lang] = new Dictionary<ushort, string>();
            NumForgeSlots[lang] = new Dictionary<ushort, int>();
            for (ushort i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                XmlNode node = xmlDoc.DocumentElement.ChildNodes[i];
                EquipmentNames[lang].Add(i, node.InnerText);
                NumForgeSlots[lang].Add(i, int.Parse(node.Attributes["NumSlots"].InnerText));
            }
        }

        static void LoadItemData(string filePath, SaveLanguages lang)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            AllItemNames[lang] = new Dictionary<ushort, string>();
            AllItemNames[lang] = AllItemNames[lang].Concat(EquipmentNames[lang]).ToDictionary(x => x.Key, y => y.Value);
            for (ushort i = 1, j = 925; i < xmlDoc.DocumentElement.ChildNodes.Count; i++, j++)
                AllItemNames[lang].Add(j, xmlDoc.DocumentElement.ChildNodes[i].InnerText);
        }

        static void LoadTreasureMapData(string filePath, SaveLanguages lang)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            TreasureMapNames[lang] = new Dictionary<byte, string>();
            for (byte i = 1; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
                TreasureMapNames[lang].Add((byte)(i - 1), xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            TreasureMapNames[lang].Add(byte.MaxValue, xmlDoc.DocumentElement.ChildNodes[0].InnerText);
        }

        static void LoadSkillData(string filePath, SaveLanguages lang)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            SkillData[lang] = new Dictionary<Class, Tuple<byte, string>[]>();
            foreach (XmlNode classNode in xmlDoc.DocumentElement.ChildNodes)
            {
                Tuple<byte, string>[] classSkills = new Tuple<byte, string>[classNode.ChildNodes.Count];
                for (int i = 0; i < classSkills.Length; i++)
                    classSkills[i] = new Tuple<byte, string>(byte.Parse(classNode.ChildNodes[i].Attributes["MaxLevel"].InnerText), classNode.ChildNodes[i].InnerText);
                SkillData[lang][(Class)Enum.Parse(typeof(Class), classNode.Attributes["Name"].InnerText)] = classSkills;
            }
        }

        static void LoadClassNames(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            foreach (XmlNode langNode in xmlDoc.DocumentElement.ChildNodes)
            {
                SaveLanguages lang = (SaveLanguages)Enum.Parse(typeof(SaveLanguages), langNode.Attributes["Name"].InnerText);
                ClassNames[lang] = new Dictionary<Class, string>();
                foreach (XmlNode classNode in langNode.ChildNodes)
                    ClassNames[lang].Add((Class)Enum.Parse(typeof(Class), classNode.Attributes["Value"].InnerText), classNode.InnerText);
            }
        }
    }
}
