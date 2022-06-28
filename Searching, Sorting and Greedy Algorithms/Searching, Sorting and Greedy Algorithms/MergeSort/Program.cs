using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sorted = Sort(numbers);

            Console.WriteLine(string.Join(" ",sorted));
        }

        private static int[] Sort(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return numbers;
            }

            var left = numbers.Take(numbers.Length / 2).ToArray();
            var right = numbers.Skip(numbers.Length / 2).ToArray();

            return Merge(Sort(left), Sort(right));
        }

        private static int[] Merge(int[] left, int[] right)
        {
            var merged = new int[left.Length + right.Length];
            var mergedIndex = 0;
            var leftIndex = 0;
            var rightIndex = 0;


            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    merged[mergedIndex++] = left[leftIndex++];
                }
                else
                {
                    merged[mergedIndex++] = right[rightIndex++];
                }
            }

            for (int i = leftIndex; i < left.Length; i++)
            {
                merged[mergedIndex++] = left[i];
            }

            for (int j = rightIndex; j < right.Length; j++)
            {
                merged[mergedIndex++] = right[j];
            }

            return merged;
        }
    }
}
