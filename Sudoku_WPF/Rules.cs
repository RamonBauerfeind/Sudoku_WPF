namespace Sudoku
{
    static partial class Sudoku
    {
        // prüft Werte in Zeile auf unique
        public static bool chkZeile(int zeile, int wert, int[,] arr)
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
        public static bool chkSpalte(int spalte, int wert, int[,] arr)
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
        public static bool chkBlock(int zeile, int spalte, int wert, int[,] arr)
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
        public static bool chkMove(int zeile, int spalte, int wert, int[,] arr)
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
    }
}

