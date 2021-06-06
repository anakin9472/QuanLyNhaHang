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
    public partial class CheckInOutForm : Form
    {
        Employee emp = new Employee();
        Works works = new Works();
        int currentperiod;
        public CheckInOutForm()
        {
            InitializeComponent();
            currentperiod = -1;
        }
        private void CheckInOut_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = emp.getEmployeeByEmployeeID(Global.GlobalUserID);
                DataTable table_work = works.getPeriodWork(Global.GlobalUserID, DateTime.Now);    //sửa DateTime.Now.AddDays() lại thành DateTime.Now()
                DataTable table_period = works.getCurrentPeriod(DateTime.Now);
                label_XinChao.Text = "Xin chào: " + table.Rows[0][1].ToString();
                if (table.Rows[0][9] != DBNull.Value)
                {
                    byte[] pic;
                    pic = (byte[])table.Rows[0][7];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox_Image.Image = Image.FromStream(picture);
                }
                string temp = "Các ca làm của bạn hôm nay là: ";
                for (int i = 0; i < table_work.Rows.Count; i++)
                    temp += table_work.Rows[i][0].ToString() + " ";
                label_Caccalamhomnay.Text = temp;
                if (table_period.Rows.Count == 1)
                {
                    currentperiod = Convert.ToInt32(table_period.Rows[0][0].ToString());
                    label_CaHienTai.Text = "Ca: " + table_period.Rows[0][0].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Chưa có ca làm", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        private void pictureBox_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_CheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (works.updatePeriod("checkin", Global.GlobalUserID, DateTime.Now, currentperiod, DateTime.Now, DateTime.Now))
                    MessageBox.Show("Check in thành công!", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Check in thất bại!", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button_CheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (works.updatePeriod("checkout", Global.GlobalUserID, DateTime.Now, currentperiod, DateTime.Now, DateTime.Now))
                    MessageBox.Show("Check out thành công!", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Check out thất bại!", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
