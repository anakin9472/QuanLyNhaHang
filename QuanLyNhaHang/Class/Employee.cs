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
    public class Employee
    {
        MY_DB mydb = new MY_DB();
        private static Employee instance;

        public static Employee Instance 
        {
            get
            {
                if (instance == null)
                    instance = new Employee();
                return Employee.instance;
            }
            private set => instance = value; 
        }

        public DataTable getAllEmpTypes()
        {
            SqlCommand command = new SqlCommand("select distinct * from Role");
            command.Connection = mydb.getConnection;
            //command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkAvailableUsername(string username)
        {
            //Tạo một câu lệnh Transact-SQL hoặc thủ tục hàm được lưu trữ để thực thi dựa trên cơ sở dữ liệu SQL Server. 
            SqlCommand command = new SqlCommand("Select count(ea.EmployeeID) " +
                                                "From EmployeeAccount ea, EmployeeInfo ei " +
                                                "Where Username=@Username and ea.EmployeeID = ei.EmployeeID",
                                                mydb.getConnection);
            //.Add method: Thêm các tham số vào SqlParameterCollection
            //SqlParameterCollection: Đại diện cho một tập hợp các tham số được liên kết
            //với một SqlCommand và các ánh xạ tương ứng của chúng tới các cột trong DataSet. 
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
            //Mở kết nối
            mydb.openConnection();
            //ExecuteScalar(): Thực thi truy vấn và trả về cột đầu tiên của hàng đầu tiên trong tập kết quả được trả về bởi truy vấn. 
            int count = Convert.ToInt32(command.ExecuteScalar());
            //Đóng kết nối
            mydb.closeConnection();
            if (count > 0)
                return false;                                       //Khong hop le: Vi tai khoan nay da ton tai
            return true;                                           //Hop le: Tai khoan nay chua ton tai
        }

        //Kiểm tra đúng vai trò của nhân viên
        public bool checkRole(string username, string role)
        {
            SqlCommand command = new SqlCommand("Select count(ea.EmployeeID) " +
                                                "From EmployeeAccount ea, EmployeeInfo ei " +
                                                "Where Username = @Username " +
                                                "and Role = @Role" +
                                                "and ea.EmployeeID = ei.EmployeeID ",
                                                mydb.getConnection);
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Role", SqlDbType.VarChar).Value = role;
            mydb.openConnection();
            int temp = Convert.ToInt32(command.ExecuteScalar());
            mydb.closeConnection();
            if (temp == 0) return false;
            return true;
        }


        //Thêm thông tin nhân viên
        public bool InsertEmployeeInfor(string eid, string fname, string mname, string lname, string gender, DateTime bdate,
            double salary, string phone, string email, string role, string address, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("INSERT INTO EmployeeInfo (EmployeeID, FirstName,MiddleName, LastName,Gender, BirthDate,Address, PhoneNumber,Email,Image,RoleID,Salary)" +
        " VALUES(@eid, @fname,@mname, @lname, @gender,@bdate, @address,@phone,@email,@image,@role,@salary)", mydb.getConnection);
            command.Parameters.Add("@eid", SqlDbType.NVarChar).Value = eid;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@mname", SqlDbType.NVarChar).Value = mname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray(); //Phương thức này trả về một bản sao nội dung của MemoryStream dưới dạng một mảng byte.
            command.Parameters.Add("@role", SqlDbType.NVarChar).Value = role;
            command.Parameters.Add("@salary", SqlDbType.Real).Value = salary;
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

        //Thêm thông tin tài khoản của nhân viên
        public bool InsertEmployeeAccount(string eid, string user, string pass, string role)
        {
            SqlCommand command = new SqlCommand("INSERT INTO EmployeeAccount (EmployeeID, Username,Password,TypeEmployee)" +
        " VALUES(@eid, @user,@pass,@type)", mydb.getConnection);
            command.Parameters.Add("@eid", SqlDbType.NVarChar).Value = eid;
            command.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = role;
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


        //Hiển thị toàn bộ nhân viên + thông tin
        public DataTable getAllEmployees()
        {
            SqlCommand command = new SqlCommand("select * From EmployeeInfo");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string getRoleFromRoleID(string roldID)
        {
            SqlCommand command = new SqlCommand("select RoleName From Role where RoleID = @roleid");
            command.Parameters.Add("@roleid", SqlDbType.VarChar).Value = roldID;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Object temp = table.Rows[0][0];
            return temp.ToString();
        }

        public string getUserIDbyUsername(string uername)
        {
            SqlCommand command = new SqlCommand("select EmployeeID From EmployeeAccount where Username = @uername");
            command.Parameters.Add("@uername", SqlDbType.VarChar).Value = uername;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Object temp = table.Rows[0][0];
            return temp.ToString();
        }
        ///////////////////////////////////////
        public bool deleteEmployee(string eid)
        {
            SqlCommand command = new SqlCommand("Exec dbo.deleteEmployee @empid " +
        " Delete EmployeeInfo Where EmployeeID=@eid", mydb.getConnection);
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = eid;
            mydb.openConnection();
            //ExecuteNonQuery() thi hành truy vấn - không cần trả về dữ liệu gì, phù hợp thực hiện các truy vấn như Update, Delete ...
            //ExecuteReader() thi hành lệnh - trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về
            //ExecuteScalar() thì hành và trả về một giá trị duy nhất -ở hàng đầu tiên, cột đầu tiên            
            if ((command.ExecuteNonQuery() >= 1))  //ExecuteNonQuery(): Trả về số hàng bị tác động trong table: 
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
        public bool updateEmployee(string eid, string fname, string mname, string lname, string gender, DateTime bdate,
            double salary, string phone, string email, int role, string address, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("Update EmployeeInfo Set FirstName=@fname,MiddleName=@mname,LastName=@lname ,Gender=@gender,Birthdate=@birthdate,Address=@addr,Phonenumber=@phone,Email=@email,Image=@image,RoleID=@roleid,Salary=@salary Where EmployeeID=@eid", mydb.getConnection);
            command.Parameters.Add("@eid", SqlDbType.NVarChar).Value = eid;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@mname", SqlDbType.NVarChar).Value = mname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@birthdate", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@addr", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray();
            command.Parameters.Add("@roleid", SqlDbType.Int).Value = role;
            command.Parameters.Add("@salary", SqlDbType.Real).Value = salary;
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
        public bool checkEmployeeID(string empid)
        {
            SqlCommand command = new SqlCommand("Select * From EmployeeInfo Where EmployeeID=@empid");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = empid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            return false;
        }
        public DataTable getEmployeeID()
        {
            SqlCommand command = new SqlCommand("Select EmployeeID From EmployeeInfo");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getEmployee()
        {
            SqlCommand command = new SqlCommand("Select EmployeeID as 'Mã NV', (FirstName+' '+MiddleName+' '+LastName)as 'Họ tên', Gender as 'Giới tính', Birthdate as 'Ngày sinh', Address as 'Địa chỉ', PhoneNumber as 'SĐT', Email, Image as 'Ảnh', RoleID as 'C.Vụ', Salary as 'Lương' From EmployeeInfo");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getEmployeeByEmployeeID(string empid)
        {
            SqlCommand command = new SqlCommand("Select EmployeeID as 'Mã NV', (FirstName+' '+MiddleName+' '+LastName)as 'Họ tên', Gender as 'Giới tính', Birthdate as 'Ngày sinh', Address as 'Địa chỉ', PhoneNumber as 'SĐT', Email, Image as 'Ảnh', RoleID as 'C.Vụ', Salary as 'Lương' From EmployeeInfo Where EmployeeID=@empid");
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = empid;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getDetailEmployeeByEmployeeID(string empid)
        {
            SqlCommand command = new SqlCommand("Select * From EmployeeInfo Where EmployeeID=@empid");
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = empid;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getEmployeeByEmployeeName(string search)
        {
            SqlCommand command = new SqlCommand("Select EmployeeID as 'Mã NV', (FirstName+' '+MiddleName+' '+LastName)as 'Họ tên', Gender as 'Giới tính', Birthdate as 'Ngày sinh', Address as 'Địa chỉ', PhoneNumber as 'SĐT', Email, Image as 'Ảnh', RoleID as 'C.Vụ', Salary as 'Lương' From EmployeeInfo Where Concat(FirstName,MiddleName,LastName) Like N'%" + search + "%'");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getMaleEmp()
        {
            SqlCommand command = new SqlCommand("Select EmployeeID as 'Mã NV', (FirstName+' '+MiddleName+' '+LastName)as 'Họ tên', Gender as 'Giới tính', Birthdate as 'Ngày sinh', Address as 'Địa chỉ', PhoneNumber as 'SĐT', Email, Image as 'Ảnh', RoleID as 'C.Vụ', Salary as 'Lương' From EmployeeInfo Where Gender=N'Nam'");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getFeMaleEmp()
        {
            SqlCommand command = new SqlCommand("Select EmployeeID as 'Mã NV', (FirstName+' '+MiddleName+' '+LastName)as 'Họ tên', Gender as 'Giới tính', Birthdate as 'Ngày sinh', Address as 'Địa chỉ', PhoneNumber as 'SĐT', Email, Image as 'Ảnh', RoleID as 'C.Vụ', Salary as 'Lương' From EmployeeInfo Where Gender!=N'Nam'");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getEmployeeIDByRoleID(int roleid)
        {
            SqlCommand command = new SqlCommand("Select EmployeeID From EmployeeInfo Where RoleID=@roleid");
            command.Parameters.Add("@roleid", SqlDbType.Int).Value = roleid;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkValidUsername(string username)
        {
            SqlCommand command = new SqlCommand("Select count(ea.EmployeeID) From EmployeeAccount ea, EmployeeInfo ei Where Username=@Username and ea.EmployeeID = ei.EmployeeID", mydb.getConnection);
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            mydb.closeConnection();
            if (count > 0)
                return false;                                       //Khong hop le: Vi tai khoan nay da ton tai
            return true;                                           //Hop le: Tai khoan nay chua ton tai
        }
    }
}