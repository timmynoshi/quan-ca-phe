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
    public partial class FormQuanLy_NguoiDung : Form
    {
        public FormQuanLy_NguoiDung()
        {
            InitializeComponent();
        }

        private void FormQuanLy_NguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet.NguoiDung' table. You can move, or remove it, as needed.
            CapnhatDataGridView();
            dataGV_nguoidung.ClearSelection();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FormQuanLy_NguoiDung_Them f = new FormQuanLy_NguoiDung_Them(this);
            f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
            f.Location = new System.Drawing.Point(740, 420);

            f.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGV_nguoidung.SelectedRows.Count > 0)
            {
                string tenDangNhap = dataGV_nguoidung.SelectedRows[0].Cells[0].Value.ToString();
                FormQuanLy_NguoiDung_Sua f = new FormQuanLy_NguoiDung_Sua(this,tenDangNhap);
                f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
                f.Location = new System.Drawing.Point(740, 420);

                f.ShowDialog();
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string tenDangNhap = dataGV_nguoidung.SelectedRows[0].Cells[0].Value.ToString();
            Xoanguoidung(tenDangNhap);
            CapnhatDataGridView();
        }

        //===========================================
        public void CapnhatDataGridView()
        {

            SqlConnection con = new SqlConnection(ConString.connectionString);

            string selectQuery = "SELECT * FROM NguoiDung";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGV_nguoidung.DataSource = dataTable;
            //
            dataGV_nguoidung.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            dataGV_nguoidung.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            dataGV_nguoidung.Columns["QuyenHan"].HeaderText = "Quyền Hạn";

            dataGV_nguoidung.Columns["TenDangNhap"].Width = 177;
            dataGV_nguoidung.Columns["MatKhau"].Width = 100;
            dataGV_nguoidung.Columns["QuyenHan"].Width = 120;

        }

        public static void Themnguoidung(string tenDangNhap, string matKhau, string quyenhan)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Cập nhật cơ sở dữ liệu
            string insertQuery = "INSERT INTO NguoiDung VALUES (@TenDangNhap, @MatKhau, @QuyenHan)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@QuyenHan", quyenhan);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public static void Suanguoidung(string tenDangNhap, string matKhau, string quyenhan)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Cập nhật cơ sở dữ liệu
            string updateQuery = "UPDATE NguoiDung SET MatKhau = @MatKhau, QuyenHan = @QuyenHan WHERE TenDangNhap = @TenDangNhap";
            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
            {
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@QuyenHan", quyenhan);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public static void Xoanguoidung(string tenDangNhap)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Xóa khỏi cơ sở dữ liệu
            string deleteQuery = "DELETE FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
            using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
            {
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }


    
    }
}
