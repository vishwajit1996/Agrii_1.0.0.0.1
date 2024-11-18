using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BT;

namespace Agrii_1._0._0._0._1
{
    public partial class Frm_BillingPage : Form
    {
        public Frm_BillingPage()
        {
            InitializeComponent();
        }

        private void Frm_BillingPage_Load(object sender, EventArgs e)
        {
            DataTable DTName= new DataTable();  
            BT_Billing objInsert = new BT_Billing();
            DTName =objInsert.GetNameList();
            for (int i = 0; i < DTName.Rows.Count; i++)
            {
                cmb_CustomerName.Items.Add(DTName.Rows[i]["CustomerName"].ToString());
            }

            DataTable DTProduct = new DataTable();
            BT_Billing objGet = new BT_Billing();
            DTProduct = objGet.GetNameList();
            for (int i = 0; i < DTName.Rows.Count; i++)
            {
                cmb_CustomerName.Items.Add(DTName.Rows[i]["CustomerName"].ToString());
            }

        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            string str_CustName = cmb_CustomerName.Text;
            string str_ProdName = cmb_ProdoctName.Text;
            string str_Amount = txt_Amount.Text;
            string str_Date = DTP_DateNow.Value.ToString();
            if (string.IsNullOrEmpty(cmb_CustomerName.Text) || string.IsNullOrEmpty(cmb_ProdoctName.Text) || string.IsNullOrEmpty(txt_Amount.Text) || string.IsNullOrEmpty(DTP_DateNow.Value.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            BT_Billing objInsert = new BT_Billing();
            objInsert.InsertBill(str_CustName, str_ProdName, str_Amount, str_Date);




        }



    }
}
