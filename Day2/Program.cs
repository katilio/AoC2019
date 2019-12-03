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
            var opcodeOriginal = input.Split(',').Select(Int32.Parse).ToList();
            var opcode = input.Split(',').Select(Int32.Parse).ToList();
            int firstOffset = 0;
            int secondOffset = 0;
            opcode[1] = 0;
            opcode[2] = 0;


            int cursor = 0;
            
            //Part 1 && find last cursor position to start Part 2

            //for opcode[1] from 0 to 149 ->
            for (int noun = 0; noun < 149; noun++)
            {
                for (int verb = 0; verb < 149; verb++)
                {
                    opcode[1] = noun;
                    opcode[2] = verb;
                    while (cursor < opcode.Count() - 3 && cursor > -1)
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
                                //Console.WriteLine(opcode[0] + " with index 1: " + opcode[1] + " and index 2: " + opcode[2]);
                                //Console.WriteLine("/////////////////" + "\n");
                                //Console.ReadLine();
                                if (opcode[0] == 19690720)
                                {
                                    Console.WriteLine(100 * noun + verb);
                                    Console.ReadLine();
                                }
                                else { cursor = -1; }
                                break;
                        }
                    }
                    opcode = input.Split(',').Select(Int32.Parse).ToList(); cursor = 0;
                }
            }
            Console.ReadLine();
        }

    }
}
