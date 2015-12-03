namespace Lab_1
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSportsmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSportsmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTeamSelector = new System.Windows.Forms.ComboBox();
            this.lvSportsmen = new System.Windows.Forms.ListView();
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeamToolStripMenuItem,
            this.addSportsmanToolStripMenuItem,
            this.addScheduleToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addTeamToolStripMenuItem
            // 
            this.addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            this.addTeamToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addTeamToolStripMenuItem.Text = "Team";
            this.addTeamToolStripMenuItem.Click += new System.EventHandler(this.addTeamToolStripMenuItem_Click);
            // 
            // addSportsmanToolStripMenuItem
            // 
            this.addSportsmanToolStripMenuItem.Name = "addSportsmanToolStripMenuItem";
            this.addSportsmanToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addSportsmanToolStripMenuItem.Text = "Sportsman";
            this.addSportsmanToolStripMenuItem.Click += new System.EventHandler(this.addSportsmanToolStripMenuItem_Click);
            // 
            // addScheduleToolStripMenuItem
            // 
            this.addScheduleToolStripMenuItem.Name = "addScheduleToolStripMenuItem";
            this.addScheduleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addScheduleToolStripMenuItem.Text = "Schedule";
            this.addScheduleToolStripMenuItem.Click += new System.EventHandler(this.addScheduleToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTeamToolStripMenuItem,
            this.editSportsmanToolStripMenuItem,
            this.editScheduleToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // editTeamToolStripMenuItem
            // 
            this.editTeamToolStripMenuItem.Name = "editTeamToolStripMenuItem";
            this.editTeamToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editTeamToolStripMenuItem.Text = "Team";
            this.editTeamToolStripMenuItem.Click += new System.EventHandler(this.editTeamToolStripMenuItem_Click);
            // 
            // editSportsmanToolStripMenuItem
            // 
            this.editSportsmanToolStripMenuItem.Name = "editSportsmanToolStripMenuItem";
            this.editSportsmanToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editSportsmanToolStripMenuItem.Text = "Sportsman";
            // 
            // editScheduleToolStripMenuItem
            // 
            this.editScheduleToolStripMenuItem.Name = "editScheduleToolStripMenuItem";
            this.editScheduleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editScheduleToolStripMenuItem.Text = "Schedule";
            // 
            // cbTeamSelector
            // 
            this.cbTeamSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTeamSelector.FormattingEnabled = true;
            this.cbTeamSelector.Location = new System.Drawing.Point(12, 50);
            this.cbTeamSelector.Name = "cbTeamSelector";
            this.cbTeamSelector.Size = new System.Drawing.Size(189, 21);
            this.cbTeamSelector.TabIndex = 1;
            this.cbTeamSelector.SelectedIndexChanged += new System.EventHandler(this.cbTeamSelector_SelectedIndexChanged);
            // 
            // lvSportsmen
            // 
            this.lvSportsmen.Location = new System.Drawing.Point(12, 90);
            this.lvSportsmen.Name = "lvSportsmen";
            this.lvSportsmen.Size = new System.Drawing.Size(189, 121);
            this.lvSportsmen.TabIndex = 3;
            this.lvSportsmen.UseCompatibleStateImageBehavior = false;
            this.lvSportsmen.View = System.Windows.Forms.View.Details;
            // 
            // lvSchedule
            // 
            this.lvSchedule.Location = new System.Drawing.Point(207, 90);
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(189, 121);
            this.lvSchedule.TabIndex = 4;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sportsmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Schedule";
            // 
            // btnChange
            // 
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(207, 48);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(134, 23);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "View schedules";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 221);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSchedule);
            this.Controls.Add(this.lvSportsmen);
            this.Controls.Add(this.cbTeamSelector);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSportsmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSportsmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editScheduleToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbTeamSelector;
        private System.Windows.Forms.ListView lvSportsmen;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChange;
    }
}

