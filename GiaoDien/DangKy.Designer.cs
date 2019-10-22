namespace GiaoDien
{
    partial class DangKy
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
            this.btdangki = new System.Windows.Forms.Button();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.textBoxTENTK = new System.Windows.Forms.TextBox();
            this.z = new System.Windows.Forms.Label();
            this.labelTK = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btdangki
            // 
            this.btdangki.Location = new System.Drawing.Point(261, 195);
            this.btdangki.Name = "btdangki";
            this.btdangki.Size = new System.Drawing.Size(102, 37);
            this.btdangki.TabIndex = 11;
            this.btdangki.Text = "Đăng ký";
            this.btdangki.UseVisualStyleBackColor = true;
            // 
            // textBoxMK
            // 
            this.textBoxMK.Location = new System.Drawing.Point(163, 70);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(172, 22);
            this.textBoxMK.TabIndex = 9;
            // 
            // textBoxTENTK
            // 
            this.textBoxTENTK.Location = new System.Drawing.Point(163, 37);
            this.textBoxTENTK.Name = "textBoxTENTK";
            this.textBoxTENTK.Size = new System.Drawing.Size(172, 22);
            this.textBoxTENTK.TabIndex = 8;
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Location = new System.Drawing.Point(48, 73);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(66, 17);
            this.z.TabIndex = 7;
            this.z.Text = "Mật khẩu";
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(48, 37);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(95, 17);
            this.labelTK.TabIndex = 6;
            this.labelTK.Text = "Tên tài khoản";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Số điện thoại";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 253);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdangki);
            this.Controls.Add(this.textBoxMK);
            this.Controls.Add(this.textBoxTENTK);
            this.Controls.Add(this.z);
            this.Controls.Add(this.labelTK);
            this.Name = "DangKy";
            this.Text = "DangKi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdangki;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.TextBox textBoxTENTK;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.Label labelTK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}