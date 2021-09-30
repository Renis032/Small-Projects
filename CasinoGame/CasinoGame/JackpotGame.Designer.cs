
namespace CasinoGame
{
    partial class Jackpot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jackpot));
            this.casino_lbl = new System.Windows.Forms.Label();
            this.balance_lbl = new System.Windows.Forms.Label();
            this.wins_lbl = new System.Windows.Forms.Label();
            this.loses_lbl = new System.Windows.Forms.Label();
            this.bidAmount_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.play_btn = new System.Windows.Forms.Button();
            this.bid_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // casino_lbl
            // 
            this.casino_lbl.AutoSize = true;
            this.casino_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.casino_lbl.ForeColor = System.Drawing.Color.Yellow;
            this.casino_lbl.Location = new System.Drawing.Point(1, 11);
            this.casino_lbl.Name = "casino_lbl";
            this.casino_lbl.Size = new System.Drawing.Size(110, 37);
            this.casino_lbl.TabIndex = 3;
            this.casino_lbl.Text = "Casino";
            // 
            // balance_lbl
            // 
            this.balance_lbl.AutoSize = true;
            this.balance_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balance_lbl.ForeColor = System.Drawing.Color.Silver;
            this.balance_lbl.Location = new System.Drawing.Point(1, 45);
            this.balance_lbl.Name = "balance_lbl";
            this.balance_lbl.Size = new System.Drawing.Size(157, 37);
            this.balance_lbl.TabIndex = 4;
            this.balance_lbl.Text = "Balance: $";
            // 
            // wins_lbl
            // 
            this.wins_lbl.AutoSize = true;
            this.wins_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wins_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.wins_lbl.Location = new System.Drawing.Point(12, 254);
            this.wins_lbl.Name = "wins_lbl";
            this.wins_lbl.Size = new System.Drawing.Size(87, 27);
            this.wins_lbl.TabIndex = 5;
            this.wins_lbl.Text = "Wins: 0";
            // 
            // loses_lbl
            // 
            this.loses_lbl.AutoSize = true;
            this.loses_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loses_lbl.ForeColor = System.Drawing.Color.Red;
            this.loses_lbl.Location = new System.Drawing.Point(12, 286);
            this.loses_lbl.Name = "loses_lbl";
            this.loses_lbl.Size = new System.Drawing.Size(95, 26);
            this.loses_lbl.TabIndex = 6;
            this.loses_lbl.Text = "Losses: 0";
            this.loses_lbl.Visible = false;
            // 
            // bidAmount_lbl
            // 
            this.bidAmount_lbl.AutoSize = true;
            this.bidAmount_lbl.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bidAmount_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bidAmount_lbl.Location = new System.Drawing.Point(176, 241);
            this.bidAmount_lbl.Name = "bidAmount_lbl";
            this.bidAmount_lbl.Size = new System.Drawing.Size(126, 23);
            this.bidAmount_lbl.TabIndex = 7;
            this.bidAmount_lbl.Text = "Bid-Amount";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(190, 277);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // play_btn
            // 
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play_btn.ForeColor = System.Drawing.Color.White;
            this.play_btn.Location = new System.Drawing.Point(28, 328);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(125, 50);
            this.play_btn.TabIndex = 9;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // bid_btn
            // 
            this.bid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bid_btn.ForeColor = System.Drawing.Color.White;
            this.bid_btn.Location = new System.Drawing.Point(180, 328);
            this.bid_btn.Name = "bid_btn";
            this.bid_btn.Size = new System.Drawing.Size(125, 50);
            this.bid_btn.TabIndex = 10;
            this.bid_btn.Text = "New Bid";
            this.bid_btn.UseVisualStyleBackColor = true;
            this.bid_btn.Click += new System.EventHandler(this.bid_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Made by Renis";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CasinoGame.Properties.Resources.ValidateCopy;
            this.pictureBox3.Location = new System.Drawing.Point(232, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CasinoGame.Properties.Resources.ValidateCopy;
            this.pictureBox2.Location = new System.Drawing.Point(133, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CasinoGame.Properties.Resources.ValidateCopy;
            this.pictureBox1.Location = new System.Drawing.Point(26, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Jackpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(332, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bid_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bidAmount_lbl);
            this.Controls.Add(this.loses_lbl);
            this.Controls.Add(this.wins_lbl);
            this.Controls.Add(this.balance_lbl);
            this.Controls.Add(this.casino_lbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jackpot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CasinoGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label casino_lbl;
        private System.Windows.Forms.Label balance_lbl;
        private System.Windows.Forms.Label wins_lbl;
        private System.Windows.Forms.Label loses_lbl;
        private System.Windows.Forms.Label bidAmount_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button bid_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

