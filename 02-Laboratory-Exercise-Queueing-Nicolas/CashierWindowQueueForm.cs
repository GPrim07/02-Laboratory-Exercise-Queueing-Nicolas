using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Laboratory_Exercise_Queueing_Nicolas
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        public void DisplayCashierQueue(IEnumerable<string> CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (string obj in CashierList)
            {
                listCashierQueue.Items.Add(new ListViewItem(obj));
            }

        }


               

            private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }
        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
           

            timer1.Interval = 1000; // 1 second
            timer1.Enabled = true; // Start the timer
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
    }
    




