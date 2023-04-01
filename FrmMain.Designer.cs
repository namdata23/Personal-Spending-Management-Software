
namespace QuanLyChiTieu
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.HomePicture = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btBaocao = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.btLich = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIcon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePicture
            // 
            this.HomePicture.BackColor = System.Drawing.Color.Transparent;
            this.HomePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomePicture.BackgroundImage")));
            this.HomePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomePicture.Location = new System.Drawing.Point(12, 12);
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.Size = new System.Drawing.Size(134, 127);
            this.HomePicture.TabIndex = 13;
            this.HomePicture.TabStop = false;
            this.HomePicture.Click += new System.EventHandler(this.HomePicture_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btBaocao);
            this.groupBox3.Controls.Add(this.btNhap);
            this.groupBox3.Controls.Add(this.btLich);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 419);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu";
            // 
            // btBaocao
            // 
            this.btBaocao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaocao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btBaocao.Location = new System.Drawing.Point(3, 111);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(138, 41);
            this.btBaocao.TabIndex = 0;
            this.btBaocao.Text = "Báo Cáo";
            this.btBaocao.UseVisualStyleBackColor = false;
            this.btBaocao.Click += new System.EventHandler(this.btBaocao_Click);
            // 
            // btNhap
            // 
            this.btNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNhap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btNhap.Location = new System.Drawing.Point(3, 36);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(138, 41);
            this.btNhap.TabIndex = 0;
            this.btNhap.Text = "Nhập";
            this.btNhap.UseVisualStyleBackColor = false;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btLich
            // 
            this.btLich.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLich.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btLich.Location = new System.Drawing.Point(3, 73);
            this.btLich.Name = "btLich";
            this.btLich.Size = new System.Drawing.Size(138, 41);
            this.btLich.TabIndex = 0;
            this.btLich.Text = "Lịch";
            this.btLich.UseVisualStyleBackColor = false;
            this.btLich.Click += new System.EventHandler(this.btLich_Click);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.Transparent;
            this.pnBody.Controls.Add(this.label1);
            this.pnBody.Controls.Add(this.lbIcon);
            this.pnBody.Location = new System.Drawing.Point(152, 12);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(633, 595);
            this.pnBody.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(165, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vui lòng chọn chức năng trong Menu";
            // 
            // lbIcon
            // 
            this.lbIcon.AutoSize = true;
            this.lbIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIcon.ForeColor = System.Drawing.Color.Gray;
            this.lbIcon.Location = new System.Drawing.Point(142, 147);
            this.lbIcon.Name = "lbIcon";
            this.lbIcon.Size = new System.Drawing.Size(338, 91);
            this.lbIcon.TabIndex = 0;
            this.lbIcon.Text = "o(≧▽≦)o";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 625);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.HomePicture);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Chi Tieu";
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox HomePicture;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btLich;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIcon;
    }
}

