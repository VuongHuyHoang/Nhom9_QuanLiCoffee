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
            using (SqlConnection connection = new SqlConnection(str))
            {
                try
                {
                    connection.Open();

                    string sql = @"SELECT MaNV, HoTen, ChucVu 
                                   FROM NhanVien 
                                   WHERE TenDangNhap = @tk AND MatKhau = @mk";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@tk", txtTenDangNhap.Text.Trim());
                        command.Parameters.AddWithValue("@mk", txtMatKhau.Text.Trim());

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string maNV = reader["MaNV"].ToString();
                            string hoTen = reader["HoTen"].ToString();
                            string chucVu = reader["ChucVu"].ToString();

                            MessageBox.Show(
                                $"Đăng nhập thành công!\nNhân viên: {hoTen}\nChức vụ: {chucVu}",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            this.Hide();

                            // Phân quyền
                            if (chucVu == "QuanLy")
                            {
                                ManHinhQuanLy frm = new ManHinhQuanLy(maNV);
                                frm.Show();
                            }
                            else
                            {
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "Sai tên đăng nhập hoặc mật khẩu!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi kết nối CSDL: " + ex.Message,
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
    }
}
