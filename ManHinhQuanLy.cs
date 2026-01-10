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
    public partial class ManHinhQuanLy: Form
    {
        ContextMenuStrip menu;
        private Button currentButton;
        private Random rd;
        private int tempIndex;
        private Form currentFormChild;

        public ManHinhQuanLy(string MaNV)
        {
            InitializeComponent();
            menu = new ContextMenuStrip();

            menu.Items.Add("Tra Cứu", null, (s, e) =>
            {
                OpenChildForm(new Tracuu());
            });

            menu.Items.Add("Lựa chọn B", null, (s, e) =>
            {
                MessageBox.Show("Bạn chọn B");
            });

            rd = new Random();
        }

        private void ManHinhQuanLy_Load(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////Chọn Màu Cho Nút
        private Color SelectThemeColor()
        {
            int index = rd.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = rd.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private Color DarkenColor(Color color, double factor = 0.8)
        {
            int r = (int)(color.R * factor);
            int g = (int)(color.G * factor);
            int b = (int)(color.B * factor);

            return Color.FromArgb(r, g, b);
        }


        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbName.BackColor = color;
                    pnButtonMenu.BackColor = DarkenColor(color, 0.75);
                }
            }
        }

        private void DisableButton()
        {
            DisableButton(sdbMenu);
        }
        private void DisableButton(Control parent)
        {
            foreach (Control previousBtn in parent.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else if (previousBtn.HasChildren)
                {
                    //goi lai ham neu cac control chua cac control con
                    DisableButton(previousBtn);
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////end

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Chuyển động trượt Sidebar với Menu
        bool sidebarExpand;
        bool isAnimating;
        private void sidebarTimer_Tick_1(object sender, EventArgs e)
        {
            if (!isAnimating)
            {
                isAnimating = true;
                pnBody.Visible = false; // Ẩn tạm để tránh lag khi tair len
            }
            int step = 20;
            if (sidebarExpand)
            {
                //neu sidebar dang mo rong, thi thu nho
                pnName.Left -= step;
                pnBody.Left -= step;
                pnName.Width += step;
                pnBody.Width += step;
                sdbMenu.Width -= step;
                if (sdbMenu.Width <= sdbMenu.MinimumSize.Width)
                {
                    pnName.Width = pnName.MaximumSize.Width + 4;
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                    pnBody.Visible = true;
                    isAnimating = false;
                }
            }
            else
            {
                pnName.Left += step;
                pnBody.Left += step;
                pnBody.Width -= step;
                pnName.Width -= step;
                sdbMenu.Width += step;
                if (sdbMenu.Width >= sdbMenu.MaximumSize.Width)
                {
                    pnName.Width = pnName.MinimumSize.Width + 4;
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    pnBody.Visible = true;
                    isAnimating = false;
                }
            }
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        bool caidatExpand = false;
        private void CaiDatTimer_Tick(object sender, EventArgs e)
        {
            if (caidatExpand == false)
            {
                CaiDatContainer.Height += 10;
                if (CaiDatContainer.Height >= 107)
                {
                    CaiDatTimer.Stop();
                    caidatExpand = true;
                }
            }
            else
            {
                CaiDatContainer.Height -= 10;
                if (CaiDatContainer.Height <= 40)
                {
                    CaiDatTimer.Stop();
                    caidatExpand = false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CaiDatTimer.Start();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Mờ Form con
        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lbName.Text = btnQuanLyDanhMuc.Text;
        }

        private void btnQuanLyThucUong_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lbName.Text = btnQuanLyThucUong.Text;
            menu.Show(btnQuanLyThucUong, btnQuanLyThucUong.Width, 0);
          
        }

        private void btnQuanLyCaLam_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lbName.Text = btnQuanLyCaLam.Text;
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lbName.Text = btnQuanLyHoaDon.Text;
        }

        private void btnBangChamCong_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lbName.Text = btnBangChamCong.Text;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lbName.Text = btnBaoCao.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lbName.Text = btnLapPhieuNhap.Text;

            DSPhieuNhap dSPhieuNhap = new DSPhieuNhap();
            OpenChildForm(dSPhieuNhap);
        }
     
       


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////end
    }
}
