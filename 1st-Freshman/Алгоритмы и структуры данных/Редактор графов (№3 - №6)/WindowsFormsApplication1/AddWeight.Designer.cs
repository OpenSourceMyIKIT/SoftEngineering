namespace WindowsFormsApplication1
{
    partial class AddWeight
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
            this.btnAddWeight = new System.Windows.Forms.Button();
            this.tbAddWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddWeight
            // 
            this.btnAddWeight.Location = new System.Drawing.Point(44, 58);
            this.btnAddWeight.Name = "btnAddWeight";
            this.btnAddWeight.Size = new System.Drawing.Size(100, 30);
            this.btnAddWeight.TabIndex = 0;
            this.btnAddWeight.Text = "Добавить";
            this.btnAddWeight.UseVisualStyleBackColor = true;
            this.btnAddWeight.Click += new System.EventHandler(this.btnAddWeight_Click);
            // 
            // tbAddWeight
            // 
            this.tbAddWeight.Location = new System.Drawing.Point(12, 21);
            this.tbAddWeight.Name = "tbAddWeight";
            this.tbAddWeight.Size = new System.Drawing.Size(168, 20);
            this.tbAddWeight.TabIndex = 1;
            this.tbAddWeight.Text = "Введите вес созданной связи";
            this.tbAddWeight.Click += new System.EventHandler(this.tbAddWeight_Click);
            // 
            // AddWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 100);
            this.Controls.Add(this.tbAddWeight);
            this.Controls.Add(this.btnAddWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddWeight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вес";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddWeight;
        private System.Windows.Forms.TextBox tbAddWeight;
    }
}