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
        string Ten;
        string So;
        public ThongTinKhachHangMuaVe()
        {
            InitializeComponent();
        }

        private void ThongTinKhachHangMuaVe_Load(object sender, EventArgs e)
        {
            txt_TenKH.Text = "";
            DTP_NgaySinh.CustomFormat = " ";
        }

        private void txt_TenKH_Leave(object sender, EventArgs e)
        {
            try
            {
                if (check_Chu() == true)
                {
                    txt_TenKH.Text = txt_TenKH.Text.ToUpper();
                }
                else
                {
                    txt_TenKH.Select();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            maKH = " ";
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenKH.Text == "")
            {
                txt_TenKH.Select();
                MessageBox.Show("Tên không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (check_Chu() == false)
                {
                    MessageBox.Show("Tên không được có chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (txt_CCCD.Text == "")
            {
                txt_CCCD.Select();
                MessageBox.Show("CCCD không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_Email.Text == "")
            {
                txt_Email.Select();
                MessageBox.Show("Email không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_CCCD.Text != "" && txt_Email.Text != "@gmail.com" && txt_Email.Text.Contains("@gmail.com"))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txt_CCCD_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_CCCD.Text.Count() > 12)
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
                if (txt_Email.Text != "")
                {
                    if (!txt_Email.Text.Contains("@gmail.com") || txt_Email.Text == "@gmail.com")
                    {
                        txt_Email.Select();
                        throw new Exception("Email không đúng định dạng (vd: abc@gmail.com)");
                    }
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txt_CCCD_TextChanged(object sender, EventArgs e)
        {
            if (txt_CCCD.Text != "")
            {
                foreach(char c in txt_CCCD.Text)
                {
                    if (c < '0' && c > '9')
                    {
                        MessageBox.Show("Số căn cước không được có chữ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void DTP_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            So = "";
            DTP_NgaySinh.CustomFormat = "dd/MM/yyyy";
            if (txt_TenKH.Text != " ")
            {
                #region tạo phần số của maKH
                So += DTP_NgaySinh.Value.ToString("dd");
                So += DTP_NgaySinh.Value.ToString("MM");
                So += DTP_NgaySinh.Value.ToString("yy");
                #endregion
            }
            maKH = Ten + So;
            lb_MaKH.Text = maKH;
        }

        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {
            if (check_Chu() == true)
            {
                if (txt_TenKH.Text.Count() > 0)
                {
                    txt_TenKH.Text.Trim(); //Xoá khoảng trắng thừa đầu cuối
                    Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
                    txt_TenKH.Text = trimmer.Replace(txt_TenKH.Text, " ");
                    #region Tạo phần chữ của maKH
                    Ten = txt_TenKH.Text[0].ToString();
                    for (int i = 1; i < txt_TenKH.Text.Length; i++)
                    {
                        if (txt_TenKH.Text[i - 1] == ' ')
                        {
                            Ten += txt_TenKH.Text[i];
                        }
                    }
                    #endregion
                    maKH = Ten + So;
                    lb_MaKH.Text = maKH;
                }
            }
            else
            {
                txt_TenKH.Select();
                MessageBox.Show("Tên không được có chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool check_Chu()
        {
            foreach (char c in txt_TenKH.Text)
            {
                if (c >= '0' && c <= '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
