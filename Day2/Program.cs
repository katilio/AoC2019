using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day2
{
    class Program
    {


        static void Main(string[] args)
        {
            string path = "C:/Users/arodriguezcuadra/Downloads/AoC2019/Day2.txt";

            string input = File.ReadAllLines(@path).Select(s => s.TrimStart(',')).ToArray()[0];
            var opcode = input.Split(',').Select(Int32.Parse).ToList();
            opcode[1] = 12;
            opcode[2] = 2;

            int cursor = 0;
            while (cursor < opcode.Count() - 3)
            {
                switch (opcode[cursor])
                {
                    case 1:
                        opcode[opcode[cursor + 3]] = opcode[opcode[cursor + 1]] + opcode[opcode[cursor + 2]];
                        cursor += 4;
                        break;
                    case 2:
                        opcode[opcode[cursor + 3]] = opcode[opcode[cursor + 1]] * opcode[opcode[cursor + 2]];
                        cursor += 4;
                        break;
                    case 99:
                        Console.WriteLine(opcode[0]);
                        Console.ReadLine();
                        break;

                }
            }
        }

    }
}
