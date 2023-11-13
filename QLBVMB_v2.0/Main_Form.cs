using QLBVMB_v2._0.Models;
using Sunny.UI;
using Sunny.UI.Win32;
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
        #region Các biến
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
        #endregion
        public Main_Form()
        {
            InitializeComponent();
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            List<CHUYENBAY> listCB = db.CHUYENBAYs.ToList();
            rd_TrangChu_1chieu.Checked = true;
            DTP_TrangChu_NgayVe.Visible = false;
            lb_TrangChu_NgayVe.Visible = false;
            cmb_TrangChu_NoiDi.DataSource = listNoiDi;
            Filldgv_TrangChu_ThongTinChuyenBay(listCB);
        }

        #region Trang Chủ

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
        #region Form controls
        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Button Lọc
        private void btn_TrangChu_Loc_Click(object sender, EventArgs e)
        {
            try
            {
                if (rd_TrangChu_1chieu.Checked)
                    {
                        #region fill listCB 1 chiều
                        List<CHUYENBAY> listCB = new List<CHUYENBAY>();
                        List<CHUYENBAY> listTemp = db.CHUYENBAYs.Where(p => p.NoiDi.Trim() == cmb_TrangChu_NoiDi.Text.Trim() && p.NoiDen.Trim() == cmb_TrangChu_NoiDen.Text.Trim()).ToList();
                        foreach (var item in listTemp)
                        {
                            TimeSpan time = item.GioKhoiHanh.Value.Subtract(DTP_TrangChu_NgayDi.Value);
                            int Days = time.Days;
                            if (Days == 0)
                            {
                                listCB.Add(item);
                            }
                        }
                        if (listCB.Count > 0)
                        {
                            Filldgv_TrangChu_ThongTinChuyenBay(listCB);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        #endregion
                    }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Không tìm thấy dữ liệu !","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Filldgv_TrangChu_ThongTinChuyenBay(List<CHUYENBAY> listCB)
        {
            dgv_TrangChu_ThongTinChuyenBay.Rows.Clear();
            for (int i = 0; i <  listCB.Count; i++)
            {
                int newRow = dgv_TrangChu_ThongTinChuyenBay.Rows.Add();
                dgv_TrangChu_ThongTinChuyenBay.Rows[i].Cells[0].Value = listCB[i].MaCB.Trim();
                dgv_TrangChu_ThongTinChuyenBay.Rows[i].Cells[1].Value = listCB[i].GioKhoiHanh.Value.ToString("HH:mm");
                dgv_TrangChu_ThongTinChuyenBay.Rows[i].Cells[2].Value = listCB[i].HANGHANGKHONG.TenHang;
            }
        }
        #endregion
        #region fill cmb nơi đến
        private void cmb_TrangChu_NoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> listNoiDen = listNoiDi.Where(p => p != cmb_TrangChu_NoiDi.Text.Trim()).ToList();
            cmb_TrangChu_NoiDen.DataSource = listNoiDen;
        }
        #endregion
        #region DateTimePicker Controls
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_TrangChu_1chieu.Checked)
            {
                DTP_TrangChu_NgayVe.Visible = false;
                lb_TrangChu_NgayVe.Visible = false;
            }
            else
            {
                DTP_TrangChu_NgayVe.Value = DTP_TrangChu_NgayDi.Value.Tomorrow();
                DTP_TrangChu_NgayVe.Visible = true;
                lb_TrangChu_NgayVe.Visible = true;
            }
        }

        private void DTP_TrangChu_NgayDi_ValueChanged(object sender, EventArgs e)
        {
            DTP_TrangChu_NgayVe.Value = DTP_TrangChu_NgayDi.Value.Tomorrow();
        }

        private void DTP_TrangChu_NgayVe_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan time = DTP_TrangChu_NgayVe.Value.Subtract(DTP_TrangChu_NgayDi.Value);
            int minutes = (int)time.TotalMinutes;
            if (minutes < 0)
            {
                MessageBox.Show("Ngày đi phải lớn hơn ngày về !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DTP_TrangChu_NgayVe.Value = DTP_TrangChu_NgayDi.Value.Tomorrow();
            }
        }
        #endregion
        #region Chọn ghế ngồi
        private void dgv_TrangChu_ThongTinChuyenBay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TrangChu_MaCB.Text = dgv_TrangChu_ThongTinChuyenBay.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
        }
        
        private void txt_TrangChu_MaCB_TextChanged(object sender, EventArgs e)
        {
            if (txt_TrangChu_MaCB.Text != "")
            {
                List<Ve> listVe1 = db.Ves.Where(p => p.MaCB.Trim() == txt_TrangChu_MaCB.Text.Trim()).ToList();
                if (listVe1.Count > 0)
                {
                    ChonGhe frm = new ChonGhe(listVe1);
                    frm.TopLevel = false;
                    panel_ChonGhe.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Chuyến bay này chưa có vé !!!", "Thông báo", MessageBoxButtons.OK);
                    txt_TrangChu_MaCB.Text = "";
                    panel_ChonGhe.Controls.Clear();
                }
            }
        }
        #endregion
        #endregion
    }
}
