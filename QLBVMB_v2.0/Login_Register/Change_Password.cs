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
    public partial class Change_Password : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        public Change_Password()
        {
            InitializeComponent();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            txt_Username.Select();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                Role role_change = db.Roles.FirstOrDefault(p => p.Username.Trim() == txt_Username.Text.Trim());
                if (role_change != null)
                {
                    if (txt_newpass.Text.Trim() == txt_confirmPass.Text.Trim())
                    {
                        if (role_change.Password.Trim() == txt_Password.Text.Trim())
                        {
                            role_change.Password = txt_newpass.Text.Trim();
                            db.SaveChanges();
                            MessageBox.Show("Thay đổi mật khẩu thành công","Thông báo",MessageBoxButtons.OK); ;
                        }
                        else
                        {
                            throw new Exception("Mật khẩu sai");
                        }
                    }
                    else
                    {
                        throw new Exception("Xác nhận mật khẩu không khớp với mật khẩu mới");
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Change_Password_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
