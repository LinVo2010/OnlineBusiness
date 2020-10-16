namespace GUI
{
    partial class MHDoiTac
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
            this.tb_MaDT = new System.Windows.Forms.TextBox();
            this.tb_TenDT = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.dtgv_DoiTac = new System.Windows.Forms.DataGridView();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Thêm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_HopDong = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Gmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DoiTac)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_MaDT
            // 
            this.tb_MaDT.Location = new System.Drawing.Point(97, 21);
            this.tb_MaDT.Name = "tb_MaDT";
            this.tb_MaDT.Size = new System.Drawing.Size(100, 20);
            this.tb_MaDT.TabIndex = 0;
            // 
            // tb_TenDT
            // 
            this.tb_TenDT.Location = new System.Drawing.Point(97, 47);
            this.tb_TenDT.Name = "tb_TenDT";
            this.tb_TenDT.Size = new System.Drawing.Size(250, 20);
            this.tb_TenDT.TabIndex = 1;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(97, 73);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(250, 20);
            this.tb_DiaChi.TabIndex = 2;
            // 
            // tb_SDT
            // 
            this.tb_SDT.Location = new System.Drawing.Point(97, 99);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(250, 20);
            this.tb_SDT.TabIndex = 3;
            // 
            // dtgv_DoiTac
            // 
            this.dtgv_DoiTac.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgv_DoiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DoiTac.Location = new System.Drawing.Point(66, 268);
            this.dtgv_DoiTac.Name = "dtgv_DoiTac";
            this.dtgv_DoiTac.Size = new System.Drawing.Size(592, 147);
            this.dtgv_DoiTac.TabIndex = 4;
            this.dtgv_DoiTac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DoiTac_CellClick);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(428, 441);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 23);
            this.bt_Sua.TabIndex = 8;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(329, 441);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_Xoa.TabIndex = 7;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Thêm
            // 
            this.bt_Thêm.Location = new System.Drawing.Point(229, 441);
            this.bt_Thêm.Name = "bt_Thêm";
            this.bt_Thêm.Size = new System.Drawing.Size(75, 23);
            this.bt_Thêm.TabIndex = 6;
            this.bt_Thêm.Text = "Thêm ";
            this.bt_Thêm.UseVisualStyleBackColor = true;
            this.bt_Thêm.Click += new System.EventHandler(this.bt_Thêm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã đối tác:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đối tác:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Địa chỉ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(8, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "SĐT:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_HopDong
            // 
            this.lb_HopDong.AutoSize = true;
            this.lb_HopDong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_HopDong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_HopDong.Location = new System.Drawing.Point(308, 24);
            this.lb_HopDong.Name = "lb_HopDong";
            this.lb_HopDong.Size = new System.Drawing.Size(96, 24);
            this.lb_HopDong.TabIndex = 13;
            this.lb_HopDong.Text = "ĐỐI TÁC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(63, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "DANH SÁCH ĐỐI TÁC";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(63, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "THÔNG TIN ĐỐI TÁC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Gmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_TenDT);
            this.groupBox1.Controls.Add(this.tb_MaDT);
            this.groupBox1.Controls.Add(this.tb_DiaChi);
            this.groupBox1.Controls.Add(this.tb_SDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(66, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 159);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // tb_Gmail
            // 
            this.tb_Gmail.Location = new System.Drawing.Point(97, 125);
            this.tb_Gmail.Name = "tb_Gmail";
            this.tb_Gmail.Size = new System.Drawing.Size(250, 20);
            this.tb_Gmail.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(8, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gmail:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MHDoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_HopDong);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Thêm);
            this.Controls.Add(this.dtgv_DoiTac);
            this.Name = "MHDoiTac";
            this.Text = "MHDoiTac";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MHDoiTac_FormClosing);
            this.Load += new System.EventHandler(this.DoiTacGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DoiTac)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MaDT;
        private System.Windows.Forms.TextBox tb_TenDT;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.DataGridView dtgv_DoiTac;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Thêm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_HopDong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Gmail;
        private System.Windows.Forms.Label label6;
    }
}