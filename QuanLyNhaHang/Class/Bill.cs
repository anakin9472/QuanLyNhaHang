using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class Bill
    {
        //private static Bill instance;

        //public static Bill Instance 
        //{ 
        //    get 
        //    {
        //        if (instance == null)
        //        {
        //            instance = new Bill();
        //        }    
        //        return Bill.instance;
        //    }
        //   private set => instance = value; 
        //}


        public int Status { get => status; set => status = value; }
        public DateTime? CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime? CheckOut { get => checkOut; set => checkOut = value; }
        public int Bill_ID { get => bill_ID; set => bill_ID = value; }

        private  DateTime? checkIn;

        private DateTime? checkOut;

        private int bill_ID;

        private int status;

        public Bill(int Bill_ID, DateTime? CheckIn, DateTime? CheckOut, int status)
        {
            this.Bill_ID = Bill_ID;
            this.CheckIn = CheckIn;
            this.CheckOut = CheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.Bill_ID = (int) row["Bill_ID"];
            this.CheckIn = (DateTime?) row["CheckIn"];
            this.CheckOut = (DateTime?)row["CheckOut"];
            this.Status = (int)row["Status"];
        }




    }
}
