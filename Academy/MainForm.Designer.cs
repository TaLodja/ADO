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
            this.cbStudents = new System.Windows.Forms.ComboBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.tabPageDirections = new System.Windows.Forms.TabPage();
            this.dgvDirections = new System.Windows.Forms.DataGridView();
            this.tabPageDisciplines = new System.Windows.Forms.TabPage();
            this.cbDisciplines = new System.Windows.Forms.ComboBox();
            this.dgvDisciplines = new System.Windows.Forms.DataGridView();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbStudentsGroup = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.tabPageDirections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
            this.tabPageDisciplines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
            this.tabPageTeachers.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(546, 406);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.cbStudentsGroup);
            this.tabPageStudents.Controls.Add(this.cbStudents);
            this.tabPageStudents.Controls.Add(this.dgvStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(538, 380);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // cbStudents
            // 
            this.cbStudents.FormattingEnabled = true;
            this.cbStudents.Location = new System.Drawing.Point(6, 6);
            this.cbStudents.Name = "cbStudents";
            this.cbStudents.Size = new System.Drawing.Size(275, 21);
            this.cbStudents.TabIndex = 3;
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
            this.dgvStudents.Size = new System.Drawing.Size(532, 327);
            this.dgvStudents.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.cbGroups);
            this.tabPageGroups.Controls.Add(this.dgvGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(538, 380);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // cbGroups
            // 
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(4, 5);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(275, 21);
            this.cbGroups.TabIndex = 2;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // dgvGroups
            // 
            this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(4, 32);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.Size = new System.Drawing.Size(531, 327);
            this.dgvGroups.TabIndex = 0;
            // 
            // tabPageDirections
            // 
            this.tabPageDirections.Controls.Add(this.dgvDirections);
            this.tabPageDirections.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirections.Name = "tabPageDirections";
            this.tabPageDirections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirections.Size = new System.Drawing.Size(538, 380);
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
            this.dgvDirections.Size = new System.Drawing.Size(570, 301);
            this.dgvDirections.TabIndex = 0;
            // 
            // tabPageDisciplines
            // 
            this.tabPageDisciplines.Controls.Add(this.cbDisciplines);
            this.tabPageDisciplines.Controls.Add(this.dgvDisciplines);
            this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
            this.tabPageDisciplines.Name = "tabPageDisciplines";
            this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisciplines.Size = new System.Drawing.Size(538, 380);
            this.tabPageDisciplines.TabIndex = 3;
            this.tabPageDisciplines.Text = "Disciplines";
            this.tabPageDisciplines.UseVisualStyleBackColor = true;
            // 
            // cbDisciplines
            // 
            this.cbDisciplines.FormattingEnabled = true;
            this.cbDisciplines.Location = new System.Drawing.Point(8, 7);
            this.cbDisciplines.Name = "cbDisciplines";
            this.cbDisciplines.Size = new System.Drawing.Size(275, 21);
            this.cbDisciplines.TabIndex = 4;
            this.cbDisciplines.SelectedIndexChanged += new System.EventHandler(this.cbDisciplines_SelectedIndexChanged);
            // 
            // dgvDisciplines
            // 
            this.dgvDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplines.Location = new System.Drawing.Point(4, 34);
            this.dgvDisciplines.Name = "dgvDisciplines";
            this.dgvDisciplines.Size = new System.Drawing.Size(531, 325);
            this.dgvDisciplines.TabIndex = 0;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Controls.Add(this.dgvTeachers);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(538, 380);
            this.tabPageTeachers.TabIndex = 4;
            this.tabPageTeachers.Text = "Teachers";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(4, 31);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(559, 304);
            this.dgvTeachers.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 384);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(546, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // cbStudentsGroup
            // 
            this.cbStudentsGroup.FormattingEnabled = true;
            this.cbStudentsGroup.Location = new System.Drawing.Point(305, 6);
            this.cbStudentsGroup.Name = "cbStudentsGroup";
            this.cbStudentsGroup.Size = new System.Drawing.Size(230, 21);
            this.cbStudentsGroup.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 406);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
            this.tabPageTeachers.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.DataGridView dgvDisciplines;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.ComboBox cbStudents;
        private System.Windows.Forms.ComboBox cbDisciplines;
        private System.Windows.Forms.ComboBox cbStudentsGroup;
    }
}

