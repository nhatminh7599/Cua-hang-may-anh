namespace GiaoDien
{
    partial class Form1
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
            System.Windows.Forms.Label Á;
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.dtvsp2 = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuaHangMayAnhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuaHangMayAnhDataSet = new GiaoDien.CuaHangMayAnhDataSet();
            this.dsSPTableAdapter = new GiaoDien.CuaHangMayAnhDataSetTableAdapters.DsSPTableAdapter();
            this.lbName = new System.Windows.Forms.Label();
            this.btQuanLy = new System.Windows.Forms.Button();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btGioHang = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            Á = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvsp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.BackColor = System.Drawing.Color.Beige;
            this.lbDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Location = new System.Drawing.Point(343, 67);
            this.lbDangNhap.Margin = new System.Windows.Forms.Padding(0);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(193, 58);
            this.lbDangNhap.TabIndex = 32;
            this.lbDangNhap.Text = "Đăng nhập";
            this.lbDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDangNhap.Click += new System.EventHandler(this.lbdangnhap_Click);
            // 
            // dtvsp2
            // 
            this.dtvsp2.AllowUserToAddRows = false;
            this.dtvsp2.AllowUserToDeleteRows = false;
            this.dtvsp2.AutoGenerateColumns = false;
            this.dtvsp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvsp2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn});
            this.dtvsp2.DataSource = this.dsSPBindingSource;
            this.dtvsp2.Location = new System.Drawing.Point(5, 239);
            this.dtvsp2.Name = "dtvsp2";
            this.dtvsp2.ReadOnly = true;
            this.dtvsp2.RowTemplate.Height = 24;
            this.dtvsp2.Size = new System.Drawing.Size(532, 227);
            this.dtvsp2.TabIndex = 33;
            this.dtvsp2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvsp2_CellContentClick);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "MoTa";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsSPBindingSource
            // 
            this.dsSPBindingSource.DataMember = "DsSP";
            this.dsSPBindingSource.DataSource = this.cuaHangMayAnhDataSetBindingSource;
            // 
            // cuaHangMayAnhDataSetBindingSource
            // 
            this.cuaHangMayAnhDataSetBindingSource.DataSource = this.cuaHangMayAnhDataSet;
            this.cuaHangMayAnhDataSetBindingSource.Position = 0;
            // 
            // cuaHangMayAnhDataSet
            // 
            this.cuaHangMayAnhDataSet.DataSetName = "CuaHangMayAnhDataSet";
            this.cuaHangMayAnhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSPTableAdapter
            // 
            this.dsSPTableAdapter.ClearBeforeFill = true;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Beige;
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(343, 67);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(193, 58);
            this.lbName.TabIndex = 36;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // btQuanLy
            // 
            this.btQuanLy.Enabled = false;
            this.btQuanLy.Location = new System.Drawing.Point(343, 128);
            this.btQuanLy.Name = "btQuanLy";
            this.btQuanLy.Size = new System.Drawing.Size(99, 40);
            this.btQuanLy.TabIndex = 37;
            this.btQuanLy.Text = "Quản lý";
            this.btQuanLy.UseVisualStyleBackColor = true;
            this.btQuanLy.Visible = false;
            this.btQuanLy.Click += new System.EventHandler(this.btQuanLy_Click);
            // 
            // btDangXuat
            // 
            this.btDangXuat.Enabled = false;
            this.btDangXuat.Location = new System.Drawing.Point(448, 128);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(89, 40);
            this.btDangXuat.TabIndex = 38;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.UseVisualStyleBackColor = true;
            this.btDangXuat.Visible = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(12, 126);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(16, 23);
            this.btTru.TabIndex = 49;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(67, 126);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(16, 23);
            this.btCong.TabIndex = 50;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(12, 74);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(70, 46);
            this.btThem.TabIndex = 51;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btGioHang
            // 
            this.btGioHang.Location = new System.Drawing.Point(13, 155);
            this.btGioHang.Name = "btGioHang";
            this.btGioHang.Size = new System.Drawing.Size(70, 46);
            this.btGioHang.TabIndex = 52;
            this.btGioHang.Text = "Giỏ hàng";
            this.btGioHang.UseVisualStyleBackColor = true;
            this.btGioHang.Click += new System.EventHandler(this.btGioHang_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(181, 135);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(70, 46);
            this.btTim.TabIndex = 48;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(34, 126);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(27, 23);
            this.txtSoLuong.TabIndex = 46;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(136, 74);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(157, 55);
            this.txtTim.TabIndex = 47;
            // 
            // Á
            // 
            Á.AllowDrop = true;
            Á.BackColor = System.Drawing.Color.Khaki;
            Á.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Á.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Á.ForeColor = System.Drawing.Color.Red;
            Á.Image = global::GiaoDien.Properties.Resources.istockphoto_470355658_1024x1024;
            Á.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            Á.Location = new System.Drawing.Point(-2, -1);
            Á.Name = "Á";
            Á.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            Á.Size = new System.Drawing.Size(556, 68);
            Á.TabIndex = 0;
            Á.Text = "THÍCH THÌ MUA KHÔNG THÍCH THÌ MUA\r\n\r\n\r\n";
            Á.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(545, 478);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btGioHang);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btDangXuat);
            this.Controls.Add(this.btQuanLy);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.dtvsp2);
            this.Controls.Add(Á);
            this.Controls.Add(this.lbDangNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mua hàng vô đây nè";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvsp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.DataGridView dtvsp2;
        private System.Windows.Forms.BindingSource cuaHangMayAnhDataSetBindingSource;
        private CuaHangMayAnhDataSet cuaHangMayAnhDataSet;
        private System.Windows.Forms.BindingSource dsSPBindingSource;
        private CuaHangMayAnhDataSetTableAdapters.DsSPTableAdapter dsSPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btQuanLy;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btGioHang;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTim;
    }
}

