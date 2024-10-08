namespace QuanLyQuanCaPhe
{
    partial class FormThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanCaPheDataSet14 = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet14();
            this.hoaDonTableAdapter = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet14TableAdapters.HoaDonTableAdapter();
            this.quanLyQuanCaPheDataSet15 = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet15();
            this.cTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTHDTableAdapter = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet15TableAdapters.CTHDTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_tonggiatri = new System.Windows.Forms.TextBox();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.dataGV_custom = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grbox_thongke = new System.Windows.Forms.GroupBox();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_custom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grbox_thongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 241);
            this.dataGridView1.TabIndex = 1;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLyQuanCaPheDataSet14;
            // 
            // quanLyQuanCaPheDataSet14
            // 
            this.quanLyQuanCaPheDataSet14.DataSetName = "QuanLyQuanCaPheDataSet14";
            this.quanLyQuanCaPheDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyQuanCaPheDataSet15
            // 
            this.quanLyQuanCaPheDataSet15.DataSetName = "QuanLyQuanCaPheDataSet15";
            this.quanLyQuanCaPheDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTHDBindingSource
            // 
            this.cTHDBindingSource.DataMember = "CTHD";
            this.cTHDBindingSource.DataSource = this.quanLyQuanCaPheDataSet15;
            // 
            // cTHDTableAdapter
            // 
            this.cTHDTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(785, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "DOANH THU";
            // 
            // tbox_tonggiatri
            // 
            this.tbox_tonggiatri.BackColor = System.Drawing.Color.Snow;
            this.tbox_tonggiatri.Enabled = false;
            this.tbox_tonggiatri.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_tonggiatri.ForeColor = System.Drawing.Color.Red;
            this.tbox_tonggiatri.Location = new System.Drawing.Point(791, 168);
            this.tbox_tonggiatri.Name = "tbox_tonggiatri";
            this.tbox_tonggiatri.Size = new System.Drawing.Size(223, 43);
            this.tbox_tonggiatri.TabIndex = 2;
            this.tbox_tonggiatri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Location = new System.Drawing.Point(53, 45);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(155, 37);
            this.btn_nhanvien.TabIndex = 3;
            this.btn_nhanvien.Text = "Nhân viên";
            this.btn_nhanvien.UseVisualStyleBackColor = true;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // dataGV_custom
            // 
            this.dataGV_custom.AllowUserToAddRows = false;
            this.dataGV_custom.AllowUserToDeleteRows = false;
            this.dataGV_custom.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGV_custom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_custom.Location = new System.Drawing.Point(795, 365);
            this.dataGV_custom.Name = "dataGV_custom";
            this.dataGV_custom.ReadOnly = true;
            this.dataGV_custom.RowHeadersWidth = 51;
            this.dataGV_custom.RowTemplate.Height = 24;
            this.dataGV_custom.Size = new System.Drawing.Size(464, 241);
            this.dataGV_custom.TabIndex = 4;
            this.dataGV_custom.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 365);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(735, 241);
            this.dataGridView2.TabIndex = 1;
            // 
            // grbox_thongke
            // 
            this.grbox_thongke.Controls.Add(this.btn_khachhang);
            this.grbox_thongke.Controls.Add(this.btn_nhanvien);
            this.grbox_thongke.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_thongke.Location = new System.Drawing.Point(791, 248);
            this.grbox_thongke.Name = "grbox_thongke";
            this.grbox_thongke.Size = new System.Drawing.Size(473, 100);
            this.grbox_thongke.TabIndex = 5;
            this.grbox_thongke.TabStop = false;
            this.grbox_thongke.Text = "Thống kê theo";
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.Location = new System.Drawing.Point(262, 45);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(155, 37);
            this.btn_khachhang.TabIndex = 3;
            this.btn_khachhang.Text = "Khách hàng";
            this.btn_khachhang.UseVisualStyleBackColor = true;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyQuanCaPhe.Properties.Resources.willow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1185, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1276, 715);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbox_thongke);
            this.Controls.Add(this.dataGV_custom);
            this.Controls.Add(this.tbox_tonggiatri);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_custom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grbox_thongke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyQuanCaPheDataSet14 quanLyQuanCaPheDataSet14;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLyQuanCaPheDataSet14TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private QuanLyQuanCaPheDataSet15 quanLyQuanCaPheDataSet15;
        private System.Windows.Forms.BindingSource cTHDBindingSource;
        private QuanLyQuanCaPheDataSet15TableAdapters.CTHDTableAdapter cTHDTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_tonggiatri;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.DataGridView dataGV_custom;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox grbox_thongke;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}