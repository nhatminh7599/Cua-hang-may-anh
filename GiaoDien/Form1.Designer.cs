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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btQuanLy = new System.Windows.Forms.Button();
            this.btDangXuat = new System.Windows.Forms.Button();
            Á = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvsp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dtvsp2.Location = new System.Drawing.Point(5, 174);
            this.dtvsp2.Name = "dtvsp2";
            this.dtvsp2.ReadOnly = true;
            this.dtvsp2.RowTemplate.Height = 24;
            this.dtvsp2.Size = new System.Drawing.Size(532, 292);
            this.dtvsp2.TabIndex = 33;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 28);
            this.button2.TabIndex = 35;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 23);
            this.textBox2.TabIndex = 34;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(545, 478);
            this.Controls.Add(this.btDangXuat);
            this.Controls.Add(this.btQuanLy);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtvsp2);
            this.Controls.Add(Á);
            this.Controls.Add(this.lbDangNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btQuanLy;
        private System.Windows.Forms.Button btDangXuat;
    }
}

