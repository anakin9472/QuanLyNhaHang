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
    public partial class ĐẶT_BÀN : Form
    {
        Customer customer = new Customer();
        public ĐẶT_BÀN()
        {
            InitializeComponent();
        }

        public string CurrentTable_ID;


        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            BeginForm frm = new BeginForm();
            frm.Show();
        }

        private void Label_FoodName_Click(object sender, EventArgs e)
        {

        }

        private void labelAddNewEmployee_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (customer.CustomerIDAvailable(TextBox_CustomerID.Text))
            {
                FlowLayoutPanel_RightTop.Enabled = true;
                Panel_RightBottom.Enabled = true;
                TextBox_CustomerID.Enabled = false;
               // Button_Confirm.Enabled = false;
                Panel_LeftBottom.Enabled = true;

                DataTable table = customer.getCustomerByID(TextBox_CustomerID.Text);
                Object temp = table.Rows[0][1];
                TextBox_CustomerName.Text = temp.ToString();
                temp = table.Rows[0][2];
                ComboBox_Gender.SelectedValue = temp.ToString();
                temp = table.Rows[0][3];
                TextBox_PhoneNumber.Text = temp.ToString();
                temp = table.Rows[0][4];
                TextBox_Address.Text = temp.ToString();

                byte[] array = (byte[])table.Rows[0][5];
                MemoryStream ms = new MemoryStream(array);
                Image imgage = Image.FromStream(ms);
                 PictureBox_Customer.Image = imgage;

                FlowLayoutPanel_RightTop.Controls.Clear();
                LoadAllTablesWithCustomers();

                Global.SetGlobalCustomerID(TextBox_CustomerID.Text);

                //MessageBox.Show(Global.CustomerID);

                if (customer.Func_CustomerAlready(Global.CustomerID))
                {
                    Global.SetGlobalTableID(CurrentTable_ID);
                    //CHỌN_MÓN frm = new CHỌN_MÓN();
                    //frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Lỗi xác thực ID của khách hàng.", "Xác thực", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.pgn;*.gif)|*.jpg;*.png;*.gif";
            //Mở hộp thoại chọn hình ảnh ra và gán cho hình ảnh được chọn vào PictureBox
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBox_Customer.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string CustomerID = TextBox_CustomerID.Text;

                if (!customer.CustomerIDAvailable(CustomerID))
                {

                    try
                    {
                        if (!Verif())

                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {
                            string Gender = ComboBox_Gender.SelectedValue.ToString();
                            string Name = TextBox_CustomerName.Text;
                            string PhoneNumber = TextBox_PhoneNumber.Text;
                            string Address = TextBox_Address.Text;
                            

                            MemoryStream Picture = new MemoryStream();
                            PictureBox_Customer.Image.Save(Picture, PictureBox_Customer.Image.RawFormat);

                            if (customer.InsertCustomer(CustomerID, Name, Gender, PhoneNumber, Address, Picture))
                            {
                                MessageBox.Show("Đăng ký thành công.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Button_Edit.Enabled = true;
                                Panel_LeftBottom.Enabled = false;
                                FlowLayoutPanel_RightTop.Enabled = true;
                                Panel_RightBottom.Enabled = true;

                            }

                            else
                            {
                                MessageBox.Show("Đăng ký không thành công.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }

                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                else
                {
                    MessageBox.Show("ID này đã được sử dụng.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void ReloadComboBox()
        {
            ComboBox_Gender.DataSource = customer.getGender();
            ComboBox_Gender.ValueMember = "Gender";
            ComboBox_Gender.DisplayMember = "Gender";
            ComboBox_Gender.SelectedItem = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ĐẶT_BÀN_Load(object sender, EventArgs e)
        {
            ReloadComboBox();
            Panel_LeftBottom.Enabled = false;
            FlowLayoutPanel_RightTop.Enabled = false;
            Panel_RightBottom.Enabled = false;
            LoadAllTables();
            
        }


        bool Verif()
        {
            if ((TextBox_CustomerID.Text.Trim() == "") || (TextBox_CustomerName.Text.Trim() == "") || (ComboBox_Gender.SelectedValue == null) || (TextBox_PhoneNumber.Text.Trim() == "") || (TextBox_Address.Text.Trim() == "") || (PictureBox_Customer.Image == null))
                return false;
            return true;
        }

        private void TextBox_CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            if (!customer.CustomerIDAvailable(TextBox_CustomerID.Text))
            {
                Panel_LeftBottom.Enabled = true;
                //Button_Edit.Enabled = false;
            }
            else
            {
                MessageBox.Show("ID khách hàng này đã được đăng ký.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TextBox_CustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string CustomerID = TextBox_CustomerID.Text;

            //Kiểm tra đã đầy đủ thông tin chưa

            if (customer.CustomerIDAvailable(CustomerID))
            {

                if (!Verif())
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thay đổi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {


                    //if (customer.CustomerIDAvailable(CustomerID))
                    //{
                    //    MessageBox.Show("Không thể dùng ID này do đã có người sử dụng. ", "Thay đổi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}

                    //else
                    //{

                    string Gender = ComboBox_Gender.SelectedValue.ToString();
                    string Name = TextBox_CustomerName.Text;
                    string PhoneNumber = TextBox_PhoneNumber.Text;
                    string Address = TextBox_Address.Text;

                    MemoryStream picc = new MemoryStream();
                    PictureBox_Customer.Image.Save(picc, PictureBox_Customer.Image.RawFormat);

                    if (customer.EditCustomerInfo(CustomerID, Name, Gender, PhoneNumber, Address, picc))
                    {
                        MessageBox.Show("Thay đổi thông tin khách hàng thành công ", "Thay đổi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBox_CustomerID.Enabled = true;
                        Panel_LeftBottom.Enabled = false;
                        // Button_Register.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thông tin khách hàng không thành công ", "Thay đổi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //}

                }

            }

            else
            {
                MessageBox.Show("ID khách hàng này không tồn tại trong danh sách ", "Thay đổi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void LoadAllTables()
        {
            List<Table> tableList = TableConnect.Instance.LoadTableList();
            foreach (Table item in tableList)
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
                       

                        FlowLayoutPanel_RightTop.Controls.Add(btn);
                        break;


                    default:
                        btn.ForeColor = Color.Crimson;
                        btn.BackColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        
                        btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        //Đưa các control button vào 1 flowLayoutPanel để hiển thị ra cho User
                        FlowLayoutPanel_RightTop.Controls.Add(btn);
                        break;
                }

            }
        }

        void LoadAllTablesWithCustomers()
        {
            List<Table> tableList = TableConnect.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                //Mỗi table sẽ được hiển thị ra dưới dạng Control Button
                //Format lại Button 
                Button btn = new Button { Width = TableConnect.width, Height = TableConnect.height };
                btn.Text = item.TableID + Environment.NewLine + item.TableStatus /*+ Environment.NewLine + "SL khách: "*/;

                //Gọi tới event thực thi hiển thị hoá đơn của từng bàn cụ thể, mà mỗi bàn được thể hiện dưới dạng Control Button
                btn.Click += Btn_Click1;


                // Tag là một thuộc tính kiểu object, dùng để lưu những thứ cần thiết mà không phải tạo class mới inherit class gốc chỉ để lưu trữ thêm thông tin cần thiết
                btn.Tag = item;

                switch (item.TableStatus)
                {
                    case "Available":
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                        FlowLayoutPanel_RightTop.Controls.Add(btn);
                        break;


                    default:
                        btn.ForeColor = Color.Crimson;
                        btn.BackColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;

                        btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        //Đưa các control button vào 1 flowLayoutPanel để hiển thị ra cho User
                        FlowLayoutPanel_RightTop.Controls.Add(btn);
                        break;
                }

                if (customer.Func_FindTable(item.TableID,TextBox_CustomerID.Text))
                {
                    CurrentTable_ID = item.TableID;
                    Global.SetGlobalTableID(CurrentTable_ID);
                    btn.ForeColor = Color.Crimson;
                    btn.BackColor = Color.FromArgb(255, 234, 167);
                    btn.FlatStyle = FlatStyle.Flat;

                    btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }    

            }
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            string TableID = ((sender as Button).Tag as Table).TableID;                     //gọi lại thông tin về table đã được 
            TextBox_SelectedTable.Text = TableID;
            if (customer.Func_FindTable(TableID, TextBox_CustomerID.Text))
            {
                //SqlCommand command = new SqlCommand("SELECT NumOfCustomers FROM CustomerOrderTable WHERE TableID = @TableID");
                //command.Parameters.Add("@TableID", SqlDbType.NVarChar).Value = TableID;
                //command.Connection = MY_DB.Instance.getConnection;
                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                //DataTable table = new DataTable();
                //adapter.Fill(table);
                ComboBox_NumOfCustomers.SelectedIndex = customer.Func_GetNumOfCustomers(TableID) - 1;
            }
            else
            {
                ComboBox_NumOfCustomers.SelectedIndex = -1;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string customerid = TextBox_CustomerID.Text;
             string TableID = ((sender as Button).Tag as Table).TableID;                     //gọi lại thông tin về table đã được 
            TextBox_SelectedTable.Text = TableID;
            if (!TableConnect.Instance.Func_CheckAvailableTable(TableID))
            {
                SqlCommand command = new SqlCommand("SELECT NumOfCustomers FROM ReservationTable WHERE TableID = @TableID and CustomerID = @CustomerID");
                command.Parameters.Add("@TableID", SqlDbType.NVarChar).Value = TableID;
                command.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = customerid;
                command.Connection = MY_DB.Instance.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
       
                ComboBox_NumOfCustomers.SelectedIndex = Convert.ToInt32(table.Rows[0][0]) - 1;
                Global.SetGlobalTableID(TableID);
            }
            else
            {
                ComboBox_NumOfCustomers.SelectedIndex = -1;
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_OrderTable_Click(object sender, EventArgs e)
        {
            string tableID = TextBox_SelectedTable.Text;
            if (!TableConnect.Instance.Func_CheckAvailableTable(tableID))
            {
                MessageBox.Show("Bàn này đã có người đặt.", "Đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int NumOfCustomers = Convert.ToInt32(ComboBox_NumOfCustomers.SelectedItem);
                try
                {
                    if (NumOfCustomers == 0)
                    {
                        MessageBox.Show("Lỗi đặt bàn.", "Đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        if (customer.OrderTable(tableID, TextBox_CustomerID.Text, NumOfCustomers))
                        {
                            MessageBox.Show("Đặt bàn thành công. Vui lòng di chuyển tới mục chọn món.", "Đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Global.SetGlobalTableID(tableID);

                        }
                        else
                        {
                            MessageBox.Show("Đặt bàn không thành công. ", "Đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                 }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.Message + " \n" + "Đặt bàn không thành công. ", "Đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show(ex.Message + " \n" + "Vui lòng nhập số lượng khách tham gia. ", "Đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel_RightTop.Controls.Clear(); 
            LoadAllTablesWithCustomers();
            TextBox_SelectedTable.Text = "";
            ComboBox_NumOfCustomers.SelectedIndex = -1;
        }

        private void Table_EditNumOfCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ComboBox_NumOfCustomers.SelectedItem) > 0)
                {
                    if (customer.EditNumOfCustomers(TextBox_SelectedTable.Text, Convert.ToInt32(ComboBox_NumOfCustomers.SelectedItem)))
                    {
                        MessageBox.Show("Chỉnh sửa số lượng khách hàng thành công ", "Đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa số lượng khách hàng không thành công ", "Đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    
                }
                else
                {
                    MessageBox.Show("Bàn này chưa được đặt. ", "Đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show( "Bàn này chưa được đặt. ", "Đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_ChangeTable_Click(object sender, EventArgs e)
        {
            string NewTable_ID = TextBox_SelectedTable.Text;

            if (NewTable_ID == CurrentTable_ID)
            {
                MessageBox.Show("Chuyển bàn không thành công ", "Chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //try
                //{
                if (TableConnect.Instance.Func_CheckAvailableTable(NewTable_ID))
                {
                    //if (Convert.ToInt32(ComboBox_NumOfCustomers.SelectedItem) > 0)
                    int NumOfCustomers = customer.Func_GetNumOfCustomers(CurrentTable_ID);
                    //{
                    if (customer.ChangeTable(NewTable_ID, CurrentTable_ID, NumOfCustomers))
                    {
                        MessageBox.Show("Chuyển bàn thành công ", "Chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Global.SetGlobalTableID(NewTable_ID);
                    }
                    else
                    {
                        MessageBox.Show("Chuyển bàn không thành công ", "Chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Bàn này chưa được đặt. ", "Chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}


                }
                else
                {
                    MessageBox.Show("Bàn này đã được đặt. ", "Chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //}
                //catch
                //{
                //    MessageBox.Show("Không thể chuyển bàn. ", "Chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

            }







        }

        private void FlowLayoutPanel_RightTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
