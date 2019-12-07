using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2019
{

    public class Shared
    {
        public static string[] getInput(string filename)
        {
            string path = "A:/Downloads/" + filename;
            string[] input = File.ReadAllLines(@path).Select(s => s.TrimStart()).ToArray();
            return input;
        }
        public static List<string> getInputList(string filename)
        {
            List<string> input = File.ReadAllLines(@filename).Select(s => s.TrimStart()).ToList<string>();
            return input;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Shared.getInput("day1.txt");
            double totalFuel = 0;
            foreach (string line in input)
            {
                double dividedMass = (int.Parse(line) / 3);
                double fuel = Math.Floor(dividedMass) - 2;
                totalFuel += fuel;
                while (fuel > 6) // Part 2
                {
                    fuel = fuel / 3;
                    fuel = Math.Floor(fuel) - 2;
                    totalFuel += fuel;
                }
            }

            Console.WriteLine(totalFuel);
            Console.ReadLine();
        }
    }
}
