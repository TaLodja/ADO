namespace Academy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.buttonStudentsFilterReset = new System.Windows.Forms.Button();
            this.cbStudentsGroup = new System.Windows.Forms.ComboBox();
            this.cbStudentsDirection = new System.Windows.Forms.ComboBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonGroupsFilterReset = new System.Windows.Forms.Button();
            this.cbGroupsDirection = new System.Windows.Forms.ComboBox();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.tabPageDirections = new System.Windows.Forms.TabPage();
            this.dgvDirections = new System.Windows.Forms.DataGridView();
            this.tabPageDisciplines = new System.Windows.Forms.TabPage();
            this.dgvTeachersToDiscipline = new System.Windows.Forms.DataGridView();
            this.buttonDisciplinesFilterReset = new System.Windows.Forms.Button();
            this.cbDisciplinesDirection = new System.Windows.Forms.ComboBox();
            this.dgvDisciplines = new System.Windows.Forms.DataGridView();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.dgvDisciplinesToTeacher = new System.Windows.Forms.DataGridView();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.tabPageDirections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
            this.tabPageDisciplines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersToDiscipline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
            this.tabPageTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinesToTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStudents);
            this.tabControl.Controls.Add(this.tabPageGroups);
            this.tabControl.Controls.Add(this.tabPageDirections);
            this.tabControl.Controls.Add(this.tabPageDisciplines);
            this.tabControl.Controls.Add(this.tabPageTeachers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(830, 602);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.buttonStudentsFilterReset);
            this.tabPageStudents.Controls.Add(this.cbStudentsGroup);
            this.tabPageStudents.Controls.Add(this.cbStudentsDirection);
            this.tabPageStudents.Controls.Add(this.dgvStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(822, 576);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // buttonStudentsFilterReset
            // 
            this.buttonStudentsFilterReset.Location = new System.Drawing.Point(698, 7);
            this.buttonStudentsFilterReset.Name = "buttonStudentsFilterReset";
            this.buttonStudentsFilterReset.Size = new System.Drawing.Size(121, 23);
            this.buttonStudentsFilterReset.TabIndex = 4;
            this.buttonStudentsFilterReset.Text = "Filter Reset";
            this.buttonStudentsFilterReset.UseVisualStyleBackColor = true;
            this.buttonStudentsFilterReset.Click += new System.EventHandler(this.buttonStudentsFilterReset_Click);
            // 
            // cbStudentsGroup
            // 
            this.cbStudentsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentsGroup.FormattingEnabled = true;
            this.cbStudentsGroup.Location = new System.Drawing.Point(3, 6);
            this.cbStudentsGroup.Name = "cbStudentsGroup";
            this.cbStudentsGroup.Size = new System.Drawing.Size(187, 21);
            this.cbStudentsGroup.TabIndex = 3;
            this.cbStudentsGroup.SelectedIndexChanged += new System.EventHandler(this.cbStudentsGroup_SelectedIndexChanged);
            // 
            // cbStudentsDirection
            // 
            this.cbStudentsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentsDirection.FormattingEnabled = true;
            this.cbStudentsDirection.Location = new System.Drawing.Point(196, 7);
            this.cbStudentsDirection.Name = "cbStudentsDirection";
            this.cbStudentsDirection.Size = new System.Drawing.Size(455, 21);
            this.cbStudentsDirection.TabIndex = 2;
            this.cbStudentsDirection.SelectedIndexChanged += new System.EventHandler(this.cbStudentsDirection_SelectedIndexChanged);
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(3, 32);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(816, 523);
            this.dgvStudents.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.buttonAddGroup);
            this.tabPageGroups.Controls.Add(this.buttonGroupsFilterReset);
            this.tabPageGroups.Controls.Add(this.cbGroupsDirection);
            this.tabPageGroups.Controls.Add(this.dgvGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(822, 576);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(733, 6);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(81, 23);
            this.buttonAddGroup.TabIndex = 7;
            this.buttonAddGroup.Text = "Add Group";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonGroupsFilterReset
            // 
            this.buttonGroupsFilterReset.Location = new System.Drawing.Point(549, 6);
            this.buttonGroupsFilterReset.Name = "buttonGroupsFilterReset";
            this.buttonGroupsFilterReset.Size = new System.Drawing.Size(81, 23);
            this.buttonGroupsFilterReset.TabIndex = 5;
            this.buttonGroupsFilterReset.Text = "Filter Reset";
            this.buttonGroupsFilterReset.UseVisualStyleBackColor = true;
            this.buttonGroupsFilterReset.Click += new System.EventHandler(this.buttonGroupsFilterReset_Click);
            // 
            // cbGroupsDirection
            // 
            this.cbGroupsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupsDirection.FormattingEnabled = true;
            this.cbGroupsDirection.Location = new System.Drawing.Point(4, 6);
            this.cbGroupsDirection.Name = "cbGroupsDirection";
            this.cbGroupsDirection.Size = new System.Drawing.Size(539, 21);
            this.cbGroupsDirection.TabIndex = 1;
            this.cbGroupsDirection.SelectedIndexChanged += new System.EventHandler(this.cbGroupsDirection_SelectedIndexChanged);
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(4, 32);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.Size = new System.Drawing.Size(815, 493);
            this.dgvGroups.TabIndex = 0;
            this.dgvGroups.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellEnter);
            this.dgvGroups.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellLeave);
            // 
            // tabPageDirections
            // 
            this.tabPageDirections.Controls.Add(this.dgvDirections);
            this.tabPageDirections.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirections.Name = "tabPageDirections";
            this.tabPageDirections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirections.Size = new System.Drawing.Size(822, 576);
            this.tabPageDirections.TabIndex = 2;
            this.tabPageDirections.Text = "Directions";
            this.tabPageDirections.UseVisualStyleBackColor = true;
            // 
            // dgvDirections
            // 
            this.dgvDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDirections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirections.Location = new System.Drawing.Point(0, 34);
            this.dgvDirections.Name = "dgvDirections";
            this.dgvDirections.Size = new System.Drawing.Size(826, 521);
            this.dgvDirections.TabIndex = 0;
            // 
            // tabPageDisciplines
            // 
            this.tabPageDisciplines.Controls.Add(this.dgvTeachersToDiscipline);
            this.tabPageDisciplines.Controls.Add(this.buttonDisciplinesFilterReset);
            this.tabPageDisciplines.Controls.Add(this.cbDisciplinesDirection);
            this.tabPageDisciplines.Controls.Add(this.dgvDisciplines);
            this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
            this.tabPageDisciplines.Name = "tabPageDisciplines";
            this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisciplines.Size = new System.Drawing.Size(822, 576);
            this.tabPageDisciplines.TabIndex = 3;
            this.tabPageDisciplines.Text = "Disciplines";
            this.tabPageDisciplines.UseVisualStyleBackColor = true;
            // 
            // dgvTeachersToDiscipline
            // 
            this.dgvTeachersToDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachersToDiscipline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachersToDiscipline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachersToDiscipline.Location = new System.Drawing.Point(446, 200);
            this.dgvTeachersToDiscipline.Name = "dgvTeachersToDiscipline";
            this.dgvTeachersToDiscipline.Size = new System.Drawing.Size(327, 164);
            this.dgvTeachersToDiscipline.TabIndex = 7;
            // 
            // buttonDisciplinesFilterReset
            // 
            this.buttonDisciplinesFilterReset.Location = new System.Drawing.Point(698, 7);
            this.buttonDisciplinesFilterReset.Name = "buttonDisciplinesFilterReset";
            this.buttonDisciplinesFilterReset.Size = new System.Drawing.Size(121, 23);
            this.buttonDisciplinesFilterReset.TabIndex = 6;
            this.buttonDisciplinesFilterReset.Text = "Filter Reset";
            this.buttonDisciplinesFilterReset.UseVisualStyleBackColor = true;
            this.buttonDisciplinesFilterReset.Click += new System.EventHandler(this.buttonDisciplinesFilterReset_Click);
            // 
            // cbDisciplinesDirection
            // 
            this.cbDisciplinesDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplinesDirection.FormattingEnabled = true;
            this.cbDisciplinesDirection.Location = new System.Drawing.Point(3, 7);
            this.cbDisciplinesDirection.Name = "cbDisciplinesDirection";
            this.cbDisciplinesDirection.Size = new System.Drawing.Size(649, 21);
            this.cbDisciplinesDirection.TabIndex = 3;
            this.cbDisciplinesDirection.SelectedIndexChanged += new System.EventHandler(this.cbDisciplinesDirection_SelectedIndexChanged);
            // 
            // dgvDisciplines
            // 
            this.dgvDisciplines.AllowUserToAddRows = false;
            this.dgvDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplines.Location = new System.Drawing.Point(4, 34);
            this.dgvDisciplines.Name = "dgvDisciplines";
            this.dgvDisciplines.Size = new System.Drawing.Size(815, 521);
            this.dgvDisciplines.TabIndex = 0;
            this.dgvDisciplines.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDisciplines_CellMouseClick);
            this.dgvDisciplines.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDisciplines_CellMouseDown);
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Controls.Add(this.dgvDisciplinesToTeacher);
            this.tabPageTeachers.Controls.Add(this.dgvTeachers);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(822, 576);
            this.tabPageTeachers.TabIndex = 4;
            this.tabPageTeachers.Text = "Teachers";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // dgvDisciplinesToTeacher
            // 
            this.dgvDisciplinesToTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisciplinesToTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisciplinesToTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinesToTeacher.Location = new System.Drawing.Point(395, 189);
            this.dgvDisciplinesToTeacher.Name = "dgvDisciplinesToTeacher";
            this.dgvDisciplinesToTeacher.Size = new System.Drawing.Size(409, 162);
            this.dgvDisciplinesToTeacher.TabIndex = 1;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(4, 31);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(815, 524);
            this.dgvTeachers.TabIndex = 0;
            this.dgvTeachers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTeachers_CellMouseClick);
            this.dgvTeachers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTeachers_CellMouseDown);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 580);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(830, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 602);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academy SPU_411";
            this.tabControl.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabPageGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.tabPageDirections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).EndInit();
            this.tabPageDisciplines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersToDiscipline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
            this.tabPageTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinesToTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabPage tabPageDirections;
        private System.Windows.Forms.TabPage tabPageDisciplines;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.DataGridView dgvDirections;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvDisciplines;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.ComboBox cbGroupsDirection;
        private System.Windows.Forms.ComboBox cbStudentsDirection;
        private System.Windows.Forms.ComboBox cbDisciplinesDirection;
        private System.Windows.Forms.ComboBox cbStudentsGroup;
        private System.Windows.Forms.Button buttonStudentsFilterReset;
        private System.Windows.Forms.Button buttonGroupsFilterReset;
        private System.Windows.Forms.Button buttonDisciplinesFilterReset;
        private System.Windows.Forms.DataGridView dgvTeachersToDiscipline;
        private System.Windows.Forms.DataGridView dgvDisciplinesToTeacher;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Button buttonAddGroup;
    }
}

