using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BaiTapLon_Nhom9_QuanLiCofffee
{
    public partial class DSPhieuNhap : Form
    {
        string connectionString =
                                  @"Data Source=LAPTOP-F3O4C3L0\SQLVANHIEU;
                                   Initial Catalog=ThemPhieu;
                                   Integrated Security=True";
        public DSPhieuNhap()
        {
            InitializeComponent();
        }

        private void DSPhieuNhap_Load(object sender, EventArgs e)
        {
            //LoadDanhSachPhieu();
        }
        private void LoadDanhSachPhieu()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    // Truy vấn kết hợp với bảng QuanLy để lấy tên người quản lý
                    string query = @"SELECT p.MaPN as 'Mã Phiếu', 
                                            p.NgayNhap as 'Ngày Nhập', 
                                            q.TenQL as 'Người Quản Lý', 
                                            p.TongTien as 'Tổng Tiền' 
                                     FROM PhieuNhap p
                                     JOIN QuanLy q ON p.MaQL = q.MaQL
                                     ORDER BY p.NgayNhap DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDanhSach.DataSource = dt;

                    // Định dạng hiển thị tiền tệ cho cột Tổng Tiền
                    dgvDanhSach.Columns["Tổng Tiền"].DefaultCellStyle.Format = "N0";
                    dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            // Giả sử Form thêm phiếu của bạn tên là frmThemPhieu
            ThemPhieu Them = new ThemPhieu();

            // Hiển thị Form thêm phiếu dưới dạng Dialog
            if (Them.ShowDialog() == DialogResult.OK)
            {
                // Sau khi Form thêm phiếu đóng lại và lưu thành công, load lại danh sách
                LoadDanhSachPhieu();
            }
        }
    }
}
