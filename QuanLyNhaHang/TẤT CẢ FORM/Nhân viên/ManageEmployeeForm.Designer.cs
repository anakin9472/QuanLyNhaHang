
namespace QuanLyNhaHang
{
    partial class ManageEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployeeForm));
            this.pnData = new System.Windows.Forms.Panel();
            this.datagridvie_Employee = new System.Windows.Forms.DataGridView();
            this.button_Detail = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_ToTal = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.label_SearchID = new System.Windows.Forms.Label();
            this.label_Male = new System.Windows.Forms.Label();
            this.label_Female = new System.Windows.Forms.Label();
            this.button_Female = new System.Windows.Forms.Button();
            this.button_Male = new System.Windows.Forms.Button();
            this.button_SearchID = new System.Windows.Forms.Button();
            this.textbox_SearchID = new System.Windows.Forms.TextBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textbox_SearchName = new System.Windows.Forms.TextBox();
            this.button_SearchName = new System.Windows.Forms.Button();
            this.label_SearchName = new System.Windows.Forms.Label();
            this.label_DanhSachNhanVien = new System.Windows.Forms.Label();
            this.panel_Gender = new System.Windows.Forms.Panel();
            this.pnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridvie_Employee)).BeginInit();
            this.panel_Button.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.panel_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.datagridvie_Employee);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.Location = new System.Drawing.Point(0, 113);
            this.pnData.Margin = new System.Windows.Forms.Padding(4);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(1417, 514);
            this.pnData.TabIndex = 2;
            // 
            // datagridvie_Employee
            // 
            this.datagridvie_Employee.AllowUserToAddRows = false;
            this.datagridvie_Employee.AllowUserToDeleteRows = false;
            this.datagridvie_Employee.AllowUserToResizeColumns = false;
            this.datagridvie_Employee.AllowUserToResizeRows = false;
            this.datagridvie_Employee.BackgroundColor = System.Drawing.Color.White;
            this.datagridvie_Employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridvie_Employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridvie_Employee.ColumnHeadersHeight = 25;
            this.datagridvie_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridvie_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridvie_Employee.Location = new System.Drawing.Point(0, 0);
            this.datagridvie_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.datagridvie_Employee.Name = "datagridvie_Employee";
            this.datagridvie_Employee.ReadOnly = true;
            this.datagridvie_Employee.RowHeadersWidth = 25;
            this.datagridvie_Employee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagridvie_Employee.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridvie_Employee.Size = new System.Drawing.Size(1417, 514);
            this.datagridvie_Employee.TabIndex = 0;
            // 
            // button_Detail
            // 
            this.button_Detail.BackColor = System.Drawing.Color.White;
            this.button_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Detail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.button_Detail.Location = new System.Drawing.Point(32, 7);
            this.button_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.button_Detail.Name = "button_Detail";
            this.button_Detail.Size = new System.Drawing.Size(109, 39);
            this.button_Detail.TabIndex = 0;
            this.button_Detail.Text = "Chi tiết";
            this.button_Detail.UseVisualStyleBackColor = false;
            this.button_Detail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.White;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.button_Add.Location = new System.Drawing.Point(172, 7);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(119, 39);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Thêm mới";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label_ToTal
            // 
            this.label_ToTal.AutoSize = true;
            this.label_ToTal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ToTal.Location = new System.Drawing.Point(1137, 15);
            this.label_ToTal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ToTal.Name = "label_ToTal";
            this.label_ToTal.Size = new System.Drawing.Size(149, 25);
            this.label_ToTal.TabIndex = 4;
            this.label_ToTal.Text = "Tổng nhân viên:";
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.White;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.button_Refresh.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_Refresh.Location = new System.Drawing.Point(321, 7);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(109, 39);
            this.button_Refresh.TabIndex = 5;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel_Button
            // 
            this.panel_Button.BackColor = System.Drawing.Color.White;
            this.panel_Button.Controls.Add(this.button_Refresh);
            this.panel_Button.Controls.Add(this.label_ToTal);
            this.panel_Button.Controls.Add(this.button_Add);
            this.panel_Button.Controls.Add(this.button_Detail);
            this.panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Button.Location = new System.Drawing.Point(0, 627);
            this.panel_Button.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(1417, 57);
            this.panel_Button.TabIndex = 1;
            // 
            // label_SearchID
            // 
            this.label_SearchID.AutoSize = true;
            this.label_SearchID.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SearchID.Location = new System.Drawing.Point(16, 64);
            this.label_SearchID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SearchID.Name = "label_SearchID";
            this.label_SearchID.Size = new System.Drawing.Size(138, 30);
            this.label_SearchID.TabIndex = 1;
            this.label_SearchID.Text = "Tìm kiếm ID:";
            // 
            // label_Male
            // 
            this.label_Male.AutoSize = true;
            this.label_Male.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Male.Location = new System.Drawing.Point(271, 12);
            this.label_Male.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Male.Name = "label_Male";
            this.label_Male.Size = new System.Drawing.Size(54, 25);
            this.label_Male.TabIndex = 2;
            this.label_Male.Text = "Nam";
            // 
            // label_Female
            // 
            this.label_Female.AutoSize = true;
            this.label_Female.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Female.Location = new System.Drawing.Point(59, 12);
            this.label_Female.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Female.Name = "label_Female";
            this.label_Female.Size = new System.Drawing.Size(39, 25);
            this.label_Female.TabIndex = 3;
            this.label_Female.Text = "Nữ";
            // 
            // button_Female
            // 
            this.button_Female.BackColor = System.Drawing.Color.Transparent;
            this.button_Female.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Female.BackgroundImage")));
            this.button_Female.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Female.FlatAppearance.BorderSize = 0;
            this.button_Female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Female.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button_Female.Location = new System.Drawing.Point(11, 4);
            this.button_Female.Margin = new System.Windows.Forms.Padding(4);
            this.button_Female.Name = "button_Female";
            this.button_Female.Size = new System.Drawing.Size(40, 37);
            this.button_Female.TabIndex = 5;
            this.button_Female.UseVisualStyleBackColor = false;
            this.button_Female.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // button_Male
            // 
            this.button_Male.BackColor = System.Drawing.Color.Transparent;
            this.button_Male.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Male.BackgroundImage")));
            this.button_Male.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Male.FlatAppearance.BorderSize = 0;
            this.button_Male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Male.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button_Male.Location = new System.Drawing.Point(223, 6);
            this.button_Male.Margin = new System.Windows.Forms.Padding(4);
            this.button_Male.Name = "button_Male";
            this.button_Male.Size = new System.Drawing.Size(40, 37);
            this.button_Male.TabIndex = 6;
            this.button_Male.UseVisualStyleBackColor = false;
            this.button_Male.Click += new System.EventHandler(this.btnMale_Click);
            // 
            // button_SearchID
            // 
            this.button_SearchID.BackColor = System.Drawing.Color.Transparent;
            this.button_SearchID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SearchID.BackgroundImage")));
            this.button_SearchID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SearchID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SearchID.FlatAppearance.BorderSize = 0;
            this.button_SearchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchID.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button_SearchID.Location = new System.Drawing.Point(444, 63);
            this.button_SearchID.Margin = new System.Windows.Forms.Padding(4);
            this.button_SearchID.Name = "button_SearchID";
            this.button_SearchID.Size = new System.Drawing.Size(39, 31);
            this.button_SearchID.TabIndex = 7;
            this.button_SearchID.UseVisualStyleBackColor = false;
            this.button_SearchID.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textbox_SearchID
            // 
            this.textbox_SearchID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_SearchID.Location = new System.Drawing.Point(172, 62);
            this.textbox_SearchID.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_SearchID.Name = "textbox_SearchID";
            this.textbox_SearchID.Size = new System.Drawing.Size(265, 34);
            this.textbox_SearchID.TabIndex = 8;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.White;
            this.panel_Top.Controls.Add(this.button_Exit);
            this.panel_Top.Controls.Add(this.textbox_SearchName);
            this.panel_Top.Controls.Add(this.button_SearchName);
            this.panel_Top.Controls.Add(this.label_SearchName);
            this.panel_Top.Controls.Add(this.label_DanhSachNhanVien);
            this.panel_Top.Controls.Add(this.panel_Gender);
            this.panel_Top.Controls.Add(this.textbox_SearchID);
            this.panel_Top.Controls.Add(this.button_SearchID);
            this.panel_Top.Controls.Add(this.label_SearchID);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1417, 113);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Top_Paint);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.White;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.button_Exit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_Exit.Location = new System.Drawing.Point(1349, 0);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(68, 48);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textbox_SearchName
            // 
            this.textbox_SearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_SearchName.Location = new System.Drawing.Point(672, 62);
            this.textbox_SearchName.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_SearchName.Name = "textbox_SearchName";
            this.textbox_SearchName.Size = new System.Drawing.Size(265, 34);
            this.textbox_SearchName.TabIndex = 13;
            // 
            // button_SearchName
            // 
            this.button_SearchName.BackColor = System.Drawing.Color.Transparent;
            this.button_SearchName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SearchName.BackgroundImage")));
            this.button_SearchName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SearchName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SearchName.FlatAppearance.BorderSize = 0;
            this.button_SearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchName.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button_SearchName.Location = new System.Drawing.Point(947, 63);
            this.button_SearchName.Margin = new System.Windows.Forms.Padding(4);
            this.button_SearchName.Name = "button_SearchName";
            this.button_SearchName.Size = new System.Drawing.Size(39, 31);
            this.button_SearchName.TabIndex = 12;
            this.button_SearchName.UseVisualStyleBackColor = false;
            this.button_SearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // label_SearchName
            // 
            this.label_SearchName.AutoSize = true;
            this.label_SearchName.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SearchName.Location = new System.Drawing.Point(500, 64);
            this.label_SearchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SearchName.Name = "label_SearchName";
            this.label_SearchName.Size = new System.Drawing.Size(149, 30);
            this.label_SearchName.TabIndex = 11;
            this.label_SearchName.Text = "Tìm kiếm tên:";
            // 
            // label_DanhSachNhanVien
            // 
            this.label_DanhSachNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.label_DanhSachNhanVien.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DanhSachNhanVien.ForeColor = System.Drawing.Color.White;
            this.label_DanhSachNhanVien.Location = new System.Drawing.Point(500, 6);
            this.label_DanhSachNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DanhSachNhanVien.Name = "label_DanhSachNhanVien";
            this.label_DanhSachNhanVien.Size = new System.Drawing.Size(439, 42);
            this.label_DanhSachNhanVien.TabIndex = 10;
            this.label_DanhSachNhanVien.Text = "DANH SÁCH NHÂN VIÊN";
            this.label_DanhSachNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Gender
            // 
            this.panel_Gender.Controls.Add(this.button_Male);
            this.panel_Gender.Controls.Add(this.label_Male);
            this.panel_Gender.Controls.Add(this.label_Female);
            this.panel_Gender.Controls.Add(this.button_Female);
            this.panel_Gender.Location = new System.Drawing.Point(1036, 58);
            this.panel_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Gender.Name = "panel_Gender";
            this.panel_Gender.Size = new System.Drawing.Size(377, 48);
            this.panel_Gender.TabIndex = 9;
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 684);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageEmployeeForm";
            this.Text = "ManageEmployeeForm";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            this.pnData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridvie_Employee)).EndInit();
            this.panel_Button.ResumeLayout(false);
            this.panel_Button.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Gender.ResumeLayout(false);
            this.panel_Gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.DataGridView datagridvie_Employee;
        private System.Windows.Forms.Button button_Detail;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_ToTal;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Panel panel_Button;
        private System.Windows.Forms.Label label_SearchID;
        private System.Windows.Forms.Label label_Male;
        private System.Windows.Forms.Label label_Female;
        private System.Windows.Forms.Button button_Female;
        private System.Windows.Forms.Button button_Male;
        private System.Windows.Forms.Button button_SearchID;
        private System.Windows.Forms.TextBox textbox_SearchID;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Gender;
        private System.Windows.Forms.Label label_DanhSachNhanVien;
        private System.Windows.Forms.TextBox textbox_SearchName;
        private System.Windows.Forms.Button button_SearchName;
        private System.Windows.Forms.Label label_SearchName;
        private System.Windows.Forms.Button button_Exit;
    }
}