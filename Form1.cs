using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoGarme
{
    public partial class Form1 : Form
    {
        string player = "X";
        int toggle_count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void checkForWinner()
        {
            bool bWinner = false;
            String winner = "";

            // Horizontal Check
            if ( (A1.Enabled == false) && (A1.Text == A2.Text) && (A2.Text == A3.Text) )
            {
                bWinner = true;
                winner = A1.Text;
            }
            else if ((A6.Enabled == false) && (A6.Text == A7.Text) && (A7.Text == A8.Text))
            {
                bWinner = true;
            }
            else if ((!A11.Enabled)  && (A11.Text == A12.Text) && (A12.Text == A13.Text))
            {
                bWinner = true;
                winner = A1.Text;
            }

          
            // verical check
            if ((!A1.Enabled) && (A1.Text == A6.Text) && (A6.Text == A11.Text))
            {
                bWinner = true;
                winner = A1.Text;
            }

            else if ((!A2.Enabled) && (A2.Text == A7.Text) && (A7.Text == A12.Text))
            {
                bWinner = true;
                winner = A2.Text;
            }

            else if ((!A3.Enabled) && (A3.Text == A8.Text) && (A8.Text == A13.Text))
            {
                bWinner = true;
                winner = A3.Text;
            }

            // diagonal check
            if ((!A1.Enabled) && (A1.Text == A7.Text) && (A7.Text == A13.Text))
            {
                bWinner = true;
                winner = A1.Text;
            }

            else if ((!A3.Enabled) && (A3.Text == A7.Text) && (A7.Text == A11.Text))
            {
                bWinner = true;
                winner = A3.Text;
            }

           
            if (bWinner)
            {
                disableButtons();

                MessageBox.Show(winner + " Wins!", "Yay!");
             
            }
            else
            {
                if (toggle_count == 9)
                {
                    MessageBox.Show("Draw", " Bummer!");
                   
                }
            }


        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;

                    if (b.Name != "btnReplay")
                    {
                        b.Enabled = false;
                    }
                }
            }
            catch { }

        }

        private void resetGame()
        {
            player = "X";
            toggle_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;

                    if (b.Name != "btnReplay")
                    {
                        b.Enabled = true;
                        b.Text = "";
                    }
                }
            }
            catch { }

        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (player == "X")
            {
                b.Text = "X";
                player = "O";
            }
            else
            {
                b.Text = "O";
                player = "X";

            }

            b.Enabled = false;
            toggle_count++;

            checkForWinner();


        }

        private void A2_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (player == "X")
            {
                b.Text = "X";
                player = "O";
            }
            else
            {
                b.Text = "O";
                player = "X";

            }

            b.Enabled = false;
            toggle_count++;

            checkForWinner();
        }

        private void A3_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (player == "X")
            {
                b.Text = "X";
                player = "O";
            }
            else
            {
                b.Text = "O";
                player = "X";

            }

            b.Enabled = false;
            toggle_count++;

            checkForWinner();

        }

        private void A6_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (player == "X")
            {
                b.Text = "X";
                player = "O";
            }
            else
            {
                b.Text = "O";
                player = "X";

            }

            b.Enabled = false;
            toggle_count++;
            checkForWinner();

        }

        private void A7_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (player == "X")
            {
                b.Text = "X";
                player = "O";
            }
            else
            {
                b.Text = "O";
                player = "X";

            }

            b.Enabled = false;
            toggle_count++;
            checkForWinner();

        }

        private void A8_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (player == "X")
            {
                b.Text = "X";
                player = "O";
            }
            else
            {
                b.Text = "O";
                player = "X";

            }
            b.Enabled = false;
            toggle_count++;
            checkForWinner();

        }

        private void A11_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (player == "X")
            {
                b.Text = "X";
                player = "O";
            }
            else
            {
                b.Text = "O";
                player = "X";

            }

            b.Enabled = false;
            toggle_count++;
            checkForWinner();

        }

        private void A12_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (player == "X")
            {
                b.Text = "X";
                player = "O";
            }
            else
            {
                b.Text = "O";
                player = "X";

            }
            b.Enabled = false;
            toggle_count++;
            checkForWinner();

        }

        private void A13_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (player == "X")
            {
                b.Text = "X";
                player = "O";
            }
            else
            {
                b.Text = "O";
                player = "X";

            }
            b.Enabled = false;
            toggle_count++;
            checkForWinner();

        }

        private void btnReplay_Click(object sender, EventArgs e)
        { 
            resetGame();
        }
    }
}
