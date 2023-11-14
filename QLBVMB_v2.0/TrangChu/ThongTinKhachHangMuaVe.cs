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
        public ThongTinKhachHangMuaVe()
        {
            InitializeComponent();
        }

        private void ThongTinKhachHangMuaVe_Load(object sender, EventArgs e)
        {
            txt_TenKH.Select();
            lb_MaKH.Text = Generate_MaKH();
        }

        private string Generate_MaKH()
        {
            throw new NotImplementedException();
        }
    }
}
