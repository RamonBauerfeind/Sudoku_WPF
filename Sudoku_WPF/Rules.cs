namespace Sudoku
{
    static partial class Sudoku
    {
        // prüft Werte in Zeile auf unique
        static bool chkZeile(int zeile, int wert, int[,] arr)
        {
            for (int i = 0; i < 9; i++)
            {
                if (arr[i, zeile] == wert)
                {
                    return false;
                }
            }
            return true;
        }

        // prüft Werte in Spalte auf unique
        static bool chkSpalte(int spalte, int wert, int[,] arr)
        {
            for (int i = 0; i < 9; i++)
            {
                if (arr[spalte, i] == wert)
                {
                    return false;
                }
            }
            return true;
        }

        // prüft Werte in Block auf unique
        static bool chkBlock(int zeile, int spalte, int wert, int[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == spalte)
                {
                    continue;
                }
                for (int j = 0; j < 3; j++)
                {
                    if (j == zeile)
                    {
                        continue;
                    }
                    if (arr[spalte - (spalte % 3) + i, zeile - (zeile % 3) + j] == wert)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Zusammenfassung von chkZeile, chk Spalte, chkBlock
        static bool chkMove(int zeile, int spalte, int wert, int[,] arr)
        {
            if (!chkZeile(zeile, wert, arr))
            {
                return false;
            }

            if (!chkSpalte(spalte, wert, arr))
            {
                return false;
            }

            if (!chkBlock(zeile, spalte, wert, arr))
            {
                return false;
            }
            return true;
        }

        //Find mistake here!!!!!
        public static bool chkResult(int zeile, int spalte, int wert, int[,] arr)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (arr[y, x] == 0)
                    {
                        return false;
                    }
                    // prüfen ob Zahl an jeweiliger Stelle möglich ist
                    if (chkMove(zeile, spalte, wert, arr))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

