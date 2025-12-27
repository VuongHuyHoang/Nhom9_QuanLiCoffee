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
    public partial class ThemPhieu : Form
    {
        string connectionString =
                                   @"Data Source=LAPTOP-F3O4C3L0\SQLVANHIEU;
                                   Initial Catalog=ThemPhieu;
                                   Integrated Security=True";

        SqlConnection sqlCon = null;
        ErrorProvider errorProvider = new ErrorProvider();
        public ThemPhieu()
        {
            InitializeComponent();

        }

        private void ThemPhieu_Load(object sender, EventArgs e)
        {
            LoadDataToCombobox();
            // Khởi tạo cột cho DataGridView nếu chưa tạo ở Design
            
        }
       
        private void LoadDataToCombobox()
        {
            using (sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                // Load Quản lý
                SqlDataAdapter daQL = new SqlDataAdapter("SELECT MaQL, TenQL FROM QuanLy", sqlCon);
                DataTable dtQL = new DataTable();
                daQL.Fill(dtQL);
                cboQuanLy.DataSource = dtQL;
                cboQuanLy.DisplayMember = "TenQL";
                cboQuanLy.ValueMember = "MaQL";

                // Load Nguyên liệu
                SqlDataAdapter daNL = new SqlDataAdapter("SELECT MaNL, TenNL FROM NguyenLieu", sqlCon);
                DataTable dtNL = new DataTable();
                daNL.Fill(dtNL);
                cboNguyenLieu.DataSource = dtNL;
                cboNguyenLieu.DisplayMember = "TenNL";
                cboNguyenLieu.ValueMember = "MaNL";
            }
        }
        private bool KiemTraDuLieu()
        {
            bool isValid = true;
            errorProvider.Clear(); // Xóa các lỗi cũ trước khi kiểm tra

            // 1. Kiểm tra Số lượng
            if (nudSoLuong.Value <= 0)
            {
                errorProvider.SetError(nudSoLuong, "Số lượng phải lớn hơn 0!");
                isValid = false;
            }

            // 2. Kiểm tra Đơn giá
            decimal donGia;
            bool isNumeric = decimal.TryParse(txtDonGia.Text, out donGia);

            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                errorProvider.SetError(txtDonGia, "Đơn giá không được để trống!");
                isValid = false;
            }
            else if (!isNumeric || donGia <= 0)
            {
                errorProvider.SetError(txtDonGia, "Đơn giá phải là số dương!");
                isValid = false;
            }

            return isValid;
        }
        private void TinhThanhTien()
        {
            decimal soLuong = nudSoLuong.Value;
            decimal donGia = 0;
            if (decimal.TryParse(txtDonGia.Text, out donGia))
            {
                txtThanhTien.Text = (soLuong * donGia).ToString();
            }
            else
            {
                txtThanhTien.Text = "0";
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
            TinhThanhTien();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
            TinhThanhTien();
        }


        private void CapNhatTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }
            txtTongTien.Text = tongTien.ToString("N0"); // Định dạng số cho dễ nhìn
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                return; // Dừng lại nếu dữ liệu sai
            }
            // Nếu dữ liệu đúng, tiến hành thêm vào DataGridView
            string maNL = cboNguyenLieu.SelectedValue.ToString();
            string tenNL = cboNguyenLieu.Text;
            decimal soLuong = nudSoLuong.Value;
            decimal donGia = decimal.Parse(txtDonGia.Text);
            decimal thanhTien = soLuong * donGia;

            int stt = dgvChiTiet.Rows.Count ;
            dgvChiTiet.Rows.Add(stt, maNL, tenNL, soLuong, donGia, thanhTien);

            CapNhatTongTien();

            // Tùy chọn: Xóa trắng đơn giá/số lượng sau khi thêm thành công
            txtDonGia.Clear();
            nudSoLuong.Value = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào cơ bản
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) || dgvChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu và ít nhất một nguyên liệu!");
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlTransaction transaction = sqlCon.BeginTransaction(); // Dùng Transaction để tránh lỗi dữ liệu rời rạc

                try
                {
                    // 2. Lưu vào bảng PhieuNhap
                    string queryPhieu = "INSERT INTO PhieuNhap (MaPN, NgayNhap, MaQL, TongTien) VALUES (@MaPN, @NgayNhap, @MaQL, @TongTien)";
                    SqlCommand cmdPhieu = new SqlCommand(queryPhieu, sqlCon, transaction);
                    cmdPhieu.Parameters.AddWithValue("@MaPN", txtMaPhieu.Text);
                    cmdPhieu.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                    cmdPhieu.Parameters.AddWithValue("@MaQL", cboQuanLy.SelectedValue);
                    // Loại bỏ định dạng dấu phân cách nghìn nếu có trước khi lưu
                    cmdPhieu.Parameters.AddWithValue("@TongTien", decimal.Parse(txtTongTien.Text, System.Globalization.NumberStyles.Any));

                    cmdPhieu.ExecuteNonQuery();

                    // 3. Lưu vào bảng ChiTietPhieuNhap (Duyệt từng dòng trong DataGridView)
                    foreach (DataGridViewRow row in dgvChiTiet.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string queryCT = "INSERT INTO ChiTietPhieuNhap (MaPN, MaNL, SoLuong, DonGia, ThanhTien) VALUES (@MaPN, @MaNL, @SoLuong, @DonGia, @ThanhTien)";
                        SqlCommand cmdCT = new SqlCommand(queryCT, sqlCon, transaction);
                        cmdCT.Parameters.AddWithValue("@MaPN", txtMaPhieu.Text);
                        cmdCT.Parameters.AddWithValue("@MaNL", row.Cells["MaNL"].Value);
                        cmdCT.Parameters.AddWithValue("@SoLuong", row.Cells["SoLuong"].Value);
                        cmdCT.Parameters.AddWithValue("@DonGia", row.Cells["DonGia"].Value);
                        cmdCT.Parameters.AddWithValue("@ThanhTien", row.Cells["ThanhTien"].Value);

                        cmdCT.ExecuteNonQuery();
                    }

                    transaction.Commit(); // Xác nhận lưu mọi thứ thành công
                    MessageBox.Show("Lưu phiếu nhập thành công!");

                    // 4. Thiết lập DialogResult và đóng Form để quay về danh sách
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Nếu có lỗi, hủy bỏ mọi thao tác đã thực hiện
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
