namespace To_do_list
{
    partial class DailyPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelJob = new System.Windows.Forms.Panel();
            this.panelDate = new System.Windows.Forms.Panel();
            this.btnNextday = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.addJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelJob);
            this.panel1.Controls.Add(this.panelDate);
            this.panel1.Location = new System.Drawing.Point(13, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 546);
            this.panel1.TabIndex = 0;
            // 
            // panelJob
            // 
            this.panelJob.Location = new System.Drawing.Point(3, 50);
            this.panelJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelJob.Name = "panelJob";
            this.panelJob.Size = new System.Drawing.Size(899, 491);
            this.panelJob.TabIndex = 1;
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.btnNextday);
            this.panelDate.Controls.Add(this.btnYesterday);
            this.panelDate.Controls.Add(this.dateTimePickerDate);
            this.panelDate.Location = new System.Drawing.Point(3, 2);
            this.panelDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(899, 43);
            this.panelDate.TabIndex = 0;
            // 
            // btnNextday
            // 
            this.btnNextday.Location = new System.Drawing.Point(576, 9);
            this.btnNextday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextday.Name = "btnNextday";
            this.btnNextday.Size = new System.Drawing.Size(112, 26);
            this.btnNextday.TabIndex = 2;
            this.btnNextday.Text = "Ngày mai";
            this.btnNextday.UseVisualStyleBackColor = true;
            this.btnNextday.Click += new System.EventHandler(this.btnNextday_Click);
            // 
            // btnYesterday
            // 
            this.btnYesterday.Location = new System.Drawing.Point(212, 9);
            this.btnYesterday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(112, 26);
            this.btnYesterday.TabIndex = 1;
            this.btnYesterday.Text = "Hôm qua";
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(351, 10);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addJobToolStripMenuItem,
            this.TodayToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(929, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // addJobToolStripMenuItem
            // 
            this.addJobToolStripMenuItem.Name = "addJobToolStripMenuItem";
            this.addJobToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.addJobToolStripMenuItem.Text = "Thêm việc";
            // 
            // TodayToolStripMenuItem
            // 
            this.TodayToolStripMenuItem.Name = "TodayToolStripMenuItem";
            this.TodayToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.TodayToolStripMenuItem.Text = "Hôm nay";
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch trong ngày";
            this.panel1.ResumeLayout(false);
            this.panelDate.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelJob;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem addJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TodayToolStripMenuItem;
        private System.Windows.Forms.Button btnNextday;
        private System.Windows.Forms.Button btnYesterday;
    }
}