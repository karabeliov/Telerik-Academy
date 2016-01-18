using System;
using System.Xml;

namespace RemoveAllAlbumsWithPrice
{
    public class RemoveAllAlbumsWithPrice
    {
        public static void Main()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../musicCatalog.xml");

            var rootNode = xmlDoc.DocumentElement;
            foreach (XmlElement album in rootNode.SelectNodes("album"))
            {
                var price = double.Parse(album["price"].InnerText);
                if (price > 20)
                {
                    rootNode.RemoveChild(album);
                }
            }

            xmlDoc.Save("../../new-catalog.xml");
            Console.WriteLine("Operation is ready!");
        }
    }
}
