using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sudoku
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DateTime Start = DateTime.Now;
            int[,] input;

            input = Sudoku.Create(81); // Schwierigkeitsgrad hier festlegen
            int counter = 0;
            int solved = 0;
            Sudoku.Solve(0, 0, 0, input, ref counter, ref solved, 0);

            List<TextBlock> TextBlock = new List<TextBlock>();
            for(int i = 0; i < 81; i++)
            {
                TextBlock.Add(tb_1); TextBlock.Add(tb_2); TextBlock.Add(tb_3); TextBlock.Add(tb_4); TextBlock.Add(tb_5); TextBlock.Add(tb_6); TextBlock.Add(tb_7); TextBlock.Add(tb_8); TextBlock.Add(tb_9);
                TextBlock.Add(tb_10); TextBlock.Add(tb_11); TextBlock.Add(tb_12); TextBlock.Add(tb_13); TextBlock.Add(tb_14); TextBlock.Add(tb_15); TextBlock.Add(tb_16); TextBlock.Add(tb_17); TextBlock.Add(tb_18);
                TextBlock.Add(tb_19); TextBlock.Add(tb_20); TextBlock.Add(tb_21); TextBlock.Add(tb_22); TextBlock.Add(tb_23); TextBlock.Add(tb_24); TextBlock.Add(tb_25); TextBlock.Add(tb_26); TextBlock.Add(tb_27);
                TextBlock.Add(tb_28); TextBlock.Add(tb_29); TextBlock.Add(tb_30); TextBlock.Add(tb_31); TextBlock.Add(tb_32); TextBlock.Add(tb_33); TextBlock.Add(tb_34); TextBlock.Add(tb_35); TextBlock.Add(tb_36);
            }

            int k = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBlock[k].Text = Convert.ToString(input[i, j]);
                    k++;
                }
            }
        }
    }
}
