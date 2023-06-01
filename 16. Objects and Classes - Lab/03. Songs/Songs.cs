// Define a class called Song that will hold the following information about some songs:
// • Type List
// • Name
// • Time
// Input / Constraints
// • On the first line, you will receive the number of songs - N.
// • On the next N lines, you will be receiving data in the following format: "{typeList}_{name}_{time}".
// • On the last line, you will receive Type List or "all".
// Output
// If you receive Type List as an input on the last line, print out only the names of the songs, which are from that Type
// List. If you receive the "all" command, print out the names of all the songs.

namespace _3._Songs
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfSongs = int.Parse(Console.ReadLine());
            List<Song> songList = new List<Song>();

            for (int i = 0; i < numOfSongs; i++)
            {
                List<string> curentSongProperty = Console.ReadLine().Split("_").ToList();
                string typeList = curentSongProperty[0];
                string name = curentSongProperty[1];
                string time = curentSongProperty[2];

                Song curentSong = new Song(typeList, name, time);
                songList.Add(curentSong);
            }

            string lookForSong = Console.ReadLine();

            if (lookForSong == "all")
            {
                foreach (Song song in songList)
                {
                    Console.WriteLine($"{song.Name}");
                }
            }
            else
            {
                foreach (var song in songList)
                {
                    if(lookForSong == song.TypeList)
                    {
                        Console.WriteLine($"{song.Name}");
                    }
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}