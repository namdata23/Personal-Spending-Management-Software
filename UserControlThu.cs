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
    public partial class UserControlThu : UserControl
    {
        public UserControlThu()
        {
            InitializeComponent();
        }

        private void rdTienluong_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdTienluong.Text;
            FrmMain.rdChoose = 9;
            FrmMain.isThu = true;
        }

        private void rdTienphucap_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdTienphucap.Text;
            FrmMain.rdChoose = 10;
            FrmMain.isThu = true;

        }

        private void rdTienthuong_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdTienthuong.Text;
            FrmMain.isThu = true;
            FrmMain.rdChoose = 11;
        }

        private void rdDautu_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdDautu.Text;
            FrmMain.isThu = true;
            FrmMain.rdChoose = 12;
        }

        private void rdThunhapphu_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdThunhapphu.Text;
            FrmMain.isThu = true;
            FrmMain.rdChoose = 13;
        }
    }
}
