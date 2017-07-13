using System;
using System.Collections.Generic;

namespace killnickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List <(string Name, string Song)> goodSongs = new List <(string, string)>();
            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();
            allSongs.Add(("Get Away", "The Internet"));
            allSongs.Add(("Photograph", "Nickelback"));
            allSongs.Add(("Bleed", "Deadmau5"));
            allSongs.Add(("Flicker", "Porter Robinson"));
            allSongs.Add(("Pavane", "Faure"));
            allSongs.Add(("Bonfire", "Childish Gambino"));
            allSongs.Add(("Savin' me", "Nickelback"));

            foreach ((string, string) song in allSongs) {
                if (song.Item2 != "Nickelback") {
                    goodSongs.Add(song);
                    Console.WriteLine(song);
                }
            }
        }
    }
}
