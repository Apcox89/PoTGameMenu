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
            this.lblPstats = new System.Windows.Forms.Label();
            this.pStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPstats
            // 
            this.lblPstats.AutoSize = true;
            this.lblPstats.Location = new System.Drawing.Point(323, 118);
            this.lblPstats.Name = "lblPstats";
            this.lblPstats.Size = new System.Drawing.Size(57, 13);
            this.lblPstats.TabIndex = 0;
            this.lblPstats.Text = "playerstats";
            // 
            // pStats
            // 
            this.pStats.Location = new System.Drawing.Point(197, 108);
            this.pStats.Name = "pStats";
            this.pStats.Size = new System.Drawing.Size(109, 23);
            this.pStats.TabIndex = 1;
            this.pStats.Text = "Check Stats:";
            this.pStats.UseVisualStyleBackColor = true;
            this.pStats.Click += new System.EventHandler(this.pStats_Click);
            // 
            // PoTMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pStats);
            this.Controls.Add(this.lblPstats);
            this.Name = "PoTMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPstats;
        private System.Windows.Forms.Button pStats;
    }
}

