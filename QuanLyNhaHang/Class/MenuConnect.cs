using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public class MenuConnect
    {
        private static MenuConnect instance;

        public static MenuConnect Instance 
        { 
            get
            {
                if (instance == null) instance = new MenuConnect();
                return MenuConnect.instance;
            }
            set => instance = value; 
        }

        public DataTable GetMenuForTable(string Table_ID)
        {

           // MessageBox.Show(Table_ID);
            SqlCommand command = new SqlCommand("GetMenuForTable");
            command.Connection = MY_DB.Instance.getConnection;
            command.Parameters.Add("@TableID", SqlDbType.NVarChar).Value = Table_ID;
           command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetOrderFoods(string FoodName, int NumOfFood)
        {
            SqlCommand command = new SqlCommand("GetOrderFoods");
            command.Connection = MY_DB.Instance.getConnection;
            command.Parameters.Add("@FoodName", SqlDbType.NVarChar).Value = FoodName;
            command.Parameters.Add("@NumOfFood", SqlDbType.Int).Value = NumOfFood;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public List<Menu> GetMenuInfo(string Table_ID)
        {
            List<Menu> listMenuInfo = new List<Menu>();

            DataTable table = this.GetMenuForTable(Table_ID);
            //MessageBox.Show(table.Rows.Count.ToString());

            foreach (DataRow item in table.Rows)
            {

                Menu MenuInfo = new Menu(item);
                
                listMenuInfo.Add(MenuInfo);
            }
            return listMenuInfo;
        }

        public List<Menu> GetOrderInfo (string FoodName, int NumOfFood)
        {
            List<Menu> listMenuInfo = new List<Menu>();

            DataTable table = this.GetOrderFoods(FoodName, NumOfFood);

            foreach (DataRow item in table.Rows)
            {
                Menu MenuInfo = new Menu(item);
                listMenuInfo.Add(MenuInfo);
            }
            return listMenuInfo;
        }

        public DataTable ShowAllCustomersWithBill()
        {
            SqlCommand command = new SqlCommand("ShowAllCustomersWithBill");
            command.Connection = MY_DB.Instance.getConnection;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool PayingBill(string TableID)
        {

            SqlCommand command = new SqlCommand("PayingBill", MY_DB.Instance.getConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TableID", SqlDbType.NVarChar).Value = TableID;

            MY_DB.Instance.openConnection();

            if ((command.ExecuteNonQuery() < 1))
            {
                MY_DB.Instance.closeConnection();
                return false;
            }
            else
            {
                MY_DB.Instance.closeConnection();
                return true;
            }
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


    }
}
