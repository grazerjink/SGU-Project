namespace QLKS.UI
{
    partial class DoiMatKhau
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
            this.lblMatKhauHienTai = new System.Windows.Forms.Label();
            this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblMatKhauNhapLai = new System.Windows.Forms.Label();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblLoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMatKhauHienTai
            // 
            this.lblMatKhauHienTai.AutoSize = true;
            this.lblMatKhauHienTai.Location = new System.Drawing.Point(22, 67);
            this.lblMatKhauHienTai.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblMatKhauHienTai.Name = "lblMatKhauHienTai";
            this.lblMatKhauHienTai.Size = new System.Drawing.Size(89, 13);
            this.lblMatKhauHienTai.TabIndex = 6;
            this.lblMatKhauHienTai.Text = "Mật khẩu hiện tại";
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(145, 64);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(165, 20);
            this.txtMatKhauHienTai.TabIndex = 1;
            this.txtMatKhauHienTai.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(22, 105);
            this.lblMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(99, 13);
            this.lblMatKhauMoi.TabIndex = 6;
            this.lblMatKhauMoi.Text = "Nhập mật khẩu mới";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(145, 102);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(165, 20);
            this.txtMatKhauMoi.TabIndex = 2;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblMatKhauNhapLai
            // 
            this.lblMatKhauNhapLai.AutoSize = true;
            this.lblMatKhauNhapLai.Location = new System.Drawing.Point(22, 143);
            this.lblMatKhauNhapLai.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.lblMatKhauNhapLai.Name = "lblMatKhauNhapLai";
            this.lblMatKhauNhapLai.Size = new System.Drawing.Size(112, 13);
            this.lblMatKhauNhapLai.TabIndex = 6;
            this.lblMatKhauNhapLai.Text = "Nhập lại mật khẩu mới";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLai.Location = new System.Drawing.Point(145, 140);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(165, 21);
            this.txtNhapLai.TabIndex = 3;
            this.txtNhapLai.UseSystemPasswordChar = true;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(107, 24);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(115, 20);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Đổi mật khẩu";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(171, 208);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(97, 27);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.doiMatKhau);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(68, 208);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(97, 27);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.huy);
            // 
            // lblLoi
            // 
            this.lblLoi.AutoSize = true;
            this.lblLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoi.ForeColor = System.Drawing.Color.Red;
            this.lblLoi.Location = new System.Drawing.Point(125, 169);
            this.lblLoi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblLoi.Name = "lblLoi";
            this.lblLoi.Size = new System.Drawing.Size(0, 13);
            this.lblLoi.TabIndex = 6;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 251);
            this.Controls.Add(this.lblLoi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauHienTai);
            this.Controls.Add(this.lblMatKhauNhapLai);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMatKhauHienTai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(360, 290);
            this.MinimumSize = new System.Drawing.Size(360, 290);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.thoat);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatKhauHienTai;
        private System.Windows.Forms.TextBox txtMatKhauHienTai;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauNhapLai;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblLoi;
    }
}