using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_list
{
    [Serializable]
    public class PlanData
    {
        private List<PlanItem> job;

        private int notifyTime;

        private bool notifyStatus;
        public List<PlanItem> Job { get => job; set => job = value; }
        public int NotifyTime { get => notifyTime; set => notifyTime = value; }
        public bool NotifyStatus { get => notifyStatus; set => notifyStatus = value; }
    }
}
