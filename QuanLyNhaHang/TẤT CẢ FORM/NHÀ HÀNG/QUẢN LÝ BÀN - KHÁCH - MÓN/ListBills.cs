using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;

namespace QuanLyNhaHang
{
    public partial class ListBills : Form
    {
        public ListBills()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListBills_Load(object sender, EventArgs e)
        {
            ReloadDataGridView();
        }


        void ReloadDataGridView()
        {
            //TextBox_FoodID.Enabled = true;
            DataTable table = MenuConnect.Instance.ShowAllCustomersWithBill();
            
            table.Columns["CustomerID"].ColumnName = "ID khách hàng";
            table.Columns["Name"].ColumnName = "Họ và tên";
            table.Columns["PhoneNumber"].ColumnName = "SĐT";
            table.Columns["TableID"].ColumnName = "Bàn";
            table.Columns["NumOfCustomers"].ColumnName = "SL khách";
            table.Columns["Bill_ID"].ColumnName = "ID hoá đơn";
            table.Columns["BillTotalPrice"].ColumnName = "Tổng hoá đơn";
            table.Columns["DayPaid"].ColumnName = "Ngày đặt";
            table.Columns["BillStatus"].ColumnName = "Tình trạng";
            DataGridView_ShowAllCustomersWithBill.DataSource = table;
           // DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView_ShowAllCustomersWithBill.RowTemplate.Height = 80;
            DataGridView_ShowAllCustomersWithBill.ColumnHeadersVisible = true;
            //picCol = (DataGridViewImageColumn)DataGridView_ShowAllCustomersWithBill.Columns[5];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // EditWidth(DataGridView_ShowAllCustomersWithBill);
            DataGridView_ShowAllCustomersWithBill.RowTemplate.Height = 120;
            DataGridView_ShowAllCustomersWithBill.AllowUserToAddRows = false;
            DataGridView_ShowAllCustomersWithBill.RowHeadersWidth = 80;
            DataGridView_ShowAllCustomersWithBill.Columns[0].Width = 110;
            DataGridView_ShowAllCustomersWithBill.Columns[1].Width = 180;
            DataGridView_ShowAllCustomersWithBill.Columns[2].Width = 100;
            DataGridView_ShowAllCustomersWithBill.Columns[3].Width = 70;
            DataGridView_ShowAllCustomersWithBill.Columns[4].Width = 80;
            DataGridView_ShowAllCustomersWithBill.Columns[5].Width = 50;
            DataGridView_ShowAllCustomersWithBill.Columns[6].Width = 120;
            DataGridView_ShowAllCustomersWithBill.Columns[7].Width = 120;
            DataGridView_ShowAllCustomersWithBill.Columns[5].Width = 120;
        }
        public void EditWidth(DataGridView dgv)
        {
            //Chỉnh lại kích thước của DataGridView
            dgv.RowTemplate.Height = 100;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersWidth = 20;
            dgv.Columns[0].Width = 30;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Height = 120;
            }
            //for (int i = 1; i < dgv.Columns.Count; i++)
            //{
            //    dgv.Columns[i].Width = 90;
            //}
            dgv.Columns[0].Width = 40;
            dgv.Columns[3].Width = 50;
            dgv.Columns[4].Width = 50;
            dgv.Columns[1].Width = 110;
            dgv.Columns[2].Width = 110;
            dgv.Columns[5].Width = 140;
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            DataTable table = MenuConnect.Instance.ShowAllCustomersWithBill();

