using System;
using System.Text;
using System.Xml;

namespace ParsingXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader xmlReader = XmlReader.Create("https://coinmarketcap.com/all/views/all/");
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Cube"))
                {
                    if (xmlReader.HasAttributes)
                        Console.WriteLine(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));
                }
            }
            Console.ReadKey();
        }
    }
}