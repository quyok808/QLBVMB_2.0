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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLBVMB_v2._0
{
    public partial class Main_Form : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        List<string> listNoiDi = new List<string>()
        {
            "Hà Nội",
            "Hồ Chí Minh",
            "Đà Nẵng",
            "Quảng Ninh",
            "Hải Phòng",
            "Nghệ An",
            "Huế",
            "Khánh Hòa",
            "Lâm Đồng",
            "Bình Định",
            "Cần Thơ",
            "Kiên Giang",
            "Đồng Nai"
        };
        public Main_Form()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            //ChonGhe frm = new ChonGhe();
            //frm.TopLevel = false;
            ////panel_Show.Controls.Add(frm);
            //frm.Dock = DockStyle.Fill;
            //frm.Show();

            rd_TrangChu_1chieu.Checked = true;
            DTP_TrangChu_NgayVe.Visible = false;
            lb_TrangChu_NgayVe.Visible = false;
            Fillcmb_TrangChu_NoiDi(listNoiDi);
        }

        private void Fillcmb_TrangChu_NoiDi(List<string> listNoiDi)
        {
            cmb_TrangChu_NoiDi.DataSource = listNoiDi;
        }

        #region Form move
        public Point downPoint = Point.Empty;
        private void Main_Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }

        private void Main_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }

        private void Main_Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

        #endregion

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_TrangChu_1chieu.Checked)
            {
                DTP_TrangChu_NgayVe.Visible = false;
                lb_TrangChu_NgayVe.Visible = false;
            }
            else
            {
                DTP_TrangChu_NgayVe.Visible = true;
                lb_TrangChu_NgayVe.Visible = true;
            }
        }

        private void cmb_TrangChu_NoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> listNoiDen = listNoiDi.Where(p => p != cmb_TrangChu_NoiDi.Text.Trim()).ToList();
            cmb_TrangChu_NoiDen.DataSource = listNoiDen;
        }

        private void btn_TrangChu_Loc_Click(object sender, EventArgs e)
        {
            List<CHUYENBAY> listCB = db.CHUYENBAYs.Where(p => p.NoiDi.Trim() == cmb_TrangChu_NoiDi.Text.Trim() || p.NoiDen.Trim() == cmb_TrangChu_NoiDen.Text.Trim() || p.GioKhoiHanh == DTP_TrangChu_NgayDi.Value).ToList();
            Filldgv_TrangChu_ThongTinChuyenBay(listCB);
        }

        private void Filldgv_TrangChu_ThongTinChuyenBay(List<CHUYENBAY> listCB)
        {
            dgv_TrangChu_ThongTinChuyenBay.Rows.Clear();
            for (int i = 0; i <  listCB.Count; i++)
            {
                int newRow = dgv_TrangChu_ThongTinChuyenBay.Rows.Add();
                dgv_TrangChu_ThongTinChuyenBay.Rows[i].Cells[0].Value = listCB[i].MaCB.Trim();
                dgv_TrangChu_ThongTinChuyenBay.Rows[i].Cells[1].Value = listCB[i].GioKhoiHanh.Value.ToShortTimeString();
                dgv_TrangChu_ThongTinChuyenBay.Rows[i].Cells[2].Value = listCB[i].MAYBAY.HANGHANGKHONG.TenHang;
            }
        }
    }
}
