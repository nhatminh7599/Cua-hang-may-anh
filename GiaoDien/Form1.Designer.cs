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
            this.lbphukien = new System.Windows.Forms.Label();
            this.lbfilm = new System.Windows.Forms.Label();
            this.lbmayanh = new System.Windows.Forms.Label();
            this.picboxphukien = new System.Windows.Forms.PictureBox();
            this.picboxfilm = new System.Windows.Forms.PictureBox();
            this.picboxmayanh = new System.Windows.Forms.PictureBox();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.dtvsp2 = new System.Windows.Forms.DataGridView();
            this.cuaHangMayAnhDataSet = new GiaoDien.CuaHangMayAnhDataSet();
            this.cuaHangMayAnhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSPTableAdapter = new GiaoDien.CuaHangMayAnhDataSetTableAdapters.DsSPTableAdapter();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Á = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxphukien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxfilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxmayanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvsp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPBindingSource)).BeginInit();
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
            Á.Size = new System.Drawing.Size(1012, 68);
            Á.TabIndex = 0;
            Á.Text = "THÍCH THÌ MUA KHÔNG THÍCH THÌ MUA\r\n\r\n\r\n";
            Á.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbphukien
            // 
            this.lbphukien.BackColor = System.Drawing.Color.Peru;
            this.lbphukien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphukien.Location = new System.Drawing.Point(545, 67);
            this.lbphukien.Name = "lbphukien";
            this.lbphukien.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.lbphukien.Size = new System.Drawing.Size(274, 85);
            this.lbphukien.TabIndex = 30;
            this.lbphukien.Text = "PHỤ KIỆN";
            this.lbphukien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbfilm
            // 
            this.lbfilm.BackColor = System.Drawing.Color.Peru;
            this.lbfilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfilm.Location = new System.Drawing.Point(271, 67);
            this.lbfilm.Name = "lbfilm";
            this.lbfilm.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.lbfilm.Size = new System.Drawing.Size(283, 85);
            this.lbfilm.TabIndex = 28;
            this.lbfilm.Text = "FILM";
            this.lbfilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbmayanh
            // 
            this.lbmayanh.BackColor = System.Drawing.Color.Peru;
            this.lbmayanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmayanh.Location = new System.Drawing.Point(-3, 67);
            this.lbmayanh.Name = "lbmayanh";
            this.lbmayanh.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.lbmayanh.Size = new System.Drawing.Size(274, 85);
            this.lbmayanh.TabIndex = 9;
            this.lbmayanh.Text = "MÁY ẢNH";
            this.lbmayanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picboxphukien
            // 
            this.picboxphukien.BackColor = System.Drawing.Color.Peru;
            this.picboxphukien.Image = global::GiaoDien.Properties.Resources.camera_bag1;
            this.picboxphukien.Location = new System.Drawing.Point(556, 67);
            this.picboxphukien.Name = "picboxphukien";
            this.picboxphukien.Size = new System.Drawing.Size(85, 85);
            this.picboxphukien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxphukien.TabIndex = 31;
            this.picboxphukien.TabStop = false;
            // 
            // picboxfilm
            // 
            this.picboxfilm.BackColor = System.Drawing.Color.Peru;
            this.picboxfilm.Image = global::GiaoDien.Properties.Resources.film;
            this.picboxfilm.Location = new System.Drawing.Point(282, 67);
            this.picboxfilm.Name = "picboxfilm";
            this.picboxfilm.Size = new System.Drawing.Size(85, 85);
            this.picboxfilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxfilm.TabIndex = 29;
            this.picboxfilm.TabStop = false;
            // 
            // picboxmayanh
            // 
            this.picboxmayanh.BackColor = System.Drawing.Color.Peru;
            this.picboxmayanh.Image = global::GiaoDien.Properties.Resources.photo_camera;
            this.picboxmayanh.Location = new System.Drawing.Point(8, 67);
            this.picboxmayanh.Name = "picboxmayanh";
            this.picboxmayanh.Size = new System.Drawing.Size(85, 85);
            this.picboxmayanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxmayanh.TabIndex = 27;
            this.picboxmayanh.TabStop = false;
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.BackColor = System.Drawing.Color.Peru;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Location = new System.Drawing.Point(815, 67);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lbDangNhap.Size = new System.Drawing.Size(195, 85);
            this.lbDangNhap.TabIndex = 32;
            this.lbDangNhap.Text = "ĐĂNG NHẬP";
            this.lbDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDangNhap.Click += new System.EventHandler(this.lbdangnhap_Click);
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Peru;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(815, 67);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lbName.Size = new System.Drawing.Size(195, 85);
            this.lbName.TabIndex = 32;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.Visible = false;
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // dtvsp2
            // 
            this.dtvsp2.AutoGenerateColumns = false;
            this.dtvsp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvsp2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn});
            this.dtvsp2.DataSource = this.dsSPBindingSource;
            this.dtvsp2.Location = new System.Drawing.Point(9, 162);
            this.dtvsp2.Name = "dtvsp2";
            this.dtvsp2.RowTemplate.Height = 24;
            this.dtvsp2.Size = new System.Drawing.Size(545, 270);
            this.dtvsp2.TabIndex = 33;
            // 
            // cuaHangMayAnhDataSet
            // 
            this.cuaHangMayAnhDataSet.DataSetName = "CuaHangMayAnhDataSet";
            this.cuaHangMayAnhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuaHangMayAnhDataSetBindingSource
            // 
            this.cuaHangMayAnhDataSetBindingSource.DataSource = this.cuaHangMayAnhDataSet;
            this.cuaHangMayAnhDataSetBindingSource.Position = 0;
            // 
            // dsSPBindingSource
            // 
            this.dsSPBindingSource.DataMember = "DsSP";
            this.dsSPBindingSource.DataSource = this.cuaHangMayAnhDataSetBindingSource;
            // 
            // dsSPTableAdapter
            // 
            this.dsSPTableAdapter.ClearBeforeFill = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1007, 444);
            this.Controls.Add(this.dtvsp2);
            this.Controls.Add(Á);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.picboxphukien);
            this.Controls.Add(this.lbphukien);
            this.Controls.Add(this.picboxfilm);
            this.Controls.Add(this.lbfilm);
            this.Controls.Add(this.picboxmayanh);
            this.Controls.Add(this.lbmayanh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mua hàng vô đây nè";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxphukien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxfilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxmayanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvsp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayAnhDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxmayanh;
        private System.Windows.Forms.PictureBox picboxfilm;
        private System.Windows.Forms.PictureBox picboxphukien;
        private System.Windows.Forms.Label lbphukien;
        private System.Windows.Forms.Label lbfilm;
        private System.Windows.Forms.Label lbmayanh;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label lbName;
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
    }
}

