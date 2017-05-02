namespace QLKS.UI
{
    partial class KhoiPhuc
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlDoiMatKhau = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.errorMatKhauMoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNhapLai = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDoiMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatKhauMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhapLai)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(24, 20);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(249, 17);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Nhập email đăng kí hoặc số điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(14, 50);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 15, 5, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(79, 100);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(70, 3, 70, 3);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(139, 34);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.khoiPhucMatKhau);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(65, 73);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(250, 15);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Email hay số điện thoại đăng ký không đúng.";
            // 
            // pnlDoiMatKhau
            // 
            this.pnlDoiMatKhau.Controls.Add(this.label1);
            this.pnlDoiMatKhau.Controls.Add(this.btnHuy);
            this.pnlDoiMatKhau.Controls.Add(this.btnOK);
            this.pnlDoiMatKhau.Controls.Add(this.txtNhapLai);
            this.pnlDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.pnlDoiMatKhau.Controls.Add(this.lblNhapLai);
            this.pnlDoiMatKhau.Controls.Add(this.lblMatKhauMoi);
            this.pnlDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.pnlDoiMatKhau.Name = "pnlDoiMatKhau";
            this.pnlDoiMatKhau.Size = new System.Drawing.Size(297, 146);
            this.pnlDoiMatKhau.TabIndex = 6;
            this.pnlDoiMatKhau.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(80, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu mới";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(49, 107);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(97, 27);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.huyKhoiPhuc);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(152, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 27);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.doiMatKhauMoi);
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(131, 71);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(139, 20);
            this.txtNhapLai.TabIndex = 1;
            this.txtNhapLai.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(131, 43);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(139, 20);
            this.txtMatKhauMoi.TabIndex = 0;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Location = new System.Drawing.Point(13, 74);
            this.lblNhapLai.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(112, 13);
            this.lblNhapLai.TabIndex = 0;
            this.lblNhapLai.Text = "Nhập lại mật khẩu mới";
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(13, 46);
            this.lblMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(99, 13);
            this.lblMatKhauMoi.TabIndex = 0;
            this.lblMatKhauMoi.Text = "Nhập mật khẩu mới";
            // 
            // errorMatKhauMoi
            // 
            this.errorMatKhauMoi.ContainerControl = this;
            // 
            // errorNhapLai
            // 
            this.errorNhapLai.ContainerControl = this;
            // 
            // KhoiPhuc
            // 
            this.AcceptButton = this.btnXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 146);
            this.Controls.Add(this.pnlDoiMatKhau);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTieuDe);
            this.MaximumSize = new System.Drawing.Size(313, 185);
            this.MinimumSize = new System.Drawing.Size(313, 185);
            this.Name = "KhoiPhuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khôi phục mật khẩu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.thoatChucNang);
            this.pnlDoiMatKhau.ResumeLayout(false);
            this.pnlDoiMatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatKhauMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhapLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlDoiMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.ErrorProvider errorMatKhauMoi;
        private System.Windows.Forms.ErrorProvider errorNhapLai;
    }
}