namespace QuanLyQuanCaPhe
{
    partial class FormQuanLy_NguoiDung_Them
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
            this.tbox_matkhau = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tbox_tendangnhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_quyenhan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.erPro_saitkmk = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erPro_saitkmk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(226, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM NGƯỜI DÙNG";
            // 
            // tbox_matkhau
            // 
            this.tbox_matkhau.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_matkhau.Location = new System.Drawing.Point(344, 128);
            this.tbox_matkhau.Name = "tbox_matkhau";
            this.tbox_matkhau.Size = new System.Drawing.Size(203, 36);
            this.tbox_matkhau.TabIndex = 9;
            this.tbox_matkhau.TextChanged += new System.EventHandler(this.tbox_matkhau_TextChanged);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.Bisque;
            this.btn_huy.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(383, 246);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(80, 46);
            this.btn_huy.TabIndex = 7;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Bisque;
            this.btn_ok.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(238, 246);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(80, 46);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tbox_tendangnhap
            // 
            this.tbox_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_tendangnhap.Location = new System.Drawing.Point(344, 79);
            this.tbox_tendangnhap.Name = "tbox_tendangnhap";
            this.tbox_tendangnhap.Size = new System.Drawing.Size(203, 34);
            this.tbox_tendangnhap.TabIndex = 6;
            this.tbox_tendangnhap.TextChanged += new System.EventHandler(this.tbox_tendangnhap_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(154, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(154, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên đăng nhập";
            // 
            // combox_quyenhan
            // 
            this.combox_quyenhan.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_quyenhan.FormattingEnabled = true;
            this.combox_quyenhan.Items.AddRange(new object[] {
            "NhanVien",
            "QuanTri"});
            this.combox_quyenhan.Location = new System.Drawing.Point(344, 179);
            this.combox_quyenhan.Name = "combox_quyenhan";
            this.combox_quyenhan.Size = new System.Drawing.Size(203, 36);
            this.combox_quyenhan.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(154, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quyền hạn";
            // 
            // erPro_saitkmk
            // 
            this.erPro_saitkmk.ContainerControl = this;
            // 
            // FormQuanLy_NguoiDung_Them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(700, 320);
            this.Controls.Add(this.combox_quyenhan);
            this.Controls.Add(this.tbox_matkhau);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tbox_tendangnhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLy_NguoiDung_Them";
            this.Text = "FormQuanLy_NguoiDung_Them";
            this.Load += new System.EventHandler(this.FormQuanLy_NguoiDung_Them_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erPro_saitkmk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_matkhau;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox tbox_tendangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combox_quyenhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider erPro_saitkmk;
    }
}