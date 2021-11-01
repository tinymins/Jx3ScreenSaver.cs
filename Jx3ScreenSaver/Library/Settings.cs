using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace Jx3ScreenSaver
{
    public class Settings
    {
        // Cache
        private static Dictionary<string, string> dicCache = new Dictionary<string,string>();
        private static string xmlRoot = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TmsJx3ScreenSaver\\";
        private static string xmlPath = xmlRoot + "config.xml";
        private static XmlDocument xmlDoc = null;

        // Load xml file
        private static void LoadXml()
        {
            if (xmlDoc == null)
            {
                xmlDoc = new XmlDocument();
                if (File.Exists(xmlPath))
                {
                    xmlDoc.Load(xmlPath);
                }
                if (xmlDoc.SelectSingleNode("config") == null)
                {
                    xmlDoc.AppendChild(xmlDoc.CreateNode(XmlNodeType.Element, "config", null));
                }
            }
        }

        // Save xml file
        private static void SaveXml()
        {
            if (xmlDoc != null)
            {
                if (!Directory.Exists(xmlRoot))
                {
                    Directory.CreateDirectory(xmlRoot);
                }
                xmlDoc.Save(xmlPath);
            }
        }

        // Set setting value by key and value
        private static void Set(string key, string value)
        {
            LoadXml();
            bool isfind = false;
            XmlNode root = xmlDoc.SelectSingleNode("config");
            XmlNodeList nodeList = root.ChildNodes;
            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("key") == key)
                {
                    xe.SetAttribute("value", value);
                    isfind = true;
                    break;
                }
            }
            if (!isfind)
            {
                XmlElement xe1 = xmlDoc.CreateElement("cfg");
                xe1.SetAttribute("key", key);
                xe1.SetAttribute("value", value);
                root.AppendChild(xe1);
            }
            SaveXml();

            dicCache[key] = value;
        }

        // Get setting value by key and default value
        private static string Get(string key, string defaultVal)
        {
            LoadXml();
            if (!dicCache.ContainsKey(key))
            {
                XmlNode root = xmlDoc.SelectSingleNode("config");
                XmlNodeList nodeList = root.ChildNodes;
                foreach (XmlNode xn in nodeList)
                {
                    XmlElement xe = (XmlElement)xn;
                    if (xe.GetAttribute("key") == key)
                    {
                        dicCache[key] = xe.GetAttribute("value");
                        break;
                    }
                }

                if (!dicCache.ContainsKey(key))
                    dicCache[key] = defaultVal;
            }
            return dicCache[key];
        }

        // Setting values
        public static int    ClosingTime         { get { return    int.Parse(Get("ClosingTime"      , "10000")); } set { Set("ClosingTime"      , value.ToString()); } }
        public static int    CreateInterval      { get { return    int.Parse(Get("CreateInterval"   , "300"  )); } set { Set("CreateInterval"   , value.ToString()); } }
        public static double BackgroundOpacity   { get { return double.Parse(Get("BackgroundOpacity", "0"    )); } set { Set("BackgroundOpacity", value.ToString()); } }
        public static double ForegroundOpacity   { get { return double.Parse(Get("ForegroundOpacity", "1"    )); } set { Set("ForegroundOpacity", value.ToString()); } }
        public static int    MaxInstanceCount    { get { return    int.Parse(Get("MaxInstanceCount" , "50"   )); } set { Set("MaxInstanceCount" , value.ToString()); } }
        public static bool   UseSeasunDumpReport { get { return bool.Parse(Get("UseSeasunDumpReport", "false")); } set { Set("UseSeasunDumpReport", value.ToString()); } }
    }
}