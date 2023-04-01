
namespace QuanLyChiTieu
{
    partial class UserControlThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlThu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdTienthuong = new System.Windows.Forms.RadioButton();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.rdThunhapphu = new System.Windows.Forms.RadioButton();
            this.rdTienphucap = new System.Windows.Forms.RadioButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.rdDautu = new System.Windows.Forms.RadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.rdTienluong = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 210);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdTienthuong);
            this.panel3.Controls.Add(this.pictureBox9);
            this.panel3.Controls.Add(this.rdThunhapphu);
            this.panel3.Controls.Add(this.rdTienphucap);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.rdDautu);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.rdTienluong);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(23, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 140);
            this.panel3.TabIndex = 11;
            // 
            // rdTienthuong
            // 
            this.rdTienthuong.AutoSize = true;
            this.rdTienthuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTienthuong.Location = new System.Drawing.Point(409, 15);
            this.rdTienthuong.Name = "rdTienthuong";
            this.rdTienthuong.Size = new System.Drawing.Size(117, 22);
            this.rdTienthuong.TabIndex = 9;
            this.rdTienthuong.TabStop = true;
            this.rdTienthuong.Text = "Tiền thưởng";
            this.rdTienthuong.UseVisualStyleBackColor = true;
            this.rdTienthuong.CheckedChanged += new System.EventHandler(this.rdTienthuong_CheckedChanged);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(362, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(41, 45);
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // rdThunhapphu
            // 
            this.rdThunhapphu.AutoSize = true;
            this.rdThunhapphu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThunhapphu.Location = new System.Drawing.Point(222, 61);
            this.rdThunhapphu.Name = "rdThunhapphu";
            this.rdThunhapphu.Size = new System.Drawing.Size(98, 40);
            this.rdThunhapphu.TabIndex = 9;
            this.rdThunhapphu.TabStop = true;
            this.rdThunhapphu.Text = "Thu nhập\r\n phụ";
            this.rdThunhapphu.UseVisualStyleBackColor = true;
            this.rdThunhapphu.CheckedChanged += new System.EventHandler(this.rdThunhapphu_CheckedChanged);
            // 
            // rdTienphucap
            // 
            this.rdTienphucap.AutoSize = true;
            this.rdTienphucap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTienphucap.Location = new System.Drawing.Point(222, 6);
            this.rdTienphucap.Name = "rdTienphucap";
            this.rdTienphucap.Size = new System.Drawing.Size(93, 40);
            this.rdTienphucap.TabIndex = 9;
            this.rdTienphucap.TabStop = true;
            this.rdTienphucap.Text = "Tiền phụ\r\n cấp";
            this.rdTienphucap.UseVisualStyleBackColor = true;
            this.rdTienphucap.CheckedChanged += new System.EventHandler(this.rdTienphucap_CheckedChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(175, 58);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 45);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // rdDautu
            // 
            this.rdDautu.AutoSize = true;
            this.rdDautu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDautu.Location = new System.Drawing.Point(50, 66);
            this.rdDautu.Name = "rdDautu";
            this.rdDautu.Size = new System.Drawing.Size(78, 22);
            this.rdDautu.TabIndex = 9;
            this.rdDautu.TabStop = true;
            this.rdDautu.Text = "Đầu tư";
            this.rdDautu.UseVisualStyleBackColor = true;
            this.rdDautu.CheckedChanged += new System.EventHandler(this.rdDautu_CheckedChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(175, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 45);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // rdTienluong
            // 
            this.rdTienluong.AutoSize = true;
            this.rdTienluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTienluong.Location = new System.Drawing.Point(50, 15);
            this.rdTienluong.Name = "rdTienluong";
            this.rdTienluong.Size = new System.Drawing.Size(107, 22);
            this.rdTienluong.TabIndex = 9;
            this.rdTienluong.TabStop = true;
            this.rdTienluong.Text = "Tiền lương";
            this.rdTienluong.UseVisualStyleBackColor = true;
            this.rdTienluong.CheckedChanged += new System.EventHandler(this.rdTienluong_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 45);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 45);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlThu";
            this.Size = new System.Drawing.Size(604, 210);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTienthuong;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.RadioButton rdThunhapphu;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RadioButton rdTienphucap;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton rdDautu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdTienluong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
