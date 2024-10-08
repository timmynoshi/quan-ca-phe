namespace QuanLyQuanCaPhe
{
    partial class FormQuanLy_Ban_Sua
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
            this.combox_manv = new System.Windows.Forms.ComboBox();
            this.numUD_socho = new System.Windows.Forms.NumericUpDown();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tbox_maban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_socho)).BeginInit();
            this.SuspendLayout();
            // 
            // combox_manv
            // 
            this.combox_manv.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_manv.FormattingEnabled = true;
            this.combox_manv.Location = new System.Drawing.Point(372, 202);
            this.combox_manv.Name = "combox_manv";
            this.combox_manv.Size = new System.Drawing.Size(84, 36);
            this.combox_manv.TabIndex = 38;
            // 
            // numUD_socho
            // 
            this.numUD_socho.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUD_socho.Location = new System.Drawing.Point(372, 143);
            this.numUD_socho.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numUD_socho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_socho.Name = "numUD_socho";
            this.numUD_socho.Size = new System.Drawing.Size(84, 36);
            this.numUD_socho.TabIndex = 37;
            this.numUD_socho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.Bisque;
            this.btn_huy.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(524, 196);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(80, 46);
            this.btn_huy.TabIndex = 35;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Bisque;
            this.btn_ok.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(524, 88);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(80, 46);
            this.btn_ok.TabIndex = 36;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tbox_maban
            // 
            this.tbox_maban.BackColor = System.Drawing.Color.White;
            this.tbox_maban.Enabled = false;
            this.tbox_maban.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_maban.Location = new System.Drawing.Point(372, 88);
            this.tbox_maban.Name = "tbox_maban";
            this.tbox_maban.Size = new System.Drawing.Size(84, 34);
            this.tbox_maban.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(77, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mã nhân viên phụ trách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(185, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Số lượng chỗ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(247, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(286, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 30;
            this.label1.Text = "SỬA BÀN";
            // 
            // FormQuanLy_Ban_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(700, 320);
            this.Controls.Add(this.combox_manv);
            this.Controls.Add(this.numUD_socho);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tbox_maban);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLy_Ban_Sua";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormQuanLy_Ban_Sua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_socho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combox_manv;
        private System.Windows.Forms.NumericUpDown numUD_socho;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox tbox_maban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}