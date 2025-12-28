using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon_Nhom9_QuanLiCofffee
{
    public partial class Tracuu : Form
    {
        string connectionString = @"Data Source=.;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

        public Tracuu()
        {
            InitializeComponent();
        }

        private void Tracuu_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadTatCaDoUong();
        }

        private void LoadDanhMuc()
        {
            string connStr = @"Data Source=.;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT MaDM, TenDM FROM DanhMuc";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "TenDM";
                comboBox1.ValueMember = "MaDM";   
                comboBox1.SelectedIndex = -1;     
            }
        }



        private void LoadTatCaDoUong()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT MaDoUong, TenDoUong, DonGia, TrangThai FROM DoUong";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT MaDoUong, TenDoUong, DonGia, TrangThai FROM DoUong WHERE TenDoUong LIKE @Ten";

                if (comboBox1.SelectedIndex != -1)
                    sql += " AND MaDM = @MaDM";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", "%" + textBox1.Text + "%");

                if (comboBox1.SelectedIndex != -1)
                    cmd.Parameters.AddWithValue("@MaDM", comboBox1.SelectedValue.ToString());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show(
                        "Vui lòng nhập lại!",
                        "Không tìm thấy đồ uống",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                dataGridView1.DataSource = dt;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            LoadTatCaDoUong();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Tracuu_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCafeDataSet.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter1.Fill(this.quanLyQuanCafeDataSet.DanhMuc);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
