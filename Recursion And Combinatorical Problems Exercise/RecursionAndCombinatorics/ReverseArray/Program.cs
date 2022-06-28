using System;

namespace ReverseArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            ReverseArr(input, 0, input.Length - 1);
        }

        private static void ReverseArr(string[] arr, int start, int end)
        {
            if (start >= end)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            var temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            ReverseArr(arr, start + 1, end - 1);
        }
    }
}
