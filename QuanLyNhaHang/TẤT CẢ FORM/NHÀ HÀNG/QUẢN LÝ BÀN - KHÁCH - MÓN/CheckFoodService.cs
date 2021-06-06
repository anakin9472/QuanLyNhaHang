using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class CheckFoodService : Form
    {
        public CheckFoodService()
        {
            InitializeComponent();
        }

        private void CheckFoodService_Load(object sender, EventArgs e)
        {
            ReloadDataGridView();
        }


        void ReloadDataGridView()
        {
           // TextBox_FoodID.Enabled = true;
            DataTable table = Food.Instance.getAllFood();
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
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 100;
            dgv.Columns[5].Width = 140;
            dgv.Columns[6].Width = 40;
        }

        private void DataGridView_Food_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_Food_Click_1(object sender, EventArgs e)
        {
            TextBox_FoodID.Text = DataGridView_Food.CurrentRow.Cells[0].Value.ToString();
            TextBox_FoodName.Text = DataGridView_Food.CurrentRow.Cells[1].Value.ToString();
            TextBox_Price.Text =
            (Convert.ToDouble(DataGridView_Food.CurrentRow.Cells[3].Value) - Convert.ToDouble(DataGridView_Food.CurrentRow.Cells[3].Value)
            * (Convert.ToDouble(DataGridView_Food.CurrentRow.Cells[4].Value) / 100)).ToString();


            
        }

        private void TextBox_SelectedRequireNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button_Check_Click(object sender, EventArgs e)
        {
            DataTable table = PaymentConnect.Instance.CheckFoodPaidProcess(TextBox_FoodName.Text);
            table.Columns["DayPaid"].ColumnName = "Ngày";
            table.Columns["FoodName"].ColumnName = "Tên món";
            table.Columns["TotalPrice"].ColumnName = "Tổng";
            DataGridView_CheckFoodPaidProcess.DataSource = table;

            TextBox_PriceGoal.Text = (Convert.ToDouble(TextBox_SelectedRequireNumber.Text) * Convert.ToDouble(TextBox_Price.Text)).ToString();

            try
            {
                TextBox_Announce.Text = "Chênh lệch "
                 + Math.Round(((Convert.ToDouble(TextBox_PriceGoal.Text) -
                    Convert.ToDouble((DataGridView_CheckFoodPaidProcess.CurrentRow.Cells[2].Value))) / Convert.ToDouble(TextBox_Price.Text)), 3).ToString() + " sản phẩm";
            }
            catch
            {
                MessageBox.Show("Món này chưa được sử dụng", "Chương trình kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
