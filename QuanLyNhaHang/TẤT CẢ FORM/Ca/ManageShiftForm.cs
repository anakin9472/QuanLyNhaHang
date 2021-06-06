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
    public partial class ManageShiftForm : Form
    {
        Period per = new Period();
        Role role = new Role();
        public ManageShiftForm()
        {
            InitializeComponent();
        }

        private void ManagePeriod_Load(object sender, EventArgs e)
        {
            dataGridView_Ca.DataSource = per.getPeriod();
            formatWidth();
            comboBox_ChucVu.DataSource = role.getRole();
            comboBox_ChucVu.DisplayMember = "RoleName";
            comboBox_ChucVu.ValueMember = "RoleID";
        }
        private void formatWidth()
        {
            dataGridView_Ca.ReadOnly = true;
            dataGridView_Ca.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridView_Ca.Columns.Count; i++)
            {
                dataGridView_Ca.Columns[i].Width = dataGridView_Ca.Width / dataGridView_Ca.Columns.Count - 10;
            }
            dataGridView_Ca.Columns[2].DefaultCellStyle.Format = "HH:mm:ss";
            dataGridView_Ca.Columns[3].DefaultCellStyle.Format = "HH:mm:ss";
        }
        private void button_DeleteShift_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_MaCa.Text.Trim() != "")
                {
                    int perid = Convert.ToInt32(textBox_MaCa.Text);
                    if ((MessageBox.Show("Bạn có chắc chắn là muốn xóa ca này?", "Quản lý ca", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                        if (per.deletePeriod(perid))
                        {
                            MessageBox.Show("Ca này đã được xóa", "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ManagePeriod_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_EditShift_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_MaCa.Text.Trim() != "")
                {
                    int perid = Convert.ToInt32(textBox_MaCa.Text);
                    string name = textBox_TenCa.Text;
                    DateTime timestart = dateTimePicker_BatDauca.Value;
                    DateTime timeend = dateTimePicker_KetThucCA.Value;
                    int employeequantity = Convert.ToInt32(numericUpDown_Soluongnhanvien.Text);
                    int roleid = Convert.ToInt32(comboBox_ChucVu.SelectedValue.ToString());
                    if (per.updatePeriod(perid, name, timestart, timeend, employeequantity, roleid))
                    {
                        MessageBox.Show("Ca đã được thay đổi thành công!", "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManagePeriod_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_InsertShift_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_MaCa.Text.Trim() != "")
                {
                    int perid = Convert.ToInt32(textBox_MaCa.Text);
                    string name = textBox_TenCa.Text;
                    DateTime timestart = dateTimePicker_BatDauca.Value;
                    DateTime timeend = dateTimePicker_KetThucCA.Value;
                    int employeequantity = Convert.ToInt32(numericUpDown_Soluongnhanvien.Text);
                    int roleid = Convert.ToInt32(comboBox_ChucVu.SelectedValue.ToString());
                    if (per.insertPeriod(perid, name, timestart, timeend, employeequantity, roleid))
                    {
                        MessageBox.Show("Đã thêm ca mới thành công", "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManagePeriod_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Quản lý ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Period_Click(object sender, EventArgs e)
        {
            textBox_MaCa.Text = dataGridView_Ca.CurrentRow.Cells[0].Value.ToString();
            textBox_TenCa.Text = dataGridView_Ca.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker_BatDauca.Value = (DateTime)dataGridView_Ca.CurrentRow.Cells[2].Value;
            dateTimePicker_KetThucCA.Value = (DateTime)dataGridView_Ca.CurrentRow.Cells[3].Value;
            numericUpDown_Soluongnhanvien.Text = dataGridView_Ca.CurrentRow.Cells[4].Value.ToString();
            comboBox_ChucVu.SelectedValue = dataGridView_Ca.CurrentRow.Cells[5].Value.ToString();

        }
    }
}