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
    public partial class FormQuanLy_NhanVien_Them : Form
    {
        private static FormQuanLy_NhanVien parentForm;
        public FormQuanLy_NhanVien_Them(FormQuanLy_NhanVien form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbox_manv.Text) || string.IsNullOrEmpty(tbox_tennv.Text) || string.IsNullOrEmpty(tbox_sdt.Text) || string.IsNullOrEmpty(tbox_namsinh.Text))
            {
                erPro_thieuthongtin.SetError(tbox_manv, "Phải điền đầy đủ thông tin");
            }
            else
            {
                string maNV = tbox_manv.Text;
                string tenNV = tbox_tennv.Text;
                string sdt = tbox_sdt.Text;
                string namSinh = tbox_namsinh.Text;

                FormQuanLy_NhanVien.Themnhanvien(maNV, tenNV, sdt, namSinh);
                parentForm.CapnhatDataGridView();
                this.Close();
            }
        }

        private void FormQuanLy_NhanVien_Them_Load(object sender, EventArgs e)
        {
            tbox_sdt.TabStop = false;
        }
    }
}
