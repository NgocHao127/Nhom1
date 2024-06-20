namespace AppBanVeMayBay
{
    partial class FormThongTinTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongTinTaiKhoan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndangky = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvthongtintaikhoan = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbquoctich = new System.Windows.Forms.Label();
            this.lbnamsinh = new System.Windows.Forms.Label();
            this.lbcccd = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.lbtentaikhoan = new System.Windows.Forms.Label();
            this.lbdienthoai = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtintaikhoan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btndangky);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 450);
            this.panel1.TabIndex = 54;
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndangky.FlatAppearance.BorderSize = 0;
            this.btndangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndangky.ForeColor = System.Drawing.Color.Lavender;
            this.btndangky.Location = new System.Drawing.Point(37, 183);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(141, 29);
            this.btndangky.TabIndex = 57;
            this.btndangky.Text = "Sửa Thông Tin";
            this.btndangky.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dgvthongtintaikhoan);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 450);
            this.panel2.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(155, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "Số vé chưa thanh toán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 96;
            this.label8.Text = "0";
            // 
            // dgvthongtintaikhoan
            // 
            this.dgvthongtintaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtintaikhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvthongtintaikhoan.Location = new System.Drawing.Point(0, 224);
            this.dgvthongtintaikhoan.Name = "dgvthongtintaikhoan";
            this.dgvthongtintaikhoan.Size = new System.Drawing.Size(588, 226);
            this.dgvthongtintaikhoan.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "Số vé đã mua:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtten);
            this.panel3.Controls.Add(this.txttaikhoan);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lbgioitinh);
            this.panel3.Controls.Add(this.lbemail);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbquoctich);
            this.panel3.Controls.Add(this.lbnamsinh);
            this.panel3.Controls.Add(this.lbcccd);
            this.panel3.Controls.Add(this.lbten);
            this.panel3.Controls.Add(this.lbtentaikhoan);
            this.panel3.Controls.Add(this.lbdienthoai);
            this.panel3.Controls.Add(this.lbmatkhau);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 173);
            this.panel3.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "nữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Thuhuyen6@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "Hà Nội";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Việt Nam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "2000-05-24";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "9876544567";
            // 
            // txtten
            // 
            this.txtten.AutoSize = true;
            this.txtten.Location = new System.Drawing.Point(41, 63);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(60, 13);
            this.txtten.TabIndex = 88;
            this.txtten.Text = "Thu Huyền";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.AutoSize = true;
            this.txttaikhoan.Location = new System.Drawing.Point(93, 25);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(61, 13);
            this.txttaikhoan.TabIndex = 87;
            this.txttaikhoan.Text = "Thuhuyen6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "2444576735";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(457, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "123";
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Location = new System.Drawing.Point(208, 25);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(54, 13);
            this.lbgioitinh.TabIndex = 84;
            this.lbgioitinh.Text = "Giới Tính:";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(208, 63);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(35, 13);
            this.lbemail.TabIndex = 83;
            this.lbemail.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Địa Chỉ:";
            // 
            // lbquoctich
            // 
            this.lbquoctich.AutoSize = true;
            this.lbquoctich.Location = new System.Drawing.Point(395, 25);
            this.lbquoctich.Name = "lbquoctich";
            this.lbquoctich.Size = new System.Drawing.Size(60, 13);
            this.lbquoctich.TabIndex = 81;
            this.lbquoctich.Text = "Quốc Tịch:";
            // 
            // lbnamsinh
            // 
            this.lbnamsinh.AutoSize = true;
            this.lbnamsinh.Location = new System.Drawing.Point(208, 98);
            this.lbnamsinh.Name = "lbnamsinh";
            this.lbnamsinh.Size = new System.Drawing.Size(59, 13);
            this.lbnamsinh.TabIndex = 80;
            this.lbnamsinh.Text = "Ngày Sinh:";
            // 
            // lbcccd
            // 
            this.lbcccd.AutoSize = true;
            this.lbcccd.Location = new System.Drawing.Point(6, 98);
            this.lbcccd.Name = "lbcccd";
            this.lbcccd.Size = new System.Drawing.Size(39, 13);
            this.lbcccd.TabIndex = 79;
            this.lbcccd.Text = "CCCD:";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(6, 63);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(29, 13);
            this.lbten.TabIndex = 78;
            this.lbten.Text = "Tên:";
            // 
            // lbtentaikhoan
            // 
            this.lbtentaikhoan.AutoSize = true;
            this.lbtentaikhoan.Location = new System.Drawing.Point(6, 25);
            this.lbtentaikhoan.Name = "lbtentaikhoan";
            this.lbtentaikhoan.Size = new System.Drawing.Size(81, 13);
            this.lbtentaikhoan.TabIndex = 77;
            this.lbtentaikhoan.Text = "Tên Tài Khoản:";
            // 
            // lbdienthoai
            // 
            this.lbdienthoai.AutoSize = true;
            this.lbdienthoai.Location = new System.Drawing.Point(6, 134);
            this.lbdienthoai.Name = "lbdienthoai";
            this.lbdienthoai.Size = new System.Drawing.Size(62, 13);
            this.lbdienthoai.TabIndex = 76;
            this.lbdienthoai.Text = "Điện Thoại:";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Location = new System.Drawing.Point(395, 63);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(56, 13);
            this.lbmatkhau.TabIndex = 75;
            this.lbmatkhau.Text = "Mật Khẩu:";
            // 
            // FormThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormThongTinTaiKhoan";
            this.Text = "Thông Tin Tài Khoản";
            this.Load += new System.EventHandler(this.FormThongTinTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtintaikhoan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvthongtintaikhoan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbgioitinh;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbquoctich;
        private System.Windows.Forms.Label lbnamsinh;
        private System.Windows.Forms.Label lbcccd;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label lbtentaikhoan;
        private System.Windows.Forms.Label lbdienthoai;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtten;
        private System.Windows.Forms.Label txttaikhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btndangky;
    }
}