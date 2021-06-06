using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    //Class Table để lưu trữ thông tin các thuộc tính có liên quan đến Table
    public class Table
    {
        public Table(string TableID, string TableStatus)
        {
            this.TableID = TableID;
            this.TableStatus = TableStatus;
        }
        private string tableID;
        public string TableID 
        {
            get { return tableID; }
            set { tableID = value; }
        }
        //Hàm xử lý DataTable, chuyển từ DataTable => ListTable, chuyển từng row thành ListTable
        public Table(DataRow row)
        {
            this.TableID = row["TableID"].ToString();
            this.TableStatus = row["TableStatus"].ToString();
        }

        private string tableStatus;

        public string TableStatus 
        {
            get { return tableStatus; }
            set { tableStatus = value; } 
        }
    }
}
