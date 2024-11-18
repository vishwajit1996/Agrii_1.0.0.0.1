using DT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    public class BT_Billing
    {
        DT_Database dbHelper = new DT_Database();

        public DataTable InsertBill(string str_CustName, string str_ProdName, string str_Amount, string str_Date)
        {
            string query = "";

            return dbHelper.ExecuteQuery(query);
        }
        public DataTable GetNameList()
        {
            string query = "Select [NAME] from [dbo].[CUSTOMER_DETAILS]";

            return dbHelper.ExecuteQuery(query);
        }
    }
}
