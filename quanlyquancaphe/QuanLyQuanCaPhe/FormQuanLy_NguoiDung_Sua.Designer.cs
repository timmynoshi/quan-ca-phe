namespace QuanLyQuanCaPhe
{
    partial class FormQuanLy_NguoiDung_Sua
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
            this.combox_quyenhan = new System.Windows.Forms.ComboBox();
            this.tbox_matkhau = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tbox_tendangnhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combox_quyenhan
            // 
            this.combox_quyenhan.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_quyenhan.FormattingEnabled = true;
            this.combox_quyenhan.Items.AddRange(new object[] {
            "NhanVien",
            "QuanTri"});
            this.combox_quyenhan.Location = new System.Drawing.Point(344, 180);
            this.combox_quyenhan.Name = "combox_quyenhan";
            this.combox_quyenhan.Size = new System.Drawing.Size(203, 36);
            this.combox_quyenhan.TabIndex = 19;
            // 
            // tbox_matkhau
            // 
            this.tbox_matkhau.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_matkhau.Location = new System.Drawing.Point(344, 129);
            this.tbox_matkhau.Name = "tbox_matkhau";
            this.tbox_matkhau.Size = new System.Drawing.Size(203, 36);
            this.tbox_matkhau.TabIndex = 18;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.Bisque;
            this.btn_huy.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(383, 247);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(80, 46);
            this.btn_huy.TabIndex = 16;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Bisque;
            this.btn_ok.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(238, 247);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(80, 46);
            this.btn_ok.TabIndex = 17;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tbox_tendangnhap
            // 
            this.tbox_tendangnhap.BackColor = System.Drawing.Color.White;
            this.tbox_tendangnhap.Enabled = false;
            this.tbox_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_tendangnhap.Location = new System.Drawing.Point(344, 80);
            this.tbox_tendangnhap.Name = "tbox_tendangnhap";
            this.tbox_tendangnhap.Size = new System.Drawing.Size(203, 34);
            this.tbox_tendangnhap.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(154, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quyền hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(154, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(154, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(199, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "CẬP NHẬT NGƯỜI DÙNG";
            // 
            // FormQuanLy_NguoiDung_Sua
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
            this.Name = "FormQuanLy_NguoiDung_Sua";
            this.Text = "FormQuanLy_NguoiDung_Sua";
            this.Load += new System.EventHandler(this.FormQuanLy_NguoiDung_Sua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combox_quyenhan;
        private System.Windows.Forms.TextBox tbox_matkhau;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox tbox_tendangnhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}