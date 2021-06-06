using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class PaymentConnect
    {
        private static PaymentConnect instance;

        public static PaymentConnect Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new PaymentConnect();
                return PaymentConnect.instance;
            }
            private set => instance = value; 
        }

        private PaymentConnect()
        {

        }

        public DataTable GetBillInfoFromBillID(int Bill_ID)
        {
            SqlCommand command = new SqlCommand("GetBillInfoFromBillID");
            command.Connection = MY_DB.Instance.getConnection;
            command.Parameters.Add("@Bill_ID", SqlDbType.NVarChar).Value = Bill_ID;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public List<Payment> GetListBillInfo (int Bill_ID)
        {
            List<Payment> listBillInfo = new List<Payment>();

            DataTable table = this.GetBillInfoFromBillID(Bill_ID);

            foreach(DataRow item in table.Rows)
            {
                Payment billInfo = new Payment(item);
                listBillInfo.Add(billInfo);
            }    
            return listBillInfo;
        }

        public DataTable NetWorthPerDay()
        {
            SqlCommand command = new SqlCommand("NetWorthPerDay");
            command.Connection = MY_DB.Instance.getConnection;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable AllFoodSaleOfDay()
        {
            SqlCommand command = new SqlCommand("AllFoodSaleOfDay");
            command.Connection = MY_DB.Instance.getConnection;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable BestSellingOfDay()
        {
            SqlCommand command = new SqlCommand("BestSellingOfDay ");
            command.Connection = MY_DB.Instance.getConnection;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable CheckFoodPaidProcess(string FoodName)
        {
            SqlCommand command = new SqlCommand("CheckFoodPaidProcess ");
            command.Parameters.Add("@FoodName", SqlDbType.NVarChar).Value = FoodName;
            command.Connection = MY_DB.Instance.getConnection;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
