using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cinema
{
    public class XmlHandler
    {
        private static readonly XElement XMLTREE;

        static XmlHandler()
        {
            XMLTREE = XElement.Load("Config.xml");
        }

        public static bool IsViewModeAdmin()
        {
            return XMLTREE.Element("viewmode").Value == "Admin" || XMLTREE.Element("viewmode").Value == "admin";
        }
        public static string ReadElementValue(string elementName) 
        {
            XElement? elem = XMLTREE.Element(elementName);
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
            IEnumerable<XElement> elements = XMLTREE.Descendants(elementName);
            return elements;
        }

        public static void WriteElement(XElement element)
        {
            /*
            XElement xmlTree1 = new XElement("Root",
                new XElement("Child", 1),
                new XElement("Child", 2),
                new XElement("Child", 3),
                new XElement("Child", 4),
                new XElement("Child", 5),
                new XElement("Child", 6)
            );

            < Root >
              < Child > 3 </ Child >
              < Child > 4 </ Child >
              < Child > 5 </ Child >
            </ Root >
            */
            XMLTREE.Add(element);
            XMLTREE.Save("Config.xml");
        }

    }
}

