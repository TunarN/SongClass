using SongClass.model;
using System;

namespace SongClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Singer IceCUb = new Singer
            {
                Name = "O'Shea",
                Surname = "Jackson",
                Age = 53
            };
            Song YouKnowHowWeDoIt = new Song
            {
                Name = "You Know How We Do It ",
                Genre = "Pop",
                Singer = IceCUb,
            };
            YouKnowHowWeDoIt.Addreting(10);
            YouKnowHowWeDoIt.Addreting(9);
            YouKnowHowWeDoIt.Addreting(10);
            YouKnowHowWeDoIt.Addreting(9);
            Console.WriteLine(YouKnowHowWeDoIt.GetAverageRating());





        }
    }
}
