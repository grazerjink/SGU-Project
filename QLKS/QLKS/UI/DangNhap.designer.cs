namespace QLKS.UI
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
            this.components = new System.ComponentModel.Container();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblErrorTaiKhoan = new System.Windows.Forms.Label();
            this.lblErrorMatKhau = new System.Windows.Forms.Label();
            this.errorTaiKhoan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMatKhau = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.Location = new System.Drawing.Point(17, 26);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(73, 13);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "Tên tài khoản";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Location = new System.Drawing.Point(38, 59);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(52, 13);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(101, 23);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(8, 3, 15, 3);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(179, 20);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(101, 56);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(8, 3, 15, 3);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(179, 20);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblQuenMatKhau
            // 
            this.lblQuenMatKhau.AutoSize = true;
            this.lblQuenMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblQuenMatKhau.Location = new System.Drawing.Point(91, 98);
            this.lblQuenMatKhau.Name = "lblQuenMatKhau";
            this.lblQuenMatKhau.Size = new System.Drawing.Size(89, 13);
            this.lblQuenMatKhau.TabIndex = 4;
            this.lblQuenMatKhau.TabStop = true;
            this.lblQuenMatKhau.Text = "Quên mật khẩu ?";
            this.lblQuenMatKhau.Click += new System.EventHandler(this.khoiPhucMatKhau);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDangNhap.Location = new System.Drawing.Point(186, 91);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(94, 26);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.dangNhapHeThong);
            // 
            // lblErrorTaiKhoan
            // 
            this.lblErrorTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.lblErrorTaiKhoan.Name = "lblErrorTaiKhoan";
            this.lblErrorTaiKhoan.Size = new System.Drawing.Size(100, 23);
            this.lblErrorTaiKhoan.TabIndex = 1;
            // 
            // lblErrorMatKhau
            // 
            this.lblErrorMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMatKhau.Location = new System.Drawing.Point(0, 0);
            this.lblErrorMatKhau.Name = "lblErrorMatKhau";
            this.lblErrorMatKhau.Size = new System.Drawing.Size(100, 23);
            this.lblErrorMatKhau.TabIndex = 0;
            // 
            // errorTaiKhoan
            // 
            this.errorTaiKhoan.BlinkRate = 300;
            this.errorTaiKhoan.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTaiKhoan.ContainerControl = this;
            // 
            // errorMatKhau
            // 
            this.errorMatKhau.BlinkRate = 300;
            this.errorMatKhau.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorMatKhau.ContainerControl = this;
            // 
            // DangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 129);
            this.Controls.Add(this.lblErrorMatKhau);
            this.Controls.Add(this.lblErrorTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblQuenMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.MaximumSize = new System.Drawing.Size(320, 168);
            this.MinimumSize = new System.Drawing.Size(320, 168);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.errorTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        public System.Windows.Forms.TextBox txtTaiKhoan;
        public System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.LinkLabel lblQuenMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblErrorTaiKhoan;
        private System.Windows.Forms.Label lblErrorMatKhau;
        private System.Windows.Forms.ErrorProvider errorTaiKhoan;
        private System.Windows.Forms.ErrorProvider errorMatKhau;
    }
}