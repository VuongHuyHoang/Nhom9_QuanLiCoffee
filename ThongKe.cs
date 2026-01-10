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

namespace BaiTapLon_Nhom9_QuanLiCofffee
{
    public partial class ThongKe : Form
    {
        private readonly string connStr =
                @"Data Source=LAPTOP-QUBRA9KU\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;TrustServerCertificate=True";
        public ThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            
            

            

            

          
        }
        

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra ngày hợp lệ
            if (dtpFromDate.Value.Date > dtpToDate.Value.Date)
            {
                MessageBox.Show("Khoảng thời gian không hợp lệ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand("sp_ThongKeThucUongTheoLoai", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@FromDate", SqlDbType.Date).Value = dtpFromDate.Value.Date;
                    cmd.Parameters.Add("@ToDate", SqlDbType.Date).Value = dtpToDate.Value.Date;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    conn.Open();
                    da.Fill(ds);

                    /* ======================================
                       RESULT SET 1: BẢNG THỐNG KÊ THEO LOẠI
                       ====================================== */
                    if (ds.Tables.Count > 0 && ds.Tables[0].Columns.Contains("TenLoai"))
                    {
                        dgvDanhMuc.DataSource = ds.Tables[0];

                        dgvDanhMuc.Columns["MaLoai"].HeaderText = "Mã loại";
                        dgvDanhMuc.Columns["TenLoai"].HeaderText = "Tên loại";
                        dgvDanhMuc.Columns["SoLuongThucUong"].HeaderText = "Số thức uống";
                        dgvDanhMuc.Columns["TongSoLuongBan"].HeaderText = "Tổng SL bán";
                        dgvDanhMuc.Columns["TongDoanhThu"].HeaderText = "Tổng doanh thu (VNĐ)";
                        dgvDanhMuc.Columns["TyLeDoanhThu"].HeaderText = "Tỷ lệ (%)";

                        dgvDanhMuc.Columns["TongDoanhThu"].DefaultCellStyle.Format = "N0";
                        dgvDanhMuc.Columns["TyLeDoanhThu"].DefaultCellStyle.Format = "N2";

                        dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvDanhMuc.RowTemplate.Height = 40;
                        dgvDanhMuc.ColumnHeadersHeight = 45;
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu thống kê",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhMuc.DataSource = null;
                        return;
                    }

                    /* ======================================
                       RESULT SET 2: KPI TỔNG
                       ====================================== */
                    if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                    {
                        lblTongSoLuong.Text =
                            ds.Tables[1].Rows[0]["TongSoLuong"].ToString();

                        lblTongDoanhThu.Text =
                            Convert.ToDecimal(ds.Tables[1].Rows[0]["TongDoanhThu"])
                            .ToString("N0") + " VNĐ";
                    }
                    else
                    {
                        lblTongSoLuong.Text = "0";
                        lblTongDoanhThu.Text = "0 VNĐ";
                    }

                    /* ======================================
                       RESULT SET 3: LOẠI BÁN CHẠY NHẤT
                       ====================================== */
                    if (ds.Tables.Count > 2 && ds.Tables[2].Rows.Count > 0)
                    {
                        lblBanChay.Text =
                            ds.Tables[2].Rows[0]["TenLoai"] + " (" +
                            ds.Tables[2].Rows[0]["SoLuongBan"] + ")";
                    }
                    else
                    {
                        lblBanChay.Text = "Không có dữ liệu";
                    }

                    /* ======================================
                       DÀN CHIỀU CAO DÒNG FULL GRID
                       ====================================== */
                    if (dgvDanhMuc.Rows.Count > 0)
                    {
                        int headerHeight = dgvDanhMuc.ColumnHeadersHeight;
                        int availableHeight = dgvDanhMuc.Height - headerHeight;
                        int rowHeight = availableHeight / dgvDanhMuc.Rows.Count;

                        foreach (DataGridViewRow row in dgvDanhMuc.Rows)
                        {
                            row.Height = rowHeight;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Lỗi SQL: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi hệ thống: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            // 1. Reset DateTimePicker (mặc định: hôm nay)
            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today;

            // 2. Xóa bảng thống kê
            dgvDanhMuc.DataSource = null;
            dgvDanhMuc.Rows.Clear();
            dgvDanhMuc.Refresh();

            // 3. Reset KPI
            lblTongSoLuong.Text = "0";
            lblTongDoanhThu.Text = "0 VNĐ";
            lblBanChay.Text = "—";

            // 4. Reset lại giao diện DataGridView
            dgvDanhMuc.ColumnHeadersHeight = 45;
            dgvDanhMuc.RowTemplate.Height = 40;
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.ScrollBars = ScrollBars.Vertical;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
