using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Use XML
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace Lab_09_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check references
            Console.WriteLine(" --+== Most Basic XML Element ==+--\n");
            XElement xml01 = new XElement("test", 1);               //"test" is the name of the field and 1 is the value of the data
            Console.WriteLine(xml01);
            //Add a subelement
            Console.WriteLine("\n\n --+== Adding a sub-element ==+--\n");
            XElement xml02 = new XElement("RootElement",
                new XElement("Sub-Element", 2)
                );
            Console.WriteLine(xml02);

            Console.WriteLine("\n");
            XElement xml03 = new XElement("RootElement",
                new XElement("Sub-Element",
                new XElement("Sub-Sub-Element", 3)),
                new XElement("Sub-Element", 2),
                new XElement("Sub-Element", 2),
                new XElement("Sub-Element", 2)
                );
            Console.WriteLine(xml03);
            
            //Adding attributes
            Console.WriteLine("\n\n --+== Adding an attribute to an element ==+--\n");
            XElement xml04 = new XElement("RootElement",
                new XElement("Sub-Element",
                new XElement("Sub-Sub-Element", 3)),
                new XElement("Sub-Element",new XAttribute("Height", 500),
                2),
                new XElement("Sub-Element", 2),
                new XElement("Sub-Element", 2)
                );
            Console.WriteLine(xml04);

            Console.WriteLine("\n\n --+== Adding an attribute to each and all elements ==+--\n");
            XElement xml05 = new XElement("RootElement",
                new XElement("Sub-Element", new XAttribute("Height", 500),
                new XElement("Sub-Sub-Element", new XAttribute("Height", 500), 3)),
                new XElement("Sub-Element", new XAttribute("Height", 500), 2),
                new XElement("Sub-Element", new XAttribute("Height", 500), 2),
                new XElement("Sub-Element", new XAttribute("Height", 500), 2)
                );
            Console.WriteLine(xml05);

            //Saving the XML to a file
            XElement xml06 = new XElement("RootElement",
                new XElement("Sub-Element", new XAttribute("Height", 500),
                new XElement("Sub-Sub-Element", new XAttribute("Height", 500), 3)),
                new XElement("Sub-Element", new XAttribute("Height", 500), 2),
                new XElement("Sub-Element", new XAttribute("Height", 500), 2),
                new XElement("Sub-Element", new XAttribute("Height", 500), 2)
                );
            XDocument file = new XDocument(XElement.Parse(xml06.ToString()));
            file.Save("Xml06.xml");

            //Loading info from an XML file
            Console.WriteLine("\n\n --+== Loading from a file ==+--\n");
            XDocument doc07 = XDocument.Load("Xml06.xml");
        }
    }
}
