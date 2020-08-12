using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using BLL_DAL;
using System.Data.SqlClient;

namespace DoAnMon_QuanLyBanHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        //QL_DangNhap cauHinh = new QL_DangNhap();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            SqlHelper.con = new SqlConnection(SqlHelper.ConnectString);
            SqlHelper.con.Open();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "Username")
            {
                if (txtPassword.Text != "Password")
                {
                    SqlCommand cmd = new SqlCommand("select * from NguoiDung where MaNV = @user and MatKhau = @pass", SqlHelper.con);
                    cmd.Parameters.AddWithValue("@user", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        SqlHelper.chucvu = dt.Rows[0]["MaCV"].ToString().Trim();

                        frmMain mainMenu = new frmMain();
                        mainMenu.Show();
                        mainMenu.FormClosed += logOut;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n Please try again.");
                        txtPassword.Text = "Password";
                        txtUserName.Focus();
                        txtPassword.UseSystemPasswordChar = false;
                    }
                }
                else
                    msgError("Please enter password.");
            }
            else
                msgError("Please enter username.");
        }

        private void logOut(object sender, FormClosedEventArgs e) {
            txtUserName.Text = "Username";
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Text = "Password";
            lblErrorMessage.Visible = false;
            this.Show();
            //txtUserName.Focus();

        }

        private void msgError(string msg) {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Username") {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.LightGray;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "") {
                txtUserName.Text = "Username";
                txtUserName.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password") {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void ptrClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptrMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
