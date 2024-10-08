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
    public partial class FormQuanLy_Nuoc_Sua : Form
    {
        private static FormQuanLy_Nuoc parentForm;
        private string maNuoc;
        public FormQuanLy_Nuoc_Sua(FormQuanLy_Nuoc form, string maNuoc)
        {
            InitializeComponent();
            this.maNuoc = maNuoc;
            parentForm = form;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string tenNuoc = tbox_tennuoc.Text;
            string donGia = tbox_dongia.Text;
            FormQuanLy_Nuoc.Suanuoc(maNuoc, tenNuoc, donGia);
            parentForm.CapnhatDataGridView();
            this.Close();
        }

        private void FormQuanLy_Nuoc_Sua_Load(object sender, EventArgs e)
        {
            tbox_manuoc.Text = maNuoc;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
