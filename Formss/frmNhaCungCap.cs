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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        BLL_DAL_QLBH qlbh = new BLL_DAL_QLBH();
        private void ResetValues()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNCC.Enabled = true;
            txtTenNCC.Focus();
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mancc = txtMaNCC.Text;

                if (qlbh.kiemTraKhoaChinhNCC(mancc) == true)
                {
                    qlbh.xoakh(mancc);
                    MessageBox.Show("Xóa thành công");
                    dtgrvDSNCC.DataSource = qlbh.loadDSNCC();
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
            if (dtgrvDSNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return;
            }
            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
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

            string mancc = txtMaNCC.Text;
            string tenncc = txtTenNCC.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            if (qlbh.kiemTraKhoaChinhSP(mancc))
            {
                qlbh.suancc(mancc, tenncc, diachi, sdt);
                MessageBox.Show("Sửa thành công");
                dtgrvDSNCC.DataSource = qlbh.loadDSNCC();
            }
            else
            {
                MessageBox.Show("Không tồn tại thông tin cần sửa");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return;
            }
            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
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
            string mancc = txtMaNCC.Text;
            string tenncc = txtTenNCC.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;

            if (qlbh.kiemTraKhoaChinhNCC(mancc) == true)
            {
                MessageBox.Show("Đã trùng thông tin");
            }
            else
            {
                qlbh.themkh(mancc, tenncc, diachi, sdt);
                dtgrvDSNCC.DataSource = qlbh.loadDSNCC();
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
        public void loadNCC(){
            dtgrvDSNCC.DataSource = qlbh.loadDSNCC();
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            loadNCC();
        }

        private void dtgrvDSNCC_Click(object sender, EventArgs e)
        {

        }

        private void dtgrvDSNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dtgrvDSNCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dtgrvDSNCC.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dtgrvDSNCC.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dtgrvDSNCC.CurrentRow.Cells[3].Value.ToString();
        }

    }
}
