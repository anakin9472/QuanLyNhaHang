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
    public partial class ManageEmployeeForm : Form
    {
        public ManageEmployeeForm()
        {
            InitializeComponent();
        }
        Employee emp = new Employee();

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            reload();
            datagridvie_Employee.AllowUserToAddRows = false;
            datagridvie_Employee.AllowUserToResizeRows = false;
            datagridvie_Employee.AllowUserToOrderColumns = false;
            datagridvie_Employee.AllowUserToResizeColumns = false;
        }

        void reload()
        {

            datagridvie_Employee.RowTemplate.Height = 80;
            datagridvie_Employee.DataSource = emp.getEmployee();
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)datagridvie_Employee.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            datagridvie_Employee.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            datagridvie_Employee.Columns[0].Width = 40;
            datagridvie_Employee.Columns[1].Width = 150;
            datagridvie_Employee.Columns[2].Width = 80;
            datagridvie_Employee.Columns[5].Width = 150;
            datagridvie_Employee.Columns[6].Width = 150;
            datagridvie_Employee.Columns[8].Width = 50;
            int tong = emp.getEmployee().Rows.Count;
            int male = emp.getMaleEmp().Rows.Count;
            label_ToTal.Text = "Tổng nhân viên " + tong.ToString();
            label_Male.Text = "Nam: " + male.ToString();
            label_Female.Text = "Nữ: " + (tong - male).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
            reload();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string id = datagridvie_Employee.CurrentRow.Cells[0].Value.ToString();
            DetailEmployeeForm frm = new DetailEmployeeForm(id);
            frm.ShowDialog();
            reload();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textbox_SearchID.Text == "")
                MessageBox.Show("Vui lòng điền ID");
            else
            {
                string searchid = textbox_SearchID.Text;
                DataTable tab = emp.getEmployeeByEmployeeID(searchid);

                if (tab.Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy ID " + textbox_SearchID.Text);
                else
                {
                    datagridvie_Employee.RowTemplate.Height = 80;
                    datagridvie_Employee.DataSource = tab;
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    //if(dgvEmp.Columns[9] != DBNull.Value)
                    //{ 
                    //}
                    picCol = (DataGridViewImageColumn)datagridvie_Employee.Columns[7];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    datagridvie_Employee.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                    datagridvie_Employee.Columns[0].Width = 40;
                    datagridvie_Employee.Columns[1].Width = 150;
                    datagridvie_Employee.Columns[2].Width = 80;
                    datagridvie_Employee.Columns[5].Width = 150;
                    datagridvie_Employee.Columns[6].Width = 150;
                    datagridvie_Employee.Columns[8].Width = 50;
                }
            }
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {

            datagridvie_Employee.RowTemplate.Height = 80;
            datagridvie_Employee.DataSource = emp.getFeMaleEmp();

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)datagridvie_Employee.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            datagridvie_Employee.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            datagridvie_Employee.Columns[0].Width = 40;
            datagridvie_Employee.Columns[1].Width = 150;
            datagridvie_Employee.Columns[2].Width = 80;
            datagridvie_Employee.Columns[5].Width = 150;
            datagridvie_Employee.Columns[6].Width = 150;
            datagridvie_Employee.Columns[8].Width = 50;
        }

        private void btnMale_Click(object sender, EventArgs e)
        {

            datagridvie_Employee.RowTemplate.Height = 80;
            datagridvie_Employee.DataSource = emp.getMaleEmp();

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)datagridvie_Employee.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            datagridvie_Employee.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            datagridvie_Employee.Columns[0].Width = 40;
            datagridvie_Employee.Columns[1].Width = 150;
            datagridvie_Employee.Columns[2].Width = 80;
            datagridvie_Employee.Columns[5].Width = 150;
            datagridvie_Employee.Columns[6].Width = 150;
            datagridvie_Employee.Columns[8].Width = 50;
        }


        private void btnSearchName_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            if (textbox_SearchName.Text != "")
            {
                string searchname = textbox_SearchName.Text;
                //fill dgv
                datagridvie_Employee.RowTemplate.Height = 80;
                datagridvie_Employee.DataSource = emp.getEmployeeByEmployeeName(searchname);
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)datagridvie_Employee.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                datagridvie_Employee.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                datagridvie_Employee.Columns[0].Width = 40;

                datagridvie_Employee.Columns[1].Width = 150;
                datagridvie_Employee.Columns[2].Width = 80;
                datagridvie_Employee.Columns[5].Width = 150;
                datagridvie_Employee.Columns[6].Width = 150;
                datagridvie_Employee.Columns[8].Width = 50;
            }
            else
            {
                MessageBox.Show("Hãy điền tên nhân viên!!!", "Tìm kiếm theo tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
