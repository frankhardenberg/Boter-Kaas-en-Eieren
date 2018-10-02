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

        string A;
        string B;
        string C;
        string Row1;
        string Row2;
        string Row3;

        bool Turn = true;
        int TurnCount = 0;
        List<string> Alghoritmes = new List<string>();

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
        }

        public void Listjes()
        {
            Alghoritmes.Add(B1.Text);
            Alghoritmes.Add(B2.Text);
            Alghoritmes.Add(B3.Text);
        }

        public void WinnerOrNot()
        {
            
        }
    }
}
