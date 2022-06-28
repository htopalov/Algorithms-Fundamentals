using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTeams
{
    public class Program
    {
        static void Main(string[] args)
        {
            var girls = Console.ReadLine().Split(", ");
            var girlsCombination = new string[3];
            var girlsCombinations = new List<string[]>();

            GenerateCombinations(0, 0, girls, girlsCombination, girlsCombinations);

            var boys = Console.ReadLine().Split(", ");
            var boysCombination = new string[2];
            var boysCombinations = new List<string[]>();

            GenerateCombinations(0,0, boys, boysCombination, boysCombinations);

            Print(girlsCombinations, boysCombinations);
        }

        private static void Print(List<string[]> girlsCombinations, List<string[]> boysCombinations)
        {
            foreach (var girls in girlsCombinations)
            {
                foreach (var boys in boysCombinations)
                {
                    Console.WriteLine($"{string.Join(", ", girls)}, {string.Join(", ", boys)}");
                }
            }
        }

        private static void GenerateCombinations(int index, int start, string[] elements, string[] combination, List<string[]> combinations)
        {
            if (index >= combination.Length)
            {
                combinations.Add(combination.ToArray());
                return;
            }

            for (int i = start; i < elements.Length; i++)
            {
                combination[index] = elements[i];
                GenerateCombinations(index + 1, i + 1, elements, combination, combinations);
            }
        }
    }
}
