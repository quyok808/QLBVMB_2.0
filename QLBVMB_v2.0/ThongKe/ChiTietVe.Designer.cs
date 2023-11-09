namespace QLBVMB_v2._0.ThongKe
{
    partial class ChiTietVe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NoiDi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MaCB = new System.Windows.Forms.TextBox();
            this.DTP_NgayGioDi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NoiDen = new System.Windows.Forms.TextBox();
            this.DTP_NgayGioDenDuKien = new System.Windows.Forms.DateTimePicker();
            this.txt_SoHieuMayBay = new System.Windows.Forms.TextBox();
            this.txt_GiaVe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Thue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ";
            // 
            // txt_NoiDi
            // 
            this.txt_NoiDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoiDi.Location = new System.Drawing.Point(44, 22);
            this.txt_NoiDi.Name = "txt_NoiDi";
            this.txt_NoiDi.Size = new System.Drawing.Size(100, 22);
            this.txt_NoiDi.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.txt_SoHieuMayBay);
            this.groupBox1.Controls.Add(this.txt_Thue);
            this.groupBox1.Controls.Add(this.txt_MaCB);
            this.groupBox1.Controls.Add(this.txt_GiaVe);
            this.groupBox1.Controls.Add(this.DTP_NgayGioDenDuKien);
            this.groupBox1.Controls.Add(this.DTP_NgayGioDi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NoiDen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_NoiDi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hoá đơn";
            // 
            // txt_MaCB
            // 
            this.txt_MaCB.Location = new System.Drawing.Point(21, 100);
            this.txt_MaCB.Name = "txt_MaCB";
            this.txt_MaCB.Size = new System.Drawing.Size(123, 22);
            this.txt_MaCB.TabIndex = 3;
            this.txt_MaCB.Text = "Mã chuyến bay";
            // 
            // DTP_NgayGioDi
            // 
            this.DTP_NgayGioDi.CustomFormat = "hh:mm dd/MM/yyyy";
            this.DTP_NgayGioDi.Enabled = false;
            this.DTP_NgayGioDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_NgayGioDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_NgayGioDi.Location = new System.Drawing.Point(21, 60);
            this.DTP_NgayGioDi.Name = "DTP_NgayGioDi";
            this.DTP_NgayGioDi.Size = new System.Drawing.Size(123, 22);
            this.DTP_NgayGioDi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đến";
            // 
            // txt_NoiDen
            // 
            this.txt_NoiDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoiDen.Location = new System.Drawing.Point(204, 21);
            this.txt_NoiDen.Name = "txt_NoiDen";
            this.txt_NoiDen.Size = new System.Drawing.Size(100, 22);
            this.txt_NoiDen.TabIndex = 1;
            // 
            // DTP_NgayGioDenDuKien
            // 
            this.DTP_NgayGioDenDuKien.CustomFormat = "hh:mm dd/MM/yyyy";
            this.DTP_NgayGioDenDuKien.Enabled = false;
            this.DTP_NgayGioDenDuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_NgayGioDenDuKien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_NgayGioDenDuKien.Location = new System.Drawing.Point(170, 60);
            this.DTP_NgayGioDenDuKien.Name = "DTP_NgayGioDenDuKien";
            this.DTP_NgayGioDenDuKien.Size = new System.Drawing.Size(134, 22);
            this.DTP_NgayGioDenDuKien.TabIndex = 2;
            // 
            // txt_SoHieuMayBay
            // 
            this.txt_SoHieuMayBay.Location = new System.Drawing.Point(170, 100);
            this.txt_SoHieuMayBay.Name = "txt_SoHieuMayBay";
            this.txt_SoHieuMayBay.Size = new System.Drawing.Size(134, 22);
            this.txt_SoHieuMayBay.TabIndex = 3;
            this.txt_SoHieuMayBay.Text = "Mã máy bay";
            // 
            // txt_GiaVe
            // 
            this.txt_GiaVe.Location = new System.Drawing.Point(105, 150);
            this.txt_GiaVe.Name = "txt_GiaVe";
            this.txt_GiaVe.Size = new System.Drawing.Size(100, 22);
            this.txt_GiaVe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thuế và phí";
            // 
            // txt_Thue
            // 
            this.txt_Thue.Location = new System.Drawing.Point(105, 186);
            this.txt_Thue.Name = "txt_Thue";
            this.txt_Thue.Size = new System.Drawing.Size(100, 22);
            this.txt_Thue.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(105, 222);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(100, 22);
            this.txt_TongTien.TabIndex = 3;
            // 
            // ChiTietVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 288);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChiTietVe";
            this.Text = "ChiTietVe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NoiDi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DTP_NgayGioDi;
        private System.Windows.Forms.TextBox txt_MaCB;
        private System.Windows.Forms.TextBox txt_SoHieuMayBay;
        private System.Windows.Forms.DateTimePicker DTP_NgayGioDenDuKien;
        private System.Windows.Forms.TextBox txt_NoiDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.TextBox txt_Thue;
        private System.Windows.Forms.TextBox txt_GiaVe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}