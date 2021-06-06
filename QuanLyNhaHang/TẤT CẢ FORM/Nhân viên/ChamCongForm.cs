using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.IO;

namespace QuanLyNhaHang
{
    public partial class ChamCongForm : Form
    {
        Wage wage = new Wage();
        public ChamCongForm()
        {
            InitializeComponent();
        }

        private void ChamCongForm_Load(object sender, EventArgs e)
        {
            dataGridView_ChamCong.DataSource = wage.getWage(DateTime.Now);
        }

        private void SaveToFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (.docx)|.docx";

            sfd.FileName = "DSChamCong.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView_ChamCong, sfd.FileName);
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
                        if (c == 1)
                        {
                            if (DataArray[r, c].ToString().Length > 2)
                            {
                                string bdate = DataArray[r, c].ToString();
                                string datenontime = "";
                                for (int i = 0; ; i++)
                                {
                                    if (bdate[i] == ' ')
                                        break;
                                    datenontime += bdate[i];
                                }
                            }
                            else
                                oTemp += " " + "\t";
                        }
                        else
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
                        "DANH SÁCH CHẤM CÔNG NHÂN VIÊN\n";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //Save Image


                //Save the file
                oDoc.SaveAs(filename);
            }
        }
        private void ToPrinterBtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDialog.Document = printDoc;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }
    }
}
