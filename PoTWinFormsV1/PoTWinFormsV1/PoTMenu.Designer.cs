namespace PoTWinFormsV1
{
    partial class PoTMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoTMenu));
            this.lblPstats = new System.Windows.Forms.Label();
            this.pStats = new System.Windows.Forms.Button();
            this.lblStatClicker = new System.Windows.Forms.Label();
            this.btnLvlUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBillGnant = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnXpStat = new System.Windows.Forms.Button();
            this.lblXpCurrent = new System.Windows.Forms.Label();
            this.btnDead = new System.Windows.Forms.Button();
            this.lblAliveTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPstats
            // 
            this.lblPstats.AutoSize = true;
            this.lblPstats.Location = new System.Drawing.Point(35, 207);
            this.lblPstats.Name = "lblPstats";
            this.lblPstats.Size = new System.Drawing.Size(57, 13);
            this.lblPstats.TabIndex = 0;
            this.lblPstats.Text = "playerstats";
            this.lblPstats.Click += new System.EventHandler(this.lblPstats_Click);
            // 
            // pStats
            // 
            this.pStats.Location = new System.Drawing.Point(146, 162);
            this.pStats.Name = "pStats";
            this.pStats.Size = new System.Drawing.Size(109, 23);
            this.pStats.TabIndex = 1;
            this.pStats.Text = "Check Stats:";
            this.pStats.UseVisualStyleBackColor = true;
            this.pStats.Click += new System.EventHandler(this.pStats_Click);
            // 
            // lblStatClicker
            // 
            this.lblStatClicker.AutoSize = true;
            this.lblStatClicker.Location = new System.Drawing.Point(128, 293);
            this.lblStatClicker.Name = "lblStatClicker";
            this.lblStatClicker.Size = new System.Drawing.Size(111, 13);
            this.lblStatClicker.TabIndex = 2;
            this.lblStatClicker.Text = "^Test lvlUp Function^";
            // 
            // btnLvlUp
            // 
            this.btnLvlUp.Location = new System.Drawing.Point(147, 267);
            this.btnLvlUp.Name = "btnLvlUp";
            this.btnLvlUp.Size = new System.Drawing.Size(75, 23);
            this.btnLvlUp.TabIndex = 4;
            this.btnLvlUp.Text = "Gain Points";
            this.btnLvlUp.UseVisualStyleBackColor = true;
            this.btnLvlUp.Click += new System.EventHandler(this.btnLvlUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblBillGnant
            // 
            this.lblBillGnant.AutoSize = true;
            this.lblBillGnant.Font = new System.Drawing.Font("Adobe Devanagari", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillGnant.Location = new System.Drawing.Point(385, 93);
            this.lblBillGnant.Name = "lblBillGnant";
            this.lblBillGnant.Size = new System.Drawing.Size(123, 37);
            this.lblBillGnant.TabIndex = 6;
            this.lblBillGnant.Text = "Bill Gnant";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Adobe Devanagari", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(45, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 65);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Portals of Technoprolis";
            // 
            // btnXpStat
            // 
            this.btnXpStat.Location = new System.Drawing.Point(146, 339);
            this.btnXpStat.Name = "btnXpStat";
            this.btnXpStat.Size = new System.Drawing.Size(75, 23);
            this.btnXpStat.TabIndex = 8;
            this.btnXpStat.Text = "Current XP:";
            this.btnXpStat.UseVisualStyleBackColor = true;
            this.btnXpStat.Click += new System.EventHandler(this.btnXpStat_Click);
            // 
            // lblXpCurrent
            // 
            this.lblXpCurrent.AutoSize = true;
            this.lblXpCurrent.Location = new System.Drawing.Point(155, 364);
            this.lblXpCurrent.Name = "lblXpCurrent";
            this.lblXpCurrent.Size = new System.Drawing.Size(56, 13);
            this.lblXpCurrent.TabIndex = 9;
            this.lblXpCurrent.Text = "XP Output";
            // 
            // btnDead
            // 
            this.btnDead.Location = new System.Drawing.Point(630, 315);
            this.btnDead.Name = "btnDead";
            this.btnDead.Size = new System.Drawing.Size(75, 37);
            this.btnDead.TabIndex = 10;
            this.btnDead.Text = "Test Player Death";
            this.btnDead.UseVisualStyleBackColor = true;
            this.btnDead.Click += new System.EventHandler(this.btnDead_Click);
            // 
            // lblAliveTest
            // 
            this.lblAliveTest.AutoSize = true;
            this.lblAliveTest.Location = new System.Drawing.Point(665, 355);
            this.lblAliveTest.Name = "lblAliveTest";
            this.lblAliveTest.Size = new System.Drawing.Size(40, 13);
            this.lblAliveTest.TabIndex = 11;
            this.lblAliveTest.Text = "Status:";
            // 
            // PoTMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAliveTest);
            this.Controls.Add(this.btnDead);
            this.Controls.Add(this.lblXpCurrent);
            this.Controls.Add(this.btnXpStat);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBillGnant);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLvlUp);
            this.Controls.Add(this.lblStatClicker);
            this.Controls.Add(this.pStats);
            this.Controls.Add(this.lblPstats);
            this.Name = "PoTMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPstats;
        private System.Windows.Forms.Button pStats;
        private System.Windows.Forms.Label lblStatClicker;
        private System.Windows.Forms.Button btnLvlUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBillGnant;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnXpStat;
        private System.Windows.Forms.Label lblXpCurrent;
        private System.Windows.Forms.Button btnDead;
        private System.Windows.Forms.Label lblAliveTest;
    }
}

