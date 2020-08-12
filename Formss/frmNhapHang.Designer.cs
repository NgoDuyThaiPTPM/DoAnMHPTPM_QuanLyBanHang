namespace DoAnMon_QuanLyBanHang
{
    partial class frmNhapHang
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
            this.grbPhieuNhapHang = new System.Windows.Forms.GroupBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.dtpkNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dtgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dtgvChiTietPN = new System.Windows.Forms.DataGridView();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThemPhieuNhap = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNhapCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.grbPhieuNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPhieuNhapHang
            // 
            this.grbPhieuNhapHang.Controls.Add(this.btnThemPhieuNhap);
            this.grbPhieuNhapHang.Controls.Add(this.btnLuu);
            this.grbPhieuNhapHang.Controls.Add(this.btnSua);
            this.grbPhieuNhapHang.Controls.Add(this.btnLamMoi);
            this.grbPhieuNhapHang.Controls.Add(this.dtpkNgayNhap);
            this.grbPhieuNhapHang.Controls.Add(this.cboTinhTrang);
            this.grbPhieuNhapHang.Controls.Add(this.cboNV);
            this.grbPhieuNhapHang.Controls.Add(this.cboNCC);
            this.grbPhieuNhapHang.Controls.Add(this.txtGhiChu);
            this.grbPhieuNhapHang.Controls.Add(this.txtMaPN);
            this.grbPhieuNhapHang.Controls.Add(this.txtTongTien);
            this.grbPhieuNhapHang.Controls.Add(this.label4);
            this.grbPhieuNhapHang.Controls.Add(this.lblNgayNhap);
            this.grbPhieuNhapHang.Controls.Add(this.label3);
            this.grbPhieuNhapHang.Controls.Add(this.lblGhiChu);
            this.grbPhieuNhapHang.Controls.Add(this.lblTongTien);
            this.grbPhieuNhapHang.Controls.Add(this.lblMaPN);
            this.grbPhieuNhapHang.Controls.Add(this.lblTinhTrang);
            this.grbPhieuNhapHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbPhieuNhapHang.Location = new System.Drawing.Point(0, 0);
            this.grbPhieuNhapHang.Margin = new System.Windows.Forms.Padding(2);
            this.grbPhieuNhapHang.Name = "grbPhieuNhapHang";
            this.grbPhieuNhapHang.Padding = new System.Windows.Forms.Padding(2);
            this.grbPhieuNhapHang.Size = new System.Drawing.Size(340, 619);
            this.grbPhieuNhapHang.TabIndex = 0;
            this.grbPhieuNhapHang.TabStop = false;
            this.grbPhieuNhapHang.Text = "Phiếu Nhập Hàng";
            this.grbPhieuNhapHang.Enter += new System.EventHandler(this.frmTaoDonNhapHang_Enter);
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(13, 98);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(2);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(284, 21);
            this.cboNCC.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(13, 297);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(287, 20);
            this.txtGhiChu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhân Viên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(11, 276);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(45, 13);
            this.lblGhiChu.TabIndex = 0;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(11, 226);
            this.lblTinhTrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(59, 13);
            this.lblTinhTrang.TabIndex = 0;
            this.lblTinhTrang.Text = "Tình Trạng";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(9, 127);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(61, 13);
            this.lblNgayNhap.TabIndex = 0;
            this.lblNgayNhap.Text = "Ngày Nhập";
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(13, 197);
            this.cboNV.Margin = new System.Windows.Forms.Padding(2);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(284, 21);
            this.cboNV.TabIndex = 3;
            // 
            // dtpkNgayNhap
            // 
            this.dtpkNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayNhap.Location = new System.Drawing.Point(13, 148);
            this.dtpkNgayNhap.Name = "dtpkNgayNhap";
            this.dtpkNgayNhap.Size = new System.Drawing.Size(136, 20);
            this.dtpkNgayNhap.TabIndex = 4;
            // 
            // dtgvPhieuNhap
            // 
            this.dtgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNhap.Location = new System.Drawing.Point(355, 12);
            this.dtgvPhieuNhap.Name = "dtgvPhieuNhap";
            this.dtgvPhieuNhap.Size = new System.Drawing.Size(623, 274);
            this.dtgvPhieuNhap.TabIndex = 1;
            this.dtgvPhieuNhap.SelectionChanged += new System.EventHandler(this.dtgvPhieuNhap_SelectionChanged);
            // 
            // dtgvChiTietPN
            // 
            this.dtgvChiTietPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietPN.Location = new System.Drawing.Point(355, 292);
            this.dtgvChiTietPN.Name = "dtgvChiTietPN";
            this.dtgvChiTietPN.Size = new System.Drawing.Size(623, 274);
            this.dtgvChiTietPN.TabIndex = 1;
            this.dtgvChiTietPN.SelectionChanged += new System.EventHandler(this.dtgvChiTietPN_SelectionChanged);
            this.dtgvChiTietPN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgvChiTietPN_KeyDown);
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Location = new System.Drawing.Point(999, 12);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.Size = new System.Drawing.Size(376, 274);
            this.dtgvSanPham.TabIndex = 1;
            this.dtgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSanPham_CellContentClick);
            this.dtgvSanPham.SelectionChanged += new System.EventHandler(this.dtgvSanPham_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.txtDonViTinh);
            this.panel1.Controls.Add(this.lblDonGia);
            this.panel1.Controls.Add(this.lblDVT);
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Location = new System.Drawing.Point(999, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 274);
            this.panel1.TabIndex = 2;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(22, 28);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(53, 13);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(22, 149);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(65, 13);
            this.lblDVT.TabIndex = 0;
            this.lblDVT.Text = "Đơn Vị Tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(25, 176);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(165, 20);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(22, 88);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(46, 13);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(25, 115);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(165, 20);
            this.txtDonGia.TabIndex = 1;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // lblMaPN
            // 
            this.lblMaPN.AutoSize = true;
            this.lblMaPN.Location = new System.Drawing.Point(11, 28);
            this.lblMaPN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(81, 13);
            this.lblMaPN.TabIndex = 0;
            this.lblMaPN.Text = "Mã Phiếu Nhập";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(13, 49);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(287, 20);
            this.txtMaPN.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(12, 325);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(56, 13);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(14, 346);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(287, 20);
            this.txtTongTien.TabIndex = 2;
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(11, 247);
            this.cboTinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(284, 21);
            this.cboTinhTrang.TabIndex = 3;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(127, 223);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(116, 36);
            this.btnThemSP.TabIndex = 3;
            this.btnThemSP.Text = "Thêm Sản Phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(15, 398);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(116, 36);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới Phiếu Nhập";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThemPhieuNhap
            // 
            this.btnThemPhieuNhap.Location = new System.Drawing.Point(185, 398);
            this.btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            this.btnThemPhieuNhap.Size = new System.Drawing.Size(116, 36);
            this.btnThemPhieuNhap.TabIndex = 3;
            this.btnThemPhieuNhap.Text = "Thêm Phiếu Nhập";
            this.btnThemPhieuNhap.UseVisualStyleBackColor = true;
            this.btnThemPhieuNhap.Click += new System.EventHandler(this.btnThemPhieuNhap_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(15, 468);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa Phiếu Nhập";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(185, 468);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 36);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu Phiếu Nhập";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNhapCT
            // 
            this.btnNhapCT.Location = new System.Drawing.Point(367, 572);
            this.btnNhapCT.Name = "btnNhapCT";
            this.btnNhapCT.Size = new System.Drawing.Size(116, 36);
            this.btnNhapCT.TabIndex = 3;
            this.btnNhapCT.Text = "Nhập Chi Tiết";
            this.btnNhapCT.UseVisualStyleBackColor = true;
            this.btnNhapCT.Click += new System.EventHandler(this.btnNhapCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(844, 572);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(116, 36);
            this.btnXoaCT.TabIndex = 3;
            this.btnXoaCT.Text = "Xóa Chi Tiết ";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(25, 54);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(165, 20);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXoaCT);
            this.Controls.Add(this.btnNhapCT);
            this.Controls.Add(this.dtgvChiTietPN);
            this.Controls.Add(this.dtgvSanPham);
            this.Controls.Add(this.dtgvPhieuNhap);
            this.Controls.Add(this.grbPhieuNhapHang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhapHang";
            this.Text = "frmNhapHang";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.grbPhieuNhapHang.ResumeLayout(false);
            this.grbPhieuNhapHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPhieuNhapHang;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpkNgayNhap;
        private System.Windows.Forms.ComboBox cboNV;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dtgvPhieuNhap;
        private System.Windows.Forms.DataGridView dtgvChiTietPN;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnThemPhieuNhap;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnNhapCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}