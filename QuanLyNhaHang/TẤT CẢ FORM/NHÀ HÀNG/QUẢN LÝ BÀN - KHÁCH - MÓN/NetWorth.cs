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
using System.IO;

namespace QuanLyNhaHang
{
    public partial class NetWorth : Form
    {
        public NetWorth()
        {
            InitializeComponent();
        }

        private void NetWorth_Load(object sender, EventArgs e)
        {
            ReloadDataGridView_NetWorthPerDay();
            ReloadDataGridView_AllFoodSaleOfDay();
            ReloadDataGridView_BestSellingOfDay();
        }
        void ReloadDataGridView_NetWorthPerDay()
        {

            //DataGridView_NetWorthPerDay.DataSource = PaymentConnect.Instance.NetWorthPerDay();
            //TextBox_FoodID.Enabled = true;
            DataTable table = PaymentConnect.Instance.NetWorthPerDay();

            table.Columns["DayPaid"].ColumnName = "Ngày thanh toán";
            table.Columns["TotalPerday"].ColumnName = "Tổng doanh thu (VNĐ)";

            DataGridView_NetWorthPerDay.DataSource = table;
            // DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView_NetWorthPerDay.RowTemplate.Height = 80;
            DataGridView_NetWorthPerDay.ColumnHeadersVisible = true;
            //picCol = (DataGridViewImageColumn)DataGridView_ShowAllCustomersWithBill.Columns[5];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // EditWidth(DataGridView_ShowAllCustomersWithBill);

        }

        void ReloadDataGridView_AllFoodSaleOfDay()
        {

            //TextBox_FoodID.Enabled = true;
            DataTable table = PaymentConnect.Instance.AllFoodSaleOfDay();

            table.Columns["DayPaid"].ColumnName = "Ngày";
            table.Columns["FoodName"].ColumnName = "Món ăn";
            table.Columns["FoodCount"].ColumnName = "Số lượng";
            table.Columns["Price"].ColumnName = "Đơn giá";
            table.Columns["Discount"].ColumnName = "Khuyến mãi";
            table.Columns["Picture"].ColumnName = "Hình ảnh";
            DataGridView_AllFoodSaleOfDay.DataSource = table;
            // DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView_AllFoodSaleOfDay.RowTemplate.Height = 80;
            DataGridView_AllFoodSaleOfDay.ColumnHeadersVisible = true;


            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)DataGridView_AllFoodSaleOfDay.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;


            for (int i = 0; i < DataGridView_AllFoodSaleOfDay.Rows.Count; i++)
            {
                DataGridView_AllFoodSaleOfDay.Rows[i].Height = 50;
            }

        }


        void ReloadDataGridView_BestSellingOfDay()
        {

            //TextBox_FoodID.Enabled = true;
            DataTable table = PaymentConnect.Instance.BestSellingOfDay();

            table.Columns["DayPaid"].ColumnName = "Ngày";
            table.Columns["FoodName"].ColumnName = "Món ăn";
            table.Columns["MaxCount"].ColumnName = "Số lượng";
            table.Columns["Price"].ColumnName = "Đơn giá";
            table.Columns["Discount"].ColumnName = "Khuyến mãi";

            DataGridView_BestSellingOfDay.DataSource = table;
            // DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView_BestSellingOfDay.RowTemplate.Height = 80;
            DataGridView_BestSellingOfDay.ColumnHeadersVisible = true;


            


            for (int i = 0; i < DataGridView_AllFoodSaleOfDay.Rows.Count; i++)
            {
                DataGridView_AllFoodSaleOfDay.Rows[i].Height = 50;
            }

        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            ReloadDataGridView_NetWorthPerDay();
            ReloadDataGridView_AllFoodSaleOfDay();
            ReloadDataGridView_BestSellingOfDay();
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (.docx)|.docx";

            sfd.FileName = "ThongTinDoanhThu.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //Export_Data_To_Word(DataGridView_NetWorthPerDay, sfd.FileName);
                Export_Data_To_Word(DataGridView_BestSellingOfDay, sfd.FileName);
                //Export_Data_To_Word(DataGridView_BestSellingOfDay, sfd.FileName);
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
                        "THÔNG TIN DOANH THU\n";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //Save the file
                oDoc.SaveAs(filename);
            }
        }
    }
}
