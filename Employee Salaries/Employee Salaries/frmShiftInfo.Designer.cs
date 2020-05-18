namespace Employee_Salaries
{
    partial class frmShiftInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShiftInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTimeIn = new System.Windows.Forms.ComboBox();
            this.cbInMinutes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOutMinutes = new System.Windows.Forms.ComboBox();
            this.cbTimeOut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHourly = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbInAmOrPm = new System.Windows.Forms.ComboBox();
            this.cbIOutAmOrPm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day:";
            // 
            // cbDay
            // 
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbDay.Location = new System.Drawing.Point(107, 122);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(200, 28);
            this.cbDay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time in:";
            // 
            // cbTimeIn
            // 
            this.cbTimeIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeIn.FormattingEnabled = true;
            this.cbTimeIn.Location = new System.Drawing.Point(107, 169);
            this.cbTimeIn.Name = "cbTimeIn";
            this.cbTimeIn.Size = new System.Drawing.Size(61, 28);
            this.cbTimeIn.TabIndex = 8;
            // 
            // cbInMinutes
            // 
            this.cbInMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInMinutes.FormattingEnabled = true;
            this.cbInMinutes.Location = new System.Drawing.Point(181, 169);
            this.cbInMinutes.Name = "cbInMinutes";
            this.cbInMinutes.Size = new System.Drawing.Size(59, 28);
            this.cbInMinutes.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hourly rate:";
            // 
            // cboOutMinutes
            // 
            this.cboOutMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOutMinutes.FormattingEnabled = true;
            this.cboOutMinutes.Location = new System.Drawing.Point(181, 214);
            this.cboOutMinutes.Name = "cboOutMinutes";
            this.cboOutMinutes.Size = new System.Drawing.Size(59, 28);
            this.cboOutMinutes.TabIndex = 13;
            // 
            // cbTimeOut
            // 
            this.cbTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeOut.FormattingEnabled = true;
            this.cbTimeOut.Location = new System.Drawing.Point(107, 214);
            this.cbTimeOut.Name = "cbTimeOut";
            this.cbTimeOut.Size = new System.Drawing.Size(61, 28);
            this.cbTimeOut.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time out:";
            // 
            // txtHourly
            // 
            this.txtHourly.Location = new System.Drawing.Point(108, 264);
            this.txtHourly.Name = "txtHourly";
            this.txtHourly.Size = new System.Drawing.Size(199, 26);
            this.txtHourly.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Shift Details";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 36);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbInAmOrPm
            // 
            this.cbInAmOrPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInAmOrPm.FormattingEnabled = true;
            this.cbInAmOrPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbInAmOrPm.Location = new System.Drawing.Point(253, 169);
            this.cbInAmOrPm.Name = "cbInAmOrPm";
            this.cbInAmOrPm.Size = new System.Drawing.Size(54, 28);
            this.cbInAmOrPm.TabIndex = 18;
            // 
            // cbIOutAmOrPm
            // 
            this.cbIOutAmOrPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIOutAmOrPm.FormattingEnabled = true;
            this.cbIOutAmOrPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbIOutAmOrPm.Location = new System.Drawing.Point(253, 214);
            this.cbIOutAmOrPm.Name = "cbIOutAmOrPm";
            this.cbIOutAmOrPm.Size = new System.Drawing.Size(54, 28);
            this.cbIOutAmOrPm.TabIndex = 19;
            // 
            // frmShiftInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 392);
            this.Controls.Add(this.cbIOutAmOrPm);
            this.Controls.Add(this.cbInAmOrPm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHourly);
            this.Controls.Add(this.cboOutMinutes);
            this.Controls.Add(this.cbTimeOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbInMinutes);
            this.Controls.Add(this.cbTimeIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmShiftInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chahine Software Solutions";
            this.Load += new System.EventHandler(this.frmShiftInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.ComboBox cbDay;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox cbTimeIn;
        public System.Windows.Forms.ComboBox cbInMinutes;
        public System.Windows.Forms.ComboBox cboOutMinutes;
        public System.Windows.Forms.ComboBox cbTimeOut;
        public System.Windows.Forms.TextBox txtHourly;
        public System.Windows.Forms.ComboBox cbInAmOrPm;
        public System.Windows.Forms.ComboBox cbIOutAmOrPm;
    }
}