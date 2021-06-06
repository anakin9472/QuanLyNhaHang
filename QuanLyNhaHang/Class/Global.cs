using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    class Global
    {
        public static string GlobalUserID { get; private set; }
        public static void SetGlobalUserID(string userID)
        {
            GlobalUserID = userID;
        }

        public static string Role { get; private set; }
        public static void SetRole(string userID)
        {
            Role = userID;
        }

        public static string CustomerID { get; private set; }
        public static void SetGlobalCustomerID(string cusid)
        {
            CustomerID = cusid;
        }
        public static string TableID { get; private set; }
        public static void SetGlobalTableID(string tableID)
        {
            TableID = tableID;
        }




    }
}
