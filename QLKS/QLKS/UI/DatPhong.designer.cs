using System;

namespace QLKS.UI
{
    partial class DatPhong
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
            this.lblNgayThue = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.dateNgayThue = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.dateNgayTra = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorCMND = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDienThoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLuuLai = new System.Windows.Forms.Button();
            this.errorNgay = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNgayThue = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgayThue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgayThue
            // 
            this.lblNgayThue.AutoSize = true;
            this.lblNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThue.Location = new System.Drawing.Point(6, 63);
            this.lblNgayThue.Name = "lblNgayThue";
            this.lblNgayThue.Size = new System.Drawing.Size(56, 13);
            this.lblNgayThue.TabIndex = 0;
            this.lblNgayThue.Text = "Ngày thuê";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(6, 130);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(38, 13);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "Phòng";
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(80, 127);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(139, 20);
            this.txtPhong.TabIndex = 6;
            this.txtPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateNgayThue
            // 
            this.dateNgayThue.CustomFormat = "dd/MM/yyyy";
            this.dateNgayThue.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayThue.Location = new System.Drawing.Point(80, 61);
            this.dateNgayThue.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateNgayThue.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateNgayThue.Name = "dateNgayThue";
            this.dateNgayThue.Size = new System.Drawing.Size(139, 20);
            this.dateNgayThue.TabIndex = 4;
            this.dateNgayThue.Value = new System.DateTime(2017, 4, 18, 0, 0, 0, 0);
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.Location = new System.Drawing.Point(6, 96);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(47, 13);
            this.lblNgayTra.TabIndex = 5;
            this.lblNgayTra.Text = "Ngày trả";
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dateNgayTra.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayTra.Location = new System.Drawing.Point(80, 93);
            this.dateNgayTra.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateNgayTra.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(139, 20);
            this.dateNgayTra.TabIndex = 5;
            this.dateNgayTra.Value = new System.DateTime(2017, 4, 18, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.lblMaNV);
            this.groupBox2.Controls.Add(this.dateNgayTra);
            this.groupBox2.Controls.Add(this.lblNgayTra);
            this.groupBox2.Controls.Add(this.dateNgayThue);
            this.groupBox2.Controls.Add(this.txtPhong);
            this.groupBox2.Controls.Add(this.lblPhong);
            this.groupBox2.Controls.Add(this.lblNgayThue);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(485, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 162);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đặt phòng";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(80, 28);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(139, 20);
            this.txtMaNV.TabIndex = 9;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(6, 31);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(40, 13);
            this.lblMaNV.TabIndex = 8;
            this.lblMaNV.Text = "Mã NV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(6, 63);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(6, 97);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lblDienThoai.TabIndex = 0;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(80, 60);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(139, 20);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(80, 94);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(139, 20);
            this.txtDienThoai.TabIndex = 3;
            this.txtDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmnd.Location = new System.Drawing.Point(6, 29);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(39, 13);
            this.lblCmnd.TabIndex = 7;
            this.lblCmnd.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(80, 26);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(139, 20);
            this.txtCMND.TabIndex = 1;
            this.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCMND.TextChanged += new System.EventHandler(this.kiemTraCMND);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.lblCmnd);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblDienThoai);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(485, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 129);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // errorCMND
            // 
            this.errorCMND.ContainerControl = this;
            // 
            // errorHoTen
            // 
            this.errorHoTen.ContainerControl = this;
            // 
            // errorDienThoai
            // 
            this.errorDienThoai.ContainerControl = this;
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Location = new System.Drawing.Point(606, 373);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(119, 32);
            this.btnLuuLai.TabIndex = 7;
            this.btnLuuLai.Text = "Lưu lại";
            this.btnLuuLai.UseVisualStyleBackColor = true;
            this.btnLuuLai.Click += new System.EventHandler(this.themPhieuDatPhong);
            // 
            // errorNgay
            // 
            this.errorNgay.ContainerControl = this;
            // 
            // errorNgayThue
            // 
            this.errorNgayThue.ContainerControl = this;
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLuuLai);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(753, 456);
            this.MinimumSize = new System.Drawing.Size(753, 456);
            this.Name = "DatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.thoatDatPhong);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgayThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNgayThue;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.DateTimePicker dateNgayThue;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.DateTimePicker dateNgayTra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ErrorProvider errorCMND;
        private System.Windows.Forms.ErrorProvider errorHoTen;
        private System.Windows.Forms.ErrorProvider errorDienThoai;
        private System.Windows.Forms.Button btnLuuLai;
        private System.Windows.Forms.ErrorProvider errorNgay;
        private System.Windows.Forms.ErrorProvider errorNgayThue;
    }
}