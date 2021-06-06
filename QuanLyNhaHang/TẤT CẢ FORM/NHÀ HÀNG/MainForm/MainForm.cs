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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadForm();
        }

        TableFoodManagement tableFoodManagement = new TableFoodManagement()
        {
            TopLevel = false,
            TopMost = false
        };
        CheckFoodService checkFoodService = new CheckFoodService()
        {
            TopLevel = false,
            TopMost = false
        };
        FoodManagement foodManagement = new FoodManagement()
        {
            TopLevel = false,
            TopMost = false
        };
        ListBills listBills = new ListBills()
        {
            TopLevel = false,
            TopMost = false
        };

        ManageEmployeeForm manageEmployeeForm = new ManageEmployeeForm()
        {
            TopLevel = false,
            TopMost = false
        };
        DetailEmployeeForm detailEmployeeForm = new DetailEmployeeForm()
        {
            TopLevel = false,
            TopMost = false
        }
        ;
        RegisterForm registerForm = new RegisterForm()
        {
            TopLevel = false,
            TopMost = false
        };
        ChamCongForm chamCongForm = new ChamCongForm()
        {
            TopLevel = false,
            TopMost = false
        };
        ManageShiftForm manageShiftForm = new ManageShiftForm()
        {
            TopLevel = false,
            TopMost = false
        };
        SplitShiftForm splitShiftForm = new SplitShiftForm()
        {
            TopLevel = false,
            TopMost = false
        };
        CheckInOutForm checkInOutForm = new CheckInOutForm()
        {
            TopLevel = false,
            TopMost = false
        };


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void qUANLYBANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            foodManagement.Show();
        }


        void LoadForm()
        {
            if (Global.Role == "Employee" )
            {
                qUANLYNHÂNVIÊNToolStripMenuItem.Visible = false;
                cHIACAToolStripMenuItem.Visible = false;
            }
            PanelDisplay.Controls.Add(tableFoodManagement);
            PanelDisplay.Controls.Add(checkFoodService);
            PanelDisplay.Controls.Add(foodManagement);
            PanelDisplay.Controls.Add(listBills);
            PanelDisplay.Controls.Add(manageEmployeeForm);
            PanelDisplay.Controls.Add(detailEmployeeForm);
            PanelDisplay.Controls.Add(registerForm);
            PanelDisplay.Controls.Add(chamCongForm);
            PanelDisplay.Controls.Add(manageShiftForm);
            PanelDisplay.Controls.Add(splitShiftForm);
            PanelDisplay.Controls.Add(checkInOutForm);
        }
        void ResetForm()
        {
            tableFoodManagement.Hide();

            checkFoodService.Hide();

            foodManagement.Hide();

            listBills.Hide();

            manageEmployeeForm.Hide();

            detailEmployeeForm.Hide();

            registerForm.Hide();

            chamCongForm.Hide();

            manageShiftForm.Hide();

            splitShiftForm.Hide();

            checkInOutForm.Hide();
        }
        private void qUANLYBANVAKHACHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            tableFoodManagement.Show();
        }

        private void kHACHHANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            checkFoodService.Show();
        }

        private void PanelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            BeginForm frm = new BeginForm();
            frm.Show();
        }

        private void tHÔNGKÊVADOANHTHUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            listBills.Show();
        }

        private void quảnLýNhânVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            manageEmployeeForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            detailEmployeeForm.Show();
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            registerForm.Show();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            chamCongForm.Show();
        }

        private void quảnLýCaLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            manageShiftForm.Show();
        }

        private void chiaCaLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            splitShiftForm.Show();
        }

        private void cHECKINOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            checkInOutForm.Show();
        }
    }
}
