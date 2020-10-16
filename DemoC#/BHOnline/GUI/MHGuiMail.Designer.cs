namespace GUI
{
    partial class MHGuiMail
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
            this.tb_DinhKem = new System.Windows.Forms.TextBox();
            this.bt_ChonFile = new System.Windows.Forms.Button();
            this.tb_NguoiNhan = new System.Windows.Forms.TextBox();
            this.tb_ChuDe = new System.Windows.Forms.TextBox();
            this.tb_NoiDung = new System.Windows.Forms.TextBox();
            this.tb_Gui = new System.Windows.Forms.Button();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.tb_TenDangNhap = new System.Windows.Forms.TextBox();
            this.lb_HopDong = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_DinhKem
            // 
            this.tb_DinhKem.Location = new System.Drawing.Point(95, 21);
            this.tb_DinhKem.Name = "tb_DinhKem";
            this.tb_DinhKem.ReadOnly = true;
            this.tb_DinhKem.Size = new System.Drawing.Size(416, 20);
            this.tb_DinhKem.TabIndex = 0;
            // 
            // bt_ChonFile
            // 
            this.bt_ChonFile.Location = new System.Drawing.Point(517, 21);
            this.bt_ChonFile.Name = "bt_ChonFile";
            this.bt_ChonFile.Size = new System.Drawing.Size(75, 23);
            this.bt_ChonFile.TabIndex = 1;
            this.bt_ChonFile.Text = "Chọn File";
            this.bt_ChonFile.UseVisualStyleBackColor = true;
            this.bt_ChonFile.Click += new System.EventHandler(this.bt_dinhkem_Click);
            // 
            // tb_NguoiNhan
            // 
            this.tb_NguoiNhan.Location = new System.Drawing.Point(95, 51);
            this.tb_NguoiNhan.Name = "tb_NguoiNhan";
            this.tb_NguoiNhan.Size = new System.Drawing.Size(236, 20);
            this.tb_NguoiNhan.TabIndex = 2;
            this.tb_NguoiNhan.TextChanged += new System.EventHandler(this.tb_NguoiNhan_TextChanged);
            // 
            // tb_ChuDe
            // 
            this.tb_ChuDe.Location = new System.Drawing.Point(95, 139);
            this.tb_ChuDe.Multiline = true;
            this.tb_ChuDe.Name = "tb_ChuDe";
            this.tb_ChuDe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ChuDe.Size = new System.Drawing.Size(236, 38);
            this.tb_ChuDe.TabIndex = 3;
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Location = new System.Drawing.Point(95, 195);
            this.tb_NoiDung.Multiline = true;
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_NoiDung.Size = new System.Drawing.Size(586, 135);
            this.tb_NoiDung.TabIndex = 4;
            // 
            // tb_Gui
            // 
            this.tb_Gui.Location = new System.Drawing.Point(371, 431);
            this.tb_Gui.Name = "tb_Gui";
            this.tb_Gui.Size = new System.Drawing.Size(75, 23);
            this.tb_Gui.TabIndex = 5;
            this.tb_Gui.Text = "Gửi";
            this.tb_Gui.UseVisualStyleBackColor = true;
            this.tb_Gui.Click += new System.EventHandler(this.tb_Gui_Click);
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(95, 108);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(236, 20);
            this.tb_MatKhau.TabIndex = 7;
            this.tb_MatKhau.UseSystemPasswordChar = true;
            // 
            // tb_TenDangNhap
            // 
            this.tb_TenDangNhap.Location = new System.Drawing.Point(95, 82);
            this.tb_TenDangNhap.Name = "tb_TenDangNhap";
            this.tb_TenDangNhap.Size = new System.Drawing.Size(236, 20);
            this.tb_TenDangNhap.TabIndex = 6;
            // 
            // lb_HopDong
            // 
            this.lb_HopDong.AutoSize = true;
            this.lb_HopDong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_HopDong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_HopDong.Location = new System.Drawing.Point(339, 9);
            this.lb_HopDong.Name = "lb_HopDong";
            this.lb_HopDong.Size = new System.Drawing.Size(126, 24);
            this.lb_HopDong.TabIndex = 19;
            this.lb_HopDong.Text = "GỬI GMAIL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(40, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "THÔNG TIN GMAIL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(24, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Đính kèm:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Người nhận:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Người gửi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mật khẩu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(33, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Chủ đề:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(24, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nội dung:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_DinhKem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bt_ChonFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_NguoiNhan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ChuDe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_NoiDung);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_TenDangNhap);
            this.groupBox1.Controls.Add(this.tb_MatKhau);
            this.groupBox1.Location = new System.Drawing.Point(43, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 343);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MHGuiMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_Gui);
            this.Controls.Add(this.lb_HopDong);
            this.Name = "MHGuiMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MHGuiMail";
            this.Load += new System.EventHandler(this.GuiMailGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_DinhKem;
        private System.Windows.Forms.Button bt_ChonFile;
        private System.Windows.Forms.TextBox tb_NguoiNhan;
        private System.Windows.Forms.TextBox tb_ChuDe;
        private System.Windows.Forms.TextBox tb_NoiDung;
        private System.Windows.Forms.Button tb_Gui;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.TextBox tb_TenDangNhap;
        private System.Windows.Forms.Label lb_HopDong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}