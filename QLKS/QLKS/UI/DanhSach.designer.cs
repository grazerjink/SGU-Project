using DAO;

namespace QLKS.UI
{
    partial class DanhSach
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
            this.ctmTrangThaiDat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDaHuy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.tabDatPhong = new System.Windows.Forms.TabControl();
            this.pageDatPhong = new System.Windows.Forms.TabPage();
            this.cbxDaDat = new System.Windows.Forms.CheckBox();
            this.tblDatPhong = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxDangThue = new System.Windows.Forms.CheckBox();
            this.tblThuePhong = new System.Windows.Forms.DataGridView();
            this.ctmTrangThaiThue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuThemDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmTrangThaiDat.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.tabDatPhong.SuspendLayout();
            this.pageDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatPhong)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblThuePhong)).BeginInit();
            this.ctmTrangThaiThue.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctmTrangThaiDat
            // 
            this.ctmTrangThaiDat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDaNhan,
            this.mnuDaHuy});
            this.ctmTrangThaiDat.Name = "contextMenuStrip1";
            this.ctmTrangThaiDat.Size = new System.Drawing.Size(119, 48);
            // 
            // mnuDaNhan
            // 
            this.mnuDaNhan.Image = global::QLKS.Properties.Resources.tick_ic;
            this.mnuDaNhan.Name = "mnuDaNhan";
            this.mnuDaNhan.Size = new System.Drawing.Size(118, 22);
            this.mnuDaNhan.Text = "Đã nhận";
            this.mnuDaNhan.Click += new System.EventHandler(this.trangThaiDaNhan);
            // 
            // mnuDaHuy
            // 
            this.mnuDaHuy.Image = global::QLKS.Properties.Resources.cancel_ic;
            this.mnuDaHuy.Name = "mnuDaHuy";
            this.mnuDaHuy.Size = new System.Drawing.Size(118, 22);
            this.mnuDaHuy.Text = "Đã hủy";
            this.mnuDaHuy.Click += new System.EventHandler(this.trangThaiDaHuy);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoiMatKhau});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 0;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "khachhang";
            this.dataGridViewTextBoxColumn1.FillWeight = 120F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 342;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "khachhang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Điện thoại";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 285;
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BackColor = System.Drawing.Color.White;
            this.pnlChucNang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlChucNang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChucNang.Controls.Add(this.lblMaNV);
            this.pnlChucNang.Controls.Add(this.btnDangXuat);
            this.pnlChucNang.Controls.Add(this.btnThuePhong);
            this.pnlChucNang.Controls.Add(this.btnDatPhong);
            this.pnlChucNang.Controls.Add(this.pnlLogo);
            this.pnlChucNang.Location = new System.Drawing.Point(705, 34);
            this.pnlChucNang.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Padding = new System.Windows.Forms.Padding(5);
            this.pnlChucNang.Size = new System.Drawing.Size(149, 466);
            this.pnlChucNang.TabIndex = 7;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Red;
            this.lblMaNV.Location = new System.Drawing.Point(8, 143);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(91, 16);
            this.lblMaNV.TabIndex = 11;
            this.lblMaNV.Text = "Mã NV : NV01";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BackgroundImage = global::QLKS.Properties.Resources.dangxuat;
            this.btnDangXuat.Location = new System.Drawing.Point(8, 412);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(129, 38);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.dangXuat);
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.BackColor = System.Drawing.Color.Transparent;
            this.btnThuePhong.BackgroundImage = global::QLKS.Properties.Resources.thuphong;
            this.btnThuePhong.Location = new System.Drawing.Point(8, 231);
            this.btnThuePhong.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(129, 38);
            this.btnThuePhong.TabIndex = 3;
            this.btnThuePhong.UseVisualStyleBackColor = false;
            this.btnThuePhong.Click += new System.EventHandler(this.thuePhong);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnDatPhong.BackgroundImage = global::QLKS.Properties.Resources.datphong;
            this.btnDatPhong.Location = new System.Drawing.Point(8, 175);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(129, 38);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.datPhong);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::QLKS.Properties.Resources.hotel_icon;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(8, 8);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(129, 120);
            this.pnlLogo.TabIndex = 1;
            // 
            // tabDatPhong
            // 
            this.tabDatPhong.Controls.Add(this.pageDatPhong);
            this.tabDatPhong.Controls.Add(this.tabPage2);
            this.tabDatPhong.Location = new System.Drawing.Point(12, 34);
            this.tabDatPhong.Name = "tabDatPhong";
            this.tabDatPhong.SelectedIndex = 0;
            this.tabDatPhong.Size = new System.Drawing.Size(687, 466);
            this.tabDatPhong.TabIndex = 9;
            // 
            // pageDatPhong
            // 
            this.pageDatPhong.BackColor = System.Drawing.Color.White;
            this.pageDatPhong.Controls.Add(this.cbxDaDat);
            this.pageDatPhong.Controls.Add(this.tblDatPhong);
            this.pageDatPhong.Location = new System.Drawing.Point(4, 22);
            this.pageDatPhong.Name = "pageDatPhong";
            this.pageDatPhong.Padding = new System.Windows.Forms.Padding(5);
            this.pageDatPhong.Size = new System.Drawing.Size(679, 440);
            this.pageDatPhong.TabIndex = 0;
            this.pageDatPhong.Text = "Danh sách phòng đặt";
            // 
            // cbxDaDat
            // 
            this.cbxDaDat.AutoSize = true;
            this.cbxDaDat.Location = new System.Drawing.Point(486, 15);
            this.cbxDaDat.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbxDaDat.Name = "cbxDaDat";
            this.cbxDaDat.Size = new System.Drawing.Size(183, 17);
            this.cbxDaDat.TabIndex = 10;
            this.cbxDaDat.Text = "Hiển thị phòng đặt ngày hôm nay";
            this.cbxDaDat.UseVisualStyleBackColor = true;
            this.cbxDaDat.CheckedChanged += new System.EventHandler(this.chonHienThiDanhSachPhongDatHienTai);
            // 
            // tblDatPhong
            // 
            this.tblDatPhong.AllowUserToResizeRows = false;
            this.tblDatPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDatPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblDatPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tblDatPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDatPhong.ContextMenuStrip = this.ctmTrangThaiDat;
            this.tblDatPhong.EnableHeadersVisualStyles = false;
            this.tblDatPhong.Location = new System.Drawing.Point(10, 40);
            this.tblDatPhong.Margin = new System.Windows.Forms.Padding(5);
            this.tblDatPhong.MultiSelect = false;
            this.tblDatPhong.Name = "tblDatPhong";
            this.tblDatPhong.ReadOnly = true;
            this.tblDatPhong.RowHeadersVisible = false;
            this.tblDatPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDatPhong.Size = new System.Drawing.Size(659, 390);
            this.tblDatPhong.TabIndex = 9;
            this.tblDatPhong.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.chonTrangThaiPhieuDat);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.cbxDangThue);
            this.tabPage2.Controls.Add(this.tblThuePhong);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách phòng thuê";
            // 
            // cbxDangThue
            // 
            this.cbxDangThue.AutoSize = true;
            this.cbxDangThue.Location = new System.Drawing.Point(428, 15);
            this.cbxDangThue.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbxDangThue.Name = "cbxDangThue";
            this.cbxDangThue.Size = new System.Drawing.Size(239, 17);
            this.cbxDangThue.TabIndex = 12;
            this.cbxDangThue.Text = "Hiển thị phòng cần thanh toán ngày hôm nay";
            this.cbxDangThue.UseVisualStyleBackColor = true;
            this.cbxDangThue.CheckedChanged += new System.EventHandler(this.chonHienThiDanhSachCanThanhToan);
            // 
            // tblThuePhong
            // 
            this.tblThuePhong.AllowUserToResizeRows = false;
            this.tblThuePhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblThuePhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblThuePhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tblThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblThuePhong.ContextMenuStrip = this.ctmTrangThaiThue;
            this.tblThuePhong.EnableHeadersVisualStyles = false;
            this.tblThuePhong.Location = new System.Drawing.Point(10, 40);
            this.tblThuePhong.Margin = new System.Windows.Forms.Padding(5);
            this.tblThuePhong.MultiSelect = false;
            this.tblThuePhong.Name = "tblThuePhong";
            this.tblThuePhong.ReadOnly = true;
            this.tblThuePhong.RowHeadersVisible = false;
            this.tblThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblThuePhong.Size = new System.Drawing.Size(659, 390);
            this.tblThuePhong.TabIndex = 11;
            this.tblThuePhong.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.chonTrangThaiPhieuThue);
            // 
            // ctmTrangThaiThue
            // 
            this.ctmTrangThaiThue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemDichVu,
            this.mnuTraPhong});
            this.ctmTrangThaiThue.Name = "contextMenuStrip1";
            this.ctmTrangThaiThue.Size = new System.Drawing.Size(148, 48);
            // 
            // mnuThemDichVu
            // 
            this.mnuThemDichVu.Image = global::QLKS.Properties.Resources.service_icon;
            this.mnuThemDichVu.Name = "mnuThemDichVu";
            this.mnuThemDichVu.Size = new System.Drawing.Size(147, 22);
            this.mnuThemDichVu.Text = "Thêm dịch vụ";
            this.mnuThemDichVu.Click += new System.EventHandler(this.themDichVu);
            // 
            // mnuTraPhong
            // 
            this.mnuTraPhong.Image = global::QLKS.Properties.Resources.bill_icon;
            this.mnuTraPhong.Name = "mnuTraPhong";
            this.mnuTraPhong.Size = new System.Drawing.Size(147, 22);
            this.mnuTraPhong.Text = "Trả phòng";
            this.mnuTraPhong.Click += new System.EventHandler(this.trangThaiThanhToan);
            // 
            // DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 508);
            this.Controls.Add(this.tabDatPhong);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(880, 551);
            this.MinimumSize = new System.Drawing.Size(880, 551);
            this.Name = "DanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí hệ thống khách sạn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.thoatChuongTrinh);
            this.ctmTrangThaiDat.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlChucNang.PerformLayout();
            this.tabDatPhong.ResumeLayout(false);
            this.pageDatPhong.ResumeLayout(false);
            this.pageDatPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatPhong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblThuePhong)).EndInit();
            this.ctmTrangThaiThue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ctmTrangThaiDat;
        private System.Windows.Forms.ToolStripMenuItem mnuDaNhan;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONGTHUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kHACHHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIENTHOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYNHANDataGridViewTextBoxColumn;*/
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripMenuItem mnuDaHuy;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.TabControl tabDatPhong;
        private System.Windows.Forms.TabPage pageDatPhong;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView tblDatPhong;
        public System.Windows.Forms.DataGridView tblThuePhong;
        private System.Windows.Forms.ContextMenuStrip ctmTrangThaiThue;
        private System.Windows.Forms.ToolStripMenuItem mnuTraPhong;
        public System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.CheckBox cbxDaDat;
        private System.Windows.Forms.CheckBox cbxDangThue;
        private System.Windows.Forms.ToolStripMenuItem mnuThemDichVu;
    }
}

