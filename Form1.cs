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

        private List<List<Button>> Matrix;

        private List<string> DateOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        private PlanData job;

        

        public List<List<Button>> Matrix1 { get => Matrix; set => Matrix = value; }
        public PlanData Job { get => job; set => job = value; }

        public Form1()
        {
            InitializeComponent();
            LoadMatrix();

            try
            {
                Job = DeseializeFromXML(filePath) as PlanData;
            } catch 
            {
                SetDefaultJob();
            }
        }

        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem() 
            { Date = DateTime.Now, 
              FromTime = new Point(4,0),
              ToTime = new Point(5,0),
              Job = "Thử nghiệm1",
              Status = PlanItem.ListStatus[(int)EPlanItem.Coming] 
            });
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now.AddDays(-1),
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thử nghiệm2",
                Status = PlanItem.ListStatus[(int)EPlanItem.Coming]
            });
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thử nghiệm3",
                Status = PlanItem.ListStatus[(int)EPlanItem.Coming]
            });
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now.AddDays(1),
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thử nghiệm4",
                Status = PlanItem.ListStatus[(int)EPlanItem.Coming]
            });
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
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate,FileAccess.Write);
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
            } catch (Exception)
            {
                fs.Close();
                throw new NotImplementedException();
            }
            

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(job, filePath);
        }
    }
}
