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
    public class Food
    {
        MY_DB mydb = new MY_DB();
        private static Food instance;

        public static Food Instance 
        { 
            get
            {
                if (instance == null)  
                  instance = new Food();
                return Food.instance;
            }
            set => instance = value; 
        }

        public DataTable getAllCategories()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Category");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllFood()
        {
            SqlCommand command = new SqlCommand("SELECT Food.FoodID, Name, CategoryName, Price, Discount, Picture, NumOfFood FROM Food, Category, NumOfFood where Category.CategoryID = Food.CategoryID AND Food.FoodID = NumOfFood.FoodID");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable searchFood(string search)
        {
            SqlCommand command = new SqlCommand("EXECUTE foodSearch @search = @se");
            command.Parameters.Add("@se", SqlDbType.NVarChar).Value = search;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool InsertFood(int FoodID, int CategoryID, string Name, float Price, float Discount, MemoryStream Picture)
        {

            SqlCommand command = new SqlCommand("InsertFood", mydb.getConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@FoodID", SqlDbType.Int).Value = FoodID;
            command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@Price", SqlDbType.Float).Value = Price;
            command.Parameters.Add("@Discount", SqlDbType.Float).Value = Discount;
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

        public bool InsertNumOfFood(int FoodID, int NumOfFood)
        {

            SqlCommand command = new SqlCommand("INSERT INTO NumOfFood (FoodID, NumOfFood) VALUES (@FoodID, @NumOfFood)", mydb.getConnection);

            //command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@FoodID", SqlDbType.Int).Value = FoodID;
            command.Parameters.Add("@NumOfFood", SqlDbType.Int).Value = NumOfFood;

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

        public bool FoodIDAvailable(int FoodID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Food where FoodID = @FoodID", mydb.getConnection);
            command.Parameters.Add("@FoodID", SqlDbType.Int).Value = FoodID;
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

        public string GetCategoryIDByName(string CategoryName)
        {
            SqlCommand command = new SqlCommand("SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName", mydb.getConnection);
            command.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = CategoryName;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Object temp = table.Rows[0][0];
            return temp.ToString();
        }

        public int GetFoodIDByName(string FoodName)
        {
            SqlCommand command = new SqlCommand("SELECT FoodID FROM Food WHERE Name = @FoodName", mydb.getConnection);
            command.Parameters.Add("@FoodName", SqlDbType.NVarChar).Value = FoodName;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Object temp = table.Rows[0][0];
            return Convert.ToInt32(temp);
        }

        public DataTable getFood(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool CheckAvailableFoodFromPayment(int FoodID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Func_CheckFoodPaidStatus (@FoodID)", mydb.getConnection);
            command.Parameters.Add("@FoodID", System.Data.SqlDbType.NVarChar).Value = FoodID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }

        public bool Func_CheckNumOfFood(int FoodID, int NumOfFood)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Func_CheckNumOfFood (@FoodID, @NumOfFood)", mydb.getConnection);
            command.Parameters.Add("@FoodID", System.Data.SqlDbType.Int).Value = FoodID;
            command.Parameters.Add("@NumOfFood", System.Data.SqlDbType.Int).Value = NumOfFood;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }


        public bool RemoveFood(int FoodID)
        {

            SqlCommand command = new SqlCommand("RemoveFoodByID", mydb.getConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@FoodID", SqlDbType.Int).Value = FoodID;

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

        public bool EditFood(int FoodID, int CategoryID, string Name, float Price, float Discount, MemoryStream Picture)
        {

            SqlCommand command = new SqlCommand("EditFood", mydb.getConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@FoodID", SqlDbType.Int).Value = FoodID;
            command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@Price", SqlDbType.Float).Value = Price;
            command.Parameters.Add("@Discount", SqlDbType.Float).Value = Discount;
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




    }
}
