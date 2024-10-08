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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        string connectionString = ConString.connectionString;
        

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string tenDangNhap = tbox_tendangnhap.Text;
            string matKhau = tbox_matkhau.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn SQL để kiểm tra thông tin đăng nhập
                string query = "SELECT QuyenHan FROM NguoiDung WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    // Thực hiện truy vấn và lấy giá trị quyền hạn từ cơ sở dữ liệu
                    object roleObject = command.ExecuteScalar();

                    if (roleObject != null)
                    {
                        string role = roleObject.ToString();

                        // Hiển thị thông báo đăng nhập thành công và lưu giữ quyền hạn
                        if (role == "QuanTri")
                        {
                            Role.IsQuanTri = true;
                            Role.IsNhanVien = false;
                        }
                        else
                        {
                            if (role == "NhanVien")
                            {
                                Role.IsNhanVien = true;
                                Role.IsQuanTri = false;
                            }
                        }
                        // Đóng form đăng nhập
                        this.Close();
                    }
                    else
                    {
                        erPro_saitkmk.SetError(tbox_tendangnhap, "Sai tên đăng nhập hoặc mật khẩu");
                        erPro_saitkmk.SetIconPadding(tbox_tendangnhap, 10);
                    }
                }
            }
        }

        private void tbox_tendangnhap_TextChanged(object sender, EventArgs e)
        {
            erPro_saitkmk.Clear();
        }

        private void tbox_matkhau_TextChanged(object sender, EventArgs e)
        {
            erPro_saitkmk.Clear();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void cbox_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_hienthi.Checked)
                tbox_matkhau.PasswordChar = '\0';
            else
                tbox_matkhau.PasswordChar = '*';
        }
    }
}
