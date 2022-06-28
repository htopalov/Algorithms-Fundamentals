using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema
{
    public class Program
    {
        private static List<string> nonStaticPeople;
        private static string[] people;
        private static bool[] locked;

        static void Main(string[] args)
        {
            nonStaticPeople = Console.ReadLine().Split(", ").ToList();
            people = new string[nonStaticPeople.Count];
            locked = new bool[nonStaticPeople.Count];

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "generate")
                {
                    break;
                }

                var parts = line.Split(" - ");
                var name = parts[0];
                var position = int.Parse(parts[1]) - 1;

                people[position] = name;
                locked[position] = true;

                nonStaticPeople.Remove(name);
            }

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index >= nonStaticPeople.Count)
            {
                Print();
                return;
            }

            Permute(index + 1);

            for (int i = index + 1; i < nonStaticPeople.Count; i++)
            {
                Swap(index, i);
                Permute(index + 1);
                Swap(index, i);
            }
        }

        private static void Print()
        {
            var peopleIndex = 0;
            //repeat and extra if because of judge
            for (int i = 0; i < people.Length; i++)
            {
                if (i == people.Length - 1)
                {
                    if (locked[i])
                    {
                        Console.Write($"{people[i]}");
                    }
                    else
                    {
                        Console.Write($"{nonStaticPeople[peopleIndex++]}");
                    }
                }
                else
                {
                    if (locked[i])
                    {
                        Console.Write($"{people[i]} ");
                    }
                    else
                    {
                        Console.Write($"{nonStaticPeople[peopleIndex++]} ");
                    }
                }
            }

            Console.WriteLine();
        }

        private static void Swap(int first, int second)
        {
            var temp = nonStaticPeople[first];
            nonStaticPeople[first] = nonStaticPeople[second];
            nonStaticPeople[second] = temp;
        }
    }
}
