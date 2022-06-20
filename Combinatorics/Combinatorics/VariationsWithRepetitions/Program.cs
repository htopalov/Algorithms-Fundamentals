using System;

namespace VariationsWithoutRepetitions
{
    public class Program
    {
        private static string[] elements;
        private static string[] variations;
        private static int k;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());
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
                variations[index] = elements[i];
                VariationsGen(index + 1);
            }
        }
    }
}