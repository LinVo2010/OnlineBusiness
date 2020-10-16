namespace GUI
{
    partial class MHCTDonNhapHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbMaDNH = new System.Windows.Forms.TextBox();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvCTDonNhapHang = new System.Windows.Forms.DataGridView();
            this.BTNLapCT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTDonNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.tbMaDNH);
            this.panel1.Controls.Add(this.cbSanPham);
            this.panel1.Controls.Add(this.tbSoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 97);
            this.panel1.TabIndex = 0;
            // 
            // tbMaDNH
            // 
            this.tbMaDNH.Location = new System.Drawing.Point(149, 13);
            this.tbMaDNH.Name = "tbMaDNH";
            this.tbMaDNH.Size = new System.Drawing.Size(125, 20);
            this.tbMaDNH.TabIndex = 8;
            // 
            // cbSanPham
            // 
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(149, 51);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(125, 21);
            this.cbSanPham.TabIndex = 7;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(358, 10);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(125, 20);
            this.tbSoLuong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn nhập hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT ĐƠN NHẬP HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgvCTDonNhapHang
            // 
            this.dtgvCTDonNhapHang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvCTDonNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTDonNhapHang.Location = new System.Drawing.Point(28, 167);
            this.dtgvCTDonNhapHang.Name = "dtgvCTDonNhapHang";
            this.dtgvCTDonNhapHang.Size = new System.Drawing.Size(493, 177);
            this.dtgvCTDonNhapHang.TabIndex = 2;
            // 
            // BTNLapCT
            // 
            this.BTNLapCT.Location = new System.Drawing.Point(427, 350);
            this.BTNLapCT.Name = "BTNLapCT";
            this.BTNLapCT.Size = new System.Drawing.Size(84, 32);
            this.BTNLapCT.TabIndex = 3;
            this.BTNLapCT.Text = "Lập chi tiết";
            this.BTNLapCT.UseVisualStyleBackColor = true;
            this.BTNLapCT.Click += new System.EventHandler(this.BTNLapCT_Click);
            // 
            // MHCTDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 395);
            this.Controls.Add(this.BTNLapCT);
            this.Controls.Add(this.dtgvCTDonNhapHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "MHCTDonNhapHang";
            this.Text = "MHCTDonNhapHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MHCTDonNhapHang_FormClosing);
            this.Load += new System.EventHandler(this.MHCTDonNhapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTDonNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvCTDonNhapHang;
        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNLapCT;
        private System.Windows.Forms.TextBox tbMaDNH;
    }
}