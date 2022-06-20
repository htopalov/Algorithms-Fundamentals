using System;

namespace NChooseKCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            Console.WriteLine(BinomGen(n,k));
        }

        private static int BinomGen(int row, int col)
        {
            if (row <= 1 || col == 0 || col == row)
            {
                return 1;
            }

            return BinomGen(row - 1, col) + BinomGen(row - 1, col - 1);
        }
    }
}
