namespace NumberOfBackspaces
{
    partial class form
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
            this.countLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.mistakesPerMinuteLbl = new System.Windows.Forms.Label();
            this.mistakesPerWordLbl = new System.Windows.Forms.Label();
            this.wordsCountedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(12, 9);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(47, 13);
            this.countLabel.TabIndex = 0;
            this.countLabel.Text = "Count: 0";
            // 
            // startBtn
            // 
            this.startBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startBtn.Location = new System.Drawing.Point(152, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stopBtn.Location = new System.Drawing.Point(233, 4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetBtn.Location = new System.Drawing.Point(314, 4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // mistakesPerMinuteLbl
            // 
            this.mistakesPerMinuteLbl.AutoSize = true;
            this.mistakesPerMinuteLbl.Location = new System.Drawing.Point(12, 39);
            this.mistakesPerMinuteLbl.Name = "mistakesPerMinuteLbl";
            this.mistakesPerMinuteLbl.Size = new System.Drawing.Size(44, 13);
            this.mistakesPerMinuteLbl.TabIndex = 4;
            this.mistakesPerMinuteLbl.Text = "MPM: 0";
            // 
            // mistakesPerWordLbl
            // 
            this.mistakesPerWordLbl.AutoSize = true;
            this.mistakesPerWordLbl.Location = new System.Drawing.Point(107, 39);
            this.mistakesPerWordLbl.Name = "mistakesPerWordLbl";
            this.mistakesPerWordLbl.Size = new System.Drawing.Size(46, 13);
            this.mistakesPerWordLbl.TabIndex = 5;
            this.mistakesPerWordLbl.Text = "MPW: 0";
            // 
            // wordsCountedLbl
            // 
            this.wordsCountedLbl.AutoSize = true;
            this.wordsCountedLbl.Location = new System.Drawing.Point(207, 39);
            this.wordsCountedLbl.Name = "wordsCountedLbl";
            this.wordsCountedLbl.Size = new System.Drawing.Size(50, 13);
            this.wordsCountedLbl.TabIndex = 6;
            this.wordsCountedLbl.Text = "Words: 0";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(394, 61);
            this.Controls.Add(this.wordsCountedLbl);
            this.Controls.Add(this.mistakesPerWordLbl);
            this.Controls.Add(this.mistakesPerMinuteLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.countLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 100);
            this.MinimumSize = new System.Drawing.Size(410, 100);
            this.Name = "form";
            this.Text = "Count Errors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label mistakesPerMinuteLbl;
        private System.Windows.Forms.Label mistakesPerWordLbl;
        private System.Windows.Forms.Label wordsCountedLbl;
    }
}

