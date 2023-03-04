/*Create a game of tic tac toe 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace task_3_10
{
    public partial class Form1 : Form
    {
        private bool player1 = true;
        private bool GameOver = false;
        private Button[] Buttons;
        public Form1()
        {
            InitializeComponent();
            // array for going through all buttons in game
            Buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

        }

        private bool allButtonsPressed() // if the game board is full
        {
            return Buttons.All(b => b.BackColor != SystemColors.Control);
        }

        private bool SomeboyWon() // checks if three same colors in a row
        {
            bool IsSameColor(Button[] buttons)
            {
                return buttons.All(b => b.BackColor == Color.Red) || buttons.All(b => b.BackColor == Color.Black);
            }
            if (IsSameColor(new Button[] { button1, button2, button3 })) { return true; }
            if (IsSameColor(new Button[] { button4, button5, button6 })) { return true; }
            if (IsSameColor(new Button[] { button7, button8, button9 })) { return true; }
            if (IsSameColor(new Button[] { button1, button4, button7 })) { return true; }
            if (IsSameColor(new Button[] { button2, button5, button8 })) { return true; }
            if (IsSameColor(new Button[] { button3, button6, button9 })) { return true; }
            if (IsSameColor(new Button[] { button1, button5, button9 })) { return true; }
            if (IsSameColor(new Button[] { button3, button5, button7 })) { return true; }
            return false;
        }

        private void PressButton(Button button) //functionality for button pressed in game
        {
            if (button.BackColor == SystemColors.Control && !GameOver)
            {
                if (this.player1) //different color for different player
                {
                    button.BackColor = Color.Black;
                }
                else
                {
                    button.BackColor = Color.Red;
                }
                if (SomeboyWon()) // check if current player has won
                {
                    label1.Text = player1 ? "Player 1 wins" : "Player 2 wins";
                    this.GameOver = true;
                    return;
                }
                if (allButtonsPressed()) //check if board is full
                {
                    label1.Text = "Game Over, nobody wins";
                    return;
                }
                this.player1 = !this.player1; //change player turn
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PressButton(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PressButton(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PressButton(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PressButton(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PressButton(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PressButton(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PressButton(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PressButton(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PressButton(button9);
        }
    }
}
