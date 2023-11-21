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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMatrix();
        }

        void LoadMatrix()
        {
            Button oldBtn = new Button() { Width = -Const.dateBtnMargin, Height = 0, Location = new Point(0,0) };
            for (int i = 0; i < Const.DayOfColumn; i++)
            {
                for(int j = 0; j < Const.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Const.dateBtnWidth , Height = Const.dateBtnHeigth };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Const.dateBtnMargin, oldBtn.Location.Y);
                    panelMatrix.Controls.Add(btn);
                    oldBtn = btn;
                }

                oldBtn = new Button() { Width = -Const.dateBtnMargin, Height = 0, Location = new Point(0, oldBtn.Location.Y + oldBtn.Height + Const.dateBtnMargin) };
            }
        }
    }
}
