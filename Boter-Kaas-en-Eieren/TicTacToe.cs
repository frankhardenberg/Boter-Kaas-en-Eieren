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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TicTacToe_KeyDown);
            Turntext.Text = "Player X his turn";
        }
        
        bool Turn = true;
        int TurnCount = 0;
        bool Winner;           

        private void Letter_Click(object sender, EventArgs e)
        {            
            Button Klik = (Button)sender;            

            if (Turn == true)
            {
                Turntext.Text = "Player O his turn!";
                Klik.Text = "X";

                if (Winner == true)
                {
                    
                }
            }           

            else
            {
                Turntext.Text = "Player X his turn!";
                Klik.Text = "O";

                if (Winner == true)
                {
                    Turntext.Text = string.Empty;
                    Klik.Text = string.Empty;
                }
            }

            Turn = !Turn;
            Klik.Enabled = false;
            TurnCount++;
            WinnaarsCheck();

            if (TurnCount == 9 && Winner == false)
            {
                MessageBox.Show("It's a draw!");                        
            }
        }        

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void newGameF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            NewGame();
        }

        private void quitF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }        
        
        public void NewGame()
        {
            TurnCount = 0;
            ClearAllFields();
            Turntext.Text = "";
            EnableAllButtons();
            Turntext.Text = "Player X his turn";
            Turn = true;
        }

        public void WinnaarsCheck()
        {
            if (A1.Text == "X" && A2.Text == "X" && A3.Text == "X")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'X' wins!");
            }

            if (B1.Text == "X" && B2.Text == "X" && B3.Text == "X")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'X' wins!");
            }

            if (C1.Text == "X" && C2.Text == "X" && C3.Text == "X")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'X' wins!");
            }

            if (A1.Text == "X" && B2.Text == "X" && C3.Text == "X" || C1.Text == "X" && B2.Text == "X" && A3.Text == "X")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'X' wins!");
            }

            if (A1.Text == "X" && B1.Text == "X" && C1.Text == "X")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'X' wins!");
            }

            if (A2.Text == "X" && B2.Text == "X" && C2.Text == "X")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'X' wins!");
            }

            if (A3.Text == "X" && B3.Text == "X" && C3.Text == "X")
            {
                Winner = true;                
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'X' wins!");
            }

            if (A1.Text == "O" && A2.Text == "O" && A3.Text == "O")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'O' wins!");
            }

            if (B1.Text == "O" && B2.Text == "O" && B3.Text == "O")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'O' wins!");
            }

            if (C1.Text == "O" && C2.Text == "O" && C3.Text == "O")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'O' wins!");
            }

            if (A1.Text == "O" && B2.Text == "O" && C3.Text == "O" || C1.Text == "O" && B2.Text == "O" && A3.Text == "O")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'O' wins!");
            }

            if (A1.Text == "O" && B1.Text == "O" && C1.Text == "O")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'O' wins!");
            }

            if (A2.Text == "O" && B2.Text == "O" && C2.Text == "O")
            {
                Winner = true;                
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'O' wins!");
            }

            if (A3.Text == "O" && B3.Text == "O" && C3.Text == "O")
            {
                Winner = true;
                DisableAllButtons();
                Turntext.Text = string.Empty;
                MessageBox.Show("Player 'O' wins!");
            }

            Winner = false;
        }

        public void EnableAllButtons()
        {
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
        }

        public void DisableAllButtons()
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;
        }

        public void ClearAllFields()
        {
            A1.Text = String.Empty;
            A2.Text = String.Empty;
            A3.Text = String.Empty;
            B1.Text = String.Empty;
            B2.Text = String.Empty;
            B3.Text = String.Empty;
            C1.Text = String.Empty;
            C2.Text = String.Empty;
            C3.Text = String.Empty;
        }
        
        private void Turntext_Click(object sender, EventArgs e)
        {
        }

        private void TicTacToe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                NewGame();
            }

            if (e.KeyCode == Keys.F4)
            {
                Application.Exit();
            }
        }
    }
}
