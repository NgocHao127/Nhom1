namespace AppBanVeMayBay
{
    partial class FormDangNhapQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhapQL));
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.linkquestion = new System.Windows.Forms.LinkLabel();
            this.ptbdangnhap = new System.Windows.Forms.PictureBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.lbmatkhau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbdangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtaikhoan.Location = new System.Drawing.Point(69, 209);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(78, 13);
            this.lbtaikhoan.TabIndex = 0;
            this.lbtaikhoan.Text = "Tên Tài Khoản";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(158, 206);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(172, 20);
            this.txttaikhoan.TabIndex = 1;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndangnhap.ForeColor = System.Drawing.Color.Lavender;
            this.btndangnhap.Location = new System.Drawing.Point(144, 291);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(117, 41);
            this.btndangnhap.TabIndex = 4;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // linkquestion
            // 
            this.linkquestion.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkquestion.AutoSize = true;
            this.linkquestion.Location = new System.Drawing.Point(12, 343);
            this.linkquestion.Name = "linkquestion";
            this.linkquestion.Size = new System.Drawing.Size(103, 13);
            this.linkquestion.TabIndex = 5;
            this.linkquestion.TabStop = true;
            this.linkquestion.Text = "Bạn là khách hàng?";
            this.linkquestion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkquestion_LinkClicked);
            // 
            // ptbdangnhap
            // 
            this.ptbdangnhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbdangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbdangnhap.ErrorImage = null;
            this.ptbdangnhap.Image = ((System.Drawing.Image)(resources.GetObject("ptbdangnhap.Image")));
            this.ptbdangnhap.InitialImage = null;
            this.ptbdangnhap.Location = new System.Drawing.Point(113, 8);
            this.ptbdangnhap.Name = "ptbdangnhap";
            this.ptbdangnhap.Size = new System.Drawing.Size(174, 172);
            this.ptbdangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbdangnhap.TabIndex = 7;
            this.ptbdangnhap.TabStop = false;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(158, 243);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(172, 20);
            this.txtmatkhau.TabIndex = 9;
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbmatkhau.Location = new System.Drawing.Point(69, 246);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(53, 13);
            this.lbmatkhau.TabIndex = 8;
            this.lbmatkhau.Text = "Mật Khẩu";
            // 
            // FormDangNhapQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(405, 370);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.ptbdangnhap);
            this.Controls.Add(this.linkquestion);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.lbtaikhoan);
            this.Name = "FormDangNhapQL";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.ptbdangnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtaikhoan;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.LinkLabel linkquestion;
        private System.Windows.Forms.PictureBox ptbdangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label lbmatkhau;
    }
}