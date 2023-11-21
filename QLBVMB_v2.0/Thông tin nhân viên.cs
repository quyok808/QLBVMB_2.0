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
    public partial class Thông_tin_nhân_viên : Form
    {
        public Thông_tin_nhân_viên()
        {
            InitializeComponent();
        }
        NHANVIEN nv;
        public Thông_tin_nhân_viên(NHANVIEN nv)
        {
            InitializeComponent();
           
            txtmanv.Text = nv.MaNV;
            txtten.Text = nv.TenNV;
            txtsdt.Text = nv.SDT;
            txtnoicap.Text = nv.NoiCap;
            txtemail.Text = nv.Email;
            txtluong.Text = nv.Luong.ToString();
            txtdantoc.Text = nv.Dantoc;
            txtchucvu.Text = nv.ChucVu;
            txtcccd.Text = nv.SoCCCD;
            txtdiachi.Text = nv.DiaChi;
            dtngaycap.Value = nv.NgayCap;
            dtngaysinh.Value = nv.NgaySinh;

        }

        private void Thông_tin_nhân_viên_Load(object sender, EventArgs e)
        {
            
        }
    }
}
