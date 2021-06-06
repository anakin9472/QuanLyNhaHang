using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    class Period
    {
        MY_DB mydb = new MY_DB();
        public DataTable getPeriod()
        {
            SqlCommand command = new SqlCommand("Select * From Period");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertPeriod(int perid, string name, DateTime timestart, DateTime timeend, int employeequantity, int roleid)
        {
            //Các cột StudenID, FirstName, .... phải theo đúng thứ tự được tạo trong Cơ sở dữ liệu
            SqlCommand command = new SqlCommand("INSERT INTO Period " +
        " VALUES(@periodid,@name, @timestart, @timeend, @employeequantity,@roleid)", mydb.getConnection);
            command.Parameters.Add("@timestart", SqlDbType.DateTime).Value = timestart;
            command.Parameters.Add("@timeend", SqlDbType.DateTime).Value = timeend;
            command.Parameters.Add("@employeequantity", SqlDbType.Int).Value = employeequantity;
            command.Parameters.Add("@periodid", SqlDbType.Int).Value = perid;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@roleid", SqlDbType.Int).Value = roleid;
            mydb.openConnection();
            //ExecuteNonQuery() thi hành truy vấn - không cần trả về dữ liệu gì, phù hợp thực hiện các truy vấn như Update, Delete ...
            //ExecuteReader() thi hành lệnh - trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về
            //ExecuteScalar() thì hành và trả về một giá trị duy nhất -ở hàng đầu tiên, cột đầu tiên            
            if ((command.ExecuteNonQuery() == 1))  //ExecuteNonQuery(): Trả về số hàng bị tác động trong table: 
            {                                      //Thêm 1 dòng thì trả về 1 là đúng
                //Trường hợp không bị lỗi
                mydb.closeConnection();
                return true;
            }
            else
            {
                //Trường hợp bị lỗi
                mydb.closeConnection();
                return false;
            }
        }
        public bool deletePeriod(int perid)     //chưa chỉnh
        {
            SqlCommand command = new SqlCommand(" Exec dbo.deletePeriod @perid", mydb.getConnection);
            command.Parameters.Add("@perid", SqlDbType.Int).Value = perid;
            mydb.openConnection();
            //ExecuteNonQuery() thi hành truy vấn - không cần trả về dữ liệu gì, phù hợp thực hiện các truy vấn như Update, Delete ...
            //ExecuteReader() thi hành lệnh - trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về
            //ExecuteScalar() thì hành và trả về một giá trị duy nhất -ở hàng đầu tiên, cột đầu tiên            
            if ((command.ExecuteNonQuery()) >= 1)     //ExecuteNonQuery(): Trả về số hàng bị tác động trong table: 
            {                                       //Xóa 1 dòng thì trả về 1 là đúng
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updatePeriod(int perid, string name, DateTime timestart, DateTime timeend, int employeequantity, int roleid)
        {
            SqlCommand command = new SqlCommand("Update Period Set PeriodName=@name,Time_start=@timestart, Time_end=@timeend, EmployeeQuantity=@employeequantity, RoleID=@roleid Where PeriodID=@perid", mydb.getConnection);
            command.Parameters.Add("@timestart", SqlDbType.DateTime).Value = timestart;
            command.Parameters.Add("@timeend", SqlDbType.DateTime).Value = timeend;
            command.Parameters.Add("@employeequantity", SqlDbType.Int).Value = employeequantity;
            command.Parameters.Add("@perid", SqlDbType.Int).Value = perid;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@roleid", SqlDbType.Int).Value = roleid;
            mydb.openConnection();
            //ExecuteNonQuery() thi hành truy vấn - không cần trả về dữ liệu gì, phù hợp thực hiện các truy vấn như Update, Delete ...
            //ExecuteReader() thi hành lệnh - trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về
            //ExecuteScalar() thì hành và trả về một giá trị duy nhất -ở hàng đầu tiên, cột đầu tiên
            if ((command.ExecuteNonQuery() == 1))    //ExecuteNonQuery(): Trả về số hàng bị tác động trong table: 
            {                                      //Update 1 dòng thì trả về 1 là đúng
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getPeriodID(int roleid)
        {
            SqlCommand command = new SqlCommand("Select PeriodID, EmployeeQuantity From Period Where RoleID =@roleid");
            command.Parameters.Add("@roleid", SqlDbType.Int).Value = roleid;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
