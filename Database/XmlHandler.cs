using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cinema
{
    public class XmlHandler
    {
        private static XElement xmltree = XElement.Load("Config.xml");
        private static readonly string PATH = "Config.xml";

        static void LoadXmlHandler()
        {
            xmltree = XElement.Load("Config.xml");
        }

        public static bool IsViewModeAdmin()
        {
            return xmltree.Element("viewmode").Value == "Admin" || xmltree.Element("viewmode").Value == "admin";
        }
        public static string ReadElementValue(string elementName) 
        {
            XElement? elem = xmltree.Element(elementName);
            if (elem != null)
            {
                return (string)elem.Value;
            }
            else
            {
                return "";
            }
        }

        public static IEnumerable<XElement> ReadDescendants(string elementName)
        {
            IEnumerable<XElement> elements = xmltree.Descendants(elementName);
            return elements;
        }

        public static IEnumerable<XElement> ReadChildElements(string elementName)
        {
            IEnumerable<XElement> elements = xmltree.Elements(elementName);
            return elements;
        }

        public static void ModifyElement(int screeningId, XElement movie)
        {
            XElement screeningElement = xmltree.Descendants("screening").Descendants("id")
                .First(e => int.Parse(e.Value) == screeningId).Parent;
           //XElement screeningElement = xmltree.Elements("screening")
                //.First(e => int.Parse(e.Element("id").Value) == screeningId);

            if (screeningElement != null)
            {
                screeningElement.ReplaceWith(movie);

                xmltree.Save(PATH);
                LoadXmlHandler();
                Console.WriteLine("Screening modified successfully.");
            }
            else
            {
                Console.WriteLine("Screening not found.");
                throw new Exception("Screening not found.");
            }
        }

        public static void WriteElement(XElement element)
        {
            xmltree.Add(element);
            xmltree.Save(PATH);
            LoadXmlHandler();
        }

    }
}

