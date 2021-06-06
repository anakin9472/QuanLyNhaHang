
namespace QuanLyNhaHang
{
    partial class ListBills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label_TableManagement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView_ShowAllCustomersWithBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Button_NetWorth = new Guna.UI2.WinForms.Guna2Button();
            this.Print = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ShowAllCustomersWithBill)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_TableManagement
            // 
            this.Label_TableManagement.AutoSize = true;
            this.Label_TableManagement.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label_TableManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TableManagement.ForeColor = System.Drawing.Color.White;
            this.Label_TableManagement.Location = new System.Drawing.Point(484, 32);
            this.Label_TableManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TableManagement.Name = "Label_TableManagement";
            this.Label_TableManagement.Size = new System.Drawing.Size(427, 51);
            this.Label_TableManagement.TabIndex = 53;
            this.Label_TableManagement.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.Button_NetWorth);
            this.panel1.Controls.Add(this.Button_Refresh);
            this.panel1.Controls.Add(this.DataGridView_ShowAllCustomersWithBill);
            this.panel1.Controls.Add(this.Label_TableManagement);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 685);
            this.panel1.TabIndex = 54;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.BorderColor = System.Drawing.Color.Crimson;
            this.Button_Refresh.BorderRadius = 10;
            this.Button_Refresh.BorderThickness = 2;
            this.Button_Refresh.CheckedState.Parent = this.Button_Refresh;
            this.Button_Refresh.CustomImages.Parent = this.Button_Refresh;
            this.Button_Refresh.FillColor = System.Drawing.Color.White;
            this.Button_Refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Refresh.ForeColor = System.Drawing.Color.Crimson;
            this.Button_Refresh.HoverState.Parent = this.Button_Refresh;
            this.Button_Refresh.Location = new System.Drawing.Point(1145, 32);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.PressedColor = System.Drawing.Color.Crimson;
            this.Button_Refresh.ShadowDecoration.Parent = this.Button_Refresh;
            this.Button_Refresh.Size = new System.Drawing.Size(156, 57);
            this.Button_Refresh.TabIndex = 179;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // DataGridView_ShowAllCustomersWithBill
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_ShowAllCustomersWithBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_ShowAllCustomersWithBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_ShowAllCustomersWithBill.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_ShowAllCustomersWithBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_ShowAllCustomersWithBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_ShowAllCustomersWithBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_ShowAllCustomersWithBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_ShowAllCustomersWithBill.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_ShowAllCustomersWithBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_ShowAllCustomersWithBill.EnableHeadersVisualStyles = false;
            this.DataGridView_ShowAllCustomersWithBill.GridColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_ShowAllCustomersWithBill.Location = new System.Drawing.Point(13, 117);
            this.DataGridView_ShowAllCustomersWithBill.Name = "DataGridView_ShowAllCustomersWithBill";
            this.DataGridView_ShowAllCustomersWithBill.RowHeadersVisible = false;
            this.DataGridView_ShowAllCustomersWithBill.RowHeadersWidth = 51;
            this.DataGridView_ShowAllCustomersWithBill.RowTemplate.Height = 24;
            this.DataGridView_ShowAllCustomersWithBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_ShowAllCustomersWithBill.Size = new System.Drawing.Size(1308, 543);
            this.DataGridView_ShowAllCustomersWithBill.TabIndex = 54;
            this.DataGridView_ShowAllCustomersWithBill.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.HeaderStyle.Height = 27;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.ReadOnly = false;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_ShowAllCustomersWithBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Button_NetWorth
            // 
            this.Button_NetWorth.BorderColor = System.Drawing.Color.Crimson;
            this.Button_NetWorth.BorderRadius = 10;
            this.Button_NetWorth.BorderThickness = 2;
            this.Button_NetWorth.CheckedState.Parent = this.Button_NetWorth;
            this.Button_NetWorth.CustomImages.Parent = this.Button_NetWorth;
            this.Button_NetWorth.FillColor = System.Drawing.Color.White;
            this.Button_NetWorth.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_NetWorth.ForeColor = System.Drawing.Color.Crimson;
            this.Button_NetWorth.HoverState.Parent = this.Button_NetWorth;
            this.Button_NetWorth.Location = new System.Drawing.Point(86, 32);
            this.Button_NetWorth.Name = "Button_NetWorth";
            this.Button_NetWorth.PressedColor = System.Drawing.Color.Crimson;
            this.Button_NetWorth.ShadowDecoration.Parent = this.Button_NetWorth;
            this.Button_NetWorth.Size = new System.Drawing.Size(156, 57);
            this.Button_NetWorth.TabIndex = 180;
            this.Button_NetWorth.Text = "Doanh thu";
            this.Button_NetWorth.Click += new System.EventHandler(this.Button_NetWorth_Click);
            // 
            // Print
            // 
            this.Print.BorderColor = System.Drawing.Color.Crimson;
            this.Print.BorderRadius = 10;
            this.Print.BorderThickness = 2;
            this.Print.CheckedState.Parent = this.Print;
            this.Print.CustomImages.Parent = this.Print;
            this.Print.FillColor = System.Drawing.Color.White;
            this.Print.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.Color.Crimson;
            this.Print.HoverState.Parent = this.Print;
            this.Print.Location = new System.Drawing.Point(271, 32);
            this.Print.Name = "Print";
            this.Print.PressedColor = System.Drawing.Color.Crimson;
            this.Print.ShadowDecoration.Parent = this.Print;
            this.Print.Size = new System.Drawing.Size(156, 57);
            this.Print.TabIndex = 181;
            this.Print.Text = "Print";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // ListBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 683);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListBills";
            this.Text = "ListBills";
            this.Load += new System.EventHandler(this.ListBills_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ShowAllCustomersWithBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_TableManagement;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_ShowAllCustomersWithBill;
        private Guna.UI2.WinForms.Guna2Button Button_Refresh;
        private Guna.UI2.WinForms.Guna2Button Button_NetWorth;
        private Guna.UI2.WinForms.Guna2Button Print;
    }
}