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
        public ChonGhe()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    Button btn = new Button();
                    btn.Name = (i * 1 + 1 + j * 5).ToString();
                    btn.Size = new System.Drawing.Size(50, 40);
                    btn.TabIndex = 0;
                    btn.Text = (i + 1 + j * 4).ToString();
                    btn.Location = new Point(55 * i + 204, 45 * j + 200);
                    btn.UseVisualStyleBackColor = false;
                    btn.BackColor = Color.White;
                    //btn.Click += btn_Click;

                    panel_Show.Controls.Add(btn);
                }
            }
        }
    }
}
