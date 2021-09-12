
namespace CoinFlip
{
    partial class CoinFlipGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinFlipGame));
            this.CoinTail = new System.Windows.Forms.PictureBox();
            this.CoinFlipButton = new System.Windows.Forms.Button();
            this.CoinHead = new System.Windows.Forms.PictureBox();
            this.HeadsCounter = new System.Windows.Forms.TextBox();
            this.TailsCounter = new System.Windows.Forms.TextBox();
            this.FirstPic = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CoinTail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPic)).BeginInit();
            this.SuspendLayout();
            // 
            // CoinTail
            // 
            this.CoinTail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CoinTail.Image = ((System.Drawing.Image)(resources.GetObject("CoinTail.Image")));
            this.CoinTail.Location = new System.Drawing.Point(241, 12);
            this.CoinTail.Name = "CoinTail";
            this.CoinTail.Size = new System.Drawing.Size(300, 300);
            this.CoinTail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoinTail.TabIndex = 0;
            this.CoinTail.TabStop = false;
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.BackColor = System.Drawing.Color.White;
            this.CoinFlipButton.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinFlipButton.Location = new System.Drawing.Point(241, 380);
            this.CoinFlipButton.Name = "CoinFlipButton";
            this.CoinFlipButton.Size = new System.Drawing.Size(300, 42);
            this.CoinFlipButton.TabIndex = 1;
            this.CoinFlipButton.Text = "Flip";
            this.CoinFlipButton.UseVisualStyleBackColor = false;
            this.CoinFlipButton.Click += new System.EventHandler(this.CoinFlipButton_Click);
            // 
            // CoinHead
            // 
            this.CoinHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CoinHead.Image = ((System.Drawing.Image)(resources.GetObject("CoinHead.Image")));
            this.CoinHead.Location = new System.Drawing.Point(241, 12);
            this.CoinHead.Name = "CoinHead";
            this.CoinHead.Size = new System.Drawing.Size(300, 300);
            this.CoinHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoinHead.TabIndex = 2;
            this.CoinHead.TabStop = false;
            // 
            // HeadsCounter
            // 
            this.HeadsCounter.Location = new System.Drawing.Point(241, 338);
            this.HeadsCounter.Multiline = true;
            this.HeadsCounter.Name = "HeadsCounter";
            this.HeadsCounter.Size = new System.Drawing.Size(138, 36);
            this.HeadsCounter.TabIndex = 3;
            this.HeadsCounter.TextChanged += new System.EventHandler(this.HeadsCounter_TextChanged);
            // 
            // TailsCounter
            // 
            this.TailsCounter.Location = new System.Drawing.Point(403, 338);
            this.TailsCounter.Multiline = true;
            this.TailsCounter.Name = "TailsCounter";
            this.TailsCounter.Size = new System.Drawing.Size(138, 36);
            this.TailsCounter.TabIndex = 4;
            // 
            // FirstPic
            // 
            this.FirstPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FirstPic.Image = ((System.Drawing.Image)(resources.GetObject("FirstPic.Image")));
            this.FirstPic.Location = new System.Drawing.Point(241, 12);
            this.FirstPic.Name = "FirstPic";
            this.FirstPic.Size = new System.Drawing.Size(300, 300);
            this.FirstPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FirstPic.TabIndex = 5;
            this.FirstPic.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Location = new System.Drawing.Point(701, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Made by Renis";
            // 
            // CoinFlipGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FirstPic);
            this.Controls.Add(this.TailsCounter);
            this.Controls.Add(this.HeadsCounter);
            this.Controls.Add(this.CoinHead);
            this.Controls.Add(this.CoinFlipButton);
            this.Controls.Add(this.CoinTail);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CoinFlipGame";
            this.Text = "Coin Flip Game";
            this.Load += new System.EventHandler(this.CoinFlipGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoinTail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CoinTail;
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.PictureBox CoinHead;
        private System.Windows.Forms.TextBox HeadsCounter;
        private System.Windows.Forms.TextBox TailsCounter;
        private System.Windows.Forms.PictureBox FirstPic;
        private System.Windows.Forms.TextBox textBox1;
    }
}

