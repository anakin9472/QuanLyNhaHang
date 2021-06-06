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
    public partial class LoginForm : Form
    {
        MY_DB mydb = new MY_DB();
        public string user;
        public string role;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Button_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    SqlCommand command = new SqlCommand();
                    Global.SetGlobalUserID(Employee.Instance.getUserIDbyUsername(TextBox_Username.Text));
                    //MessageBox.Show(Global.GlobalUserID);
                    if (RadioButton_Employee.Checked)
                    {
                        role = "Chef";
                        Global.SetRole(role);
                    }
                    else if (RadioButton_Manager.Checked)
                    {
                        role = "Manager";
                        Global.SetRole(role);
                    }
                    command.CommandText = "Select * From EmployeeAccount, EmployeeInfo " +
                    "WHERE EmployeeAccount.EmployeeID=EmployeeInfo.EmployeeID AND Password = @password and Username = @username and TypeEmployee = @role";
                    command.Connection = mydb.getConnection;
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = TextBox_Username.Text;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = TextBox_Password.Text;
                    command.Parameters.Add("@role", SqlDbType.NVarChar).Value = role;

                    //SqlDataAdapter: Đại diện cho một tập hợp các lệnh dữ liệu (Select/ Insert / Update / Delete
                    //và một kết nối cơ sở dữ liệu được sử dụng để điền vào DataSet và cập nhật cơ sở dữ liệu SQL Server. 
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if ((table.Rows.Count > 0))
                    {
                        MessageBox.Show("Đăng nhập thành công.", "Đăng nhập", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Hide();
                        MainForm frm = new MainForm();
                        frm.ShowDialog();
                        this.Close();
                       
                        //this.DialogResult=DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đăng nhập.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        bool verif()
        {
            if ((TextBox_Username.Text.Trim() == "") || (TextBox_Password.Text.Trim() == ""))
                return false;
            else
                return true;
        }

        private void LinkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Close();
            RegisterForm frm = new RegisterForm();
            frm.Show();
        }

        private void Button_Escape_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel_Register_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkLabel_Register_DoubleClick(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
        }

        private void Button_Enter_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    SqlCommand command = new SqlCommand();
                    Global.SetGlobalUserID(Employee.Instance.getUserIDbyUsername(TextBox_Username.Text));
                    //MessageBox.Show(Global.GlobalUserID);
                    if (RadioButton_Employee.Checked)
                    {
                        role = "Employee";
                        Global.SetRole(role);
                    }
                    else if (RadioButton_Manager.Checked)
                    {
                        role = "Manager";
                        Global.SetRole(role);
                    }
                    command.CommandText = "Select * From EmployeeAccount, EmployeeInfo " +
                    "WHERE EmployeeAccount.EmployeeID=EmployeeInfo.EmployeeID AND Password = @password and Username = @username and TypeEmployee = @role";
                    command.Connection = mydb.getConnection;
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = TextBox_Username.Text;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = TextBox_Password.Text;
                    command.Parameters.Add("@role", SqlDbType.NVarChar).Value = role;

                    //SqlDataAdapter: Đại diện cho một tập hợp các lệnh dữ liệu (Select/ Insert / Update / Delete
                    //và một kết nối cơ sở dữ liệu được sử dụng để điền vào DataSet và cập nhật cơ sở dữ liệu SQL Server. 
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if ((table.Rows.Count > 0))
                    {
                        MessageBox.Show("Đăng nhập thành công.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainForm frm = new MainForm();
                        frm.ShowDialog();
                        this.Close();

                        //this.DialogResult=DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đăng nhập.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
