
namespace QuanLyNhaHang
{
    partial class CustomerMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đĂTBANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHONMONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelDisplay = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đĂTBANToolStripMenuItem,
            this.cHONMONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1469, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // đĂTBANToolStripMenuItem
            // 
            this.đĂTBANToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đĂTBANToolStripMenuItem.Name = "đĂTBANToolStripMenuItem";
            this.đĂTBANToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.đĂTBANToolStripMenuItem.Text = "ĐẶT BÀN";
            this.đĂTBANToolStripMenuItem.Click += new System.EventHandler(this.đĂTBANToolStripMenuItem_Click);
            // 
            // cHONMONToolStripMenuItem
            // 
            this.cHONMONToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHONMONToolStripMenuItem.Name = "cHONMONToolStripMenuItem";
            this.cHONMONToolStripMenuItem.Size = new System.Drawing.Size(137, 32);
            this.cHONMONToolStripMenuItem.Text = "CHỌN MÓN";
            this.cHONMONToolStripMenuItem.Click += new System.EventHandler(this.cHONMONToolStripMenuItem_Click);
            // 
            // PanelDisplay
            // 
            this.PanelDisplay.Location = new System.Drawing.Point(2, 36);
            this.PanelDisplay.Name = "PanelDisplay";
            this.PanelDisplay.Size = new System.Drawing.Size(1452, 752);
            this.PanelDisplay.TabIndex = 1;
            this.PanelDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1469, 793);
            this.Controls.Add(this.PanelDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đĂTBANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHONMONToolStripMenuItem;
        private System.Windows.Forms.Panel PanelDisplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}