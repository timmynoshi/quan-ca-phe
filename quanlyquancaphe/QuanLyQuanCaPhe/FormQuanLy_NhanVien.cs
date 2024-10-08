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
    public partial class FormQuanLy_NhanVien : Form
    {
        public FormQuanLy_NhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLy_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet1.NhanVien' table. You can move, or remove it, as needed.
            CapnhatDataGridView();
            dataGV_nhanvien.ClearSelection();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FormQuanLy_NhanVien_Them f = new FormQuanLy_NhanVien_Them(this);
            f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
            f.Location = new System.Drawing.Point(740, 420);

            f.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGV_nhanvien.SelectedRows.Count > 0)
            {
                string maNV = dataGV_nhanvien.SelectedRows[0].Cells[0].Value.ToString();
                FormQuanLy_NhanVien_Sua f = new FormQuanLy_NhanVien_Sua(this, maNV);
                f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
                f.Location = new System.Drawing.Point(740, 420);

                f.ShowDialog();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maNV = dataGV_nhanvien.SelectedRows[0].Cells[0].Value.ToString();
            Xoanhanvien(maNV);
            CapnhatDataGridView();
        }

        //============
        public void CapnhatDataGridView()
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);

            string selectQuery = "SELECT * FROM NhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGV_nhanvien.DataSource = dataTable;

            dataGV_nhanvien.Columns["MaNV"].HeaderText = "Mã NV";
            dataGV_nhanvien.Columns["TenNV"].HeaderText = "Họ tên";
            dataGV_nhanvien.Columns["SoDienThoaiNV"].HeaderText = "SĐT";
            dataGV_nhanvien.Columns["NamSinh"].HeaderText = "Năm sinh";

            dataGV_nhanvien.Columns["MaNV"].Width = 80;
            dataGV_nhanvien.Columns["TenNV"].Width = 180;
            dataGV_nhanvien.Columns["SoDienThoaiNV"].Width = 100;
            dataGV_nhanvien.Columns["NamSinh"].Width = 100;
        }

        public static void Themnhanvien(string maNV, string tenNV, string sdt, string namSinh)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Cập nhật cơ sở dữ liệu
            string insertQuery = "INSERT INTO NhanVien VALUES (@MaNV, @TenNV, @SDT, @NamSinh)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@TenNV", tenNV);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@NamSinh", namSinh);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        public static void Suanhanvien(string maNV, string tenNV, string sdt, string namSinh)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Cập nhật cơ sở dữ liệu
            string updateQuery = "UPDATE NhanVien SET TenNV = @TenNV, SoDienThoaiNV = @SDT, NamSinh = @NamSinh WHERE MaNV = @MaNV";
            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@TenNV", tenNV);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@NamSinh", namSinh);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public static void Xoanhanvien(string maNV)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Xóa khỏi cơ sở dữ liệu
            string deleteQuery = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        
    }
}
