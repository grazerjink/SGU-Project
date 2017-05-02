namespace QLKS.UI
{
    partial class TinhTrang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblTinhTrang = new System.Windows.Forms.DataGridView();
            this.sttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phong1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblTinhTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblTinhTrang
            // 
            this.tblTinhTrang.AllowUserToResizeColumns = false;
            this.tblTinhTrang.AllowUserToResizeRows = false;
            this.tblTinhTrang.AutoGenerateColumns = false;
            this.tblTinhTrang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTinhTrang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblTinhTrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblTinhTrang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttDataGridViewTextBoxColumn,
            this.phong1DataGridViewTextBoxColumn,
            this.loaiphongDataGridViewTextBoxColumn,
            this.tienphongDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewTextBoxColumn});
            this.tblTinhTrang.DataSource = this.phongBindingSource;
            this.tblTinhTrang.EnableHeadersVisualStyles = false;
            this.tblTinhTrang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tblTinhTrang.Location = new System.Drawing.Point(0, 0);
            this.tblTinhTrang.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tblTinhTrang.MultiSelect = false;
            this.tblTinhTrang.Name = "tblTinhTrang";
            this.tblTinhTrang.ReadOnly = true;
            this.tblTinhTrang.RowHeadersVisible = false;
            this.tblTinhTrang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblTinhTrang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTinhTrang.Size = new System.Drawing.Size(460, 393);
            this.tblTinhTrang.TabIndex = 1;
            this.tblTinhTrang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.hienThiTrangThaiMau);
            this.tblTinhTrang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chonPhong);
            // 
            // sttDataGridViewTextBoxColumn
            // 
            this.sttDataGridViewTextBoxColumn.DataPropertyName = "stt";
            this.sttDataGridViewTextBoxColumn.FillWeight = 60F;
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
            // phongBindingSource
            // 
            this.phongBindingSource.DataSource = typeof(DAO.phong);
            // 
            // TinhTrang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblTinhTrang);
            this.Location = new System.Drawing.Point(10, 12);
            this.Name = "TinhTrang";
            this.Size = new System.Drawing.Size(460, 393);
            ((System.ComponentModel.ISupportInitialize)(this.tblTinhTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView tblTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phong1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource phongBindingSource;
    }
}
