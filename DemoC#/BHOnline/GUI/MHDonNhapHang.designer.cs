namespace GUI
{
    partial class MHDonNhapHang
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
            this.dtpk_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.cbDT = new System.Windows.Forms.ComboBox();
            this.tbLyDoNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDNH = new System.Windows.Forms.DataGridView();
            this.btnLapDon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDNH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.tbMaDNH);
            this.panel1.Controls.Add(this.dtpk_NgayLap);
            this.panel1.Controls.Add(this.cbMaNV);
            this.panel1.Controls.Add(this.cbDT);
            this.panel1.Controls.Add(this.tbLyDoNhap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(49, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 141);
            this.panel1.TabIndex = 0;
            // 
            // tbMaDNH
            // 
            this.tbMaDNH.Location = new System.Drawing.Point(146, 17);
            this.tbMaDNH.Name = "tbMaDNH";
            this.tbMaDNH.Size = new System.Drawing.Size(157, 20);
            this.tbMaDNH.TabIndex = 16;
            // 
            // dtpk_NgayLap
            // 
            this.dtpk_NgayLap.CustomFormat = "dd-MM-yyyy";
            this.dtpk_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_NgayLap.Location = new System.Drawing.Point(426, 15);
            this.dtpk_NgayLap.Name = "dtpk_NgayLap";
            this.dtpk_NgayLap.Size = new System.Drawing.Size(157, 20);
            this.dtpk_NgayLap.TabIndex = 15;
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(146, 100);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(157, 21);
            this.cbMaNV.TabIndex = 10;
            // 
            // cbDT
            // 
            this.cbDT.FormattingEnabled = true;
            this.cbDT.Location = new System.Drawing.Point(146, 60);
            this.cbDT.Name = "cbDT";
            this.cbDT.Size = new System.Drawing.Size(157, 21);
            this.cbDT.TabIndex = 9;
            // 
            // tbLyDoNhap
            // 
            this.tbLyDoNhap.Location = new System.Drawing.Point(426, 59);
            this.tbLyDoNhap.Name = "tbLyDoNhap";
            this.tbLyDoNhap.Size = new System.Drawing.Size(157, 20);
            this.tbLyDoNhap.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Lập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lý do nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đối tác bán hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn nhập hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "LẬP ĐƠN NHẬP HÀNG";
            // 
            // dtgvDNH
            // 
            this.dtgvDNH.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDNH.Location = new System.Drawing.Point(49, 209);
            this.dtgvDNH.Name = "dtgvDNH";
            this.dtgvDNH.Size = new System.Drawing.Size(600, 150);
            this.dtgvDNH.TabIndex = 2;
            // 
            // btnLapDon
            // 
            this.btnLapDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapDon.Location = new System.Drawing.Point(548, 374);
            this.btnLapDon.Name = "btnLapDon";
            this.btnLapDon.Size = new System.Drawing.Size(101, 33);
            this.btnLapDon.TabIndex = 3;
            this.btnLapDon.Text = "Lập đơn";
            this.btnLapDon.UseVisualStyleBackColor = true;
            this.btnLapDon.Click += new System.EventHandler(this.btnLapDon_Click);
            // 
            // MHDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 430);
            this.Controls.Add(this.btnLapDon);
            this.Controls.Add(this.dtgvDNH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "MHDonNhapHang";
            this.Text = "MHDonNhapHang";
            this.Load += new System.EventHandler(this.MHDonNhapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDNH;
        private System.Windows.Forms.Button btnLapDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.ComboBox cbDT;
        private System.Windows.Forms.TextBox tbLyDoNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpk_NgayLap;
        private System.Windows.Forms.TextBox tbMaDNH;
    }
}