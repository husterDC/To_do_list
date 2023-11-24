namespace To_do_list
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nUDNotify = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNotify = new System.Windows.Forms.CheckBox();
            this.Today = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMatrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnTuseday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNotify)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 617);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.Today);
            this.panel3.Controls.Add(this.dateTimePickerDate);
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1023, 54);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nUDNotify);
            this.panel6.Controls.Add(this.checkBoxNotify);
            this.panel6.Location = new System.Drawing.Point(3, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 47);
            this.panel6.TabIndex = 2;
            // 
            // nUDNotify
            // 
            this.nUDNotify.Location = new System.Drawing.Point(131, 10);
            this.nUDNotify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUDNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDNotify.Name = "nUDNotify";
            this.nUDNotify.Size = new System.Drawing.Size(67, 22);
            this.nUDNotify.TabIndex = 3;
            this.nUDNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDNotify.ValueChanged += new System.EventHandler(this.nUDNotify_ValueChanged);
            // 
            // checkBoxNotify
            // 
            this.checkBoxNotify.AutoSize = true;
            this.checkBoxNotify.Checked = true;
            this.checkBoxNotify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNotify.Location = new System.Drawing.Point(16, 11);
            this.checkBoxNotify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxNotify.Name = "checkBoxNotify";
            this.checkBoxNotify.Size = new System.Drawing.Size(95, 20);
            this.checkBoxNotify.TabIndex = 3;
            this.checkBoxNotify.Text = "Thông báo";
            this.checkBoxNotify.UseVisualStyleBackColor = true;
            this.checkBoxNotify.CheckedChanged += new System.EventHandler(this.checkBoxNotify_CheckedChanged);
            // 
            // Today
            // 
            this.Today.Location = new System.Drawing.Point(669, 7);
            this.Today.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(81, 34);
            this.Today.TabIndex = 1;
            this.Today.Text = "Hôm nay";
            this.Today.UseVisualStyleBackColor = true;
            this.Today.Click += new System.EventHandler(this.Today_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(373, 16);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(267, 22);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelMatrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 551);
            this.panel2.TabIndex = 0;
            // 
            // panelMatrix
            // 
            this.panelMatrix.Location = new System.Drawing.Point(133, 76);
            this.panelMatrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMatrix.Name = "panelMatrix";
            this.panelMatrix.Size = new System.Drawing.Size(743, 458);
            this.panelMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNextMonth);
            this.panel4.Controls.Add(this.btnPreviousMonth);
            this.panel4.Controls.Add(this.btnSunday);
            this.panel4.Controls.Add(this.btnSaturday);
            this.panel4.Controls.Add(this.btnFriday);
            this.panel4.Controls.Add(this.btnThursday);
            this.panel4.Controls.Add(this.btnWednesday);
            this.panel4.Controls.Add(this.btnTuseday);
            this.panel4.Controls.Add(this.btnMonday);
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1020, 66);
            this.panel4.TabIndex = 0;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(901, 2);
            this.btnNextMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(101, 64);
            this.btnNextMonth.TabIndex = 10;
            this.btnNextMonth.Text = "Tháng sau";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.Location = new System.Drawing.Point(16, 2);
            this.btnPreviousMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(101, 64);
            this.btnPreviousMonth.TabIndex = 9;
            this.btnPreviousMonth.Text = "Tháng trước";
            this.btnPreviousMonth.UseVisualStyleBackColor = true;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(773, 2);
            this.btnSunday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(101, 64);
            this.btnSunday.TabIndex = 8;
            this.btnSunday.Text = "Chủ Nhật";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(667, 2);
            this.btnSaturday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(101, 64);
            this.btnSaturday.TabIndex = 7;
            this.btnSaturday.Text = "Thứ 7";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(559, 2);
            this.btnFriday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(101, 64);
            this.btnFriday.TabIndex = 6;
            this.btnFriday.Text = "Thứ 6";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            this.btnThursday.Location = new System.Drawing.Point(452, 2);
            this.btnThursday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(101, 64);
            this.btnThursday.TabIndex = 5;
            this.btnThursday.Text = "Thứ 5";
            this.btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(345, 2);
            this.btnWednesday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(101, 64);
            this.btnWednesday.TabIndex = 4;
            this.btnWednesday.Text = "Thứ 4";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnTuseday
            // 
            this.btnTuseday.Location = new System.Drawing.Point(237, 2);
            this.btnTuseday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTuseday.Name = "btnTuseday";
            this.btnTuseday.Size = new System.Drawing.Size(101, 64);
            this.btnTuseday.TabIndex = 3;
            this.btnTuseday.Text = "Thứ 3";
            this.btnTuseday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(131, 2);
            this.btnMonday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(101, 64);
            this.btnMonday.TabIndex = 2;
            this.btnMonday.Text = "Thứ 2";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // timerNotify
            // 
            this.timerNotify.Enabled = true;
            this.timerNotify.Interval = 60000;
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "To_do_list";
            this.Notify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 641);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNotify)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Today;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Panel panelMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuseday;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nUDNotify;
        private System.Windows.Forms.CheckBox checkBoxNotify;
        private System.Windows.Forms.Timer timerNotify;
        private System.Windows.Forms.NotifyIcon Notify;
    }
}

