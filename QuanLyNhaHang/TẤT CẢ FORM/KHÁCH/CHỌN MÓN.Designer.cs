
namespace QuanLyNhaHang
{
    partial class CHỌN_MÓN
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
            this.FlowLayoutPanel_SelectedFood = new System.Windows.Forms.FlowLayoutPanel();
            this.ListView_OrderDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlowLayoutPanel_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_TableManagement = new System.Windows.Forms.Label();
            this.Label_Search = new System.Windows.Forms.Label();
            this.ComboBox_Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Button_Discount = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_LeftTop = new System.Windows.Forms.Panel();
            this.Label_TotalPrice = new System.Windows.Forms.Label();
            this.TextBox_TotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_Order = new Guna.UI2.WinForms.Guna2Button();
            this.Label_NumOfFood = new System.Windows.Forms.Label();
            this.TextBox_SelectedFood = new Guna.UI2.WinForms.Guna2TextBox();
            this.NumericUpDown_NumOfFood = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.Label_SelectedFood = new System.Windows.Forms.Label();
            this.PictureBox_Discount = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.FlowLayoutPanel_SelectedFood.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel_LeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_NumOfFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Discount)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowLayoutPanel_SelectedFood
            // 
            this.FlowLayoutPanel_SelectedFood.Controls.Add(this.ListView_OrderDetails);
            this.FlowLayoutPanel_SelectedFood.Location = new System.Drawing.Point(12, 165);
            this.FlowLayoutPanel_SelectedFood.Name = "FlowLayoutPanel_SelectedFood";
            this.FlowLayoutPanel_SelectedFood.Size = new System.Drawing.Size(593, 426);
            this.FlowLayoutPanel_SelectedFood.TabIndex = 0;
            // 
            // ListView_OrderDetails
            // 
            this.ListView_OrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListView_OrderDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_OrderDetails.HideSelection = false;
            this.ListView_OrderDetails.Location = new System.Drawing.Point(3, 3);
            this.ListView_OrderDetails.Name = "ListView_OrderDetails";
            this.ListView_OrderDetails.Size = new System.Drawing.Size(593, 423);
            this.ListView_OrderDetails.TabIndex = 0;
            this.ListView_OrderDetails.UseCompatibleStateImageBehavior = false;
            this.ListView_OrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MÓN";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ĐƠN GIÁ";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "GIẢM";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SL";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TỔNG";
            this.columnHeader5.Width = 100;
            // 
            // FlowLayoutPanel_Menu
            // 
            this.FlowLayoutPanel_Menu.AutoScroll = true;
            this.FlowLayoutPanel_Menu.Location = new System.Drawing.Point(612, 54);
            this.FlowLayoutPanel_Menu.Name = "FlowLayoutPanel_Menu";
            this.FlowLayoutPanel_Menu.Size = new System.Drawing.Size(826, 684);
            this.FlowLayoutPanel_Menu.TabIndex = 0;
            this.FlowLayoutPanel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel_Menu_Paint);
            // 
            // Label_TableManagement
            // 
            this.Label_TableManagement.AutoSize = true;
            this.Label_TableManagement.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label_TableManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TableManagement.ForeColor = System.Drawing.Color.White;
            this.Label_TableManagement.Location = new System.Drawing.Point(876, 0);
            this.Label_TableManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TableManagement.Name = "Label_TableManagement";
            this.Label_TableManagement.Size = new System.Drawing.Size(235, 51);
            this.Label_TableManagement.TabIndex = 53;
            this.Label_TableManagement.Text = "CHỌN MÓN";
            // 
            // Label_Search
            // 
            this.Label_Search.AutoSize = true;
            this.Label_Search.BackColor = System.Drawing.Color.White;
            this.Label_Search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Search.Location = new System.Drawing.Point(12, 15);
            this.Label_Search.Name = "Label_Search";
            this.Label_Search.Size = new System.Drawing.Size(364, 32);
            this.Label_Search.TabIndex = 167;
            this.Label_Search.Text = "Tìm kiếm món theo danh mục:";
            // 
            // ComboBox_Category
            // 
            this.ComboBox_Category.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Category.BorderColor = System.Drawing.Color.Black;
            this.ComboBox_Category.BorderRadius = 10;
            this.ComboBox_Category.BorderThickness = 2;
            this.ComboBox_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Category.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox_Category.FocusedState.Parent = this.ComboBox_Category;
            this.ComboBox_Category.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Category.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_Category.FormattingEnabled = true;
            this.ComboBox_Category.HoverState.Parent = this.ComboBox_Category;
            this.ComboBox_Category.ItemHeight = 30;
            this.ComboBox_Category.ItemsAppearance.Parent = this.ComboBox_Category;
            this.ComboBox_Category.Location = new System.Drawing.Point(12, 57);
            this.ComboBox_Category.Name = "ComboBox_Category";
            this.ComboBox_Category.ShadowDecoration.Parent = this.ComboBox_Category;
            this.ComboBox_Category.Size = new System.Drawing.Size(365, 36);
            this.ComboBox_Category.TabIndex = 170;
            // 
            // Button_Discount
            // 
            this.Button_Discount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Button_Discount.BorderRadius = 10;
            this.Button_Discount.BorderThickness = 2;
            this.Button_Discount.CheckedState.Parent = this.Button_Discount;
            this.Button_Discount.CustomImages.Parent = this.Button_Discount;
            this.Button_Discount.FillColor = System.Drawing.Color.Crimson;
            this.Button_Discount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Discount.ForeColor = System.Drawing.Color.White;
            this.Button_Discount.HoverState.Parent = this.Button_Discount;
            this.Button_Discount.Location = new System.Drawing.Point(12, 117);
            this.Button_Discount.Name = "Button_Discount";
            this.Button_Discount.ShadowDecoration.Parent = this.Button_Discount;
            this.Button_Discount.Size = new System.Drawing.Size(365, 42);
            this.Button_Discount.TabIndex = 2;
            this.Button_Discount.Text = "Sản phẩm có khuyến mãi";
            this.Button_Discount.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.Panel_LeftTop);
            this.panel1.Controls.Add(this.PictureBox_Discount);
            this.panel1.Controls.Add(this.Button_Discount);
            this.panel1.Controls.Add(this.Button_Search);
            this.panel1.Controls.Add(this.Label_Search);
            this.panel1.Controls.Add(this.ComboBox_Category);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1451, 753);
            this.panel1.TabIndex = 171;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Panel_LeftTop
            // 
            this.Panel_LeftTop.BackColor = System.Drawing.Color.White;
            this.Panel_LeftTop.Controls.Add(this.Label_TotalPrice);
            this.Panel_LeftTop.Controls.Add(this.TextBox_TotalPrice);
            this.Panel_LeftTop.Controls.Add(this.Button_Order);
            this.Panel_LeftTop.Controls.Add(this.Label_NumOfFood);
            this.Panel_LeftTop.Controls.Add(this.TextBox_SelectedFood);
            this.Panel_LeftTop.Controls.Add(this.NumericUpDown_NumOfFood);
            this.Panel_LeftTop.Controls.Add(this.Label_SelectedFood);
            this.Panel_LeftTop.Location = new System.Drawing.Point(12, 598);
            this.Panel_LeftTop.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_LeftTop.Name = "Panel_LeftTop";
            this.Panel_LeftTop.Size = new System.Drawing.Size(593, 139);
            this.Panel_LeftTop.TabIndex = 172;
            // 
            // Label_TotalPrice
            // 
            this.Label_TotalPrice.AutoSize = true;
            this.Label_TotalPrice.BackColor = System.Drawing.Color.White;
            this.Label_TotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalPrice.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalPrice.Location = new System.Drawing.Point(13, 92);
            this.Label_TotalPrice.Name = "Label_TotalPrice";
            this.Label_TotalPrice.Size = new System.Drawing.Size(83, 32);
            this.Label_TotalPrice.TabIndex = 180;
            this.Label_TotalPrice.Text = "Tổng :";
            // 
            // TextBox_TotalPrice
            // 
            this.TextBox_TotalPrice.BorderColor = System.Drawing.Color.Black;
            this.TextBox_TotalPrice.BorderRadius = 10;
            this.TextBox_TotalPrice.BorderThickness = 2;
            this.TextBox_TotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_TotalPrice.DefaultText = "";
            this.TextBox_TotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_TotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_TotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_TotalPrice.DisabledState.Parent = this.TextBox_TotalPrice;
            this.TextBox_TotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_TotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_TotalPrice.FocusedState.Parent = this.TextBox_TotalPrice;
            this.TextBox_TotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TotalPrice.ForeColor = System.Drawing.Color.Black;
            this.TextBox_TotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_TotalPrice.HoverState.Parent = this.TextBox_TotalPrice;
            this.TextBox_TotalPrice.Location = new System.Drawing.Point(106, 82);
            this.TextBox_TotalPrice.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TextBox_TotalPrice.Name = "TextBox_TotalPrice";
            this.TextBox_TotalPrice.PasswordChar = '\0';
            this.TextBox_TotalPrice.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_TotalPrice.PlaceholderText = "";
            this.TextBox_TotalPrice.SelectedText = "";
            this.TextBox_TotalPrice.ShadowDecoration.Parent = this.TextBox_TotalPrice;
            this.TextBox_TotalPrice.Size = new System.Drawing.Size(245, 42);
            this.TextBox_TotalPrice.TabIndex = 181;
            // 
            // Button_Order
            // 
            this.Button_Order.BorderColor = System.Drawing.Color.Crimson;
            this.Button_Order.BorderRadius = 10;
            this.Button_Order.BorderThickness = 2;
            this.Button_Order.CheckedState.Parent = this.Button_Order;
            this.Button_Order.CustomImages.Parent = this.Button_Order;
            this.Button_Order.FillColor = System.Drawing.Color.White;
            this.Button_Order.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Order.ForeColor = System.Drawing.Color.Crimson;
            this.Button_Order.HoverState.Parent = this.Button_Order;
            this.Button_Order.Location = new System.Drawing.Point(402, 69);
            this.Button_Order.Name = "Button_Order";
            this.Button_Order.PressedColor = System.Drawing.Color.Crimson;
            this.Button_Order.ShadowDecoration.Parent = this.Button_Order;
            this.Button_Order.Size = new System.Drawing.Size(187, 55);
            this.Button_Order.TabIndex = 170;
            this.Button_Order.Text = "Đặt món";
            this.Button_Order.Click += new System.EventHandler(this.Button_Order_Click);
            // 
            // Label_NumOfFood
            // 
            this.Label_NumOfFood.AutoSize = true;
            this.Label_NumOfFood.BackColor = System.Drawing.Color.White;
            this.Label_NumOfFood.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NumOfFood.ForeColor = System.Drawing.Color.Black;
            this.Label_NumOfFood.Location = new System.Drawing.Point(375, 25);
            this.Label_NumOfFood.Name = "Label_NumOfFood";
            this.Label_NumOfFood.Size = new System.Drawing.Size(46, 32);
            this.Label_NumOfFood.TabIndex = 179;
            this.Label_NumOfFood.Text = "SL:";
            // 
            // TextBox_SelectedFood
            // 
            this.TextBox_SelectedFood.BorderColor = System.Drawing.Color.Black;
            this.TextBox_SelectedFood.BorderRadius = 10;
            this.TextBox_SelectedFood.BorderThickness = 2;
            this.TextBox_SelectedFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_SelectedFood.DefaultText = "";
            this.TextBox_SelectedFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_SelectedFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_SelectedFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_SelectedFood.DisabledState.Parent = this.TextBox_SelectedFood;
            this.TextBox_SelectedFood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_SelectedFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_SelectedFood.FocusedState.Parent = this.TextBox_SelectedFood;
            this.TextBox_SelectedFood.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_SelectedFood.ForeColor = System.Drawing.Color.Black;
            this.TextBox_SelectedFood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_SelectedFood.HoverState.Parent = this.TextBox_SelectedFood;
            this.TextBox_SelectedFood.Location = new System.Drawing.Point(101, 15);
            this.TextBox_SelectedFood.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TextBox_SelectedFood.Name = "TextBox_SelectedFood";
            this.TextBox_SelectedFood.PasswordChar = '\0';
            this.TextBox_SelectedFood.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_SelectedFood.PlaceholderText = "";
            this.TextBox_SelectedFood.SelectedText = "";
            this.TextBox_SelectedFood.ShadowDecoration.Parent = this.TextBox_SelectedFood;
            this.TextBox_SelectedFood.Size = new System.Drawing.Size(250, 42);
            this.TextBox_SelectedFood.TabIndex = 178;
            // 
            // NumericUpDown_NumOfFood
            // 
            this.NumericUpDown_NumOfFood.BackColor = System.Drawing.Color.Transparent;
            this.NumericUpDown_NumOfFood.BorderColor = System.Drawing.Color.Black;
            this.NumericUpDown_NumOfFood.BorderThickness = 2;
            this.NumericUpDown_NumOfFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericUpDown_NumOfFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumericUpDown_NumOfFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumericUpDown_NumOfFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumericUpDown_NumOfFood.DisabledState.Parent = this.NumericUpDown_NumOfFood;
            this.NumericUpDown_NumOfFood.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumericUpDown_NumOfFood.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumericUpDown_NumOfFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumericUpDown_NumOfFood.FocusedState.Parent = this.NumericUpDown_NumOfFood;
            this.NumericUpDown_NumOfFood.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown_NumOfFood.ForeColor = System.Drawing.Color.Black;
            this.NumericUpDown_NumOfFood.Location = new System.Drawing.Point(440, 15);
            this.NumericUpDown_NumOfFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumericUpDown_NumOfFood.Name = "NumericUpDown_NumOfFood";
            this.NumericUpDown_NumOfFood.ShadowDecoration.Parent = this.NumericUpDown_NumOfFood;
            this.NumericUpDown_NumOfFood.Size = new System.Drawing.Size(131, 42);
            this.NumericUpDown_NumOfFood.TabIndex = 177;
            // 
            // Label_SelectedFood
            // 
            this.Label_SelectedFood.AutoSize = true;
            this.Label_SelectedFood.BackColor = System.Drawing.Color.White;
            this.Label_SelectedFood.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SelectedFood.ForeColor = System.Drawing.Color.Black;
            this.Label_SelectedFood.Location = new System.Drawing.Point(13, 25);
            this.Label_SelectedFood.Name = "Label_SelectedFood";
            this.Label_SelectedFood.Size = new System.Drawing.Size(78, 32);
            this.Label_SelectedFood.TabIndex = 175;
            this.Label_SelectedFood.Text = "Món :";
            // 
            // PictureBox_Discount
            // 
            this.PictureBox_Discount.BackColor = System.Drawing.Color.RoyalBlue;
            this.PictureBox_Discount.Image = global::QuanLyNhaHang.Properties.Resources.gift_box;
            this.PictureBox_Discount.Location = new System.Drawing.Point(383, 117);
            this.PictureBox_Discount.Name = "PictureBox_Discount";
            this.PictureBox_Discount.ShadowDecoration.Parent = this.PictureBox_Discount;
            this.PictureBox_Discount.Size = new System.Drawing.Size(73, 42);
            this.PictureBox_Discount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Discount.TabIndex = 171;
            this.PictureBox_Discount.TabStop = false;
            // 
            // Button_Search
            // 
            this.Button_Search.BorderColor = System.Drawing.Color.Orange;
            this.Button_Search.BorderRadius = 10;
            this.Button_Search.BorderThickness = 3;
            this.Button_Search.CheckedState.Parent = this.Button_Search;
            this.Button_Search.CustomImages.Parent = this.Button_Search;
            this.Button_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(202)))), ((int)(((byte)(36)))));
            this.Button_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Search.ForeColor = System.Drawing.Color.White;
            this.Button_Search.HoverState.Parent = this.Button_Search;
            this.Button_Search.Image = global::QuanLyNhaHang.Properties.Resources.search;
            this.Button_Search.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_Search.Location = new System.Drawing.Point(383, 54);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.PressedColor = System.Drawing.Color.White;
            this.Button_Search.ShadowDecoration.Parent = this.Button_Search;
            this.Button_Search.Size = new System.Drawing.Size(73, 51);
            this.Button_Search.TabIndex = 169;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // CHỌN_MÓN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 750);
            this.Controls.Add(this.Label_TableManagement);
            this.Controls.Add(this.FlowLayoutPanel_SelectedFood);
            this.Controls.Add(this.FlowLayoutPanel_Menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CHỌN_MÓN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN_MÓN";
            this.Load += new System.EventHandler(this.CHỌN_MÓN_Load);
            this.FlowLayoutPanel_SelectedFood.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_LeftTop.ResumeLayout(false);
            this.Panel_LeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_NumOfFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Discount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_SelectedFood;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Menu;
        private System.Windows.Forms.Label Label_TableManagement;
        private System.Windows.Forms.Label Label_Search;
        private Guna.UI2.WinForms.Guna2Button Button_Search;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Category;
        private Guna.UI2.WinForms.Guna2Button Button_Discount;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_Discount;
        private System.Windows.Forms.ListView ListView_OrderDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel Panel_LeftTop;
        private Guna.UI2.WinForms.Guna2Button Button_Order;
        private System.Windows.Forms.Label Label_SelectedFood;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericUpDown_NumOfFood;
        private System.Windows.Forms.Label Label_NumOfFood;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_SelectedFood;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label Label_TotalPrice;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_TotalPrice;
    }
}