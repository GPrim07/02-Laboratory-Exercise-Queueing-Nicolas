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
    public partial class QueueingForm : Form
    {
        public QueueingForm()
        {
            InitializeComponent();
        }

        
            private void btnCashier_Click(object sender, EventArgs e)
        {
           
            CashierClass.getNumberInQueue = CashierClass.CashierGeneratedNumber("P-");

            
            lblQueue.Text = "Position in Queue\n" + CashierClass.getNumberInQueue;

            
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);



        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnCashierWindow_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierForm = new CashierWindowQueueForm();

            cashierForm.Show();
        }
    }

    }

