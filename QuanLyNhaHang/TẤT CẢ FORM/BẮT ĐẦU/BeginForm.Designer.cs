
namespace QuanLyNhaHang
{
    partial class BeginForm
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
            this.Button_CustomerLogin = new System.Windows.Forms.Button();
            this.Label_Content = new System.Windows.Forms.Label();
            this.Button_EmployeeLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_CustomerLogin
            // 
            this.Button_CustomerLogin.BackColor = System.Drawing.Color.White;
            this.Button_CustomerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CustomerLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CustomerLogin.ForeColor = System.Drawing.Color.Crimson;
            this.Button_CustomerLogin.Location = new System.Drawing.Point(69, 256);
            this.Button_CustomerLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_CustomerLogin.Name = "Button_CustomerLogin";
            this.Button_CustomerLogin.Size = new System.Drawing.Size(235, 42);
            this.Button_CustomerLogin.TabIndex = 5;
            this.Button_CustomerLogin.Text = "KHÁCH HÀNG";
            this.Button_CustomerLogin.UseVisualStyleBackColor = false;
            this.Button_CustomerLogin.Click += new System.EventHandler(this.buttonNaptien_Click);
            // 
            // Label_Content
            // 
            this.Label_Content.AutoSize = true;
            this.Label_Content.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Label_Content.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_Content.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Content.ForeColor = System.Drawing.Color.White;
            this.Label_Content.Location = new System.Drawing.Point(86, 173);
            this.Label_Content.Name = "Label_Content";
            this.Label_Content.Size = new System.Drawing.Size(458, 41);
            this.Label_Content.TabIndex = 3;
            this.Label_Content.Text = "CHÀO MỪNG TỚI NHÀ HÀNG !";
            // 
            // Button_EmployeeLogin
            // 
            this.Button_EmployeeLogin.BackColor = System.Drawing.Color.White;
            this.Button_EmployeeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_EmployeeLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_EmployeeLogin.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Button_EmployeeLogin.Location = new System.Drawing.Point(350, 256);
            this.Button_EmployeeLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_EmployeeLogin.Name = "Button_EmployeeLogin";
            this.Button_EmployeeLogin.Size = new System.Drawing.Size(246, 42);
            this.Button_EmployeeLogin.TabIndex = 6;
            this.Button_EmployeeLogin.Text = "NHÂN VIÊN ";
            this.Button_EmployeeLogin.UseVisualStyleBackColor = false;
            this.Button_EmployeeLogin.Click += new System.EventHandler(this.Button_EmployeeLogin_Click);
            // 
            // BeginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.J6Pqp81;
            this.ClientSize = new System.Drawing.Size(657, 504);
            this.Controls.Add(this.Button_EmployeeLogin);
            this.Controls.Add(this.Button_CustomerLogin);
            this.Controls.Add(this.Label_Content);
            this.Name = "BeginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeginForm";
            this.Load += new System.EventHandler(this.BeginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_CustomerLogin;
        private System.Windows.Forms.Label Label_Content;
        private System.Windows.Forms.Button Button_EmployeeLogin;
    }
}