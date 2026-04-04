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
            this.rtbEmail = new System.Windows.Forms.RichTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.rtbPhone = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.labelBirthDate.Location = new System.Drawing.Point(7, 163);
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
            this.pictureBoxPhoto.Size = new System.Drawing.Size(167, 255);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 10;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhoto.Location = new System.Drawing.Point(397, 286);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(167, 34);
            this.buttonPhoto.TabIndex = 11;
            this.buttonPhoto.Text = "Обзор";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // rtbEmail
            // 
            this.rtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbEmail.Location = new System.Drawing.Point(174, 198);
            this.rtbEmail.Multiline = false;
            this.rtbEmail.Name = "rtbEmail";
            this.rtbEmail.Size = new System.Drawing.Size(211, 34);
            this.rtbEmail.TabIndex = 13;
            this.rtbEmail.Text = "";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(100, 198);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(62, 24);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email:";
            // 
            // rtbPhone
            // 
            this.rtbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbPhone.Location = new System.Drawing.Point(174, 238);
            this.rtbPhone.Multiline = false;
            this.rtbPhone.Name = "rtbPhone";
            this.rtbPhone.Size = new System.Drawing.Size(211, 34);
            this.rtbPhone.TabIndex = 15;
            this.rtbPhone.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Телефон:";
            // 
            // HumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 335);
            this.Controls.Add(this.rtbPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbEmail);
            this.Controls.Add(this.labelEmail);
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
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelBirthDate;
        protected System.Windows.Forms.PictureBox pictureBoxPhoto;
        protected System.Windows.Forms.Button buttonPhoto;
        protected System.Windows.Forms.RichTextBox rtbLastName;
        protected System.Windows.Forms.RichTextBox rtbFirstName;
        protected System.Windows.Forms.RichTextBox rtbMiddleName;
        protected System.Windows.Forms.DateTimePicker dtpBirthDate;
        protected System.Windows.Forms.RichTextBox rtbEmail;
        private System.Windows.Forms.Label labelEmail;
        protected System.Windows.Forms.RichTextBox rtbPhone;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label labelID;
    }
}