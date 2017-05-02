using System;

namespace QLKS.UI
{
    partial class TraPhong
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
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNgayThue = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongNgayThue = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tblDichVu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongTienDichVu = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.sudungdichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tendichvuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudungdichvuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(283, 483);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(146, 32);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.thanhToan);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTieuDe.Location = new System.Drawing.Point(143, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(246, 20);
            this.lblTieuDe.TabIndex = 21;
            this.lblTieuDe.Text = "Thông tin hóa đơn thanh toán";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(103, 483);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(146, 32);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.huy);
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(377, 79);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(128, 20);
            this.txtPhong.TabIndex = 41;
            this.txtPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Phòng";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(377, 49);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(128, 20);
            this.txtMaNV.TabIndex = 39;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Lế tân thanh toán";
            // 
            // txtNgayThue
            // 
            this.txtNgayThue.Location = new System.Drawing.Point(377, 109);
            this.txtNgayThue.Name = "txtNgayThue";
            this.txtNgayThue.ReadOnly = true;
            this.txtNgayThue.Size = new System.Drawing.Size(128, 20);
            this.txtNgayThue.TabIndex = 31;
            this.txtNgayThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(122, 49);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.ReadOnly = true;
            this.txtNgayLap.Size = new System.Drawing.Size(128, 20);
            this.txtNgayLap.TabIndex = 27;
            this.txtNgayLap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ngày lập phiếu";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Blue;
            this.txtTongTien.Location = new System.Drawing.Point(377, 194);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(128, 21);
            this.txtTongTien.TabIndex = 36;
            this.txtTongTien.Text = "0.00 VNĐ";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tổng tiền";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(121, 109);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(128, 20);
            this.txtCMND.TabIndex = 28;
            this.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "CMND";
            // 
            // txtTongNgayThue
            // 
            this.txtTongNgayThue.Location = new System.Drawing.Point(377, 138);
            this.txtTongNgayThue.Name = "txtTongNgayThue";
            this.txtTongNgayThue.ReadOnly = true;
            this.txtTongNgayThue.Size = new System.Drawing.Size(128, 20);
            this.txtTongNgayThue.TabIndex = 35;
            this.txtTongNgayThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(121, 166);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(128, 20);
            this.txtDienThoai.TabIndex = 30;
            this.txtDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(121, 138);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(128, 20);
            this.txtHoTen.TabIndex = 29;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày thuê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tổng ngày thuê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(122, 79);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(128, 20);
            this.txtMaPhieu.TabIndex = 43;
            this.txtMaPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Mã phiếu thuê";
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Location = new System.Drawing.Point(377, 166);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.ReadOnly = true;
            this.txtTienPhong.Size = new System.Drawing.Size(128, 20);
            this.txtTienPhong.TabIndex = 46;
            this.txtTienPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Tiền phòng";
            // 
            // tblDichVu
            // 
            this.tblDichVu.AutoGenerateColumns = false;
            this.tblDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tendichvuDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.tongtienDataGridViewTextBoxColumn});
            this.tblDichVu.DataSource = this.sudungdichvuBindingSource;
            this.tblDichVu.EnableHeadersVisualStyles = false;
            this.tblDichVu.Location = new System.Drawing.Point(33, 231);
            this.tblDichVu.MultiSelect = false;
            this.tblDichVu.Name = "tblDichVu";
            this.tblDichVu.ReadOnly = true;
            this.tblDichVu.RowHeadersVisible = false;
            this.tblDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDichVu.Size = new System.Drawing.Size(472, 168);
            this.tblDichVu.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tổng tiền dịch vụ";
            // 
            // lblTongTienDichVu
            // 
            this.lblTongTienDichVu.AutoSize = true;
            this.lblTongTienDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTongTienDichVu.Location = new System.Drawing.Point(374, 407);
            this.lblTongTienDichVu.Name = "lblTongTienDichVu";
            this.lblTongTienDichVu.Size = new System.Drawing.Size(71, 16);
            this.lblTongTienDichVu.TabIndex = 49;
            this.lblTongTienDichVu.Text = "0.00 VNĐ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(236, 433);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "Tổng cộng ";
            // 
            // lblTongCong
            // 
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongCong.ForeColor = System.Drawing.Color.Red;
            this.lblTongCong.Location = new System.Drawing.Point(374, 433);
            this.lblTongCong.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(71, 16);
            this.lblTongCong.TabIndex = 51;
            this.lblTongCong.Text = "0.00 VNĐ";
            // 
            // sudungdichvuBindingSource
            // 
            this.sudungdichvuBindingSource.DataSource = typeof(DAO.sudungdichvu);
            // 
            // tendichvuDataGridViewTextBoxColumn
            // 
            this.tendichvuDataGridViewTextBoxColumn.DataPropertyName = "tendichvu";
            this.tendichvuDataGridViewTextBoxColumn.FillWeight = 130F;
            this.tendichvuDataGridViewTextBoxColumn.HeaderText = "Tên dịch vụ";
            this.tendichvuDataGridViewTextBoxColumn.Name = "tendichvuDataGridViewTextBoxColumn";
            this.tendichvuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.FillWeight = 70F;
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongtienDataGridViewTextBoxColumn
            // 
            this.tongtienDataGridViewTextBoxColumn.DataPropertyName = "tongtien";
            this.tongtienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongtienDataGridViewTextBoxColumn.Name = "tongtienDataGridViewTextBoxColumn";
            this.tongtienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 527);
            this.Controls.Add(this.lblTongCong);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTongTienDichVu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tblDichVu);
            this.Controls.Add(this.txtTienPhong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNgayThue);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongNgayThue);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnThanhToan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Activated += new System.EventHandler(this.hienThiChiTiet);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.thoatTraPhong);
            ((System.ComponentModel.ISupportInitialize)(this.tblDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudungdichvuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNgayThue;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongNgayThue;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView tblDichVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongTienDichVu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.BindingSource sudungdichvuBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendichvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
    }
}