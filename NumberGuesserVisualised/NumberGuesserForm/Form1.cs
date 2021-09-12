using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuesserForm
{
    public partial class Tries : Form
    {
        public static Random rnd = new Random();
        int tries = 5;
        string guess;
        static int numToGuess = rnd.Next(0, 21);

        public Tries()
        {
            InitializeComponent();
            this.AcceptButton = GuessButton;
            label1.Text = "Tries left: " + tries;
        }

        private void checkWinner(String userGuess)
        {
            try
            {
                NumberLabel.Text = "Guess the number!";
                int guessedNum = Int32.Parse(guess);
                SmallerGreater.Visible = true;

                if (guessedNum == numToGuess)
                {
                    SmallerGreater.Text = "You Win!";
                    GuessButton.Visible = false;
                    RestartButton.Visible = true;
                    GuessButton.Enabled = false;
                }
                else if (guessedNum > numToGuess)
                {
                    SmallerGreater.Text = "Lower!";
                    tries--;
                    label1.Text = "Tries left: " + tries;
                }
                else if (guessedNum < numToGuess)
                {
                    SmallerGreater.Text = "Greater!";
                    tries--;
                    label1.Text = "Tries left: " + tries;
                }
              
                if (tries == 0)
                {
                    SmallerGreater.Text = "You lose :( The number was " + numToGuess;
                    GuessButton.Visible = false;
                    RestartButton.Visible = true;
                    GuessButton.Enabled = false;
                }
            }
            catch (Exception e)
            {
                NumberLabel.Text = "Error";
                textBox1.Text = "";
                SmallerGreater.Text = "";
            }
        }

        private void GuessButton_Click_1(object sender, EventArgs e)
        {
            guess = textBox1.Text;
            checkWinner(guess);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            GuessButton.Enabled = true;
            RestartButton.Visible = false;
            GuessButton.Visible = true;
            textBox1.Text = "";
            tries = 6;
            numToGuess = rnd.Next(0, 21);
            SmallerGreater.Text = "";
            SmallerGreater.Visible = false;
            checkWinner(guess);
        }
    }
}
