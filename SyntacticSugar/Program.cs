using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {

            var predatorsForBug1 = new List<string>()
            {
                "Human", "Raid"
            };
            predatorsForBug1.Add("Dinosaurs");

            var preyForBug1 = new List<string>()
            {
                "Fly",
                "Caterpillar"
            };

            var bug1 = new Bug("Black Widow", "Spider", predatorsForBug1, preyForBug1);

            Console.WriteLine(bug1.PredatorList());
            Console.WriteLine(bug1.PreyList());
            Console.WriteLine(bug1.Eat("Fly"));

            var predatorsForBug2 = new List<string>()
            { "Human", "Mouse", "Bat" };
            var preyForBug2 = new List<string>()
            { "Spiders", "Lizards" };

            var bug2 = new Bug("King Scorpio", "scorpion", predatorsForBug2, preyForBug2);

            Console.WriteLine(bug2.PredatorList());
            Console.WriteLine(bug2.PreyList());
            Console.WriteLine(bug2.Eat("Fly"));

        }
    }
}
