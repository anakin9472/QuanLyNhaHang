
namespace QuanLyNhaHang
{
    partial class FoodManagement
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
            this.DataGridView_Food = new System.Windows.Forms.DataGridView();
            this.Label_Title = new System.Windows.Forms.Label();
            this.PanelFood = new System.Windows.Forms.Panel();
            this.Label_NumOfFood = new System.Windows.Forms.Label();
            this.TextBox_NumOfFood = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Discount = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label_Discount = new System.Windows.Forms.Label();
            this.TextBox_FoodName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_FoodID = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBox_Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_FoodName = new System.Windows.Forms.Label();
            this.Label_Category = new System.Windows.Forms.Label();
            this.Label_FoodID = new System.Windows.Forms.Label();
            this.Button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_UploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Remove = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox_Food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Food)).BeginInit();
            this.PanelFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Food)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Food
            // 
            this.DataGridView_Food.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Food.Location = new System.Drawing.Point(604, 76);
            this.DataGridView_Food.Name = "DataGridView_Food";
            this.DataGridView_Food.RowHeadersWidth = 51;
            this.DataGridView_Food.RowTemplate.Height = 24;
            this.DataGridView_Food.Size = new System.Drawing.Size(716, 437);
            this.DataGridView_Food.TabIndex = 0;
            this.DataGridView_Food.Click += new System.EventHandler(this.DataGridView_Food_Click);
            // 
            // Label_Title
            // 
            this.Label_Title.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.ForeColor = System.Drawing.Color.White;
            this.Label_Title.Location = new System.Drawing.Point(500, 9);
            this.Label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(374, 52);
            this.Label_Title.TabIndex = 151;
            this.Label_Title.Text = "QUẢN LÝ MÓN ĂN";
            this.Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelFood
            // 
            this.PanelFood.Controls.Add(this.Label_NumOfFood);
            this.PanelFood.Controls.Add(this.TextBox_NumOfFood);
            this.PanelFood.Controls.Add(this.TextBox_Discount);
            this.PanelFood.Controls.Add(this.TextBox_Price);
            this.PanelFood.Controls.Add(this.Label_Discount);
            this.PanelFood.Controls.Add(this.TextBox_FoodName);
            this.PanelFood.Controls.Add(this.TextBox_FoodID);
            this.PanelFood.Controls.Add(this.ComboBox_Category);
            this.PanelFood.Controls.Add(this.Label_Price);
            this.PanelFood.Controls.Add(this.Label_FoodName);
            this.PanelFood.Controls.Add(this.Label_Category);
            this.PanelFood.Controls.Add(this.Label_FoodID);
            this.PanelFood.Location = new System.Drawing.Point(13, 65);
            this.PanelFood.Margin = new System.Windows.Forms.Padding(4);
            this.PanelFood.Name = "PanelFood";
            this.PanelFood.Size = new System.Drawing.Size(568, 329);
            this.PanelFood.TabIndex = 152;
            // 
            // Label_NumOfFood
            // 
            this.Label_NumOfFood.AutoSize = true;
            this.Label_NumOfFood.BackColor = System.Drawing.Color.White;
            this.Label_NumOfFood.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NumOfFood.Location = new System.Drawing.Point(12, 284);
            this.Label_NumOfFood.Name = "Label_NumOfFood";
            this.Label_NumOfFood.Size = new System.Drawing.Size(119, 32);
            this.Label_NumOfFood.TabIndex = 168;
            this.Label_NumOfFood.Text = "Số lượng:";
            // 
            // TextBox_NumOfFood
            // 
            this.TextBox_NumOfFood.BorderColor = System.Drawing.Color.Black;
            this.TextBox_NumOfFood.BorderRadius = 10;
            this.TextBox_NumOfFood.BorderThickness = 2;
            this.TextBox_NumOfFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_NumOfFood.DefaultText = "";
            this.TextBox_NumOfFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_NumOfFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_NumOfFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_NumOfFood.DisabledState.Parent = this.TextBox_NumOfFood;
            this.TextBox_NumOfFood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_NumOfFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_NumOfFood.FocusedState.Parent = this.TextBox_NumOfFood;
            this.TextBox_NumOfFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_NumOfFood.ForeColor = System.Drawing.Color.Black;
            this.TextBox_NumOfFood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_NumOfFood.HoverState.Parent = this.TextBox_NumOfFood;
            this.TextBox_NumOfFood.Location = new System.Drawing.Point(208, 284);
            this.TextBox_NumOfFood.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_NumOfFood.Name = "TextBox_NumOfFood";
            this.TextBox_NumOfFood.PasswordChar = '\0';
            this.TextBox_NumOfFood.PlaceholderText = "";
            this.TextBox_NumOfFood.SelectedText = "";
            this.TextBox_NumOfFood.ShadowDecoration.Parent = this.TextBox_NumOfFood;
            this.TextBox_NumOfFood.Size = new System.Drawing.Size(350, 38);
            this.TextBox_NumOfFood.TabIndex = 167;
            // 
            // TextBox_Discount
            // 
            this.TextBox_Discount.BackColor = System.Drawing.Color.White;
            this.TextBox_Discount.BorderColor = System.Drawing.Color.Black;
            this.TextBox_Discount.BorderRadius = 10;
            this.TextBox_Discount.BorderThickness = 2;
            this.TextBox_Discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Discount.DefaultText = "";
            this.TextBox_Discount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Discount.DisabledState.Parent = this.TextBox_Discount;
            this.TextBox_Discount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Discount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Discount.FocusedState.Parent = this.TextBox_Discount;
            this.TextBox_Discount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Discount.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Discount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Discount.HoverState.Parent = this.TextBox_Discount;
            this.TextBox_Discount.Location = new System.Drawing.Point(208, 232);
            this.TextBox_Discount.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_Discount.Name = "TextBox_Discount";
            this.TextBox_Discount.PasswordChar = '\0';
            this.TextBox_Discount.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_Discount.PlaceholderText = "";
            this.TextBox_Discount.SelectedText = "";
            this.TextBox_Discount.ShadowDecoration.Parent = this.TextBox_Discount;
            this.TextBox_Discount.Size = new System.Drawing.Size(350, 38);
            this.TextBox_Discount.TabIndex = 166;
            // 
            // TextBox_Price
            // 
            this.TextBox_Price.BorderColor = System.Drawing.Color.Black;
            this.TextBox_Price.BorderRadius = 10;
            this.TextBox_Price.BorderThickness = 2;
            this.TextBox_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Price.DefaultText = "";
            this.TextBox_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Price.DisabledState.Parent = this.TextBox_Price;
            this.TextBox_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Price.FocusedState.Parent = this.TextBox_Price;
            this.TextBox_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Price.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Price.HoverState.Parent = this.TextBox_Price;
            this.TextBox_Price.Location = new System.Drawing.Point(208, 180);
            this.TextBox_Price.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.PasswordChar = '\0';
            this.TextBox_Price.PlaceholderText = "";
            this.TextBox_Price.SelectedText = "";
            this.TextBox_Price.ShadowDecoration.Parent = this.TextBox_Price;
            this.TextBox_Price.Size = new System.Drawing.Size(350, 38);
            this.TextBox_Price.TabIndex = 165;
            // 
            // Label_Discount
            // 
            this.Label_Discount.AutoSize = true;
            this.Label_Discount.BackColor = System.Drawing.Color.White;
            this.Label_Discount.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Discount.Location = new System.Drawing.Point(12, 232);
            this.Label_Discount.Name = "Label_Discount";
            this.Label_Discount.Size = new System.Drawing.Size(193, 32);
            this.Label_Discount.TabIndex = 164;
            this.Label_Discount.Text = "Khuyến mãi (%):";
            // 
            // TextBox_FoodName
            // 
            this.TextBox_FoodName.BorderColor = System.Drawing.Color.Black;
            this.TextBox_FoodName.BorderRadius = 10;
            this.TextBox_FoodName.BorderThickness = 2;
            this.TextBox_FoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_FoodName.DefaultText = "";
            this.TextBox_FoodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_FoodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_FoodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_FoodName.DisabledState.Parent = this.TextBox_FoodName;
            this.TextBox_FoodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_FoodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_FoodName.FocusedState.Parent = this.TextBox_FoodName;
            this.TextBox_FoodName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_FoodName.ForeColor = System.Drawing.Color.Black;
            this.TextBox_FoodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_FoodName.HoverState.Parent = this.TextBox_FoodName;
            this.TextBox_FoodName.Location = new System.Drawing.Point(208, 65);
            this.TextBox_FoodName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_FoodName.Name = "TextBox_FoodName";
            this.TextBox_FoodName.PasswordChar = '\0';
            this.TextBox_FoodName.PlaceholderText = "";
            this.TextBox_FoodName.SelectedText = "";
            this.TextBox_FoodName.ShadowDecoration.Parent = this.TextBox_FoodName;
            this.TextBox_FoodName.Size = new System.Drawing.Size(350, 38);
            this.TextBox_FoodName.TabIndex = 147;
            // 
            // TextBox_FoodID
            // 
            this.TextBox_FoodID.BorderColor = System.Drawing.Color.Black;
            this.TextBox_FoodID.BorderRadius = 10;
            this.TextBox_FoodID.BorderThickness = 2;
            this.TextBox_FoodID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_FoodID.DefaultText = "";
            this.TextBox_FoodID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_FoodID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_FoodID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_FoodID.DisabledState.Parent = this.TextBox_FoodID;
            this.TextBox_FoodID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_FoodID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_FoodID.FocusedState.Parent = this.TextBox_FoodID;
            this.TextBox_FoodID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_FoodID.ForeColor = System.Drawing.Color.Black;
            this.TextBox_FoodID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_FoodID.HoverState.Parent = this.TextBox_FoodID;
            this.TextBox_FoodID.Location = new System.Drawing.Point(208, 9);
            this.TextBox_FoodID.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_FoodID.Name = "TextBox_FoodID";
            this.TextBox_FoodID.PasswordChar = '\0';
            this.TextBox_FoodID.PlaceholderText = "";
            this.TextBox_FoodID.SelectedText = "";
            this.TextBox_FoodID.ShadowDecoration.Parent = this.TextBox_FoodID;
            this.TextBox_FoodID.Size = new System.Drawing.Size(350, 38);
            this.TextBox_FoodID.TabIndex = 146;
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
            this.ComboBox_Category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Category.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_Category.FormattingEnabled = true;
            this.ComboBox_Category.HoverState.Parent = this.ComboBox_Category;
            this.ComboBox_Category.ItemHeight = 30;
            this.ComboBox_Category.ItemsAppearance.Parent = this.ComboBox_Category;
            this.ComboBox_Category.Location = new System.Drawing.Point(208, 125);
            this.ComboBox_Category.Name = "ComboBox_Category";
            this.ComboBox_Category.ShadowDecoration.Parent = this.ComboBox_Category;
            this.ComboBox_Category.Size = new System.Drawing.Size(350, 36);
            this.ComboBox_Category.TabIndex = 145;
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.BackColor = System.Drawing.Color.White;
            this.Label_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.Location = new System.Drawing.Point(12, 186);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(130, 32);
            this.Label_Price.TabIndex = 140;
            this.Label_Price.Text = "Giá (VNĐ):";
            // 
            // Label_FoodName
            // 
            this.Label_FoodName.AutoSize = true;
            this.Label_FoodName.BackColor = System.Drawing.Color.White;
            this.Label_FoodName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FoodName.Location = new System.Drawing.Point(12, 71);
            this.Label_FoodName.Name = "Label_FoodName";
            this.Label_FoodName.Size = new System.Drawing.Size(149, 32);
            this.Label_FoodName.TabIndex = 139;
            this.Label_FoodName.Text = "Tên món ăn:";
            this.Label_FoodName.Click += new System.EventHandler(this.label2_Click);
            // 
            // Label_Category
            // 
            this.Label_Category.AutoSize = true;
            this.Label_Category.BackColor = System.Drawing.Color.White;
            this.Label_Category.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Category.Location = new System.Drawing.Point(12, 129);
            this.Label_Category.Name = "Label_Category";
            this.Label_Category.Size = new System.Drawing.Size(132, 32);
            this.Label_Category.TabIndex = 141;
            this.Label_Category.Text = "Danh mục:";
            // 
            // Label_FoodID
            // 
            this.Label_FoodID.AutoSize = true;
            this.Label_FoodID.BackColor = System.Drawing.Color.White;
            this.Label_FoodID.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FoodID.Location = new System.Drawing.Point(12, 15);
            this.Label_FoodID.Name = "Label_FoodID";
            this.Label_FoodID.Size = new System.Drawing.Size(135, 32);
            this.Label_FoodID.TabIndex = 134;
            this.Label_FoodID.Text = "ID món ăn:";
            // 
            // Button_Add
            // 
            this.Button_Add.BorderColor = System.Drawing.Color.Firebrick;
            this.Button_Add.BorderRadius = 10;
            this.Button_Add.BorderThickness = 3;
            this.Button_Add.CheckedState.Parent = this.Button_Add;
            this.Button_Add.CustomImages.Parent = this.Button_Add;
            this.Button_Add.FillColor = System.Drawing.Color.White;
            this.Button_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.Color.Crimson;
            this.Button_Add.HoverState.Parent = this.Button_Add;
            this.Button_Add.Location = new System.Drawing.Point(795, 532);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.ShadowDecoration.Parent = this.Button_Add;
            this.Button_Add.Size = new System.Drawing.Size(145, 55);
            this.Button_Add.TabIndex = 159;
            this.Button_Add.Text = "Thêm";
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_UploadImage
            // 
            this.Button_UploadImage.BorderRadius = 10;
            this.Button_UploadImage.BorderThickness = 3;
            this.Button_UploadImage.CheckedState.Parent = this.Button_UploadImage;
            this.Button_UploadImage.CustomImages.Parent = this.Button_UploadImage;
            this.Button_UploadImage.FillColor = System.Drawing.Color.White;
            this.Button_UploadImage.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UploadImage.ForeColor = System.Drawing.Color.Black;
            this.Button_UploadImage.HoverState.Parent = this.Button_UploadImage;
            this.Button_UploadImage.Location = new System.Drawing.Point(389, 587);
            this.Button_UploadImage.Name = "Button_UploadImage";
            this.Button_UploadImage.ShadowDecoration.Parent = this.Button_UploadImage;
            this.Button_UploadImage.Size = new System.Drawing.Size(159, 55);
            this.Button_UploadImage.TabIndex = 160;
            this.Button_UploadImage.Text = "Thêm ảnh";
            this.Button_UploadImage.Click += new System.EventHandler(this.Button_UploadImage_Click);
            // 
            // Button_Remove
            // 
            this.Button_Remove.BorderColor = System.Drawing.Color.Firebrick;
            this.Button_Remove.BorderRadius = 10;
            this.Button_Remove.BorderThickness = 3;
            this.Button_Remove.CheckedState.Parent = this.Button_Remove;
            this.Button_Remove.CustomImages.Parent = this.Button_Remove;
            this.Button_Remove.FillColor = System.Drawing.Color.White;
            this.Button_Remove.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Remove.ForeColor = System.Drawing.Color.Crimson;
            this.Button_Remove.HoverState.Parent = this.Button_Remove;
            this.Button_Remove.Location = new System.Drawing.Point(990, 532);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.ShadowDecoration.Parent = this.Button_Remove;
            this.Button_Remove.Size = new System.Drawing.Size(149, 55);
            this.Button_Remove.TabIndex = 163;
            this.Button_Remove.Text = "Xoá";
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.BorderColor = System.Drawing.Color.Firebrick;
            this.Button_Edit.BorderRadius = 10;
            this.Button_Edit.BorderThickness = 3;
            this.Button_Edit.CheckedState.Parent = this.Button_Edit;
            this.Button_Edit.CustomImages.Parent = this.Button_Edit;
            this.Button_Edit.FillColor = System.Drawing.Color.White;
            this.Button_Edit.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Edit.ForeColor = System.Drawing.Color.Crimson;
            this.Button_Edit.HoverState.Parent = this.Button_Edit;
            this.Button_Edit.Location = new System.Drawing.Point(1176, 532);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.ShadowDecoration.Parent = this.Button_Edit;
            this.Button_Edit.Size = new System.Drawing.Size(144, 55);
            this.Button_Edit.TabIndex = 164;
            this.Button_Edit.Text = "Sửa";
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.BorderColor = System.Drawing.Color.Firebrick;
            this.Button_Refresh.BorderRadius = 10;
            this.Button_Refresh.BorderThickness = 3;
            this.Button_Refresh.CheckedState.Parent = this.Button_Refresh;
            this.Button_Refresh.CustomImages.Parent = this.Button_Refresh;
            this.Button_Refresh.FillColor = System.Drawing.Color.White;
            this.Button_Refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Refresh.ForeColor = System.Drawing.Color.Crimson;
            this.Button_Refresh.HoverState.Parent = this.Button_Refresh;
            this.Button_Refresh.Location = new System.Drawing.Point(604, 532);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.ShadowDecoration.Parent = this.Button_Refresh;
            this.Button_Refresh.Size = new System.Drawing.Size(145, 55);
            this.Button_Refresh.TabIndex = 165;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // PictureBox_Food
            // 
            this.PictureBox_Food.BackColor = System.Drawing.Color.MistyRose;
            this.PictureBox_Food.Location = new System.Drawing.Point(31, 401);
            this.PictureBox_Food.Name = "PictureBox_Food";
            this.PictureBox_Food.Size = new System.Drawing.Size(325, 241);
            this.PictureBox_Food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Food.TabIndex = 162;
            this.PictureBox_Food.TabStop = false;
            // 
            // FoodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 683);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.PictureBox_Food);
            this.Controls.Add(this.Button_UploadImage);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.PanelFood);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.DataGridView_Food);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodManagement";
            this.Load += new System.EventHandler(this.FoodManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Food)).EndInit();
            this.PanelFood.ResumeLayout(false);
            this.PanelFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Food;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Panel PanelFood;
        private System.Windows.Forms.Label Label_FoodName;
        private System.Windows.Forms.Label Label_FoodID;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Label Label_Category;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Category;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_FoodName;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_FoodID;
        private Guna.UI2.WinForms.Guna2Button Button_Add;
        private Guna.UI2.WinForms.Guna2Button Button_UploadImage;
        private System.Windows.Forms.PictureBox PictureBox_Food;
        private Guna.UI2.WinForms.Guna2Button Button_Remove;
        private Guna.UI2.WinForms.Guna2Button Button_Edit;
        private Guna.UI2.WinForms.Guna2Button Button_Refresh;
        private System.Windows.Forms.Label Label_Discount;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Discount;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Price;
        private System.Windows.Forms.Label Label_NumOfFood;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_NumOfFood;
    }
}