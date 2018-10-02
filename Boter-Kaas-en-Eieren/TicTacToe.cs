using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boter_Kaas_en_Eieren
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        bool Turn = true;
        int TurnCount = 0;
        bool Winner = false;

        private void Letter_Click(object sender, EventArgs e)
        {
            Button Klik = (Button)sender;
            if (Turn)
            {
                Klik.Text = "X";
            }

            else
            {
                Klik.Text = "O";
            }

            Turn = !Turn;
            Klik.Enabled = false;            
            TurnCount++;

            if (TurnCount == 9 && Winner == false)
            {
                MessageBox.Show("It's a draw!");
            }            
        }

        public void WinnaarsCheck()
        {
            if (A1.Text == "X" && A2.Text == "X" && A3.Text == "X")
            {
                MessageBox.Show("Player 'X' wins!");
            }

            if (B1.Text == "X" && B2.Text == "X" && B3.Text == "X")
            {
                MessageBox.Show("Player 'X' wins!");
            }

            if (C1.Text == "X" && C2.Text == "X" && C3.Text == "X")
            {
                MessageBox.Show("Player 'X' wins!");
            }

            if (A1.Text == "X" && B2.Text == "X" && C3.Text == "X" || C1.Text == "X" && B2.Text == "X" && A3.Text == "X") 
            {
                MessageBox.Show("Player 'X' wins!");

            }

            if (A1.Text == "X" && B1.Text == "X" && C1.Text == "X")
            {
                MessageBox.Show("Player 'X' wins!");
            }

            if (A2.Text == "X" && B2.Text == "X" && C2.Text == "X")
            {
                MessageBox.Show("Player 'X' wins!");
            }

            if (A3.Text == "X" && B3.Text == "X" && C3.Text == "X")
            {
                MessageBox.Show("Player 'X' wins!");
            }
            
            if (A1.Text == "O" && A2.Text == "O" && A3.Text == "O")
            {
                MessageBox.Show("Player 'O' wins!");
            }

            if (B1.Text == "O" && B2.Text == "O" && B3.Text == "O")
            {
                MessageBox.Show("Player 'O' wins!");
            }

            if (C1.Text == "O" && C2.Text == "O" && C3.Text == "O")
            {
                MessageBox.Show("Player 'O' wins!");
            }

            if (A1.Text == "O" && B2.Text == "O" && C3.Text == "O" || C1.Text == "O" && B2.Text == "O" && A3.Text == "O")
            {
                MessageBox.Show("Player 'O' wins!");
            }

            if (A1.Text == "O" && B1.Text == "O" && C1.Text == "O")
            {
                MessageBox.Show("Player 'O' wins!");
            }

            if (A2.Text == "O" && B2.Text == "O" && C2.Text == "O")
            {
                MessageBox.Show("Player 'O' wins!");
            }

            if (A3.Text == "O" && B3.Text == "O" && C3.Text == "O")
            {
                MessageBox.Show("Player 'O' wins!");
            }

            Winner = true;
        }             
    }
}
// Toevoegen: Menu strip, met New Game (F2 Knop) & Quit (ESC of F4 Knop) & label wie zijn beurt het is.
