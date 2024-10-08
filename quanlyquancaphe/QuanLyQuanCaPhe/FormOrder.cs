using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class FormOrder : Form
    {
        public static string soHDxuatbill;
        private static FormMenu parentForm;
        public FormOrder(FormMenu form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet12.CTHD' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet11.HoaDon' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet11.CTHD' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet10.HoaDon' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet9.CTHD' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyQuanCaPheDataSet6.KhachHang' table. You can move, or remove it, as needed.
            //=========
            using (SqlConnection connection = new SqlConnection(ConString.connectionString))
            {
                connection.Open();

                // Truy vấn các mã nhân viên từ table "NhanVien"
                string query = "SELECT TenNuoc FROM Nuoc";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Tạo DataTable để lưu trữ dữ liệu
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // Cung cấp dữ liệu cho ComboBox
                combox_thucuong.DisplayMember = "TenNuoc"; // Hiển thị giá trị của cột "MaNhanVien"
                combox_thucuong.ValueMember = "TenNuoc"; // Giá trị tương ứng là giá trị của cột "MaNhanVien"
                combox_thucuong.DataSource = dataTable;
                numUD_soluong.Value = 1;
                reader.Close();
                
            }




            for (int i=0; i<=9; i++)
            {
                if (parentForm.bans[i].TrangThai)
                {
                    string ban_temp = "btn_ban" + (i+1).ToString();
                    foreach (Control control in panel_ban.Controls)
                    {
                        if (control is Button button && button.Name == ban_temp)
                        {
                            button.BackColor = Color.SandyBrown;
                            break; 
                        }
                    }
                }    
            }

            CapnhatDataGridViewKH();
            CapnhatDataGridViewHD();
            CapnhatDataGridViewCTHD();
            dataGV_khachhang.ClearSelection();
            dataGV_khachhang.Rows[0].Selected = true;

            //=========


        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            FormOrder_ThemKH f = new FormOrder_ThemKH(this);
            f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
            f.Location = new System.Drawing.Point(1000, 460);
            f.ShowDialog(this);
        }

        // ====================================================
        public void CapnhatDataGridViewKH()
        {

            SqlConnection con = new SqlConnection(ConString.connectionString);

            string selectQuery = "SELECT * FROM KhachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGV_khachhang.DataSource = dataTable;

            dataGV_khachhang.Columns["MaKH"].HeaderText = "Mã KH";
            dataGV_khachhang.Columns["TenKH"].HeaderText = "Họ tên";
            dataGV_khachhang.Columns["SoDienThoaiKH"].HeaderText = "SĐT";

            dataGV_khachhang.Columns["MaKH"].Width = 80;
            dataGV_khachhang.Columns["TenKH"].Width = 180;
            dataGV_khachhang.Columns["SoDienThoaiKH"].Width = 120;
        }
        public void CapnhatDataGridViewHD()
        {

            SqlConnection con = new SqlConnection(ConString.connectionString);

            string selectQuery = "SELECT * FROM HoaDon";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGV_hoadon.DataSource = dataTable;

            dataGV_hoadon.Columns["MaHD"].HeaderText = "Mã HĐ";
            dataGV_hoadon.Columns["MaKH"].HeaderText = "Mã KH";
            dataGV_hoadon.Columns["MaBan"].HeaderText = "Mã bàn";
            dataGV_hoadon.Columns["NgayNhapDon"].HeaderText = "Ngày nhập đơn";


            dataGV_hoadon.Columns["MaHD"].Width = 80;
            dataGV_hoadon.Columns["MaKH"].Width = 80;
            dataGV_hoadon.Columns["MaBan"].Width = 80;
            dataGV_hoadon.Columns["NgayNhapDon"].Width = 120;
        }
        public void CapnhatDataGridViewCTHD()
        {

            SqlConnection con = new SqlConnection(ConString.connectionString);

            string selectQuery = "SELECT * FROM CTHD";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGV_cthd.DataSource = dataTable;

            dataGV_cthd.Columns["MaHD"].HeaderText = "Mã HĐ";
            dataGV_cthd.Columns["MaNuoc"].HeaderText = "Mã nước";
            dataGV_cthd.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGV_cthd.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dataGV_cthd.Columns["TrangThai"].HeaderText = "Trạng thái";



            dataGV_cthd.Columns["MaHD"].Width = 80;
            dataGV_cthd.Columns["MaNuoc"].Width = 80;
            dataGV_cthd.Columns["SoLuong"].Width = 80;
            dataGV_cthd.Columns["ThanhTien"].Width = 120;
            dataGV_cthd.Columns["TrangThai"].Width = 160;

        }
        public static void Themkhachhang(string maKH, string tenKH, string sdt)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Cập nhật cơ sở dữ liệu
            string insertQuery = "INSERT INTO KhachHang VALUES (@MaKH, @TenKH, @SDT)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@TenKH", tenKH);
                cmd.Parameters.AddWithValue("@SDT", sdt);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public static void Xoakhachhang(string maKH)
        {
            SqlConnection con = new SqlConnection(ConString.connectionString);
            con.Open();

            // Xóa khỏi cơ sở dữ liệu
            string deleteQuery = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void btn_xoakh_Click(object sender, EventArgs e)
        {
            string maKH = dataGV_khachhang.SelectedRows[0].Cells[0].Value.ToString();
            Xoakhachhang(maKH);
            CapnhatDataGridViewKH();
        }


        private void btn_datban_Click(object sender, EventArgs e)
        {
            

                SqlConnection connection = new SqlConnection(ConString.connectionString);
                connection.Open();
                parentForm.bans[FormMenu.conTro].MaHD = "HD" + FormMenu.soHD.ToString();
                string checkQuery = "SELECT COUNT(*) FROM HoaDon WHERE MaHD = @MaHD";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@MaHD", parentForm.bans[FormMenu.conTro].MaHD);
                int count;
                do
                {
                    // Kiểm tra MaHD
                    checkCommand.Parameters["@MaHD"].Value = parentForm.bans[FormMenu.conTro].MaHD;
                    count = (int)checkCommand.ExecuteScalar();

                    if (count == 0)
                    {
                        parentForm.bans[FormMenu.conTro].TrangThai = true;

                        string maHD = parentForm.bans[FormMenu.conTro].MaHD;
                        string maKH = dataGV_khachhang.SelectedRows[0].Cells[0].Value.ToString();
                        string maBan = "B" + (FormMenu.conTro + 1).ToString();
                        DateTime ngayNhapDon = DateTime.Now;
                        string query = "INSERT INTO HoaDon (MaHD, MaKH, MaBan, NgayNhapDon) VALUES (@MaHD, @MaKH, @MaBan, @NgayNhapDon)";

                        // Tạo đối tượng Connection
                        using (SqlConnection connection1 = new SqlConnection(ConString.connectionString))
                        {
                            // Mở kết nối
                            connection1.Open();

                            // Tạo đối tượng Command
                            using (SqlCommand command = new SqlCommand(query, connection1))
                            {
                                // Thêm các tham số và gán giá trị
                                command.Parameters.AddWithValue("@MaHD", maHD);
                                command.Parameters.AddWithValue("@MaKH", maKH);
                                command.Parameters.AddWithValue("@MaBan", maBan);
                                command.Parameters.AddWithValue("@NgayNhapDon", ngayNhapDon);

                                // Thực thi câu lệnh INSERT INTO
                                command.ExecuteNonQuery();

                                // Thêm dữ liệu thành công
                            }
                            CapnhatDataGridViewHD();
                            FormMenu.soHD++;
                            string ban_temp = "btn_ban" + (FormMenu.conTro + 1).ToString();
                            foreach (Control control in panel_ban.Controls)
                            {
                                if (control is Button button && button.Name == ban_temp)
                                {
                                    button.BackColor = Color.SandyBrown;
                                    break; // Tìm thấy Button cần thay đổi, thoát khỏi vòng lặp
                                }
                            }
                            connection1.Close();
                        }
                        btn_themmon.Enabled = true;
                        btn_datban.Enabled = false;
                        break;
                    }

                    // Tăng biến soHD lên
                    FormMenu.soHD++;

                    // Cập nhật MaHD mới
                    parentForm.bans[FormMenu.conTro].MaHD = "HD" + FormMenu.soHD.ToString();
                }
                while (true);
                connection.Close();
            
    
        }


        private void btn_themmon_Click(object sender, EventArgs e)
        {
            string maHD = parentForm.bans[FormMenu.conTro].MaHD;
            string tenNuoc = combox_thucuong.Text;
            string maNuoc = null;
            string donGia = null;
            string query = "SELECT MaNuoc FROM Nuoc WHERE TenNuoc = @TenNuoc";
            string query2 = "SELECT DonGia FROM Nuoc WHERE TenNuoc = @TenNuoc";
            // Tạo đối tượng Connection
            using (SqlConnection connection = new SqlConnection(ConString.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenNuoc", tenNuoc);
                    maNuoc = (string)command.ExecuteScalar();

                }
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("@TenNuoc", tenNuoc);
                    donGia = command.ExecuteScalar().ToString();
                }
            }
            int donGia_int = Convert.ToInt32(donGia);
            string soLuong = numUD_soluong.Value.ToString();
            string thanhTien = (numUD_soluong.Value*donGia_int).ToString();
            string trangThai = "Chưa thanh toán";

            string query3 = "INSERT INTO CTHD (MaHD, MaNuoc, SoLuong, ThanhTien, TrangThai) VALUES (@MaHD, @MaNuoc, @SoLuong, @ThanhTien, @TrangThai)";
            using (SqlConnection connection = new SqlConnection(ConString.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query3, connection))
                {
                    command.Parameters.AddWithValue("@MaHD", maHD);
                    command.Parameters.AddWithValue("@MaNuoc", maNuoc);
                    command.Parameters.AddWithValue("@Soluong", soLuong);
                    command.Parameters.AddWithValue("@ThanhTien", thanhTien);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);
                    command.ExecuteNonQuery();
                }
            }
            CapnhatDataGridViewCTHD();
            btn_thanhtoan.Enabled = true;
            
        }
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            string maHD = parentForm.bans[FormMenu.conTro].MaHD;
            soHDxuatbill = parentForm.bans[FormMenu.conTro].MaHD;
            string query = "SELECT ThanhTien FROM CTHD WHERE MaHD = @MaHD";
            string query2 = "UPDATE CTHD SET TrangThai = @TrangThai WHERE MaHD = @MaHD";
            using (SqlConnection connection = new SqlConnection(ConString.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHD", maHD); // maHD là mã hóa đơn cần tính tổng thành tiền
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int thanhTien = Convert.ToInt32(reader["ThanhTien"]);
                        FormMenu.tonggiatri += thanhTien;
                    }

                    reader.Close();
                }

                using (SqlCommand updateCommand = new SqlCommand(query2, connection))
                {

                    updateCommand.Parameters.AddWithValue("@TrangThai", "Đã thanh toán");
                    updateCommand.Parameters.AddWithValue("@MaHD", maHD); // maHD là mã hóa đơn cần cập nhật trạng thái

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                }
            }
            parentForm.bans[FormMenu.conTro].TrangThai = false;
            parentForm.bans[FormMenu.conTro].MaHD = null;

            CapnhatDataGridViewCTHD();
            string ban_temp = "btn_ban" + (FormMenu.conTro + 1).ToString();
            foreach (Control control in panel_ban.Controls)
            {
                if (control is Button button && button.Name == ban_temp)
                {
                    button.BackColor = Color.LightGreen;
                    break; // Tìm thấy Button cần thay đổi, thoát khỏi vòng lặp
                }
            }
            btn_themmon.Enabled = false;
            btn_thanhtoan.Enabled = false;
            FormMenu.CapNhatTongGiaTri();
            if(cbox_xuatbill.Checked)
            {
                FormBill f = new FormBill(this);
                f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
                f.Location = new System.Drawing.Point(1010, 240);
                f.ShowDialog(this);
            } 
            cbox_xuatbill.Checked = false;

        }

        private void btn_ban1_Click(object sender, EventArgs e)
        {
            FormMenu.conTro = 0;
            if (parentForm.bans[FormMenu.conTro].TrangThai == false)
            {
                btn_datban.Enabled = true;
                btn_thanhtoan.Enabled = false;
                btn_themmon.Enabled = false;
                btn_ban1.BackColor = Color.LightGreen;
            }
            else
            {
                btn_datban.Enabled = false;
                btn_themmon.Enabled = true;
                btn_thanhtoan.Enabled = true;
                btn_ban1.BackColor = Color.SandyBrown;
            }
        }

        private void btn_ban2_Click(object sender, EventArgs e)
        {
            FormMenu.conTro = 1;
            if (parentForm.bans[FormMenu.conTro].TrangThai == false)
            {
                btn_datban.Enabled = true;
                btn_thanhtoan.Enabled = false;
                btn_themmon.Enabled = false;
                btn_ban2.BackColor = Color.LightGreen;
            }
            else
            {
                btn_datban.Enabled = false;
                btn_thanhtoan.Enabled = true;
                btn_themmon.Enabled = true;

                btn_ban2.BackColor = Color.SandyBrown;
            }
        }

        private void btn_ban3_Click(object sender, EventArgs e)
        {
            FormMenu.conTro = 2;
            if (parentForm.bans[FormMenu.conTro].TrangThai == false)
            {
                btn_datban.Enabled = true;
                btn_thanhtoan.Enabled = false;
                btn_themmon.Enabled = false;
                btn_ban3.BackColor = Color.LightGreen;
            }
            else
            {
                btn_datban.Enabled = false;
                btn_thanhtoan.Enabled = true;
                btn_themmon.Enabled = true;

                btn_ban3.BackColor = Color.SandyBrown;
            }
        }

        private void btn_ban4_Click(object sender, EventArgs e)
        {
            FormMenu.conTro = 3;
            if (parentForm.bans[FormMenu.conTro].TrangThai == false)
            {
                btn_datban.Enabled = true;
                btn_thanhtoan.Enabled = false;
                btn_themmon.Enabled = false;
                btn_ban4.BackColor = Color.LightGreen;
            }
            else
            {
                btn_datban.Enabled = false;
                btn_thanhtoan.Enabled = true;
                btn_themmon.Enabled = true;

                btn_ban4.BackColor = Color.SandyBrown;
            }
        }

        private void btn_ban5_Click(object sender, EventArgs e)
        {
            FormMenu.conTro = 4;
            if (parentForm.bans[FormMenu.conTro].TrangThai == false)
            {
                btn_datban.Enabled = true;
                btn_thanhtoan.Enabled = false;
                btn_themmon.Enabled = false;
                btn_ban5.BackColor = Color.LightGreen;
            }
            else
            {
                btn_datban.Enabled = false;
                btn_thanhtoan.Enabled = true;
                btn_themmon.Enabled = true;

                btn_ban5.BackColor = Color.SandyBrown;
            }
        }

        private void btn_ban6_Click(object sender, EventArgs e)
        {
            FormMenu.conTro = 5;
            if (parentForm.bans[FormMenu.conTro].TrangThai == false)
            {
                btn_datban.Enabled = true;
                btn_thanhtoan.Enabled = false;
                btn_themmon.Enabled = false;
                btn_ban6.BackColor = Color.LightGreen;
            }
            else
            {
                btn_datban.Enabled = false;
                btn_thanhtoan.Enabled = true;
                btn_themmon.Enabled = true;

                btn_ban6.BackColor = Color.SandyBrown;
            }
        }

        private void btn_ban7_Click(object sender, EventArgs e)
        {
            FormMenu.conTro = 6;
            if (parentForm.bans[FormMenu.conTro].TrangThai == false)
            {
                btn_datban.Enabled = true;
                btn_thanhtoan.Enabled = false;
                btn_themmon.Enabled = false;
                btn_ban7.BackColor = Color.LightGreen;
            }
            else
            {
                btn_datban.Enabled = false;
                btn_thanhtoan.Enabled = true;
                btn_themmon.Enabled = true;

                btn_ban7.BackColor = Color.SandyBrown;
            }
        }

        private void btn_ban8_Click(object sender, EventArgs e)
        {
            FormMenu.conTro = 7;
            if (parentForm.bans[FormMenu.conTro].TrangThai == false)
            {
                btn_datban.Enabled = true;
                btn_thanhtoan.Enabled = false;
                btn_themmon.Enabled = false;
                btn_ban8.BackColor = Color.LightGreen;
            }
            else
            {
                btn_datban.Enabled = false;
                btn_thanhtoan.Enabled = true;
                btn_themmon.Enabled = true;

                btn_ban8.BackColor = Color.SandyBrown;
            }
        }

        private void btn_ban9_Click(object sender, EventArgs e)
        {
            FormMenu.conTro = 8;
            if (parentForm.bans[FormMenu.conTro].TrangThai == false)
            {
                btn_datban.Enabled = true;
                btn_thanhtoan.Enabled = false;
                btn_themmon.Enabled = false;
                btn_ban9.BackColor = Color.LightGreen;
            }
            else
            {
                btn_datban.Enabled = false;
                btn_thanhtoan.Enabled = true;
                btn_themmon.Enabled = true;

                btn_ban9.BackColor = Color.SandyBrown;
            }
        }

        private void btn_ban10_Click(object sender, EventArgs e)
        {
            FormMenu.conTro = 9;
            if (parentForm.bans[FormMenu.conTro].TrangThai == false)
            {
                btn_datban.Enabled = true;
                btn_thanhtoan.Enabled = false;
                btn_themmon.Enabled = false;
                btn_ban10.BackColor = Color.LightGreen;
            }
            else
            {
                btn_datban.Enabled = false;
                btn_thanhtoan.Enabled = true;
                btn_themmon.Enabled = true;

                btn_ban10.BackColor = Color.SandyBrown;
            }
        }

        
    }
}
