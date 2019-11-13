namespace GiaoDien
{
    partial class DangNhap
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
            this.labelTK = new System.Windows.Forms.Label();
            this.z = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtTenMK = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btdangki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(29, 44);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(95, 17);
            this.labelTK.TabIndex = 4;
            this.labelTK.Text = "Tên tài khoản";
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Location = new System.Drawing.Point(29, 80);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(66, 17);
            this.z.TabIndex = 5;
            this.z.Text = "Mật khẩu";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(144, 44);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(172, 22);
            this.txtTenTK.TabIndex = 0;
            this.txtTenTK.TextChanged += new System.EventHandler(this.txtTenTK_TextChanged);
            // 
            // txtTenMK
            // 
            this.txtTenMK.Location = new System.Drawing.Point(144, 77);
            this.txtTenMK.Name = "txtTenMK";
            this.txtTenMK.Size = new System.Drawing.Size(172, 22);
            this.txtTenMK.TabIndex = 1;
            this.txtTenMK.TextChanged += new System.EventHandler(this.txtTenMK_TextChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(48, 118);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(102, 37);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btdangki
            // 
            this.btdangki.Location = new System.Drawing.Point(214, 118);
            this.btdangki.Name = "btdangki";
            this.btdangki.Size = new System.Drawing.Size(102, 37);
            this.btdangki.TabIndex = 3;
            this.btdangki.Text = "Đăng ký";
            this.btdangki.UseVisualStyleBackColor = true;
            this.btdangki.Click += new System.EventHandler(this.btdangki_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 181);
            this.Controls.Add(this.btdangki);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtTenMK);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.z);
            this.Controls.Add(this.labelTK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTK;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtTenMK;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btdangki;
    }
}