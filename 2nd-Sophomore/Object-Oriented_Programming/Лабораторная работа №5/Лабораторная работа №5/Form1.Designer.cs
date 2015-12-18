namespace Лабораторная_работа__5
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
            this.cbClientDB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpecialist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAim = new System.Windows.Forms.TextBox();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbClientDB
            // 
            this.cbClientDB.FormattingEnabled = true;
            this.cbClientDB.Location = new System.Drawing.Point(12, 33);
            this.cbClientDB.Name = "cbClientDB";
            this.cbClientDB.Size = new System.Drawing.Size(121, 21);
            this.cbClientDB.TabIndex = 0;
            this.cbClientDB.SelectedIndexChanged += new System.EventHandler(this.cbClientDB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "База данных клиентов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // tbSpecialist
            // 
            this.tbSpecialist.Enabled = false;
            this.tbSpecialist.Location = new System.Drawing.Point(12, 87);
            this.tbSpecialist.Name = "tbSpecialist";
            this.tbSpecialist.Size = new System.Drawing.Size(298, 20);
            this.tbSpecialist.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Специалист";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Время визита";
            // 
            // tbTime
            // 
            this.tbTime.Enabled = false;
            this.tbTime.Location = new System.Drawing.Point(12, 132);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(298, 20);
            this.tbTime.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Цель визита";
            // 
            // tbAim
            // 
            this.tbAim.Enabled = false;
            this.tbAim.Location = new System.Drawing.Point(12, 180);
            this.tbAim.Name = "tbAim";
            this.tbAim.Size = new System.Drawing.Size(298, 20);
            this.tbAim.TabIndex = 8;
            // 
            // btnAdmission
            // 
            this.btnAdmission.Location = new System.Drawing.Point(219, 209);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(91, 28);
            this.btnAdmission.TabIndex = 10;
            this.btnAdmission.Text = "Записаться";
            this.btnAdmission.UseVisualStyleBackColor = true;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Цель визита";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 244);
            this.Controls.Add(this.btnAdmission);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpecialist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClientDB);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClientDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSpecialist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAim;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Label label6;
    }
}

