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
    public partial class FrmBaoCao : Form
    {
        int day, month, year;
        DateTime today = DateTime.Today;
        double tongthuchitemp=0;
        double tongThuThang = 0, tongChiThang = 0;
        public FrmBaoCao()
        {
            
            InitializeComponent();
            chartBaocao.Titles.Add("Bảng báo cáo ");
            
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            //
            
            //
            lbThu.Text = FrmMain.tongThu.ToString();
            lbChi.Text = FrmMain.tongChi.ToString();
            lbTong.Text = (FrmMain.tongThu + FrmMain.tongChi).ToString();

            foreach (ListViewItem item in FrmMain.toLich)
                listThuChi.Items.Add(item);
            taoBang(FrmMain.tongChi, FrmMain.tongThu, FrmMain.tongChi + FrmMain.tongThu);
        }
        ///bang
        public void taoBang( double tongchi,double tongthu,double tong)
        {
            chartBaocao.Series["chitieu"].Points.AddXY("chi tiêu", tongchi);
            chartBaocao.Series["chitieu"].Points.AddXY("thu nhâp", tongthu);
            chartBaocao.Series["chitieu"].Points.AddXY("thu chi", tong);
            chartBaocao.Series["chitieu"].Points[0].Color = Color.Red;
            chartBaocao.Series["chitieu"].Points[1].Color = Color.Blue;
            chartBaocao.Series["chitieu"].Points[2].Color = Color.Green;


        }
        public void xoaDulieutrongbang()
        {
            foreach (var series in chartBaocao.Series)
            {
                series.Points.Clear();
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listThuChi.SelectedItems)
            {
                //kiem tra so tien hien tai de update len total box
                double soTienInList = double.Parse(item.SubItems[1].Text);
                if (soTienInList < 0)
                    FrmMain.tongChi -= double.Parse(item.SubItems[1].Text);
                else
                    FrmMain.tongThu -= double.Parse(item.SubItems[1].Text);

                ///xoa item đã chọn
                listThuChi.Items.Remove(item);
                ///update list vào frmMain
                FrmMain.toLich.Remove(item);
            }
            lbTong.Text = (FrmMain.tongChi + FrmMain.tongThu).ToString();
            lbChi.Text = FrmMain.tongChi.ToString();
            lbThu.Text = FrmMain.tongThu.ToString();

            //them xao du lieu va them du lieu vao trong bang chart pie
            xoaDulieutrongbang();
            taoBang(FrmMain.tongChi, FrmMain.tongThu, FrmMain.tongChi + FrmMain.tongThu);
        }

        private void btHangnam_Click(object sender, EventArgs e)
        {
            btHangthang.BackColor= Color.White;
            btHangnam.BackColor = Color.Orange;
            defaultListView();
            day = today.Day;
            month = today.Month;
            year = today.Year;
            foreach (ListViewItem item in listThuChi.Items)
            {

                string dateStr = item.SubItems[2].Text;
                double soTienInList = double.Parse(item.SubItems[1].Text);
                DateTime itemDate = DateTime.Parse(dateStr);
                if (year == itemDate.Year)
                {

                    if (soTienInList < 0)
                        tongChiThang += double.Parse(item.SubItems[1].Text);
                    else
                        tongThuThang += double.Parse(item.SubItems[1].Text);

                }
            }
            lbChi.Text = tongChiThang.ToString();
            lbThu.Text = tongThuThang.ToString();
            lbTong.Text = (tongChiThang + tongThuThang).ToString();

            //them xao du lieu va them du lieu vao trong bang chart pie
            xoaDulieutrongbang();
            taoBang(tongChiThang, tongThuThang, tongChiThang + tongThuThang);
            
            tongthuchitemp = 0;
            tongThuThang = 0;
            tongChiThang = 0;
        }

        private void btHangthang_Click(object sender, EventArgs e)
        {
            btHangthang.BackColor = Color.Orange;
            btHangnam.BackColor = Color.White;
            defaultListView();
            day = today.Day;
            month = today.Month;
            year = today.Year;
            foreach (ListViewItem item in listThuChi.Items)
            {

                string dateStr = item.SubItems[2].Text;
                double soTienInList = double.Parse(item.SubItems[1].Text);
                DateTime itemDate = DateTime.Parse(dateStr);
                if (month == itemDate.Month && year == itemDate.Year)
                {

                    if (soTienInList < 0)
                        tongChiThang += double.Parse(item.SubItems[1].Text);
                    else
                        tongThuThang += double.Parse(item.SubItems[1].Text);
                 
                }
            }
            lbChi.Text = tongChiThang.ToString();
            lbThu.Text = tongThuThang.ToString();
            lbTong.Text = (tongChiThang+ tongThuThang).ToString();

            //them xao du lieu va them du lieu vao trong bang chart pie
            xoaDulieutrongbang();
            taoBang(tongChiThang, tongThuThang, tongChiThang + tongThuThang);

            tongthuchitemp = 0;
            tongThuThang = 0;
            tongChiThang = 0;
        }
        private void btChi_Click(object sender, EventArgs e)
        {
            defaultListView();
            foreach (ListViewItem item in listThuChi.Items)
            {   
                double soTienInList = double.Parse(item.SubItems[1].Text);
                if (soTienInList > 0)
                    listThuChi.Items.Remove(item);
            }
        }
        private void btThu_Click(object sender, EventArgs e)
        {
            defaultListView();
            foreach (ListViewItem item in listThuChi.Items)
            {
                double soTienInList = double.Parse(item.SubItems[1].Text);
                if (soTienInList < 0)
                    listThuChi.Items.Remove(item);
            }
        }
        private void btDefault_Click(object sender, EventArgs e)
        {
            defaultListView();

        }

        public void defaultListView()
        {
           
            listThuChi.Items.Clear();
            foreach (ListViewItem item in FrmMain.toLich)
                listThuChi.Items.Add(item);

            //them xao du lieu va them du lieu vao trong bang chart pie
            xoaDulieutrongbang();
            taoBang(FrmMain.tongChi, FrmMain.tongThu, FrmMain.tongChi + FrmMain.tongThu);

        }




        //private void dtDate_ValueChanged(object sender, EventArgs e)
        //{
        //    defaultListView();

        //    //tongthuchitemp = 0;
        //    month = dtDate.Value.Month; ;
        //    year = dtDate.Value.Year;
        //    day = dtDate.Value.Day;

        //    //tao usercontroll cho days

        //    foreach (ListViewItem item in listThuChi.Items)
        //    {

        //        string dateStr = item.SubItems[2].Text;
        //        double tongthuchiInList = double.Parse(item.SubItems[1].Text);
        //        DateTime itemDate = DateTime.Parse(dateStr);
        //        if (day == itemDate.Day && month == itemDate.Month && year == itemDate.Year)
        //        {
        //            tongthuchitemp += tongthuchiInList;
        //        }
        //    }
        //    foreach (ListViewItem item in listThuChi.Items)
        //    {
        //        string dateStr = item.SubItems[2].Text;
        //        DateTime itemDate = DateTime.Parse(dateStr);
        //        if (day != itemDate.Day || month != itemDate.Month || year != itemDate.Year)
        //            listThuChi.Items.Remove(item);

        //    }
        //    FrmMain.tongChi = 0;
        //    FrmMain.tongThu = 0;
        //    foreach (ListViewItem item in listThuChi.Items)
        //    {
        //        double soTienInList = double.Parse(item.SubItems[1].Text);

        //        if (soTienInList < 0)
        //            FrmMain.tongChi += double.Parse(item.SubItems[1].Text);
        //        else
        //            FrmMain.tongThu += double.Parse(item.SubItems[1].Text);
        //    }
        //    lbThu.Text = FrmMain.tongThu.ToString();
        //    lbChi.Text = FrmMain.tongChi.ToString();
        //    lbTong.Text = (FrmMain.tongThu + FrmMain.tongChi).ToString();
        //}

    }
}
