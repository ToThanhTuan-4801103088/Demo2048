namespace Demo
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.label5x5 = new System.Windows.Forms.Label();
            this.label4x4 = new System.Windows.Forms.Label();
            this.min2_4x4 = new System.Windows.Forms.Label();
            this.min2_5x5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 40F);
            this.label1.Location = new System.Drawing.Point(220, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "2048";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Moccasin;
            this.pictureBox1.Location = new System.Drawing.Point(79, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 178);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Moccasin;
            this.Exit.Font = new System.Drawing.Font("Consolas", 20F);
            this.Exit.Location = new System.Drawing.Point(389, 248);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(74, 32);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.BackColor = System.Drawing.Color.Moccasin;
            this.labelAbout.Font = new System.Drawing.Font("Consolas", 20F);
            this.labelAbout.Location = new System.Drawing.Point(389, 198);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(89, 32);
            this.labelAbout.TabIndex = 7;
            this.labelAbout.Text = "About";
            this.labelAbout.Click += new System.EventHandler(this.labelAbout_Click);
            // 
            // label5x5
            // 
            this.label5x5.AutoSize = true;
            this.label5x5.BackColor = System.Drawing.Color.Moccasin;
            this.label5x5.Font = new System.Drawing.Font("Consolas", 20F);
            this.label5x5.Location = new System.Drawing.Point(240, 221);
            this.label5x5.Name = "label5x5";
            this.label5x5.Size = new System.Drawing.Size(104, 32);
            this.label5x5.TabIndex = 6;
            this.label5x5.Text = "Normal";
            this.label5x5.Click += new System.EventHandler(this.label5x5_Click);
            // 
            // label4x4
            // 
            this.label4x4.AutoSize = true;
            this.label4x4.BackColor = System.Drawing.Color.Moccasin;
            this.label4x4.Font = new System.Drawing.Font("Consolas", 20F);
            this.label4x4.Location = new System.Drawing.Point(109, 221);
            this.label4x4.Name = "label4x4";
            this.label4x4.Size = new System.Drawing.Size(104, 32);
            this.label4x4.TabIndex = 5;
            this.label4x4.Text = "Normal";
            this.label4x4.Click += new System.EventHandler(this.label4x4_Click);
            // 
            // min2_4x4
            // 
            this.min2_4x4.AutoSize = true;
            this.min2_4x4.BackColor = System.Drawing.Color.Moccasin;
            this.min2_4x4.Font = new System.Drawing.Font("Consolas", 20F);
            this.min2_4x4.Location = new System.Drawing.Point(130, 268);
            this.min2_4x4.Name = "min2_4x4";
            this.min2_4x4.Size = new System.Drawing.Size(74, 32);
            this.min2_4x4.TabIndex = 9;
            this.min2_4x4.Text = "2min";
            this.min2_4x4.Click += new System.EventHandler(this.min2_4x4_Click);
            // 
            // min2_5x5
            // 
            this.min2_5x5.AutoSize = true;
            this.min2_5x5.BackColor = System.Drawing.Color.Moccasin;
            this.min2_5x5.Font = new System.Drawing.Font("Consolas", 20F);
            this.min2_5x5.Location = new System.Drawing.Point(263, 268);
            this.min2_5x5.Name = "min2_5x5";
            this.min2_5x5.Size = new System.Drawing.Size(74, 32);
            this.min2_5x5.TabIndex = 10;
            this.min2_5x5.Text = "2min";
            this.min2_5x5.Click += new System.EventHandler(this.min2_5x5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Moccasin;
            this.label6.Font = new System.Drawing.Font("Consolas", 20F);
            this.label6.Location = new System.Drawing.Point(145, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "4x4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Moccasin;
            this.label7.Font = new System.Drawing.Font("Consolas", 20F);
            this.label7.Location = new System.Drawing.Point(278, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "5x5";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 394);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.min2_5x5);
            this.Controls.Add(this.min2_4x4);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.label5x5);
            this.Controls.Add(this.label4x4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label label5x5;
        private System.Windows.Forms.Label label4x4;
        private System.Windows.Forms.Label min2_4x4;
        private System.Windows.Forms.Label min2_5x5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}