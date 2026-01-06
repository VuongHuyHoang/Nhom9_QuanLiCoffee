using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO; // Thư viện xử lý file
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_Nhom9_QuanLiCofffee
{
    public partial class ThemDoUongcs : Form
    {
        // Chuỗi kết nối
        string strKetNoi = @"Data Source=LAPTOP-QUBRA9KU\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;TrustServerCertificate=True";
        // Biến lưu tên ảnh hiện tại (Mặc định là rỗng)
        string tenFileAnh = "";

        SqlConnection sqlCon = null;
        SqlDataAdapter sqlAdt = null;
        DataTable dt = null;

        public ThemDoUongcs()
        {
            InitializeComponent();
        }

        // --- HÀM KẾT NỐI ---
        private void MoKetNoi()
        {
            try
            {
                if (sqlCon == null) sqlCon = new SqlConnection(strKetNoi);
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        // --- HÀM LOAD ẢNH THÔNG MINH (TRÁNH BỊ KHÓA FILE) ---
        // Đây là bí quyết để không bị lỗi "File used by another process"
        private Image LoadAnhKhongKhoa(string duongDan)
        {
            if (!File.Exists(duongDan)) return null;
            using (FileStream fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read))
            {
                return Image.FromStream(fs);
            }
        }

        // --- LOAD DỮ LIỆU ---
        private void LoadDuLieu()
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM DoUong", sqlCon);
            sqlAdt = new SqlDataAdapter(sqlCmd);
            dt = new DataTable();
            sqlAdt.Fill(dt);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;

            // Đặt tên tiếng Việt cho đẹp
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Columns["MaDoUong"].HeaderText = "Mã Món";
                dataGridView1.Columns["TenDoUong"].HeaderText = "Tên Món";
                dataGridView1.Columns["MaDM"].HeaderText = "Danh Mục";
                dataGridView1.Columns["DonGia"].HeaderText = "Đơn Giá";
                // Ẩn cột hình ảnh đi cho đỡ rối mắt (Vì đã hiện trên PictureBox rồi)
                if (dataGridView1.Columns.Contains("HinhAnh"))
                    dataGridView1.Columns["HinhAnh"].Visible = false;

                dataGridView1.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }
        }

        private void LoadCombobox()
        {
            MoKetNoi();
            SqlDataAdapter adt = new SqlDataAdapter("SELECT * FROM DanhMuc", sqlCon);
            DataTable dtDM = new DataTable();
            adt.Fill(dtDM);

            cboDanhMuc.DataSource = dtDM;
            cboDanhMuc.DisplayMember = "TenDM";
            cboDanhMuc.ValueMember = "MaDM";
        }

        private void ThemDoUongcs_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            LoadCombobox();
        }

        // --- NÚT CHỌN ẢNH (Button1) ---
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh lên PictureBox (Dùng hàm không khóa file)
                pictureBox1.Image = LoadAnhKhongKhoa(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Cập nhật tên file mới vào biến
                tenFileAnh = Path.GetFileName(open.FileName);

                // Lưu đường dẫn gốc vào Tag để lát copy
                pictureBox1.Tag = open.FileName;
            }
        }

        // --- NÚT THÊM (Button6) ---
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                // 1. XỬ LÝ COPY ẢNH
                if (pictureBox1.Tag != null)
                {
                    string duongDanGoc = pictureBox1.Tag.ToString();
                    string thuMucChuaAnh = Application.StartupPath + @"\Images";
                    string thuMucDich = thuMucChuaAnh + @"\" + tenFileAnh;

                    // Tạo thư mục nếu chưa có
                    if (!Directory.Exists(thuMucChuaAnh)) Directory.CreateDirectory(thuMucChuaAnh);

                    // Copy file
                    try { File.Copy(duongDanGoc, thuMucDich, true); } catch { }
                }

                // 2. LỆNH INSERT
                string sqlThem = "INSERT INTO DoUong (MaDoUong, TenDoUong, DonGia, MaDM, HinhAnh) VALUES (@Ma, @Ten, @Gia, @MaDM, @Hinh)";
                SqlCommand cmd = new SqlCommand(sqlThem, sqlCon);

                cmd.Parameters.AddWithValue("@Ma", textBox2.Text);
                cmd.Parameters.AddWithValue("@Ten", textBox3.Text);
                cmd.Parameters.AddWithValue("@Gia", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@MaDM", cboDanhMuc.SelectedValue);

                // Nếu chưa chọn ảnh thì lưu chuỗi rỗng hoặc mặc định
                cmd.Parameters.AddWithValue("@Hinh", tenFileAnh);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công!");
                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        // --- NÚT SỬA (Button8) ---
        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng chọn món cần sửa!");
                return;
            }

            try
            {
                MoKetNoi();

                // 1. XỬ LÝ COPY ẢNH (NẾU CÓ CHỌN ẢNH MỚI)
                if (pictureBox1.Tag != null)
                {
                    string duongDanGoc = pictureBox1.Tag.ToString();
                    string thuMucChuaAnh = Application.StartupPath + @"\Images";
                    string thuMucDich = thuMucChuaAnh + @"\" + tenFileAnh;
                    if (!Directory.Exists(thuMucChuaAnh)) Directory.CreateDirectory(thuMucChuaAnh);
                    try { File.Copy(duongDanGoc, thuMucDich, true); } catch { }
                }

                // 2. LỆNH UPDATE (Đã bổ sung cập nhật HinhAnh)
                string sqlSua = "UPDATE DoUong SET TenDoUong = @Ten, DonGia = @Gia, MaDM = @MaDM, HinhAnh = @Hinh, TrangThai = @trangthai WHERE MaDoUong = @Ma";

                SqlCommand cmd = new SqlCommand(sqlSua, sqlCon);
                cmd.Parameters.AddWithValue("@Ma", textBox2.Text);
                cmd.Parameters.AddWithValue("@Ten", textBox3.Text);
                cmd.Parameters.AddWithValue("@Gia", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@MaDM", cboDanhMuc.SelectedValue);
                cmd.Parameters.AddWithValue("@trangthai", txtTrangThai.Text);

                // Cập nhật tên ảnh mới (hoặc giữ tên ảnh cũ nếu không đổi)
                cmd.Parameters.AddWithValue("@Hinh", tenFileAnh);

                int ketQua = cmd.ExecuteNonQuery();
                if (ketQua > 0)
                {
                    MessageBox.Show("Đã sửa thành công!");
                    LoadDuLieu();
                    // Reset Tag sau khi sửa để tránh copy lại lần sau
                    pictureBox1.Tag = null;
                }
                else MessageBox.Show("Không tìm thấy mã món!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        // --- SỰ KIỆN CLICK BẢNG (CellClick) ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox2.Text = row.Cells["MaDoUong"].Value.ToString();
                textBox3.Text = row.Cells["TenDoUong"].Value.ToString();

                // Xử lý giá
                if (row.Cells["DonGia"].Value != DBNull.Value)
                    numericUpDown1.Value = Convert.ToDecimal(row.Cells["DonGia"].Value);
                else numericUpDown1.Value = 0;

                // Xử lý Danh mục
                if (row.Cells["MaDM"].Value != null)
                    cboDanhMuc.SelectedValue = row.Cells["MaDM"].Value.ToString();

                // --- XỬ LÝ HIỂN THỊ ẢNH ---
                // Reset ảnh trước
                pictureBox1.Image = null;
                pictureBox1.Tag = null; // Reset tag để biết là chưa chọn ảnh mới

                var cellHinh = row.Cells["HinhAnh"].Value;
                if (cellHinh != null && !string.IsNullOrEmpty(cellHinh.ToString()))
                {
                    tenFileAnh = cellHinh.ToString(); // Lưu tên ảnh của dòng đang chọn vào biến
                    string duongDanAnh = Application.StartupPath + @"\Images\" + tenFileAnh;

                    // Load ảnh dùng hàm thông minh
                    pictureBox1.Image = LoadAnhKhongKhoa(duongDanAnh);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    tenFileAnh = ""; // Không có ảnh
                }
            }
        }

        // Nút Xóa (Button9) giữ nguyên code cũ của bạn cũng ok, 
        // nhưng nhớ thêm try-catch giống các nút trên.
        private void button9_Click(object sender, EventArgs e)
        {   // 1. Kiểm tra xem người dùng đã chọn dòng nào trên bảng chưa
            // (Hoặc kiểm tra xem ô Mã có trống không)
            if (dataGridView1.SelectedRows.Count == 0 && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng chọn món cần xóa trên bảng!");
                return;
            }
            // 2. Lấy Mã Đồ Uống cần xóa
            // Cách hay nhất: Lấy trực tiếp từ dòng đang chọn trên DataGridView để chính xác 100%
            string maCanXoa = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy giá trị của cột "MaDoUong" (Bạn đảm bảo tên cột đúng nhé)
                maCanXoa = dataGridView1.CurrentRow.Cells["MaDoUong"].Value.ToString();
            }
            else
            {
                // Hoặc lấy từ ô nhập liệu nếu người dùng gõ tay
                maCanXoa = textBox2.Text;
            }
            // 3. Hỏi xác nhận (Rất quan trọng, tránh bấm nhầm)
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa món [" + maCanXoa + "] không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (ketQua == DialogResult.Yes)
            {
                try
                {
                    MoKetNoi(); // Mở kết nối
                    // 4. Viết lệnh SQL Xóa
                    // Chỉ cần xóa theo MaDoUong là đủ
                    string sqlXoa = "DELETE FROM DoUong WHERE MaDoUong = @Ma";
                    SqlCommand cmd = new SqlCommand(sqlXoa, sqlCon);
                    cmd.Parameters.AddWithValue("@Ma", maCanXoa);
                    // 5. Thực thi lệnh
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thành công!");
                    // 6. Cập nhật lại giao diện
                    LoadDuLieu(); // Load lại bảng
                    // Xóa trắng các ô nhập liệu cho đẹp
                    textBox2.Text = "";
                    textBox3.Text = "";
                    numericUpDown1.Value = 0;
                }
                catch (Exception ex)

                {
                    MessageBox.Show("Lỗi không xóa được: " + ex.Message);

                    // Lỗi thường gặp: Do món này đang nằm trong hóa đơn nào đó (ràng buộc khóa ngoại)
                }
            }
        }

        // Các hàm thừa
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

    }
}