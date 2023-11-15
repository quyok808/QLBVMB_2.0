using Microsoft.Reporting.Map.WebForms.BingMaps;
using QLBVMB_v2._0.Models;
using QLBVMB_v2._0.Properties;
using QLBVMB_v2._0.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB_v2._0
{
    public partial class ChonGhe : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        List<Ve> listVe;
        public ChonGhe()
        {
            InitializeComponent();
        }

        public ChonGhe(List<Ve> listVe)
        {
            InitializeComponent();
            this.listVe = listVe;
        }

        private void ChonGhe_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Button btn = new Button();
                    btn.Name = listVe[(i * 1 + j * 4)].MaVe;
                    btn.TextAlign = ContentAlignment.TopCenter;
                    btn.Size = new System.Drawing.Size(70, 50);
                    btn.Font = new Font("#9Slide03 Arima Madurai", 8);
                    btn.TabIndex = 0;
                    btn.Text = listVe[(i * 1 + j * 4)].MaVe;
                    btn.Location = new System.Drawing.Point(72 * i + 80, 53 * j + 190);
                    btn.UseVisualStyleBackColor = false;
                    if (listVe[(i * 1 + j * 4)].TrangThai == 1)
                    {
                        btn.BackColor = Color.Gray;
                        btn.Enabled = false;
                    }
                        
                    else
                        btn.BackColor = Color.White;
                    btn.Click += btn_Click;

                    panel_Show.Controls.Add(btn);
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.White)
            {
                if (MessageBox.Show("Bạn có chắc chọn ghế này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Main_Form.mave = button.Text.Trim();
                    ThongTinKhachHangMuaVe frm = new ThongTinKhachHangMuaVe();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Main_Form.kh[0] = frm.lb_MaKH.Text.Trim();
                        Main_Form.kh[1] = frm.txt_TenKH.Text;
                        Main_Form.kh[2] = frm.DTP_NgaySinh.Value.ToString("dd/MM/yyyy");
                        Main_Form.kh[3] = frm.txt_CCCD.Text;
                        Main_Form.kh[4] = frm.txt_Email.Text;
                    }
                }
            }
        }
    }
}
