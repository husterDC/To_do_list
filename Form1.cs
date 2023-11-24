using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace To_do_list
{
    public partial class Form1 : Form
    {
        

        private string filePath = "data.XML";
        private string filePath2 = "dataNotify.XML";

        private List<List<Button>> Matrix;

        private List<string> DateOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        private PlanData job;

        private int appTime;

        
        

        public List<List<Button>> Matrix1 { get => Matrix; set => Matrix = value; }
        public PlanData Job { get => job; set => job = value; }
        public int AppTime { get => appTime; set => appTime = value; }
        

        public Form1()
        {
            InitializeComponent();
            LoadMatrix();

            //Đăng kí khởi chạy cùng window
            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\To_do_list");
            //mo registry khoi dong cung win
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            //string subkey = "Software\\ManhQuyen";
            try
            {
                //chen gia tri key
                regkey.SetValue("Index", keyvalue);
                //regstart.SetValue("taoregistrytronghethong", "E:\\Studing\\Bai Tap\\CSharp\\Channel 4\\bai temp\\tao registry trong he thong\\tao registry trong he thong\\bin\\Debug\\tao registry trong he thong.exe");
                regstart.SetValue("To_do_list", Application.StartupPath + "\\To_do_list.exe");
                ////dong tien trinh ghi key
                //regkey.Close();
            }
            catch (System.Exception ex)
            {
            }
            timerNotify.Start();
            appTime = 0;

            
            try
            {
                Job = DeseializeFromXML(filePath) as PlanData;
                if (Job == null)
                {
                    Job = new PlanData();
                    Job.Job = new List<PlanItem>();
                }
            } catch 
            {
                SetDefaultJob();
            }
        }

        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
        }
        void LoadMatrix()
        {
            Matrix1 = new List<List<Button>>();
            Button oldBtn = new Button() { Width = -Const.dateBtnMargin, Height = 0, Location = new Point(0,0) };
            for (int i = 0; i < Const.DayOfColumn; i++)
            {
                Matrix1.Add(new List<Button>());
                for(int j = 0; j < Const.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Const.dateBtnWidth , Height = Const.dateBtnHeigth };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Const.dateBtnMargin, oldBtn.Location.Y);
                    panelMatrix.Controls.Add(btn);
                    oldBtn = btn;
                    Matrix1[i].Add(btn);
                }

                oldBtn = new Button() { Width = -Const.dateBtnMargin, Height = 0, Location = new Point(0, oldBtn.Location.Y + oldBtn.Height + Const.dateBtnMargin) };
            }
            SetDefaulDate();
        }
        int DayOfMonth(DateTime date)
        {
            switch(date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if (date.Year % 4 == 0 && date.Year % 100 != 0 || date.Year % 400 == 0)
                    {
                        return 29;
                    } else
                        return 28;
                default:
                    return 30;
            }
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearValueMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                btn.Click += Btn_Click;

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Violet;
                }

                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Aqua;
                }
               
                if (column >= 6)
                {
                    line++;
                }

                useDate = useDate.AddDays(1);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            DailyPlan daily = new DailyPlan(new DateTime(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            daily.ShowDialog();
        }

        bool isEqualDate(DateTime date1, DateTime date2)
        {
            if (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day)
            {
                return true;
            }
            return false;
        }
        void ClearValueMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }
        void SetDefaulDate()
        {
            dateTimePickerDate.Value = DateTime.Now;
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void Today_Click(object sender, EventArgs e)
        {
            SetDefaulDate();
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddMonths(-1);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddMonths(1);
        }

        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            sr.Serialize(fs, data);

            fs.Close();

        }

        private object DeseializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;

                
            } catch (Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
            }           
            
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(job, filePath);
        }

        private void timerNotify_Tick(object sender, EventArgs e)
        {
            if (!checkBoxNotify.Checked)
                return;
            AppTime++;
            if (AppTime == 1 || AppTime < Const.notifyTime)
                return;
            if (Job == null || Job.Job == null)
                return;
            DateTime today = DateTime.Now;
            List<PlanItem> todayJob = Job.Job.Where(p=>p.Date.Year == today.Year && p.Date.Month == today.Month && p.Date.Day == today.Day).ToList();
            List<PlanItem> todayJobDoing = todayJob.Where(p => p.Status == "Doing").ToList();
            List<PlanItem> todayJobComing = Job.Job.Where(p => p.Status == "Coming").ToList();
            Notify.ShowBalloonTip(Const.notifyTimeOut, "Lịch trình công việc", string.Format("Bạn có {0} việc cần làm trong ngày hôm nay\n{1} việc chưa hoàn thành.\n{2} việc sắp tới.", todayJob.Count, todayJobDoing.Count, todayJobComing.Count), ToolTipIcon.Info);

            AppTime = 0;
        }

        private void checkBoxNotify_CheckedChanged(object sender, EventArgs e)
        {
            nUDNotify.Enabled = checkBoxNotify.Checked;
        }

        private void nUDNotify_ValueChanged(object sender, EventArgs e)
        {
            Const.notifyTime = (int)nUDNotify.Value;
            
        }
    }
}