            table.Columns["CustomerID"].ColumnName = "ID khách hàng";
            table.Columns["Name"].ColumnName = "Họ và tên";
            table.Columns["PhoneNumber"].ColumnName = "SĐT";
            table.Columns["TableID"].ColumnName = "Bàn";
            table.Columns["NumOfCustomers"].ColumnName = "SL khách";
            table.Columns["Bill_ID"].ColumnName = "ID hoá đơn";
            table.Columns["BillTotalPrice"].ColumnName = "Tổng hoá đơn";
            table.Columns["DayPaid"].ColumnName = "Ngày đặt";
            table.Columns["BillStatus"].ColumnName = "Tình trạng";
            DataGridView_ShowAllCustomersWithBill.DataSource = table;
            // DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView_ShowAllCustomersWithBill.RowTemplate.Height = 80;
            DataGridView_ShowAllCustomersWithBill.ColumnHeadersVisible = true;
            //picCol = (DataGridViewImageColumn)DataGridView_ShowAllCustomersWithBill.Columns[5];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // EditWidth(DataGridView_ShowAllCustomersWithBill);
            DataGridView_ShowAllCustomersWithBill.RowTemplate.Height = 120;
            DataGridView_ShowAllCustomersWithBill.AllowUserToAddRows = false;
            DataGridView_ShowAllCustomersWithBill.RowHeadersWidth = 80;
            DataGridView_ShowAllCustomersWithBill.Columns[0].Width = 110;
            DataGridView_ShowAllCustomersWithBill.Columns[1].Width = 180;
            DataGridView_ShowAllCustomersWithBill.Columns[2].Width = 100;
            DataGridView_ShowAllCustomersWithBill.Columns[3].Width = 70;
            DataGridView_ShowAllCustomersWithBill.Columns[4].Width = 80;
            DataGridView_ShowAllCustomersWithBill.Columns[5].Width = 50;
            DataGridView_ShowAllCustomersWithBill.Columns[6].Width = 120;
            DataGridView_ShowAllCustomersWithBill.Columns[7].Width = 120;
            DataGridView_ShowAllCustomersWithBill.Columns[5].Width = 120;
        }

        private void Button_NetWorth_Click(object sender, EventArgs e)
        {
            NetWorth frm = new NetWorth();
            frm.Show();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (.docx)|.docx";

            sfd.FileName = "DSHĐ.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(DataGridView_ShowAllCustomersWithBill, sfd.FileName);
                MessageBox.Show("Xuất File Word thành công", "Xuất File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            public void Export_Data_To_Word(DataGridView DataGridView, string filename)
            {
                if (DataGridView.Rows.Count != 0)
                {
                    int RowCount = DataGridView.Rows.Count;
                    int ColumnCount = DataGridView.Columns.Count;
                    Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                    //Add Rows
                    int r = 0;
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        for (r = 0; r <= RowCount - 1; r++)
                        {
                            DataArray[r, c] = DataGridView.Rows[r].Cells[c].Value;
                        }//End Row loop
                    }//End Column loop

                    Word.Document oDoc = new Word.Document();
                    oDoc.Application.Visible = true;

                    //Page orinatation
                    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                    dynamic oRange = oDoc.Content.Application.Selection.Range;
                    string oTemp = "";
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        for (int c = 0; c <= ColumnCount - 1; c++)
                        {
                            oTemp += DataArray[r, c] + "\t";
                        }
                    }
                    //Table Format
                    oRange.Text = oTemp;
                    object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                    object ApplyBorders = true;
                    object AutoFit = true;
                    object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                    oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                          Type.Missing, Type.Missing, ref ApplyBorders,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                    oRange.Select();

                    oDoc.Application.Selection.Tables[1].Select();
                    oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                    oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.InsertRowsAbove(1);
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();

                    //Header row style
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                    //Add header row manually
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DataGridView.Columns[c].HeaderText;
                    }

                    //Table Style
                    oDoc.Application.Selection.Tables[1].set_Style("Grid Table 5 Dark - Accent 3");     //Kiểu format table(có sẵn) trong Word
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    //Header test
                    foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                    {
                        Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                        headerRange.Text = "TRƯỜNG ĐẠI HỌC SPKT TP.HCM                                                                                "
                            + "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n" +
                            "               NHÀ HÀNG D&D                                                                                                                 "
                            + "Trang: 1\n" +
                            "DANH SÁCH HOÁ ĐƠN\n";
                        headerRange.Font.Size = 16;
                        headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }

                    //Save the file
                    oDoc.SaveAs(filename);
                }
            }



        }
    }

