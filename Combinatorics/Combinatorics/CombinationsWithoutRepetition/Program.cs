using System;

namespace CombinationsWithoutRepetition
{
    public class Program
    {
        private static string[] elements;
        private static string[] combinations;
        private static int k;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());
            combinations = new string[k];

            CombinationsGen(0, 0);
        }

        private static void CombinationsGen(int index, int elementsStartIndex)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = elementsStartIndex; i < elements.Length; i++)
            {
                combinations[index] = elements[i];
                CombinationsGen(index + 1, i + 1);
            }
        }
    }
}
