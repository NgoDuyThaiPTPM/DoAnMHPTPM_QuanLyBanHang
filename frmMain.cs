using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;

namespace DoAnMon_QuanLyBanHang
{
    public partial class frmMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Panel leftBoderButton;
        public frmMain()
        {
            InitializeComponent();
            customizeDesing();
            random = new Random();
            btnExit.Visible = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            leftBoderButton = new Panel();
            leftBoderButton.Size = new Size(7, 60);
            pnMenu.Controls.Add(leftBoderButton);
        }
        private struct RBGColors {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
            
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor() {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index) {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender, Color color) {
            if (btnSender != null) {
                if (currentButton != (Button)btnSender) {
                    DisableButton();
                    DisableButton1();
                    color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.TextAlign = ContentAlignment.MiddleCenter;
                    //currentButton.IconColor = color;
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentButton.ImageAlign = ContentAlignment.MiddleRight;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnTieuDe.BackColor = color;
                    pnLogo.BackColor = ThemeColor.changeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.changeColorBrightness(color, -0.3);
                    btnExit.Visible = true;
                    //left boder button
                    leftBoderButton.BackColor = color;
                    leftBoderButton.Location = new Point(0, currentButton.Location.Y);
                    leftBoderButton.Visible = true;
                    leftBoderButton.BringToFront();
                    pnTieuDe.BackColor = color;
                }
            }
        }
        private void DisableButton() {
            foreach (Control previousBtn in pnMenu.Controls) {
                if (previousBtn.GetType() == typeof(Button)) {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton1() {
            if (currentButton != null) {
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                //currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void customizeDesing() {
            pnSubMenuTaiKhoan.Visible = false;
            pnSubMenuSanPham.Visible = false;
            pnSubMenuSoQuy.Visible = false;
            pnSubMenuBaoCao.Visible = false;
        }

        private void hideSubMenu() {
            if (pnSubMenuTaiKhoan.Visible == true)
                pnSubMenuTaiKhoan.Visible = false;
            if (pnSubMenuSanPham.Visible == true)
                pnSubMenuSanPham.Visible = false;
            if (pnSubMenuSoQuy.Visible == true)
                pnSubMenuSoQuy.Visible = false;
            if (pnSubMenuBaoCao.Visible == true)
                pnSubMenuBaoCao.Visible = false;
        }

        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if(SqlHelper.chucvu == "CV02")
            {
                this.btnBaoCao.Enabled = false;
                this.btnSoQuy.Enabled = false;
                this.btnBanHang.Enabled = false;
                this.btnKhachHang.Enabled = false;
            }

            else if (SqlHelper.chucvu == "CV03") {
                this.btnBaoCao.Enabled = false;
                this.btnSoQuy.Enabled = false;
            }

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color4);
            showSubMenu(pnSubMenuSanPham);
        }

        private void btnSoQuy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color5);
            showSubMenu(pnSubMenuSoQuy);
        }
        #region SubMenuSanPham

        private void btnDSSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDSSanPham(), sender);
            //Your code
            hideSubMenu();
        }

        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhapHang(), sender);
            //Your code
            hideSubMenu();
        }

        private void btnKiemHang_Click(object sender, EventArgs e)
        {
            //Your code
            hideSubMenu();
        }

        private void btnChuyenHang_Click(object sender, EventArgs e)
        {
            //Your code
            hideSubMenu();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhaCungCap(), sender);
            //Your code
            hideSubMenu();
        }

        private void btnDieuChinhGiaVon_Click(object sender, EventArgs e)
        {
            //Your code
            hideSubMenu();
        }
        #endregion
        #region SubMenuSoQuy
        private void btnTongQuanSoQuy_Click(object sender, EventArgs e)
        {
            //Your code
            hideSubMenu();
        }

        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            openChildForm(new Formss.frmPhieuThu(), sender);
            //Your code
            hideSubMenu();
        }

        private void btnPhieuChi_Click(object sender, EventArgs e)
        {
            openChildForm(new Formss.frmPhieuChi(), sender);
            //Your code
            hideSubMenu();
        }

        private void btnSoQuyT_Click(object sender, EventArgs e)
        {
            //Your code
            hideSubMenu();
        }
        #endregion
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color6);
            showSubMenu(pnSubMenuBaoCao);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Formss.frmDSKhachHang(), sender);
            ActivateButton(sender, RBGColors.color3);
            //Your code
            hideSubMenu();
        }


        private void btnBanHang_Click(object sender, EventArgs e)
        {

            openChildForm(new Formss.frmBanHang(), sender);
            ActivateButton(sender, RBGColors.color1);
            //Your code
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm, object btnSender) {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender, RBGColors.color1);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblTieuDe.Text = childForm.Text;
        }
        #region SubMenuBaoCao
        private void btnBaoCaoNhapHang_Click(object sender, EventArgs e)
        {
            //Your code
            hideSubMenu();
        }

        private void btnBaoCaoKho_Click(object sender, EventArgs e)
        {
            //Your code
            hideSubMenu();
        }

        private void btnBaoCaoTaiChinh_Click(object sender, EventArgs e)
        {
            //Your code
            hideSubMenu();
        }

        private void btnBaoCaoBanHang_Click(object sender, EventArgs e)
        {
            //Your code
            hideSubMenu();
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        public void Reset() {
            DisableButton();
            lblTieuDe.Text = "TRANG CHỦ";
            pnTieuDe.BackColor = Color.FromArgb(0, 150, 136);
            pnLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnExit.Visible = false;
        }

        private void pnTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ptrRose_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color6);
            showSubMenu(pnSubMenuTaiKhoan);

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDangNhap(), sender);
            //Your code
            hideSubMenu();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmDangKy(), sender);
            //Your code
            hideSubMenu();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
                this.Close();
        }

    }
}
