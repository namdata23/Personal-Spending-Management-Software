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
    public partial class UserControlChi : UserControl
    {

        public UserControlChi()
        {
            InitializeComponent();
        }





        private void rdThuenha_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdThuenha.Text;
            FrmMain.rdChoose = 0;
            FrmMain.isThu = false;

        }

        private void rdHoctap_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdHoctap.Text;
            FrmMain.isThu = false;
            FrmMain.rdChoose = 1;
        }

        private void rdPhilienlac_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdPhilienlac.Text;
            FrmMain.isThu = false;
            FrmMain.rdChoose = 2;
        }

        private void rdDiennuoc_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdDiennuoc.Text;
            FrmMain.isThu = false;
            FrmMain.rdChoose = 3;
        }

        private void rdMuasam_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdMuasam.Text;
            FrmMain.isThu = false;
            FrmMain.rdChoose = 4;
        }

        private void rdYte_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdYte.Text;
            FrmMain.isThu = false;

            FrmMain.rdChoose = 5;
        }

        private void rdDichuyen_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdDichuyen.Text;
            FrmMain.isThu = false;

            FrmMain.rdChoose = 6;
        }

        private void rdAnuong_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdAnuong.Text;
            FrmMain.isThu = false;

            FrmMain.rdChoose = 7;
        }

        private void rdPhikhac_CheckedChanged(object sender, EventArgs e)
        {
            FrmMain.tenDM = rdPhikhac.Text;
            FrmMain.isThu = false;
            FrmMain.rdChoose = 8;
        }
    }
}
