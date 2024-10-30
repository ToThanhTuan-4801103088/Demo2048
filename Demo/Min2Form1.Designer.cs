namespace Demo
{
    partial class Min2Form1
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
            this.ExitToMenu = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Label();
            this.lbHighScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitToMenu
            // 
            this.ExitToMenu.AutoSize = true;
            this.ExitToMenu.BackColor = System.Drawing.Color.White;
            this.ExitToMenu.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.ExitToMenu.ForeColor = System.Drawing.Color.Black;
            this.ExitToMenu.Location = new System.Drawing.Point(258, 517);
            this.ExitToMenu.Name = "ExitToMenu";
            this.ExitToMenu.Size = new System.Drawing.Size(154, 24);
            this.ExitToMenu.TabIndex = 10;
            this.ExitToMenu.Text = "Back To Menu";
            this.ExitToMenu.Click += new System.EventHandler(this.ExitToMenu_Click);
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.BackColor = System.Drawing.Color.White;
            this.Reset.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(282, 480);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(130, 24);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset Game";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // lbHighScore
            // 
            this.lbHighScore.AutoSize = true;
            this.lbHighScore.BackColor = System.Drawing.Color.White;
            this.lbHighScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighScore.ForeColor = System.Drawing.Color.Black;
            this.lbHighScore.Location = new System.Drawing.Point(165, 517);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(22, 24);
            this.lbHighScore.TabIndex = 8;
            this.lbHighScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Highest:";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.White;
            this.lbScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Black;
            this.lbScore.Location = new System.Drawing.Point(133, 480);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(22, 24);
            this.lbScore.TabIndex = 7;
            this.lbScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time Left: ";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.BackColor = System.Drawing.Color.White;
            this.lbTimer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.Black;
            this.lbTimer.Location = new System.Drawing.Point(165, 441);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(70, 24);
            this.lbTimer.TabIndex = 12;
            this.lbTimer.Text = "00:00";
            // 
            // Min2Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 551);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExitToMenu);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.lbHighScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label1);
            this.Name = "Min2Form1";
            this.Text = "Min2Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitToMenu;
        private System.Windows.Forms.Label Reset;
        private System.Windows.Forms.Label lbHighScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTimer;
    }
}