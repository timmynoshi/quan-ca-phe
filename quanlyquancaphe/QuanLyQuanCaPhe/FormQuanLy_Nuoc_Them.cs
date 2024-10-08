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
    public partial class FormQuanLy_Nuoc_Them : Form
    {
        private static FormQuanLy_Nuoc parentForm;
        public FormQuanLy_Nuoc_Them(FormQuanLy_Nuoc form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbox_manuoc.Text) || string.IsNullOrEmpty(tbox_tennuoc.Text))
            {
                erPro_thieuthongtin.SetError(tbox_manuoc, "Phải điền đầy đủ thông tin");
            }
            else
            {
                string maNuoc = tbox_manuoc.Text;
                string tenNuoc = tbox_tennuoc.Text;
                string donGia = tbox_dongia.Text;
                FormQuanLy_Nuoc.Themnuoc(maNuoc, tenNuoc, donGia);
                parentForm.CapnhatDataGridView();
                this.Close();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
