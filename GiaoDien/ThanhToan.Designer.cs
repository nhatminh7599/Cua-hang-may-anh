namespace GiaoDien
{
    partial class ThanhToan
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.btThanhtoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("iCiel Brandon Text Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(195, 46);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(286, 34);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Đơn hàng bạn đang có";
            // 
            // btThanhtoan
            // 
            this.btThanhtoan.Location = new System.Drawing.Point(495, 441);
            this.btThanhtoan.Name = "btThanhtoan";
            this.btThanhtoan.Size = new System.Drawing.Size(186, 39);
            this.btThanhtoan.TabIndex = 1;
            this.btThanhtoan.Text = "Thanh toán";
            this.btThanhtoan.UseVisualStyleBackColor = true;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 492);
            this.Controls.Add(this.btThanhtoan);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Button btThanhtoan;
    }
}