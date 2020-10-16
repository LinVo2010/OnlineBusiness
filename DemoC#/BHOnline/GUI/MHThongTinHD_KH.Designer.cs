namespace GUI
{
    partial class MHThongTinHD_KH
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
            this.btn_TiepTucMua = new System.Windows.Forms.Button();
            this.lb_ThongTinHD = new System.Windows.Forms.Label();
            this.lb_ThongTinKH = new System.Windows.Forms.Label();
            this.lb_TTHD = new System.Windows.Forms.Label();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.txb_TenKH1 = new System.Windows.Forms.TextBox();
            this.txb_SDT1 = new System.Windows.Forms.TextBox();
            this.txb_DiaChi1 = new System.Windows.Forms.TextBox();
            this.dgv_DSHD = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNguoiDung = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHD)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TiepTucMua
            // 
            this.btn_TiepTucMua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TiepTucMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TiepTucMua.ForeColor = System.Drawing.Color.Black;
            this.btn_TiepTucMua.Location = new System.Drawing.Point(743, 472);
            this.btn_TiepTucMua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TiepTucMua.Name = "btn_TiepTucMua";
            this.btn_TiepTucMua.Size = new System.Drawing.Size(165, 30);
            this.btn_TiepTucMua.TabIndex = 47;
            this.btn_TiepTucMua.Text = "Tiếp tục mua hàng";
            this.btn_TiepTucMua.UseVisualStyleBackColor = false;
            this.btn_TiepTucMua.Click += new System.EventHandler(this.btn_TiepTucMua_Click_1);
            // 
            // lb_ThongTinHD
            // 
            this.lb_ThongTinHD.AutoSize = true;
            this.lb_ThongTinHD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ThongTinHD.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTinHD.ForeColor = System.Drawing.Color.Black;
            this.lb_ThongTinHD.ImageKey = "(none)";
            this.lb_ThongTinHD.Location = new System.Drawing.Point(123, 203);
            this.lb_ThongTinHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ThongTinHD.Name = "lb_ThongTinHD";
            this.lb_ThongTinHD.Size = new System.Drawing.Size(151, 22);
            this.lb_ThongTinHD.TabIndex = 46;
            this.lb_ThongTinHD.Text = "Chi Tiết Hóa Đơn";
            // 
            // lb_ThongTinKH
            // 
            this.lb_ThongTinKH.AutoSize = true;
            this.lb_ThongTinKH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ThongTinKH.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTinKH.ForeColor = System.Drawing.Color.Black;
            this.lb_ThongTinKH.ImageKey = "(none)";
            this.lb_ThongTinKH.Location = new System.Drawing.Point(123, 70);
            this.lb_ThongTinKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ThongTinKH.Name = "lb_ThongTinKH";
            this.lb_ThongTinKH.Size = new System.Drawing.Size(196, 22);
            this.lb_ThongTinKH.TabIndex = 45;
            this.lb_ThongTinKH.Text = "Thông Tin Khách Hàng";
            // 
            // lb_TTHD
            // 
            this.lb_TTHD.AutoSize = true;
            this.lb_TTHD.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TTHD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_TTHD.Location = new System.Drawing.Point(393, 6);
            this.lb_TTHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TTHD.Name = "lb_TTHD";
            this.lb_TTHD.Size = new System.Drawing.Size(248, 32);
            this.lb_TTHD.TabIndex = 41;
            this.lb_TTHD.Text = "Thông Tin Hóa đơn";
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.Location = new System.Drawing.Point(2, 69);
            this.lb_SDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(131, 22);
            this.lb_SDT.TabIndex = 29;
            this.lb_SDT.Text = "Số Điện Thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Email:";
            // 
            // txb_Email
            // 
            this.txb_Email.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Email.Location = new System.Drawing.Point(476, 32);
            this.txb_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.ReadOnly = true;
            this.txb_Email.Size = new System.Drawing.Size(318, 28);
            this.txb_Email.TabIndex = 41;
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ten.Location = new System.Drawing.Point(2, 32);
            this.lb_Ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(98, 22);
            this.lb_Ten.TabIndex = 28;
            this.lb_Ten.Text = "Họ và Tên:";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(386, 64);
            this.lb_DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(76, 22);
            this.lb_DiaChi.TabIndex = 27;
            this.lb_DiaChi.Text = "Địa Chỉ:";
            // 
            // txb_TenKH1
            // 
            this.txb_TenKH1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenKH1.Location = new System.Drawing.Point(143, 32);
            this.txb_TenKH1.Margin = new System.Windows.Forms.Padding(2);
            this.txb_TenKH1.Name = "txb_TenKH1";
            this.txb_TenKH1.ReadOnly = true;
            this.txb_TenKH1.Size = new System.Drawing.Size(182, 28);
            this.txb_TenKH1.TabIndex = 24;
            // 
            // txb_SDT1
            // 
            this.txb_SDT1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SDT1.Location = new System.Drawing.Point(143, 67);
            this.txb_SDT1.Margin = new System.Windows.Forms.Padding(2);
            this.txb_SDT1.Name = "txb_SDT1";
            this.txb_SDT1.ReadOnly = true;
            this.txb_SDT1.Size = new System.Drawing.Size(181, 28);
            this.txb_SDT1.TabIndex = 25;
            // 
            // txb_DiaChi1
            // 
            this.txb_DiaChi1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DiaChi1.Location = new System.Drawing.Point(476, 62);
            this.txb_DiaChi1.Margin = new System.Windows.Forms.Padding(2);
            this.txb_DiaChi1.Multiline = true;
            this.txb_DiaChi1.Name = "txb_DiaChi1";
            this.txb_DiaChi1.ReadOnly = true;
            this.txb_DiaChi1.Size = new System.Drawing.Size(318, 28);
            this.txb_DiaChi1.TabIndex = 26;
            // 
            // dgv_DSHD
            // 
            this.dgv_DSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSHD.Location = new System.Drawing.Point(115, 227);
            this.dgv_DSHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DSHD.Name = "dgv_DSHD";
            this.dgv_DSHD.RowTemplate.Height = 24;
            this.dgv_DSHD.Size = new System.Drawing.Size(793, 223);
            this.dgv_DSHD.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_SDT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txb_Email);
            this.panel2.Controls.Add(this.lb_Ten);
            this.panel2.Controls.Add(this.lb_DiaChi);
            this.panel2.Controls.Add(this.txb_TenKH1);
            this.panel2.Controls.Add(this.txb_SDT1);
            this.panel2.Controls.Add(this.txb_DiaChi1);
            this.panel2.Location = new System.Drawing.Point(115, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 107);
            this.panel2.TabIndex = 42;
            // 
            // lbNguoiDung
            // 
            this.lbNguoiDung.AutoSize = true;
            this.lbNguoiDung.Location = new System.Drawing.Point(886, 21);
            this.lbNguoiDung.Name = "lbNguoiDung";
            this.lbNguoiDung.Size = new System.Drawing.Size(35, 13);
            this.lbNguoiDung.TabIndex = 49;
            this.lbNguoiDung.Text = "label2";
            // 
            // MHThongTinHD_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 518);
            this.Controls.Add(this.lbNguoiDung);
            this.Controls.Add(this.btn_TiepTucMua);
            this.Controls.Add(this.lb_ThongTinHD);
            this.Controls.Add(this.lb_ThongTinKH);
            this.Controls.Add(this.lb_TTHD);
            this.Controls.Add(this.dgv_DSHD);
            this.Controls.Add(this.panel2);
            this.Name = "MHThongTinHD_KH";
            this.Text = "MHThongTinHD_KH";
            this.Load += new System.EventHandler(this.MHThongTinHD_KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_TiepTucMua;
        private System.Windows.Forms.Label lb_ThongTinHD;
        private System.Windows.Forms.Label lb_ThongTinKH;
        private System.Windows.Forms.Label lb_TTHD;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.TextBox txb_TenKH1;
        private System.Windows.Forms.TextBox txb_SDT1;
        private System.Windows.Forms.TextBox txb_DiaChi1;
        private System.Windows.Forms.DataGridView dgv_DSHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNguoiDung;
    }
}