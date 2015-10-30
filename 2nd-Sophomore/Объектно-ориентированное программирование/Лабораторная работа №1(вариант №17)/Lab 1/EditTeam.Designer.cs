namespace Lab_1
{
    partial class EditTeam
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
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSportsmenAdd = new System.Windows.Forms.ComboBox();
            this.btnAddSportsman = new System.Windows.Forms.Button();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.cbSchedulesAdd = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSportsmenDelete = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbScheduleDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteSportsman = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            this.cbTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(12, 25);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(224, 21);
            this.cbTeams.TabIndex = 0;
            this.cbTeams.SelectedIndexChanged += new System.EventHandler(this.cbTeams_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose sportsman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose schedule";
            // 
            // cbSportsmenAdd
            // 
            this.cbSportsmenAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSportsmenAdd.FormattingEnabled = true;
            this.cbSportsmenAdd.Location = new System.Drawing.Point(6, 30);
            this.cbSportsmenAdd.Name = "cbSportsmenAdd";
            this.cbSportsmenAdd.Size = new System.Drawing.Size(94, 21);
            this.cbSportsmenAdd.TabIndex = 4;
            // 
            // btnAddSportsman
            // 
            this.btnAddSportsman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSportsman.Location = new System.Drawing.Point(6, 57);
            this.btnAddSportsman.Name = "btnAddSportsman";
            this.btnAddSportsman.Size = new System.Drawing.Size(94, 23);
            this.btnAddSportsman.TabIndex = 6;
            this.btnAddSportsman.Text = "Add sportsman";
            this.btnAddSportsman.UseVisualStyleBackColor = true;
            this.btnAddSportsman.Click += new System.EventHandler(this.btnAddSportsman_Click);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchedule.Location = new System.Drawing.Point(6, 126);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(94, 23);
            this.btnAddSchedule.TabIndex = 8;
            this.btnAddSchedule.Text = "Add schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // cbSchedulesAdd
            // 
            this.cbSchedulesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSchedulesAdd.FormattingEnabled = true;
            this.cbSchedulesAdd.Location = new System.Drawing.Point(6, 99);
            this.cbSchedulesAdd.Name = "cbSchedulesAdd";
            this.cbSchedulesAdd.Size = new System.Drawing.Size(93, 21);
            this.cbSchedulesAdd.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(77, 213);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSportsmenAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddSchedule);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSchedulesAdd);
            this.groupBox1.Controls.Add(this.btnAddSportsman);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 155);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSportsmenDelete);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnDeleteSchedule);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbScheduleDelete);
            this.groupBox2.Controls.Add(this.btnDeleteSportsman);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(127, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 155);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // cbSportsmenDelete
            // 
            this.cbSportsmenDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSportsmenDelete.FormattingEnabled = true;
            this.cbSportsmenDelete.Location = new System.Drawing.Point(6, 30);
            this.cbSportsmenDelete.Name = "cbSportsmenDelete";
            this.cbSportsmenDelete.Size = new System.Drawing.Size(94, 21);
            this.cbSportsmenDelete.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Choose sportsman";
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSchedule.Location = new System.Drawing.Point(6, 126);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(94, 23);
            this.btnDeleteSchedule.TabIndex = 8;
            this.btnDeleteSchedule.Text = "Delete schedule";
            this.btnDeleteSchedule.UseVisualStyleBackColor = true;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Choose schedule";
            // 
            // cbScheduleDelete
            // 
            this.cbScheduleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbScheduleDelete.FormattingEnabled = true;
            this.cbScheduleDelete.Location = new System.Drawing.Point(6, 99);
            this.cbScheduleDelete.Name = "cbScheduleDelete";
            this.cbScheduleDelete.Size = new System.Drawing.Size(93, 21);
            this.cbScheduleDelete.TabIndex = 7;
            // 
            // btnDeleteSportsman
            // 
            this.btnDeleteSportsman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSportsman.Location = new System.Drawing.Point(6, 57);
            this.btnDeleteSportsman.Name = "btnDeleteSportsman";
            this.btnDeleteSportsman.Size = new System.Drawing.Size(94, 23);
            this.btnDeleteSportsman.TabIndex = 6;
            this.btnDeleteSportsman.Text = "Del sportsman";
            this.btnDeleteSportsman.UseVisualStyleBackColor = true;
            this.btnDeleteSportsman.Click += new System.EventHandler(this.btnDeleteSportsman_Click);
            // 
            // EditTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(247, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTeams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTeam";
            this.Load += new System.EventHandler(this.EditTeam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSportsmenAdd;
        private System.Windows.Forms.Button btnAddSportsman;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.ComboBox cbSchedulesAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSportsmenDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbScheduleDelete;
        private System.Windows.Forms.Button btnDeleteSportsman;
    }
}