using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_Nhom9_QuanLiCofffee
{
    public partial class ThemDoUongcs : Form
    {
        public ThemDoUongcs()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThemDoUongcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'themDoUongDataSet.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter.Fill(this.themDoUongDataSet.DanhMuc);
            // TODO: This line of code loads data into the 'themDoUongDataSet.DoUong' table. You can move, or remove it, as needed.
            this.doUongTableAdapter.Fill(this.themDoUongDataSet.DoUong);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
