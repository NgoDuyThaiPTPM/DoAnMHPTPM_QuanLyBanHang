using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;

namespace DoAnMon_QuanLyBanHang
{
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }
        BLL_DAL_QLBH qlbh = new BLL_DAL_QLBH();

        string maSPDC;
        string tenSPDC;
        string maPNDC;
        double tong = 0;

        private void frmTaoDonNhapHang_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        Boolean kiemTra() {
            if (txtMaPN.Text != "") {
                if (cboNCC.Text != "") {
                    if (dtpkNgayNhap.Text != "") {
                        if (cboNV.Text != "") {
                            if (cboTinhTrang.Text != "") {
                                if (txtTongTien.Text != "")
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Không được để trống Tổng Tiền");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không được để trống Tình Trạng");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không được để trống Nhân Viên");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được để trống Ngày Nhập");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống Nhà Cung Cấp");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Không được để trống Phiếu Nhập");
                return false;
            }
        }

        void tinhTong() {
            tong = 0;
            for (int i = 0; i <= dtgvChiTietPN.Rows.Count - 1; i++) {
                tong = Convert.ToDouble(dtgvChiTietPN.Rows[i].Cells[2].Value.ToString().Trim()) * Convert.ToDouble(dtgvChiTietPN.Rows[i].Cells[3].Value.ToString().Trim()) + tong;
            }
            txtTongTien.Text = tong.ToString();
        }

        private bool kiemTraNhapCT() {
            if (txtDonGia.Text != "")
            {
                return true;
            }
            else {
                MessageBox.Show("Không được để trống đơn giá");
                return false;
            }
        }

        void boChonGrid() {
            dtgvChiTietPN.ClearSelection();
            dtgvPhieuNhap.ClearSelection();
            dtgvSanPham.ClearSelection();
        }

        void load_cbo() {
            cboNCC.DataSource = qlbh.loadDSNCC();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
            //cboNCC.SelectedIndex = 0;

            cboTinhTrang.Items.Add("Chưa Thanh Toán");
            cboTinhTrang.Items.Add("Đã Thanh Toán");
            //cboTinhTrang.SelectedIndex = 0;
        }

        void load_dataGrid() {
            dtgvSanPham.DataSource = qlbh.loadSPPhieuNhap();

            dtgvPhieuNhap.DataSource = qlbh.loadPhieuNhapHang();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            load_cbo();
            load_dataGrid();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (qlbh.kiemTraTrungPN(maPNDC, maSPDC) == true)
            {
                qlbh.themCTPN(maPNDC, maSPDC, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text));
                dtgvChiTietPN.DataSource = qlbh.loadChiTietPNTheoMa(maPNDC);
                tinhTong();
                qlbh.capNhatTongTien(maPNDC, (int)tong);
                load_dataGrid();
                MessageBox.Show("Thêm Thành Công");
            }
            else
                MessageBox.Show("Sản phẩm này đã đặt, bạn cần chọn sản phẩm khác");
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            if (kiemTra() == true) {
                if (qlbh.kt(txtMaPN.Text) == true)
                {
                    btnLuu.Enabled = true;
                    qlbh.themPhieuNhap(txtMaPN.Text, cboNCC.SelectedValue.ToString(), dtpkNgayNhap.Value, cboNV.SelectedValue.ToString(), cboTinhTrang.SelectedValue.ToString(), Convert.ToInt32(txtTongTien.Text));
                    MessageBox.Show("Thêm thành công");
                    load_dataGrid();
                    btnThemPhieuNhap.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Mã phiếu đặt hàng bị trùng");
                    txtMaPN.Focus();
                }
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (dtgvChiTietPN.SelectedCells.Count > 0) {
                int vt = dtgvChiTietPN.SelectedCells[0].RowIndex;
                qlbh.xoaCTPN(dtgvChiTietPN.Rows[vt].Cells[0].Value.ToString(), dtgvChiTietPN.Rows[vt].Cells[1].Value.ToString());
                dtgvChiTietPN.DataSource = qlbh.loadChiTietPNTheoMa(maPNDC);
                tinhTong();
                qlbh.capNhatTongTien(maPNDC, (int)tong);
                MessageBox.Show("Xóa Thành Công");
                load_dataGrid();
            }
        }

        private void dtgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvSanPham.SelectedCells.Count > 0) {
                int vitri = dtgvSanPham.SelectedCells[0].RowIndex;
                maSPDC = dtgvSanPham.Rows[vitri].Cells[0].Value.ToString().Trim();
                tenSPDC = dtgvSanPham.Rows[vitri].Cells[1].Value.ToString().Trim();
                txtDonViTinh.Text = dtgvSanPham.Rows[vitri].Cells[2].Value.ToString().Trim();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThemPhieuNhap.Enabled = true;
            txtTongTien.Text = "0";
            dtpkNgayNhap.Value = DateTime.Now;
            cboNV.Text = "NV01";
            txtMaPN.Text = qlbh.taoMaPhieuNhapHang();
        }

        private void dtgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            if (dtgvPhieuNhap.SelectedCells.Count > 0) {
                int vitri = dtgvPhieuNhap.SelectedCells[0].RowIndex;
                maPNDC = dtgvPhieuNhap.Rows[vitri].Cells[0].Value.ToString().Trim();
                txtMaPN.Text = maPNDC;
                cboNCC.Text = dtgvPhieuNhap.Rows[vitri].Cells[1].Value.ToString().Trim();
                cboNV.Text = dtgvPhieuNhap.Rows[vitri].Cells[2].Value.ToString().Trim();
                dtpkNgayNhap.Value = Convert.ToDateTime(dtgvPhieuNhap.Rows[vitri].Cells[3].Value.ToString().Trim());
                cboTinhTrang.Text = dtgvPhieuNhap.Rows[vitri].Cells[4].Value.ToString().Trim();
                txtTongTien.Text=dtgvPhieuNhap.Rows[vitri].Cells[5].Value.ToString().Trim();
                dtgvChiTietPN.DataSource = qlbh.loadChiTietPNTheoMa(maPNDC);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            qlbh.suaPhieuNhapHang(txtMaPN.Text, cboNCC.SelectedValue.ToString(), dtpkNgayNhap.Value, cboNV.SelectedValue.ToString(), cboTinhTrang.SelectedValue.ToString(), Convert.ToInt32(txtTongTien.Text.Replace(".0000", "").ToString().Trim()));
            MessageBox.Show("Sửa Thành Công");
            load_dataGrid();
        }

        private void dtgvChiTietPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && dtgvChiTietPN.CurrentCell.ColumnIndex == 1) {
                e.Handled = true;
                DataGridViewCell cell = dtgvChiTietPN.Rows[0].Cells[0];
                dtgvChiTietPN.CurrentCell = cell;
                dtgvChiTietPN.BeginEdit(true);
            }
        }

        private void dtgvChiTietPN_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvChiTietPN.SelectedCells.Count > 0) {
                int vt = dtgvChiTietPN.SelectedCells[0].RowIndex;
                maPNDC = dtgvChiTietPN.Rows[vt].Cells[0].Value.ToString().Trim();
                maSPDC = dtgvChiTietPN.Rows[vt].Cells[1].Value.ToString().Trim();
                txtSoLuong.Text = dtgvChiTietPN.Rows[vt].Cells[2].Value.ToString().Trim();
                txtDonGia.Text = dtgvChiTietPN.Rows[vt].Cells[3].Value.ToString().Trim();

            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNhapCT_Click(object sender, EventArgs e)
        {
            qlbh.suaCTPN(maPNDC, maSPDC, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text));
            dtgvChiTietPN.DataSource = qlbh.loadChiTietPNTheoMa(maPNDC);
            tinhTong();
            qlbh.capNhatTongTien(maPNDC, (int)tong);
            load_dataGrid();
            MessageBox.Show("Sửa thành công");
        }
    }
}
