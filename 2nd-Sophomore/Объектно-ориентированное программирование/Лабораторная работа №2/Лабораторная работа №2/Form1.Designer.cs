namespace Лабораторная_работа__2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbStateList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPowerInhereted = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMonarch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGovernment = new System.Windows.Forms.TextBox();
            this.tbSourceOfLaw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFoundation = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Государство";
            // 
            // cbStateList
            // 
            this.cbStateList.FormattingEnabled = true;
            this.cbStateList.Location = new System.Drawing.Point(21, 29);
            this.cbStateList.Name = "cbStateList";
            this.cbStateList.Size = new System.Drawing.Size(165, 21);
            this.cbStateList.TabIndex = 1;
            this.cbStateList.Text = "Выберите государство...";
            this.cbStateList.SelectedIndexChanged += new System.EventHandler(this.cbStateList_SelectedIndexChanged);
            this.cbStateList.Click += new System.EventHandler(this.cbStateList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPowerInhereted);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbMonarch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbGovernment);
            this.groupBox1.Controls.Add(this.tbSourceOfLaw);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbFoundation);
            this.groupBox1.Controls.Add(this.tbType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // tbPowerInhereted
            // 
            this.tbPowerInhereted.Location = new System.Drawing.Point(287, 152);
            this.tbPowerInhereted.Name = "tbPowerInhereted";
            this.tbPowerInhereted.ReadOnly = true;
            this.tbPowerInhereted.Size = new System.Drawing.Size(139, 20);
            this.tbPowerInhereted.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Власть наследуется";
            // 
            // tbMonarch
            // 
            this.tbMonarch.Location = new System.Drawing.Point(12, 152);
            this.tbMonarch.Name = "tbMonarch";
            this.tbMonarch.ReadOnly = true;
            this.tbMonarch.Size = new System.Drawing.Size(269, 20);
            this.tbMonarch.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Монарх";
            // 
            // tbGovernment
            // 
            this.tbGovernment.Location = new System.Drawing.Point(12, 94);
            this.tbGovernment.Name = "tbGovernment";
            this.tbGovernment.ReadOnly = true;
            this.tbGovernment.Size = new System.Drawing.Size(139, 20);
            this.tbGovernment.TabIndex = 10;
            // 
            // tbSourceOfLaw
            // 
            this.tbSourceOfLaw.Location = new System.Drawing.Point(157, 94);
            this.tbSourceOfLaw.Name = "tbSourceOfLaw";
            this.tbSourceOfLaw.ReadOnly = true;
            this.tbSourceOfLaw.Size = new System.Drawing.Size(143, 20);
            this.tbSourceOfLaw.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Источник власти";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Орган управления";
            // 
            // tbFoundation
            // 
            this.tbFoundation.Location = new System.Drawing.Point(138, 36);
            this.tbFoundation.Name = "tbFoundation";
            this.tbFoundation.ReadOnly = true;
            this.tbFoundation.Size = new System.Drawing.Size(139, 20);
            this.tbFoundation.TabIndex = 6;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(283, 36);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(143, 20);
            this.tbType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Политический строй";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата основания";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 36);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(120, 20);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 268);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbStateList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFoundation;
        private System.Windows.Forms.TextBox tbGovernment;
        private System.Windows.Forms.TextBox tbSourceOfLaw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPowerInhereted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMonarch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbStateList;
    }
}

