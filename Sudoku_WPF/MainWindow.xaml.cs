﻿using System;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<TextBox> TextBox = new List<TextBox>();
            for (int i = 0; i < 81; i++)
            {
                TextBox.Add(tb_1); TextBox.Add(tb_2); TextBox.Add(tb_3); TextBox.Add(tb_4); TextBox.Add(tb_5); TextBox.Add(tb_6); TextBox.Add(tb_7); TextBox.Add(tb_8); TextBox.Add(tb_9);
                TextBox.Add(tb_10); TextBox.Add(tb_11); TextBox.Add(tb_12); TextBox.Add(tb_13); TextBox.Add(tb_14); TextBox.Add(tb_15); TextBox.Add(tb_16); TextBox.Add(tb_17); TextBox.Add(tb_18);
                TextBox.Add(tb_19); TextBox.Add(tb_20); TextBox.Add(tb_21); TextBox.Add(tb_22); TextBox.Add(tb_23); TextBox.Add(tb_24); TextBox.Add(tb_25); TextBox.Add(tb_26); TextBox.Add(tb_27);
                TextBox.Add(tb_28); TextBox.Add(tb_29); TextBox.Add(tb_30); TextBox.Add(tb_31); TextBox.Add(tb_32); TextBox.Add(tb_33); TextBox.Add(tb_34); TextBox.Add(tb_35); TextBox.Add(tb_36);
                TextBox.Add(tb_37); TextBox.Add(tb_38); TextBox.Add(tb_39); TextBox.Add(tb_40); TextBox.Add(tb_41); TextBox.Add(tb_42); TextBox.Add(tb_43); TextBox.Add(tb_44); TextBox.Add(tb_45);
                TextBox.Add(tb_46); TextBox.Add(tb_47); TextBox.Add(tb_48); TextBox.Add(tb_49); TextBox.Add(tb_50); TextBox.Add(tb_51); TextBox.Add(tb_52); TextBox.Add(tb_53); TextBox.Add(tb_54);
                TextBox.Add(tb_55); TextBox.Add(tb_56); TextBox.Add(tb_57); TextBox.Add(tb_58); TextBox.Add(tb_59); TextBox.Add(tb_60); TextBox.Add(tb_61); TextBox.Add(tb_62); TextBox.Add(tb_63);
                TextBox.Add(tb_64); TextBox.Add(tb_65); TextBox.Add(tb_66); TextBox.Add(tb_67); TextBox.Add(tb_68); TextBox.Add(tb_69); TextBox.Add(tb_70); TextBox.Add(tb_71); TextBox.Add(tb_72);
                TextBox.Add(tb_73); TextBox.Add(tb_74); TextBox.Add(tb_75); TextBox.Add(tb_76); TextBox.Add(tb_77); TextBox.Add(tb_78); TextBox.Add(tb_79); TextBox.Add(tb_80); TextBox.Add(tb_81);
            }

            int k = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox[k].Text = Convert.ToString("");
                    k++;
                }
            }
        }

        public void NewGame()
        {
            int[,] input;
            input = Sudoku.Create(50); // Schwierigkeitsgrad hier festlegen
            int counter = 0;
            int solved = 0;
            Sudoku.Solve(0, 0, 0, input, ref counter, ref solved, 0);

            List<TextBox> TextBox = new List<TextBox>();
            for (int i = 0; i < 81; i++)
            {
                TextBox.Add(tb_1); TextBox.Add(tb_2); TextBox.Add(tb_3); TextBox.Add(tb_4); TextBox.Add(tb_5); TextBox.Add(tb_6); TextBox.Add(tb_7); TextBox.Add(tb_8); TextBox.Add(tb_9);
                TextBox.Add(tb_10); TextBox.Add(tb_11); TextBox.Add(tb_12); TextBox.Add(tb_13); TextBox.Add(tb_14); TextBox.Add(tb_15); TextBox.Add(tb_16); TextBox.Add(tb_17); TextBox.Add(tb_18);
                TextBox.Add(tb_19); TextBox.Add(tb_20); TextBox.Add(tb_21); TextBox.Add(tb_22); TextBox.Add(tb_23); TextBox.Add(tb_24); TextBox.Add(tb_25); TextBox.Add(tb_26); TextBox.Add(tb_27);
                TextBox.Add(tb_28); TextBox.Add(tb_29); TextBox.Add(tb_30); TextBox.Add(tb_31); TextBox.Add(tb_32); TextBox.Add(tb_33); TextBox.Add(tb_34); TextBox.Add(tb_35); TextBox.Add(tb_36);
                TextBox.Add(tb_37); TextBox.Add(tb_38); TextBox.Add(tb_39); TextBox.Add(tb_40); TextBox.Add(tb_41); TextBox.Add(tb_42); TextBox.Add(tb_43); TextBox.Add(tb_44); TextBox.Add(tb_45);
                TextBox.Add(tb_46); TextBox.Add(tb_47); TextBox.Add(tb_48); TextBox.Add(tb_49); TextBox.Add(tb_50); TextBox.Add(tb_51); TextBox.Add(tb_52); TextBox.Add(tb_53); TextBox.Add(tb_54);
                TextBox.Add(tb_55); TextBox.Add(tb_56); TextBox.Add(tb_57); TextBox.Add(tb_58); TextBox.Add(tb_59); TextBox.Add(tb_60); TextBox.Add(tb_61); TextBox.Add(tb_62); TextBox.Add(tb_63);
                TextBox.Add(tb_64); TextBox.Add(tb_65); TextBox.Add(tb_66); TextBox.Add(tb_67); TextBox.Add(tb_68); TextBox.Add(tb_69); TextBox.Add(tb_70); TextBox.Add(tb_71); TextBox.Add(tb_72);
                TextBox.Add(tb_73); TextBox.Add(tb_74); TextBox.Add(tb_75); TextBox.Add(tb_76); TextBox.Add(tb_77); TextBox.Add(tb_78); TextBox.Add(tb_79); TextBox.Add(tb_80); TextBox.Add(tb_81);
            }

            int k = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (input[i, j] == 0)
                    {
                        TextBox[k].Text = Convert.ToString("");
                        k++;
                    }
                    else
                    {
                        TextBox[k].Text = Convert.ToString(input[i, j]);
                        k++;
                    }
                }
            }
        }


        public void bt_newGame_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }
    }
}
