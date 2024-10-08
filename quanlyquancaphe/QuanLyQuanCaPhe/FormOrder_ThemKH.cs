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
    public partial class FormOrder_ThemKH : Form
    {
        private static FormOrder parentForm;
        public FormOrder_ThemKH(FormOrder form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void FormOrder_ThemKH_Load(object sender, EventArgs e)
        {
            tbox_sdt.TabStop = false;
            tbox_tenkh.TabStop = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbox_makh.Text) || string.IsNullOrEmpty(tbox_tenkh.Text))
            {
                erPro_thieuthongtin.SetError(tbox_makh, "Phải điền đầy đủ thông tin (SĐT có thể trống)");
            }
            else
            {
                string maKH = tbox_makh.Text;
                string tenKH = tbox_tenkh.Text;
                string sdt = tbox_sdt.Text;
                FormOrder.Themkhachhang(maKH, tenKH, sdt);
                parentForm.CapnhatDataGridViewKH();
                this.Close();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
