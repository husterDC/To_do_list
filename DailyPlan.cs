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
                    AJob aJob = new AJob(todayJob[i]);
                    fPanel.Controls.Add(aJob);
                }
            }
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
    }
}
