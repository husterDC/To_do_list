namespace To_do_list
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.textbJob = new System.Windows.Forms.TextBox();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nUDToMinute = new System.Windows.Forms.NumericUpDown();
            this.nUDToHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDFromMinute = new System.Windows.Forms.NumericUpDown();
            this.nUDFromHour = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDToHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFromHour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.textbJob);
            this.panel1.Controls.Add(this.checkBoxDone);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 24);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(622, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 19);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(571, 2);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 19);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(494, 1);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(73, 21);
            this.cbStatus.TabIndex = 2;
            // 
            // textbJob
            // 
            this.textbJob.Location = new System.Drawing.Point(28, 2);
            this.textbJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbJob.Name = "textbJob";
            this.textbJob.Size = new System.Drawing.Size(294, 20);
            this.textbJob.TabIndex = 1;
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.Location = new System.Drawing.Point(9, 5);
            this.checkBoxDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDone.TabIndex = 0;
            this.checkBoxDone.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nUDToMinute);
            this.panel2.Controls.Add(this.nUDToHour);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nUDFromMinute);
            this.panel2.Controls.Add(this.nUDFromHour);
            this.panel2.Location = new System.Drawing.Point(328, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 24);
            this.panel2.TabIndex = 1;
            // 
            // nUDToMinute
            // 
            this.nUDToMinute.Location = new System.Drawing.Point(128, 2);
            this.nUDToMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nUDToMinute.Name = "nUDToMinute";
            this.nUDToMinute.Size = new System.Drawing.Size(28, 20);
            this.nUDToMinute.TabIndex = 4;
            // 
            // nUDToHour
            // 
            this.nUDToHour.Location = new System.Drawing.Point(95, 2);
            this.nUDToHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nUDToHour.Name = "nUDToHour";
            this.nUDToHour.Size = new System.Drawing.Size(28, 20);
            this.nUDToHour.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đến";
            // 
            // nUDFromMinute
            // 
            this.nUDFromMinute.Location = new System.Drawing.Point(36, 2);
            this.nUDFromMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nUDFromMinute.Name = "nUDFromMinute";
            this.nUDFromMinute.Size = new System.Drawing.Size(28, 20);
            this.nUDFromMinute.TabIndex = 1;
            // 
            // nUDFromHour
            // 
            this.nUDFromHour.Location = new System.Drawing.Point(3, 3);
            this.nUDFromHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nUDFromHour.Name = "nUDFromHour";
            this.nUDFromHour.Size = new System.Drawing.Size(28, 20);
            this.nUDFromHour.TabIndex = 0;
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(677, 28);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDToHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFromHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textbJob;
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nUDToMinute;
        private System.Windows.Forms.NumericUpDown nUDToHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDFromMinute;
        private System.Windows.Forms.NumericUpDown nUDFromHour;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
