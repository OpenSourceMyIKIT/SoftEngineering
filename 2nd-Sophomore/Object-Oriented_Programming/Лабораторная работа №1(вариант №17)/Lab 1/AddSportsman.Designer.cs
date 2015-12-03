namespace Lab_1
{
    partial class AddSportsman
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
            this.btnFinalize = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbSport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFinalize
            // 
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Location = new System.Drawing.Point(12, 90);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(91, 25);
            this.btnFinalize.TabIndex = 0;
            this.btnFinalize.Text = "Add";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(91, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "Enter name";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(12, 38);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(91, 20);
            this.tbSurname.TabIndex = 2;
            this.tbSurname.Text = "Enter surname";
            // 
            // tbSport
            // 
            this.tbSport.Location = new System.Drawing.Point(12, 64);
            this.tbSport.Name = "tbSport";
            this.tbSport.Size = new System.Drawing.Size(91, 20);
            this.tbSport.TabIndex = 3;
            this.tbSport.Text = "Enter sport";
            // 
            // AddSportsman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(120, 122);
            this.Controls.Add(this.tbSport);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnFinalize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSportsman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbSport;
    }
}