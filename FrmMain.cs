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
    
    public partial class FrmMain : Form
    {
        public static string DangNhap = "";
        public static int rdChoose = 99999;
        public static string tenDM;
        public static bool isThu = true;
        public static List<ListViewItem> toLich;


        public static double tongChi = 0;
        public static double tongThu = 0;
        //public static double tongThuChi=0;
        ////
        public static double tienThuchi = 0;
        public FrmMain()
        {
            toLich = new List<ListViewItem>();
           FrmLogin f = new FrmLogin();
            f.ShowDialog();
            InitializeComponent();
        }
        public void tinhTongTienInList()
        {
            
        }
        private Form currenFormChild;



        private void OpenCHildForm(Form childForm)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
            currenFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        

        private void btNhap_Click(object sender, EventArgs e)
        {
            btBaocao.BackColor = Color.White;
            btLich.BackColor = Color.White;
            btNhap.BackColor = Color.Orange;

            OpenCHildForm(new FrmNhap());
            pnBody.Size = new Size(633, 595);
            this.Size = new Size(600, 545);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btLich_Click(object sender, EventArgs e)
        {
            btBaocao.BackColor = Color.White;
            btLich.BackColor = Color.Orange;
            btNhap.BackColor = Color.White;
            OpenCHildForm(new FrmLich());
            pnBody.Size = new Size(988, 805);
            this.Size = new Size(875,675);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btBaocao_Click(object sender, EventArgs e)
        {
            btBaocao.BackColor = Color.Orange;
            btLich.BackColor = Color.White;
            btNhap.BackColor = Color.White;
            OpenCHildForm(new FrmBaoCao());
            pnBody.Size = new Size(665, 628);
            this.Size = new Size(650, 545);
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void HomePicture_Click(object sender, EventArgs e)
        {
           
            btBaocao.BackColor = Color.White;
            btLich.BackColor = Color.White;
            btNhap.BackColor = Color.Orange;
            pnBody.Size = new Size(633, 595);
            this.Size = new Size(600, 545);
            this.StartPosition = FormStartPosition.CenterScreen;
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
        
        }

        
    }
}
