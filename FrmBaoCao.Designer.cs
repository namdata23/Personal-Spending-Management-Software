
namespace QuanLyChiTieu
{
    partial class FrmBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTong = new System.Windows.Forms.Label();
            this.lbChi = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btHangnam = new System.Windows.Forms.Button();
            this.btHangthang = new System.Windows.Forms.Button();
            this.chartBaocao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listThuChi = new System.Windows.Forms.ListView();
            this.DanhMuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateThuChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btChi = new System.Windows.Forms.Button();
            this.btThu = new System.Windows.Forms.Button();
            this.containerThuchi = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.btDefault = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBaocao)).BeginInit();
            this.containerThuchi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTong);
            this.panel1.Controls.Add(this.lbChi);
            this.panel1.Controls.Add(this.lbThu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 140);
            this.panel1.TabIndex = 17;
            // 
            // lbTong
            // 
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.ForeColor = System.Drawing.Color.Black;
            this.lbTong.Location = new System.Drawing.Point(86, 90);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(205, 32);
            this.lbTong.TabIndex = 2;
            this.lbTong.Text = "0đ";
            this.lbTong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbChi
            // 
            this.lbChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChi.ForeColor = System.Drawing.Color.Red;
            this.lbChi.Location = new System.Drawing.Point(87, 13);
            this.lbChi.Name = "lbChi";
            this.lbChi.Size = new System.Drawing.Size(205, 23);
            this.lbChi.TabIndex = 2;
            this.lbChi.Text = "0đ";
            this.lbChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbThu
            // 
            this.lbThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThu.ForeColor = System.Drawing.Color.Blue;
            this.lbThu.Location = new System.Drawing.Point(87, 55);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(205, 23);
            this.lbThu.TabIndex = 2;
            this.lbThu.Text = "0đ";
            this.lbThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thu chi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thu nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chi tiêu:";
            // 
            // btHangnam
            // 
            this.btHangnam.BackColor = System.Drawing.Color.Orange;
            this.btHangnam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHangnam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btHangnam.Location = new System.Drawing.Point(177, 11);
            this.btHangnam.Name = "btHangnam";
            this.btHangnam.Size = new System.Drawing.Size(145, 31);
            this.btHangnam.TabIndex = 15;
            this.btHangnam.Text = "Hằng năm";
            this.btHangnam.UseVisualStyleBackColor = false;
            this.btHangnam.Click += new System.EventHandler(this.btHangnam_Click);
            // 
            // btHangthang
            // 
            this.btHangthang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btHangthang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHangthang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btHangthang.Location = new System.Drawing.Point(12, 11);
            this.btHangthang.Name = "btHangthang";
            this.btHangthang.Size = new System.Drawing.Size(159, 31);
            this.btHangthang.TabIndex = 16;
            this.btHangthang.Text = "Hằng tháng";
            this.btHangthang.UseVisualStyleBackColor = false;
            this.btHangthang.Click += new System.EventHandler(this.btHangthang_Click);
            // 
            // chartBaocao
            // 
            this.chartBaocao.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartBaocao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBaocao.Legends.Add(legend1);
            this.chartBaocao.Location = new System.Drawing.Point(328, 12);
            this.chartBaocao.Name = "chartBaocao";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "chitieu";
            this.chartBaocao.Series.Add(series1);
            this.chartBaocao.Size = new System.Drawing.Size(313, 176);
            this.chartBaocao.TabIndex = 21;
            // 
            // listThuChi
            // 
            this.listThuChi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DanhMuc,
            this.SoTien,
            this.DateThuChi,
            this.GhiChu});
            this.listThuChi.FullRowSelect = true;
            this.listThuChi.HideSelection = false;
            this.listThuChi.Location = new System.Drawing.Point(3, 3);
            this.listThuChi.Name = "listThuChi";
            this.listThuChi.Size = new System.Drawing.Size(607, 330);
            this.listThuChi.TabIndex = 22;
            this.listThuChi.UseCompatibleStateImageBehavior = false;
            this.listThuChi.View = System.Windows.Forms.View.Details;
            // 
            // DanhMuc
            // 
            this.DanhMuc.Text = "Danh mục";
            this.DanhMuc.Width = 160;
            // 
            // SoTien
            // 
            this.SoTien.Text = "Số tiền";
            this.SoTien.Width = 120;
            // 
            // DateThuChi
            // 
            this.DateThuChi.Text = "Date";
            this.DateThuChi.Width = 120;
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "Ghi chú";
            this.GhiChu.Width = 400;
            // 
            // btChi
            // 
            this.btChi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btChi.Location = new System.Drawing.Point(316, 3);
            this.btChi.Name = "btChi";
            this.btChi.Size = new System.Drawing.Size(159, 31);
            this.btChi.TabIndex = 16;
            this.btChi.Text = "Chi tiêu";
            this.btChi.UseVisualStyleBackColor = false;
            this.btChi.Click += new System.EventHandler(this.btChi_Click);
            // 
            // btThu
            // 
            this.btThu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btThu.Location = new System.Drawing.Point(481, 3);
            this.btThu.Name = "btThu";
            this.btThu.Size = new System.Drawing.Size(145, 31);
            this.btThu.TabIndex = 15;
            this.btThu.Text = "Thu nhập";
            this.btThu.UseVisualStyleBackColor = false;
            this.btThu.Click += new System.EventHandler(this.btThu_Click);
            // 
            // containerThuchi
            // 
            this.containerThuchi.Controls.Add(this.listThuChi);
            this.containerThuchi.Location = new System.Drawing.Point(13, 40);
            this.containerThuchi.Name = "containerThuchi";
            this.containerThuchi.Size = new System.Drawing.Size(613, 336);
            this.containerThuchi.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btDefault);
            this.panel2.Controls.Add(this.btChi);
            this.panel2.Controls.Add(this.containerThuchi);
            this.panel2.Controls.Add(this.btThu);
            this.panel2.Location = new System.Drawing.Point(12, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 383);
            this.panel2.TabIndex = 24;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btXoa.Location = new System.Drawing.Point(13, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(132, 31);
            this.btXoa.TabIndex = 16;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btDefault
            // 
            this.btDefault.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDefault.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btDefault.Location = new System.Drawing.Point(151, 3);
            this.btDefault.Name = "btDefault";
            this.btDefault.Size = new System.Drawing.Size(159, 31);
            this.btDefault.TabIndex = 16;
            this.btDefault.Text = "Default";
            this.btDefault.UseVisualStyleBackColor = false;
            this.btDefault.Click += new System.EventHandler(this.btDefault_Click);
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartBaocao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btHangnam);
            this.Controls.Add(this.btHangthang);
            this.Name = "FrmBaoCao";
            this.Text = "Bao cao";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBaocao)).EndInit();
            this.containerThuchi.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btHangnam;
        private System.Windows.Forms.Button btHangthang;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbChi;
        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBaocao;
        private System.Windows.Forms.ListView listThuChi;
        private System.Windows.Forms.ColumnHeader DanhMuc;
        private System.Windows.Forms.ColumnHeader SoTien;
        private System.Windows.Forms.ColumnHeader DateThuChi;
        private System.Windows.Forms.ColumnHeader GhiChu;
        private System.Windows.Forms.Button btChi;
        private System.Windows.Forms.Button btThu;
        private System.Windows.Forms.Panel containerThuchi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDefault;
        private System.Windows.Forms.Button btXoa;
    }
}