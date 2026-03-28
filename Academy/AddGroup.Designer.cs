namespace Academy
{
    partial class AddGroup
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
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.lbGroupName = new System.Windows.Forms.Label();
            this.lbWeekdays = new System.Windows.Forms.Label();
            this.tbWeekdays = new System.Windows.Forms.TextBox();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.lbDirection = new System.Windows.Forms.Label();
            this.cbDirections = new System.Windows.Forms.ComboBox();
            this.buttonSaveGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(12, 37);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(100, 20);
            this.tbGroupName.TabIndex = 0;
            // 
            // lbGroupName
            // 
            this.lbGroupName.AutoSize = true;
            this.lbGroupName.Location = new System.Drawing.Point(25, 21);
            this.lbGroupName.Name = "lbGroupName";
            this.lbGroupName.Size = new System.Drawing.Size(66, 13);
            this.lbGroupName.TabIndex = 1;
            this.lbGroupName.Text = "group_name";
            // 
            // lbWeekdays
            // 
            this.lbWeekdays.AutoSize = true;
            this.lbWeekdays.Location = new System.Drawing.Point(131, 21);
            this.lbWeekdays.Name = "lbWeekdays";
            this.lbWeekdays.Size = new System.Drawing.Size(55, 13);
            this.lbWeekdays.TabIndex = 3;
            this.lbWeekdays.Text = "weekdays";
            // 
            // tbWeekdays
            // 
            this.tbWeekdays.Location = new System.Drawing.Point(118, 37);
            this.tbWeekdays.Name = "tbWeekdays";
            this.tbWeekdays.Size = new System.Drawing.Size(100, 20);
            this.tbWeekdays.TabIndex = 2;
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Location = new System.Drawing.Point(237, 21);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(52, 13);
            this.lbStartTime.TabIndex = 5;
            this.lbStartTime.Text = "start_time";
            // 
            // tbStartTime
            // 
            this.tbStartTime.Location = new System.Drawing.Point(224, 37);
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(100, 20);
            this.tbStartTime.TabIndex = 4;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(343, 21);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(54, 13);
            this.lbStartDate.TabIndex = 7;
            this.lbStartDate.Text = "start_date";
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(330, 37);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(100, 20);
            this.tbStartDate.TabIndex = 6;
            // 
            // lbDirection
            // 
            this.lbDirection.AutoSize = true;
            this.lbDirection.Location = new System.Drawing.Point(458, 21);
            this.lbDirection.Name = "lbDirection";
            this.lbDirection.Size = new System.Drawing.Size(47, 13);
            this.lbDirection.TabIndex = 8;
            this.lbDirection.Text = "direction";
            // 
            // cbDirections
            // 
            this.cbDirections.FormattingEnabled = true;
            this.cbDirections.Location = new System.Drawing.Point(437, 37);
            this.cbDirections.Name = "cbDirections";
            this.cbDirections.Size = new System.Drawing.Size(273, 21);
            this.cbDirections.TabIndex = 9;
            // 
            // buttonSaveGroup
            // 
            this.buttonSaveGroup.Location = new System.Drawing.Point(581, 67);
            this.buttonSaveGroup.Name = "buttonSaveGroup";
            this.buttonSaveGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveGroup.TabIndex = 10;
            this.buttonSaveGroup.Text = "SaveGroup";
            this.buttonSaveGroup.UseVisualStyleBackColor = true;
            this.buttonSaveGroup.Click += new System.EventHandler(this.buttonSaveGroup_Click);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 102);
            this.Controls.Add(this.buttonSaveGroup);
            this.Controls.Add(this.cbDirections);
            this.Controls.Add(this.lbDirection);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.tbStartTime);
            this.Controls.Add(this.lbWeekdays);
            this.Controls.Add(this.tbWeekdays);
            this.Controls.Add(this.lbGroupName);
            this.Controls.Add(this.tbGroupName);
            this.MaximizeBox = false;
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.Label lbGroupName;
        private System.Windows.Forms.Label lbWeekdays;
        private System.Windows.Forms.TextBox tbWeekdays;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.TextBox tbStartTime;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.Label lbDirection;
        private System.Windows.Forms.ComboBox cbDirections;
        private System.Windows.Forms.Button buttonSaveGroup;
    }
}