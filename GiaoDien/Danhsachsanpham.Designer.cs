namespace GiaoDien
{
    partial class Danhsachsanpham
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
            System.Windows.Forms.Label moTaLabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label tenSPLabel;
            System.Windows.Forms.Label maSPLabel;
            this.dtvsp = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuaHangMayAnhDataSet = new GiaoDien.CuaHangMayAnhDataSet();
            this.dsSPTableAdapter = new GiaoDien.CuaHangMayAnhDataSetTableAdapters.DsSPTableAdapter();
            this.tableAdapterManager = new GiaoDien.CuaHangMayAnhDataSetTableAdapters.TableAdapterManager();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            moTaLabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            tenSPLabel = new System.Windows.Forms.Label();
            maSPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // moTaLabel
            // 
            moTaLabel.AutoSize = true;
            moTaLabel.Location = new System.Drawing.Point(21, 177);
            moTaLabel.Name = "moTaLabel";
            moTaLabel.Size = new System.Drawing.Size(41, 13);
            moTaLabel.TabIndex = 23;
            moTaLabel.Text = "Mo Ta:";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Location = new System.Drawing.Point(36, 146);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(26, 13);
            giaLabel.TabIndex = 21;
            giaLabel.Text = "Gia:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(11, 98);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(56, 13);
            soLuongLabel.TabIndex = 19;
            soLuongLabel.Text = "So Luong:";
            // 
            // tenSPLabel
            // 
            tenSPLabel.AutoSize = true;
            tenSPLabel.Location = new System.Drawing.Point(21, 66);
            tenSPLabel.Name = "tenSPLabel";
            tenSPLabel.Size = new System.Drawing.Size(46, 13);
            tenSPLabel.TabIndex = 17;
            tenSPLabel.Text = "Ten SP:";
            // 
            // maSPLabel
            // 
            maSPLabel.AutoSize = true;
            maSPLabel.Location = new System.Drawing.Point(21, 26);
            maSPLabel.Name = "maSPLabel";
            maSPLabel.Size = new System.Drawing.Size(42, 13);
            maSPLabel.TabIndex = 15;
            maSPLabel.Text = "Ma SP:";
            // 
            // dtvsp
            // 
            this.dtvsp.AutoGenerateColumns = false;
            this.dtvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn});
            this.dtvsp.DataSource = this.dsSPBindingSource;
            this.dtvsp.Location = new System.Drawing.Point(12, 229);
            this.dtvsp.Name = "dtvsp";
            this.dtvsp.Size = new System.Drawing.Size(551, 179);
            this.dtvsp.TabIndex = 0;
            this.dtvsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvsp_CellClick);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "MoTa";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            // 
            // dsSPBindingSource
            // 
            this.dsSPBindingSource.DataMember = "DsSP";
            this.dsSPBindingSource.DataSource = this.cuaHangMayAnhDataSet;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DsSPTableAdapter = this.dsSPTableAdapter;
            this.tableAdapterManager.UpdateOrder = GiaoDien.CuaHangMayAnhDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(266, 140);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(83, 39);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(266, 33);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(83, 39);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(266, 88);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(83, 39);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập mã cần tìm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(377, 76);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(170, 57);
            this.txtTim.TabIndex = 13;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(421, 140);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(88, 42);
            this.btTim.TabIndex = 14;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // txtMoTa
            // 
            this.txtMoTa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPBindingSource, "MoTa", true));
            this.txtMoTa.Location = new System.Drawing.Point(68, 174);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(167, 32);
            this.txtMoTa.TabIndex = 24;
            // 
            // txtGia
            // 
            this.txtGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPBindingSource, "Gia", true));
            this.txtGia.Location = new System.Drawing.Point(68, 133);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(167, 35);
            this.txtGia.TabIndex = 22;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPBindingSource, "SoLuong", true));
            this.txtSoLuong.Location = new System.Drawing.Point(68, 95);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(167, 32);
            this.txtSoLuong.TabIndex = 20;
            // 
            // txtTenSP
            // 
            this.txtTenSP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPBindingSource, "TenSP", true));
            this.txtTenSP.Location = new System.Drawing.Point(68, 54);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(167, 35);
            this.txtTenSP.TabIndex = 18;
            // 
            // txtMaSP
            // 
            this.txtMaSP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPBindingSource, "MaSP", true));
            this.txtMaSP.Location = new System.Drawing.Point(68, 14);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(167, 34);
            this.txtMaSP.TabIndex = 16;
            // 
            // Danhsachsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 420);
            this.Controls.Add(moTaLabel);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(giaLabel);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(soLuongLabel);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(tenSPLabel);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(maSPLabel);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.dtvsp);
            this.Name = "Danhsachsanpham";
            this.Text = "Danhsachsanpham";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Danhsachsanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvsp;
        private CuaHangMayAnhDataSet cuaHangMayAnhDataSet;
        private System.Windows.Forms.BindingSource dsSPBindingSource;
        private CuaHangMayAnhDataSetTableAdapters.DsSPTableAdapter dsSPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private CuaHangMayAnhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
    }
}