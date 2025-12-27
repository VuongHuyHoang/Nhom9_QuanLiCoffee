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
using System.Data.SqlClient;

namespace BaiTapLon_Nhom9_QuanLiCofffee
{
    public partial class Login: Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-QUBRA9KU\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;TrustServerCertificate=True";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtTenDangNhap.Text.Trim();
            string mk = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(str))
            {
                try
                {
                    connection.Open();

                    /* ================== 1. KIỂM TRA QUẢN LÝ ================== */
                    string sqlQuanLy = @"SELECT MaQL, HoTen 
                                 FROM QuanLy
                                 WHERE TenDangNhap = @tk AND MatKhau = @mk";

                    using (SqlCommand cmdQL = new SqlCommand(sqlQuanLy, connection))
                    {
                        cmdQL.Parameters.AddWithValue("@tk", tk);
                        cmdQL.Parameters.AddWithValue("@mk", mk);

                        using (SqlDataReader readerQL = cmdQL.ExecuteReader())
                        {
                            if (readerQL.Read())
                            {
                                string maQL = readerQL["MaQL"].ToString();
                                string hoTen = readerQL["HoTen"].ToString();

                                MessageBox.Show(
                                    $"Đăng nhập thành công!\nQuản lý: {hoTen}",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                this.Hide();
                                ManHinhQuanLy frm = new ManHinhQuanLy(maQL);
                                frm.Show();
                                return; // THOÁT HÀM – không kiểm tra nhân viên nữa
                            }
                        }
                    }

                    /* ================== 2. KIỂM TRA NHÂN VIÊN ================== */
                    string sqlNhanVien = @"SELECT MaNV, HoTen 
                                   FROM NhanVien
                                   WHERE TenDangNhap = @tk AND MatKhau = @mk";

                    using (SqlCommand cmdNV = new SqlCommand(sqlNhanVien, connection))
                    {
                        cmdNV.Parameters.AddWithValue("@tk", tk);
                        cmdNV.Parameters.AddWithValue("@mk", mk);

                        using (SqlDataReader readerNV = cmdNV.ExecuteReader())
                        {
                            if (readerNV.Read())
                            {
                                string maNV = readerNV["MaNV"].ToString();
                                string hoTen = readerNV["HoTen"].ToString();

                                MessageBox.Show(
                                    $"Đăng nhập thành công!\nNhân viên: {hoTen}",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                this.Hide();
                              
                                
                                return;
                            }
                        }
                    }

                    /* ================== 3. ĐĂNG NHẬP THẤT BẠI ================== */
                    MessageBox.Show(
                        "Sai tên đăng nhập hoặc mật khẩu!",
                        "Đăng nhập thất bại",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi hệ thống: " + ex.Message,
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
