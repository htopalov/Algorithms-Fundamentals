using System;
using System.Collections.Generic;

namespace WordCruncher
{
    public class Program
    {
        private static string target;
        private static Dictionary<int, List<string>> wordByIndex;
        private static Dictionary<string, int> wordsCount;
        private static LinkedList<string> usedWords;

        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(", ");
            target = Console.ReadLine();

            wordByIndex = new Dictionary<int, List<string>>();
            wordsCount = new Dictionary<string, int>();
            usedWords = new LinkedList<string>();

            foreach (var word in words)
            {
                var index = target.IndexOf(word);

                if (index == - 1)
                {
                    continue;
                }

                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word] += 1;
                    continue;
                }

                wordsCount[word] = 1;

                while (index != -1)
                {
                    if (!wordByIndex.ContainsKey(index))
                    {
                        wordByIndex[index] = new List<string>();
                    }

                    wordByIndex[index].Add(word);

                    index = target.IndexOf(word, index + 1);
                }
            }

            GenerateSolutions(0);
        }

        private static void GenerateSolutions(int index)
        {
            if (index == target.Length)
            {
                Console.WriteLine(string.Join(" ", usedWords));
                return;
            }

            if (!wordByIndex.ContainsKey(index))
            {
                return;
            }

            foreach (var word in wordByIndex[index])
            {
                if (wordsCount[word] == 0)
                {
                    continue;
                }

                wordsCount[word] -= 1;
                usedWords.AddLast(word);

                GenerateSolutions(index + word.Length);

                wordsCount[word] += 1;
                usedWords.RemoveLast();
            }
        }
    }
}
