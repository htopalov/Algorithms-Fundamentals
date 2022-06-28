using System;
using System.Linq;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var key = int.Parse(Console.ReadLine());

            Console.WriteLine(Search(arr, key));
        }

        private static int Search(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                var mid = (left + right) / 2;
                var element = arr[mid];
                if (key == element)
                {
                    return mid;
                }

                if (key > element)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
