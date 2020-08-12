using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace DoAnMon_QuanLyBanHang.Formss
{
    public partial class frmBanHang : Form
    {
        QLBHDataContext ql = new QLBHDataContext();
        BLL_DAL_QLBH qlbh = new BLL_DAL_QLBH();
        string maHDDC;
        string tenSPDC;
        string maSPDC;
        string maNV = "NV01";
        double tong = 0;
        public frmBanHang()
        {
            InitializeComponent();
        }
        Boolean kiemTra() {
            if (txtMaHD.Text != "") {
                if (dtpkNgayLap.Text != "") {
                    if (cboMaNV.Text != "") {
                        if (txtTenNV.Text != "") {
                            if (cboMaKH.Text != "") {
                                if (txtTenKH.Text != "") {
                                    if (txtDiaChi.Text != "") {
                                        if (txtSDT.Text != "") {
                                            return true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Không được để trống số điện thoại");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không được để trống địa chỉ");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không được để trống tên khách hàng");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không được để trống mã khách hàng");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không được để trống tên nhân viên");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được để trống mã nhân viên");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống ngày lập hóa đơn");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Không được để trống mã hóa đơn");
                return false;
            }

        }
        void tinhTong()
        {
            tong = 0;
            for (int i = 0; i <= dtgvChiTietHDBH.Rows.Count - 1; i++)
            {
                tong = Convert.ToDouble(dtgvChiTietHDBH.Rows[i].Cells[2].Value.ToString().Trim()) * Convert.ToDouble(dtgvChiTietHDBH.Rows[i].Cells[3].Value.ToString().Trim()) + tong;
            }
            txtTongTien.Text = tong.ToString();
        }
        private bool kiemTraNhapCT()
        {
            if (txtSoluong.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Không được để trống số lượng mua");
                return false;
            }

        }

        void boChonGrid()
        {
            dtgvChiTietHDBH.ClearSelection();
            dtgvTTHD.ClearSelection();
        }
        void load_cbo()
        {
            cboMaNV.DataSource = qlbh.loadNhanVien();
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
            //cboNCC.SelectedIndex = 0;

            cboMaKH.DataSource = qlbh.loadKhachHang();
            cboMaKH.DisplayMember = "MaKH";
            cboMaKH.ValueMember = "MaKH";
            //cboNCC.SelectedIndex = 0;

            cboMaSP.DataSource = qlbh.loadDtgvDSSP();
            cboMaSP.DisplayMember = "MaSP";
            cboMaSP.ValueMember = "MaSP";

        }
        void load_dataGrid()
        {
            dtgvTTHD.DataSource = qlbh.loadHD();
        }

        private void frmBanHang1_Load(object sender, EventArgs e)
        {
            load_cbo();
            load_dataGrid();
        }


        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }
        private void ResetValuesHang()
        {
            
        }

        private void dtgrvTTDH_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboMaKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboMaSP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemmoi_Click_1(object sender, EventArgs e)
        {
            if (kiemTra() == true)
            {
                if (qlbh.kthd(txtMaHD.Text) == true)
                {
                    qlbh.themHD(txtMaHD.Text, cboMaNV.SelectedValue.ToString(), cboMaKH.SelectedValue.ToString(), dtpkNgayLap.Value, txtTinhTrang.Text, Convert.ToInt32(txtTongTien.Text));
                    MessageBox.Show("Thêm thành công");
                    load_dataGrid();
                    btnThemmoi.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn bị trùng");
                    txtMaHD.Focus();
                }
            }
        }

        private void dtgvTTDH_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvTTHD.SelectedCells.Count > 0)
            {
                int vitri = dtgvTTHD.SelectedCells[0].RowIndex;
                maHDDC = dtgvTTHD.Rows[vitri].Cells[0].Value.ToString().Trim();
                txtMaHD.Text = maHDDC;
                cboMaNV.Text = dtgvTTHD.Rows[vitri].Cells[1].Value.ToString().Trim();
                cboMaKH.Text = dtgvTTHD.Rows[vitri].Cells[2].Value.ToString().Trim();
                dtpkNgayLap.Value = Convert.ToDateTime(dtgvTTHD.Rows[vitri].Cells[3].Value.ToString().Trim());
                txtTinhTrang.Text = dtgvTTHD.Rows[vitri].Cells[4].Value.ToString().Trim();
                txtTongTien.Text = dtgvTTHD.Rows[vitri].Cells[5].Value.ToString().Trim();
                dtgvTTHD.DataSource = qlbh.loadChiTietPNTheoMa(maHDDC);

            }
        }

        private void dtgvChiTietHDBH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && dtgvChiTietHDBH.CurrentCell.ColumnIndex == 1)
            {
                e.Handled = true;
                DataGridViewCell cell = dtgvChiTietHDBH.Rows[0].Cells[0];
                dtgvChiTietHDBH.CurrentCell = cell;
                dtgvChiTietHDBH.BeginEdit(true);
            }
        }

        private void dtgvChiTietHDBH_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvChiTietHDBH.SelectedCells.Count > 0)
            {
                int vt = dtgvChiTietHDBH.SelectedCells[0].RowIndex;
                maHDDC = dtgvChiTietHDBH.Rows[vt].Cells[0].Value.ToString().Trim();
                maSPDC = dtgvChiTietHDBH.Rows[vt].Cells[1].Value.ToString().Trim();
                txtSoluong.Text = dtgvChiTietHDBH.Rows[vt].Cells[2].Value.ToString().Trim();
                txtDonGia.Text = dtgvChiTietHDBH.Rows[vt].Cells[3].Value.ToString().Trim();

            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SanPham sanpham = (from sp in ql.SanPhams where sp.MaSP == cboMaSP.SelectedValue.ToString() select sp).FirstOrDefault();
            //txtTenSP.Text = sanpham.TenSP;
            //txtDonGia.Text = sanpham.DonGiaBan.ToString();
            //txtSLCon.Text = sanpham.SoLuong.ToString();

        }

        private void dtgvTTDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
