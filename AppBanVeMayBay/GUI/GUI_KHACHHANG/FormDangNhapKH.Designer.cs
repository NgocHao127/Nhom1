namespace AppBanVeMayBay.GUI.GUI_KHACHHANG
{
    partial class FormDangNhapKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhapKH));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbtentaikhoan = new System.Windows.Forms.Label();
            this.linkdangky = new System.Windows.Forms.LinkLabel();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.txttentaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.linkquenmatkhau = new System.Windows.Forms.LinkLabel();
            this.btndangky = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbtentaikhoan
            // 
            this.lbtentaikhoan.AutoSize = true;
            this.lbtentaikhoan.Location = new System.Drawing.Point(60, 240);
            this.lbtentaikhoan.Name = "lbtentaikhoan";
            this.lbtentaikhoan.Size = new System.Drawing.Size(78, 13);
            this.lbtentaikhoan.TabIndex = 1;
            this.lbtentaikhoan.Text = "Tên Tài Khoản";
            // 
            // linkdangky
            // 
            this.linkdangky.AutoSize = true;
            this.linkdangky.Location = new System.Drawing.Point(107, 315);
            this.linkdangky.Name = "linkdangky";
            this.linkdangky.Size = new System.Drawing.Size(48, 13);
            this.linkdangky.TabIndex = 2;
            this.linkdangky.TabStop = true;
            this.linkdangky.Text = "Đăng Ký";
            this.linkdangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkdangky_LinkClicked);
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Location = new System.Drawing.Point(60, 280);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(53, 13);
            this.lbmatkhau.TabIndex = 3;
            this.lbmatkhau.Text = "Mật Khẩu";
            // 
            // txttentaikhoan
            // 
            this.txttentaikhoan.Location = new System.Drawing.Point(144, 237);
            this.txttentaikhoan.Name = "txttentaikhoan";
            this.txttentaikhoan.Size = new System.Drawing.Size(218, 20);
            this.txttentaikhoan.TabIndex = 4;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(144, 277);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(220, 20);
            this.txtmatkhau.TabIndex = 5;
            // 
            // linkquenmatkhau
            // 
            this.linkquenmatkhau.AutoSize = true;
            this.linkquenmatkhau.Location = new System.Drawing.Point(247, 315);
            this.linkquenmatkhau.Name = "linkquenmatkhau";
            this.linkquenmatkhau.Size = new System.Drawing.Size(82, 13);
            this.linkquenmatkhau.TabIndex = 6;
            this.linkquenmatkhau.TabStop = true;
            this.linkquenmatkhau.Text = "Quên Mật Khẩu";
            this.linkquenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkquenmatkhau_LinkClicked);
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndangky.FlatAppearance.BorderSize = 0;
            this.btndangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndangky.ForeColor = System.Drawing.Color.Lavender;
            this.btndangky.Location = new System.Drawing.Point(159, 342);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(111, 43);
            this.btndangky.TabIndex = 13;
            this.btndangky.Text = "Đăng Nhập";
            this.btndangky.UseVisualStyleBackColor = false;
            this.btndangky.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 404);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bạn là quản lý?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormDangNhapKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 426);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.linkquenmatkhau);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttentaikhoan);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.linkdangky);
            this.Controls.Add(this.lbtentaikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDangNhapKH";
            this.Text = "FormDangNhapKH";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbtentaikhoan;
        private System.Windows.Forms.LinkLabel linkdangky;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.TextBox txttentaikhoan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.LinkLabel linkquenmatkhau;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}