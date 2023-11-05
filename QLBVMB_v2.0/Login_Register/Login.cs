using QLBVMB_v2._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB_v2._0.Login_Register
{
    public partial class Login : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        public static int role;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Username.Select();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            int flag = 0;
            List<Role> listRole = db.Roles.ToList();
            Role checkQL = new Role();
            #region check username, password
            foreach (var item in listRole)
            {
                if (item.Username.Trim() == txt_Username.Text.Trim() && item.Password.Trim() == txt_Password.Text.Trim())
                {
                    flag = 1;
                    checkQL = item;
                    break;
                }
            }
            #endregion
            #region Check role quản lý
            if (flag == 1)
            {
                if (checkQL.RoleName.Trim().Contains("Quản lý"))
                {
                    role = 1;
                }
                else
                    role = 0;
                this.Hide();
                Main_Form frm = new Main_Form();
                frm.Show();
            }
            #endregion
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Login_Load(sender, e);
            }
        }
        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }
        #region Close Form
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
