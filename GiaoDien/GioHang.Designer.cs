namespace GiaoDien
{
    partial class GioHang
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
            this.btThanhToan = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(365, 271);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(104, 37);
            this.btThanhToan.TabIndex = 3;
            this.btThanhToan.Text = "Thanh Toan";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(253, 271);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(104, 37);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 183);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông tin đơn hàng";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.Control;
            this.label.Location = new System.Drawing.Point(12, 271);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 37);
            this.label.TabIndex = 6;
            this.label.Text = "Tổng giá:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(108, 274);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(138, 34);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.Text = "0";
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 367);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GioHang";
            this.Text = "GioHang";
            this.Load += new System.EventHandler(this.GioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}