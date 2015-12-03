namespace Альберти
{
    partial class Form1
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
            this.codeBtn = new System.Windows.Forms.Button();
            this.uncodeBtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codeBtn
            // 
            this.codeBtn.Location = new System.Drawing.Point(12, 144);
            this.codeBtn.Name = "codeBtn";
            this.codeBtn.Size = new System.Drawing.Size(119, 23);
            this.codeBtn.TabIndex = 0;
            this.codeBtn.Text = "Зашифровать";
            this.codeBtn.UseVisualStyleBackColor = true;
            this.codeBtn.Click += new System.EventHandler(this.codeBtn_Click);
            // 
            // uncodeBtn
            // 
            this.uncodeBtn.Location = new System.Drawing.Point(272, 144);
            this.uncodeBtn.Name = "uncodeBtn";
            this.uncodeBtn.Size = new System.Drawing.Size(119, 23);
            this.uncodeBtn.TabIndex = 0;
            this.uncodeBtn.Text = "Дешифровать";
            this.uncodeBtn.UseVisualStyleBackColor = true;
            this.uncodeBtn.Click += new System.EventHandler(this.uncodeBtn_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 173);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(379, 123);
            this.output.TabIndex = 1;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 12);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(379, 123);
            this.input.TabIndex = 1;
            this.input.Text = "Входное сообщение";
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(137, 146);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(129, 20);
            this.key.TabIndex = 2;
            this.key.Text = "виват";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 308);
            this.Controls.Add(this.key);
            this.Controls.Add(this.input);
            this.Controls.Add(this.output);
            this.Controls.Add(this.uncodeBtn);
            this.Controls.Add(this.codeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button codeBtn;
        private System.Windows.Forms.Button uncodeBtn;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox key;
    }
}

