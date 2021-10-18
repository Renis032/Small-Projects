using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        string operation = "";
        double firstNum;
        double secondNum;

        Color darkBoxBG = new Color();
        Color darkBack = new Color();

        Color lightBack = new Color();
        Color lightBoxBG = new Color();

        bool darkMode = true;

        public Form1()
        {
            InitializeComponent();
            darkBoxBG = Color.FromArgb(64, 64, 64);
            darkBack = Color.Black;
            lightBoxBG = Color.DarkCyan;
            lightBack = Color.Silver;
        }

        private void NumValue(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (display.Text == "0")
            {
                display.Text = "";
            }

            if (btn.Text == ".")
            {
                if (!display.Text.Contains("."))
                {
                    display.Text = display.Text + btn.Text;
                }
            }
            else
            {
                display.Text += btn.Text;
            }
        }

        private void c_btn_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void ce_btn_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void divBtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNum = double.Parse(display.Text);
            operation = btn.Text;
            display.Text = "";
        }

        private void PlusClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNum = double.Parse(display.Text);
            operation = btn.Text;
            display.Text = "";
        }

        private void mulpClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNum = double.Parse(display.Text);
            operation = btn.Text;
            display.Text = "";
        }

        private void minusClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNum = double.Parse(display.Text);
            operation = btn.Text;
            display.Text = "";
        }

        private void backspace_btn_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }
            if (display.Text == "")
            {
                display.Text = "0";
            }
        }

        private void plusminus_btn_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(display.Text) > 0)
            {
                var temp = Int32.Parse(display.Text) * (-1);
                display.Text = Convert.ToString(temp);
            }
            else
            {
                display.Text = display.Text.Remove(0, 1);
            }
        }

        private void equals_btn_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(display.Text);

            switch (operation)
            {
                case "+":
                    display.Text = Convert.ToString(firstNum + secondNum);
                    break;
                case "-":
                    display.Text = Convert.ToString(firstNum - secondNum);
                    break;
                case "/":
                    display.Text = Convert.ToString(firstNum / secondNum);
                    break;
                case "*":
                    display.Text = Convert.ToString(firstNum * secondNum);
                    break;
                default:
                    break;
            }
        }

        private void themeBtn_Click(object sender, EventArgs e)
        {
            //turn to light mode
            if (darkMode)
            {
                themeMode(lightBoxBG, Color.Black);
                display.BackColor = Color.White;
                BackColor = Color.Silver;
                darkMode = false;
            }
            //turn to dark mode
            else if(!darkMode)
            {
                themeMode(darkBoxBG, Color.White);
                display.BackColor = darkBoxBG;
                BackColor = Color.Black;
                darkMode = true;
            }
        }

        void themeMode(Color backBoxColor, Color fontColor)
        {
            btn0.BackColor = backBoxColor;
            btn1.BackColor = backBoxColor;
            btn2.BackColor = backBoxColor;
            btn3.BackColor = backBoxColor;
            btn4.BackColor = backBoxColor;
            btn5.BackColor = backBoxColor;
            btn6.BackColor = backBoxColor;
            btn7.BackColor = backBoxColor;
            btn8.BackColor = backBoxColor;
            btn9.BackColor = backBoxColor;
            themeBtn.BackColor = backBoxColor;
            backspace_btn.BackColor = backBoxColor;
            ce_btn.BackColor = backBoxColor;
            c_btn.BackColor = backBoxColor;
            mult_btn.BackColor = backBoxColor;
            div_btn.BackColor = backBoxColor;
            plusminus_btn.BackColor = backBoxColor;
            plus_btn.BackColor = backBoxColor;
            minus_btn.BackColor = backBoxColor;
            dot_btn.BackColor = backBoxColor;
            equals_btn.BackColor = backBoxColor;
            display.ForeColor = fontColor;
        }
    }
}
