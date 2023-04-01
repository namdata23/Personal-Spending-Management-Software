
namespace QuanLyChiTieu
{
    partial class FrmNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhap));
            this.containerDanhmuc = new System.Windows.Forms.FlowLayoutPanel();
            this.btClose = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbThuchi = new System.Windows.Forms.Label();
            this.lbThunhap = new System.Windows.Forms.Label();
            this.lbChitieu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listThuchi = new System.Windows.Forms.ListView();
            this.DanhMuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateThuChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbnhaptien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.dtNgaythuchi = new System.Windows.Forms.DateTimePicker();
            this.btThu = new System.Windows.Forms.Button();
            this.btChi = new System.Windows.Forms.Button();
            this.txtAccept = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerDanhmuc
            // 
            this.containerDanhmuc.BackColor = System.Drawing.Color.Transparent;
            this.containerDanhmuc.Location = new System.Drawing.Point(3, 154);
            this.containerDanhmuc.Name = "containerDanhmuc";
            this.containerDanhmuc.Size = new System.Drawing.Size(618, 210);
            this.containerDanhmuc.TabIndex = 30;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btClose.Location = new System.Drawing.Point(500, 545);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(105, 41);
            this.btClose.TabIndex = 31;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btXoa.Location = new System.Drawing.Point(391, 545);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(105, 41);
            this.btXoa.TabIndex = 32;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbThuchi);
            this.groupBox2.Controls.Add(this.lbThunhap);
            this.groupBox2.Controls.Add(this.lbChitieu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(388, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 124);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // lbThuchi
            // 
            this.lbThuchi.AutoSize = true;
            this.lbThuchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuchi.Location = new System.Drawing.Point(106, 93);
            this.lbThuchi.Name = "lbThuchi";
            this.lbThuchi.Size = new System.Drawing.Size(35, 20);
            this.lbThuchi.TabIndex = 1;
            this.lbThuchi.Text = "0 đ";
            this.lbThuchi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbThunhap
            // 
            this.lbThunhap.AutoSize = true;
            this.lbThunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThunhap.ForeColor = System.Drawing.Color.Blue;
            this.lbThunhap.Location = new System.Drawing.Point(95, 62);
            this.lbThunhap.Name = "lbThunhap";
            this.lbThunhap.Size = new System.Drawing.Size(46, 20);
            this.lbThunhap.TabIndex = 1;
            this.lbThunhap.Text = "+0 đ";
            // 
            // lbChitieu
            // 
            this.lbChitieu.AutoSize = true;
            this.lbChitieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChitieu.ForeColor = System.Drawing.Color.Red;
            this.lbChitieu.Location = new System.Drawing.Point(95, 29);
            this.lbChitieu.Name = "lbChitieu";
            this.lbChitieu.Size = new System.Drawing.Size(42, 20);
            this.lbChitieu.TabIndex = 1;
            this.lbChitieu.Text = "-0 đ";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thu chi:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thu nhập:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chi tiêu:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listThuchi
            // 
            this.listThuchi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DanhMuc,
            this.SoTien,
            this.DateThuChi,
            this.GhiChu});
            this.listThuchi.FullRowSelect = true;
            this.listThuchi.HideSelection = false;
            this.listThuchi.LargeImageList = this.imageListLarge;
            this.listThuchi.Location = new System.Drawing.Point(3, 415);
            this.listThuchi.Name = "listThuchi";
            this.listThuchi.Size = new System.Drawing.Size(379, 171);
            this.listThuchi.SmallImageList = this.imageListSmall;
            this.listThuchi.TabIndex = 29;
            this.listThuchi.UseCompatibleStateImageBehavior = false;
            this.listThuchi.View = System.Windows.Forms.View.Details;
            // 
            // DanhMuc
            // 
            this.DanhMuc.Text = "Danh mục";
            this.DanhMuc.Width = 120;
            // 
            // SoTien
            // 
            this.SoTien.Text = "Số tiền";
            this.SoTien.Width = 100;
            // 
            // DateThuChi
            // 
            this.DateThuChi.Text = "Date";
            this.DateThuChi.Width = 90;
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "Ghi chú";
            this.GhiChu.Width = 120;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "z4208554600082_48f3c7e22c59ad7664a7ab5171727da7 (1).png");
            this.imageListLarge.Images.SetKeyName(1, "z4208554795397_0cac8539709f1bb37ec066a179edc0a5.jpg");
            this.imageListLarge.Images.SetKeyName(2, "phone-call.png");
            this.imageListLarge.Images.SetKeyName(3, "z4208554639929_cf6670320635a16aafe14cec5acf853c.jpg");
            this.imageListLarge.Images.SetKeyName(4, "z4208554675922_9050253764c06bda622198944092b770.png");
            this.imageListLarge.Images.SetKeyName(5, "z4208554687117_a809c1700bd58e78ac7d99e17dc845a8.png");
            this.imageListLarge.Images.SetKeyName(6, "z4208554592380_1b8f9ecd715375255e07390dbc3f23f9.png");
            this.imageListLarge.Images.SetKeyName(7, "z4208554687068_b5219bac464394579f2fb5764e8d1666.png");
            this.imageListLarge.Images.SetKeyName(8, "z4208554813353_5f95f300b0d146e8028a6cc6a8b9dc3b.png");
            this.imageListLarge.Images.SetKeyName(9, "tienluong.png");
            this.imageListLarge.Images.SetKeyName(10, "tienphucap.png");
            this.imageListLarge.Images.SetKeyName(11, "tienthuong.png");
            this.imageListLarge.Images.SetKeyName(12, "dautu.png");
            this.imageListLarge.Images.SetKeyName(13, "thunhapphu.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "z4208554600082_48f3c7e22c59ad7664a7ab5171727da7 (1).png");
            this.imageListSmall.Images.SetKeyName(1, "z4208554795397_0cac8539709f1bb37ec066a179edc0a5.jpg");
            this.imageListSmall.Images.SetKeyName(2, "phone-call.png");
            this.imageListSmall.Images.SetKeyName(3, "z4208554639929_cf6670320635a16aafe14cec5acf853c.jpg");
            this.imageListSmall.Images.SetKeyName(4, "z4208554675922_9050253764c06bda622198944092b770.png");
            this.imageListSmall.Images.SetKeyName(5, "z4208554687117_a809c1700bd58e78ac7d99e17dc845a8.png");
            this.imageListSmall.Images.SetKeyName(6, "z4208554592380_1b8f9ecd715375255e07390dbc3f23f9.png");
            this.imageListSmall.Images.SetKeyName(7, "z4208554687068_b5219bac464394579f2fb5764e8d1666.png");
            this.imageListSmall.Images.SetKeyName(8, "z4208554813353_5f95f300b0d146e8028a6cc6a8b9dc3b.png");
            this.imageListSmall.Images.SetKeyName(9, "tienluong.png");
            this.imageListSmall.Images.SetKeyName(10, "tienphucap.png");
            this.imageListSmall.Images.SetKeyName(11, "tienthuong.png");
            this.imageListSmall.Images.SetKeyName(12, "dautu.png");
            this.imageListSmall.Images.SetKeyName(13, "thunhapphu.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtSotien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbnhaptien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGhichu);
            this.panel1.Controls.Add(this.dtNgaythuchi);
            this.panel1.Location = new System.Drawing.Point(3, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 91);
            this.panel1.TabIndex = 28;
            // 
            // txtSotien
            // 
            this.txtSotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSotien.Location = new System.Drawing.Point(97, 42);
            this.txtSotien.Multiline = true;
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(200, 32);
            this.txtSotien.TabIndex = 2;
            this.txtSotien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSotien_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ghi Chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "VND";
            // 
            // lbnhaptien
            // 
            this.lbnhaptien.AutoSize = true;
            this.lbnhaptien.Location = new System.Drawing.Point(17, 49);
            this.lbnhaptien.Name = "lbnhaptien";
            this.lbnhaptien.Size = new System.Drawing.Size(57, 16);
            this.lbnhaptien.TabIndex = 0;
            this.lbnhaptien.Text = "Tiền chi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.Location = new System.Drawing.Point(421, 42);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(173, 32);
            this.txtGhichu.TabIndex = 2;
            // 
            // dtNgaythuchi
            // 
            this.dtNgaythuchi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaythuchi.Location = new System.Drawing.Point(97, 14);
            this.dtNgaythuchi.Name = "dtNgaythuchi";
            this.dtNgaythuchi.Size = new System.Drawing.Size(200, 22);
            this.dtNgaythuchi.TabIndex = 1;
            // 
            // btThu
            // 
            this.btThu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btThu.Location = new System.Drawing.Point(319, 12);
            this.btThu.Name = "btThu";
            this.btThu.Size = new System.Drawing.Size(225, 39);
            this.btThu.TabIndex = 26;
            this.btThu.Text = "Tiền thu";
            this.btThu.UseVisualStyleBackColor = false;
            this.btThu.Click += new System.EventHandler(this.btThu_Click);
            // 
            // btChi
            // 
            this.btChi.BackColor = System.Drawing.Color.Orange;
            this.btChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btChi.Location = new System.Drawing.Point(88, 12);
            this.btChi.Name = "btChi";
            this.btChi.Size = new System.Drawing.Size(225, 39);
            this.btChi.TabIndex = 27;
            this.btChi.Text = "Tiền chi";
            this.btChi.UseVisualStyleBackColor = false;
            this.btChi.Click += new System.EventHandler(this.btChi_Click);
            // 
            // txtAccept
            // 
            this.txtAccept.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtAccept.Location = new System.Drawing.Point(3, 370);
            this.txtAccept.Name = "txtAccept";
            this.txtAccept.Size = new System.Drawing.Size(604, 39);
            this.txtAccept.TabIndex = 25;
            this.txtAccept.Text = "Nhập";
            this.txtAccept.UseVisualStyleBackColor = false;
            this.txtAccept.Click += new System.EventHandler(this.txtAccept_Click);
            // 
            // FrmNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 595);
            this.Controls.Add(this.containerDanhmuc);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listThuchi);
            this.Controls.Add(this.txtAccept);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btThu);
            this.Controls.Add(this.btChi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhap";
            this.Text = "FormNhap";
            this.Load += new System.EventHandler(this.FormNhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel containerDanhmuc;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbThuchi;
        private System.Windows.Forms.Label lbThunhap;
        private System.Windows.Forms.Label lbChitieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listThuchi;
        private System.Windows.Forms.ColumnHeader DanhMuc;
        private System.Windows.Forms.ColumnHeader SoTien;
        private System.Windows.Forms.ColumnHeader DateThuChi;
        private System.Windows.Forms.ColumnHeader GhiChu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbnhaptien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.DateTimePicker dtNgaythuchi;
        private System.Windows.Forms.Button btThu;
        private System.Windows.Forms.Button btChi;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.Button txtAccept;
    }
}