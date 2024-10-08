namespace QuanLyQuanCaPhe
{
    partial class FormDangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_tendangnhap = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.tbox_matkhau = new System.Windows.Forms.TextBox();
            this.erPro_saitkmk = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbox_hienthi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.erPro_saitkmk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(219, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(85, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(85, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // tbox_tendangnhap
            // 
            this.tbox_tendangnhap.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_tendangnhap.Location = new System.Drawing.Point(313, 82);
            this.tbox_tendangnhap.Name = "tbox_tendangnhap";
            this.tbox_tendangnhap.Size = new System.Drawing.Size(203, 35);
            this.tbox_tendangnhap.TabIndex = 1;
            this.tbox_tendangnhap.TextChanged += new System.EventHandler(this.tbox_tendangnhap_TextChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Bisque;
            this.btn_ok.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(189, 233);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(80, 46);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.Bisque;
            this.btn_huy.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(331, 233);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(80, 46);
            this.btn_huy.TabIndex = 2;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // tbox_matkhau
            // 
            this.tbox_matkhau.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_matkhau.Location = new System.Drawing.Point(313, 148);
            this.tbox_matkhau.Name = "tbox_matkhau";
            this.tbox_matkhau.PasswordChar = '*';
            this.tbox_matkhau.Size = new System.Drawing.Size(203, 35);
            this.tbox_matkhau.TabIndex = 3;
            this.tbox_matkhau.TextChanged += new System.EventHandler(this.tbox_matkhau_TextChanged);
            // 
            // erPro_saitkmk
            // 
            this.erPro_saitkmk.ContainerControl = this;
            // 
            // cbox_hienthi
            // 
            this.cbox_hienthi.AutoSize = true;
            this.cbox_hienthi.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_hienthi.ForeColor = System.Drawing.Color.Bisque;
            this.cbox_hienthi.Location = new System.Drawing.Point(426, 201);
            this.cbox_hienthi.Name = "cbox_hienthi";
            this.cbox_hienthi.Size = new System.Drawing.Size(90, 25);
            this.cbox_hienthi.TabIndex = 4;
            this.cbox_hienthi.Text = "Hiển thị";
            this.cbox_hienthi.UseVisualStyleBackColor = true;
            this.cbox_hienthi.CheckedChanged += new System.EventHandler(this.cbox_hienthi_CheckedChanged);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.cbox_hienthi);
            this.Controls.Add(this.tbox_matkhau);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tbox_tendangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erPro_saitkmk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_tendangnhap;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.TextBox tbox_matkhau;
        private System.Windows.Forms.ErrorProvider erPro_saitkmk;
        private System.Windows.Forms.CheckBox cbox_hienthi;
    }
}