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
    public partial class FormThongKe : Form
    {
        private static FormMenu parentForm;
        public FormThongKe(FormMenu form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet15.CTHD' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet14.HoaDon' table. You can move, or remove it, as needed.
            tbox_tonggiatri.Text=FormMenu.tonggiatri.ToString();
            CapnhatDataGridViewHD();
            CapnhatDataGridViewCTHD();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConString.connectionString);
            connection.Open();
            string query = @"
            SELECT NV.MaNV AS N'Mã nhân viên', TenNV AS N'Họ tên', COUNT(*) AS N'Số lần phục vụ'
            FROM NhanVien NV
            INNER JOIN Ban B ON NV.MaNV=B.MaNV
            INNER JOIN HoaDon HD ON B.MaBan=HD.MaBan
            GROUP BY NV.MaNV, TenNV
            ORDER BY N'Số lần phục vụ' DESC";

            // Thực thi truy vấn
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Hiển thị kết quả trên DataGridView
            dataGV_custom.DataSource = dataTable;
            dataGV_custom.Visible = true;

            // Đóng kết nối
            connection.Close();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConString.connectionString);
            connection.Open();
            string query = @"
            SELECT KH.MaKH AS N'Mã khách hàng', TenKH AS N'Họ tên', COUNT(*) AS N'Số lần ghé quán'
            FROM KhachHang KH
            INNER JOIN HoaDon HD ON KH.MaKH=HD.MaKH
            GROUP BY KH.MaKH, TenKH
            ORDER BY COUNT(*) DESC";

            // Thực thi truy vấn
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Hiển thị kết quả trên DataGridView
            dataGV_custom.DataSource = dataTable;
            dataGV_custom.Visible = true;


            // Đóng kết nối
            connection.Close();
        }

        public void CapnhatDataGridViewHD()
        {

            SqlConnection con = new SqlConnection(ConString.connectionString);

            string selectQuery = "SELECT * FROM HoaDon";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns["MaHD"].HeaderText = "Mã HĐ";
            dataGridView1.Columns["MaKH"].HeaderText = "Mã KH";
            dataGridView1.Columns["MaBan"].HeaderText = "Mã bàn";
            dataGridView1.Columns["NgayNhapDon"].HeaderText = "Ngày nhập đơn";


            dataGridView1.Columns["MaHD"].Width = 120;
            dataGridView1.Columns["MaKH"].Width = 120;
            dataGridView1.Columns["MaBan"].Width = 120;
            dataGridView1.Columns["NgayNhapDon"].Width = 138;
        }
        public void CapnhatDataGridViewCTHD()
        {

            SqlConnection con = new SqlConnection(ConString.connectionString);

            string selectQuery = "SELECT * FROM CTHD";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;

            dataGridView2.Columns["MaHD"].HeaderText = "Mã HĐ";
            dataGridView2.Columns["MaNuoc"].HeaderText = "Mã nước";
            dataGridView2.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridView2.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dataGridView2.Columns["TrangThai"].HeaderText = "Trạng thái";



            dataGridView2.Columns["MaHD"].Width = 80;
            dataGridView2.Columns["MaNuoc"].Width = 80;
            dataGridView2.Columns["SoLuong"].Width = 80;
            dataGridView2.Columns["ThanhTien"].Width = 120;
            dataGridView2.Columns["TrangThai"].Width = 138;

        }
    }
}
