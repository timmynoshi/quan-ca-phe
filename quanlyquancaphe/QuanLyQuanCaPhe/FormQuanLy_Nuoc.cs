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
    public partial class FormQuanLy_Nuoc : Form
    {
        public FormQuanLy_Nuoc()
        {
            InitializeComponent();
        }

        private void FormQuanLy_Nuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet5.Nuoc' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet4.Nuoc' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet3.Nuoc' table. You can move, or remove it, as needed.
            CapnhatDataGridView();
            dataGV_nuoc.ClearSelection();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FormQuanLy_Nuoc_Them f = new FormQuanLy_Nuoc_Them(this);
            f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
            f.Location = new System.Drawing.Point(740, 420);

            f.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGV_nuoc.SelectedRows.Count > 0)
            {
                string maNuoc = dataGV_nuoc.SelectedRows[0].Cells[0].Value.ToString();
                FormQuanLy_Nuoc_Sua f = new FormQuanLy_Nuoc_Sua(this, maNuoc);
                f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
                f.Location = new System.Drawing.Point(740, 420);

                f.ShowDialog();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maNuoc = dataGV_nuoc.SelectedRows[0].Cells[0].Value.ToString();
            Xoanuoc(maNuoc);
            CapnhatDataGridView();
        }

        //=================================
        public void CapnhatDataGridView()
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);

            string selectQuery = "SELECT * FROM Nuoc";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGV_nuoc.DataSource = dataTable;

            dataGV_nuoc.Columns["MaNuoc"].HeaderText = "Mã";
            dataGV_nuoc.Columns["TenNuoc"].HeaderText = "Tên";
            dataGV_nuoc.Columns["DonGia"].HeaderText = "Đơn giá";

            dataGV_nuoc.Columns["MaNuoc"].Width = 80;
            dataGV_nuoc.Columns["TenNuoc"].Width = 180;
            dataGV_nuoc.Columns["DonGia"].Width = 123;
        }

        public static void Themnuoc(string maNuoc, string tenNuoc, string donGia)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Cập nhật cơ sở dữ liệu
            string insertQuery = "INSERT INTO Nuoc VALUES (@MaNuoc, @TenNuoc, @DonGia)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaNuoc", maNuoc);
                cmd.Parameters.AddWithValue("@TenNuoc", tenNuoc);
                cmd.Parameters.AddWithValue("@DonGia", donGia);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        public static void Suanuoc(string maNuoc, string tenNuoc, string donGia)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Cập nhật cơ sở dữ liệu
            string updateQuery = "UPDATE Nuoc SET TenNuoc = @TenNuoc, DonGia = @DonGia WHERE MaNuoc = @MaNuoc";
            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaNuoc", maNuoc);
                cmd.Parameters.AddWithValue("@TenNuoc", tenNuoc);
                cmd.Parameters.AddWithValue("@DonGia", donGia);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public static void Xoanuoc(string maNuoc)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Xóa khỏi cơ sở dữ liệu
            string deleteQuery = "DELETE FROM Nuoc WHERE MaNuoc = @MaNuoc";
            using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaNuoc", maNuoc);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        
    }
}
