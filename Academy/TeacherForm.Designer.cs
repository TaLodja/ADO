namespace Academy
{
    partial class TeacherForm
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
            this.labelWorkSince = new System.Windows.Forms.Label();
            this.dtpWorkSince = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.dgvDisciplinesToTeacher = new System.Windows.Forms.DataGridView();
            this.labelDisciplines = new System.Windows.Forms.Label();
            this.cbTeachersDiscipline = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinesToTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Location = new System.Drawing.Point(397, 207);
            // 
            // labelWorkSince
            // 
            this.labelWorkSince.AutoSize = true;
            this.labelWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkSince.Location = new System.Drawing.Point(55, 205);
            this.labelWorkSince.Name = "labelWorkSince";
            this.labelWorkSince.Size = new System.Drawing.Size(115, 24);
            this.labelWorkSince.TabIndex = 12;
            this.labelWorkSince.Text = "Работает с:";
            // 
            // dtpWorkSince
            // 
            this.dtpWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkSince.Location = new System.Drawing.Point(177, 208);
            this.dtpWorkSince.Name = "dtpWorkSince";
            this.dtpWorkSince.Size = new System.Drawing.Size(208, 29);
            this.dtpWorkSince.TabIndex = 13;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(397, 487);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(143, 35);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(249, 487);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(136, 35);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // dgvDisciplinesToTeacher
            // 
            this.dgvDisciplinesToTeacher.AllowUserToAddRows = false;
            this.dgvDisciplinesToTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDisciplinesToTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinesToTeacher.Location = new System.Drawing.Point(3, 276);
            this.dgvDisciplinesToTeacher.Name = "dgvDisciplinesToTeacher";
            this.dgvDisciplinesToTeacher.Size = new System.Drawing.Size(537, 111);
            this.dgvDisciplinesToTeacher.TabIndex = 20;
            // 
            // labelDisciplines
            // 
            this.labelDisciplines.AutoSize = true;
            this.labelDisciplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisciplines.Location = new System.Drawing.Point(15, 249);
            this.labelDisciplines.Name = "labelDisciplines";
            this.labelDisciplines.Size = new System.Drawing.Size(194, 24);
            this.labelDisciplines.TabIndex = 21;
            this.labelDisciplines.Text = "Читает дисциплины:";
            // 
            // cbTeachersDiscipline
            // 
            this.cbTeachersDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTeachersDiscipline.FormattingEnabled = true;
            this.cbTeachersDiscipline.Location = new System.Drawing.Point(3, 394);
            this.cbTeachersDiscipline.Name = "cbTeachersDiscipline";
            this.cbTeachersDiscipline.Size = new System.Drawing.Size(537, 28);
            this.cbTeachersDiscipline.TabIndex = 23;
            this.cbTeachersDiscipline.Text = "Добавить дисциплину";
            this.cbTeachersDiscipline.SelectedIndexChanged += new System.EventHandler(this.cbTeachersDiscipline_SelectedIndexChanged);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 536);
            this.Controls.Add(this.cbTeachersDiscipline);
            this.Controls.Add(this.labelDisciplines);
            this.Controls.Add(this.dgvDisciplinesToTeacher);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dtpWorkSince);
            this.Controls.Add(this.labelWorkSince);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Controls.SetChildIndex(this.labelWorkSince, 0);
            this.Controls.SetChildIndex(this.dtpWorkSince, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.rtbLastName, 0);
            this.Controls.SetChildIndex(this.rtbFirstName, 0);
            this.Controls.SetChildIndex(this.rtbMiddleName, 0);
            this.Controls.SetChildIndex(this.dtpBirthDate, 0);
            this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
            this.Controls.SetChildIndex(this.buttonPhoto, 0);
            this.Controls.SetChildIndex(this.dgvDisciplinesToTeacher, 0);
            this.Controls.SetChildIndex(this.labelDisciplines, 0);
            this.Controls.SetChildIndex(this.cbTeachersDiscipline, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinesToTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWorkSince;
        private System.Windows.Forms.DateTimePicker dtpWorkSince;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DataGridView dgvDisciplinesToTeacher;
        private System.Windows.Forms.Label labelDisciplines;
        private System.Windows.Forms.ComboBox cbTeachersDiscipline;
    }
}