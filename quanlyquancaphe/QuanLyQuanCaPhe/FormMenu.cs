using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyQuanCaPhe
{
    public partial class FormMenu : Form
    {
        public List<Ban> bans = new List<Ban>();
        public static int conTro = -1;
        public static int soHD = 1;
        public static int tonggiatri = 0;
        public FormMenu()
        {
            InitializeComponent();
        }

        public static void CapNhatTongGiaTri()
        {
            string query = "SELECT SUM(ThanhTien) AS TongGiaTri FROM CTHD";

            using (SqlConnection connection = new SqlConnection(ConString.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        FormMenu.tonggiatri = Convert.ToInt32(result);
                    }
                    else
                    {
                        FormMenu.tonggiatri = 0;
                    }
                }
            }
        }
        private void CloseAllChildForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form childForm in openForms)
            {
                if (childForm != this) // Kiểm tra nếu form con khác form cha
                {
                    childForm.Close(); // Đóng form con
                }
            }
            panel_quanly.Visible = false;

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
            if (Role.IsQuanTri)
            {
                pictureBox2.Visible = true;
                btn_dangnhap.Visible = false;
                btn_dangxuat.Visible = true;
                btn_quanly.Enabled = true;
                btn_quanly.Visible = true;
                btn_order.Visible = true;
                btn_thongke.Visible = true;

            }
            else
            {
                if (Role.IsNhanVien)
                {
                    pictureBox2.Visible = true;
                    btn_dangnhap.Visible = false;
                    btn_dangxuat.Visible = true;
                    btn_quanly.Visible = true;
                    btn_quanly.Enabled = false;
                    btn_order.Visible = true;
                    btn_thongke.Visible = true;
                }
                else
                {
                    pictureBox2.Visible = false;
                    btn_quanly.Visible=false;
                    btn_order.Visible=false;
                    btn_thongke.Visible=false;
                    btn_dangnhap.Visible = true;
                    btn_dangxuat.Visible = false;
                }
            }
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            Role.IsNhanVien = false;
            Role.IsQuanTri = false;
            btn_dangnhap.Visible = true;
            btn_dangxuat.Visible = false;
            CloseAllChildForms();
            pictureBox2.Visible = false;
            btn_quanly.Visible = false;
            btn_order.Visible = false;
            btn_thongke.Visible = false;
            btn_dangnhap.Visible = true;
            btn_dangxuat.Visible = false;
            panel_order.Visible = false;
            panel_quanly.Visible = false;
            gbox_quanly.Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToString();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            btn_dangnhap.TabStop = false;
            btn_dangxuat.TabStop = false;
            btn_thongke.TabStop = false;
            btn_thoat.TabStop = false;
            btn_order.TabStop = false;
            btn_quanly.TabStop = false;
            panel_order.Visible = false;
            panel_quanly.Visible = false;
            for (int i = 0;i<=10;i++)
            {
                Ban ban = new Ban
                {
                    MaKH = null,
                    TrangThai = false
                };
                bans.Add(ban);
            }
            CapNhatTongGiaTri();
            lbl_timer.Text = DateTime.Now.ToString();
            Timer timer = new Timer();
            timer.Interval = 1000; // Đặt khoảng thời gian là 1 giây (1000 milliseconds)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void btn_quanly_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();



            panel_order.Visible = false;
            panel_quanly.Visible = false;

            gbox_quanly.Visible = true; // Mở groupBox1 nếu đang ẩn
        }

        private void btn_quanly_nguoidung_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            panel_quanly.Visible = true;
            FormQuanLy_NguoiDung f = new FormQuanLy_NguoiDung();
            f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
            f.Location = new System.Drawing.Point(697, 145);
            f.Show(this);
        }

        private void btn_quanly_nhanvien_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            panel_quanly.Visible = true;
            FormQuanLy_NhanVien f = new FormQuanLy_NhanVien();
            f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
            f.Location = new System.Drawing.Point(697, 145);
            f.Show(this);
        }

        private void btn_quanly_ban_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            panel_quanly.Visible = true;
            FormQuanLy_Ban f = new FormQuanLy_Ban();
            f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
            f.Location = new System.Drawing.Point(697, 145);
            f.Show(this);
        }

        private void btn_quanly_thucuong_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            panel_quanly.Visible = true;
            FormQuanLy_Nuoc f = new FormQuanLy_Nuoc();
            f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
            f.Location = new System.Drawing.Point(697, 145);
            f.Show(this);
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
          
            gbox_quanly.Visible = false;
            panel_order.Visible = false;

            FormOrder f = new FormOrder(this);
            f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
            f.Location = new System.Drawing.Point(366, 145);
            f.Show(this);
            gbox_quanly.Visible = false;
            panel_order.Visible = true;

        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();

            gbox_quanly.Visible = false;
            panel_order.Visible = false;

            FormThongKe f = new FormThongKe(this);
            f.StartPosition = FormStartPosition.Manual; // Đặt chế độ bắt đầu ở tọa độ bất kỳ
            f.Location = new System.Drawing.Point(366, 145);
            f.Show(this);
            gbox_quanly.Visible = false;
            panel_order.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
