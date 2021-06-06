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
    class Wage
    {
        MY_DB mydb = new MY_DB();
        public DataTable getWage(DateTime workdate)
        {
            SqlCommand command = new SqlCommand("Select EmployeeID as 'Mã NV', Workdate as 'Ngày làm việc', (dbo.formatfloat(Salary) + dbo.formatfloat(Reward)) as 'Lương' From Wage  Where Convert(Date,Workdate)=Convert(Date,@date)");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = workdate;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
