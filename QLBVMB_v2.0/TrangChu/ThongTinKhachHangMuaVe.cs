using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                if (txt_TenKH.Text == "")
                {
                    txt_TenKH.Select();
                    throw new Exception("Tên không được để trống");
                }
                txt_TenKH.Text = txt_TenKH.Text.ToUpper();
                txt_TenKH.Text.Trim(); //Xoá khoảng trắng thừa đầu cuối
                Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
                txt_TenKH.Text = trimmer.Replace(txt_TenKH.Text, " ");

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void txt_CCCD_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_CCCD.Text == "")
                {
                    txt_CCCD.Select();
                    throw new Exception("Số căn cước công dân không được để trống");
                }
                if (txt_CCCD.Text.Count() != 12)
                {
                    txt_CCCD.Select();
                    throw new Exception("Số căn cước bị sai hoặc không hợp lệ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txt_Email_Enter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Nên điền email bạn hay sử dụng để gửi thông tin về vé cho bạn",txt_Email);
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Email.Text == "")
                {
                    txt_Email.Select();
                    throw new Exception("Email không được để trống");
                }
                if (!txt_Email.Text.Contains("@gmail.com"))
                {
                    txt_Email.Select();
                    throw new Exception("Email không đúng định dạng (vd: abc@gmail.com)");
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
