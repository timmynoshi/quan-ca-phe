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
    public partial class FormQuanLy_NguoiDung_Sua : Form
    {
        private FormQuanLy_NguoiDung parentForm;
        private string tenDangNhap;

        public FormQuanLy_NguoiDung_Sua(FormQuanLy_NguoiDung form, string tenDangNhap)
        {
            InitializeComponent();
            parentForm = form;
            this.tenDangNhap = tenDangNhap;
        }

        private void FormQuanLy_NguoiDung_Sua_Load(object sender, EventArgs e)
        {
            tbox_tendangnhap.Text = tenDangNhap;
            combox_quyenhan.SelectedIndex = 0;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string matKhau = tbox_matkhau.Text;
            string quyenhan = combox_quyenhan.Text;
            FormQuanLy_NguoiDung.Suanguoidung(tenDangNhap, matKhau, quyenhan);
            parentForm.CapnhatDataGridView();
            this.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
