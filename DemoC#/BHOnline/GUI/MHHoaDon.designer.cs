namespace GUI
{
    partial class MHHoaDon
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
            this.lbNguoiDung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvTTinDonHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbGmail = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dtgvDiaChiLuuTru = new System.Windows.Forms.DataGridView();
            this.dtgvLichSuHD = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTTinDonHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiaChiLuuTru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSuHD)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNguoiDung
            // 
            this.lbNguoiDung.AutoSize = true;
            this.lbNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiDung.Location = new System.Drawing.Point(782, 19);
            this.lbNguoiDung.Name = "lbNguoiDung";
            this.lbNguoiDung.Size = new System.Drawing.Size(45, 16);
            this.lbNguoiDung.TabIndex = 10;
            this.lbNguoiDung.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(318, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "HỆ THỐNG BÁN HÀNG ONLINE";
            // 
            // dtgvTTinDonHang
            // 
            this.dtgvTTinDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTTinDonHang.Location = new System.Drawing.Point(451, 117);
            this.dtgvTTinDonHang.Name = "dtgvTTinDonHang";
            this.dtgvTTinDonHang.Size = new System.Drawing.Size(423, 103);
            this.dtgvTTinDonHang.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Thông tin đơn hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đia chỉ lưu trữ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txbGmail);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.txbSDT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 236);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giao hàng mới";
            // 
            // txbGmail
            // 
            this.txbGmail.Location = new System.Drawing.Point(98, 139);
            this.txbGmail.Name = "txbGmail";
            this.txbGmail.Size = new System.Drawing.Size(230, 22);
            this.txbGmail.TabIndex = 26;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(98, 97);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(230, 22);
            this.txbDiaChi.TabIndex = 25;
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(98, 52);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(230, 22);
            this.txbSDT.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Gmail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Địa chỉ:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "SĐT:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(329, 200);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(80, 25);
            this.btnThanhToan.TabIndex = 18;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dtgvDiaChiLuuTru
            // 
            this.dtgvDiaChiLuuTru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiaChiLuuTru.Location = new System.Drawing.Point(19, 117);
            this.dtgvDiaChiLuuTru.Name = "dtgvDiaChiLuuTru";
            this.dtgvDiaChiLuuTru.Size = new System.Drawing.Size(415, 70);
            this.dtgvDiaChiLuuTru.TabIndex = 17;
            this.dtgvDiaChiLuuTru.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDiaChiLuuTru_CellClick);
            // 
            // dtgvLichSuHD
            // 
            this.dtgvLichSuHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLichSuHD.Location = new System.Drawing.Point(451, 283);
            this.dtgvLichSuHD.Name = "dtgvLichSuHD";
            this.dtgvLichSuHD.Size = new System.Drawing.Size(423, 163);
            this.dtgvLichSuHD.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lịch sử đơn hàng";
            // 
            // MHHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 460);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgvLichSuHD);
            this.Controls.Add(this.dtgvDiaChiLuuTru);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvTTinDonHang);
            this.Controls.Add(this.lbNguoiDung);
            this.Controls.Add(this.label1);
            this.Name = "MHHoaDon";
            this.Text = "MHHoaDon";
            this.Load += new System.EventHandler(this.MHHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTTinDonHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiaChiLuuTru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSuHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNguoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTTinDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbGmail;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dtgvDiaChiLuuTru;
        private System.Windows.Forms.DataGridView dtgvLichSuHD;
        private System.Windows.Forms.Label label8;
    }
}