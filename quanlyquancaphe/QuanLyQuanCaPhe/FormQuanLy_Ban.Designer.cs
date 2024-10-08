namespace QuanLyQuanCaPhe
{
    partial class FormQuanLy_Ban
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
            this.btn_sua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGV_ban = new System.Windows.Forms.DataGridView();
            this.banBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanCaPheDataSet2 = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet2();
            this.banTableAdapter = new QuanLyQuanCaPhe.QuanLyQuanCaPheDataSet2TableAdapters.BanTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_sua.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(702, 128);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(110, 53);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGV_ban);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH BÀN";
            // 
            // dataGV_ban
            // 
            this.dataGV_ban.AllowUserToAddRows = false;
            this.dataGV_ban.AllowUserToDeleteRows = false;
            this.dataGV_ban.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGV_ban.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGV_ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_ban.Location = new System.Drawing.Point(19, 44);
            this.dataGV_ban.MultiSelect = false;
            this.dataGV_ban.Name = "dataGV_ban";
            this.dataGV_ban.ReadOnly = true;
            this.dataGV_ban.RowHeadersWidth = 51;
            this.dataGV_ban.RowTemplate.Height = 24;
            this.dataGV_ban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_ban.Size = new System.Drawing.Size(630, 150);
            this.dataGV_ban.TabIndex = 1;
            this.dataGV_ban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_ban_CellContentClick);
            // 
            // banBindingSource
            // 
            this.banBindingSource.DataMember = "Ban";
            this.banBindingSource.DataSource = this.quanLyQuanCaPheDataSet2;
            // 
            // quanLyQuanCaPheDataSet2
            // 
            this.quanLyQuanCaPheDataSet2.DataSetName = "QuanLyQuanCaPheDataSet2";
            this.quanLyQuanCaPheDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banTableAdapter
            // 
            this.banTableAdapter.ClearBeforeFill = true;
            // 
            // FormQuanLy_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(840, 700);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLy_Ban";
            this.Text = "FormQuanLy_Ban";
            this.Load += new System.EventHandler(this.FormQuanLy_Ban_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGV_ban;
        private QuanLyQuanCaPheDataSet2 quanLyQuanCaPheDataSet2;
        private System.Windows.Forms.BindingSource banBindingSource;
        private QuanLyQuanCaPheDataSet2TableAdapters.BanTableAdapter banTableAdapter;
    }
}