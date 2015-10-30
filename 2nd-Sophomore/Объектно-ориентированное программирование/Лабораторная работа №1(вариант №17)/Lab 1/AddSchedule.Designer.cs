namespace Lab_1
{
    partial class AddSchedule
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
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(12, 64);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(91, 20);
            this.tbYear.TabIndex = 7;
            this.tbYear.Text = "Enter year";
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(12, 38);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(91, 20);
            this.tbMonth.TabIndex = 6;
            this.tbMonth.Text = "Enter month";
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(12, 12);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(91, 20);
            this.tbDay.TabIndex = 5;
            this.tbDay.Text = "Enter day";
            // 
            // btnFinalize
            // 
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Location = new System.Drawing.Point(12, 90);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(91, 25);
            this.btnFinalize.TabIndex = 4;
            this.btnFinalize.Text = "Add";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // AddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(120, 122);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.btnFinalize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Button btnFinalize;
    }
}