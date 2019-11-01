using System;
using System.Collections.Generic;

namespace Sudoku
{
    static partial class Sudoku
    {
        // Erstellen eines neuen Spielfeldes, um damit zu arbeiten
        public static List<int[,]> solution = new List<int[,]>();
        public static int[,] Solve(int wert, int px, int py, int[,] field, ref int counter, ref int solved, int mode)
        {
            if (mode == 1 && solved >= 1)
            {
                return null;
            }
            if (mode == 2 && solved >= 2)
            {
                return null;
            }

            int[,] workerfield = new int[9, 9];
            bool chkSkip = false;

            Array.Copy(field, workerfield, field.Length); // kopiert Array myArray in workerfield

            // Eintragen eines Wertes in freies Feld
            if (field[px, py] != 0)
            {
                workerfield[px, py] = field[px, py];
            }
            else
            {
                workerfield[px, py] = wert;
            }

            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    // wenn Feld leer ist....
                    if (workerfield[x, y] == 0)
                    {
                        // Erstellen einer Zahl
                        for (int val = 1; val <= 9; val++)
                        {
                            // prüfen ob Zahl an jeweiliger Stelle möglich ist
                            if (chkSkip || chkMove(y, x, val, workerfield))
                            {
                                // wenn true => rekursiver Funktionsaufruf, aktuelles Spielfeld wird übergeben
                                chkSkip = false;
                                Solve(val, x, y, workerfield, ref counter, ref solved, mode);
                            }
                        }
                        // wenn kein Wert mehr gefunden wird....
                        counter++;
                        return null;
                    }
                }
            }
            solution.Add(workerfield);
            solved++;
            return workerfield;
        }
    }
}
