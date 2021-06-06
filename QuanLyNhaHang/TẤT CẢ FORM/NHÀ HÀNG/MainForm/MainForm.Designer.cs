
namespace QuanLyNhaHang
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.PanelDisplay = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qUANLYNHÂNVIÊNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHIACAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCaLàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiaCaLàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKINOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUANLYBANVAKHACHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUANLYBANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHÔNGKÊVADOANHTHUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kHACHHANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDisplay
            // 
            this.PanelDisplay.BackColor = System.Drawing.Color.White;
            this.PanelDisplay.Location = new System.Drawing.Point(12, 39);
            this.PanelDisplay.Name = "PanelDisplay";
            this.PanelDisplay.Size = new System.Drawing.Size(1524, 684);
            this.PanelDisplay.TabIndex = 0;
            this.PanelDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDisplay_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUANLYNHÂNVIÊNToolStripMenuItem,
            this.cHIACAToolStripMenuItem,
            this.cHECKINOUTToolStripMenuItem,
            this.qUANLYBANVAKHACHToolStripMenuItem,
            this.qUANLYBANToolStripMenuItem,
            this.tHÔNGKÊVADOANHTHUToolStripMenuItem,
            this.kHACHHANGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1548, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // qUANLYNHÂNVIÊNToolStripMenuItem
            // 
            this.qUANLYNHÂNVIÊNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânVienToolStripMenuItem,
            this.thêmNhânViênToolStripMenuItem,
            this.chấmCôngToolStripMenuItem});
            this.qUANLYNHÂNVIÊNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qUANLYNHÂNVIÊNToolStripMenuItem.Name = "qUANLYNHÂNVIÊNToolStripMenuItem";
            this.qUANLYNHÂNVIÊNToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.qUANLYNHÂNVIÊNToolStripMenuItem.Text = "NHÂN VIÊN";
            // 
            // quảnLýNhânVienToolStripMenuItem
            // 
            this.quảnLýNhânVienToolStripMenuItem.Name = "quảnLýNhânVienToolStripMenuItem";
            this.quảnLýNhânVienToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.quảnLýNhânVienToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânVienToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânVienToolStripMenuItem_Click);
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            this.thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            this.thêmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.thêmNhânViênToolStripMenuItem.Text = "Thêm nhân viên";
            this.thêmNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thêmNhânViênToolStripMenuItem_Click);
            // 
            // chấmCôngToolStripMenuItem
            // 
            this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            this.chấmCôngToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.chấmCôngToolStripMenuItem.Text = "Chấm công";
            this.chấmCôngToolStripMenuItem.Click += new System.EventHandler(this.chấmCôngToolStripMenuItem_Click);
            // 
            // cHIACAToolStripMenuItem
            // 
            this.cHIACAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýCaLàmToolStripMenuItem,
            this.chiaCaLàmToolStripMenuItem});
            this.cHIACAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHIACAToolStripMenuItem.Name = "cHIACAToolStripMenuItem";
            this.cHIACAToolStripMenuItem.Size = new System.Drawing.Size(141, 32);
            this.cHIACAToolStripMenuItem.Text = "QUẢN LÝ CA";
            // 
            // quảnLýCaLàmToolStripMenuItem
            // 
            this.quảnLýCaLàmToolStripMenuItem.Name = "quảnLýCaLàmToolStripMenuItem";
            this.quảnLýCaLàmToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.quảnLýCaLàmToolStripMenuItem.Text = "Quản lý ca làm";
            this.quảnLýCaLàmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCaLàmToolStripMenuItem_Click);
            // 
            // chiaCaLàmToolStripMenuItem
            // 
            this.chiaCaLàmToolStripMenuItem.Name = "chiaCaLàmToolStripMenuItem";
            this.chiaCaLàmToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.chiaCaLàmToolStripMenuItem.Text = "Chia ca làm";
            this.chiaCaLàmToolStripMenuItem.Click += new System.EventHandler(this.chiaCaLàmToolStripMenuItem_Click);
            // 
            // cHECKINOUTToolStripMenuItem
            // 
            this.cHECKINOUTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHECKINOUTToolStripMenuItem.Name = "cHECKINOUTToolStripMenuItem";
            this.cHECKINOUTToolStripMenuItem.Size = new System.Drawing.Size(168, 32);
            this.cHECKINOUTToolStripMenuItem.Text = "CHECK IN/ OUT";
            this.cHECKINOUTToolStripMenuItem.Click += new System.EventHandler(this.cHECKINOUTToolStripMenuItem_Click);
            // 
            // qUANLYBANVAKHACHToolStripMenuItem
            // 
            this.qUANLYBANVAKHACHToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qUANLYBANVAKHACHToolStripMenuItem.Name = "qUANLYBANVAKHACHToolStripMenuItem";
            this.qUANLYBANVAKHACHToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.qUANLYBANVAKHACHToolStripMenuItem.Text = "BÀN ĂN";
            this.qUANLYBANVAKHACHToolStripMenuItem.Click += new System.EventHandler(this.qUANLYBANVAKHACHToolStripMenuItem_Click);
            // 
            // qUANLYBANToolStripMenuItem
            // 
            this.qUANLYBANToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qUANLYBANToolStripMenuItem.Name = "qUANLYBANToolStripMenuItem";
            this.qUANLYBANToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.qUANLYBANToolStripMenuItem.Text = "MÓN ĂN";
            this.qUANLYBANToolStripMenuItem.Click += new System.EventHandler(this.qUANLYBANToolStripMenuItem_Click);
            // 
            // tHÔNGKÊVADOANHTHUToolStripMenuItem
            // 
            this.tHÔNGKÊVADOANHTHUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHÔNGKÊVADOANHTHUToolStripMenuItem.Name = "tHÔNGKÊVADOANHTHUToolStripMenuItem";
            this.tHÔNGKÊVADOANHTHUToolStripMenuItem.Size = new System.Drawing.Size(144, 32);
            this.tHÔNGKÊVADOANHTHUToolStripMenuItem.Text = "DOANH THU";
            this.tHÔNGKÊVADOANHTHUToolStripMenuItem.Click += new System.EventHandler(this.tHÔNGKÊVADOANHTHUToolStripMenuItem_Click);
            // 
            // kHACHHANGToolStripMenuItem
            // 
            this.kHACHHANGToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kHACHHANGToolStripMenuItem.Name = "kHACHHANGToolStripMenuItem";
            this.kHACHHANGToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.kHACHHANGToolStripMenuItem.Text = "CHƯƠNG TRÌNH KIỂM TRA";
            this.kHACHHANGToolStripMenuItem.Click += new System.EventHandler(this.kHACHHANGToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 759);
            this.Controls.Add(this.PanelDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUANLYNHÂNVIÊNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUANLYBANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUANLYBANVAKHACHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHÔNGKÊVADOANHTHUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHIACAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kHACHHANGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCaLàmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiaCaLàmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHECKINOUTToolStripMenuItem;
    }
}