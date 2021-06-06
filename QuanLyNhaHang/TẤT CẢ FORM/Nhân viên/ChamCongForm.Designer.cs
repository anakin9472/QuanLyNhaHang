
namespace QuanLyNhaHang
{
    partial class ChamCongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamCongForm));
            this.dataGridView_ChamCong = new System.Windows.Forms.DataGridView();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_SaveToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ChamCong
            // 
            this.dataGridView_ChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChamCong.Location = new System.Drawing.Point(32, 36);
            this.dataGridView_ChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ChamCong.Name = "dataGridView_ChamCong";
            this.dataGridView_ChamCong.RowHeadersWidth = 51;
            this.dataGridView_ChamCong.Size = new System.Drawing.Size(477, 431);
            this.dataGridView_ChamCong.TabIndex = 0;
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Print.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.Location = new System.Drawing.Point(311, 474);
            this.button_Print.Margin = new System.Windows.Forms.Padding(4);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(132, 65);
            this.button_Print.TabIndex = 1;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.ToPrinterBtn_Click);
            // 
            // button_SaveToFile
            // 
            this.button_SaveToFile.BackColor = System.Drawing.Color.Lime;
            this.button_SaveToFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveToFile.Location = new System.Drawing.Point(89, 474);
            this.button_SaveToFile.Margin = new System.Windows.Forms.Padding(4);
            this.button_SaveToFile.Name = "button_SaveToFile";
            this.button_SaveToFile.Size = new System.Drawing.Size(132, 65);
            this.button_SaveToFile.TabIndex = 2;
            this.button_SaveToFile.Text = "Save";
            this.button_SaveToFile.UseVisualStyleBackColor = false;
            this.button_SaveToFile.Click += new System.EventHandler(this.SaveToFileBtn_Click);
            // 
            // ChamCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 554);
            this.Controls.Add(this.button_SaveToFile);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.dataGridView_ChamCong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChamCongForm";
            this.Text = "ChamCongForm";
            this.Load += new System.EventHandler(this.ChamCongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ChamCong;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button button_SaveToFile;
    }
}