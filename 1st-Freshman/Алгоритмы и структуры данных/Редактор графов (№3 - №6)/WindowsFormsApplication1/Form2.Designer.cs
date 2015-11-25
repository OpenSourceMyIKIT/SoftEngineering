namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.lbCoordinate = new System.Windows.Forms.Label();
            this.rbAddVertex = new System.Windows.Forms.RadioButton();
            this.rbDelLink = new System.Windows.Forms.RadioButton();
            this.rbAddLink = new System.Windows.Forms.RadioButton();
            this.rbDragVertex = new System.Windows.Forms.RadioButton();
            this.rbDelVertex = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumVertex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumLinks = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйГрафToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВBMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new WindowsFormsApplication1.Form2.DoubleBufferedPanel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbCoordinates = new System.Windows.Forms.Label();
            this.btnShortestPath = new System.Windows.Forms.Button();
            this.btnMinTree = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCoordinate
            // 
            this.lbCoordinate.AutoSize = true;
            this.lbCoordinate.Location = new System.Drawing.Point(-1, 311);
            this.lbCoordinate.Name = "lbCoordinate";
            this.lbCoordinate.Size = new System.Drawing.Size(28, 13);
            this.lbCoordinate.TabIndex = 0;
            this.lbCoordinate.Text = "(0,0)";
            // 
            // rbAddVertex
            // 
            this.rbAddVertex.AutoSize = true;
            this.rbAddVertex.Location = new System.Drawing.Point(6, 19);
            this.rbAddVertex.Name = "rbAddVertex";
            this.rbAddVertex.Size = new System.Drawing.Size(121, 17);
            this.rbAddVertex.TabIndex = 1;
            this.rbAddVertex.TabStop = true;
            this.rbAddVertex.Text = "Добавить вершину";
            this.rbAddVertex.UseVisualStyleBackColor = true;
            // 
            // rbDelLink
            // 
            this.rbDelLink.AutoSize = true;
            this.rbDelLink.Location = new System.Drawing.Point(6, 128);
            this.rbDelLink.Name = "rbDelLink";
            this.rbDelLink.Size = new System.Drawing.Size(101, 17);
            this.rbDelLink.TabIndex = 2;
            this.rbDelLink.TabStop = true;
            this.rbDelLink.Text = "Удалить связь";
            this.rbDelLink.UseVisualStyleBackColor = true;
            // 
            // rbAddLink
            // 
            this.rbAddLink.AutoSize = true;
            this.rbAddLink.Location = new System.Drawing.Point(6, 105);
            this.rbAddLink.Name = "rbAddLink";
            this.rbAddLink.Size = new System.Drawing.Size(108, 17);
            this.rbAddLink.TabIndex = 3;
            this.rbAddLink.TabStop = true;
            this.rbAddLink.Text = "Добавить связь";
            this.rbAddLink.UseVisualStyleBackColor = true;
            // 
            // rbDragVertex
            // 
            this.rbDragVertex.AutoSize = true;
            this.rbDragVertex.Location = new System.Drawing.Point(6, 65);
            this.rbDragVertex.Name = "rbDragVertex";
            this.rbDragVertex.Size = new System.Drawing.Size(139, 17);
            this.rbDragVertex.TabIndex = 4;
            this.rbDragVertex.TabStop = true;
            this.rbDragVertex.Text = "Переместить вершину";
            this.rbDragVertex.UseVisualStyleBackColor = true;
            // 
            // rbDelVertex
            // 
            this.rbDelVertex.AutoSize = true;
            this.rbDelVertex.Location = new System.Drawing.Point(6, 42);
            this.rbDelVertex.Name = "rbDelVertex";
            this.rbDelVertex.Size = new System.Drawing.Size(114, 17);
            this.rbDelVertex.TabIndex = 5;
            this.rbDelVertex.TabStop = true;
            this.rbDelVertex.Text = "Удалить вершину";
            this.rbDelVertex.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAddVertex);
            this.groupBox1.Controls.Add(this.rbDelLink);
            this.groupBox1.Controls.Add(this.rbAddLink);
            this.groupBox1.Controls.Add(this.rbDragVertex);
            this.groupBox1.Controls.Add(this.rbDelVertex);
            this.groupBox1.Location = new System.Drawing.Point(691, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режимы";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(693, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(693, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 25);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Вершин: ";
            // 
            // lbNumVertex
            // 
            this.lbNumVertex.AutoSize = true;
            this.lbNumVertex.Location = new System.Drawing.Point(743, 190);
            this.lbNumVertex.Name = "lbNumVertex";
            this.lbNumVertex.Size = new System.Drawing.Size(13, 13);
            this.lbNumVertex.TabIndex = 10;
            this.lbNumVertex.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Связей:";
            // 
            // lbNumLinks
            // 
            this.lbNumLinks.AutoSize = true;
            this.lbNumLinks.Location = new System.Drawing.Point(744, 207);
            this.lbNumLinks.Name = "lbNumLinks";
            this.lbNumLinks.Size = new System.Drawing.Size(13, 13);
            this.lbNumLinks.TabIndex = 12;
            this.lbNumLinks.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файдToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файдToolStripMenuItem
            // 
            this.файдToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйГрафToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.сохранитьВBMPToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файдToolStripMenuItem.Name = "файдToolStripMenuItem";
            this.файдToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файдToolStripMenuItem.Text = "Файл";
            // 
            // новыйГрафToolStripMenuItem
            // 
            this.новыйГрафToolStripMenuItem.Name = "новыйГрафToolStripMenuItem";
            this.новыйГрафToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.новыйГрафToolStripMenuItem.Text = "Новый граф";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьВBMPToolStripMenuItem
            // 
            this.сохранитьВBMPToolStripMenuItem.Name = "сохранитьВBMPToolStripMenuItem";
            this.сохранитьВBMPToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.сохранитьВBMPToolStripMenuItem.Text = "Сохранить в BMP";
            this.сохранитьВBMPToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВBMPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.dgv);
            this.panel.Controls.Add(this.lbCoordinates);
            this.panel.Location = new System.Drawing.Point(12, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(660, 339);
            this.panel.TabIndex = 14;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(419, 188);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(240, 150);
            this.dgv.TabIndex = 1;
            this.dgv.Visible = false;
            // 
            // lbCoordinates
            // 
            this.lbCoordinates.AutoSize = true;
            this.lbCoordinates.Location = new System.Drawing.Point(2, 318);
            this.lbCoordinates.Name = "lbCoordinates";
            this.lbCoordinates.Size = new System.Drawing.Size(28, 13);
            this.lbCoordinates.TabIndex = 0;
            this.lbCoordinates.Text = "(0,0)";
            // 
            // btnShortestPath
            // 
            this.btnShortestPath.Location = new System.Drawing.Point(693, 272);
            this.btnShortestPath.Name = "btnShortestPath";
            this.btnShortestPath.Size = new System.Drawing.Size(180, 25);
            this.btnShortestPath.TabIndex = 15;
            this.btnShortestPath.Text = "Вычислить кратчайший путь";
            this.btnShortestPath.UseVisualStyleBackColor = true;
            this.btnShortestPath.Click += new System.EventHandler(this.btnShortestPath_Click);
            // 
            // btnMinTree
            // 
            this.btnMinTree.Location = new System.Drawing.Point(693, 241);
            this.btnMinTree.Name = "btnMinTree";
            this.btnMinTree.Size = new System.Drawing.Size(180, 25);
            this.btnMinTree.TabIndex = 16;
            this.btnMinTree.Text = "Остовное дерево";
            this.btnMinTree.UseVisualStyleBackColor = true;
            this.btnMinTree.Click += new System.EventHandler(this.btnMinTree_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 378);
            this.Controls.Add(this.btnMinTree);
            this.Controls.Add(this.btnShortestPath);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbNumLinks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNumVertex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphCreator v1.0";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private Form2.DoubleBufferedPanel panel;
        private System.Windows.Forms.RadioButton rbAddVertex;
        private System.Windows.Forms.RadioButton rbDelLink;
        private System.Windows.Forms.RadioButton rbAddLink;
        private System.Windows.Forms.RadioButton rbDragVertex;
        private System.Windows.Forms.RadioButton rbDelVertex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCoordinate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumVertex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNumLinks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйГрафToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВBMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label lbCoordinates;
        private System.Windows.Forms.Button btnShortestPath;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnMinTree;
        //private System.Windows.Forms.Panel panel;
        }
    }