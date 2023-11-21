using QLBVMB_v2._0.Models;
using QLBVMB_v2._0.TrangChu;
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
            rd_TrangChu_1chieu.Checked = true;
            DTP_TrangChu_NgayVe.Visible = false;
            lb_TrangChu_NgayVe.Visible = false;
            cmb_TrangChu_NoiDi.DataSource = listNoiDi;
            
            List<CHUYENBAY> listCB = db.CHUYENBAYs.Where(p => DateTime.Compare(p.GioKhoiHanh.Value,DateTime.Now) > 0).ToList();
            Filldgv_TrangChu_ThongTinChuyenBay(listCB);
            List<NHANVIEN> listnv = db.NHANVIENs.ToList();
            fill_dgv_thongtinnhanvien(listnv);
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
        private List<CHUYENBAY> listCB(string noidi, string noiden, DateTimePicker ngaydi)
        {
            List<CHUYENBAY> ListCB = new List<CHUYENBAY>();
            List<CHUYENBAY> listTemp = db.CHUYENBAYs.Where(p => p.NoiDi.Trim() == noidi && p.NoiDen.Trim() == noiden).ToList();
            foreach (var item in listTemp)
            {
                TimeSpan time = item.GioKhoiHanh.Value.Subtract(ngaydi.Value);
                int Days = time.Days;
                if (Days == 0)
                {
                    ListCB.Add(item);
                }
            }
            return ListCB;
        }

        private void btn_TrangChu_Loc_Click(object sender, EventArgs e)
        {
            try
            {
                #region fill listCB 1 chiều
                    
                if (listCB(cmb_TrangChu_NoiDi.Text.Trim(), cmb_TrangChu_NoiDen.Text.Trim(), DTP_TrangChu_NgayDi).Count > 0)
                {
                    Filldgv_TrangChu_ThongTinChuyenBay(listCB(cmb_TrangChu_NoiDi.Text.Trim(), cmb_TrangChu_NoiDen.Text.Trim(), DTP_TrangChu_NgayDi));
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                #endregion
            }
            catch
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
                dgv_TrangChu_ThongTinChuyenBay.Rows[i].Cells[3].Value = listCB[i].NoiDi;
                dgv_TrangChu_ThongTinChuyenBay.Rows[i].Cells[4].Value = listCB[i].NoiDen;
                dgv_TrangChu_ThongTinChuyenBay.Rows[i].Cells[5].Value = listCB[i].GioKhoiHanh.Value.ToString("dd/MM/yyyy");
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
            if (e.RowIndex == -1)
            {
                // Đây là header của cột, không thực hiện xử lý dưới đây
                return;
            }
            txt_TrangChu_MaCB.Text = dgv_TrangChu_ThongTinChuyenBay.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
        }
        List<string> list = new List<string>();
        private void txt_TrangChu_MaCB_TextChanged(object sender, EventArgs e) // hiện ghế bên dgv trái trong trang chủ
        {
            panel_ChonGhe.Controls.Clear();
            if (txt_TrangChu_MaCB.Text != "")
            {
                List<Ve> listVe1 = db.Ves.Where(p => p.MaCB.Trim() == txt_TrangChu_MaCB.Text.Trim()).ToList();
                if (listVe1.Count > 0)
                {
                    ChonGhe frm = new ChonGhe(listVe1);
                    frm.TopLevel = false;
                    panel_ChonGhe.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.DataEntered += (senders, es) =>
                    {
                        list = frm.dataDgv_ThongtinHoaDon;
                        Filldgv_TrangChu_ThongTinHoaDon(frm.dataDgv_ThongtinHoaDon);
                        
                        txt_TrangChu_MaCB.Text = "";
                        if (rd_TrangChu_KhuHoi.Checked)
                        {
                            Filldgv_TrangChu_ThongTinChuyenBay(listCB(cmb_TrangChu_NoiDen.Text.Trim(), cmb_TrangChu_NoiDi.Text.Trim(), DTP_TrangChu_NgayVe));
                        }
                        list = null;
                    };
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

        private int tongTien()
        {
            int tong = 0;
            for (int i = 0; i < dgv_TrangChu_ThongTinHoaDon.Rows.Count; i++)
            {
                tong += int.Parse(dgv_TrangChu_ThongTinHoaDon.Rows[i].Cells[9].Value.ToString().Trim());
            }
            return tong;
        }
        public void Filldgv_TrangChu_ThongTinHoaDon(List<string> data)
        {
            int newrow = dgv_TrangChu_ThongTinHoaDon.Rows.Add();
            dgv_TrangChu_ThongTinHoaDon.Rows[newrow].Cells[0].Value = data[0];
            dgv_TrangChu_ThongTinHoaDon.Rows[newrow].Cells[1].Value = data[1];
            dgv_TrangChu_ThongTinHoaDon.Rows[newrow].Cells[2].Value = data[2];
            dgv_TrangChu_ThongTinHoaDon.Rows[newrow].Cells[3].Value = data[3];
            dgv_TrangChu_ThongTinHoaDon.Rows[newrow].Cells[4].Value = cmb_TrangChu_NoiDi.Text;
            dgv_TrangChu_ThongTinHoaDon.Rows[newrow].Cells[5].Value = cmb_TrangChu_NoiDen.Text;
            dgv_TrangChu_ThongTinHoaDon.Rows[newrow].Cells[6].Value = data[4];
            dgv_TrangChu_ThongTinHoaDon.Rows[newrow].Cells[7].Value = txt_TrangChu_MaCB.Text.Trim();
            dgv_TrangChu_ThongTinHoaDon.Rows[newrow].Cells[8].Value = data[5];
            dgv_TrangChu_ThongTinHoaDon.Rows[newrow].Cells[9].Value = data[6];
            txt_TrangChu_TongTien.Text = tongTien().ToString();
        }
        #endregion
        #region Xem thông tin chuyến bay đang chọn
        private void dgv_TrangChu_ThongTinChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    // Đây là header của cột, không thực hiện xử lý dưới đây
                    return;
                }
                cmb_TrangChu_NoiDi.Text = dgv_TrangChu_ThongTinChuyenBay.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmb_TrangChu_NoiDen.Text = dgv_TrangChu_ThongTinChuyenBay.Rows[e.RowIndex].Cells[4].Value.ToString();
                DTP_TrangChu_NgayDi.Value = DateTime.Parse(dgv_TrangChu_ThongTinChuyenBay.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"tet");
            }
        }
        #endregion

        #region Thông tin nhân viên
        private void fill_dgv_thongtinnhanvien(List<NHANVIEN> listnv)
        {
            dgv_Thongtinnhanvien.Rows.Clear();
            foreach (var item in listnv)
            {
                int newrow = dgv_Thongtinnhanvien.Rows.Add();
                dgv_Thongtinnhanvien.Rows[newrow].Cells[0].Value = item.MaNV;
                dgv_Thongtinnhanvien.Rows[newrow].Cells[1].Value = item.TenNV;
                dgv_Thongtinnhanvien.Rows[newrow].Cells[2].Value = item.Email;
            }
        }
        private void txtmanv_TextChanged(object sender, EventArgs e)
        {
            List<NHANVIEN> listnv = db.NHANVIENs.Where(p => p.MaNV.Trim().Contains(txtmanv.Text)).ToList();
            fill_dgv_thongtinnhanvien(listnv);
        }

        private void txttennv_TextChanged(object sender, EventArgs e)
        {
            List<NHANVIEN> listnv = db.NHANVIENs.Where(p => p.TenNV.Trim().Contains(txttennv.Text)).ToList();
            fill_dgv_thongtinnhanvien(listnv);
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            List<NHANVIEN> listnv = db.NHANVIENs.Where(p => p.Email.Trim().Contains(txtemail.Text)).ToList();
            fill_dgv_thongtinnhanvien(listnv);
        }
        private void dgv_Thongtinnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string manv = dgv_Thongtinnhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(p => p.MaNV.Trim() == manv.Trim());
            Thông_tin_nhân_viên f = new Thông_tin_nhân_viên(nv);
            f.Show();
        }
        #endregion
        private void btn_TrangChu_Xoa_Click(object sender, EventArgs e)
        {
            dgv_TrangChu_ThongTinHoaDon.Rows.Clear();
            txt_TrangChu_TongTien.Text = "";
        }

        
        #endregion


    }
}
