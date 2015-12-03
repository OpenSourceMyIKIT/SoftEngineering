namespace Цезарь_Вежинер
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
            this.input = new System.Windows.Forms.TextBox();
            this.decode = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.keyOl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 12);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(404, 149);
            this.input.TabIndex = 2;
            // 
            // decode
            // 
            this.decode.Location = new System.Drawing.Point(313, 181);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(101, 23);
            this.decode.TabIndex = 4;
            this.decode.Text = "Расшифровать";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(10, 181);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(102, 23);
            this.code.TabIndex = 4;
            this.code.Text = "Зашифровать";
            this.code.UseVisualStyleBackColor = true;
            this.code.Click += new System.EventHandler(this.code_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 219);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(404, 149);
            this.output.TabIndex = 2;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(286, 12);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(130, 20);
            this.key.TabIndex = 5;
            this.key.Text = "тгыг";
            this.key.Visible = false;
            // 
            // keyOl
            // 
            this.keyOl.Location = new System.Drawing.Point(153, 184);
            this.keyOl.Name = "keyOl";
            this.keyOl.Size = new System.Drawing.Size(125, 20);
            this.keyOl.TabIndex = 0;
            this.keyOl.Text = "баг";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 383);
            this.Controls.Add(this.key);
            this.Controls.Add(this.code);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.keyOl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.Button code;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.TextBox keyOl;
    }
}

