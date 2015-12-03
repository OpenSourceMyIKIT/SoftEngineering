namespace Lab_1
{
    partial class AddTeam
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
            this.tbScore = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(12, 38);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(91, 20);
            this.tbScore.TabIndex = 6;
            this.tbScore.Text = "Enter score";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(91, 20);
            this.tbName.TabIndex = 5;
            this.tbName.Text = "Enter name";
            // 
            // btnFinalize
            // 
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Location = new System.Drawing.Point(12, 64);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(91, 25);
            this.btnFinalize.TabIndex = 4;
            this.btnFinalize.Text = "Add";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(120, 97);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnFinalize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnFinalize;
    }
}