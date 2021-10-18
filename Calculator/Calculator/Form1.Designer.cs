
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.plusminus_btn = new System.Windows.Forms.Button();
            this.ce_btn = new System.Windows.Forms.Button();
            this.c_btn = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.plus_btn = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.mult_btn = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.dot_btn = new System.Windows.Forms.Button();
            this.equals_btn = new System.Windows.Forms.Button();
            this.backspace_btn = new System.Windows.Forms.Button();
            this.themeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.display.CausesValidation = false;
            this.display.Font = new System.Drawing.Font("Yu Gothic UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(10, 12);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.display.Size = new System.Drawing.Size(430, 70);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            // 
            // plusminus_btn
            // 
            this.plusminus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plusminus_btn.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusminus_btn.ForeColor = System.Drawing.Color.White;
            this.plusminus_btn.Location = new System.Drawing.Point(340, 557);
            this.plusminus_btn.Name = "plusminus_btn";
            this.plusminus_btn.Size = new System.Drawing.Size(100, 100);
            this.plusminus_btn.TabIndex = 2;
            this.plusminus_btn.Text = "±";
            this.plusminus_btn.UseVisualStyleBackColor = false;
            this.plusminus_btn.Click += new System.EventHandler(this.plusminus_btn_Click);
            // 
            // ce_btn
            // 
            this.ce_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ce_btn.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ce_btn.ForeColor = System.Drawing.Color.White;
            this.ce_btn.Location = new System.Drawing.Point(120, 125);
            this.ce_btn.Name = "ce_btn";
            this.ce_btn.Size = new System.Drawing.Size(100, 100);
            this.ce_btn.TabIndex = 3;
            this.ce_btn.Text = "CE";
            this.ce_btn.UseVisualStyleBackColor = false;
            this.ce_btn.Click += new System.EventHandler(this.ce_btn_Click);
            // 
            // c_btn
            // 
            this.c_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c_btn.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_btn.ForeColor = System.Drawing.Color.White;
            this.c_btn.Location = new System.Drawing.Point(230, 125);
            this.c_btn.Name = "c_btn";
            this.c_btn.Size = new System.Drawing.Size(100, 100);
            this.c_btn.TabIndex = 4;
            this.c_btn.Text = "C";
            this.c_btn.UseVisualStyleBackColor = false;
            this.c_btn.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn9.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(230, 231);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 100);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumValue);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn8.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(120, 231);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumValue);
            // 
            // plus_btn
            // 
            this.plus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plus_btn.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_btn.ForeColor = System.Drawing.Color.White;
            this.plus_btn.Location = new System.Drawing.Point(340, 341);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(100, 100);
            this.plus_btn.TabIndex = 6;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = false;
            this.plus_btn.Click += new System.EventHandler(this.PlusClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn7.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(10, 231);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumValue);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(230, 451);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumValue);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(120, 451);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumValue);
            // 
            // mult_btn
            // 
            this.mult_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mult_btn.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mult_btn.ForeColor = System.Drawing.Color.White;
            this.mult_btn.Location = new System.Drawing.Point(340, 125);
            this.mult_btn.Name = "mult_btn";
            this.mult_btn.Size = new System.Drawing.Size(100, 100);
            this.mult_btn.TabIndex = 14;
            this.mult_btn.Text = "*";
            this.mult_btn.UseVisualStyleBackColor = false;
            this.mult_btn.Click += new System.EventHandler(this.mulpClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(10, 451);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumValue);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn6.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(230, 341);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumValue);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn5.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(120, 341);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumValue);
            // 
            // minus_btn
            // 
            this.minus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minus_btn.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus_btn.ForeColor = System.Drawing.Color.White;
            this.minus_btn.Location = new System.Drawing.Point(340, 451);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(100, 100);
            this.minus_btn.TabIndex = 10;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = false;
            this.minus_btn.Click += new System.EventHandler(this.minusClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(10, 341);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumValue);
            // 
            // div_btn
            // 
            this.div_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.div_btn.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.div_btn.ForeColor = System.Drawing.Color.White;
            this.div_btn.Location = new System.Drawing.Point(340, 231);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(100, 100);
            this.div_btn.TabIndex = 17;
            this.div_btn.Text = "/";
            this.div_btn.UseVisualStyleBackColor = false;
            this.div_btn.Click += new System.EventHandler(this.divBtn);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn0.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(10, 557);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(100, 100);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumValue);
            // 
            // dot_btn
            // 
            this.dot_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dot_btn.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot_btn.ForeColor = System.Drawing.Color.White;
            this.dot_btn.Location = new System.Drawing.Point(120, 557);
            this.dot_btn.Name = "dot_btn";
            this.dot_btn.Size = new System.Drawing.Size(100, 100);
            this.dot_btn.TabIndex = 19;
            this.dot_btn.Text = ".";
            this.dot_btn.UseVisualStyleBackColor = false;
            this.dot_btn.Click += new System.EventHandler(this.NumValue);
            // 
            // equals_btn
            // 
            this.equals_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.equals_btn.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equals_btn.ForeColor = System.Drawing.Color.White;
            this.equals_btn.Location = new System.Drawing.Point(230, 557);
            this.equals_btn.Name = "equals_btn";
            this.equals_btn.Size = new System.Drawing.Size(100, 100);
            this.equals_btn.TabIndex = 20;
            this.equals_btn.Text = "=";
            this.equals_btn.UseVisualStyleBackColor = false;
            this.equals_btn.Click += new System.EventHandler(this.equals_btn_Click);
            // 
            // backspace_btn
            // 
            this.backspace_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backspace_btn.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspace_btn.ForeColor = System.Drawing.Color.White;
            this.backspace_btn.Location = new System.Drawing.Point(10, 125);
            this.backspace_btn.Name = "backspace_btn";
            this.backspace_btn.Size = new System.Drawing.Size(100, 100);
            this.backspace_btn.TabIndex = 21;
            this.backspace_btn.Text = "⌫";
            this.backspace_btn.UseVisualStyleBackColor = false;
            this.backspace_btn.Click += new System.EventHandler(this.backspace_btn_Click);
            // 
            // themeBtn
            // 
            this.themeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.themeBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeBtn.ForeColor = System.Drawing.Color.White;
            this.themeBtn.Location = new System.Drawing.Point(388, 88);
            this.themeBtn.Name = "themeBtn";
            this.themeBtn.Size = new System.Drawing.Size(52, 31);
            this.themeBtn.TabIndex = 22;
            this.themeBtn.Text = "☾☼";
            this.themeBtn.UseVisualStyleBackColor = false;
            this.themeBtn.Click += new System.EventHandler(this.themeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(452, 673);
            this.Controls.Add(this.themeBtn);
            this.Controls.Add(this.backspace_btn);
            this.Controls.Add(this.equals_btn);
            this.Controls.Add(this.dot_btn);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.div_btn);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.mult_btn);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.c_btn);
            this.Controls.Add(this.ce_btn);
            this.Controls.Add(this.plusminus_btn);
            this.Controls.Add(this.display);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button plusminus_btn;
        private System.Windows.Forms.Button ce_btn;
        private System.Windows.Forms.Button c_btn;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button mult_btn;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button div_btn;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button dot_btn;
        private System.Windows.Forms.Button equals_btn;
        private System.Windows.Forms.Button backspace_btn;
        private System.Windows.Forms.Button themeBtn;
    }
}

