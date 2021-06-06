using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class TableFoodManagement : Form
    {
        public float TotalPrice = 0;
        public string deletedTableID;
        public string selectedTableID;
        public TableFoodManagement()
        {
            InitializeComponent();
            LoadAllTables();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_FoodList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        void LoadAllTables()
        {
            FlowLayoutPanel_Left.Controls.Clear();
            List<Table> tableList = TableConnect.Instance.LoadTableList();
            foreach(Table item in tableList)
            {
                //Mỗi table sẽ được hiển thị ra dưới dạng Control Button
                //Format lại Button 
                Button btn = new Button { Width = TableConnect.width, Height = TableConnect.height };
                btn.Text = item.TableID + Environment.NewLine + item.TableStatus /*+ Environment.NewLine + "SL khách: "*/;

                //Gọi tới event thực thi hiển thị hoá đơn của từng bàn cụ thể, mà mỗi bàn được thể hiện dưới dạng Control Button
                btn.Click += Btn_Click;
                

                // Tag là một thuộc tính kiểu object, dùng để lưu những thứ cần thiết mà không phải tạo class mới inherit class gốc chỉ để lưu trữ thêm thông tin cần thiết
                btn.Tag = item;

                switch (item.TableStatus)
                {
                    case "Available":
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        FlowLayoutPanel_Left.Controls.Add(btn);
                        break;
                    default:
                        btn.ForeColor = Color.Crimson;
                        btn.BackColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        //Đưa các control button vào 1 flowLayoutPanel để hiển thị ra cho User
                        FlowLayoutPanel_Left.Controls.Add(btn);
                        break;
                }

            }    
        }
        void ShowBillDetails(string tableID)
        {
            listView1.Items.Clear();
            //tableID => BillID => PaymentID
            //Tạo ra được List các Hoá đơn cần thiết
            //List<Payment> listBillInfo = PaymentConnect.Instance.GetListBillInfo(BillConnect.Instance.GetUncheckedBillIDbyTableID(tableID));
            //MessageBox.Show(tableID);
            List<Menu> listMenuInfo = MenuConnect.Instance.GetMenuInfo(tableID);
            //Hiển thị ra bằng listView
            //Với mỗi hoá đơn trong List hoá đơn sẽ đưa vào item của ListView
            foreach(Menu item in listMenuInfo)
            {
               
                //item ID thức ăn được đưa vào 1 ListViewItem
                ListViewItem listViewItem = new ListViewItem(item.Name.ToString());

                //Lần lượt add thêm các Item khác
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.Discount.ToString());
                listViewItem.SubItems.Add(item.FoodCount.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                //MessageBox.Show(item.Name.ToString());
                //Đưa các item đó vào giao diện ListView chính
                listView1.Items.Add(listViewItem);

                
                TotalPrice += item.TotalPrice;

            }    

        }
        void Btn_Click(object sender, EventArgs e)
        {
            //try
            //{
                //Goi tới hàm show Hoá đơn của bàn ăn đó ra
                string tableID = ((sender as Button).Tag as Table).TableID;                     //gọi lại thông tin về table đã được lưu
                deletedTableID = tableID;
                selectedTableID = tableID;
                //MessageBox.Show(tableID);
                ShowBillDetails(tableID);
                TextBox_TotalPrice.Text = TotalPrice.ToString() + " VNĐ";
                TotalPrice = 0;

                TextBox_NumOfCustomers.Text = TableConnect.Instance.GetNumOfCustomersFromTableID(tableID).ToString();
                TextBox_PaidStatus.Text = TableConnect.Instance.PaidStatus(tableID);
                //deletedTableID = tableID;

            //}
            //catch
            //{

            //    listView1.Items.Clear();
            //    TextBox_NumOfCustomers.Text = "";
            //    TextBox_PaidStatus.Text = "";
            //    TextBox_TotalPrice.Text = "";
            //}
        }

        private void TableFoodManagement_Load(object sender, EventArgs e)
        {
            TextBox_TotalPrice.Text = TotalPrice.ToString();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            TextBox_NumOfCustomers.Text = "";
            TextBox_PaidStatus.Text = "";
            TextBox_TotalPrice.Text = "";
            LoadAllTables();
        }

        private void Label_TotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void Button_AddTable_Click(object sender, EventArgs e)
        {        
                    //try
                    //{

                            if (TableConnect.Instance.insertTable())
                            {
                                MessageBox.Show("Thêm bàn thành công.", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadAllTables();

                            }

                            else
                            {
                                MessageBox.Show("Thêm bàn không thành công.", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                    //}
                    //catch
                    //{
                    //    MessageBox.Show("Thêm bàn không thành công.", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}

        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand command = new SqlCommand("SELECT * FROM CustomerOrderTable where TableID = @TableID and CheckPay = 0", MY_DB.Instance.getConnection);
                command.Parameters.Add("@TableID", System.Data.SqlDbType.NVarChar).Value = deletedTableID;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                try
                {

                    if (table.Columns.Count != 4)
                    {
                        if (TableConnect.Instance.RemoveTable(deletedTableID))
                        {
                            MessageBox.Show("Xoá bàn thành công.", "Xoá bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllTables();
                        }
                        else
                        {
                            MessageBox.Show("Xoá bàn không thành công.", "Xoá bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bàn này đã có người đặt nên không thể xoá.", "Xoá bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch
                {
                    MessageBox.Show("Xoá bàn không thành công.", "Xoá bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Lựa chọn bàn để tiến hành xoá.", "Xoá bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            //try
            //{

                SqlCommand command = new SqlCommand("SELECT * FROM CustomerOrderTable where TableID = @TableID and CheckPay = 0", MY_DB.Instance.getConnection);
                command.Parameters.Add("@TableID", System.Data.SqlDbType.NVarChar).Value = selectedTableID;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                //try
                //{

                    if (table.Columns.Count == 4)
                    {
                        if (MenuConnect.Instance.PayingBill(selectedTableID))
                        {
                            MessageBox.Show("Thanh toán thành công.", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllTables();
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán không thành công.", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bàn này chưa được đặt", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                //}
                //catch
                //{
                //    MessageBox.Show("Thanh toán không thành công.", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            //}
            //catch
            //{
            //    MessageBox.Show("Lựa chọn bàn để tiến hành thanh toán.", "Thanh toán.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
