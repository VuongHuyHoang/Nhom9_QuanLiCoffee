namespace BaiTapLon_Nhom9_QuanLiCofffee
{
    partial class ThemDoUongcs
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.themDoUongDataSet = new BaiTapLon_Nhom9_QuanLiCofffee.ThemDoUongDataSet();
            this.doUongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doUongTableAdapter = new BaiTapLon_Nhom9_QuanLiCofffee.ThemDoUongDataSetTableAdapters.DoUongTableAdapter();
            this.tableAdapterManager = new BaiTapLon_Nhom9_QuanLiCofffee.ThemDoUongDataSetTableAdapters.TableAdapterManager();
            this.maDoUongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoUongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDanhMucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhMucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhMucTableAdapter = new BaiTapLon_Nhom9_QuanLiCofffee.ThemDoUongDataSetTableAdapters.DanhMucTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themDoUongDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doUongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 511);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1116, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đồ uống";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDoUongDataGridViewTextBoxColumn,
            this.tenDoUongDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.maDanhMucDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doUongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(583, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(595, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 400);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 142);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.numericUpDown1);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(0, 192);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(512, 57);
            this.panel8.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(195, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(314, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.comboBox1);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(0, 129);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(512, 57);
            this.panel7.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Silver;
            this.comboBox1.DataSource = this.danhMucBindingSource;
            this.comboBox1.DisplayMember = "TenDanhMuc";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "MaDanhMuc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Mục:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(0, 66);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(515, 57);
            this.panel6.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.Location = new System.Drawing.Point(192, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(317, 22);
            this.textBox3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Món:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(512, 57);
            this.panel5.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(195, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(314, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(589, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 68);
            this.panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(3, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(398, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 53);
            this.button5.TabIndex = 0;
            this.button5.Text = "Tìm";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button6);
            this.panel9.Controls.Add(this.button7);
            this.panel9.Controls.Add(this.button8);
            this.panel9.Controls.Add(this.button9);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(583, 70);
            this.panel9.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 70);
            this.button6.TabIndex = 0;
            this.button6.Text = "Thêm";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(431, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 70);
            this.button7.TabIndex = 3;
            this.button7.Text = "Xem";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.Location = new System.Drawing.Point(140, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 70);
            this.button8.TabIndex = 1;
            this.button8.Text = "Sửa";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.Location = new System.Drawing.Point(276, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 70);
            this.button9.TabIndex = 2;
            this.button9.Text = "Xóa";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // themDoUongDataSet
            // 
            this.themDoUongDataSet.DataSetName = "ThemDoUongDataSet";
            this.themDoUongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doUongBindingSource
            // 
            this.doUongBindingSource.DataMember = "DoUong";
            this.doUongBindingSource.DataSource = this.themDoUongDataSet;
            // 
            // doUongTableAdapter
            // 
            this.doUongTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DanhMucTableAdapter = this.danhMucTableAdapter;
            this.tableAdapterManager.DoUongTableAdapter = this.doUongTableAdapter;
            this.tableAdapterManager.UpdateOrder = BaiTapLon_Nhom9_QuanLiCofffee.ThemDoUongDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maDoUongDataGridViewTextBoxColumn
            // 
            this.maDoUongDataGridViewTextBoxColumn.DataPropertyName = "MaDoUong";
            this.maDoUongDataGridViewTextBoxColumn.HeaderText = "MaDoUong";
            this.maDoUongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDoUongDataGridViewTextBoxColumn.Name = "maDoUongDataGridViewTextBoxColumn";
            // 
            // tenDoUongDataGridViewTextBoxColumn
            // 
            this.tenDoUongDataGridViewTextBoxColumn.DataPropertyName = "TenDoUong";
            this.tenDoUongDataGridViewTextBoxColumn.HeaderText = "TenDoUong";
            this.tenDoUongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDoUongDataGridViewTextBoxColumn.Name = "tenDoUongDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // maDanhMucDataGridViewTextBoxColumn
            // 
            this.maDanhMucDataGridViewTextBoxColumn.DataPropertyName = "MaDanhMuc";
            this.maDanhMucDataGridViewTextBoxColumn.HeaderText = "MaDanhMuc";
            this.maDanhMucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDanhMucDataGridViewTextBoxColumn.Name = "maDanhMucDataGridViewTextBoxColumn";
            // 
            // hinhAnhDataGridViewTextBoxColumn
            // 
            this.hinhAnhDataGridViewTextBoxColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewTextBoxColumn.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hinhAnhDataGridViewTextBoxColumn.Name = "hinhAnhDataGridViewTextBoxColumn";
            // 
            // danhMucBindingSource
            // 
            this.danhMucBindingSource.DataMember = "DanhMuc";
            this.danhMucBindingSource.DataSource = this.themDoUongDataSet;
            // 
            // danhMucTableAdapter
            // 
            this.danhMucTableAdapter.ClearBeforeFill = true;
            // 
            // ThemDoUongcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 550);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThemDoUongcs";
            this.Text = "ThemDoUongcs";
            this.Load += new System.EventHandler(this.ThemDoUongcs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.themDoUongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doUongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ThemDoUongDataSet themDoUongDataSet;
        private System.Windows.Forms.BindingSource doUongBindingSource;
        private ThemDoUongDataSetTableAdapters.DoUongTableAdapter doUongTableAdapter;
        private ThemDoUongDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoUongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoUongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDanhMucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhAnhDataGridViewTextBoxColumn;
        private ThemDoUongDataSetTableAdapters.DanhMucTableAdapter danhMucTableAdapter;
        private System.Windows.Forms.BindingSource danhMucBindingSource;
    }
}