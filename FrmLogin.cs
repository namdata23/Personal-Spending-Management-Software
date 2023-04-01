using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            nDangNhap();
        }


        int dem = 0; // bien dem so lan nhap sai
        const int MAX_dem = 3; // toi da so lan nhap sai 
        private void nDangNhap()
        {
            if (txtTaiKhoan.Text != "Nam" || txtMatKhau.Text != "nam")
            {
                dem++;

                if (dem < MAX_dem)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nBạn còn " + (MAX_dem - dem) + " lần thử", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Text = "";
                    txtTaiKhoan.Focus();
                    txtMatKhau.Text = "";
                }

                else if (dem >= MAX_dem)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu quá nhiều!\nChương trình sẽ đóng sau 3 giây.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    timer1.Enabled = true;
                }

            }


            else
            {
                FrmMain.DangNhap = txtTaiKhoan.Text;
                this.Close(); //nhap dung thi dong form Login sang form Main
                // FrmMain so1 = new FrmMain();
                //this.Visible = false;
                //so1.ShowDialog();

            }
        }
       

        private void nThoat()
        {
            if (MessageBox.Show("Do you want to exit form? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); // Thoát chương trình nếu người dùng chọn "Yes"
            }
        }

        protected override bool ProcessDialogKey(Keys keyData) // use bàn phím
        {
            switch (keyData)
            {
                case Keys.Enter: nDangNhap(); break;
                case Keys.Escape: nThoat(); break;
            }
            return false;
        }

      

     

        private void txtTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
           

                if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
                {
                    errorProvider1.SetError(txtTaiKhoan, "Vui lòng nhập tên tài khoản");
                    //e.Cancel = true;

                }
                else
                {
                    errorProvider1.Clear();
                }
          }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu");
                //e.Cancel = true;

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                txtMatKhau.Focus();
            }
        }

        private void picHide_Click(object sender, EventArgs e)
        {

            if (txtMatKhau.PasswordChar == '*')
            {
                picShow.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void picShow_Click(object sender, EventArgs e)
        {

            if (txtMatKhau.PasswordChar == '\0')
            {
                picHide.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            nThoat();
        }

        private void btDangNhap_Click_1(object sender, EventArgs e)
        {
            nDangNhap();
        }

      
    }
}
