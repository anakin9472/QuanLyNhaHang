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
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
        }

        private void buttonNaptien_Click(object sender, EventArgs e)
        {
            CustomerMainForm frm = new CustomerMainForm();
            //this.Close();
            frm.ShowDialog();
        }

        private void Button_EmployeeLogin_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            //this.Close();
            frm.ShowDialog();
        }

        private void BeginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
