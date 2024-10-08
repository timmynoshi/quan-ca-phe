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
    public partial class FormQuanLy_Ban : Form
    {
        public FormQuanLy_Ban()
        {
            InitializeComponent();
        }

        private void FormQuanLy_Ban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet2.Ban' table. You can move, or remove it, as needed.
            CapnhatDataGridView();
            dataGV_ban.ClearSelection();
        }



        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGV_ban.SelectedRows.Count > 0)
            {
                string maBan = dataGV_ban.SelectedRows[0].Cells[0].Value.ToString();
                FormQuanLy_Ban_Sua f = new FormQuanLy_Ban_Sua(this, maBan);
                f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
                f.Location = new System.Drawing.Point(740, 420);

                f.ShowDialog();
            }
        }



        //======
        public void CapnhatDataGridView()
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);

            string selectQuery = "SELECT * FROM Ban";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGV_ban.DataSource = dataTable;

            dataGV_ban.Columns["MaBan"].HeaderText = "Mã bàn";
            dataGV_ban.Columns["SoCho"].HeaderText = "SL chỗ";
            dataGV_ban.Columns["MaNV"].HeaderText = "Nhân viên phụ trách";

            dataGV_ban.Columns["MaBan"].Width = 100;
            dataGV_ban.Columns["SoCho"].Width = 100;
            dataGV_ban.Columns["MaNV"].Width = 202;
        }

        public static void Themban(string maBan, string soCho, string maNV)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Cập nhật cơ sở dữ liệu
            string insertQuery = "INSERT INTO Ban VALUES (@MaBan, @SoCho, @MaNV)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaBan", maBan);
                cmd.Parameters.AddWithValue("@SoCho", soCho);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        public static void Suaban(string maBan, string soCho, string maNV)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Cập nhật cơ sở dữ liệu
            string updateQuery = "UPDATE Ban SET SoCho = @SoCho, MaNV = @MaNV WHERE MaBan = @MaBan";
            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaBan", maBan);
                cmd.Parameters.AddWithValue("@SoCho", soCho);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public static void Xoaban(string maBan)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Xóa khỏi cơ sở dữ liệu
            string deleteQuery = "DELETE FROM Ban WHERE MaBan = @MaBan";
            using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaBan", maBan);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void dataGV_ban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
