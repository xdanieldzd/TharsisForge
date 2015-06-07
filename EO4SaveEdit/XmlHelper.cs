﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit
{
    public static class XmlHelper
    {
        public static int[] NumForgeSlots { get; private set; }
        public static string[] ItemNames { get; private set; }
        public static string[] TreasureMapNames { get; private set; }
        public static Dictionary<Class, Tuple<byte, string>[]> SkillData { get; private set; }

        static XmlHelper()
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("Data\\ItemData.xml");
            NumForgeSlots = new int[xmlDoc.DocumentElement.ChildNodes.Count];
            ItemNames = new string[xmlDoc.DocumentElement.ChildNodes.Count];
            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                XmlNode node = xmlDoc.DocumentElement.ChildNodes[i];
                NumForgeSlots[i] = int.Parse(node.Attributes["NumSlots"].InnerText);
                ItemNames[i] = node.InnerText;
            }

            xmlDoc.Load("Data\\TreasureMapData.xml");
            TreasureMapNames = new string[xmlDoc.DocumentElement.ChildNodes.Count];
            for (int i = 1; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
                TreasureMapNames[i] = xmlDoc.DocumentElement.ChildNodes[i].InnerText;

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