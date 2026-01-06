namespace BaiTapLon_Nhom9_QuanLiCofffee
{
    partial class DSPhieuNhap
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnSuaPhieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(1125, 286);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách phiếu nhập";
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Location = new System.Drawing.Point(917, 326);
            this.btnThemPhieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(182, 51);
            this.btnThemPhieu.TabIndex = 2;
            this.btnThemPhieu.Text = "Thêm phiếu nhập";
            this.btnThemPhieu.UseVisualStyleBackColor = true;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Location = new System.Drawing.Point(427, 326);
            this.btnXoaPhieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(182, 51);
            this.btnXoaPhieu.TabIndex = 3;
            this.btnXoaPhieu.Text = "Xóa phiếu nhập";
            this.btnXoaPhieu.UseVisualStyleBackColor = true;
            // 
            // btnSuaPhieu
            // 
            this.btnSuaPhieu.Location = new System.Drawing.Point(672, 326);
            this.btnSuaPhieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSuaPhieu.Name = "btnSuaPhieu";
            this.btnSuaPhieu.Size = new System.Drawing.Size(182, 51);
            this.btnSuaPhieu.TabIndex = 4;
            this.btnSuaPhieu.Text = "Sửa phiếu nhập";
            this.btnSuaPhieu.UseVisualStyleBackColor = true;
            // 
            // DSPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 424);
            this.Controls.Add(this.btnSuaPhieu);
            this.Controls.Add(this.btnXoaPhieu);
            this.Controls.Add(this.btnThemPhieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSach);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DSPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSPhieuNhap";
            this.Load += new System.EventHandler(this.DSPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnSuaPhieu;
    }
}