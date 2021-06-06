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
    public partial class SplitShiftForm : Form
    {
        Works wor = new Works();
        Employee emp = new Employee();
        Period per = new Period();
        int numberofemloyees;
        int numberofperiod;
        int numberofedit;
        public SplitShiftForm()
        {
            InitializeComponent();
            numberofedit = 2;
        }

        private void ChiaCa_Load(object sender, EventArgs e)
        {
            try
            {
                numberofemloyees = emp.getEmployeeID().Rows.Count;
                numberofperiod = per.getPeriod().Rows.Count;
                //DateTime startdate = DateTime.Now;
                dataGridView_Chiaca.RowTemplate.Height = 80;
                dataGridView_Chiaca.DataSource = wor.getShiftWork("");
                formatDataGridView();
                label_NumberEmployee.Text = dataGridView_Chiaca.RowCount + "/" + numberofemloyees + " Employees";
                label_NumberPeriod.Text = numberofperiod + " Periods";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        void formatDataGridView()
        {
            dataGridView_Chiaca.ReadOnly = true;
            dataGridView_Chiaca.AllowUserToAddRows = false;
            dataGridView_Chiaca.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dataGridView_Chiaca.Columns[0].Width = 80;
            dataGridView_Chiaca.Columns[1].Width = 108;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView_Chiaca.Columns[0];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            if (dataGridView_Chiaca.Rows.Count > 1)
            {
                for (; numberofedit < dataGridView_Chiaca.Columns.Count; numberofedit++)
                {
                    string temp = dataGridView_Chiaca.Columns[numberofedit].HeaderCell.Value.ToString();
                    var date = DateTime.Parse(temp);
                    string datewithmonday = String.Format("{0:ddd: dd/MM}", date);
                    dataGridView_Chiaca.Columns[numberofedit].HeaderCell.Value = datewithmonday;
                }
            }
        }
        private void button_Chiaca_Click(object sender, EventArgs e)
        {
            //var datetime = DateTime.Now.AddDays(-2);
            var datetime = DateTime.Now;
            if (wor.getWorks().Rows.Count > 0)
                datetime = DateTime.Parse(wor.getWorks().Rows[0][0].ToString());
            DateTime start = datetime;

            if ((MessageBox.Show("Bạn có chắc là muốn chia ca? Chương trình sẽ tiến hành chia ca từ ngày " + String.Format("{0:dddd: dd/MM}", start.AddDays(1)), "Chia ca", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                Role role = new Role();
                DataTable tablerole = role.getRole();
                int[] chiadeu = new int[tablerole.Rows.Count];
                for (int i = 0; i < tablerole.Rows.Count; i++)
                {
                    //Lấy ra ca thuộc role thứ i
                    DataTable table = per.getPeriodID(Convert.ToInt32(tablerole.Rows[i][0].ToString()));
                    DataTable tableemp = emp.getEmployeeIDByRoleID(Convert.ToInt32(tablerole.Rows[i][0].ToString()));
                    int[] SoNVTrenMotCa = new int[table.Rows.Count];
                    int[] Ca = new int[table.Rows.Count];
                    string[] MaNV = new string[tableemp.Rows.Count];
                    for (int z = 0; z < tableemp.Rows.Count; z++)
                    {
                        MaNV[z] = tableemp.Rows[z][0].ToString();
                    }
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        Ca[j] = Convert.ToInt32(table.Rows[j][0].ToString());
                        SoNVTrenMotCa[j] = Convert.ToInt32(table.Rows[j][1].ToString());
                    }
                    try
                    {
                        chiadeu[i] = wor.updateChiaca(tableemp.Rows.Count, MaNV, table.Rows.Count, Ca, SoNVTrenMotCa, start);

                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                List<int> listchiathieu = new List<int>();
                int boichung = BCNN_Mang(chiadeu, tablerole.Rows.Count);
                for (int i = 0; i < tablerole.Rows.Count; i++)
                    for (int j = 0; j < (boichung / chiadeu[i]) - 1; j++)
                        listchiathieu.Add(Convert.ToInt32(tablerole.Rows[i][0].ToString()));
                for (int i = 0; i < listchiathieu.Count; i++)
                {
                    //var datetime2 = DateTime.Now.AddDays(-2);
                    var datetime2 = DateTime.Now;
                    if (wor.getWorks().Rows.Count > 0)
                        datetime2 = DateTime.Parse(wor.getWorksDate(listchiathieu[i]).Rows[0][0].ToString());
                    DateTime start2 = datetime2;
                    //Lấy ra ca thuộc role thứ i
                    DataTable table = per.getPeriodID(listchiathieu[i]);
                    DataTable tableemp = emp.getEmployeeIDByRoleID(listchiathieu[i]);
                    int[] SoNVTrenMotCa = new int[table.Rows.Count];
                    int[] Ca = new int[table.Rows.Count];
                    string[] MaNV = new string[tableemp.Rows.Count];
                    for (int z = 0; z < tableemp.Rows.Count; z++)
                    {
                        MaNV[z] = tableemp.Rows[z][0].ToString();
                    }
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        Ca[j] = Convert.ToInt32(table.Rows[j][0].ToString());
                        SoNVTrenMotCa[j] = Convert.ToInt32(table.Rows[j][1].ToString());
                    }
                    try
                    {
                        chiadeu[i] = wor.updateChiaca(tableemp.Rows.Count, MaNV, table.Rows.Count, Ca, SoNVTrenMotCa, start2);

                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Chia ca thành công!", "Chia ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int UCLN(int a, int b)
        {
            if (a == b)
                return a;
            if (a > b)
                return UCLN(a - b, b);
            else
                return UCLN(a, b - a);
        }
        private int BCNN(int a, int b)
        {
            return (a * b / UCLN(a, b));
        }
        private int BCNN_Mang(int[] a, int n)
        {
            int temp = BCNN(a[0], a[1]);
            for (int i = 2; i < n; i++)
            {
                temp = BCNN(temp, a[i]);
            }
            return temp;
        }

        private void gunaPictureBox_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Chiaca.DataSource = wor.getShiftWork(gunaTextBox_Timkiem.Text);
            formatDataGridView();
        }

        private void button_Ca_Click(object sender, EventArgs e)
        {
            ManageShiftForm form = new ManageShiftForm();
            form.Show();
            //ChiaCa_Load(null,null);
        }

        private void button_NhanVien_Click(object sender, EventArgs e)
        {
            ManageEmployeeForm form = new ManageEmployeeForm();
            form.Show();
            //ChiaCa_Load(null,null);
        }

        private void buttonChamCong_Click(object sender, EventArgs e)
        {
            ChamCongForm form = new ChamCongForm();
            form.Show();
        }
    }
}
