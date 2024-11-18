using Agrii_1._0._0._0._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrii_A
{
    public partial class Frm_HomePage : Form
    {
        public Frm_HomePage()
        {
            InitializeComponent();
        }

        private void costomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
            Frm_Login objFRM=new Frm_Login();   
            objFRM.Show();  
        }

        private void allCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_BillingPage objFRMBill = new Frm_BillingPage();
            objFRMBill.Show();
        }
    }
}
