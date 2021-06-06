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
    public partial class RegisterForm : Form
    {
        string current_eid;
        Employee employee = new Employee();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void labelAddNewEmployee_Click(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void labelSalary_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            ComboBox_SelectRole.DataSource = Employee.Instance.getAllEmpTypes();
            ComboBox_SelectRole.DisplayMember = "RoleName";
            ComboBox_SelectRole.ValueMember = "RoleId";
            ComboBox_SelectRole.SelectedItem = null;

            //Step 1
            radioButtonMale.Checked = true;
            //Step 2
            labelNext.Visible = false;
            pictureBoxNext.Visible = false;

            textBoxUsername.Enabled = false;
            textBoxPassword.Enabled = false;
            textBoxConfirmPassword.Enabled = false;
            ButtonRegisterAccount.Enabled = false;
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.pgn;*.gif)|*.jpg;*.png;*.gif";
            //Mở hộp thoại chọn hình ảnh ra và gán cho hình ảnh được chọn vào PictureBox
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonRegisterInformation_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (verifInformation())
                {
                    string eid = textBoxEmployeeID.Text;
                    string fname = textBoxFirstName.Text;
                    string mname = textBoxMiddleName.Text;
                    string lname = textBoxLastName.Text;
                    string gender = "Nam";
                    if (radioButtonFemale.Checked)
                        gender = "Nữ";
                    DateTime bdate = dateTimePickerBirthdate.Value;
                    double salary = Double.Parse(textBoxSalary.Text);
                    string phone = textBoxPhone.Text;
                    string email = textBoxEmail.Text;
                    string role = ComboBox_SelectRole.SelectedValue.ToString();
                    string address = textBoxAddress.Text;

                    MemoryStream pic = new MemoryStream();
                    pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);

                    int born_year = dateTimePickerBirthdate.Value.Year;
                    int this_year = DateTime.Now.Year;
                    if (((this_year - born_year) < 18) || (this_year - born_year) > 50)
                        MessageBox.Show("Nhân viên phải có độ tuổi từ 18 đến 50.", "Lỗi thêm hồ sơ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (employee.InsertEmployeeInfor(eid, fname, mname, lname, gender, bdate, salary, phone, email, role, address, pic))
                        {
                            //Get eid to create account
                            current_eid = eid;
                            //Disable Register in current steps
                            buttonRegisterInformation.Enabled = false;
                            //Enable Controls in next steps
                            labelNext.Visible = true;
                            pictureBoxNext.Visible = true;
                            textBoxUsername.Enabled = true;
                            textBoxPassword.Enabled = true;
                            textBoxConfirmPassword.Enabled = true;
                            ButtonRegisterAccount.Enabled = true;
                            MessageBox.Show("Nhân viên thêm thành công.", "Thêm hồ sơ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không thể thêm hồ sơ.", "Thêm hồ sơ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thêm hồ sơ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifAccount())
                {
                    if (textBoxPassword.Text == textBoxConfirmPassword.Text)
                    {
                        string user = textBoxUsername.Text;
                        string pass = textBoxPassword.Text;
                        string roleID = ComboBox_SelectRole.SelectedValue.ToString();
                        string role = employee.getRoleFromRoleID(roleID);
                        if (employee.checkAvailableUsername(user))
                            if (employee.InsertEmployeeAccount(current_eid, user, pass, role))
                            {
                                //Step 1
                                buttonRegisterInformation.Enabled = true;
                                //Step 2
                                labelNext.Visible = false;
                                pictureBoxNext.Visible = false;
                                textBoxUsername.Text = "";
                                textBoxPassword.Text = "";
                                textBoxConfirmPassword.Text = "";
                                textBoxUsername.Enabled = false;
                                textBoxPassword.Enabled = false;
                                textBoxConfirmPassword.Enabled = false;
                                ButtonRegisterAccount.Enabled = false;
                                MessageBox.Show("Đăng ký tài khoản nhân viên thành công.", "Đăng ký tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Lỗi đăng ký tài khoản.", "Add New Employee Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Tên đăng nhập đã được sử dụng.", "Đăng ký tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Mật khẩu xác nhận không trùng khớp.", "Đăng ký tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Đăng ký tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        bool verifInformation()
        {
            if ((textBoxEmployeeID.Text.Trim() == "")
                || (textBoxFirstName.Text.Trim() == "")
                || (textBoxMiddleName.Text.Trim() == "")
                || (textBoxLastName.Text.Trim() == "")
                || (textBoxSalary.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (textBoxEmail.Text.Trim() == "")
                || (ComboBox_SelectRole.SelectedValue == null)
                || (textBoxAddress.Text.Trim() == "")
                || (pictureBoxImage.Image == null))
                return false;
            else
                return true;
        }
        bool verifAccount()
        {
            if ((textBoxUsername.Text.Trim() == "")
                || (textBoxPassword.Text.Trim() == "")
                || (textBoxConfirmPassword.Text.Trim() == ""))
                return false;
            else
                return true;
        }



    }
}
