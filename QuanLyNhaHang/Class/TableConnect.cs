using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class TableConnect
    {
        MY_DB mydb = new MY_DB();
        private static TableConnect instance;

        public static TableConnect Instance 
        { 
            get 
            { 
                if (instance == null) 
                    instance = new TableConnect();
                    return TableConnect.instance;
            }
            private set => instance = value; 
        }
        public static int width = 90;
        public static int height = 90;
            
        //Hàm lấy dữ liệu các table từ SQL
        public DataTable getTableList()
        {
            SqlCommand command = new SqlCommand("getTableList");
            command.Connection = MY_DB.Instance.getConnection;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Trả về danh sách các Table có đầy đủ các thuộc tính
        public List<Table> LoadTableList()
        {
            List<Table> TableList = new List<Table>();

            //List lấy các table execute equery từ Database

            DataTable dataTable = this.getTableList();

            foreach (DataRow item in dataTable.Rows)
            {
                //Hàm xử lý DataTable, chuyển từ DataTable => ListTable, chuyển từng row thành ListTable
                Table table = new Table(item);

                TableList.Add(table);

            }  
            
            //Trả về TableList đã có đầy đủ các table sau khi execute query từ SQL server
            return TableList;
        }

        public bool Func_CheckAvailableTable(string TableID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Func_CheckAvailableTable (@TableID)", mydb.getConnection);
            command.Parameters.Add("@TableID", System.Data.SqlDbType.NVarChar).Value = TableID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }

        public int GetNumOfCustomersFromTableID (string TableID)
        {
            SqlCommand command = new SqlCommand("SELECT NumOfCustomers FROM CustomerOrderTable  WHERE TableID = @TableID", mydb.getConnection);
            command.Parameters.Add("@TableID", System.Data.SqlDbType.NVarChar).Value = TableID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Convert.ToInt32(table.Rows[0][0]);
        }

        public string PaidStatus (string TableID)
        {
            SqlCommand command = new SqlCommand("SELECT dbo.PaidStatus02 (@TableID)", mydb.getConnection);
            command.Parameters.Add("@TableID", System.Data.SqlDbType.NVarChar).Value = TableID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }

        public bool insertTable()
        {
            SqlCommand command = new SqlCommand("dbo.insertTable", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 0))  //ExecuteNonQuery(): Trả về số hàng bị tác động trong table: 
            {                                      //Thêm 1 dòng thì trả về 1 là đúng
                //Trường hợp không bị lỗi
                mydb.closeConnection();
                return false;
            }
            else
            {
                //Trường hợp bị lỗi
                mydb.closeConnection();
                return true;
            }
        }


        public bool RemoveTable(string TableID)
        {

            SqlCommand command = new SqlCommand("RemoveTable", mydb.getConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TableID", SqlDbType.NVarChar).Value = TableID;

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



    }
}
