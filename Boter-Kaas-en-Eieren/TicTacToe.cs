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

        public void RowsAndColums()
        {
            
        }

        public void WinnerOrNot()
        {

        }
    }
}
