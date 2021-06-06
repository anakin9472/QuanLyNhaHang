using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class Menu
    {
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int FoodCount { get => foodCount; set => foodCount = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Discount { get => discount; set => discount = value; }

        private string discount;

        private string name;
        private float price;
        private int foodCount;
        private float totalPrice;

        public Menu(string name, float price, string discount, int foodCount, float totalPrice)
        {
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.FoodCount = foodCount;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.Name = row["Name"].ToString();
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.Discount = Convert.ToDouble(row["Discount"]).ToString() + "%";
            this.FoodCount = (int)row["FoodCount"];
            this.TotalPrice = (float) Convert.ToDouble(row["TotalPrice"].ToString());
        }

    }
}
