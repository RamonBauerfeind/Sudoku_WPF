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

            List<TextBlock> textBox = new List<TextBlock>();
            for(int i = 0; i < 81; i++)
            {
                textBox.Add(tb_1); textBox.Add(tb_2); textBox.Add(tb_3); textBox.Add(tb_4); textBox.Add(tb_5); textBox.Add(tb_6); textBox.Add(tb_7); textBox.Add(tb_8); textBox.Add(tb_9);
                textBox.Add(tb_10); textBox.Add(tb_11); textBox.Add(tb_12); textBox.Add(tb_13); textBox.Add(tb_14); textBox.Add(tb_15); textBox.Add(tb_16); textBox.Add(tb_17); textBox.Add(tb_18);
                textBox.Add(tb_19); textBox.Add(tb_20); textBox.Add(tb_21); textBox.Add(tb_22); textBox.Add(tb_23); textBox.Add(tb_24); textBox.Add(tb_25); textBox.Add(tb_26); textBox.Add(tb_27);
                textBox.Add(tb_28); textBox.Add(tb_29); textBox.Add(tb_30); textBox.Add(tb_31); textBox.Add(tb_32); textBox.Add(tb_33); textBox.Add(tb_34); textBox.Add(tb_35); textBox.Add(tb_36);
            }

            int k = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    textBox[k].Text = Convert.ToString(input[i, j]);
                    k++;
                }
            }
        }
    }
}
