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
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            moTaLabel.Location = new System.Drawing.Point(28, 218);
            moTaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            moTaLabel.Name = "moTaLabel";
            moTaLabel.Size = new System.Drawing.Size(52, 17);
            moTaLabel.TabIndex = 23;
            moTaLabel.Text = "Mo Ta:";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Location = new System.Drawing.Point(48, 180);
            giaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(34, 17);
            giaLabel.TabIndex = 21;
            giaLabel.Text = "Gia:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(15, 121);
            soLuongLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(73, 17);
            soLuongLabel.TabIndex = 19;
            soLuongLabel.Text = "So Luong:";
            // 
            // tenSPLabel
            // 
            tenSPLabel.AutoSize = true;
            tenSPLabel.Location = new System.Drawing.Point(28, 81);
            tenSPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tenSPLabel.Name = "tenSPLabel";
            tenSPLabel.Size = new System.Drawing.Size(59, 17);
            tenSPLabel.TabIndex = 17;
            tenSPLabel.Text = "Ten SP:";
            // 
            // maSPLabel
            // 
            maSPLabel.AutoSize = true;
            maSPLabel.Location = new System.Drawing.Point(28, 32);
            maSPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            maSPLabel.Name = "maSPLabel";
            maSPLabel.Size = new System.Drawing.Size(53, 17);
            maSPLabel.TabIndex = 15;
            maSPLabel.Text = "Ma SP:";
            // 
            // dtvsp
            // 
            this.dtvsp.AllowUserToAddRows = false;
            this.dtvsp.AllowUserToDeleteRows = false;
            this.dtvsp.AutoGenerateColumns = false;
            this.dtvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.Gia,
            this.MoTa});
            this.dtvsp.DataSource = this.dsSPBindingSource;
            this.dtvsp.Location = new System.Drawing.Point(16, 282);
            this.dtvsp.Margin = new System.Windows.Forms.Padding(4);
            this.dtvsp.MultiSelect = false;
            this.dtvsp.Name = "dtvsp";
            this.dtvsp.ReadOnly = true;
            this.dtvsp.Size = new System.Drawing.Size(712, 220);
            this.dtvsp.TabIndex = 0;
            this.dtvsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvsp_CellClick);
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
            this.btXoa.Location = new System.Drawing.Point(355, 172);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(111, 48);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(355, 41);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(111, 48);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(355, 108);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(111, 48);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập mã cần tìm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(503, 94);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(225, 69);
            this.txtTim.TabIndex = 13;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(561, 172);
            this.btTim.Margin = new System.Windows.Forms.Padding(4);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(117, 52);
            this.btTim.TabIndex = 14;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // txtMoTa
            // 
            this.txtMoTa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPBindingSource, "MoTa", true));
            this.txtMoTa.Location = new System.Drawing.Point(91, 214);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(221, 38);
            this.txtMoTa.TabIndex = 24;
            // 
            // txtGia
            // 
            this.txtGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPBindingSource, "Gia", true));
            this.txtGia.Location = new System.Drawing.Point(91, 164);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(221, 42);
            this.txtGia.TabIndex = 22;
            this.txtGia.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPBindingSource, "SoLuong", true));
            this.txtSoLuong.Location = new System.Drawing.Point(91, 117);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(221, 38);
            this.txtSoLuong.TabIndex = 20;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPBindingSource, "TenSP", true));
            this.txtTenSP.Location = new System.Drawing.Point(91, 66);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(221, 42);
            this.txtTenSP.TabIndex = 18;
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // txtMaSP
            // 
            this.txtMaSP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPBindingSource, "MaSP", true));
            this.txtMaSP.Location = new System.Drawing.Point(91, 17);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(221, 41);
            this.txtMaSP.TabIndex = 16;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "TenSP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Gia";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "MoTa";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // Danhsachsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 517);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Danhsachsanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
    }
}