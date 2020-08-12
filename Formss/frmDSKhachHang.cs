using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;

namespace DoAnMon_QuanLyBanHang.Formss
{
    public partial class frmDSKhachHang : Form
    {
        public frmDSKhachHang()
        {
            InitializeComponent();
        }
        BLL_DAL_QLBH qlbh = new BLL_DAL_QLBH();
        private void frmDSKhachHang_Load(object sender, EventArgs e)
        {
            loadDSKH();
        }

        public void loadDSKH() {
            dtgrvDSKH.DataSource = qlbh.loadDSKH();
        }

        private void dtgrvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dtgrvDSKH.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dtgrvDSKH.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dtgrvDSKH.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dtgrvDSKH.CurrentRow.Cells[3].Value.ToString();
        }
        private void ResetValues()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnNhapLai.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaKH.Enabled = true;
            txtTenKH.Focus();
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = txtMaKH.Text;

                if (qlbh.kiemTraKhoaChinhKH(makh) == true)
                {
                    qlbh.xoakh(makh);
                    MessageBox.Show("Xóa thành công");
                    dtgrvDSKH.DataSource = qlbh.loadDSKH();
                }
                else
                {
                    MessageBox.Show("Không tồn tại thông tin cần xóa");
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgrvDSKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            if (qlbh.kiemTraKhoaChinhSP(makh))
            {
                qlbh.suakh(makh, tenkh, diachi,sdt);
                MessageBox.Show("Sửa thành công");
                dtgrvDSKH.DataSource = qlbh.loadDSKH();
            }
            else
            {
                MessageBox.Show("Không tồn tại thông tin cần sửa");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            } 
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;

            if (qlbh.kiemTraKhoaChinhKH(makh) == true)
            {
                MessageBox.Show("Đã trùng thông tin");
            }
            else
            {
                qlbh.themkh(makh, tenkh, diachi, sdt);
                dtgrvDSKH.DataSource = qlbh.loadDSKH();
            } 
            ResetValues();
            btnLuu.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnNhapLai.Enabled = false;
            btnLuu.Enabled = false;
        }

    }
}
