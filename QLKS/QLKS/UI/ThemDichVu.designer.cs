namespace QLKS.UI
{
    partial class ThemDichVu
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
            this.lblMaPhieuThue = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtMaPhieuThue = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.listDichVu = new System.Windows.Forms.ListBox();
            this.tblSuDungDichVu = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.ctmTuyChon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblSuDungDichVu)).BeginInit();
            this.ctmTuyChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaPhieuThue
            // 
            this.lblMaPhieuThue.AutoSize = true;
            this.lblMaPhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuThue.Location = new System.Drawing.Point(213, 14);
            this.lblMaPhieuThue.Name = "lblMaPhieuThue";
            this.lblMaPhieuThue.Size = new System.Drawing.Size(91, 16);
            this.lblMaPhieuThue.TabIndex = 0;
            this.lblMaPhieuThue.Text = "Mã phiếu thuê";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(213, 40);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(47, 16);
            this.lblPhong.TabIndex = 1;
            this.lblPhong.Text = "Phòng";
            // 
            // txtMaPhieuThue
            // 
            this.txtMaPhieuThue.Location = new System.Drawing.Point(310, 13);
            this.txtMaPhieuThue.Name = "txtMaPhieuThue";
            this.txtMaPhieuThue.ReadOnly = true;
            this.txtMaPhieuThue.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhieuThue.TabIndex = 2;
            this.txtMaPhieuThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(310, 39);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(100, 20);
            this.txtPhong.TabIndex = 2;
            this.txtPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listDichVu
            // 
            this.listDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDichVu.FormattingEnabled = true;
            this.listDichVu.ItemHeight = 16;
            this.listDichVu.Location = new System.Drawing.Point(12, 12);
            this.listDichVu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.listDichVu.Name = "listDichVu";
            this.listDichVu.Size = new System.Drawing.Size(119, 356);
            this.listDichVu.TabIndex = 3;
            // 
            // tblSuDungDichVu
            // 
            this.tblSuDungDichVu.AllowUserToResizeColumns = false;
            this.tblSuDungDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSuDungDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblSuDungDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSuDungDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tendichvu,
            this.gia,
            this.soluong});
            this.tblSuDungDichVu.EnableHeadersVisualStyles = false;
            this.tblSuDungDichVu.Location = new System.Drawing.Point(216, 69);
            this.tblSuDungDichVu.Name = "tblSuDungDichVu";
            this.tblSuDungDichVu.RowHeadersVisible = false;
            this.tblSuDungDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSuDungDichVu.Size = new System.Drawing.Size(276, 267);
            this.tblSuDungDichVu.TabIndex = 4;
            this.tblSuDungDichVu.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.chonTuyChon);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(389, 342);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 26);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.xacNhan);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(137, 140);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(137, 157);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(72, 20);
            this.txtSoLuong.TabIndex = 7;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(137, 183);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(72, 23);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.chonDichVu);
            // 
            // ctmTuyChon
            // 
            this.ctmTuyChon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXoa});
            this.ctmTuyChon.Name = "ctmTuyChon";
            this.ctmTuyChon.Size = new System.Drawing.Size(95, 26);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Image = global::QLKS.Properties.Resources.cancel_ic;
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(94, 22);
            this.mnuXoa.Text = "Xóa";
            this.mnuXoa.Click += new System.EventHandler(this.xoaDichVu);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Visible = false;
            // 
            // tendichvu
            // 
            this.tendichvu.FillWeight = 120F;
            this.tendichvu.HeaderText = "Tên dịch vụ";
            this.tendichvu.Name = "tendichvu";
            // 
            // gia
            // 
            this.gia.HeaderText = "Đơn giá";
            this.gia.Name = "gia";
            // 
            // soluong
            // 
            this.soluong.FillWeight = 80F;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // ThemDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tblSuDungDichVu);
            this.Controls.Add(this.listDichVu);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtMaPhieuThue);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.lblMaPhieuThue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThemDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.thoatChucNang);
            ((System.ComponentModel.ISupportInitialize)(this.tblSuDungDichVu)).EndInit();
            this.ctmTuyChon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaPhieuThue;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtMaPhieuThue;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.ListBox listDichVu;
        private System.Windows.Forms.DataGridView tblSuDungDichVu;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ContextMenuStrip ctmTuyChon;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}