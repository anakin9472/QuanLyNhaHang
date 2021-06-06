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
    public partial class FoodManagement : Form
    {
        Food food = new Food();
        public FoodManagement()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FoodManagement_Load(object sender, EventArgs e)
        {
            ReloadComboBox();
            ReloadDataGridView();

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        void ReloadComboBox()
        {
            ComboBox_Category.DataSource = food.getAllCategories();
            ComboBox_Category.ValueMember = "CategoryID";
            ComboBox_Category.DisplayMember = "CategoryName";
            ComboBox_Category.SelectedItem = null;
        }
        void ReloadDataGridView()
        {
            TextBox_FoodID.Enabled = true;
            DataTable table = food.getAllFood();
            table.Columns["FoodID"].ColumnName = "  ID";
            table.Columns["Name"].ColumnName = "        Tên món";
            table.Columns["CategoryName"].ColumnName = "        Danh mục";
            table.Columns["Price"].ColumnName = "Giá (VNĐ)";
            table.Columns["Discount"].ColumnName = "KM (%)";
            table.Columns["Picture"].ColumnName = "         Ảnh";
            table.Columns["NumOfFood"].ColumnName = "  SL";
            DataGridView_Food.DataSource = table;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView_Food.RowTemplate.Height = 80;
            picCol = (DataGridViewImageColumn)DataGridView_Food.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            EditWidth(DataGridView_Food);

        }

        public void EditWidth(DataGridView dgv)
        {
            //Chỉnh lại kích thước của DataGridView
            dgv.RowTemplate.Height = 100;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersWidth = 20;
            dgv.Columns[0].Width = 30;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Height = 120;
            }
            //for (int i = 1; i < dgv.Columns.Count; i++)
            //{
            //    dgv.Columns[i].Width = 90;
            //}
            dgv.Columns[0].Width = 40;
            dgv.Columns[3].Width = 50;
            dgv.Columns[4].Width = 50;
            dgv.Columns[1].Width = 90;
            dgv.Columns[2].Width = 90;
            dgv.Columns[5].Width = 140;
            dgv.Columns[6].Width = 40;
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            ReloadDataGridView();
            TextBox_FoodID.Text = "";
            TextBox_FoodName.Text = "";
            ComboBox_Category.SelectedIndex = -1;
            TextBox_Price.Text = "";
            TextBox_Discount.Text = "";
            PictureBox_Food.Image = null;

        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            //try
            //{
                int FoodID = int.Parse(TextBox_FoodID.Text);

                //Kiểm tra ID của Food có tồn tại chưa

                if (!food.FoodIDAvailable(FoodID))
                {

                //Kiểm tra đã đầy đủ thông tin chưa
                    //try
                    //{
                    if (!Verif())

                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thêm món ăn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {
                            int CategoryID = Convert.ToInt32(ComboBox_Category.SelectedValue);
                            string FoodName = TextBox_FoodName.Text;
                            float price = float.Parse(TextBox_Price.Text);
                            float discount = float.Parse(TextBox_Discount.Text);
                            int NumOfFood = Convert.ToInt32(TextBox_NumOfFood.Text);
                            MemoryStream pic = new MemoryStream();
                            PictureBox_Food.Image.Save(pic, PictureBox_Food.Image.RawFormat);

                                if (food.InsertFood(FoodID, CategoryID, FoodName, price, discount, pic) && food.InsertNumOfFood(FoodID,NumOfFood))
                                {
                                    MessageBox.Show("Thêm món ăn thành công.", "Thêm món ăn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                }

                                else
                                {
                                    MessageBox.Show("Thêm món ăn không thành công.", "Thêm món ăn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
  
                        }

                     //}
                    // catch
                    //{
                    //        MessageBox.Show("Vui lòng nhập đầy đủ thông tin món ăn.", "Thêm món ăn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}

                }

                else
                {
                    MessageBox.Show("Món ăn này đã có trong danh sách.", "Thêm món ăn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin món ăn chính xác.", "Thêm món ăn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}



}

        bool Verif()
        {
            if ((TextBox_FoodID.Text.Trim() == "") || (TextBox_FoodName.Text.Trim() == "") || (ComboBox_Category.SelectedValue == null) ||(TextBox_Price.Text.Trim() == "") || (TextBox_Discount.Text.Trim() == "") || (PictureBox_Food.Image == null))
                return false;
            return true;
        }

        //Xử lý tải ảnh
        private void Button_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.pgn;*.gif)|*.jpg;*.png;*.gif";
            //Mở hộp thoại chọn hình ảnh ra và gán cho hình ảnh được chọn vào PictureBox
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBox_Food.Image = Image.FromFile(opf.FileName);
            }
        }

        private void DataGridView_Food_Click(object sender, EventArgs e)
        {
            PictureBox_Food.Image = null;
            TextBox_FoodID.Text = DataGridView_Food.CurrentRow.Cells[0].Value.ToString();
            TextBox_FoodName.Text = DataGridView_Food.CurrentRow.Cells[1].Value.ToString();
            ComboBox_Category.SelectedValue = food.GetCategoryIDByName(DataGridView_Food.CurrentRow.Cells[2].Value.ToString());
            TextBox_Price.Text = DataGridView_Food.CurrentRow.Cells[3].Value.ToString();
            TextBox_Discount.Text = DataGridView_Food.CurrentRow.Cells[4].Value.ToString();
            if (!Convert.IsDBNull(DataGridView_Food.CurrentRow.Cells[5].Value))
            {
                byte[] pic;
                pic = (byte[])DataGridView_Food.CurrentRow.Cells[5].Value;
                MemoryStream picture = new MemoryStream(pic);
                PictureBox_Food.Image = Image.FromStream(picture);
            }

            TextBox_FoodID.Enabled = false;
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            //DataTable table = food.searchFood(TextBox_Search.Text);


            //table.Columns["FoodID"].ColumnName = "ID món";
            //table.Columns["Name"].ColumnName = "Tên món";
            //table.Columns["CategoryName"].ColumnName = "Danh mục";
            //table.Columns["Price"].ColumnName = "Giá (VNĐ)";
            //table.Columns["Discount"].ColumnName = "Khuyến mãi (%)";
            //table.Columns["Picture"].ColumnName = "Ảnh";

            //DataGridView_Food.DataSource = table;
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //DataGridView_Food.RowTemplate.Height = 80;
            //picCol = (DataGridViewImageColumn)DataGridView_Food.Columns[5];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //EditWidth(DataGridView_Food);
        }
        public void FillGrid(SqlCommand command)
        {
            DataGridView_Food.ReadOnly = true; // xu ly hinh anh, code có tham khảo msdn 
            DataGridViewImageColumn Piccol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview 
            //DataGridView_Food.RowTemplate.Height = 80; // dong nay tham khảo trên MSDN ngay 18/03/2019,co gian de pic dep, dang tim auto-size 
            DataGridView_Food.DataSource = food.getFood(command);
            Piccol = (DataGridViewImageColumn)DataGridView_Food.Columns[5];
            Piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView_Food.AllowUserToAddRows = false;

        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {


            int FoodID = Convert.ToInt32(TextBox_FoodID.Text);

            //Kiểm tra đã đầy đủ thông tin chưa

            if (food.FoodIDAvailable(FoodID))
            {

                    if (!Verif())
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Xoá món ăn khỏi danh sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        

                            if (food.CheckAvailableFoodFromPayment (FoodID))
                            {
                                MessageBox.Show("Không thể xoá do món này vẫn nằm trong 1 hoá đơn chưa thanh toán. ", "Xoá món ăn khỏi danh sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            else
                            {
                               if (food.RemoveFood(FoodID))
                                {
                                    MessageBox.Show("Xoá món ăn thành công ", "Xoá món ăn khỏi danh sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }    
                               else
                                {
                                    MessageBox.Show("Xoá món ăn không thành công ", "Xoá món ăn khỏi danh sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }    
                            }

                     }

            }

            else
            {
                MessageBox.Show("Món ăn này không tồn tại trong danh sách ", "Xoá món ăn khỏi danh sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            int FoodID = Convert.ToInt32(TextBox_FoodID.Text);

            //Kiểm tra đã đầy đủ thông tin chưa

            if (food.FoodIDAvailable(FoodID))
            {

                if (!Verif())
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thay đổi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {


                    if (food.CheckAvailableFoodFromPayment(FoodID))
                    {
                        MessageBox.Show("Không thể thay đổi thông tin do món này vẫn nằm trong 1 hoá đơn chưa thanh toán. ", "Thay đổi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {

                        int CategoryID = Convert.ToInt32(ComboBox_Category.SelectedValue);
                        string FoodName = TextBox_FoodName.Text;
                        float price = float.Parse(TextBox_Price.Text);
                        float discount = float.Parse(TextBox_Discount.Text);

                        MemoryStream pic = new MemoryStream();
                        PictureBox_Food.Image.Save(pic, PictureBox_Food.Image.RawFormat);
                        int FoodID_flag = Convert.ToInt32(TextBox_FoodID.Text);

                            if (food.EditFood(FoodID, CategoryID, FoodName, price, discount, pic))
                            {
                                MessageBox.Show("Thay đổi thông tin món ăn thành công ", "Thay đổi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thay đổi thông tin món ăn không thành công ", "Thay đổi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                    }

                }

            }

            else
            {
                MessageBox.Show("Món ăn này không tồn tại trong danh sách ", "Thay đổi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
