using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace QuanLyChiTieu
{
    public partial class FrmLich : Form
    {
        int month, year, day;
        DateTime today = DateTime.Today;
        double tongthuchitemp = 0;
        public FrmLich()
        {
            InitializeComponent();
        }
        //public FrmLich(ListViewItem s)
        //{
        //    listThuChi.Items.Add(s);
        //    InitializeComponent();
        //}

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            lbThu.Text = FrmMain.tongThu.ToString();
            lbChi.Text = FrmMain.tongChi.ToString();
            lbTong.Text = (FrmMain.tongThu+FrmMain.tongChi).ToString();
            

            foreach (ListViewItem item in FrmMain.toLich)
            {
                listThuChi.Items.Add(item);
            }

            displayDays();
   

        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            day = now.Day;


            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            // lay ngay dau tien cua thang
            DateTime startofthemonth = new DateTime(year, month, 1);
            // lay so ngay cua thang
            int days = DateTime.DaysInMonth(year, month);
            //doi  startofthemonth sang interger
            int dayoftheweak = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;
            // tao blank usercontroll
            for( int i = 1; i < dayoftheweak; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //tao usercontroll cho days
            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                if (i == day)
                {
                    ucdays.BackColor = Color.FloralWhite;
                }
                foreach (ListViewItem item in listThuChi.Items)
                {

                    string dateStr = item.SubItems[2].Text;
                    double tongthuchiInList = double.Parse(item.SubItems[1].Text);
                    DateTime itemDate = DateTime.Parse(dateStr);
                    if (i == itemDate.Day && month == itemDate.Month && year == itemDate.Year)
                    {

                        tongthuchitemp += tongthuchiInList;

                    }
                }
                ucdays.txteve(tongthuchitemp.ToString());
                tongthuchitemp = 0;
                daycontainer.Controls.Add(ucdays);
            }
        }
        public void taoLich(int day, int month, int year)
        {
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            // lay so ngay cua thang
            int days = DateTime.DaysInMonth(year, month);
            //doi  startofthemonth sang interger
            int dayoftheweak = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // tao blank usercontroll
            for (int i = 1; i < dayoftheweak; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //tao usercontroll for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                if (i == day && today.Month == month && today.Year == year)
                {
                    ucdays.BackColor = Color.FloralWhite;
                }
                foreach (ListViewItem item in listThuChi.Items)
                {

                    string dateStr = item.SubItems[2].Text;
                    double tongthuchiInList = double.Parse(item.SubItems[1].Text);
                    DateTime itemDate = DateTime.Parse(dateStr);
                    if (i == itemDate.Day && month == itemDate.Month && year == itemDate.Year)
                    {
                        tongthuchitemp += tongthuchiInList;

                    }
                }
                ucdays.txteve(tongthuchitemp.ToString());
                tongthuchitemp = 0;
                daycontainer.Controls.Add(ucdays);
            }
        }

        //button xem lich cua thang truoc
        private void btprevious_Click(object sender, EventArgs e)
        {
            //xóa container
            daycontainer.Controls.Clear();
            
            //giảm tháng lên thành tháng trước đó
            month--;
            taoLich(day, month, year);
            //string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            //LBDATE.Text = monthname + " " + year;
            //DateTime startofthemonth = new DateTime(year, month, 1);
            //// lay so ngay cua thang
            //int days = DateTime.DaysInMonth(year, month);
            ////doi  startofthemonth sang interger
            //int dayoftheweak = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            //// tao blank usercontroll
            //for (int i = 1; i < dayoftheweak; i++)
            //{
            //    UserControlBlank ucblank = new UserControlBlank();
            //    daycontainer.Controls.Add(ucblank);
            //}
            ////tao usercontroll for days
            //for (int i = 1; i <= days; i++)
            //{
            //    UserControlDays ucdays = new UserControlDays();
            //    ucdays.days(i);
            //    if(i==day && today.Month==month && today.Year==year)
            //    {
            //        ucdays.BackColor = Color.FloralWhite;
            //    }
            //    foreach (ListViewItem item in listThuChi.Items)
            //    {

            //        string dateStr = item.SubItems[2].Text;
            //        double tongthuchiInList = double.Parse(item.SubItems[1].Text);
            //        DateTime itemDate = DateTime.Parse(dateStr);
            //        if (i == itemDate.Day && month == itemDate.Month && year == itemDate.Year)
            //        {
            //            tongthuchitemp += tongthuchiInList;

            //        }
            //    }
            //    ucdays.txteve(tongthuchitemp.ToString());
            //    tongthuchitemp = 0;
            //    daycontainer.Controls.Add(ucdays);
                
            //}
        }

        //button xem lich cua thang sau
        private void btnext_Click(object sender, EventArgs e)
        {
            //xóa container
            daycontainer.Controls.Clear();
     
            //tăng tháng lên thành tháng tiếp theo
            month++;
            taoLich(day, month, year);

            //string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            ////header thang Nam
            //LBDATE.Text = monthname + " " + year;
            //DateTime startofthemonth = new DateTime(year, month, 1);
            //// lay so ngay cua thang
            //int days = DateTime.DaysInMonth(year, month);
            ////doi  startofthemonth sang interger
            //int dayoftheweak = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            //// tao blank usercontroll
            //for (int i = 1; i < dayoftheweak; i++)
            //{
            //    UserControlBlank ucblank = new UserControlBlank();
            //    daycontainer.Controls.Add(ucblank);
            //}
            ////tao usercontroll for days
            //for (int i = 1; i <= days; i++)
            //{

            //    UserControlDays ucdays = new UserControlDays();
            //    ucdays.days(i);
            //    if (i == day && today.Month == month && today.Year == year)
            //    {
            //        ucdays.BackColor = Color.FloralWhite;
            //    }

            //    foreach (ListViewItem item in listThuChi.Items)
            //    {

            //        string dateStr = item.SubItems[2].Text;
            //        double tongthuchiInList = double.Parse(item.SubItems[1].Text);
            //        DateTime itemDate = DateTime.Parse(dateStr);
            //        if (i == itemDate.Day && month == itemDate.Month && year == itemDate.Year)
            //        {
            //            tongthuchitemp += tongthuchiInList;

            //        }
            //    }
            //    ucdays.txteve(tongthuchitemp.ToString());
            //    tongthuchitemp = 0;
            //    daycontainer.Controls.Add(ucdays);

            //}
        }
        ///////////////////////////////////////////////////////////////
        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            defaultListView();
            daycontainer.Controls.Clear();
            //tongthuchitemp = 0;
            month = dtDate.Value.Month;
            year = dtDate.Value.Year;
            day = dtDate.Value.Day;
            //
            
            //
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            LBDATE.Text = monthname + " " + year;

            // lay ngay dau tien cua thang
            DateTime startofthemonth = new DateTime(year, month, 1);
            // lay so ngay cua thang
            int days = DateTime.DaysInMonth(year, month);
            //doi  startofthemonth sang interger
            int dayoftheweak = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // tao blank usercontroll
            for (int i = 1; i < dayoftheweak; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //tao usercontroll cho days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                
                if (i == today.Day && today.Month == month && today.Year == year)
                {
                    ucdays.BackColor = Color.FloralWhite;
                }
                if (i == dtDate.Value.Day)
                {
                    ucdays.BackColor = Color.GreenYellow;
                }
                foreach (ListViewItem item in listThuChi.Items)
                {

                    string dateStr = item.SubItems[2].Text;
                    double tongthuchiInList = double.Parse(item.SubItems[1].Text);
                    DateTime itemDate = DateTime.Parse(dateStr);
                    if (i == itemDate.Day && month == itemDate.Month && year == itemDate.Year)
                    {
                        tongthuchitemp += tongthuchiInList;
                    }
                }
                ucdays.txteve(tongthuchitemp.ToString());
                tongthuchitemp = 0;
                daycontainer.Controls.Add(ucdays);
            }
            foreach (ListViewItem item in listThuChi.Items)
            {
                string dateStr = item.SubItems[2].Text;
                DateTime itemDate = DateTime.Parse(dateStr);
                if (day != itemDate.Day || month != itemDate.Month || year != itemDate.Year)
                    listThuChi.Items.Remove(item);

            }
            
            //cap nhat cac lb thu chi tong
            double tempTongChi = 0;
            double tempTongThu = 0;
            foreach (ListViewItem item in listThuChi.Items)
            {
                double soTienInList = double.Parse(item.SubItems[1].Text);
                
                if (soTienInList < 0)
                    tempTongChi += double.Parse(item.SubItems[1].Text);
                else
                    tempTongThu += double.Parse(item.SubItems[1].Text);
            }
            lbThu.Text = tempTongThu.ToString();
            lbChi.Text = tempTongChi.ToString();
            lbTong.Text = (tempTongChi + tempTongThu).ToString();
        }
        
        private void btMacdinh_Click(object sender, EventArgs e)
        {
            double tempTongChi = 0;
            double tempTongThu = 0;
            defaultListView();
            foreach (ListViewItem item in listThuChi.Items)
            {
                double soTienInList = double.Parse(item.SubItems[1].Text);

                if (soTienInList < 0)
                    tempTongChi += double.Parse(item.SubItems[1].Text);
                else
                    tempTongThu += double.Parse(item.SubItems[1].Text);
            }
            lbThu.Text = tempTongThu.ToString();
            lbChi.Text = tempTongChi.ToString();
            lbTong.Text = (tempTongChi + tempTongThu).ToString();

        }
        //button quay ve mac dinh
        public void defaultListView()
        {
            daycontainer.Controls.Clear();
          
            listThuChi.Items.Clear();
            foreach (ListViewItem item in FrmMain.toLich)
                listThuChi.Items.Add(item); 
            displayDays();
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

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
