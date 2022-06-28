using System;

namespace NestedLoopsToRecursion
{
    public class Program
    {
        private static int[] elements;

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            elements = new int[input];
            Generator(0);
        }

        private static void Generator(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            for (int i = 1; i <= elements.Length; i++)
            {
                elements[index] = i;
                Generator(index+1);
            }
        }
    }
}
