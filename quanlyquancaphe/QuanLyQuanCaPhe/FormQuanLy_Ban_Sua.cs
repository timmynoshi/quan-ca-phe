using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class FormQuanLy_Ban_Sua : Form
    {
        private static FormQuanLy_Ban parentForm;
        private string maBan;
        public FormQuanLy_Ban_Sua(FormQuanLy_Ban form, string maBan)
        {
            InitializeComponent();
            parentForm = form;
            this.maBan = maBan;
        }

        private void FormQuanLy_Ban_Sua_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-QVVRD1SB;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True"))
            {
                connection.Open();

                // Truy vấn các mã nhân viên từ table "NhanVien"
                string query = "SELECT MaNV FROM NhanVien";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Tạo DataTable để lưu trữ dữ liệu
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // Cung cấp dữ liệu cho ComboBox
                combox_manv.DisplayMember = "MaNV"; // Hiển thị giá trị của cột "MaNhanVien"
                combox_manv.ValueMember = "MaNV"; // Giá trị tương ứng là giá trị của cột "MaNhanVien"
                combox_manv.DataSource = dataTable;

                reader.Close();
            }
            tbox_maban.Text = maBan;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string soCho = numUD_socho.Value.ToString();
            string maNV = combox_manv.Text;
            FormQuanLy_Ban.Suaban(maBan, soCho, maNV);
            parentForm.CapnhatDataGridView();
            this.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
