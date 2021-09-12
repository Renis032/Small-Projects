using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class CoinFlipGame : Form
    {
        int heads = 0;
        int tails = 0;

        public CoinFlipGame()
        {
            InitializeComponent();
            HeadsCounter.Text = "Heads: ";
            TailsCounter.Text = "Tails: ";
            CoinTail.Visible = false;
            CoinHead.Visible = false;
        }

        private void CoinFlipGame_Load(object sender, EventArgs e)
        {

        }

        private void CoinFlipButton_Click(object sender, EventArgs e)
        {
            FirstPic.Visible = false;
            Random rnd = new Random();
            int random = rnd.Next(1, 3);

            if (random == 1)
            {
                CoinTail.Visible = true;
                CoinHead.Visible = false;
                tails++;
                TailsCounter.Text = "Tails: " + tails;
            }
            else
            {
                CoinTail.Visible = false;
                CoinHead.Visible = true;
                heads++;
                HeadsCounter.Text = "Heads: " + heads;
            }
        }

        private void HeadsCounter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
