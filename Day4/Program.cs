using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4
{
    class Program
    {
        private static bool HasDoubles (int number)
        {
            char[] digits = number.ToString().ToCharArray();
            for (int i = 0; i < 5; i++)
            {
                //Part 1   if(digits[i] == digits[i+1]) { return true; }
                if (i == 4) {
                    if (digits[i] == digits[i + 1] && digits[i] != digits[i-1]) {
                        return true; } }
                else if (i == 0 && digits[i] == digits[i + 1] && digits[i] != digits[i + 2])
                {
                    return true;
                }
                else if (digits[i] == digits[i + 1] && digits[i] != digits[i+2] && digits[i] != digits[i-1]) {
                    return true; }
            }
            return false;
        }

        private static bool NeverDecreases (int number)
        {
            char[] digits = number.ToString().ToCharArray();
            for (int i = 0; i < 5; i++)
            {
                if (!(digits[i] <= digits[i+1])) { return false; }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int min = 153517;
            int max = 630395;
            List<int> possiblePasswords = new List<int>();
            for (int i = min; i < max; i++)
            {
                if (HasDoubles(i) && NeverDecreases(i))
                {
                    possiblePasswords.Add(i);
                }
            }

            Console.WriteLine("Number of possible passwords = " + possiblePasswords.Count());
            Console.ReadLine();
        }
    }
}
