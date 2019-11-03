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

            input = Sudoku.Create(0); // Schwierigkeitsgrad hier festlegen
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
                TextBlock.Add(tb_37); TextBlock.Add(tb_38); TextBlock.Add(tb_39); TextBlock.Add(tb_40); TextBlock.Add(tb_41); TextBlock.Add(tb_42); TextBlock.Add(tb_43); TextBlock.Add(tb_44); TextBlock.Add(tb_45);
                TextBlock.Add(tb_46); TextBlock.Add(tb_47); TextBlock.Add(tb_48); TextBlock.Add(tb_49); TextBlock.Add(tb_50); TextBlock.Add(tb_51); TextBlock.Add(tb_52); TextBlock.Add(tb_53); TextBlock.Add(tb_54);
                TextBlock.Add(tb_55); TextBlock.Add(tb_56); TextBlock.Add(tb_57); TextBlock.Add(tb_58); TextBlock.Add(tb_59); TextBlock.Add(tb_60); TextBlock.Add(tb_61); TextBlock.Add(tb_62); TextBlock.Add(tb_63);
                TextBlock.Add(tb_64); TextBlock.Add(tb_65); TextBlock.Add(tb_66); TextBlock.Add(tb_67); TextBlock.Add(tb_68); TextBlock.Add(tb_69); TextBlock.Add(tb_70); TextBlock.Add(tb_71); TextBlock.Add(tb_72);
                TextBlock.Add(tb_73); TextBlock.Add(tb_74); TextBlock.Add(tb_75); TextBlock.Add(tb_76); TextBlock.Add(tb_77); TextBlock.Add(tb_78); TextBlock.Add(tb_79); TextBlock.Add(tb_80); TextBlock.Add(tb_81);

            }

            int k = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(input[i, j] == 0)
                    {
                        TextBlock[k].Text = Convert.ToString("");
                        k++;
                    }
                    else
                    {
                        TextBlock[k].Text = Convert.ToString(input[i, j]);
                        k++;
                    }
                }
            }
        }

        private void bt_newGame_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
