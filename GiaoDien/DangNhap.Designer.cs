﻿namespace GiaoDien
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
            this.textBoxTENTK = new System.Windows.Forms.TextBox();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.btdangki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(29, 44);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(95, 17);
            this.labelTK.TabIndex = 0;
            this.labelTK.Text = "Tên tài khoản";
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Location = new System.Drawing.Point(29, 80);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(66, 17);
            this.z.TabIndex = 1;
            this.z.Text = "Mật khẩu";
            // 
            // textBoxTENTK
            // 
            this.textBoxTENTK.Location = new System.Drawing.Point(144, 44);
            this.textBoxTENTK.Name = "textBoxTENTK";
            this.textBoxTENTK.Size = new System.Drawing.Size(172, 22);
            this.textBoxTENTK.TabIndex = 2;
            // 
            // textBoxMK
            // 
            this.textBoxMK.Location = new System.Drawing.Point(144, 77);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(172, 22);
            this.textBoxMK.TabIndex = 3;
            // 
            // btdangnhap
            // 
            this.btdangnhap.Location = new System.Drawing.Point(48, 118);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(102, 37);
            this.btdangnhap.TabIndex = 4;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            // 
            // btdangki
            // 
            this.btdangki.Location = new System.Drawing.Point(214, 118);
            this.btdangki.Name = "btdangki";
            this.btdangki.Size = new System.Drawing.Size(102, 37);
            this.btdangki.TabIndex = 5;
            this.btdangki.Text = "Đăng ký";
            this.btdangki.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 167);
            this.Controls.Add(this.btdangki);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.textBoxMK);
            this.Controls.Add(this.textBoxTENTK);
            this.Controls.Add(this.z);
            this.Controls.Add(this.labelTK);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTK;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.TextBox textBoxTENTK;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Button btdangki;
    }
}