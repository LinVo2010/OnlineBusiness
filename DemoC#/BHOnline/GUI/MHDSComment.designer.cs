namespace GUI
{
    partial class MHDSComment
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
            this.dGV_DsComment = new System.Windows.Forms.DataGridView();
            this.gb_DsComment = new System.Windows.Forms.GroupBox();
            this.lb_TenSanPham = new System.Windows.Forms.Label();
            this.tb_TenSanPham = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTP_NgayDang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NoiDung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Sao = new System.Windows.Forms.TextBox();
            this.lb_Sao = new System.Windows.Forms.Label();
            this.tb_TenKhachHang = new System.Windows.Forms.TextBox();
            this.lb_TenKhachHang = new System.Windows.Forms.Label();
            this.bt_TroVe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DsComment)).BeginInit();
            this.gb_DsComment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_DsComment
            // 
            this.dGV_DsComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DsComment.Location = new System.Drawing.Point(6, 16);
            this.dGV_DsComment.Name = "dGV_DsComment";
            this.dGV_DsComment.Size = new System.Drawing.Size(604, 156);
            this.dGV_DsComment.TabIndex = 0;
            this.dGV_DsComment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DsComment_CellClick);
            this.dGV_DsComment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DsComment_CellContentClick);
            // 
            // gb_DsComment
            // 
            this.gb_DsComment.Controls.Add(this.dGV_DsComment);
            this.gb_DsComment.Location = new System.Drawing.Point(37, 119);
            this.gb_DsComment.Name = "gb_DsComment";
            this.gb_DsComment.Size = new System.Drawing.Size(616, 180);
            this.gb_DsComment.TabIndex = 1;
            this.gb_DsComment.TabStop = false;
            this.gb_DsComment.Text = "Danh sách comment";
            // 
            // lb_TenSanPham
            // 
            this.lb_TenSanPham.AutoSize = true;
            this.lb_TenSanPham.Location = new System.Drawing.Point(34, 84);
            this.lb_TenSanPham.Name = "lb_TenSanPham";
            this.lb_TenSanPham.Size = new System.Drawing.Size(77, 13);
            this.lb_TenSanPham.TabIndex = 2;
            this.lb_TenSanPham.Text = "Tên Sản phẩm";
            this.lb_TenSanPham.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_TenSanPham
            // 
            this.tb_TenSanPham.Location = new System.Drawing.Point(117, 81);
            this.tb_TenSanPham.Name = "tb_TenSanPham";
            this.tb_TenSanPham.Size = new System.Drawing.Size(217, 20);
            this.tb_TenSanPham.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.dTP_NgayDang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_NoiDung);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Sao);
            this.groupBox1.Controls.Add(this.lb_Sao);
            this.groupBox1.Controls.Add(this.tb_TenKhachHang);
            this.groupBox1.Controls.Add(this.lb_TenKhachHang);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(37, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đánh giá";
            // 
            // dTP_NgayDang
            // 
            this.dTP_NgayDang.Location = new System.Drawing.Point(421, 22);
            this.dTP_NgayDang.Name = "dTP_NgayDang";
            this.dTP_NgayDang.Size = new System.Drawing.Size(179, 20);
            this.dTP_NgayDang.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày đăng";
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Location = new System.Drawing.Point(36, 76);
            this.tb_NoiDung.Multiline = true;
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_NoiDung.Size = new System.Drawing.Size(541, 88);
            this.tb_NoiDung.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nội dung đánh giá";
            // 
            // tb_Sao
            // 
            this.tb_Sao.Location = new System.Drawing.Point(299, 22);
            this.tb_Sao.Name = "tb_Sao";
            this.tb_Sao.Size = new System.Drawing.Size(41, 20);
            this.tb_Sao.TabIndex = 3;
            // 
            // lb_Sao
            // 
            this.lb_Sao.AutoSize = true;
            this.lb_Sao.Location = new System.Drawing.Point(267, 25);
            this.lb_Sao.Name = "lb_Sao";
            this.lb_Sao.Size = new System.Drawing.Size(26, 13);
            this.lb_Sao.TabIndex = 2;
            this.lb_Sao.Text = "Sao";
            // 
            // tb_TenKhachHang
            // 
            this.tb_TenKhachHang.Location = new System.Drawing.Point(98, 22);
            this.tb_TenKhachHang.Name = "tb_TenKhachHang";
            this.tb_TenKhachHang.Size = new System.Drawing.Size(157, 20);
            this.tb_TenKhachHang.TabIndex = 1;
            // 
            // lb_TenKhachHang
            // 
            this.lb_TenKhachHang.AutoSize = true;
            this.lb_TenKhachHang.Location = new System.Drawing.Point(6, 25);
            this.lb_TenKhachHang.Name = "lb_TenKhachHang";
            this.lb_TenKhachHang.Size = new System.Drawing.Size(86, 13);
            this.lb_TenKhachHang.TabIndex = 0;
            this.lb_TenKhachHang.Text = "Tên khách hàng";
            // 
            // bt_TroVe
            // 
            this.bt_TroVe.Location = new System.Drawing.Point(37, 494);
            this.bt_TroVe.Name = "bt_TroVe";
            this.bt_TroVe.Size = new System.Drawing.Size(75, 23);
            this.bt_TroVe.TabIndex = 5;
            this.bt_TroVe.Text = "Trở về";
            this.bt_TroVe.UseVisualStyleBackColor = true;
            this.bt_TroVe.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm Comment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(206, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "THÔNG TIN ĐÁNH GIÁ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MHDSComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_TroVe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_TenSanPham);
            this.Controls.Add(this.lb_TenSanPham);
            this.Controls.Add(this.gb_DsComment);
            this.Name = "MHDSComment";
            this.Text = "MHDSComment";
            this.Load += new System.EventHandler(this.MHDSComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DsComment)).EndInit();
            this.gb_DsComment.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_DsComment;
        private System.Windows.Forms.GroupBox gb_DsComment;
        private System.Windows.Forms.Label lb_TenSanPham;
        private System.Windows.Forms.TextBox tb_TenSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_NoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Sao;
        private System.Windows.Forms.Label lb_Sao;
        private System.Windows.Forms.TextBox tb_TenKhachHang;
        private System.Windows.Forms.Label lb_TenKhachHang;
        private System.Windows.Forms.Button bt_TroVe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dTP_NgayDang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}