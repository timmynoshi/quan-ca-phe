using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class FormQuanLy_NguoiDung_Them : Form
    {
        private FormQuanLy_NguoiDung parentForm;
        public FormQuanLy_NguoiDung_Them(FormQuanLy_NguoiDung form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbox_tendangnhap.Text) || string.IsNullOrEmpty(tbox_matkhau.Text))
            {
                erPro_saitkmk.SetError(tbox_tendangnhap, "Tên đăng nhập hoặc mật khẩu ko hợp lệ");
            }
            else
            {
                string tenDangNhap = tbox_tendangnhap.Text;
                string matKhau = tbox_matkhau.Text;
                string quyenhan = combox_quyenhan.SelectedItem.ToString();
                FormQuanLy_NguoiDung.Themnguoidung(tenDangNhap, matKhau, quyenhan);
                parentForm.CapnhatDataGridView();
                this.Close();
            }
        }

        private void FormQuanLy_NguoiDung_Them_Load(object sender, EventArgs e)
        {
            combox_quyenhan.SelectedIndex = 0;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbox_tendangnhap_TextChanged(object sender, EventArgs e)
        {
            erPro_saitkmk.Clear();
        }

        private void tbox_matkhau_TextChanged(object sender, EventArgs e)
        {
            erPro_saitkmk.Clear();
        }
    }
}
