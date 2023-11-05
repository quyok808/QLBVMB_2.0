namespace QLBVMB_v2._0.Login_Register
{
    partial class Login
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
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new Sunny.UI.UIButton();
            this.btn_Thoat = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.AvatarSize = 130;
            this.uiAvatar1.FillColor = System.Drawing.Color.White;
            this.uiAvatar1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiAvatar1.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.uiAvatar1.Image = global::QLBVMB_v2._0.Properties.Resources.logo_ao_lop_hinh_may_bay_thiet_ke_doc_la_jpg;
            this.uiAvatar1.Location = new System.Drawing.Point(146, 12);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(175, 165);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.SymbolSize = 70;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.White;
            this.txt_Username.Font = new System.Drawing.Font("#9Slide03 Arima Madurai ExtraBo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(158, 195);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(289, 45);
            this.txt_Username.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai ExtraBo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.Font = new System.Drawing.Font("#9Slide03 Arima Madurai ExtraBo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(158, 256);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(289, 45);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("#9Slide03 Arima Madurai ExtraBo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FillPressColor = System.Drawing.Color.Blue;
            this.btn_Login.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(44, 327);
            this.btn_Login.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(145, 46);
            this.btn_Login.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Thoat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Thoat.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Thoat.FillPressColor = System.Drawing.Color.Red;
            this.btn_Thoat.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(273, 327);
            this.btn_Thoat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Thoat.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Thoat.RectPressColor = System.Drawing.Color.Red;
            this.btn_Thoat.Size = new System.Drawing.Size(145, 46);
            this.btn_Thoat.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(459, 403);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.uiAvatar1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton btn_Login;
        private Sunny.UI.UIButton btn_Thoat;
    }
}