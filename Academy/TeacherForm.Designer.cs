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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
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
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 257);
            this.Controls.Add(this.dtpWorkSince);
            this.Controls.Add(this.labelWorkSince);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
            this.Controls.SetChildIndex(this.buttonPhoto, 0);
            this.Controls.SetChildIndex(this.labelWorkSince, 0);
            this.Controls.SetChildIndex(this.dtpWorkSince, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWorkSince;
        private System.Windows.Forms.DateTimePicker dtpWorkSince;
    }
}