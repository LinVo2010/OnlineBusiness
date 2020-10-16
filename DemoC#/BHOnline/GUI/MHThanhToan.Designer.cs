namespace GUI
{
    partial class MHThanhToan
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
            this.dgv_DSSP = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_PTTT = new System.Windows.Forms.Label();
            this.btn_TienMat = new System.Windows.Forms.Button();
            this.btn_The = new System.Windows.Forms.Button();
            this.txb_TongTien = new System.Windows.Forms.TextBox();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.txb_TongSP = new System.Windows.Forms.TextBox();
            this.lb_TongSP = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_TenKH = new System.Windows.Forms.TextBox();
            this.txb_DiaChi = new System.Windows.Forms.TextBox();
            this.txb_SDT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_HoanThanh = new System.Windows.Forms.Button();
            this.lb_ThanhToan = new System.Windows.Forms.Label();
            this.lbNguoiDung = new System.Windows.Forms.Label();
            this.lb_DiaChiNhanHang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSP)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DSSP
            // 
            this.dgv_DSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSP.Location = new System.Drawing.Point(5, 18);
            this.dgv_DSSP.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DSSP.Name = "dgv_DSSP";
            this.dgv_DSSP.RowTemplate.Height = 24;
            this.dgv_DSSP.Size = new System.Drawing.Size(828, 107);
            this.dgv_DSSP.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lb_PTTT);
            this.panel4.Controls.Add(this.btn_TienMat);
            this.panel4.Controls.Add(this.btn_The);
            this.panel4.Location = new System.Drawing.Point(44, 370);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(836, 43);
            this.panel4.TabIndex = 37;
            // 
            // lb_PTTT
            // 
            this.lb_PTTT.AutoSize = true;
            this.lb_PTTT.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PTTT.ForeColor = System.Drawing.Color.Black;
            this.lb_PTTT.Location = new System.Drawing.Point(17, 11);
            this.lb_PTTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PTTT.Name = "lb_PTTT";
            this.lb_PTTT.Size = new System.Drawing.Size(220, 22);
            this.lb_PTTT.TabIndex = 19;
            this.lb_PTTT.Text = "Phương Thức Thanh Toán";
            // 
            // btn_TienMat
            // 
            this.btn_TienMat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TienMat.ForeColor = System.Drawing.Color.Black;
            this.btn_TienMat.Location = new System.Drawing.Point(281, 6);
            this.btn_TienMat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TienMat.Name = "btn_TienMat";
            this.btn_TienMat.Size = new System.Drawing.Size(240, 30);
            this.btn_TienMat.TabIndex = 20;
            this.btn_TienMat.Text = "Thanh toán khi nhận hàng";
            this.btn_TienMat.UseVisualStyleBackColor = false;
            this.btn_TienMat.Click += new System.EventHandler(this.btn_TienMat_Click_1);
            // 
            // btn_The
            // 
            this.btn_The.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_The.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_The.ForeColor = System.Drawing.Color.Black;
            this.btn_The.Location = new System.Drawing.Point(596, 6);
            this.btn_The.Margin = new System.Windows.Forms.Padding(2);
            this.btn_The.Name = "btn_The";
            this.btn_The.Size = new System.Drawing.Size(171, 30);
            this.btn_The.TabIndex = 21;
            this.btn_The.Text = "Thanh toán thẻ";
            this.btn_The.UseVisualStyleBackColor = false;
            this.btn_The.Click += new System.EventHandler(this.btn_The_Click_1);
            // 
            // txb_TongTien
            // 
            this.txb_TongTien.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TongTien.Location = new System.Drawing.Point(182, 35);
            this.txb_TongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txb_TongTien.Name = "txb_TongTien";
            this.txb_TongTien.ReadOnly = true;
            this.txb_TongTien.Size = new System.Drawing.Size(131, 28);
            this.txb_TongTien.TabIndex = 3;
            this.txb_TongTien.Text = "0";
            this.txb_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.Location = new System.Drawing.Point(41, 41);
            this.lb_TongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(86, 21);
            this.lb_TongTien.TabIndex = 2;
            this.lb_TongTien.Text = "Tổng tiền";
            // 
            // txb_TongSP
            // 
            this.txb_TongSP.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TongSP.Location = new System.Drawing.Point(182, 2);
            this.txb_TongSP.Margin = new System.Windows.Forms.Padding(2);
            this.txb_TongSP.Name = "txb_TongSP";
            this.txb_TongSP.ReadOnly = true;
            this.txb_TongSP.Size = new System.Drawing.Size(131, 28);
            this.txb_TongSP.TabIndex = 1;
            this.txb_TongSP.Text = "0";
            this.txb_TongSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_TongSP
            // 
            this.lb_TongSP.AutoSize = true;
            this.lb_TongSP.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongSP.Location = new System.Drawing.Point(41, 9);
            this.lb_TongSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TongSP.Name = "lb_TongSP";
            this.lb_TongSP.Size = new System.Drawing.Size(135, 21);
            this.lb_TongSP.TabIndex = 0;
            this.lb_TongSP.Text = "Tổng sản phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_TongTien);
            this.panel3.Controls.Add(this.lb_TongTien);
            this.panel3.Controls.Add(this.txb_TongSP);
            this.panel3.Controls.Add(this.lb_TongSP);
            this.panel3.Location = new System.Drawing.Point(564, 291);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 65);
            this.panel3.TabIndex = 36;
            // 
            // txb_TenKH
            // 
            this.txb_TenKH.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenKH.Location = new System.Drawing.Point(2, 2);
            this.txb_TenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txb_TenKH.Name = "txb_TenKH";
            this.txb_TenKH.ReadOnly = true;
            this.txb_TenKH.Size = new System.Drawing.Size(224, 28);
            this.txb_TenKH.TabIndex = 26;
            // 
            // txb_DiaChi
            // 
            this.txb_DiaChi.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DiaChi.Location = new System.Drawing.Point(230, 2);
            this.txb_DiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txb_DiaChi.Multiline = true;
            this.txb_DiaChi.Name = "txb_DiaChi";
            this.txb_DiaChi.ReadOnly = true;
            this.txb_DiaChi.Size = new System.Drawing.Size(607, 60);
            this.txb_DiaChi.TabIndex = 25;
            // 
            // txb_SDT
            // 
            this.txb_SDT.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SDT.Location = new System.Drawing.Point(2, 34);
            this.txb_SDT.Margin = new System.Windows.Forms.Padding(2);
            this.txb_SDT.Name = "txb_SDT";
            this.txb_SDT.ReadOnly = true;
            this.txb_SDT.Size = new System.Drawing.Size(224, 28);
            this.txb_SDT.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txb_TenKH);
            this.panel2.Controls.Add(this.txb_DiaChi);
            this.panel2.Controls.Add(this.txb_SDT);
            this.panel2.Location = new System.Drawing.Point(44, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 64);
            this.panel2.TabIndex = 35;
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanThanh.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_HoanThanh.Location = new System.Drawing.Point(670, 427);
            this.btn_HoanThanh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(146, 39);
            this.btn_HoanThanh.TabIndex = 33;
            this.btn_HoanThanh.Text = "Hoàn Thành";
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            this.btn_HoanThanh.Click += new System.EventHandler(this.btn_HoanThanh_Click_1);
            // 
            // lb_ThanhToan
            // 
            this.lb_ThanhToan.AutoSize = true;
            this.lb_ThanhToan.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhToan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_ThanhToan.Location = new System.Drawing.Point(364, 20);
            this.lb_ThanhToan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ThanhToan.Name = "lb_ThanhToan";
            this.lb_ThanhToan.Size = new System.Drawing.Size(157, 32);
            this.lb_ThanhToan.TabIndex = 32;
            this.lb_ThanhToan.Text = "Thanh Toán";
            // 
            // lbNguoiDung
            // 
            this.lbNguoiDung.AutoSize = true;
            this.lbNguoiDung.Location = new System.Drawing.Point(751, 25);
            this.lbNguoiDung.Name = "lbNguoiDung";
            this.lbNguoiDung.Size = new System.Drawing.Size(35, 13);
            this.lbNguoiDung.TabIndex = 40;
            this.lbNguoiDung.Text = "label1";
            // 
            // lb_DiaChiNhanHang
            // 
            this.lb_DiaChiNhanHang.AutoSize = true;
            this.lb_DiaChiNhanHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_DiaChiNhanHang.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChiNhanHang.ForeColor = System.Drawing.Color.Black;
            this.lb_DiaChiNhanHang.ImageKey = "(none)";
            this.lb_DiaChiNhanHang.Location = new System.Drawing.Point(42, 56);
            this.lb_DiaChiNhanHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_DiaChiNhanHang.Name = "lb_DiaChiNhanHang";
            this.lb_DiaChiNhanHang.Size = new System.Drawing.Size(167, 22);
            this.lb_DiaChiNhanHang.TabIndex = 16;
            this.lb_DiaChiNhanHang.Text = "Địa Chỉ Nhận Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DSSP);
            this.groupBox1.Location = new System.Drawing.Point(44, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 130);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // MHThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_DiaChiNhanHang);
            this.Controls.Add(this.lbNguoiDung);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_HoanThanh);
            this.Controls.Add(this.lb_ThanhToan);
            this.Name = "MHThanhToan";
            this.Text = "MHThanhToan";
            this.Load += new System.EventHandler(this.MHThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSP)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DSSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_PTTT;
        private System.Windows.Forms.Button btn_TienMat;
        private System.Windows.Forms.Button btn_The;
        private System.Windows.Forms.TextBox txb_TongTien;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.TextBox txb_TongSP;
        private System.Windows.Forms.Label lb_TongSP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_TenKH;
        private System.Windows.Forms.TextBox txb_DiaChi;
        private System.Windows.Forms.TextBox txb_SDT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_HoanThanh;
        private System.Windows.Forms.Label lb_ThanhToan;
        private System.Windows.Forms.Label lbNguoiDung;
        private System.Windows.Forms.Label lb_DiaChiNhanHang;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}