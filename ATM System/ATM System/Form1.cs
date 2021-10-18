using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class Form1 : Form
    {
        int tries = 5;
        double balance, interestRate, monthlyInterestRate, loanAmount, monthlyPayment, totalPayment;
        int numberOfYears;
        string _monthlyPayment, _totalPayment;
        bool withdrawMode = false;
        bool depositMode = false;
        bool isPin = true;

        public Form1()
        {
            InitializeComponent();
            AllBorders();
            balance = 10000;
        }
        #region NumberButtons
        private void btn1_Click(object sender, EventArgs e)
        {
            NumberHelper("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NumberHelper("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumberHelper("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumberHelper("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumberHelper("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumberHelper("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NumberHelper("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumberHelper("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NumberHelper("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumberHelper("0");
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 700);
            balanceLbl.Visible = false;
            depositLbl.Visible = false;
            loanLbl.Visible = false;
            withdrawLbl.Visible = false;

            withdrawBtn.Enabled = false;
            loanBtn.Enabled = false;
            depositBtn.Enabled = false;
            balanceBtn.Enabled = false;

            bigExitBtn.Enabled = true;
            bigLoanBtn.Enabled = false;
            bigReceiptBtn.Enabled = false;
            bigResetBtn.Enabled = false;
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            lblPin.Text = "";
            starPin.Text = "";
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm exit", "ATM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            string pin1 = Convert.ToString(lblPin.Text);
            bool enabledNumbers = true;
            if (isPin)
            {
                if (pin1 == "1906")
                {
                    lblPin.Text = "";

                    balanceLbl.Visible = true;
                    depositLbl.Visible = true;
                    loanLbl.Visible = true;
                    withdrawLbl.Visible = true;

                    withdrawBtn.Enabled = true;
                    loanBtn.Enabled = true;
                    depositBtn.Enabled = true;
                    balanceBtn.Enabled = true;

                    tries = 5;
                    btn0.Enabled = false;
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                    isPin = false;
                    enabledNumbers = false;
                    starPin.Enabled = false;
                    starPin.Visible = false;
                }
                else
                {
                    starPin.Text = "Invalid Pin";
                    lblPin.Text = "Invalid Pin";
                    tries--;
                }

                if (tries > 0 && enabledNumbers == true)
                {
                    btn0.Enabled = true;
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                    btn7.Enabled = true;
                    btn8.Enabled = true;
                    btn9.Enabled = true;
                }
                if (tries == 3)
                {
                    MessageBox.Show("3 more tries left!", "ATM System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (tries == 0)
                {
                    MessageBox.Show("No more tries!\nCard blocked!", "ATM System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            
            if (withdrawMode == true)
            {
                if (balance < Convert.ToInt32(lblPin.Text))
                {
                    lblPin.Text = "Error";
                }
                else
                {
                    balance -= Convert.ToInt32(lblPin.Text);
                    withdrawMode = false;
                    MessageBox.Show("Withdrew $" + Convert.ToInt32(lblPin.Text) + "\nBalance: $" + balance,"ATM System",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (depositMode == true)
            {
                balance += Convert.ToInt32(lblPin.Text);
                depositMode = false;
                MessageBox.Show("Deposited $" + Convert.ToInt32(lblPin.Text) + "\nBalance: $" + balance, "ATM System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void loanBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 700);
            bigLoanBtn.Enabled = true;
            bigExitBtn.Enabled = true;
            bigReceiptBtn.Enabled = true;
            bigResetBtn.Enabled = true;
        }
        private void bigResetBtn_Click(object sender, EventArgs e)
        {
            loanTb.Clear();
            yearsPaybackTb.Clear();
            rateTb.Clear();
            monthlyTb.Clear();
            totalTb.Clear();
            summaryTb.Clear();
        }
        private void bigExitBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(500, 700);
        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {
            lblPin.Text = String.Format("{0:C}", balance);
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            lblPin.Text = "";

            withdrawMode = true;

            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            lblPin.Text = "";

            depositMode = true;

            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        private void bigReceiptBtn_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            summaryTb.AppendText("Loan Management Systems Calculator\n--------------------------------------------\n");
            summaryTb.AppendText("Amount of Loan " + "\t" + loanTb.Text + "\n");
            summaryTb.AppendText("Years to pay back " + "\t" + yearsPaybackTb.Text + "\n");
            summaryTb.AppendText("Interest Rate " + "\t \t" + rateTb.Text + "%\n");
            summaryTb.AppendText("Monthly Payment \t" + monthlyTb.Text + "\n");
            summaryTb.AppendText("Total Payment \t" + totalTb.Text + "\n");
            summaryTb.AppendText("--------------------------------------------\n");
            summaryTb.AppendText("-----------------Thank you---------------\n");
            summaryTb.AppendText($"---------{currentTime}-------\n");
        }

        private void bigLoanBtn_Click(object sender, EventArgs e)
        {
            interestRate = Convert.ToDouble(rateTb.Text);
            monthlyInterestRate = interestRate / 1200;
            numberOfYears = Convert.ToInt32(yearsPaybackTb.Text);
            loanAmount = Convert.ToDouble(loanTb.Text);

            monthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));

            _monthlyPayment = Convert.ToString(monthlyPayment);
            _monthlyPayment = String.Format("{0:C}", monthlyPayment);
            monthlyTb.Text = _monthlyPayment;

            totalPayment = monthlyPayment * Convert.ToInt32(yearsPaybackTb.Text) * 12;
            _totalPayment = String.Format("{0:C}", totalPayment);
            totalTb.Text = (_totalPayment);

            loanTb.Text = String.Format("{0:C}", loanAmount);
            totalTb.Text = String.Format("{0:C}", _totalPayment);
        }

        #region Helpers
        private static void ButtonBorder(Button button)
        {
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        void AllBorders()
        {
            ButtonBorder(btn0);
            ButtonBorder(loanBtn);
            ButtonBorder(depositBtn);
            ButtonBorder(withdrawBtn);
            ButtonBorder(balanceBtn);
            ButtonBorder(btn7);
            ButtonBorder(btn8);
            ButtonBorder(btn9);
            ButtonBorder(cancelBtn);
            ButtonBorder(clearBtn);
            ButtonBorder(btn6);
            ButtonBorder(btn5);
            ButtonBorder(btn4);
            ButtonBorder(enterBtn);
            ButtonBorder(btn3);
            ButtonBorder(btn2);
            ButtonBorder(btn1);
            ButtonBorder(blank3);
            ButtonBorder(blank2);
            ButtonBorder(blank1);
            ButtonBorder(bigResetBtn);
            ButtonBorder(bigExitBtn);
            ButtonBorder(bigReceiptBtn);
            ButtonBorder(bigLoanBtn);
        }

        void LimitPin()
        {
            if (lblPin.Text.Length == 3 && isPin)
            {
                btn0.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
        }

        void NumberHelper(string number)
        {
            LimitPin();
            if (lblPin.Text == "Invalid Pin")
            {
                lblPin.Text = "";
                starPin.Text = "";
            }
            lblPin.Text = lblPin.Text + number;
            starPin.Text += "*";
        }
        #endregion
    }
}
