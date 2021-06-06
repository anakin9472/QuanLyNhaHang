using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class DetailEmployeeForm : Form
    {
        public DetailEmployeeForm()
        {
            InitializeComponent();
        }
        string empid;
        public DetailEmployeeForm(string id) : this()
        {
            empid = id;
        }

        Employee emp = new Employee();
        Role role = new Role();

        private void DetailEmployeeForm_Load(object sender, EventArgs e)
        {
            combobox_ChucVu.DataSource = role.getRole();
            combobox_ChucVu.DisplayMember = "RoleName";
            combobox_ChucVu.ValueMember = "RoleID";
            combobox_ChucVu.SelectedItem = null;


            DataTable tab = emp.getDetailEmployeeByEmployeeID(empid);

            textbox_IDNV.Text = tab.Rows[0][0].ToString();
            textBox_Ho.Text = tab.Rows[0][1].ToString();
            textBox_Tenlot.Text = tab.Rows[0][2].ToString();
            textBox_Ten.Text = tab.Rows[0][3].ToString();
            combobox_GioiTinh.SelectedItem = tab.Rows[0][4].ToString();
            datetimePicker_NgaySinh.Value = (DateTime)tab.Rows[0][5];
            textBox_DiaChi.Text = tab.Rows[0][6].ToString();
            textbox_Phone.Text = tab.Rows[0][7].ToString();
            textbox_Mail.Text = tab.Rows[0][8].ToString();
            combobox_ChucVu.SelectedValue = tab.Rows[0][10].ToString();
            textbox_Luong.Text = tab.Rows[0][11].ToString();
            if (tab.Rows[0][9] != DBNull.Value)
            {
                byte[] pic;
                pic = (byte[])tab.Rows[0][9];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox_Anh.Image = Image.FromStream(picture);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Anh.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    string eid = textbox_IDNV.Text;
                    string fname = textBox_Ho.Text;
                    string mname = textBox_Tenlot.Text;
                    string lname = textBox_Ten.Text;
                    string gender = combobox_GioiTinh.SelectedItem.ToString();
                    DateTime bdate = datetimePicker_NgaySinh.Value;
                    double salary = Double.Parse(textbox_Luong.Text);
                    string phone = textbox_Phone.Text;
                    string email = textbox_Mail.Text;
                    int role = Convert.ToInt32(combobox_ChucVu.SelectedValue);
                    string address = textBox_DiaChi.Text;
                    MemoryStream pic = new MemoryStream();
                    pictureBox_Anh.Image.Save(pic, pictureBox_Anh.Image.RawFormat);
                    int born_year = datetimePicker_NgaySinh.Value.Year;
                    int this_year = DateTime.Now.Year;
                    if (((this_year - born_year) < 18) || (this_year - born_year) > 50)
                        MessageBox.Show("The Employee Age Must Be Between 18 and 50", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (emp.updateEmployee(eid, fname, mname, lname, gender, bdate, salary, phone, email, role, address, pic))
                        {
                            MessageBox.Show("Cập nhật thông tin nhân viên " + textBox_Ho.Text + " " + textBox_Tenlot.Text + " " + textBox_Ten.Text + " thành công", "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật thông tin nhân viên " + textBox_Ho.Text + " " + textBox_Tenlot.Text + " " + textBox_Ten.Text, "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy điển đầy đủ thông tin nhân viên", "Cập nhật thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string id = textbox_IDNV.Text;

            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên " + textBox_Ho.Text + " " + textBox_Tenlot.Text + " " + textBox_Ten.Text, "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (emp.deleteEmployee(id))
                    {
                        MessageBox.Show("Nhân viên " + textBox_Ho.Text + " " + textBox_Tenlot.Text + " " + textBox_Ten.Text + " đã được xóa", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhân viên " + textBox_Ho.Text + " " + textBox_Tenlot.Text + " " + textBox_Ten.Text, "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool verif()
        {
            if (textbox_IDNV.Text.Trim() == ""
                || combobox_GioiTinh.SelectedItem == null
                || textBox_Ho.Text.Trim() == ""
                || textBox_Tenlot.Text.Trim() == ""
                || textBox_Ten.Text.Trim() == ""
                || textBox_DiaChi.Text.Trim() == ""
                || textbox_Phone.Text.Trim() == ""
                || textbox_Mail.Text.Trim() == ""
                || combobox_ChucVu.SelectedValue.ToString() == ""
                || textbox_Luong.Text == ""
                || combobox_GioiTinh.SelectedItem == null
                || datetimePicker_NgaySinh.Value == null)
                return false;
            else return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

