using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class Customer
    {
        MY_DB mydb = new MY_DB();
        private static Customer instance;

        public static Customer Instance 
        { 
            get 
            {
                if (instance == null)
                    instance = new Customer();
                return Customer.instance;
            }
            set => instance = value; 
        }

        public bool InsertCustomer(string CustomerID, string Name, string Gender, string PhoneNumber, string Address, MemoryStream Picture)
        {

            SqlCommand command = new SqlCommand("InsertCustomer", mydb.getConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = CustomerID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = Gender;
            command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = PhoneNumber;
            command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
            command.Parameters.Add("@Picture", SqlDbType.Image).Value = Picture.ToArray();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getGender()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Gender");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool CustomerIDAvailable(string CustomerID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Customer where CustomerID = @CustomerID", mydb.getConnection);
            command.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = CustomerID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool EditCustomerInfo(string CustomerID, string Name, string Gender, string PhoneNumber, string Address, MemoryStream Picture)
        {

            SqlCommand command = new SqlCommand("EditCustomerInfo", mydb.getConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = CustomerID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = Gender;
            command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = PhoneNumber;
            command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
            command.Parameters.Add("@Picture", SqlDbType.Image).Value = Picture.ToArray();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 0))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        public DataTable getCustomerByID(string CustomerID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE CustomerID = @CustomerID");
            command.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = CustomerID;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool OrderTable (string TableID, string CustomerID, int NumOfCustomers)
        {
            SqlCommand command = new SqlCommand("OrderTable", mydb.getConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TableID", SqlDbType.NVarChar).Value = TableID;
            command.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = CustomerID;
            command.Parameters.Add("@NumOfCustomers", SqlDbType.Int).Value = NumOfCustomers;


            mydb.openConnection();

            if ((command.ExecuteNonQuery() < 1))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        public bool EditNumOfCustomers(string TableID, int NumOfCustomers)
        {
            SqlCommand command = new SqlCommand("EditNumOfCustomers", mydb.getConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TableID", SqlDbType.NVarChar).Value = TableID;
            command.Parameters.Add("@NumOfCustomers", SqlDbType.Int).Value = NumOfCustomers;


            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 0))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        public bool ChangeTable(string NewTable_ID, string CurrentTable_ID, int NumOfCustomers)
        {
            SqlCommand command = new SqlCommand("ChangeTable", mydb.getConnection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@NewTable_ID", SqlDbType.NVarChar).Value = NewTable_ID;
            command.Parameters.Add("@CurrentTable_ID", SqlDbType.NVarChar).Value = CurrentTable_ID;
            command.Parameters.Add("@NumOfCustomers", SqlDbType.Int).Value = NumOfCustomers;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 0))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        public bool Func_FindTable(string TableID, string CustomerID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Func_FindTable (@TableID, @CustomerID)", mydb.getConnection);
            command.Parameters.Add("@TableID", System.Data.SqlDbType.NVarChar).Value = TableID;
            command.Parameters.Add("@CustomerID", System.Data.SqlDbType.NVarChar).Value = CustomerID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }

        public bool Func_CustomerAlready(string CustomerID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CustomerOrderTable where CustomerID = @CustomerID AND CheckPay != 1", mydb.getConnection);
            command.Parameters.Add("@CustomerID", System.Data.SqlDbType.NVarChar).Value = CustomerID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }


        public int Func_GetNumOfCustomers(string TableID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Func_GetNumOfCustomers (@TableID)", mydb.getConnection);
            command.Parameters.Add("@TableID", System.Data.SqlDbType.NVarChar).Value = TableID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Object temp = table.Rows[0][0];
            return Convert.ToInt32(temp);
        }


        public void LoadFood(string TableID, string FoodName, int NumOfFood)
        {
            SqlCommand command = new SqlCommand("LoadFood");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@TableID", SqlDbType.NVarChar).Value = TableID;
            command.Parameters.Add("@FoodName", SqlDbType.NVarChar).Value = FoodName;
            command.Parameters.Add("@FoodCount", SqlDbType.Int).Value = NumOfFood;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
        }
    }
}
