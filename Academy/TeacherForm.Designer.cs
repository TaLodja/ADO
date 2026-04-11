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
            this.labelRate = new System.Windows.Forms.Label();
            this.labelDisciplines = new System.Windows.Forms.Label();
            this.dgvTeachersDisciplines = new System.Windows.Forms.DataGridView();
            this.cbDisciplines = new System.Windows.Forms.ComboBox();
            this.labelChooseDiscipline = new System.Windows.Forms.Label();
            this.numericUpDownRate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersDisciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Location = new System.Drawing.Point(397, 282);
            // 
            // rtbLastName
            // 
            this.rtbLastName.Location = new System.Drawing.Point(174, 33);
            // 
            // rtbFirstName
            // 
            this.rtbFirstName.Location = new System.Drawing.Point(174, 74);
            // 
            // rtbMiddleName
            // 
            this.rtbMiddleName.Location = new System.Drawing.Point(174, 115);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(174, 156);
            // 
            // rtbEmail
            // 
            this.rtbEmail.Location = new System.Drawing.Point(174, 192);
            // 
            // rtbPhone
            // 
            this.rtbPhone.Location = new System.Drawing.Point(174, 233);
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(136, 366);
            // 
            // labelWorkSince
            // 
            this.labelWorkSince.AutoSize = true;
            this.labelWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkSince.Location = new System.Drawing.Point(55, 279);
            this.labelWorkSince.Name = "labelWorkSince";
            this.labelWorkSince.Size = new System.Drawing.Size(115, 24);
            this.labelWorkSince.TabIndex = 12;
            this.labelWorkSince.Text = "Работает с:";
            // 
            // dtpWorkSince
            // 
            this.dtpWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkSince.Location = new System.Drawing.Point(177, 282);
            this.dtpWorkSince.Name = "dtpWorkSince";
            this.dtpWorkSince.Size = new System.Drawing.Size(208, 29);
            this.dtpWorkSince.TabIndex = 13;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(397, 361);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(167, 35);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(234, 361);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(151, 35);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRate.Location = new System.Drawing.Point(90, 324);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(78, 24);
            this.labelRate.TabIndex = 20;
            this.labelRate.Text = "Ставка:";
            // 
            // labelDisciplines
            // 
            this.labelDisciplines.AutoSize = true;
            this.labelDisciplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisciplines.Location = new System.Drawing.Point(12, 409);
            this.labelDisciplines.Name = "labelDisciplines";
            this.labelDisciplines.Size = new System.Drawing.Size(0, 24);
            this.labelDisciplines.TabIndex = 22;
            // 
            // dgvTeachersDisciplines
            // 
            this.dgvTeachersDisciplines.AllowUserToAddRows = false;
            this.dgvTeachersDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTeachersDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachersDisciplines.Location = new System.Drawing.Point(11, 436);
            this.dgvTeachersDisciplines.Name = "dgvTeachersDisciplines";
            this.dgvTeachersDisciplines.ReadOnly = true;
            this.dgvTeachersDisciplines.Size = new System.Drawing.Size(552, 88);
            this.dgvTeachersDisciplines.TabIndex = 23;
            // 
            // cbDisciplines
            // 
            this.cbDisciplines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDisciplines.FormattingEnabled = true;
            this.cbDisciplines.Location = new System.Drawing.Point(11, 554);
            this.cbDisciplines.Name = "cbDisciplines";
            this.cbDisciplines.Size = new System.Drawing.Size(552, 24);
            this.cbDisciplines.TabIndex = 24;
            this.cbDisciplines.SelectedIndexChanged += new System.EventHandler(this.cbDisciplines_SelectedIndexChanged);
            // 
            // labelChooseDiscipline
            // 
            this.labelChooseDiscipline.AutoSize = true;
            this.labelChooseDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseDiscipline.Location = new System.Drawing.Point(12, 527);
            this.labelChooseDiscipline.Name = "labelChooseDiscipline";
            this.labelChooseDiscipline.Size = new System.Drawing.Size(216, 24);
            this.labelChooseDiscipline.TabIndex = 26;
            this.labelChooseDiscipline.Text = "Добавить дисциплину:";
            // 
            // numericUpDownRate
            // 
            this.numericUpDownRate.DecimalPlaces = 4;
            this.numericUpDownRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRate.Location = new System.Drawing.Point(177, 327);
            this.numericUpDownRate.Name = "numericUpDownRate";
            this.numericUpDownRate.Size = new System.Drawing.Size(208, 29);
            this.numericUpDownRate.TabIndex = 27;
            this.numericUpDownRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 600);
            this.Controls.Add(this.numericUpDownRate);
            this.Controls.Add(this.labelChooseDiscipline);
            this.Controls.Add(this.cbDisciplines);
            this.Controls.Add(this.dgvTeachersDisciplines);
            this.Controls.Add(this.labelDisciplines);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dtpWorkSince);
            this.Controls.Add(this.labelWorkSince);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Controls.SetChildIndex(this.labelID, 0);
            this.Controls.SetChildIndex(this.rtbLastName, 0);
            this.Controls.SetChildIndex(this.rtbFirstName, 0);
            this.Controls.SetChildIndex(this.rtbMiddleName, 0);
            this.Controls.SetChildIndex(this.dtpBirthDate, 0);
            this.Controls.SetChildIndex(this.rtbEmail, 0);
            this.Controls.SetChildIndex(this.rtbPhone, 0);
            this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
            this.Controls.SetChildIndex(this.buttonPhoto, 0);
            this.Controls.SetChildIndex(this.labelWorkSince, 0);
            this.Controls.SetChildIndex(this.dtpWorkSince, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.labelRate, 0);
            this.Controls.SetChildIndex(this.labelDisciplines, 0);
            this.Controls.SetChildIndex(this.dgvTeachersDisciplines, 0);
            this.Controls.SetChildIndex(this.cbDisciplines, 0);
            this.Controls.SetChildIndex(this.labelChooseDiscipline, 0);
            this.Controls.SetChildIndex(this.numericUpDownRate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachersDisciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWorkSince;
        private System.Windows.Forms.DateTimePicker dtpWorkSince;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelDisciplines;
        private System.Windows.Forms.DataGridView dgvTeachersDisciplines;
        private System.Windows.Forms.ComboBox cbDisciplines;
        private System.Windows.Forms.Label labelChooseDiscipline;
        private System.Windows.Forms.NumericUpDown numericUpDownRate;
    }
}