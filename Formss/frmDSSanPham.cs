using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using BLL_DAL;
using System.Data.SqlClient;

namespace DoAnMon_QuanLyBanHang
{
    public partial class frmDSSanPham : Form
    {
        QLBHDataContext db = new QLBHDataContext();
        BLL_DAL_QLBH qlbh = new BLL_DAL_QLBH();
        public frmDSSanPham()
        {
            InitializeComponent();
        }
        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {

        }

        private void frmDSSanPham_Load(object sender, EventArgs e)
        {
            loadTheme();
            loadDtgvDSSP();

            cboLoaiSP.Text = "";
            txtTenLoai.Text = "";
            btnLuu.Enabled = false;
            btnNhapLai.Enabled = false;
        }
        public static Image BinaryToImage(System.Data.Linq.Binary binaryData)
        {
            if (binaryData == null) return null;

            byte[] buffer = binaryData.ToArray();
            MemoryStream memStream = new MemoryStream();
            memStream.Write(buffer, 0, buffer.Length);
            return Image.FromStream(memStream);
        }
        SanPham sp = new SanPham();
        public void loadDtgvDSSP()
        {
            dtgvDSSP.DataSource = qlbh.loadDtgvDSSP();

        }

        private void dtgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadCboLoaiHH();
                Bitmap imgData = (Bitmap)dtgvDSSP.CurrentRow.Cells[3].Value;
                MemoryStream ms = new MemoryStream();
                imgData.Save(ms, ImageFormat.Jpeg);
                ptrBxHinhDD.Image = Image.FromStream(ms);
                ptrBxHinhDD.Image = Image.FromStream(ms);

                txtMaSP.Text = dtgvDSSP.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dtgvDSSP.CurrentRow.Cells[2].Value.ToString();
            lblHinhAnh.Text = dtgvDSSP.CurrentRow.Cells[2].Value.ToString();
            cboLoaiSP.Text = dtgvDSSP.CurrentRow.Cells[1].Value.ToString();
            txtGiaNhap.Text = dtgvDSSP.CurrentRow.Cells[4].Value.ToString();
            txtSoLuong.Text = dtgvDSSP.CurrentRow.Cells[6].Value.ToString();
            txtDonViTinh.Text = dtgvDSSP.CurrentRow.Cells[7].Value.ToString();
            txtGiaBan.Text = dtgvDSSP.CurrentRow.Cells[5].Value.ToString();
            cboThuongHieu.Text = dtgvDSSP.CurrentRow.Cells[8].Value.ToString();

        }
        public void loadCboLoaiHH()
        {
            loaiHHBindingSource.DataSource = db.LoaiHHs.ToList();
        }

        private void cboLoaiSP_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                ptrBxHinhDD.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dtgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResetValues()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cboLoaiSP.Text = "";
            txtSoLuong.Text = "0";
            txtGiaNhap.Text = "0";
            txtGiaBan.Text = "0";
            txtSoLuong.Enabled = true;
            txtGiaNhap.Enabled = false;
            txtGiaBan.Enabled = false;
            ptrBxHinhDD.Image = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnNhapLai.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaSP.Enabled = true;
            txtTenSP.Focus();
            txtSoLuong.Enabled = true;
            txtGiaNhap.Enabled = true;
            txtGiaBan.Enabled = true;
        }

        private void lblGiaBan_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

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

        private void btnLuu_Click(object sender, EventArgs e)
        {


            if (txtMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }
            if (cboLoaiSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboLoaiSP.Focus();
                return;
            }
            if (ptrBxHinhDD.Image == null)
            {

                MessageBox.Show("Bạn phải chọn một hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBrowseImage.Focus();
                return;
            }
            string masp = txtMaSP.Text;
            string maloai = cboLoaiSP.Text;
            string tensp = txtTenSP.Text;
            double gianhap = double.Parse(txtGiaNhap.Text);
            double giaban = double.Parse(txtGiaBan.Text);
            int soluong = int.Parse(txtSoLuong.Text);
            string img = ptrBxHinhDD.Image.ToString();
            string donvitinh = txtDonViTinh.Text;
            string thuonghieu = cboThuongHieu.Text;

            if (qlbh.kiemTraKhoaChinhSP(masp) == true)
            {
                MessageBox.Show("Đã trùng thông tin");
            }
            else
            {
                qlbh.them(masp, maloai, tensp, gianhap, giaban, soluong, img, donvitinh, thuonghieu);
                dtgvDSSP.DataSource = qlbh.loadDtgvDSSP();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtMaSP.Text;

                if (qlbh.kiemTraKhoaChinhSP(masp) == true)
                {
                    qlbh.xoa(masp);
                    MessageBox.Show("Xóa thành công");
                    dtgvDSSP.DataSource = qlbh.loadDtgvDSSP();
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
            if (dtgvDSSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }
            if (cboLoaiSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboLoaiSP.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            if (txtDonViTinh.Text.Trim().Length == 0) {
                MessageBox.Show("Bạn phải nhập đơn vị tính cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonViTinh.Focus();
                return;
            }
            if (cboThuongHieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn thương hiệu sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboThuongHieu.Focus();
                return;
            }
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string maloai = cboLoaiSP.SelectedValue.ToString();
                double dongianhap = double.Parse(txtGiaNhap.Text);
                double dongiaban = double.Parse(txtGiaBan.Text);
                string thuonghieu = cboThuongHieu.Text;
                string hinhanh = ptrBxHinhDD.Image.ToString();
                string donvitinh = txtDonViTinh.Text;
                int soluong = int.Parse(txtSoLuong.Text);

                if (qlbh.kiemTraKhoaChinhSP(masp))
                {
                    qlbh.sua(masp, maloai, tensp, dongianhap, dongiaban, soluong, hinhanh, donvitinh, thuonghieu);
                    MessageBox.Show("Sửa thành công");
                    dtgvDSSP.DataSource = qlbh.loadDtgvDSSP();
                }
                else
                {
                    MessageBox.Show("Không tồn tại thông tin cần sửa");
                }



        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
