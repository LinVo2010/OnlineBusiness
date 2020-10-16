namespace GUI
{
    partial class MHDonTraHang
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
            this.dgvTraHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpk_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbDT = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.tbLiDo = new System.Windows.Forms.TextBox();
            this.tbMaDTH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTraHang
            // 
            this.dgvTraHang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTraHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraHang.Location = new System.Drawing.Point(29, 254);
            this.dgvTraHang.Name = "dgvTraHang";
            this.dgvTraHang.Size = new System.Drawing.Size(532, 140);
            this.dgvTraHang.TabIndex = 6;
            this.dgvTraHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraHang_CellClick);
            this.dgvTraHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraHang_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dtpk_NgayLap);
            this.panel1.Controls.Add(this.cbDT);
            this.panel1.Controls.Add(this.cbMaNV);
            this.panel1.Controls.Add(this.tbLiDo);
            this.panel1.Controls.Add(this.tbMaDTH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 176);
            this.panel1.TabIndex = 5;
            // 
            // dtpk_NgayLap
            // 
            this.dtpk_NgayLap.CustomFormat = "dd-MM-yyyy";
            this.dtpk_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_NgayLap.Location = new System.Drawing.Point(352, 15);
            this.dtpk_NgayLap.Name = "dtpk_NgayLap";
            this.dtpk_NgayLap.Size = new System.Drawing.Size(162, 20);
            this.dtpk_NgayLap.TabIndex = 14;
            // 
            // cbDT
            // 
            this.cbDT.FormattingEnabled = true;
            this.cbDT.Location = new System.Drawing.Point(125, 125);
            this.cbDT.Name = "cbDT";
            this.cbDT.Size = new System.Drawing.Size(124, 21);
            this.cbDT.TabIndex = 13;
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(125, 70);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(124, 21);
            this.cbMaNV.TabIndex = 8;
            // 
            // tbLiDo
            // 
            this.tbLiDo.Location = new System.Drawing.Point(352, 70);
            this.tbLiDo.Multiline = true;
            this.tbLiDo.Name = "tbLiDo";
            this.tbLiDo.Size = new System.Drawing.Size(162, 52);
            this.tbLiDo.TabIndex = 7;
            // 
            // tbMaDTH
            // 
            this.tbMaDTH.Location = new System.Drawing.Point(125, 18);
            this.tbMaDTH.Name = "tbMaDTH";
            this.tbMaDTH.Size = new System.Drawing.Size(124, 20);
            this.tbMaDTH.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lí do trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đối tác bán hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn trả hàng:";
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(477, 405);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(84, 33);
            this.btnTao.TabIndex = 10;
            this.btnTao.Text = "Lập đơn";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(179, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "LẬP ĐƠN TRẢ HÀNG";
            // 
            // MHDonTraHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.dgvTraHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTao);
            this.Name = "MHDonTraHang";
            this.Text = "MHDonTraHang";
            this.Load += new System.EventHandler(this.MHDonTraHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTraHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpk_NgayLap;
        private System.Windows.Forms.ComboBox cbDT;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.TextBox tbLiDo;
        private System.Windows.Forms.TextBox tbMaDTH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}