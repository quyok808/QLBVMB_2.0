namespace QLBVMB_v2._0.TrangChu
{
    partial class ThongTinKhachHangMuaVe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Huy = new Sunny.UI.UIButton();
            this.btn_Them = new Sunny.UI.UIButton();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số căn cước công dân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(243, 251);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(342, 40);
            this.txt_TenKH.TabIndex = 1;
            this.txt_TenKH.Leave += new System.EventHandler(this.txt_TenKH_Leave);
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_MaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_MaKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_MaKH.ForeColor = System.Drawing.Color.Black;
            this.lb_MaKH.Location = new System.Drawing.Point(243, 188);
            this.lb_MaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(342, 42);
            this.lb_MaKH.TabIndex = 0;
            this.lb_MaKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(598, 173);
            this.panel_Logo.TabIndex = 12;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(243, 373);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(342, 40);
            this.txt_CCCD.TabIndex = 3;
            this.txt_CCCD.Leave += new System.EventHandler(this.txt_CCCD_Leave);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(243, 434);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(342, 40);
            this.txt_Email.TabIndex = 4;
            this.txt_Email.Tag = "";
            this.txt_Email.Enter += new System.EventHandler(this.txt_Email_Enter);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Huy.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Huy.FillPressColor = System.Drawing.Color.Red;
            this.btn_Huy.Font = new System.Drawing.Font("#9Slide03 Arima Madurai ExtraBo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.Black;
            this.btn_Huy.Location = new System.Drawing.Point(385, 491);
            this.btn_Huy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.RectColor = System.Drawing.Color.Transparent;
            this.btn_Huy.RectHoverColor = System.Drawing.Color.Transparent;
            this.btn_Huy.RectPressColor = System.Drawing.Color.Transparent;
            this.btn_Huy.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btn_Huy.Size = new System.Drawing.Size(151, 59);
            this.btn_Huy.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Huy.TabIndex = 6;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Huy.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Them.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Them.FillPressColor = System.Drawing.Color.Lime;
            this.btn_Them.Font = new System.Drawing.Font("#9Slide03 Arima Madurai ExtraBo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Location = new System.Drawing.Point(82, 491);
            this.btn_Them.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.RectColor = System.Drawing.Color.Transparent;
            this.btn_Them.RectHoverColor = System.Drawing.Color.Transparent;
            this.btn_Them.RectPressColor = System.Drawing.Color.Transparent;
            this.btn_Them.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btn_Them.Size = new System.Drawing.Size(151, 59);
            this.btn_Them.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "OK";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Them.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // DTP_NgaySinh
            // 
            this.DTP_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_NgaySinh.Location = new System.Drawing.Point(243, 312);
            this.DTP_NgaySinh.Name = "DTP_NgaySinh";
            this.DTP_NgaySinh.Size = new System.Drawing.Size(342, 40);
            this.DTP_NgaySinh.TabIndex = 2;
            this.DTP_NgaySinh.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // ThongTinKhachHangMuaVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 563);
            this.Controls.Add(this.DTP_NgaySinh);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.panel_Logo);
            this.Controls.Add(this.lb_MaKH);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("#9Slide03 Arima Madurai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ThongTinKhachHangMuaVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinKhachHangMuaVe";
            this.Load += new System.EventHandler(this.ThongTinKhachHangMuaVe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_Logo;
        private Sunny.UI.UIButton btn_Huy;
        private Sunny.UI.UIButton btn_Them;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_TenKH;
        public System.Windows.Forms.Label lb_MaKH;
        public System.Windows.Forms.TextBox txt_CCCD;
        public System.Windows.Forms.TextBox txt_Email;
        public System.Windows.Forms.DateTimePicker DTP_NgaySinh;
    }
}