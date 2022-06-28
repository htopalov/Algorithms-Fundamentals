using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedAreasInMatrix
{
    public class Area
    {
        public int Row { get; set; }

        public int Col { get; set; }

        public int Size { get; set; }
    }


    public class Program
    {
        private static char[,] matrix;
        private static int size;

        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var colElements = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            var areas = new List<Area>();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    size = 0;
                    Move(row, col);

                    if (size != 0)
                    {
                        areas.Add(new Area {Row = row, Col = col, Size = size});
                    }
                }
            }

            var sortedAreas = areas
                .OrderByDescending(a => a.Size)
                .ThenBy(a => a.Row)
                .ThenBy(a => a.Col)
                .ToList();

            Console.WriteLine($"Total areas found: {areas.Count}");
            for (int i = 0; i < sortedAreas.Count; i++)
            {
                var area = sortedAreas[i];
                Console.WriteLine($"Area #{i + 1} at ({area.Row}, {area.Col}), size: {area.Size}");
            }
        }

        private static void Move(int row, int col)
        {
            if (isOutside(row, col) || isWall(row, col) || isVisited(row,col))
            {
                return;
            }

            size += 1;
            matrix[row, col] = 'v';

            Move(row + 1, col);
            Move(row - 1, col);
            Move(row, col + 1);
            Move(row, col - 1);

        }

        private static bool isVisited(int row, int col) 
            => matrix[row, col] == 'v';

        private static bool isWall(int row, int col)
            => matrix[row, col] == '*';

        private static bool isOutside(int row, int col)
            => row >= matrix.GetLength(0) ||
               col >= matrix.GetLength(1) ||
               row < 0 || 
               col < 0;
    }
}
