
namespace QuanLyNhaHang
{
    partial class CheckInOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInOutForm));
            this.button_CheckIn = new System.Windows.Forms.Button();
            this.button_CheckOut = new System.Windows.Forms.Button();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.label_XinChao = new System.Windows.Forms.Label();
            this.pictureBox_Logout = new System.Windows.Forms.PictureBox();
            this.label_Caccalamhomnay = new System.Windows.Forms.Label();
            this.label_CaHienTai = new System.Windows.Forms.Label();
            this.panel_XinChao = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout)).BeginInit();
            this.panel_XinChao.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CheckIn
            // 
            this.button_CheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_CheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CheckIn.Location = new System.Drawing.Point(63, 143);
            this.button_CheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.button_CheckIn.Name = "button_CheckIn";
            this.button_CheckIn.Size = new System.Drawing.Size(132, 94);
            this.button_CheckIn.TabIndex = 0;
            this.button_CheckIn.Text = "Check In";
            this.button_CheckIn.UseVisualStyleBackColor = false;
            this.button_CheckIn.Click += new System.EventHandler(this.button_CheckIn_Click);
            // 
            // button_CheckOut
            // 
            this.button_CheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_CheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CheckOut.Location = new System.Drawing.Point(289, 143);
            this.button_CheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.button_CheckOut.Name = "button_CheckOut";
            this.button_CheckOut.Size = new System.Drawing.Size(137, 94);
            this.button_CheckOut.TabIndex = 1;
            this.button_CheckOut.Text = "Check Out";
            this.button_CheckOut.UseVisualStyleBackColor = false;
            this.button_CheckOut.Click += new System.EventHandler(this.button_CheckOut_Click);
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Image.Location = new System.Drawing.Point(363, 0);
            this.pictureBox_Image.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(133, 90);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Image.TabIndex = 2;
            this.pictureBox_Image.TabStop = false;
            // 
            // label_XinChao
            // 
            this.label_XinChao.AutoSize = true;
            this.label_XinChao.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_XinChao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_XinChao.Location = new System.Drawing.Point(206, 0);
            this.label_XinChao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_XinChao.Name = "label_XinChao";
            this.label_XinChao.Size = new System.Drawing.Size(91, 28);
            this.label_XinChao.TabIndex = 3;
            this.label_XinChao.Text = "Xin chào:";
            // 
            // pictureBox_Logout
            // 
            this.pictureBox_Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logout.BackgroundImage")));
            this.pictureBox_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Logout.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Logout.Name = "pictureBox_Logout";
            this.pictureBox_Logout.Size = new System.Drawing.Size(55, 54);
            this.pictureBox_Logout.TabIndex = 4;
            this.pictureBox_Logout.TabStop = false;
            this.pictureBox_Logout.Click += new System.EventHandler(this.pictureBox_Logout_Click);
            // 
            // label_Caccalamhomnay
            // 
            this.label_Caccalamhomnay.AutoSize = true;
            this.label_Caccalamhomnay.BackColor = System.Drawing.Color.Transparent;
            this.label_Caccalamhomnay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Caccalamhomnay.Location = new System.Drawing.Point(3, 288);
            this.label_Caccalamhomnay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Caccalamhomnay.Name = "label_Caccalamhomnay";
            this.label_Caccalamhomnay.Size = new System.Drawing.Size(282, 28);
            this.label_Caccalamhomnay.TabIndex = 5;
            this.label_Caccalamhomnay.Text = "Các ca làm của bạn hôm nay là:";
            // 
            // label_CaHienTai
            // 
            this.label_CaHienTai.AutoSize = true;
            this.label_CaHienTai.BackColor = System.Drawing.Color.Transparent;
            this.label_CaHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CaHienTai.ForeColor = System.Drawing.Color.Red;
            this.label_CaHienTai.Location = new System.Drawing.Point(175, 91);
            this.label_CaHienTai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CaHienTai.Name = "label_CaHienTai";
            this.label_CaHienTai.Size = new System.Drawing.Size(83, 39);
            this.label_CaHienTai.TabIndex = 6;
            this.label_CaHienTai.Text = "CA: ";
            // 
            // panel_XinChao
            // 
            this.panel_XinChao.BackColor = System.Drawing.Color.Transparent;
            this.panel_XinChao.Controls.Add(this.label_XinChao);
            this.panel_XinChao.Location = new System.Drawing.Point(63, 6);
            this.panel_XinChao.Margin = new System.Windows.Forms.Padding(4);
            this.panel_XinChao.Name = "panel_XinChao";
            this.panel_XinChao.Size = new System.Drawing.Size(297, 80);
            this.panel_XinChao.TabIndex = 8;
            // 
            // CheckInOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 318);
            this.Controls.Add(this.panel_XinChao);
            this.Controls.Add(this.label_CaHienTai);
            this.Controls.Add(this.label_Caccalamhomnay);
            this.Controls.Add(this.pictureBox_Logout);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.button_CheckOut);
            this.Controls.Add(this.button_CheckIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckInOutForm";
            this.Text = "CheckInOut";
            this.Load += new System.EventHandler(this.CheckInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout)).EndInit();
            this.panel_XinChao.ResumeLayout(false);
            this.panel_XinChao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CheckIn;
        private System.Windows.Forms.Button button_CheckOut;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Label label_XinChao;
        private System.Windows.Forms.PictureBox pictureBox_Logout;
        private System.Windows.Forms.Label label_Caccalamhomnay;
        private System.Windows.Forms.Label label_CaHienTai;
        private System.Windows.Forms.Panel panel_XinChao;
    }
}