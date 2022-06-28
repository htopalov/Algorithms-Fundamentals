﻿using System;
using System.Linq;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Sort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Sort(int[] numbers)
        {
            var isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                for (int j = 1; j < numbers.Length; j++)
                {
                    var i = j - 1;
                    if (numbers[i]> numbers[j])
                    {
                        Swap(numbers,i,j);
                        isSorted = false;
                    }
                }
            }
        }

        private static void Swap(int[] numbers, int first, int second)
        {
            var temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }
}
