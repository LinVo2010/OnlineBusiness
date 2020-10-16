namespace GUI
{
    partial class MHHopDong
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
            this.lb_HopDong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_HopDong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_Gmail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_Tendoitac = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_TenNV = new System.Windows.Forms.ComboBox();
            this.tb_NoiDung = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_ViTriDang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpicker_Thoihan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpicker_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_TenHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_maNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MaHD = new System.Windows.Forms.TextBox();
            this.bt_Thêm = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bt_Lich = new System.Windows.Forms.Button();
            this.bt_GuiMail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HopDong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_HopDong
            // 
            this.lb_HopDong.AutoSize = true;
            this.lb_HopDong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_HopDong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_HopDong.Location = new System.Drawing.Point(410, 9);
            this.lb_HopDong.Name = "lb_HopDong";
            this.lb_HopDong.Size = new System.Drawing.Size(122, 24);
            this.lb_HopDong.TabIndex = 0;
            this.lb_HopDong.Text = "HỢP ĐỒNG";
            this.lb_HopDong.Click += new System.EventHandler(this.lb_HopDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_HopDong);
            this.groupBox1.Location = new System.Drawing.Point(2, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 328);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtgv_HopDong
            // 
            this.dtgv_HopDong.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgv_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HopDong.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgv_HopDong.Location = new System.Drawing.Point(6, 9);
            this.dtgv_HopDong.Name = "dtgv_HopDong";
            this.dtgv_HopDong.Size = new System.Drawing.Size(461, 313);
            this.dtgv_HopDong.TabIndex = 0;
            this.dtgv_HopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_HopDong_CellClick);
            this.dtgv_HopDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_HopDong_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tb_Gmail);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cb_TenNV);
            this.groupBox2.Controls.Add(this.tb_NoiDung);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_ViTriDang);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpicker_Thoihan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpicker_NgayLap);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_TenHD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_maNV);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_MaHD);
            this.groupBox2.Location = new System.Drawing.Point(481, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 328);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(277, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 15);
            this.label16.TabIndex = 24;
            this.label16.Text = "Gmail";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_Gmail
            // 
            this.tb_Gmail.Location = new System.Drawing.Point(348, 116);
            this.tb_Gmail.Multiline = true;
            this.tb_Gmail.Name = "tb_Gmail";
            this.tb_Gmail.ReadOnly = true;
            this.tb_Gmail.Size = new System.Drawing.Size(178, 22);
            this.tb_Gmail.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cb_Tendoitac);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tb_maDT);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(272, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 131);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(6, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "* Nếu đối tác chưa tồn tại";
            // 
            // cb_Tendoitac
            // 
            this.cb_Tendoitac.FormattingEnabled = true;
            this.cb_Tendoitac.Location = new System.Drawing.Point(74, 41);
            this.cb_Tendoitac.Name = "cb_Tendoitac";
            this.cb_Tendoitac.Size = new System.Drawing.Size(163, 21);
            this.cb_Tendoitac.TabIndex = 14;
            this.cb_Tendoitac.SelectedIndexChanged += new System.EventHandler(this.cb_Tendoitac_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(152, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm đối tác";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(1, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã đối tác:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_maDT
            // 
            this.tb_maDT.Location = new System.Drawing.Point(74, 15);
            this.tb_maDT.Name = "tb_maDT";
            this.tb_maDT.Size = new System.Drawing.Size(100, 20);
            this.tb_maDT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(1, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên đối tác:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_TenNV
            // 
            this.cb_TenNV.FormattingEnabled = true;
            this.cb_TenNV.Location = new System.Drawing.Point(92, 89);
            this.cb_TenNV.Name = "cb_TenNV";
            this.cb_TenNV.Size = new System.Drawing.Size(163, 21);
            this.cb_TenNV.TabIndex = 21;
            this.cb_TenNV.SelectedIndexChanged += new System.EventHandler(this.cb_TenNV_SelectedIndexChanged);
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Location = new System.Drawing.Point(92, 179);
            this.tb_NoiDung.Multiline = true;
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_NoiDung.Size = new System.Drawing.Size(434, 143);
            this.tb_NoiDung.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(26, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nội dung:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_ViTriDang
            // 
            this.tb_ViTriDang.Location = new System.Drawing.Point(348, 144);
            this.tb_ViTriDang.Multiline = true;
            this.tb_ViTriDang.Name = "tb_ViTriDang";
            this.tb_ViTriDang.Size = new System.Drawing.Size(178, 29);
            this.tb_ViTriDang.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(277, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Vị trí đăng:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(3, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tên nhân viên:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpicker_Thoihan
            // 
            this.dtpicker_Thoihan.CustomFormat = "dd-MM-yyyy";
            this.dtpicker_Thoihan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_Thoihan.Location = new System.Drawing.Point(92, 153);
            this.dtpicker_Thoihan.Name = "dtpicker_Thoihan";
            this.dtpicker_Thoihan.Size = new System.Drawing.Size(144, 20);
            this.dtpicker_Thoihan.TabIndex = 13;
            this.dtpicker_Thoihan.Value = new System.DateTime(2020, 8, 2, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(28, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thời hạn:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpicker_NgayLap
            // 
            this.dtpicker_NgayLap.CustomFormat = "dd-MM-yyyy";
            this.dtpicker_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_NgayLap.Location = new System.Drawing.Point(92, 127);
            this.dtpicker_NgayLap.Name = "dtpicker_NgayLap";
            this.dtpicker_NgayLap.Size = new System.Drawing.Size(144, 20);
            this.dtpicker_NgayLap.TabIndex = 11;
            this.dtpicker_NgayLap.Value = new System.DateTime(2020, 8, 2, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(28, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày lập:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên hợp đồng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_TenHD
            // 
            this.tb_TenHD.Location = new System.Drawing.Point(92, 35);
            this.tb_TenHD.Name = "tb_TenHD";
            this.tb_TenHD.Size = new System.Drawing.Size(163, 20);
            this.tb_TenHD.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã nhân viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_maNV
            // 
            this.tb_maNV.Location = new System.Drawing.Point(92, 63);
            this.tb_maNV.Name = "tb_maNV";
            this.tb_maNV.Size = new System.Drawing.Size(100, 20);
            this.tb_maNV.TabIndex = 4;
            this.tb_maNV.TextChanged += new System.EventHandler(this.tb_maNV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hợp đồng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_MaHD
            // 
            this.tb_MaHD.Location = new System.Drawing.Point(92, 9);
            this.tb_MaHD.Name = "tb_MaHD";
            this.tb_MaHD.Size = new System.Drawing.Size(100, 20);
            this.tb_MaHD.TabIndex = 0;
            // 
            // bt_Thêm
            // 
            this.bt_Thêm.Location = new System.Drawing.Point(342, 438);
            this.bt_Thêm.Name = "bt_Thêm";
            this.bt_Thêm.Size = new System.Drawing.Size(75, 23);
            this.bt_Thêm.TabIndex = 3;
            this.bt_Thêm.Text = "Thêm ";
            this.bt_Thêm.UseVisualStyleBackColor = true;
            this.bt_Thêm.Click += new System.EventHandler(this.bt_Thêm_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(442, 438);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_Xoa.TabIndex = 4;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(541, 438);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 23);
            this.bt_Sua.TabIndex = 5;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(124, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "DANH SÁCH HỢP ĐỒNG";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(692, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "THÔNG TIN HỢP ĐỒNG";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(902, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 9;
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(9, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "TênNV";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_Lich
            // 
            this.bt_Lich.Location = new System.Drawing.Point(852, 12);
            this.bt_Lich.Name = "bt_Lich";
            this.bt_Lich.Size = new System.Drawing.Size(155, 23);
            this.bt_Lich.TabIndex = 11;
            this.bt_Lich.Text = "Lịch Thời Hạn Hợp Đồng";
            this.bt_Lich.UseVisualStyleBackColor = true;
            this.bt_Lich.Click += new System.EventHandler(this.bt_Lich_Click);
            // 
            // bt_GuiMail
            // 
            this.bt_GuiMail.Location = new System.Drawing.Point(642, 438);
            this.bt_GuiMail.Name = "bt_GuiMail";
            this.bt_GuiMail.Size = new System.Drawing.Size(75, 23);
            this.bt_GuiMail.TabIndex = 12;
            this.bt_GuiMail.Text = "Gửi Mail";
            this.bt_GuiMail.UseVisualStyleBackColor = true;
            this.bt_GuiMail.Click += new System.EventHandler(this.bt_GuiMail_Click);
            // 
            // MHHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 487);
            this.Controls.Add(this.bt_GuiMail);
            this.Controls.Add(this.bt_Lich);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Thêm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_HopDong);
            this.Name = "MHHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MHHopDong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MHHopDong_FormClosing);
            this.Load += new System.EventHandler(this.HopDong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HopDong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_HopDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_HopDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_TenHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_maDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_maNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MaHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Tendoitac;
        private System.Windows.Forms.DateTimePicker dtpicker_Thoihan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpicker_NgayLap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_NoiDung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_ViTriDang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_Thêm;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_TenNV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bt_Lich;
        private System.Windows.Forms.Button bt_GuiMail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_Gmail;
    }
}