using System;
using System.Collections.Generic;
using System.Xml;

namespace ExtractArtistsFromCatalog
{
    public class ExtractArtistsFromCatalog
    {
        static void Main()
        {
            // Initialization
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            XmlElement root = doc.DocumentElement;

            // Extract all artists and print them
            var artists = ExtractArtists(root);
            Console.WriteLine("All artists in the catalog:\n{0}", string.Join(", ", artists));

            Console.WriteLine(new string('-', 50));

            // Print the number of albums for each artist
            var albums = ExtractNumberOfAlbumsForEachArtist(root);
            foreach (var album in albums)
            {
                Console.WriteLine("{0}: {1} {2}", album.Key, album.Value, album.Value == 1 ?  "album" : "albums");
            }

            Console.WriteLine(new string('-', 70));
        }

        private static IDictionary<string, int> ExtractNumberOfAlbumsForEachArtist(XmlElement root)
        {
            var output = new Dictionary<string, int>();

            var albums = root.GetElementsByTagName("album");
            foreach (XmlNode album in albums)
            {
                var artist = album["artist"].InnerText;
                if (!output.ContainsKey(artist))
                {
                    output[artist] = 0;
                }

                output[artist]++;
            }

            return output;
        }

        private static IEnumerable<string> ExtractArtists(XmlElement root)
        {
            var result = new HashSet<string>();
            var albums = root.GetElementsByTagName("album");

            foreach (XmlNode album in albums)
            {
                result.Add(album["artist"].InnerText);
            }

            return result;
        }
    }
}
