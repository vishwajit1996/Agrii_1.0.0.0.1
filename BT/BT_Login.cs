using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DT;


namespace BT
{
    public class BT_Login
    {
                DT_Database dbHelper = new DT_Database();

                public DataTable logdata(string strID)
                {
                    string query = "SELECT TOP * FROM [Agrii].[dbo].[TBL_LOGIN] WHERE [UserID] = '"+ strID + "'";


                return dbHelper.ExecuteQuery(query);
                }
    }
}
