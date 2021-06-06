using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class BillConnect
    {
        private static BillConnect instance;

        public static BillConnect Instance 
        {
            get 
            {
            if (instance == null)
                    instance = new BillConnect();
            return BillConnect.instance;
             }
            private set => instance = value; 
        }

        //Lấy ID của những hoá đơn chưa được Checkout bằng table ID
        public int GetUncheckedBillIDbyTableID(string tableID)
        {
            SqlCommand command = new SqlCommand("GetUncheckedBillIDbyTableID");
            command.Connection = MY_DB.Instance.getConnection;
            command.Parameters.Add("@tableID", SqlDbType.NVarChar).Value = tableID;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Object temp = table.Rows[0][0];
            return Convert.ToInt32(temp.ToString());
        }



    }
}
