using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class CHỌN_MÓN : Form
    {

        MY_DB mydb = new MY_DB();
        Food food = new Food();
        // SqlConnection cn;
        SqlCommand command;
        SqlDataReader dr;

        private PictureBox pic = new PictureBox();
        private Label foodName = new Label();
        private Label price = new Label();
        private Label discount = new Label();
        private Label DiscountPrice = new Label();
        private Panel panel = new Panel();
        public float TotalPrice = 0;

        public CHỌN_MÓN()
        {
            InitializeComponent();

            //cn = mydb.getConnection;
            //cn.ConnectionString = @"Data Source=DESKTOP-0NTKRTC\MSSQLSERVER03;Initial Catalog=DoAnCuoiKy_Test;Integrated Security=True"
            command = new SqlCommand("SELECT Picture, Name, Price FROM Food", mydb.getConnection);
            GetData(command);
            pic.Name = "Pic";
            SelectFoodFromClick<PictureBox, FlowLayoutPanel>(FlowLayoutPanel_Menu);


        }

        private void CHỌN_MÓN_Load(object sender, EventArgs e)
        {
            ReloadComboBox();
            TextBox_TotalPrice.Text = TotalPrice.ToString() +" VNĐ";

        }
        public void LoadAllFood()
        {
            DataTable table = Food.Instance.getAllFood();
            command = new SqlCommand("SELECT Picture, Name, Price FROM Food", mydb.getConnection);
            GetData(command);
        }


        public void GetData(SqlCommand command)
        {
            mydb.openConnection();

            //Đưa câu lệnh vào trong 1 bộ Connection của command và xây dựng 1 trình đọc SQL - SqlDataReader (đọc duyệt các dòng database)
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                //GetBytes: Truy xuất một số byte dữ liệu nhị phân thô được chỉ định. 
                long len = dr.GetBytes(0, 0, null, 0, 0);

                //Cấu trúc dữ liệu dạng byte (8 bit)
                byte[] array = new byte[System.Convert.ToInt32(len + 1)];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len + 1));

                //Xử lí với PictureBox để đưa Image vào
                pic = new PictureBox();
                pic.Width = 142;
                pic.Height = 142;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                //Luồng làm việc với các dữ liệu trên bộ nhớ
                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                //Xử lí với label Name
                foodName = new Label();
                foodName.Text = dr["Name"].ToString();
                foodName.BackColor = Color.FromArgb(72, 219, 251);
                foodName.Dock = DockStyle.Bottom;
                foodName.TextAlign = ContentAlignment.MiddleCenter;
                foodName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                //Xử lí với label Price
                price = new Label();
                price.Text = dr["Price"].ToString() + " Đ";
                price.Width = 60;
                price.BackColor = Color.FromArgb(251, 211, 218);
                //price.Dock = DockStyle.Bottom;
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                pic.Controls.Add(foodName);
                pic.Controls.Add(price);
                //pic.Name = "Pic";


                pic.Tag = foodName;


                FlowLayoutPanel_Menu.Controls.Add(pic);
            }
            dr.Close();
            mydb.closeConnection();
        }

        public void GetDataWithDiscount(SqlCommand command)
        {
            mydb.openConnection();

            //Đưa câu lệnh vào trong 1 bộ Connection của command và xây dựng 1 trình đọc SQL - SqlDataReader (đọc duyệt các dòng database)
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                //GetBytes: Truy xuất một số byte dữ liệu nhị phân thô được chỉ định. 
                long len = dr.GetBytes(0, 0, null, 0, 0);

                //Cấu trúc dữ liệu dạng byte (8 bit)
                byte[] array = new byte[System.Convert.ToInt32(len + 1)];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len + 1));

                //Xử lí với PictureBox để đưa Image vào
                pic = new PictureBox();
                pic.Width = 142;
                pic.Height = 142;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                //Luồng làm việc với các dữ liệu trên bộ nhớ
                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;
                pic.Dock = DockStyle.Top;

                //Xử lí với label Name
                foodName = new Label();
                foodName.Text = dr["Name"].ToString();
                foodName.BackColor = Color.FromArgb(72, 219, 251);
                foodName.Dock = DockStyle.Bottom;
                foodName.TextAlign = ContentAlignment.MiddleCenter;
                foodName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                //Xử lí với label Price
                price = new Label();
                price.Text = dr["Price"].ToString() + " VNĐ";
                price.Width = 60;
                price.BackColor = Color.FromArgb(251, 211, 218);
                price.Dock = DockStyle.Bottom;
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                //Xử lí với label Discount
                discount = new Label();
                discount.Text = "-" + dr["Discount"].ToString() + " %";
                discount.Width = 40;
                discount.BackColor = Color.FromArgb(250, 177, 160);
                //discount.Dock = DockStyle.Bottom;
                discount.TextAlign = ContentAlignment.MiddleCenter;
                discount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                //Xử lí với label DiscountPrice
                DiscountPrice = new Label();
                DiscountPrice.Text = dr["DiscountPrice"].ToString() + " VNĐ";
                DiscountPrice.Width = 60;
                DiscountPrice.BackColor = Color.FromArgb(255, 234, 167);
                DiscountPrice.Dock = DockStyle.Bottom;
                DiscountPrice.TextAlign = ContentAlignment.MiddleCenter;
                DiscountPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                panel = new Panel();
                panel.Width = 145;
                panel.Height = pic.Height + price.Height + DiscountPrice.Height;
                //pic.Click += Pic_Click;


                pic.Name = "Pic";
                panel.Controls.Add(pic);
                pic.Controls.Add(discount);
                pic.Controls.Add(foodName);

                pic.Tag = foodName;

                panel.Controls.Add(price);
                panel.Controls.Add(DiscountPrice);

                FlowLayoutPanel_Menu.Controls.Add(panel);
            }
            dr.Close();
            mydb.closeConnection();
        }

        private void Pic_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Reset FlowLayoutPanel
            FlowLayoutPanel_Menu.Controls.Clear();
            command = new SqlCommand("SELECT Picture, Name, Price, Discount,  Price - Price * (Discount / 100) AS DiscountPrice FROM Food where Discount > 0", mydb.getConnection);
            GetDataWithDiscount(command);
            SelectFoodFromClick2<Panel, FlowLayoutPanel>(FlowLayoutPanel_Menu);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        void ReloadComboBox()
        {
            ComboBox_Category.DataSource = food.getAllCategories();
            ComboBox_Category.ValueMember = "CategoryID";
            ComboBox_Category.DisplayMember = "CategoryName";
            ComboBox_Category.SelectedItem = null;
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {

            FlowLayoutPanel_Menu.Controls.Clear();
            int CategoryID = Convert.ToInt32(ComboBox_Category.SelectedValue);
            if (CategoryID == 0)
            {
                command = new SqlCommand("SELECT Picture, Name, Price FROM Food", mydb.getConnection);
            }
            else
            {
                command = new SqlCommand("SELECT Picture, Name, Price FROM Food where CategoryID = @CategoryID", mydb.getConnection);
                command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
            }
            GetData(command);
        }

        void SelectFoodFromClick<T1, T2>(T2 Temp) where T1 : Control where T2 : Control
        {

            foreach (Control item in Temp.Controls.OfType<T1>())
            {
                //item.Controls["Pic"].Click += Item_Click1;
                item.Click += Item_Click1;
            }
        }

        void SelectFoodFromClick2<T1, T2>(T2 Temp) where T1 : Control where T2 : Control
        {

            foreach (Control item in Temp.Controls.OfType<T1>())
            {
                item.Controls["Pic"].Click += Item_Click2;
                //item.Click += Item_Click1;
            }
        }

        public string CustomerID = Global.CustomerID;
        public string FoodName;
        public int NumOfFood;


        private void Item_Click1(object sender, EventArgs e)
        {
            FoodName = ((sender as PictureBox).Tag as Label).Text;
            TextBox_SelectedFood.Text = FoodName;
        }

        private void Item_Click2(object sender, EventArgs e)
        {
            FoodName = ((sender as PictureBox).Tag as Label).Text;
            TextBox_SelectedFood.Text = FoodName;
        }


        //void Order()
        //{
        //    TextBox_SelectedFood.Text = FoodName;

        //}

        private void Button_Order_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đặt món. ", "Đặt món", MessageBoxButtons.OK, MessageBoxIcon.Information)
                == System.Windows.Forms.DialogResult.OK)
            {

                //try
                //{
                    NumOfFood = Convert.ToInt32(NumericUpDown_NumOfFood.Value.ToString());
                    if (NumOfFood == 0)
                    {
                        MessageBox.Show("Vui lòng chọn số lượng. ", "Đặt món", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                    int foodID = food.GetFoodIDByName(TextBox_SelectedFood.Text);
                    if (food.Func_CheckNumOfFood(foodID, NumOfFood))
                    {
                        //MessageBox.Show(FoodName + " " + NumOfFood.ToString());
                        ShowOrderDetails();
                        NumericUpDown_NumOfFood.Value = NumericUpDown_NumOfFood.Minimum;
                    } 
                        else
                        {
                        MessageBox.Show("Không đủ số lượng món ", "Đặt món", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    
 
                    }
                //}
                //catch
                //{
                //    MessageBox.Show("Lỗi đặt món.", "Đặt món", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }

        }


        void ShowOrderDetails()
        {
            //ListView_OrderDetails.Items.Clear();
            //tableID => BillID => PaymentID
            //Tạo ra được List các Hoá đơn cần thiết
            //List<Payment> listBillInfo = PaymentConnect.Instance.GetListBillInfo(BillConnect.Instance.GetUncheckedBillIDbyTableID(tableID));

            List<Menu> listMenuInfo = MenuConnect.Instance.GetOrderInfo(FoodName, NumOfFood);
            //Hiển thị ra bằng listView
            //Với mỗi hoá đơn trong List hoá đơn sẽ đưa vào item của ListView
            foreach (Menu item in listMenuInfo)
            {
                //item ID thức ăn được đưa vào 1 ListViewItem
                ListViewItem listViewItem = new ListViewItem(item.Name.ToString());

                //Lần lượt add thêm các Item khác
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.Discount.ToString());
                listViewItem.SubItems.Add(item.FoodCount.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                TotalPrice += item.TotalPrice;
                TextBox_TotalPrice.Text = TotalPrice.ToString() + " VNĐ";
                //Đưa các item đó vào giao diện ListView chính
                ListView_OrderDetails.Items.Add(listViewItem);
                try
                {
                    Customer.Instance.LoadFood(Global.TableID, item.Name, item.FoodCount);
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn bàn ăn của bạn. ", "Đặt món", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
