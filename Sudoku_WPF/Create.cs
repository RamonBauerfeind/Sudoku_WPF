using System;
using System.Linq;

namespace Sudoku
{
    public partial class Sudoku
    {
        public static Random rnd = new Random();
        public static int[] Shuffle()
        {
            int[] ArrayToShuffle = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return ArrayToShuffle.OrderBy(x => rnd.Next()).ToArray();
        }

        public static int[,] Create(int fieldsLeft)
        {
            int zeile, spalte, n, solved, counter, selectedIndependentBlocks;
            int[,] OutputField = new int[9, 9];
            int[,] tmp = new int[9, 9];
            int[,] independentBlocks = new int[6, 3] { { 0, 30, 60 }, { 0, 33, 57 }, { 3, 27, 60 }, { 3, 33, 54 }, { 6, 30, 54 }, { 6, 27, 57 } };
            int[] ShuffeledArray;

            selectedIndependentBlocks = rnd.Next(5);
            counter = 0;
            solved = 0;

            for (int currentBlock = 0; currentBlock < 3; currentBlock++)
            {
                ShuffeledArray = Sudoku.Shuffle();
                zeile = independentBlocks[selectedIndependentBlocks, currentBlock] / 9;
                spalte = independentBlocks[selectedIndependentBlocks, currentBlock] % 9;
                n = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        OutputField[spalte - (spalte % 3) + i, zeile - (zeile % 3) + j] = ShuffeledArray[n++];
                    }
                }
            }

            Sudoku.Solve(0, 0, 0, OutputField, ref counter, ref solved, 1);
            OutputField = solution[0];

            n = 81 - fieldsLeft;

            Array.Copy(OutputField, tmp, OutputField.Length);

            do
            {
                zeile = rnd.Next(9);
                spalte = rnd.Next(9);
                solution.Clear();
                tmp[zeile, spalte] = 0;
                counter = 0;
                solved = 0;
                Sudoku.Solve(0, 0, 0, tmp, ref counter, ref solved, 0);
                if (solved == 1)
                {
                    Array.Copy(tmp, OutputField, OutputField.Length);
                    n--;
                }
                else
                {
                    Array.Copy(OutputField, tmp, OutputField.Length);
                }
            } while (n >= 0);

            return OutputField;
        }
    }
}
