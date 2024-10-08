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
    public partial class FormQuanLy_NhanVien_Sua : Form
    {
        private static FormQuanLy_NhanVien parentForm;
        private string maNV;
        public FormQuanLy_NhanVien_Sua(FormQuanLy_NhanVien form, string maNV)
        {
            InitializeComponent();
            parentForm = form;
            this.maNV = maNV;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string tenNV = tbox_tennv.Text;
            string sdt = tbox_sdt.Text;
            string namSinh = tbox_namsinh.Text;
            FormQuanLy_NhanVien.Suanhanvien(maNV, tenNV, sdt, namSinh);
            parentForm.CapnhatDataGridView();
            this.Close();
        }

        private void FormQuanLy_NhanVien_Sua_Load(object sender, EventArgs e)
        {
            tbox_manv.Text = maNV;
            tbox_sdt.TabStop = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
