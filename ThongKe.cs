using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration; 
using System.Data.SqlClient;


namespace BaiTapLon_Nhom9_QuanLiCofffee
{
    public partial class ThongKe : Form
    {
        private readonly string connStr =
                @"Data Source=DESKTOP-BON0N5S\SQLEXPRESS;
                  Initial Catalog=ThongKe;
                  Integrated Security=True;
                  Encrypt=False;
                  TrustServerCertificate=True";

        public ThongKe()
        {
            InitializeComponent();
 
        }


        private void ThongKe_Load(object sender, EventArgs e)
        {
            // ================= FORM =================
            this.Size = new Size(1300, 740);
            this.BackColor = Color.FromArgb(246, 248, 251);
            this.StartPosition = FormStartPosition.CenterScreen;


            // ================= DATE + BUTTON =================
            int topFilter = 10;
            int h = 42;

            // ===== Date From =====
            dtpFromDate.Location = new Point(0, topFilter);
            dtpFromDate.Size = new Size(270, h);
            dtpFromDate.Font = new Font("Segoe UI", 12);
            dtpFromDate.BorderRadius = 10;
            dtpFromDate.FillColor = Color.White;
            dtpFromDate.BorderColor = Color.FromArgb(220, 220, 220);
            //dtpFromDate.ForeColor = Color.FromArgb(60, 60, 60);
            dtpFromDate.HoverState.BorderColor = Color.FromArgb(0, 168, 255);

            // ===== Date To =====
            dtpToDate.Location = new Point(dtpFromDate.Right + 25, topFilter);
            dtpToDate.Size = new Size(270, h);
            dtpToDate.Font = new Font("Segoe UI", 12);
            dtpToDate.BorderRadius = 10;
            dtpToDate.FillColor = Color.White;
            dtpToDate.BorderColor = Color.FromArgb(220, 220, 220);
            //dtpToDate.ForeColor = Color.FromArgb(60, 60, 60);
            dtpToDate.HoverState.BorderColor = Color.FromArgb(0, 168, 255);

            // ===== Button Thống Kê =====
            btnThongKe.Location = new Point(dtpToDate.Right + 50, topFilter);
            btnThongKe.Size = new Size(140, h);
            btnThongKe.Font = new Font("Segoe UI Semibold", 12);
            btnThongKe.Text = "📊 Thống kê";
            btnThongKe.BorderRadius = 12;
            btnThongKe.FillColor = Color.Navy;      
            btnThongKe.ForeColor = Color.White;
            btnThongKe.HoverState.FillColor = Color.FromArgb(0, 180, 73);
            //btnThongKe.ShadowDecoration.Enabled = true;

            // ===== Button Làm mới =====
            btnReload.Location = new Point(btnThongKe.Right + 25, topFilter);
            btnReload.Size = new Size(140, h);
            btnReload.Font = new Font("Segoe UI Bold", 12);
            btnReload.Text = " 🔄 Làm mới";
            btnReload.BorderRadius = 12;
            btnReload.FillColor = Color.White;
            btnReload.ForeColor = Color.Navy;
            btnReload.BorderThickness = 2;
            btnReload.BorderColor = Color.FromArgb(220, 220, 220);
            btnReload.HoverState.FillColor = Color.FromArgb(245, 245, 245);


            // ================= KPI =================
            int kpiTop = 160;
            int kpiHeight = 100;
            int gap = 25;
            int kpiWidth = 400;

            pnlDoanhThu.Location = new Point(25, kpiTop);
            pnlDoanhThu.Size = new Size(kpiWidth, kpiHeight);

            pnlSoLuong.Location = new Point(pnlDoanhThu.Right + gap, kpiTop);
            pnlSoLuong.Size = new Size(kpiWidth, kpiHeight);

            pnlBanChay.Location = new Point(pnlSoLuong.Right + gap, kpiTop);
            pnlBanChay.Size = new Size(kpiWidth, kpiHeight);

            SetupKpiPanel(pnlDoanhThu);
            SetupKpiPanel(pnlSoLuong);
            SetupKpiPanel(pnlBanChay);

            // ================= KPI LABEL =================
            gndt.Location = new Point(20, 12);

            lblTongDoanhThu.Location = new Point(20, 42);
            lblTongDoanhThu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            lblTongSoLuong.Location = new Point(20, 42);
            lblTongSoLuong.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            lblBanChay.Location = new Point(20, 42);
            lblBanChay.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            // ================= DATAGRIDVIEW =================
            pnlDM.Location = new Point(25, 270);
            pnlDM.Size = new Size(1250, 455);
            


            dgvDanhMuc.Location = new Point(0, 60);
            dgvDanhMuc.Size = new Size(1250, 395);

            dgvDanhMuc.BackgroundColor = Color.White;   
            dgvDanhMuc.BorderStyle = BorderStyle.None;
            dgvDanhMuc.RowHeadersVisible = false;
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.ThemeStyle.HeaderStyle.BackColor =
             Color.FromArgb(0, 0, 128);
            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDanhMuc.ThemeStyle.HeaderStyle.Font =
                new Font("Segoe UI Semibold", 12);

            dgvDanhMuc.ThemeStyle.HeaderStyle.Height = 48;
            dgvDanhMuc.ColumnHeadersHeight = 48;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.BackColor =
                Color.Navy;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvDanhMuc.DefaultCellStyle.Font =
                new Font("Segoe UI", 12);

            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetupKpiPanel(Guna2Panel panel)
        {
            panel.FillColor = Color.White;
            panel.BorderRadius = 12;
            panel.ShadowDecoration.Enabled = true;
            panel.ShadowDecoration.Depth = 5;
            panel.ShadowDecoration.Color = Color.Gray;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtpFromDate.Value.Date > dtpToDate.Value.Date)
            {
                MessageBox.Show("Khoảng thời gian không hợp lệ");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "sp_ThongKeThucUongTheoLoai", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value.Date);
                    cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    // ===== RESULT SET 1: BẢNG =====
                    dgvDanhMuc.DataSource = ds.Tables[0];

                    // ===== RESULT SET 2: KPI =====
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        lblTongSoLuong.Text =
                            ds.Tables[1].Rows[0]["TongSoLuong"].ToString();

                        lblTongDoanhThu.Text =
                            Convert.ToDecimal(ds.Tables[1].Rows[0]["TongDoanhThu"])
                            .ToString("N0") + " VNĐ";
                    }

                    // ===== RESULT SET 3: BÁN CHẠY =====
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        lblBanChay.Text =
                            ds.Tables[2].Rows[0]["TenLoai"] + " (" +
                            ds.Tables[2].Rows[0]["SoLuongBan"] + ")";
                    }
                    // ===== CHỈNH GIAO DIỆN NGAY SAU KHI BIND =====
                    dgvDanhMuc.RowTemplate.Height = 40;
                    dgvDanhMuc.ColumnHeadersHeight = 45;
                    dgvDanhMuc.ScrollBars = ScrollBars.Vertical;
                    dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                    // DÃN DÒNG FULL HEIGHT
                    int rowCount = dgvDanhMuc.Rows.Count == 0 ? 1 : dgvDanhMuc.Rows.Count;
                    int headerHeight = dgvDanhMuc.ColumnHeadersHeight;
                    int availableHeight = dgvDanhMuc.Height - headerHeight;
                    int rowHeight = availableHeight / rowCount;

                    foreach (DataGridViewRow row in dgvDanhMuc.Rows)
                    {
                        row.Height = rowHeight;
                    }
                }
            }
        }




        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
