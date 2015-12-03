namespace Лабораторная_работа__13
{
    partial class AddPatient
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbTNumber = new System.Windows.Forms.TextBox();
            this.tbTRoute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbTransport = new System.Windows.Forms.RadioButton();
            this.rbDriver = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDCategory = new System.Windows.Forms.TextBox();
            this.tbDFio = new System.Windows.Forms.TextBox();
            this.tbTModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.rbCompany = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(312, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnEndAdd_Click);
            // 
            // tbTNumber
            // 
            this.tbTNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTNumber.Location = new System.Drawing.Point(12, 26);
            this.tbTNumber.Multiline = true;
            this.tbTNumber.Name = "tbTNumber";
            this.tbTNumber.Size = new System.Drawing.Size(78, 21);
            this.tbTNumber.TabIndex = 3;
            // 
            // tbTRoute
            // 
            this.tbTRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTRoute.Location = new System.Drawing.Point(96, 26);
            this.tbTRoute.Multiline = true;
            this.tbTRoute.Name = "tbTRoute";
            this.tbTRoute.Size = new System.Drawing.Size(76, 21);
            this.tbTRoute.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Маршрут";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Модель";
            // 
            // rbTransport
            // 
            this.rbTransport.AutoSize = true;
            this.rbTransport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbTransport.Location = new System.Drawing.Point(12, 53);
            this.rbTransport.Name = "rbTransport";
            this.rbTransport.Size = new System.Drawing.Size(78, 17);
            this.rbTransport.TabIndex = 10;
            this.rbTransport.TabStop = true;
            this.rbTransport.Text = "Транспорт";
            this.rbTransport.UseVisualStyleBackColor = true;
            // 
            // rbDriver
            // 
            this.rbDriver.AutoSize = true;
            this.rbDriver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDriver.Location = new System.Drawing.Point(12, 121);
            this.rbDriver.Name = "rbDriver";
            this.rbDriver.Size = new System.Drawing.Size(72, 17);
            this.rbDriver.TabIndex = 11;
            this.rbDriver.TabStop = true;
            this.rbDriver.Text = "Водитель";
            this.rbDriver.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Категория";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ф.И.О.";
            // 
            // tbDCategory
            // 
            this.tbDCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDCategory.Location = new System.Drawing.Point(249, 94);
            this.tbDCategory.Multiline = true;
            this.tbDCategory.Name = "tbDCategory";
            this.tbDCategory.Size = new System.Drawing.Size(113, 21);
            this.tbDCategory.TabIndex = 13;
            // 
            // tbDFio
            // 
            this.tbDFio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDFio.Location = new System.Drawing.Point(12, 94);
            this.tbDFio.Multiline = true;
            this.tbDFio.Name = "tbDFio";
            this.tbDFio.Size = new System.Drawing.Size(231, 21);
            this.tbDFio.TabIndex = 12;
            // 
            // tbTModel
            // 
            this.tbTModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTModel.Location = new System.Drawing.Point(178, 26);
            this.tbTModel.Multiline = true;
            this.tbTModel.Name = "tbTModel";
            this.tbTModel.Size = new System.Drawing.Size(184, 21);
            this.tbTModel.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Название";
            // 
            // tbCName
            // 
            this.tbCName.Location = new System.Drawing.Point(12, 168);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(231, 20);
            this.tbCName.TabIndex = 21;
            // 
            // rbCompany
            // 
            this.rbCompany.AutoSize = true;
            this.rbCompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbCompany.Location = new System.Drawing.Point(12, 194);
            this.rbCompany.Name = "rbCompany";
            this.rbCompany.Size = new System.Drawing.Size(75, 17);
            this.rbCompany.TabIndex = 23;
            this.rbCompany.TabStop = true;
            this.rbCompany.Text = "Компания";
            this.rbCompany.UseVisualStyleBackColor = true;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 261);
            this.Controls.Add(this.rbCompany);
            this.Controls.Add(this.tbCName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDCategory);
            this.Controls.Add(this.tbDFio);
            this.Controls.Add(this.rbDriver);
            this.Controls.Add(this.rbTransport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTRoute);
            this.Controls.Add(this.tbTNumber);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPatient";
            this.ShowIcon = false;
            this.Text = "Добавить в список";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbTNumber;
        private System.Windows.Forms.TextBox tbTRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbTransport;
        private System.Windows.Forms.RadioButton rbDriver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDCategory;
        private System.Windows.Forms.TextBox tbDFio;
        private System.Windows.Forms.TextBox tbTModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.RadioButton rbCompany;
    }
}