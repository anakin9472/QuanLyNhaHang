using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class Payment
    {
        //private static Payment instance;

        //public static Payment Instance 
        //{ 
        //    get
        //    {
        //        if (instance == null) instance = new Payment();
        //        return Payment.instance;
        //    }
        //    private set => instance = value; 
        //}

        public int Payment_ID { get => payment_ID; set => payment_ID = value; }
        public int Bill_ID { get => bill_ID; set => bill_ID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int FoodCount { get => foodCount; set => foodCount = value; }

        private int payment_ID;
        private int bill_ID;
        private int foodID;
        private int foodCount;

        public Payment(int Payment_ID, int Bill_ID, int FoodID, int FoodCount)
        {
            this.Payment_ID = Payment_ID;
            this.Bill_ID = Bill_ID;
            this.FoodID = FoodID;
            this.FoodCount = FoodCount;
        }
        public Payment(DataRow row)
        {
            this.Payment_ID = (int)row["Payment_ID"];
            this.Bill_ID = (int) row["Bill_ID"];
            this.FoodID = (int) row["FoodID"];
            this.FoodCount = (int)row["FoodCount"];
        }
    }
}
