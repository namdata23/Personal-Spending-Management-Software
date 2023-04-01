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
    public partial class FrmNhap : Form
    {
 
        public FrmNhap()
        {
            InitializeComponent();
      
        }

        private void btChi_Click(object sender, EventArgs e)
        {
            lbnhaptien.Text ="Tiền chi:";
            btThu.BackColor = Color.White;
            containerDanhmuc.Controls.Clear();
            UserControlChi ucChi = new UserControlChi();
            containerDanhmuc.Controls.Add(ucChi);

            btChi.BackColor = Color.Orange;
        }

        private void btThu_Click(object sender, EventArgs e)
        {
            lbnhaptien.Text = "Tiền thu:";
            
            btChi.BackColor = Color.White;
            containerDanhmuc.Controls.Clear();
            UserControlThu ucThu = new UserControlThu();
            containerDanhmuc.Controls.Add(ucThu);
            btThu.BackColor = Color.Orange;
        }

        private void FormNhap_Load(object sender, EventArgs e)
        {
            btThu.BackColor = Color.White;
            UserControlChi ucChi = new UserControlChi();
            containerDanhmuc.Controls.Add(ucChi);
            btChi.BackColor = Color.Orange;
        }
        //hàm chỉ cho phep nhap so vao txtNhaptien
      

        private void txtAccept_Click(object sender, EventArgs e)
        {


            if (txtSotien.Text == "") return;
            if(FrmMain.rdChoose<0 || FrmMain.rdChoose > 13)
            {
                MessageBox.Show("Bạn chưa chọn loại danh mục", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ListViewItem item = new ListViewItem(FrmMain.tenDM);
            
            if ( FrmMain.isThu== true)
            {

                FrmMain.tienThuchi = double.Parse(txtSotien.Text);
                item.SubItems.Add(FrmMain.tienThuchi.ToString());
                FrmMain.tongThu += FrmMain.tienThuchi;
            }
            else
            {
                FrmMain.tienThuchi = double.Parse(txtSotien.Text) * -1;
                item.SubItems.Add(FrmMain.tienThuchi.ToString());
                FrmMain.tongChi += FrmMain.tienThuchi;

            }
            item.SubItems.Add(dtNgaythuchi.Value.ToString());
            item.SubItems.Add(txtGhichu.Text);
            item.ImageIndex = FrmMain.rdChoose;
            

            listThuchi.Items.Add(item);

            //lien ket listview voi form lich
            FrmMain.toLich.Add(item);
            //reset rdChoose ve lai ban dau
            FrmMain.rdChoose = 9999;
            //re set lai user controlthu va chi khi nguoi dung nhan xac nhan
            if (FrmMain.isThu == true)
            {
                containerDanhmuc.Controls.Clear();
                UserControlThu ucThu = new UserControlThu();
                containerDanhmuc.Controls.Add(ucThu);
            }
            else
            {
                containerDanhmuc.Controls.Clear();
                UserControlChi ucChi = new UserControlChi();
                containerDanhmuc.Controls.Add(ucChi);
            }
            //RESET LAI TEXT BOX NHAP VA GHI CHU
            txtSotien.Text = "";
            txtGhichu.Text = "";
  
            //total
            lbChitieu.Text = FrmMain.tongChi.ToString();
            lbThunhap.Text = FrmMain.tongThu.ToString();
            lbThuchi.Text = (FrmMain.tongChi + FrmMain.tongThu).ToString();
        }

        private void txtSotien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số >_<", "Lưu ý!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        private void btXoa_Click(object sender, EventArgs e)
        {
           
            foreach (ListViewItem item in listThuchi.SelectedItems)
            {
                //kiem tra so tien hien tai de update len total box
                double soTienInList = double.Parse(item.SubItems[1].Text);
                if(soTienInList<0)
                    FrmMain.tongChi -= double.Parse(item.SubItems[1].Text);
                else
                    FrmMain.tongThu -= double.Parse(item.SubItems[1].Text);
                
                ///xoa item đã chọn
                listThuchi.Items.Remove(item);
                ///update list vào frmMain
                FrmMain.toLich.Remove(item);
            }
         
            lbThuchi.Text = (FrmMain.tongChi+ FrmMain.tongThu).ToString();
            lbChitieu.Text = FrmMain.tongChi.ToString();
            lbThunhap.Text = FrmMain.tongThu.ToString();
            
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
