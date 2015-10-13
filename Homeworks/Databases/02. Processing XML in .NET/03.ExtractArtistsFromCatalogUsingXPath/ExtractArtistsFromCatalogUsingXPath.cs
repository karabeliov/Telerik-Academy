using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace ExtractArtistsFromCatalogUsingXPath
{
    public class ExtractArtistsFromCatalogUsingXPath
    {
        static void Main()
        {
            // Initialization
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            // Extract all artists by type and print them
            string music = "/catalog/album[@type='music']";
            XmlNodeList musicAlbums = doc.SelectNodes(music);
            var artists = ExtractArtists(musicAlbums);
            Console.WriteLine(string.Join(", ", artists));

            Console.WriteLine(new string('-', 70));

            // Print the number of albums for each artist
            var musicAlbumNumber = ExtractNumberOfAlbumsForEachArtist(musicAlbums);
            foreach (var album in musicAlbumNumber)
            {
                Console.WriteLine("{0}: {1} {2}", album.Key, album.Value, album.Value == 1 ? "album" : "albums");
            }          
        }

        private static IDictionary<string, int> ExtractNumberOfAlbumsForEachArtist(IEnumerable albumsList)
        {
            var artistsList = new Dictionary<string, int>();
            foreach (XmlNode album in albumsList)
            {
                var artistName = album.SelectSingleNode("artist").InnerText;
                if (!artistsList.ContainsKey(artistName))
                {
                    artistsList[artistName] = 0;
                }

                artistsList[artistName]++;
            }

            return artistsList;
        }

        private static IEnumerable<string> ExtractArtists(XmlNodeList musicAlbums)
        {
            var result = new HashSet<string>();

            foreach (XmlNode musicAlbum in musicAlbums)
            {
                var music = musicAlbum.SelectSingleNode("artist");
                result.Add(music.InnerText);
            }

            return result;
        }
    }
}
