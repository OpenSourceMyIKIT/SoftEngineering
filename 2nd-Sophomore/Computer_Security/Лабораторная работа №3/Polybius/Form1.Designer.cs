namespace Polybius
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
            this.btnEncode = new System.Windows.Forms.Button();
            this.tbInputEncode = new System.Windows.Forms.TextBox();
            this.tbResultEncode = new System.Windows.Forms.TextBox();
            this.tbResultDecode = new System.Windows.Forms.TextBox();
            this.tbInputDecode = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnPrison = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbAlphabet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncode
            // 
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Location = new System.Drawing.Point(54, 110);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(95, 23);
            this.btnEncode.TabIndex = 0;
            this.btnEncode.Text = "Зашифровать";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // tbInputEncode
            // 
            this.tbInputEncode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputEncode.Location = new System.Drawing.Point(12, 58);
            this.tbInputEncode.Name = "tbInputEncode";
            this.tbInputEncode.Size = new System.Drawing.Size(188, 20);
            this.tbInputEncode.TabIndex = 1;
            this.tbInputEncode.Text = "Введите текст для шифрования";
            this.tbInputEncode.Click += new System.EventHandler(this.tbInputEncode_Click);
            // 
            // tbResultEncode
            // 
            this.tbResultEncode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResultEncode.Location = new System.Drawing.Point(12, 84);
            this.tbResultEncode.Name = "tbResultEncode";
            this.tbResultEncode.Size = new System.Drawing.Size(188, 20);
            this.tbResultEncode.TabIndex = 2;
            this.tbResultEncode.Text = "Результат";
            // 
            // tbResultDecode
            // 
            this.tbResultDecode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResultDecode.Location = new System.Drawing.Point(271, 84);
            this.tbResultDecode.Name = "tbResultDecode";
            this.tbResultDecode.Size = new System.Drawing.Size(188, 20);
            this.tbResultDecode.TabIndex = 5;
            this.tbResultDecode.Text = "Результат";
            // 
            // tbInputDecode
            // 
            this.tbInputDecode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputDecode.Location = new System.Drawing.Point(271, 58);
            this.tbInputDecode.Name = "tbInputDecode";
            this.tbInputDecode.Size = new System.Drawing.Size(188, 20);
            this.tbInputDecode.TabIndex = 4;
            this.tbInputDecode.Text = "Введите текст для дешифровки";
            this.tbInputDecode.Click += new System.EventHandler(this.tbInputDecode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.Location = new System.Drawing.Point(317, 110);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(95, 23);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Дешифровать";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnPrison
            // 
            this.btnPrison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrison.Location = new System.Drawing.Point(54, 139);
            this.btnPrison.Name = "btnPrison";
            this.btnPrison.Size = new System.Drawing.Size(95, 40);
            this.btnPrison.TabIndex = 6;
            this.btnPrison.Text = "\"Тюремная\" версия";
            this.btnPrison.UseVisualStyleBackColor = true;
            this.btnPrison.Click += new System.EventHandler(this.btnPrison_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(199, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbAlphabet
            // 
            this.cbAlphabet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAlphabet.FormattingEnabled = true;
            this.cbAlphabet.Location = new System.Drawing.Point(172, 31);
            this.cbAlphabet.Name = "cbAlphabet";
            this.cbAlphabet.Size = new System.Drawing.Size(121, 21);
            this.cbAlphabet.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Какой алфавит используем?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAlphabet);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrison);
            this.Controls.Add(this.tbResultDecode);
            this.Controls.Add(this.tbInputDecode);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.tbResultEncode);
            this.Controls.Add(this.tbInputEncode);
            this.Controls.Add(this.btnEncode);
            this.Name = "Form1";
            this.Text = "Шифровка квадратом Полибия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox tbInputEncode;
        private System.Windows.Forms.TextBox tbResultEncode;
        private System.Windows.Forms.TextBox tbResultDecode;
        private System.Windows.Forms.TextBox tbInputDecode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnPrison;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbAlphabet;
        private System.Windows.Forms.Label label1;
    }
}

