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
    public partial class DailyPlan : Form
    {
        private DateTime date;

        private PlanData job;

        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();
            this.Date = date;
            this.Job = job;           
            panelJob.Controls.Add(fPanel);
            fPanel.Width = panelJob.Width;
            fPanel.Height = panelJob.Height;
            
            dateTimePickerDate.Value = date;
        }

        public DateTime Date { get => date; set => date = value; }
        public PlanData Job { get => job; set => job = value; }


        void ShowJobByDate(DateTime date)
        {
            
            fPanel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<PlanItem> todayJob = GetJobByDate(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);
                    
                }
            }
        }

        void AddJob(PlanItem job)
        {
            AJob aJob = new AJob(job);
            aJob.Edited += AJob_Edited;
            aJob.Deleted += AJob_Deleted;
            fPanel.Controls.Add(aJob);
        }
        private void AJob_Deleted(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlanItem job = uc.Job;

            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        private void AJob_Edited(object sender, EventArgs e)
        {
            
        }

        List<PlanItem> GetJobByDate(DateTime date)
        {
            return Job.Job.Where(d=>d.Date.Year == date.Year && d.Date.Month == date.Month && d.Date.Day == date.Day).ToList();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddDays(-1);
        }

        private void btnNextday_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddDays(1);
        }

        private void addJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            PlanItem item = new PlanItem() { Date = dateTimePickerDate.Value };
            Job.Job.Add(item);
            AddJob(item);
        }

        private void TodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = DateTime.Now;
        }
    }
}
