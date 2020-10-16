namespace GUI
{
    partial class MHNhanTinKhachHang
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
            this.cb_TenSP = new System.Windows.Forms.ComboBox();
            this.dtgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.bt_GuiMail = new System.Windows.Forms.Button();
            this.tb_MaSP = new System.Windows.Forms.TextBox();
            this.dtpicker_NgayHT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_HopDong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_TenSP
            // 
            this.cb_TenSP.FormattingEnabled = true;
            this.cb_TenSP.Location = new System.Drawing.Point(149, 111);
            this.cb_TenSP.Name = "cb_TenSP";
            this.cb_TenSP.Size = new System.Drawing.Size(268, 21);
            this.cb_TenSP.TabIndex = 0;
            this.cb_TenSP.SelectedIndexChanged += new System.EventHandler(this.cb_SanPham_SelectedIndexChanged);
            this.cb_TenSP.SelectionChangeCommitted += new System.EventHandler(this.cb_SanPham_SelectionChangeCommitted);
            this.cb_TenSP.SelectedValueChanged += new System.EventHandler(this.cb_SanPham_SelectedValueChanged);
            this.cb_TenSP.TextChanged += new System.EventHandler(this.cb_SanPham_TextChanged);
            // 
            // dtgv_KhachHang
            // 
            this.dtgv_KhachHang.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_KhachHang.Location = new System.Drawing.Point(64, 178);
            this.dtgv_KhachHang.Name = "dtgv_KhachHang";
            this.dtgv_KhachHang.Size = new System.Drawing.Size(437, 180);
            this.dtgv_KhachHang.TabIndex = 1;
            this.dtgv_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_KhachHang_CellContentClick);
            // 
            // bt_GuiMail
            // 
            this.bt_GuiMail.Location = new System.Drawing.Point(249, 380);
            this.bt_GuiMail.Name = "bt_GuiMail";
            this.bt_GuiMail.Size = new System.Drawing.Size(75, 23);
            this.bt_GuiMail.TabIndex = 4;
            this.bt_GuiMail.Text = "Gửi Mail";
            this.bt_GuiMail.UseVisualStyleBackColor = true;
            this.bt_GuiMail.Click += new System.EventHandler(this.bt_GuiMail_Click);
            // 
            // tb_MaSP
            // 
            this.tb_MaSP.Location = new System.Drawing.Point(149, 85);
            this.tb_MaSP.Name = "tb_MaSP";
            this.tb_MaSP.Size = new System.Drawing.Size(100, 20);
            this.tb_MaSP.TabIndex = 13;
            this.tb_MaSP.TextChanged += new System.EventHandler(this.tb_maSP_TextChanged);
            this.tb_MaSP.Validated += new System.EventHandler(this.tb_maSP_Validated);
            // 
            // dtpicker_NgayHT
            // 
            this.dtpicker_NgayHT.Checked = false;
            this.dtpicker_NgayHT.CustomFormat = "yyyy-MM-dd";
            this.dtpicker_NgayHT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_NgayHT.Location = new System.Drawing.Point(149, 59);
            this.dtpicker_NgayHT.Name = "dtpicker_NgayHT";
            this.dtpicker_NgayHT.Size = new System.Drawing.Size(144, 20);
            this.dtpicker_NgayHT.TabIndex = 12;
            this.dtpicker_NgayHT.Value = new System.DateTime(2020, 8, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(61, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã sản phẩm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(61, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên sản phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(61, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(333, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "DANH SÁCH KHÁCH HÀNG CHƯA GỬI MAIL TUẦN NÀY";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(62, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày hiện tại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_HopDong
            // 
            this.lb_HopDong.AutoSize = true;
            this.lb_HopDong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_HopDong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_HopDong.Location = new System.Drawing.Point(155, 9);
            this.lb_HopDong.Name = "lb_HopDong";
            this.lb_HopDong.Size = new System.Drawing.Size(262, 24);
            this.lb_HopDong.TabIndex = 18;
            this.lb_HopDong.Text = "NHẮN TIN KHÁCH HÀNG";
            // 
            // MHNhanTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 425);
            this.Controls.Add(this.lb_HopDong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_MaSP);
            this.Controls.Add(this.dtpicker_NgayHT);
            this.Controls.Add(this.bt_GuiMail);
            this.Controls.Add(this.dtgv_KhachHang);
            this.Controls.Add(this.cb_TenSP);
            this.Name = "MHNhanTinKhachHang";
            this.Text = "MHNhanTinKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MHNhanTinKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.NhanTinGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_TenSP;
        private System.Windows.Forms.DataGridView dtgv_KhachHang;
        private System.Windows.Forms.Button bt_GuiMail;
        private System.Windows.Forms.TextBox tb_MaSP;
        private System.Windows.Forms.DateTimePicker dtpicker_NgayHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_HopDong;
    }
}