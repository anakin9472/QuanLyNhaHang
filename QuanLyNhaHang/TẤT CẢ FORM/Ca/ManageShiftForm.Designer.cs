
namespace QuanLyNhaHang
{
    partial class ManageShiftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageShiftForm));
            this.dataGridView_Ca = new System.Windows.Forms.DataGridView();
            this.label_QuanLyCa = new System.Windows.Forms.Label();
            this.label_MaCa = new System.Windows.Forms.Label();
            this.label_Batdauca = new System.Windows.Forms.Label();
            this.label_Ketthucca = new System.Windows.Forms.Label();
            this.label_Soluongnv = new System.Windows.Forms.Label();
            this.textBox_MaCa = new System.Windows.Forms.TextBox();
            this.button_ThemCa = new System.Windows.Forms.Button();
            this.button_SuaCa = new System.Windows.Forms.Button();
            this.button_Xoaca = new System.Windows.Forms.Button();
            this.numericUpDown_Soluongnhanvien = new System.Windows.Forms.NumericUpDown();
            this.textBox_TenCa = new System.Windows.Forms.TextBox();
            this.label_TenCa = new System.Windows.Forms.Label();
            this.label_ChucVu = new System.Windows.Forms.Label();
            this.comboBox_ChucVu = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_BatDauca = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_KetThucCA = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Soluongnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Ca
            // 
            this.dataGridView_Ca.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Ca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ca.Location = new System.Drawing.Point(465, 87);
            this.dataGridView_Ca.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Ca.Name = "dataGridView_Ca";
            this.dataGridView_Ca.RowHeadersWidth = 51;
            this.dataGridView_Ca.Size = new System.Drawing.Size(716, 373);
            this.dataGridView_Ca.TabIndex = 0;
            this.dataGridView_Ca.Click += new System.EventHandler(this.dataGridView_Period_Click);
            // 
            // label_QuanLyCa
            // 
            this.label_QuanLyCa.AutoSize = true;
            this.label_QuanLyCa.BackColor = System.Drawing.Color.Transparent;
            this.label_QuanLyCa.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_QuanLyCa.ForeColor = System.Drawing.Color.Blue;
            this.label_QuanLyCa.Location = new System.Drawing.Point(371, 11);
            this.label_QuanLyCa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_QuanLyCa.Name = "label_QuanLyCa";
            this.label_QuanLyCa.Size = new System.Drawing.Size(210, 46);
            this.label_QuanLyCa.TabIndex = 1;
            this.label_QuanLyCa.Text = "QUẢN LÝ CA";
            // 
            // label_MaCa
            // 
            this.label_MaCa.AutoSize = true;
            this.label_MaCa.BackColor = System.Drawing.Color.Transparent;
            this.label_MaCa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaCa.Location = new System.Drawing.Point(155, 89);
            this.label_MaCa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaCa.Name = "label_MaCa";
            this.label_MaCa.Size = new System.Drawing.Size(79, 32);
            this.label_MaCa.TabIndex = 2;
            this.label_MaCa.Text = "Mã ca";
            // 
            // label_Batdauca
            // 
            this.label_Batdauca.AutoSize = true;
            this.label_Batdauca.BackColor = System.Drawing.Color.Transparent;
            this.label_Batdauca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Batdauca.Location = new System.Drawing.Point(105, 181);
            this.label_Batdauca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Batdauca.Name = "label_Batdauca";
            this.label_Batdauca.Size = new System.Drawing.Size(126, 32);
            this.label_Batdauca.TabIndex = 3;
            this.label_Batdauca.Text = "Bắt đầu ca";
            // 
            // label_Ketthucca
            // 
            this.label_Ketthucca.AutoSize = true;
            this.label_Ketthucca.BackColor = System.Drawing.Color.Transparent;
            this.label_Ketthucca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ketthucca.Location = new System.Drawing.Point(97, 228);
            this.label_Ketthucca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ketthucca.Name = "label_Ketthucca";
            this.label_Ketthucca.Size = new System.Drawing.Size(134, 32);
            this.label_Ketthucca.TabIndex = 4;
            this.label_Ketthucca.Text = "Kết thúc ca";
            // 
            // label_Soluongnv
            // 
            this.label_Soluongnv.AutoSize = true;
            this.label_Soluongnv.BackColor = System.Drawing.Color.Transparent;
            this.label_Soluongnv.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Soluongnv.Location = new System.Drawing.Point(5, 279);
            this.label_Soluongnv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Soluongnv.Name = "label_Soluongnv";
            this.label_Soluongnv.Size = new System.Drawing.Size(224, 32);
            this.label_Soluongnv.TabIndex = 5;
            this.label_Soluongnv.Text = "Số lượng nhân viên";
            // 
            // textBox_MaCa
            // 
            this.textBox_MaCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaCa.Location = new System.Drawing.Point(241, 87);
            this.textBox_MaCa.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MaCa.Name = "textBox_MaCa";
            this.textBox_MaCa.Size = new System.Drawing.Size(192, 34);
            this.textBox_MaCa.TabIndex = 6;
            // 
            // button_ThemCa
            // 
            this.button_ThemCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_ThemCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemCa.Location = new System.Drawing.Point(35, 395);
            this.button_ThemCa.Margin = new System.Windows.Forms.Padding(4);
            this.button_ThemCa.Name = "button_ThemCa";
            this.button_ThemCa.Size = new System.Drawing.Size(124, 65);
            this.button_ThemCa.TabIndex = 10;
            this.button_ThemCa.Text = "Thêm ca";
            this.button_ThemCa.UseVisualStyleBackColor = false;
            this.button_ThemCa.Click += new System.EventHandler(this.button_InsertShift_Click);
            // 
            // button_SuaCa
            // 
            this.button_SuaCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_SuaCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SuaCa.Location = new System.Drawing.Point(167, 396);
            this.button_SuaCa.Margin = new System.Windows.Forms.Padding(4);
            this.button_SuaCa.Name = "button_SuaCa";
            this.button_SuaCa.Size = new System.Drawing.Size(141, 65);
            this.button_SuaCa.TabIndex = 11;
            this.button_SuaCa.Text = "Chỉnh sửa ca";
            this.button_SuaCa.UseVisualStyleBackColor = false;
            this.button_SuaCa.Click += new System.EventHandler(this.button_EditShift_Click);
            // 
            // button_Xoaca
            // 
            this.button_Xoaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Xoaca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoaca.Location = new System.Drawing.Point(313, 395);
            this.button_Xoaca.Margin = new System.Windows.Forms.Padding(4);
            this.button_Xoaca.Name = "button_Xoaca";
            this.button_Xoaca.Size = new System.Drawing.Size(121, 65);
            this.button_Xoaca.TabIndex = 12;
            this.button_Xoaca.Text = "Xóa ca";
            this.button_Xoaca.UseVisualStyleBackColor = false;
            this.button_Xoaca.Click += new System.EventHandler(this.button_DeleteShift_Click);
            // 
            // numericUpDown_Soluongnhanvien
            // 
            this.numericUpDown_Soluongnhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Soluongnhanvien.Location = new System.Drawing.Point(241, 279);
            this.numericUpDown_Soluongnhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_Soluongnhanvien.Name = "numericUpDown_Soluongnhanvien";
            this.numericUpDown_Soluongnhanvien.Size = new System.Drawing.Size(193, 34);
            this.numericUpDown_Soluongnhanvien.TabIndex = 15;
            // 
            // textBox_TenCa
            // 
            this.textBox_TenCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenCa.Location = new System.Drawing.Point(241, 133);
            this.textBox_TenCa.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TenCa.Name = "textBox_TenCa";
            this.textBox_TenCa.Size = new System.Drawing.Size(192, 34);
            this.textBox_TenCa.TabIndex = 17;
            // 
            // label_TenCa
            // 
            this.label_TenCa.AutoSize = true;
            this.label_TenCa.BackColor = System.Drawing.Color.Transparent;
            this.label_TenCa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenCa.Location = new System.Drawing.Point(152, 134);
            this.label_TenCa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenCa.Name = "label_TenCa";
            this.label_TenCa.Size = new System.Drawing.Size(83, 32);
            this.label_TenCa.TabIndex = 16;
            this.label_TenCa.Text = "Tên ca";
            // 
            // label_ChucVu
            // 
            this.label_ChucVu.AutoSize = true;
            this.label_ChucVu.BackColor = System.Drawing.Color.Transparent;
            this.label_ChucVu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChucVu.Location = new System.Drawing.Point(131, 334);
            this.label_ChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ChucVu.Name = "label_ChucVu";
            this.label_ChucVu.Size = new System.Drawing.Size(102, 32);
            this.label_ChucVu.TabIndex = 18;
            this.label_ChucVu.Text = "Chức vụ";
            // 
            // comboBox_ChucVu
            // 
            this.comboBox_ChucVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ChucVu.FormattingEnabled = true;
            this.comboBox_ChucVu.Location = new System.Drawing.Point(241, 334);
            this.comboBox_ChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_ChucVu.Name = "comboBox_ChucVu";
            this.comboBox_ChucVu.Size = new System.Drawing.Size(192, 36);
            this.comboBox_ChucVu.TabIndex = 19;
            // 
            // dateTimePicker_BatDauca
            // 
            this.dateTimePicker_BatDauca.CustomFormat = "HH:mm:ss";
            this.dateTimePicker_BatDauca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_BatDauca.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BatDauca.Location = new System.Drawing.Point(241, 181);
            this.dateTimePicker_BatDauca.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_BatDauca.Name = "dateTimePicker_BatDauca";
            this.dateTimePicker_BatDauca.ShowUpDown = true;
            this.dateTimePicker_BatDauca.Size = new System.Drawing.Size(192, 34);
            this.dateTimePicker_BatDauca.TabIndex = 20;
            // 
            // dateTimePicker_KetThucCA
            // 
            this.dateTimePicker_KetThucCA.CustomFormat = "HH:mm:ss";
            this.dateTimePicker_KetThucCA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_KetThucCA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_KetThucCA.Location = new System.Drawing.Point(241, 229);
            this.dateTimePicker_KetThucCA.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_KetThucCA.Name = "dateTimePicker_KetThucCA";
            this.dateTimePicker_KetThucCA.ShowUpDown = true;
            this.dateTimePicker_KetThucCA.Size = new System.Drawing.Size(192, 34);
            this.dateTimePicker_KetThucCA.TabIndex = 21;
            // 
            // ManageShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 513);
            this.Controls.Add(this.dateTimePicker_KetThucCA);
            this.Controls.Add(this.dateTimePicker_BatDauca);
            this.Controls.Add(this.comboBox_ChucVu);
            this.Controls.Add(this.label_ChucVu);
            this.Controls.Add(this.textBox_TenCa);
            this.Controls.Add(this.label_TenCa);
            this.Controls.Add(this.numericUpDown_Soluongnhanvien);
            this.Controls.Add(this.button_Xoaca);
            this.Controls.Add(this.button_SuaCa);
            this.Controls.Add(this.button_ThemCa);
            this.Controls.Add(this.textBox_MaCa);
            this.Controls.Add(this.label_Soluongnv);
            this.Controls.Add(this.label_Ketthucca);
            this.Controls.Add(this.label_Batdauca);
            this.Controls.Add(this.label_MaCa);
            this.Controls.Add(this.label_QuanLyCa);
            this.Controls.Add(this.dataGridView_Ca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageShiftForm";
            this.Text = "ManageShift";
            this.Load += new System.EventHandler(this.ManagePeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Soluongnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Ca;
        private System.Windows.Forms.Label label_QuanLyCa;
        private System.Windows.Forms.Label label_MaCa;
        private System.Windows.Forms.Label label_Batdauca;
        private System.Windows.Forms.Label label_Ketthucca;
        private System.Windows.Forms.Label label_Soluongnv;
        private System.Windows.Forms.TextBox textBox_MaCa;
        private System.Windows.Forms.Button button_ThemCa;
        private System.Windows.Forms.Button button_SuaCa;
        private System.Windows.Forms.Button button_Xoaca;
        private System.Windows.Forms.NumericUpDown numericUpDown_Soluongnhanvien;
        private System.Windows.Forms.TextBox textBox_TenCa;
        private System.Windows.Forms.Label label_TenCa;
        private System.Windows.Forms.Label label_ChucVu;
        private System.Windows.Forms.ComboBox comboBox_ChucVu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BatDauca;
        private System.Windows.Forms.DateTimePicker dateTimePicker_KetThucCA;
    }
}