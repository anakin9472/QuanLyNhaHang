
namespace QuanLyNhaHang
{
    partial class SplitShiftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitShiftForm));
            this.dataGridView_Chiaca = new System.Windows.Forms.DataGridView();
            this.gunaTextBox_Timkiem = new Guna.UI.WinForms.GunaTextBox();
            this.label_NumberEmployee = new System.Windows.Forms.Label();
            this.label_NumberPeriod = new System.Windows.Forms.Label();
            this.gunaPictureBox_Search = new Guna.UI.WinForms.GunaPictureBox();
            this.button_ChiaCa = new System.Windows.Forms.Button();
            this.button_NhanVien = new System.Windows.Forms.Button();
            this.button_ChamCong = new System.Windows.Forms.Button();
            this.button_Ca = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Chiaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Chiaca
            // 
            this.dataGridView_Chiaca.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Chiaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Chiaca.Location = new System.Drawing.Point(44, 122);
            this.dataGridView_Chiaca.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Chiaca.Name = "dataGridView_Chiaca";
            this.dataGridView_Chiaca.RowHeadersWidth = 51;
            this.dataGridView_Chiaca.Size = new System.Drawing.Size(1467, 498);
            this.dataGridView_Chiaca.TabIndex = 4;
            // 
            // gunaTextBox_Timkiem
            // 
            this.gunaTextBox_Timkiem.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox_Timkiem.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox_Timkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox_Timkiem.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox_Timkiem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox_Timkiem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox_Timkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox_Timkiem.Location = new System.Drawing.Point(147, 76);
            this.gunaTextBox_Timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.gunaTextBox_Timkiem.Name = "gunaTextBox_Timkiem";
            this.gunaTextBox_Timkiem.PasswordChar = '\0';
            this.gunaTextBox_Timkiem.SelectedText = "";
            this.gunaTextBox_Timkiem.Size = new System.Drawing.Size(209, 46);
            this.gunaTextBox_Timkiem.TabIndex = 14;
            this.gunaTextBox_Timkiem.Text = "Tìm kiếm";
            this.gunaTextBox_Timkiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_NumberEmployee
            // 
            this.label_NumberEmployee.AutoSize = true;
            this.label_NumberEmployee.BackColor = System.Drawing.Color.Transparent;
            this.label_NumberEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumberEmployee.Location = new System.Drawing.Point(47, 624);
            this.label_NumberEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NumberEmployee.Name = "label_NumberEmployee";
            this.label_NumberEmployee.Size = new System.Drawing.Size(106, 28);
            this.label_NumberEmployee.TabIndex = 19;
            this.label_NumberEmployee.Text = "Employees";
            // 
            // label_NumberPeriod
            // 
            this.label_NumberPeriod.AutoSize = true;
            this.label_NumberPeriod.BackColor = System.Drawing.Color.Transparent;
            this.label_NumberPeriod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumberPeriod.Location = new System.Drawing.Point(1435, 624);
            this.label_NumberPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NumberPeriod.Name = "label_NumberPeriod";
            this.label_NumberPeriod.Size = new System.Drawing.Size(76, 28);
            this.label_NumberPeriod.TabIndex = 20;
            this.label_NumberPeriod.Text = "Periods";
            // 
            // gunaPictureBox_Search
            // 
            this.gunaPictureBox_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaPictureBox_Search.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox_Search.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox_Search.Image")));
            this.gunaPictureBox_Search.InitialImage = null;
            this.gunaPictureBox_Search.Location = new System.Drawing.Point(147, 78);
            this.gunaPictureBox_Search.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPictureBox_Search.Name = "gunaPictureBox_Search";
            this.gunaPictureBox_Search.Size = new System.Drawing.Size(57, 42);
            this.gunaPictureBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox_Search.TabIndex = 15;
            this.gunaPictureBox_Search.TabStop = false;
            this.gunaPictureBox_Search.Click += new System.EventHandler(this.gunaPictureBox_Search_Click);
            // 
            // button_ChiaCa
            // 
            this.button_ChiaCa.BackColor = System.Drawing.Color.White;
            this.button_ChiaCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChiaCa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChiaCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.button_ChiaCa.Location = new System.Drawing.Point(689, 26);
            this.button_ChiaCa.Margin = new System.Windows.Forms.Padding(4);
            this.button_ChiaCa.Name = "button_ChiaCa";
            this.button_ChiaCa.Size = new System.Drawing.Size(180, 69);
            this.button_ChiaCa.TabIndex = 22;
            this.button_ChiaCa.Text = "Chia Ca";
            this.button_ChiaCa.UseVisualStyleBackColor = false;
            this.button_ChiaCa.Click += new System.EventHandler(this.button_Chiaca_Click);
            // 
            // button_NhanVien
            // 
            this.button_NhanVien.BackColor = System.Drawing.Color.White;
            this.button_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.button_NhanVien.Location = new System.Drawing.Point(1044, 13);
            this.button_NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.button_NhanVien.Name = "button_NhanVien";
            this.button_NhanVien.Size = new System.Drawing.Size(159, 43);
            this.button_NhanVien.TabIndex = 23;
            this.button_NhanVien.Text = "Nhân Viên";
            this.button_NhanVien.UseVisualStyleBackColor = false;
            this.button_NhanVien.Click += new System.EventHandler(this.button_NhanVien_Click);
            // 
            // button_ChamCong
            // 
            this.button_ChamCong.BackColor = System.Drawing.Color.White;
            this.button_ChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChamCong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChamCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.button_ChamCong.Location = new System.Drawing.Point(1352, 13);
            this.button_ChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.button_ChamCong.Name = "button_ChamCong";
            this.button_ChamCong.Size = new System.Drawing.Size(159, 43);
            this.button_ChamCong.TabIndex = 24;
            this.button_ChamCong.Text = "Chấm công";
            this.button_ChamCong.UseVisualStyleBackColor = false;
            this.button_ChamCong.Click += new System.EventHandler(this.buttonChamCong_Click);
            // 
            // button_Ca
            // 
            this.button_Ca.BackColor = System.Drawing.Color.White;
            this.button_Ca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.button_Ca.Location = new System.Drawing.Point(1211, 13);
            this.button_Ca.Margin = new System.Windows.Forms.Padding(4);
            this.button_Ca.Name = "button_Ca";
            this.button_Ca.Size = new System.Drawing.Size(133, 43);
            this.button_Ca.TabIndex = 25;
            this.button_Ca.Text = "Ca";
            this.button_Ca.UseVisualStyleBackColor = false;
            this.button_Ca.Click += new System.EventHandler(this.button_Ca_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.button2.Location = new System.Drawing.Point(865, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 25;
            this.button2.Text = "Nhân Viên";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(254)))));
            this.button1.Location = new System.Drawing.Point(1037, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Chấm công";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SplitShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1571, 671);
            this.Controls.Add(this.button_Ca);
            this.Controls.Add(this.button_ChamCong);
            this.Controls.Add(this.button_NhanVien);
            this.Controls.Add(this.button_ChiaCa);
            this.Controls.Add(this.label_NumberPeriod);
            this.Controls.Add(this.label_NumberEmployee);
            this.Controls.Add(this.gunaPictureBox_Search);
            this.Controls.Add(this.gunaTextBox_Timkiem);
            this.Controls.Add(this.dataGridView_Chiaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SplitShiftForm";
            this.Text = "Split Shift";
            this.Load += new System.EventHandler(this.ChiaCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Chiaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Chamcong;
        private System.Windows.Forms.DataGridView dataGridView_Chiaca;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox_Timkiem;
        private System.Windows.Forms.Label label_NumberEmployee;
        private System.Windows.Forms.Label label_NumberPeriod;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox_Search;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button_ChiaCa;
        private System.Windows.Forms.Button button_NhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_ChamCong;
        private System.Windows.Forms.Button button_Ca;
    }
}