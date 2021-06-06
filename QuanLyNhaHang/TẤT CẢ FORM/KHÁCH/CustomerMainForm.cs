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
    public partial class CustomerMainForm : Form
    {
        public CustomerMainForm()
        {
            InitializeComponent();
            LoadForm();
        }
        ĐẶT_BÀN datBan = new ĐẶT_BÀN
        {
            TopLevel = false,
            TopMost = false
        };
        CHỌN_MÓN chonMon = new CHỌN_MÓN
        {
            TopLevel = false,
            TopMost = false
        };
        THÔNG_TIN_KHÁCH_HÀNG thongTinKhachHang = new THÔNG_TIN_KHÁCH_HÀNG
        {
            TopLevel = false,
            TopMost = false
        };
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadForm()
        {
            PanelDisplay.Controls.Add(datBan);
            PanelDisplay.Controls.Add(chonMon);
            PanelDisplay.Controls.Add(thongTinKhachHang);
        }
        void resetForm()
        {
            datBan.Hide();
            chonMon.Hide();
            thongTinKhachHang.Hide();
        }

        private void đĂTBANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetForm();
            datBan.Show();
        }

        private void cHONMONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetForm();
            chonMon.Show();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            BeginForm frm = new BeginForm();
            frm.Show();
        }

        private void guna2Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            BeginForm frm = new BeginForm();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tHÔNGTINKHACHHANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetForm();
            thongTinKhachHang.Show();

        }
    }
}
