namespace AppBanVeMayBay
{
    partial class FormQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuenMatKhau));
            this.ptbdangnhap = new System.Windows.Forms.PictureBox();
            this.btnlaylaimatkhau = new System.Windows.Forms.Button();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbdangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbdangnhap
            // 
            this.ptbdangnhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbdangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbdangnhap.ErrorImage = null;
            this.ptbdangnhap.Image = ((System.Drawing.Image)(resources.GetObject("ptbdangnhap.Image")));
            this.ptbdangnhap.InitialImage = null;
            this.ptbdangnhap.Location = new System.Drawing.Point(102, 31);
            this.ptbdangnhap.Name = "ptbdangnhap";
            this.ptbdangnhap.Size = new System.Drawing.Size(174, 172);
            this.ptbdangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbdangnhap.TabIndex = 15;
            this.ptbdangnhap.TabStop = false;
            // 
            // btnlaylaimatkhau
            // 
            this.btnlaylaimatkhau.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnlaylaimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnlaylaimatkhau.ForeColor = System.Drawing.Color.Lavender;
            this.btnlaylaimatkhau.Location = new System.Drawing.Point(102, 317);
            this.btnlaylaimatkhau.Name = "btnlaylaimatkhau";
            this.btnlaylaimatkhau.Size = new System.Drawing.Size(148, 41);
            this.btnlaylaimatkhau.TabIndex = 12;
            this.btnlaylaimatkhau.Text = "Lấy Lại Mật Khẩu";
            this.btnlaylaimatkhau.UseVisualStyleBackColor = false;
            this.btnlaylaimatkhau.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(148, 221);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(172, 20);
            this.txttaikhoan.TabIndex = 9;
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.Location = new System.Drawing.Point(59, 224);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(56, 13);
            this.lbtaikhoan.TabIndex = 8;
            this.lbtaikhoan.Text = "Tài Khoản";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(148, 262);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(172, 20);
            this.txtemail.TabIndex = 25;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(60, 265);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(32, 13);
            this.lbemail.TabIndex = 24;
            this.lbemail.Text = "Email";
            // 
            // FormQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 387);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.ptbdangnhap);
            this.Controls.Add(this.btnlaylaimatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.lbtaikhoan);
            this.Name = "FormQuenMatKhau";
            this.Text = "Quên Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.ptbdangnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbdangnhap;
        private System.Windows.Forms.Button btnlaylaimatkhau;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label lbtaikhoan;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lbemail;
    }
}