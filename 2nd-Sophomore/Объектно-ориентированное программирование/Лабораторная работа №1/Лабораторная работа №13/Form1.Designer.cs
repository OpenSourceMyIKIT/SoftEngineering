namespace Лабораторная_работа__13
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьЭлементыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbShowTransports = new System.Windows.Forms.RadioButton();
            this.rbShowDrivers = new System.Windows.Forms.RadioButton();
            this.btnAttach = new System.Windows.Forms.Button();
            this.cbAttach = new System.Windows.Forms.ComboBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.rbShowCompanies = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.ContextMenuStrip = this.contextMenuStrip;
            this.listView.ForeColor = System.Drawing.Color.Black;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 53);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(282, 227);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьЭлементыToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(190, 26);
            // 
            // удалитьЭлементыToolStripMenuItem
            // 
            this.удалитьЭлементыToolStripMenuItem.Name = "удалитьЭлементыToolStripMenuItem";
            this.удалитьЭлементыToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.удалитьЭлементыToolStripMenuItem.Text = "Удалить элемент(-ы)";
            this.удалитьЭлементыToolStripMenuItem.Click += new System.EventHandler(this.удалитьЭлементыToolStripMenuItem_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(300, 53);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(131, 21);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBox.Click += new System.EventHandler(this.comboBox_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(300, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(300, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 25);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbShowTransports
            // 
            this.rbShowTransports.AutoSize = true;
            this.rbShowTransports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbShowTransports.Location = new System.Drawing.Point(300, 80);
            this.rbShowTransports.Name = "rbShowTransports";
            this.rbShowTransports.Size = new System.Drawing.Size(78, 17);
            this.rbShowTransports.TabIndex = 5;
            this.rbShowTransports.TabStop = true;
            this.rbShowTransports.Text = "Транспорт";
            this.rbShowTransports.UseVisualStyleBackColor = true;
            this.rbShowTransports.CheckedChanged += new System.EventHandler(this.rbShowPatients_CheckedChanged);
            // 
            // rbShowDrivers
            // 
            this.rbShowDrivers.AutoSize = true;
            this.rbShowDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbShowDrivers.Location = new System.Drawing.Point(300, 103);
            this.rbShowDrivers.Name = "rbShowDrivers";
            this.rbShowDrivers.Size = new System.Drawing.Size(72, 17);
            this.rbShowDrivers.TabIndex = 6;
            this.rbShowDrivers.TabStop = true;
            this.rbShowDrivers.Text = "Водитель";
            this.rbShowDrivers.UseVisualStyleBackColor = true;
            this.rbShowDrivers.CheckedChanged += new System.EventHandler(this.rbShowDoctors_CheckedChanged);
            // 
            // btnAttach
            // 
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttach.Location = new System.Drawing.Point(300, 193);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(131, 25);
            this.btnAttach.TabIndex = 7;
            this.btnAttach.Text = "Прикрепить";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // cbAttach
            // 
            this.cbAttach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAttach.FormattingEnabled = true;
            this.cbAttach.Location = new System.Drawing.Point(300, 149);
            this.cbAttach.Name = "cbAttach";
            this.cbAttach.Size = new System.Drawing.Size(131, 21);
            this.cbAttach.TabIndex = 8;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Lobster 1.4", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeader.Location = new System.Drawing.Point(13, 30);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 18);
            this.lbHeader.TabIndex = 9;
            // 
            // rbShowCompanies
            // 
            this.rbShowCompanies.AutoSize = true;
            this.rbShowCompanies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbShowCompanies.Location = new System.Drawing.Point(300, 126);
            this.rbShowCompanies.Name = "rbShowCompanies";
            this.rbShowCompanies.Size = new System.Drawing.Size(75, 17);
            this.rbShowCompanies.TabIndex = 10;
            this.rbShowCompanies.TabStop = true;
            this.rbShowCompanies.Text = "Компания";
            this.rbShowCompanies.UseVisualStyleBackColor = true;
            this.rbShowCompanies.CheckedChanged += new System.EventHandler(this.rbCompany_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 293);
            this.Controls.Add(this.rbShowCompanies);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.cbAttach);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.rbShowDrivers);
            this.Controls.Add(this.rbShowTransports);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbShowTransports;
        private System.Windows.Forms.RadioButton rbShowDrivers;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ComboBox cbAttach;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem удалитьЭлементыToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbShowCompanies;
    }
}

