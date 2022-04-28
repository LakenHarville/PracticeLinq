using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "Call of Duty", "IT", "Forza Horizon", "Star Wars", "Ghost Recon: Wildlands" };
            var lengths = games.OrderBy(game => game.Length).ToList();
            lengths.ForEach(x => Console.WriteLine(x));
           
         }
    }
}
