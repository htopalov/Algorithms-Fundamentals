using System;

namespace Generate01Vector
{
    public class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var vector = new int[input];
            VectorGen(vector, 0);
        }

        private static void VectorGen(int[] vector, int index)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(string.Empty, vector));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                VectorGen(vector, index + 1);
            }
        }
    }
}
