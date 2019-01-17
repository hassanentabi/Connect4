namespace TheWinningApp
{
    partial class Frm_Game
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.exiteToolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayNow = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuNewGame,
            this.aboutToolStripMenuAbout,
            this.exiteToolStripMenuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuNewGame
            // 
            this.newGameToolStripMenuNewGame.Name = "newGameToolStripMenuNewGame";
            this.newGameToolStripMenuNewGame.Size = new System.Drawing.Size(94, 24);
            this.newGameToolStripMenuNewGame.Text = "&New Game";
            this.newGameToolStripMenuNewGame.Click += new System.EventHandler(this.newGameToolStripMenuNewGame_Click);
            // 
            // exiteToolStripMenuExit
            // 
            this.exiteToolStripMenuExit.Name = "exiteToolStripMenuExit";
            this.exiteToolStripMenuExit.Size = new System.Drawing.Size(45, 24);
            this.exiteToolStripMenuExit.Text = "&Exit";
            this.exiteToolStripMenuExit.Click += new System.EventHandler(this.exiteToolStripMenuExit_Click);
            // 
            // aboutToolStripMenuAbout
            // 
            this.aboutToolStripMenuAbout.Name = "aboutToolStripMenuAbout";
            this.aboutToolStripMenuAbout.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuAbout.Text = "&About";
            this.aboutToolStripMenuAbout.Click += new System.EventHandler(this.aboutToolStripMenuAbout_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(76, 34);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(50, 17);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "name1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(194, 34);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(50, 17);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "name2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player Now:";
            // 
            // lblPlayNow
            // 
            this.lblPlayNow.AutoSize = true;
            this.lblPlayNow.Location = new System.Drawing.Point(319, 34);
            this.lblPlayNow.Name = "lblPlayNow";
            this.lblPlayNow.Size = new System.Drawing.Size(26, 17);
            this.lblPlayNow.TabIndex = 6;
            this.lblPlayNow.Text = "txt";
            // 
            // Frm_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 475);
            this.Controls.Add(this.lblPlayNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Winning Four";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuNewGame;
        private System.Windows.Forms.ToolStripMenuItem exiteToolStripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuAbout;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayNow;
    }
}

