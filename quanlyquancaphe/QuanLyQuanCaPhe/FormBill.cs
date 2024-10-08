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
    public partial class FormBill : Form
    {
        private static FormOrder parentForm;
        public FormBill(FormOrder form)
        {
            InitializeComponent();
            parentForm = form;
        }

       

        private void FormBill_Load(object sender, EventArgs e)
        {
            lbl_sohd.Text = "Số: " + FormOrder.soHDxuatbill;
            string maHD = FormOrder.soHDxuatbill; // Mã hóa đơn cần tìm
            DateTime ngayNhapDon = DateTime.MinValue; // Khởi tạo giá trị mặc định

            using (SqlConnection connection = new SqlConnection(ConString.connectionString))
            {
                connection.Open();

                string query = "SELECT NgayNhapDon FROM HoaDon WHERE MaHD = @MaHD";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHD", maHD);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ngayNhapDon = reader.GetDateTime(0);
                            // Sử dụng giá trị ngayNhapDon cho ngaynhapdonxuatbill hoặc thực hiện các xử lý khác
                        }
                    }
                }
            }

            lbl_ngay.Text = "Ngày: " + ngayNhapDon.ToString("dd/MM/yyyy");

            lbl_sohd.AutoSize = true;
            lbl_ngay.AutoSize = true;
            lbl_sohd.Location = new Point((this.ClientSize.Width - lbl_sohd.Width) / 2, lbl_sohd.Location.Y);
            lbl_ngay.Location = new Point((this.ClientSize.Width - lbl_ngay.Width) / 2, lbl_ngay.Location.Y);
            CapnhatDataGridView(FormOrder.soHDxuatbill);
            dataGV_bill.ReadOnly = true; // Ngăn chặn chỉnh sửa dữ liệu trên DataGridView
            dataGV_bill.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chỉ chọn toàn bộ hàng khi nhấp vào
            dataGV_bill.ClearSelection(); // Xóa chọn mục đang được chọn (nếu có)
        }

        public void CapnhatDataGridView(string maHD)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);

            string selectQuery = "SELECT TenNuoc, SoLuong, DonGia\r\nFROM Nuoc N INNER JOIN CTHD CT ON N.MaNuoc=CT.MaNuoc\r\n\t\t\tINNER JOIN HoaDon HD ON CT.MaHD=HD.MaHD\r\nWHERE HD.MaHD=@MaHD";

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
            adapter.SelectCommand.Parameters.AddWithValue("@MaHD", maHD);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGV_bill.DataSource = dataTable;

            dataGV_bill.Columns["TenNuoc"].HeaderText = "Tên";
            dataGV_bill.Columns["SoLuong"].HeaderText = "SL";
            dataGV_bill.Columns["DonGia"].HeaderText = "Đơn giá";

            dataGV_bill.Columns["TenNuoc"].Width = 134;
            dataGV_bill.Columns["SoLuong"].Width = 40;
            dataGV_bill.Columns["DonGia"].Width = 73;

            int tongCong = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                int donGia = Convert.ToInt32(row["DonGia"]);
                tongCong += donGia;
            }
            lbl_tongcong.Text = "Tổng cộng: " + tongCong.ToString() + " vnđ";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
