using DAO;

namespace QLKS.UI
{
    partial class ThuePhong
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
            this.btnLuuLai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dateNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.errorCMND = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDienThoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNgay = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Location = new System.Drawing.Point(606, 382);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(119, 32);
            this.btnLuuLai.TabIndex = 5;
            this.btnLuuLai.Text = "Lưu lại";
            this.btnLuuLai.UseVisualStyleBackColor = true;
            this.btnLuuLai.Click += new System.EventHandler(this.themPhieuThuePhong);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblDienThoai);
            this.groupBox1.Controls.Add(this.lblCMND);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(485, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 140);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(98, 101);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(116, 20);
            this.txtDienThoai.TabIndex = 4;
            this.txtDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(98, 32);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(116, 20);
            this.txtCMND.TabIndex = 2;
            this.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCMND.TextChanged += new System.EventHandler(this.kiemTraCMND);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(98, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(116, 20);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(6, 104);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lblDienThoai.TabIndex = 0;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(6, 35);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(39, 13);
            this.lblCMND.TabIndex = 0;
            this.lblCMND.Text = "CMND";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(6, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(86, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Tên khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.lblMaNV);
            this.groupBox2.Controls.Add(this.dateNgayTra);
            this.groupBox2.Controls.Add(this.lblNgayTra);
            this.groupBox2.Controls.Add(this.txtPhong);
            this.groupBox2.Controls.Add(this.lblPhong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(485, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 127);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thuê phòng";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(102, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(112, 20);
            this.txtMaNV.TabIndex = 0;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(10, 28);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(40, 13);
            this.lblMaNV.TabIndex = 10;
            this.lblMaNV.Text = "Mã NV";
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dateNgayTra.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayTra.Location = new System.Drawing.Point(102, 60);
            this.dateNgayTra.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateNgayTra.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(112, 20);
            this.dateNgayTra.TabIndex = 1;
            this.dateNgayTra.Value = new System.DateTime(2017, 4, 18, 0, 0, 0, 0);
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.Location = new System.Drawing.Point(10, 62);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(47, 13);
            this.lblNgayTra.TabIndex = 9;
            this.lblNgayTra.Text = "Ngày trả";
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(102, 94);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(112, 20);
            this.txtPhong.TabIndex = 0;
            this.txtPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(10, 97);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(38, 13);
            this.lblPhong.TabIndex = 6;
            this.lblPhong.Text = "Phòng";
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
            // errorNgay
            // 
            this.errorNgay.ContainerControl = this;
            // 
            // ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLuuLai);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(753, 465);
            this.MinimumSize = new System.Drawing.Size(753, 465);
            this.Name = "ThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.thoatThuePhong);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLuuLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONG1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANGTHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateNgayTra;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.ErrorProvider errorCMND;
        private System.Windows.Forms.ErrorProvider errorHoTen;
        private System.Windows.Forms.ErrorProvider errorDienThoai;
        private System.Windows.Forms.ErrorProvider errorNgay;
    }
}