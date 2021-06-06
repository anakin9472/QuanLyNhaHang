using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public class MY_DB
    {
        private static MY_DB instance;

        public static MY_DB Instance
        { 
            get { if (instance == null) instance = new MY_DB(); return MY_DB.instance; } 
            private set => instance = value; 
        }




        //Triển khai, kế thừa DbConnection - biểu diễn sự kết nối tới máy chủ CSDL

        //Tạo đối tượng SqlConnection từ một chuỗi kết nối tới SQL Server

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0NTKRTC\MSSQLSERVER03;Initial Catalog=QuanLyNhaHang;Integrated Security=True");

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }




        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                //Mở kết nối với phương thức Open()
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                //Không còn sử dụng đến kết nối nữa thì cần đóng lại bằng phương thức Close
                con.Close();
            }

        }

    }
}

