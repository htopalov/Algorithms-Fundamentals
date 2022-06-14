using System;
using System.Linq;

namespace RecursiveArraySum
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(CalculateSum(nums, 0));
        }

        private static int CalculateSum(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }

            return arr[index] + CalculateSum(arr, index + 1);
        }
    }
}
