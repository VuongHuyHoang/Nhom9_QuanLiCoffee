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
        string connectionString = @"Data Source=LAPTOP-QUBRA9KU\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;TrustServerCertificate=True";

        public DSPhieuNhap()
        {
            InitializeComponent();
        }

        private void DSPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieu();
        }
        private void LoadDanhSachPhieu()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    // Mở kết nối trước khi fill (tốt cho hiệu suất)
                    if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

                    // Truy vấn khớp với tên bảng QuanLy và PhieuNhap bạn đã tạo
                    // Sử dụng N'...' cho các bí danh có dấu để tránh lỗi font hệ thống
                    string query = @"SELECT p.MaPhieu AS [Mã Phiếu], 
                                    p.NgayNhap AS [Ngày Nhập], 
                                    q.HoTen AS [Người Quản Lý], 
                                    p.TongTienNhap AS [Tổng Tiền] 
                             FROM PhieuNhap p
                             INNER JOIN QuanLy q ON p.MaQL = q.MaQL
                             ORDER BY p.NgayNhap DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDanhSach.DataSource = dt;

                    // Kiểm tra cột tồn tại trước khi định dạng để tránh lỗi Runtime
                    if (dgvDanhSach.Columns.Contains("Tổng Tiền"))
                    {
                        // "N0" phù hợp với DECIMAL(18,0) vì nó sẽ phân cách hàng nghìn và không lấy số lẻ
                        dgvDanhSach.Columns["Tổng Tiền"].DefaultCellStyle.Format = "N0";
                        dgvDanhSach.Columns["Tổng Tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }

                    // Định dạng ngày tháng cho cột Ngày Nhập
                    if (dgvDanhSach.Columns.Contains("Ngày Nhập"))
                    {
                        dgvDanhSach.Columns["Ngày Nhập"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    }

                    dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvDanhSach.ReadOnly = true; // Chỉ xem danh sách
                    dgvDanhSach.AllowUserToAddRows = false; // Tắt dòng trống cuối cùng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phiếu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
