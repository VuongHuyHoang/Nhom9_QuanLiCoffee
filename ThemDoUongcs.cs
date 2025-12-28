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
    public partial class ThemDoUongcs : Form
    {
        string strKetNoi = @"Data Source=LAPTOP-QUBRA9KU\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;TrustServerCertificate=True";
        string tenFileAnh = "default.png";
        SqlConnection sqlCon = null;
        SqlDataAdapter sqlAdt = null;
        DataTable dt = null;
        public ThemDoUongcs()
        {
            InitializeComponent();
        }
        private void MoKetNoi()
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strKetNoi);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        private void LoadDuLieu()
        {
            MoKetNoi();
            // Lấy hết dữ liệu từ bảng DoUong
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM DoUong", sqlCon);
            sqlAdt = new SqlDataAdapter(sqlCmd);
            dt = new DataTable();
            sqlAdt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                // Có dữ liệu -> Gán vào Grid
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["MaDoUong"].HeaderText = "Mã Đồ Uống";
                dataGridView1.Columns["TenDoUong"].HeaderText = "Tên Món";
                dataGridView1.Columns["MaDM"].HeaderText = "Mã Danh Mục";
                dataGridView1.Columns["DonGia"].HeaderText = "Đơn Giá";

                // Làm đẹp số tiền (thêm dấu phẩy: 25,000)
                dataGridView1.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }
            else
            {
                MessageBox.Show("Kết nối thành công ");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }
       
        private void LoadCombobox()
        {
            MoKetNoi();
            // Lấy dữ liệu từ bảng DanhMuc
            SqlDataAdapter adt = new SqlDataAdapter("SELECT * FROM DanhMuc", sqlCon);
            DataTable dtDM = new DataTable();
            adt.Fill(dtDM);

           
           
             cboDanhMuc.DataSource = dtDM;
             cboDanhMuc.DisplayMember = "TenDM"; // Hiện tên
             cboDanhMuc.ValueMember = "MaDM";    // Giá trị ngầm là Mã
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThemDoUongcs_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            LoadCombobox();
            // git add. git commit git push

        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có nhập Mã đồ uống chưa (Vì sửa phải cần ID để biết sửa ai)
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng chọn món cần sửa hoặc nhập Mã ID!");
                return;
            }

            try
            {
                MoKetNoi();

                // 2. Câu lệnh SQL UPDATE
                // Cập nhật Tên, Giá, Danh mục dựa theo Mã (WHERE MaDoUong = @Ma)
                string sqlSua = "UPDATE DoUong SET TenDoUong = @Ten, DonGia = @Gia, MaDM = @MaDM WHERE MaDoUong = @Ma";

                SqlCommand cmd = new SqlCommand(sqlSua, sqlCon);

                // 3. Gán giá trị mới vào
                cmd.Parameters.AddWithValue("@Ma", textBox2.Text);       // ID (Dùng để tìm, không sửa ID)
                cmd.Parameters.AddWithValue("@Ten", textBox3.Text);      // Tên mới
                cmd.Parameters.AddWithValue("@Gia", numericUpDown1.Value); // Giá mới
                cmd.Parameters.AddWithValue("@MaDM", cboDanhMuc.SelectedValue); // Danh mục mới

                // 4. Thực thi
                int ketQua = cmd.ExecuteNonQuery();

                if (ketQua > 0)
                {
                    MessageBox.Show("Đã sửa thành công!");
                    LoadDuLieu(); // Load lại bảng để thấy thay đổi
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã đồ uống này để sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                if (pictureBox1.Tag != null) // Nếu người dùng có chọn ảnh mới
                {
                    string duongDanGoc = pictureBox1.Tag.ToString();
                    string thuMucDich = Application.StartupPath + @"\Images\" + tenFileAnh;

                    // Copy file (ghi đè nếu trùng tên)
                    try
                    {
                        System.IO.File.Copy(duongDanGoc, thuMucDich, true);
                    }
                    catch { /* Bỏ qua nếu lỗi copy */ }
                }
                // Câu lệnh INSERT
                string sqlThem = "INSERT INTO DoUong (MaDoUong, TenDoUong, DonGia, MaDM, HinhAnh) VALUES (@Ma, @Ten, @Gia, @MaDM, @Hinh)";
                SqlCommand cmd = new SqlCommand(sqlThem, sqlCon);

               
                
                cmd.Parameters.AddWithValue("@Ma", textBox2.Text);
                cmd.Parameters.AddWithValue("@Ten", textBox3.Text);
                cmd.Parameters.AddWithValue("@Gia", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@MaDM", cboDanhMuc.SelectedValue);
                cmd.Parameters.AddWithValue("@Hinh", tenFileAnh);


                cmd.ExecuteNonQuery(); 

                MessageBox.Show("Đã thêm thành công!");
                LoadDuLieu(); // Load lại bảng để thấy dòng mới
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            // 1. Kiểm tra xem người dùng đã chọn dòng nào trên bảng chưa
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            // 1. Kiểm tra xem người dùng có bấm vào dòng hợp lệ không (tránh dòng tiêu đề -1)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Đổ ID
                textBox2.Text = row.Cells["MaDoUong"].Value.ToString();

                // Đổ Tên Món
                textBox3.Text = row.Cells["TenDoUong"].Value.ToString();

                // --- SỬA LỖI GIÁ Ở ĐÂY ---
                // Kiểm tra xem giá có bị Null không trước khi ép kiểu
                if (row.Cells["DonGia"].Value != null && row.Cells["DonGia"].Value != DBNull.Value)
                {
                    // Ép kiểu sang Decimal an toàn
                    decimal giaTien = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    numericUpDown1.Value = giaTien;
                }
                else
                {
                    numericUpDown1.Value = 0;
                }

                // Đổ Danh Mục (Code này sẽ tự chọn đúng mục trong ComboBox)
                if (row.Cells["MaDM"].Value != null)
                {
                    cboDanhMuc.SelectedValue = row.Cells["MaDM"].Value.ToString();
                }
                var cellHinh = row.Cells["HinhAnh"].Value;

                if (cellHinh != null && cellHinh.ToString() != "")
                {
                    string tenAnh = cellHinh.ToString();
                    string duongDanAnh = Application.StartupPath + @"\Images\" + tenAnh;

                    // Kiểm tra xem file ảnh có tồn tại không rồi mới load
                    if (System.IO.File.Exists(duongDanAnh))
                    {
                        pictureBox1.Image = Image.FromFile(duongDanAnh);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        tenFileAnh = tenAnh; // Cập nhật biến toàn cục
                    }
                    else
                    {
                        pictureBox1.Image = null; // Không thấy ảnh thì để trống
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // Chỉ cho chọn file ảnh
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // 1. Hiển thị ảnh lên PictureBox cho đẹp
                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Co giãn ảnh cho vừa khung

                // 2. Lưu tên file vào biến để lát nữa dùng
                // (System.IO.Path.GetFileName sẽ cắt lấy mỗi tên file, bỏ đường dẫn dài ngoằng)
                tenFileAnh = System.IO.Path.GetFileName(open.FileName);

                // 3. Lưu đường dẫn gốc để lát nữa copy
                pictureBox1.Tag = open.FileName;
            }
        }
    }
    }
    

