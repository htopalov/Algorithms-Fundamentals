using System;

namespace RecursiveFactorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(CalcFactorial(input));
        }

        private static int CalcFactorial(int input)
        {
            if (input == 0)
            {
                return 1;
            }

            return input * CalcFactorial(input - 1);
        }
    }
}
