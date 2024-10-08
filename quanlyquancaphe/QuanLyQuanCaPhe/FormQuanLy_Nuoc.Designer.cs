namespace QuanLyQuanCaPhe
{
    partial class FormQuanLy_Nuoc
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
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGV_nuoc = new System.Windows.Forms.DataGridView();
            this.nuocBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanCaPheDataSet5 = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet5();
            this.quanLyQuanCaPheDataSet3 = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet3();
            this.nuocTableAdapter = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet3TableAdapters.NuocTableAdapter();
            this.quanLyQuanCaPheDataSet4 = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet4();
            this.nuocTableAdapter1 = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet4TableAdapters.NuocTableAdapter();
            this.nuocTableAdapter2 = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet5TableAdapters.NuocTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_nuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuocBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_xoa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(702, 187);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 53);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_sua.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(702, 128);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(110, 53);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_them.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(702, 69);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(110, 53);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGV_nuoc);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 211);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THỨC UỐNG";
            // 
            // dataGV_nuoc
            // 
            this.dataGV_nuoc.AllowUserToAddRows = false;
            this.dataGV_nuoc.AllowUserToDeleteRows = false;
            this.dataGV_nuoc.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGV_nuoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGV_nuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_nuoc.Location = new System.Drawing.Point(27, 37);
            this.dataGV_nuoc.MultiSelect = false;
            this.dataGV_nuoc.Name = "dataGV_nuoc";
            this.dataGV_nuoc.ReadOnly = true;
            this.dataGV_nuoc.RowHeadersWidth = 51;
            this.dataGV_nuoc.RowTemplate.Height = 24;
            this.dataGV_nuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_nuoc.Size = new System.Drawing.Size(604, 150);
            this.dataGV_nuoc.TabIndex = 2;
            // 
            // nuocBindingSource2
            // 
            this.nuocBindingSource2.DataMember = "Nuoc";
            this.nuocBindingSource2.DataSource = this.quanLyQuanCaPheDataSet5;
            // 
            // quanLyQuanCaPheDataSet5
            // 
            this.quanLyQuanCaPheDataSet5.DataSetName = "QuanLyQuanCaPheDataSet5";
            this.quanLyQuanCaPheDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyQuanCaPheDataSet3
            // 
            this.quanLyQuanCaPheDataSet3.DataSetName = "QuanLyQuanCaPheDataSet3";
            this.quanLyQuanCaPheDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nuocTableAdapter
            // 
            this.nuocTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyQuanCaPheDataSet4
            // 
            this.quanLyQuanCaPheDataSet4.DataSetName = "QuanLyQuanCaPheDataSet4";
            this.quanLyQuanCaPheDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nuocTableAdapter1
            // 
            this.nuocTableAdapter1.ClearBeforeFill = true;
            // 
            // nuocTableAdapter2
            // 
            this.nuocTableAdapter2.ClearBeforeFill = true;
            // 
            // FormQuanLy_Nuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(840, 700);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLy_Nuoc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormQuanLy_Nuoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_nuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuocBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private QuanLyQuanCaPheDataSet3 quanLyQuanCaPheDataSet3;
        private QuanLyQuanCaPheDataSet3TableAdapters.NuocTableAdapter nuocTableAdapter;
        private QuanLyQuanCaPheDataSet4 quanLyQuanCaPheDataSet4;
        private QuanLyQuanCaPheDataSet4TableAdapters.NuocTableAdapter nuocTableAdapter1;
        private System.Windows.Forms.DataGridView dataGV_nuoc;
        private QuanLyQuanCaPheDataSet5 quanLyQuanCaPheDataSet5;
        private System.Windows.Forms.BindingSource nuocBindingSource2;
        private QuanLyQuanCaPheDataSet5TableAdapters.NuocTableAdapter nuocTableAdapter2;
    }
}