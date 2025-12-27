namespace BaiTapLon_Nhom9_QuanLiCofffee
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.dtpToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlDoanhThu = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTongDoanhThu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gndt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlSoLuong = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTongSoLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gnslb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlBanChay = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBanChay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gnbcn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlDM = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDanhMuc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblDanhMuc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlFilter.SuspendLayout();
            this.pnlDoanhThu.SuspendLayout();
            this.pnlSoLuong.SuspendLayout();
            this.pnlBanChay.SuspendLayout();
            this.pnlDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "🥧 THỐNG KÊ THỨC UỐNG THEO LOẠI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xem chi tiết danh số bán hàng theo từng danh mục đồ uống ";
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnReload);
            this.pnlFilter.Controls.Add(this.btnThongKe);
            this.pnlFilter.Controls.Add(this.dtpToDate);
            this.pnlFilter.Controls.Add(this.dtpFromDate);
            this.pnlFilter.Location = new System.Drawing.Point(25, 78);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1250, 62);
            this.pnlFilter.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(986, 20);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(52, 19);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Làm mới";
            this.btnReload.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(732, 19);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(154, 19);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "guna2Button1";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Checked = true;
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpToDate.Location = new System.Drawing.Point(401, 14);
            this.dtpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(218, 19);
            this.dtpToDate.TabIndex = 1;
            this.dtpToDate.Value = new System.DateTime(2025, 12, 27, 11, 42, 50, 366);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Checked = true;
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFromDate.Location = new System.Drawing.Point(57, 14);
            this.dtpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(211, 25);
            this.dtpFromDate.TabIndex = 0;
            this.dtpFromDate.Value = new System.DateTime(2025, 12, 27, 11, 42, 21, 171);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.pnlDoanhThu.Controls.Add(this.gndt);
            this.pnlDoanhThu.Location = new System.Drawing.Point(32, 172);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Size = new System.Drawing.Size(350, 80);
            this.pnlDoanhThu.TabIndex = 3;
            this.pnlDoanhThu.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(17, 47);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(53, 15);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "Doanh thu";
            // 
            // gndt
            // 
            this.gndt.BackColor = System.Drawing.Color.Transparent;
            this.gndt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gndt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gndt.Location = new System.Drawing.Point(17, 11);
            this.gndt.Name = "gndt";
            this.gndt.Size = new System.Drawing.Size(96, 19);
            this.gndt.TabIndex = 0;
            this.gndt.Text = "Tổng doanh thu";
            // 
            // pnlSoLuong
            // 
            this.pnlSoLuong.Controls.Add(this.lblTongSoLuong);
            this.pnlSoLuong.Controls.Add(this.gnslb);
            this.pnlSoLuong.Location = new System.Drawing.Point(433, 171);
            this.pnlSoLuong.Name = "pnlSoLuong";
            this.pnlSoLuong.Size = new System.Drawing.Size(413, 81);
            this.pnlSoLuong.TabIndex = 4;
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblTongSoLuong.Location = new System.Drawing.Point(20, 48);
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(45, 15);
            this.lblTongSoLuong.TabIndex = 1;
            this.lblTongSoLuong.Text = "Số lượng";
            // 
            // gnslb
            // 
            this.gnslb.BackColor = System.Drawing.Color.Transparent;
            this.gnslb.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gnslb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gnslb.Location = new System.Drawing.Point(14, 12);
            this.gnslb.Name = "gnslb";
            this.gnslb.Size = new System.Drawing.Size(115, 19);
            this.gnslb.TabIndex = 0;
            this.gnslb.Text = "Tổng số lượng bán\r\n";
            // 
            // pnlBanChay
            // 
            this.pnlBanChay.Controls.Add(this.lblBanChay);
            this.pnlBanChay.Controls.Add(this.gnbcn);
            this.pnlBanChay.Location = new System.Drawing.Point(932, 172);
            this.pnlBanChay.Name = "pnlBanChay";
            this.pnlBanChay.Size = new System.Drawing.Size(320, 79);
            this.pnlBanChay.TabIndex = 5;
            // 
            // lblBanChay
            // 
            this.lblBanChay.BackColor = System.Drawing.Color.Transparent;
            this.lblBanChay.Location = new System.Drawing.Point(28, 46);
            this.lblBanChay.Name = "lblBanChay";
            this.lblBanChay.Size = new System.Drawing.Size(48, 15);
            this.lblBanChay.TabIndex = 1;
            this.lblBanChay.Text = "Bán chạy";
            // 
            // gnbcn
            // 
            this.gnbcn.BackColor = System.Drawing.Color.Transparent;
            this.gnbcn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbcn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gnbcn.Location = new System.Drawing.Point(16, 10);
            this.gnbcn.Name = "gnbcn";
            this.gnbcn.Size = new System.Drawing.Size(112, 19);
            this.gnbcn.TabIndex = 0;
            this.gnbcn.Text = "Loại bán chạy nhất";
            this.gnbcn.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // pnlDM
            // 
            this.pnlDM.Controls.Add(this.lblDanhMuc);
            this.pnlDM.Controls.Add(this.dgvDanhMuc);
            this.pnlDM.Location = new System.Drawing.Point(32, 294);
            this.pnlDM.Name = "pnlDM";
            this.pnlDM.Size = new System.Drawing.Size(1220, 385);
            this.pnlDM.TabIndex = 7;
            // 
            // dgvDanhMuc
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDanhMuc.ColumnHeadersHeight = 4;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDanhMuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.Location = new System.Drawing.Point(2, 61);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.Size = new System.Drawing.Size(814, 321);
            this.dgvDanhMuc.TabIndex = 0;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhMuc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDanhMuc.ThemeStyle.ReadOnly = false;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhMuc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhMuc.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMuc.ForeColor = System.Drawing.Color.Navy;
            this.lblDanhMuc.Location = new System.Drawing.Point(14, 16);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(190, 27);
            this.lblDanhMuc.TabIndex = 1;
            this.lblDanhMuc.Text = "CHI TIẾT DANH MỤC";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.pnlDM);
            this.Controls.Add(this.pnlBanChay);
            this.Controls.Add(this.pnlSoLuong);
            this.Controls.Add(this.pnlDoanhThu);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.pnlFilter.ResumeLayout(false);
            this.pnlDoanhThu.ResumeLayout(false);
            this.pnlDoanhThu.PerformLayout();
            this.pnlSoLuong.ResumeLayout(false);
            this.pnlSoLuong.PerformLayout();
            this.pnlBanChay.ResumeLayout(false);
            this.pnlBanChay.PerformLayout();
            this.pnlDM.ResumeLayout(false);
            this.pnlDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnlFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFromDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpToDate;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2Panel pnlDoanhThu;
        private Guna.UI2.WinForms.Guna2Panel pnlSoLuong;
        private Guna.UI2.WinForms.Guna2Panel pnlBanChay;
        private Guna.UI2.WinForms.Guna2HtmlLabel gndt;
        private Guna.UI2.WinForms.Guna2HtmlLabel gnslb;
        private Guna.UI2.WinForms.Guna2HtmlLabel gnbcn;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongDoanhThu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongSoLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBanChay;
        private Guna.UI2.WinForms.Guna2Panel pnlDM;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhMuc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDanhMuc;
    }
}