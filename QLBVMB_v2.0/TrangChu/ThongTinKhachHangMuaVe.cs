using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB_v2._0.TrangChu
{
    public partial class ThongTinKhachHangMuaVe : Form
    {
        string maKH = "";
        public ThongTinKhachHangMuaVe()
        {
            InitializeComponent();
        }

        private void ThongTinKhachHangMuaVe_Load(object sender, EventArgs e)
        {
            txt_TenKH.Select();
        }

        private void txt_TenKH_Leave(object sender, EventArgs e)
        {
            txt_TenKH.Text = txt_TenKH.Text.ToUpper();
            #region Tạo phần chữ của maKH
            maKH = txt_TenKH.Text[0].ToString();
            for (int i = 1; i < txt_TenKH.Text.Length; i++)
            {
                if (txt_TenKH.Text[i-1] == ' ')
                {
                    maKH += txt_TenKH.Text[i];
                }
            }
            #endregion
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            #region tạo phần số của maKH
            maKH += DTP_NgaySinh.Value.ToString("dd");
            maKH += DTP_NgaySinh.Value.ToString("MM");
            maKH += DTP_NgaySinh.Value.ToString("yy");
            #endregion
            lb_MaKH.Text = maKH;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            maKH = "";
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
