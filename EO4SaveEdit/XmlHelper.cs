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

        //TODO: remove duplicate data, i.e. duplicate numforgeslots for english & japanese; skilldata organization is garbage currently

        static XmlHelper()
        {
            LoadEquipmentData("Data\\EquipmentData.xml");
            LoadItemData("Data\\ItemData.xml");
            LoadTreasureMapData("Data\\TreasureMapData.xml");
            LoadSkillData("Data\\SkillData.xml");
            LoadClassNames("Data\\ClassNames.xml");
        }

        static Dictionary<SaveLanguages, string> ReadNameNodes(XmlNode parentNode)
        {
            Dictionary<SaveLanguages, string> names = new Dictionary<SaveLanguages, string>();
            foreach (XmlNode nameNode in parentNode.ChildNodes)
            {
                SaveLanguages nameLang = (SaveLanguages)Enum.Parse(typeof(SaveLanguages), nameNode.Attributes["Language"].InnerText);
                names.Add(nameLang, nameNode.InnerText);
            }
            return names;
        }

        static void LoadEquipmentData(string filePath)
        {
            EquipmentNames = new Dictionary<SaveLanguages, Dictionary<ushort, string>>();
            NumForgeSlots = new Dictionary<SaveLanguages, Dictionary<ushort, int>>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            for (ushort i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                XmlNode equipmentNode = xmlDoc.DocumentElement.ChildNodes[i];

                int numSlots = int.Parse(equipmentNode.Attributes["NumSlots"].InnerText);
                Dictionary<SaveLanguages, string> names = ReadNameNodes(equipmentNode);
                foreach (KeyValuePair<SaveLanguages, string> name in names)
                {
                    if (!EquipmentNames.ContainsKey(name.Key)) EquipmentNames[name.Key] = new Dictionary<ushort, string>();
                    if (!NumForgeSlots.ContainsKey(name.Key)) NumForgeSlots[name.Key] = new Dictionary<ushort, int>();

                    EquipmentNames[name.Key].Add(i, name.Value);
                    NumForgeSlots[name.Key].Add(i, numSlots);
                }
            }
        }

        static void LoadItemData(string filePath)
        {
            AllItemNames = new Dictionary<SaveLanguages, Dictionary<ushort, string>>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            for (ushort i = 1, j = 925; i < xmlDoc.DocumentElement.ChildNodes.Count; i++, j++)
            {
                XmlNode itemNode = xmlDoc.DocumentElement.ChildNodes[i];

                Dictionary<SaveLanguages, string> names = ReadNameNodes(itemNode);
                foreach (KeyValuePair<SaveLanguages, string> name in names)
                {
                    if (!AllItemNames.ContainsKey(name.Key))
                    {
                        AllItemNames[name.Key] = new Dictionary<ushort, string>();
                        AllItemNames[name.Key] = AllItemNames[name.Key].Concat(EquipmentNames[name.Key]).ToDictionary(x => x.Key, y => y.Value);
                    }

                    AllItemNames[name.Key].Add(j, name.Value);
                }
            }
        }

        static void LoadTreasureMapData(string filePath)
        {
            TreasureMapNames = new Dictionary<SaveLanguages, Dictionary<byte, string>>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                XmlNode mapNode = xmlDoc.DocumentElement.ChildNodes[i];

                Dictionary<SaveLanguages, string> names = ReadNameNodes(mapNode);
                foreach (KeyValuePair<SaveLanguages, string> name in names)
                {
                    if (!TreasureMapNames.ContainsKey(name.Key)) TreasureMapNames[name.Key] = new Dictionary<byte, string>();
                    TreasureMapNames[name.Key].Add(i == 0 ? byte.MaxValue : (byte)(i - 1), name.Value);
                }
            }
        }

        static void LoadSkillData(string filePath)
        {
            SkillData = new Dictionary<SaveLanguages, Dictionary<Class, Tuple<byte, string>[]>>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            foreach (XmlNode classNode in xmlDoc.DocumentElement.ChildNodes)
            {
                Class classValue = (Class)Enum.Parse(typeof(Class), classNode.Attributes["Value"].InnerText);
                Tuple<byte, Dictionary<SaveLanguages, string>>[] classSkills = new Tuple<byte, Dictionary<SaveLanguages, string>>[classNode.ChildNodes.Count];

                for (int i = 0; i < classNode.ChildNodes.Count; i++)
                {
                    XmlNode skillNode = classNode.ChildNodes[i];

                    byte maxLevel = byte.Parse(skillNode.Attributes["MaxLevel"].InnerText);
                    classSkills[i] = new Tuple<byte, Dictionary<SaveLanguages, string>>(maxLevel, ReadNameNodes(skillNode));
                }

                foreach (SaveLanguages lang in Enum.GetValues(typeof(SaveLanguages)))
                {
                    if (!SkillData.ContainsKey(lang)) SkillData[lang] = new Dictionary<Class, Tuple<byte, string>[]>();

                    Tuple<byte, string>[] classSkillsLoc = new Tuple<byte, string>[classSkills.Length];
                    for (int j = 0; j < classSkills.Length; j++)
                        classSkillsLoc[j] = new Tuple<byte, string>(classSkills[j].Item1, classSkills[j].Item2[lang]);
                    SkillData[lang].Add(classValue, classSkillsLoc);
                }
            }
        }

        static void LoadClassNames(string filePath)
        {
            ClassNames = new Dictionary<SaveLanguages, Dictionary<Class, string>>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            foreach (XmlNode classNode in xmlDoc.DocumentElement.ChildNodes)
            {
                Class classValue = (Class)Enum.Parse(typeof(Class), classNode.Attributes["Value"].InnerText);
                Dictionary<SaveLanguages, string> names = ReadNameNodes(classNode);
                foreach (KeyValuePair<SaveLanguages, string> name in names)
                {
                    if (!ClassNames.ContainsKey(name.Key)) ClassNames[name.Key] = new Dictionary<Class, string>();
                    ClassNames[name.Key].Add(classValue, name.Value);
                }
            }
        }
    }
}
