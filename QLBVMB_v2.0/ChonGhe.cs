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

namespace QLBVMB_v2._0
{
    public partial class ChonGhe : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        string maCB;
        public ChonGhe()
        {
            InitializeComponent();
        }

        public ChonGhe(string MaCB)
        {
            InitializeComponent();
            maCB = MaCB;
        }

        private void ChonGhe_Load(object sender, EventArgs e)
        {
            List<Ve> listVe = db.Ves.Where(p => p.MaCB.Trim() == maCB.Trim()).ToList();
            if (listVe.Count > 0 )
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        Button btn = new Button();
                        btn.Name = listVe[(i * 1 + j * 4)].MaVe;
                        btn.Size = new System.Drawing.Size(70, 50);
                        btn.Font = new Font("#9Slide03 Arima Madurai", 8);
                        btn.TabIndex = 0;
                        btn.Text = listVe[(i * 1 + j * 4)].MaVe;
                        btn.Location = new Point(72 * i + 80, 53 * j + 190);
                        btn.UseVisualStyleBackColor = false;
                        if (listVe[(i * 1 + j * 4)].TrangThai == 1)
                            btn.BackColor = Color.Gray;
                        else
                            btn.BackColor = Color.White;
                        //btn.Click += btn_Click;

                        panel_Show.Controls.Add(btn);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chuyến bay này chưa có vé !!!", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
