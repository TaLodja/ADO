namespace Academy
{
    partial class HumanForm
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
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.rtbLastName = new System.Windows.Forms.RichTextBox();
            this.rtbFirstName = new System.Windows.Forms.RichTextBox();
            this.rtbMiddleName = new System.Windows.Forms.RichTextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(74, 43);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(96, 24);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(138, 13);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(32, 24);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(119, 83);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(51, 24);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Имя:";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(67, 123);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(103, 24);
            this.labelMiddleName.TabIndex = 3;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthDate.Location = new System.Drawing.Point(15, 163);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(155, 24);
            this.labelBirthDate.TabIndex = 4;
            this.labelBirthDate.Text = "Дата рождения:";
            // 
            // rtbLastName
            // 
            this.rtbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbLastName.Location = new System.Drawing.Point(174, 43);
            this.rtbLastName.Multiline = false;
            this.rtbLastName.Name = "rtbLastName";
            this.rtbLastName.Size = new System.Drawing.Size(211, 34);
            this.rtbLastName.TabIndex = 5;
            this.rtbLastName.Text = "";
            // 
            // rtbFirstName
            // 
            this.rtbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbFirstName.Location = new System.Drawing.Point(174, 83);
            this.rtbFirstName.Multiline = false;
            this.rtbFirstName.Name = "rtbFirstName";
            this.rtbFirstName.Size = new System.Drawing.Size(211, 34);
            this.rtbFirstName.TabIndex = 7;
            this.rtbFirstName.Text = "";
            // 
            // rtbMiddleName
            // 
            this.rtbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMiddleName.Location = new System.Drawing.Point(174, 123);
            this.rtbMiddleName.Multiline = false;
            this.rtbMiddleName.Name = "rtbMiddleName";
            this.rtbMiddleName.Size = new System.Drawing.Size(211, 34);
            this.rtbMiddleName.TabIndex = 8;
            this.rtbMiddleName.Text = "";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(174, 163);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpBirthDate.Size = new System.Drawing.Size(211, 29);
            this.dtpBirthDate.TabIndex = 9;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(397, 13);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(143, 179);
            this.pictureBoxPhoto.TabIndex = 10;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhoto.Location = new System.Drawing.Point(397, 205);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(143, 34);
            this.buttonPhoto.TabIndex = 11;
            this.buttonPhoto.Text = "Обзор";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            // 
            // HumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 250);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.rtbMiddleName);
            this.Controls.Add(this.rtbFirstName);
            this.Controls.Add(this.rtbLastName);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HumanForm";
            this.Text = "Human";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelBirthDate;
        protected System.Windows.Forms.PictureBox pictureBoxPhoto;
        protected System.Windows.Forms.Button buttonPhoto;
        protected System.Windows.Forms.RichTextBox rtbLastName;
        protected System.Windows.Forms.RichTextBox rtbFirstName;
        protected System.Windows.Forms.RichTextBox rtbMiddleName;
        protected System.Windows.Forms.DateTimePicker dtpBirthDate;
    }
}