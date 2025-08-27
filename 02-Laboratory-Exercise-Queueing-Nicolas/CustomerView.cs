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
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();

        }
        public void SetCustomerView(string message)
        {
            lblNext.Text = message;
        }

        private void lblNext_Click(object sender, EventArgs e)
        {

        }
    }
}
