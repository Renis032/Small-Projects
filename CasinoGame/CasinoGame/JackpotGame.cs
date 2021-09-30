using System;
using System.Drawing;
using System.Windows.Forms;

namespace CasinoGame
{
    public partial class Jackpot : Form
    {
        public Jackpot()
        {
            MessageBox.Show("You start with a $100. Good luck!");
            MessageBox.Show("3x Bronze - x0.75\n2x Bronze - x0.25\n\n3x Silver - x1.5\n2x Silver - x1.25\n\n3x Gold - 2x\n2x Gold - x1.75\n\n3x Diamond - 3x");
            InitializeComponent();
            bidAmount_lbl.Text = "New Bid";
            balance_lbl.Text = "Balance: $" + balance;
        }
        Font defFont = new Font("Microsoft YaHei", 16, FontStyle.Bold);
        Random rnd = new Random();
        int a;
        int b;
        int c;
        int moves;
        int wins;
        int loss;
        float balance = 100;
        float balanceFloat;
        private void play_btn_Click(object sender, EventArgs e)
        {
            float input;
            try
            {
                input = Single.Parse(textBox1.Text);
                if (input > balance || textBox1.Text == "")
                {
                    MessageBox.Show("Please enter a valid number");
                }
                else if (float.Parse(textBox1.Text) < 1)
                {
                    MessageBox.Show("The input must be greater than $0.99");
                }
                else
                {
                    balance_lbl.Text = "Balance: $" + (balance - input);
                    timer1.Enabled = true;
                    textBox1.Enabled = false;
                    textBox1.BackColor = Color.Black;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The input must be a number!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bid_btn.ForeColor = Color.Gray;
            bid_btn.Enabled = false;
            casino_lbl.Text = "Spinning...";
            casino_lbl.Font = new Font("Microsoft YaHei", 14, FontStyle.Bold);
            moves++;
            if (moves < 30)
            {
                a = rnd.Next(0, 16);
                b = rnd.Next(0, 16);
                c = rnd.Next(0, 16);

                #region StarsValues
                switch (a)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        pictureBox1.Image = Properties.Resources.bronzeReady;
                        a = 1;
                        break;
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                        pictureBox1.Image = Properties.Resources.silverStar;
                        a = 2;
                        break;
                    case 13:
                    case 14:
                        pictureBox1.Image = Properties.Resources.goldReadylt;
                        a = 3;
                        break;
                    case 15:
                        pictureBox1.Image = Properties.Resources.diamondReady;
                        a = 4;
                        break;
                }
                switch (b)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        pictureBox2.Image = Properties.Resources.bronzeReady;
                        b = 1;
                        break;
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                        pictureBox2.Image = Properties.Resources.silverStar;
                        b = 2;
                        break;
                    case 13:
                    case 14:
                        pictureBox2.Image = Properties.Resources.goldReadylt;
                        b = 3;
                        break;
                    case 15:
                        pictureBox2.Image = Properties.Resources.diamondReady;
                        b = 4;
                        break;
                }
                switch (c)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        pictureBox3.Image = Properties.Resources.bronzeReady;
                        c = 1;
                        break;
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                        pictureBox3.Image = Properties.Resources.silverStar;
                        c = 2;
                        break;
                    case 13:
                    case 14:
                        pictureBox3.Image = Properties.Resources.goldReadylt;
                        c = 3;
                        break;
                    case 15:
                        pictureBox3.Image = Properties.Resources.diamondReady;
                        c = 4;
                        break;
                }
                #endregion
            }
            else
            {
                bid_btn.ForeColor = Color.White;
                bid_btn.Enabled = true;
                timer1.Enabled = false;
                moves = 0;
                GameResult();
            }
        }

       

        void GameResult()
        {
            //bronze
            if (a == 1 && b == 1 || a == 1 && c == 1 || b == 1 && c == 1)
            {
                if (a == 1 && b == 1 && c == 1)
                {
                    WonGame(0.75f);
                }
                else
                {
                    WonGame(0.25f);
                }
            }
            //silver
            else if (a == 2 && b == 2 || a == 2 && c == 2 || b == 2 && c == 2)
            {
                if (a == 2 && b == 2 && c == 2)
                {
                    WonGame(1.5f);
                }
                else
                {
                    WonGame(1.25f);
                }
            }
            //gold
            else if (a == 3 && b == 3 || a == 3 && c == 3 || b == 3 && c == 3)
            {
                if (a == 3 && b == 3 && c == 3)
                {
                    WonGame(2f);
                }
                else
                {
                    WonGame(1.75f);
                }
            }
            //diamond
            else if (a == 4 && b == 4 && c == 4)
            {
                WonGame(3f);
            }
            else
            {
                casino_lbl.Font = defFont;
                casino_lbl.Text = "Try Again";
                loss++;
                loses_lbl.Text = "Losses: " + loss;
                balance -= float.Parse(textBox1.Text);
                balanceFloat = (float)Math.Round(balance, 2);
                balance_lbl.Text = "Balance: $" + balance;
                if (balance <= 0)
                {
                    play_btn.Enabled = false;
                    play_btn.Visible = false;
                }
            }
        }
        private void bid_btn_Click(object sender, EventArgs e)
        {
            if (balance < 1)
            {
                MessageBox.Show("Game Over!");
                MessageBox.Show("You start with a $100. Good luck!");
                loss = 0;
                wins = 0;
                wins_lbl.Text = "Wins: " + wins;
                loses_lbl.Text = "Losses: " + loss;
                pictureBox1.Image = Properties.Resources.ValidateCopy;
                pictureBox2.Image = Properties.Resources.ValidateCopy;
                pictureBox3.Image = Properties.Resources.ValidateCopy;
                casino_lbl.Font = defFont;
                casino_lbl.Text = "Casino";
                balance = 100;
                balance_lbl.Text = "Balance: $" + balance;
            }
            bid_btn.Text = "New Bid";
            textBox1.Enabled = true;
            textBox1.Visible = true;
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox1.Focus();
            play_btn.Enabled = true;
            play_btn.Text = "Play";
            play_btn.Visible = true;
        }

        void WonGame(float multiplier)
        {
            wins++;
            balance -= float.Parse(textBox1.Text);
            balance += float.Parse(textBox1.Text) * multiplier;
            balanceFloat = (float)Math.Round(balance, 2);
            balance = balanceFloat;

            wins_lbl.Text = "Wins: " + wins;
            balance_lbl.Text = "Balance: $" + balance;
            play_btn.Text = "Continue Playing...";
            casino_lbl.Font = defFont;
            casino_lbl.Text = "You Won!";
        }
    }
}