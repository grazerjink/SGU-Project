namespace QLKS.UI
{
    partial class CauHinh
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
            this.tblPhong = new System.Windows.Forms.DataGridView();
            this.sttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phong1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctmTuyChon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.grpCauHinh = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorPhong = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlThem = new System.Windows.Forms.Panel();
            this.pnlSua = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cboSuaTrangThai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuaTienPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cboSuaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSuaPhong = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhong)).BeginInit();
            this.ctmTuyChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.grpCauHinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhong)).BeginInit();
            this.pnlThem.SuspendLayout();
            this.pnlSua.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPhong
            // 
            this.tblPhong.AllowUserToResizeColumns = false;
            this.tblPhong.AllowUserToResizeRows = false;
            this.tblPhong.AutoGenerateColumns = false;
            this.tblPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttDataGridViewTextBoxColumn,
            this.phong1DataGridViewTextBoxColumn,
            this.loaiphongDataGridViewTextBoxColumn,
            this.tienphongDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewTextBoxColumn});
            this.tblPhong.ContextMenuStrip = this.ctmTuyChon;
            this.tblPhong.DataSource = this.phongBindingSource;
            this.tblPhong.EnableHeadersVisualStyles = false;
            this.tblPhong.Location = new System.Drawing.Point(12, 38);
            this.tblPhong.Name = "tblPhong";
            this.tblPhong.ReadOnly = true;
            this.tblPhong.RowHeadersVisible = false;
            this.tblPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPhong.Size = new System.Drawing.Size(412, 361);
            this.tblPhong.TabIndex = 0;
            this.tblPhong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.hienThiMauTrangThai);
            this.tblPhong.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.chonTuyChon);
            // 
            // sttDataGridViewTextBoxColumn
            // 
            this.sttDataGridViewTextBoxColumn.DataPropertyName = "stt";
            this.sttDataGridViewTextBoxColumn.FillWeight = 45F;
            this.sttDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sttDataGridViewTextBoxColumn.Name = "sttDataGridViewTextBoxColumn";
            this.sttDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phong1DataGridViewTextBoxColumn
            // 
            this.phong1DataGridViewTextBoxColumn.DataPropertyName = "phong1";
            this.phong1DataGridViewTextBoxColumn.HeaderText = "Phòng";
            this.phong1DataGridViewTextBoxColumn.Name = "phong1DataGridViewTextBoxColumn";
            this.phong1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiphongDataGridViewTextBoxColumn
            // 
            this.loaiphongDataGridViewTextBoxColumn.DataPropertyName = "loaiphong";
            this.loaiphongDataGridViewTextBoxColumn.HeaderText = "Loại phòng";
            this.loaiphongDataGridViewTextBoxColumn.Name = "loaiphongDataGridViewTextBoxColumn";
            this.loaiphongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tienphongDataGridViewTextBoxColumn
            // 
            this.tienphongDataGridViewTextBoxColumn.DataPropertyName = "tienphong";
            this.tienphongDataGridViewTextBoxColumn.HeaderText = "Tiền phòng";
            this.tienphongDataGridViewTextBoxColumn.Name = "tienphongDataGridViewTextBoxColumn";
            this.tienphongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangthaiDataGridViewTextBoxColumn
            // 
            this.trangthaiDataGridViewTextBoxColumn.DataPropertyName = "trangthai";
            this.trangthaiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangthaiDataGridViewTextBoxColumn.Name = "trangthaiDataGridViewTextBoxColumn";
            this.trangthaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ctmTuyChon
            // 
            this.ctmTuyChon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSua,
            this.mnuXoa});
            this.ctmTuyChon.Name = "ctmTuyChon";
            this.ctmTuyChon.Size = new System.Drawing.Size(161, 48);
            // 
            // mnuSua
            // 
            this.mnuSua.Image = global::QLKS.Properties.Resources.edit_ic;
            this.mnuSua.Name = "mnuSua";
            this.mnuSua.Size = new System.Drawing.Size(160, 22);
            this.mnuSua.Text = "Cập nhật phòng";
            this.mnuSua.Click += new System.EventHandler(this.chonChucNangSuaPhong);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Image = global::QLKS.Properties.Resources.cancel_ic;
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(160, 22);
            this.mnuXoa.Text = "Xóa phòng";
            this.mnuXoa.Click += new System.EventHandler(this.chonChucNangXoaPhong);
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataSource = typeof(DAO.phong);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(196, 31);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm phòng mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.themPhongMoi);
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(72, 32);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(116, 20);
            this.txtPhong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại phòng";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Đơn",
            "Đôi",
            "Ba",
            "Bốn"});
            this.cboLoaiPhong.Location = new System.Drawing.Point(72, 65);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(116, 21);
            this.cboLoaiPhong.TabIndex = 6;
            this.cboLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.chonLoaiPhong);
            // 
            // grpCauHinh
            // 
            this.grpCauHinh.Controls.Add(this.cboTrangThai);
            this.grpCauHinh.Controls.Add(this.label4);
            this.grpCauHinh.Controls.Add(this.txtTienPhong);
            this.grpCauHinh.Controls.Add(this.label3);
            this.grpCauHinh.Controls.Add(this.label1);
            this.grpCauHinh.Controls.Add(this.btnThem);
            this.grpCauHinh.Controls.Add(this.cboLoaiPhong);
            this.grpCauHinh.Controls.Add(this.label2);
            this.grpCauHinh.Controls.Add(this.txtPhong);
            this.grpCauHinh.Location = new System.Drawing.Point(0, 0);
            this.grpCauHinh.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.grpCauHinh.Name = "grpCauHinh";
            this.grpCauHinh.Size = new System.Drawing.Size(206, 225);
            this.grpCauHinh.TabIndex = 8;
            this.grpCauHinh.TabStop = false;
            this.grpCauHinh.Text = "Cấu hình phòng";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Sẵn sàng",
            "Đang bảo trì"});
            this.cboTrangThai.Location = new System.Drawing.Point(72, 134);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(116, 21);
            this.cboTrangThai.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trạng thái";
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Location = new System.Drawing.Point(72, 100);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.ReadOnly = true;
            this.txtTienPhong.Size = new System.Drawing.Size(116, 20);
            this.txtTienPhong.TabIndex = 8;
            this.txtTienPhong.Text = "250000.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tiền phòng";
            // 
            // errorPhong
            // 
            this.errorPhong.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPhong.ContainerControl = this;
            // 
            // pnlThem
            // 
            this.pnlThem.Controls.Add(this.grpCauHinh);
            this.pnlThem.Location = new System.Drawing.Point(434, 82);
            this.pnlThem.Name = "pnlThem";
            this.pnlThem.Size = new System.Drawing.Size(206, 247);
            this.pnlThem.TabIndex = 9;
            // 
            // pnlSua
            // 
            this.pnlSua.Controls.Add(this.groupBox1);
            this.pnlSua.Location = new System.Drawing.Point(434, 82);
            this.pnlSua.Name = "pnlSua";
            this.pnlSua.Size = new System.Drawing.Size(208, 282);
            this.pnlSua.TabIndex = 10;
            this.pnlSua.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.cboSuaTrangThai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSuaTienPhong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.cboSuaLoaiPhong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSuaPhong);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 263);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình phòng";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(6, 220);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(196, 31);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.thoatSuaPhong);
            // 
            // cboSuaTrangThai
            // 
            this.cboSuaTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuaTrangThai.FormattingEnabled = true;
            this.cboSuaTrangThai.Items.AddRange(new object[] {
            "Sẵn sàng",
            "Đang bảo trì"});
            this.cboSuaTrangThai.Location = new System.Drawing.Point(72, 134);
            this.cboSuaTrangThai.Name = "cboSuaTrangThai";
            this.cboSuaTrangThai.Size = new System.Drawing.Size(116, 21);
            this.cboSuaTrangThai.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trạng thái";
            // 
            // txtSuaTienPhong
            // 
            this.txtSuaTienPhong.Location = new System.Drawing.Point(72, 100);
            this.txtSuaTienPhong.Name = "txtSuaTienPhong";
            this.txtSuaTienPhong.ReadOnly = true;
            this.txtSuaTienPhong.Size = new System.Drawing.Size(116, 20);
            this.txtSuaTienPhong.TabIndex = 8;
            this.txtSuaTienPhong.Text = "250000.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tiền phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số phòng";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(6, 183);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(196, 31);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.suaPhong);
            // 
            // cboSuaLoaiPhong
            // 
            this.cboSuaLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuaLoaiPhong.FormattingEnabled = true;
            this.cboSuaLoaiPhong.Items.AddRange(new object[] {
            "Đơn",
            "Đôi",
            "Ba",
            "Bốn"});
            this.cboSuaLoaiPhong.Location = new System.Drawing.Point(72, 65);
            this.cboSuaLoaiPhong.Name = "cboSuaLoaiPhong";
            this.cboSuaLoaiPhong.Size = new System.Drawing.Size(116, 21);
            this.cboSuaLoaiPhong.TabIndex = 6;
            this.cboSuaLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.chonSuaLoaiPhong);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Loại phòng";
            // 
            // txtSuaPhong
            // 
            this.txtSuaPhong.Location = new System.Drawing.Point(72, 32);
            this.txtSuaPhong.Name = "txtSuaPhong";
            this.txtSuaPhong.ReadOnly = true;
            this.txtSuaPhong.Size = new System.Drawing.Size(116, 20);
            this.txtSuaPhong.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoiMatKhau});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Image = global::QLKS.Properties.Resources.change_ic;
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(106, 20);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.doiMatKhau);
            // 
            // CauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 411);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlSua);
            this.Controls.Add(this.pnlThem);
            this.Controls.Add(this.tblPhong);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(666, 450);
            this.MinimumSize = new System.Drawing.Size(666, 450);
            this.Name = "CauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.thoatCauHinh);
            ((System.ComponentModel.ISupportInitialize)(this.tblPhong)).EndInit();
            this.ctmTuyChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.grpCauHinh.ResumeLayout(false);
            this.grpCauHinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhong)).EndInit();
            this.pnlThem.ResumeLayout(false);
            this.pnlSua.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.GroupBox grpCauHinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorPhong;
        private System.Windows.Forms.ContextMenuStrip ctmTuyChon;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.Panel pnlThem;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel pnlSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSuaTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuaTienPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cboSuaLoaiPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSuaPhong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phong1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
    }
}