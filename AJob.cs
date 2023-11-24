using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_do_list
{
    public partial class AJob : UserControl
    {
        private PlanItem job;
        public AJob(PlanItem job)
        {
            InitializeComponent();

            cbStatus.DataSource = PlanItem.ListStatus;

            this.Job = job;

            ShowInfo();
        }

        public PlanItem Job { get => job; set => job = value; }

        void ShowInfo()
        {
            textbJob.Text = Job.Job;
            nUDFromHour.Value = Job.FromTime.X;
            nUDFromMinute.Value = Job.FromTime.Y;
            nUDToHour.Value = Job.ToTime.X;
            nUDToMinute.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);

            checkBoxDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.Done ? true : false;

        }

        private event EventHandler edited;

        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }


        private event EventHandler deleted;

        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
            {
                deleted(this, new EventArgs());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Job.Job = textbJob.Text;
            Job.FromTime = new Point((int)nUDFromHour.Value, (int)nUDFromMinute.Value);
            Job.ToTime = new Point((int)nUDToHour.Value, (int)nUDToMinute.Value);
            Job.Status = PlanItem.ListStatus[cbStatus.SelectedIndex];

            if (edited != null)
            {
                edited(this, new EventArgs());
            }
        }

        private void checkBoxDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = checkBoxDone.Checked ? (int)EPlanItem.Done : (int)EPlanItem.Doing;
        }
    }
}
