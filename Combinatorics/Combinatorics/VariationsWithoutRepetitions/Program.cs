using System;

namespace VariationsWithoutRepetitions
{
    public class Program
    {
        private static string[] elements;
        private static string[] variations;
        private static bool[] used;
        private static int k;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());
            used = new bool[elements.Length];
            variations = new string[k];

            VariationsGen(0);
        }

        private static void VariationsGen(int index)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    variations[index] = elements[i];
                    VariationsGen(index + 1);
                    used[i] = false;
                }
               
            }
        }
    }
}
