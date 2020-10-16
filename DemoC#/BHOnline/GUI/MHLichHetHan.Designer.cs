namespace GUI
{
    partial class MHLichHetHan
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_HomNay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPreviours = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_ChuNhat = new System.Windows.Forms.Button();
            this.bt_ThuBay = new System.Windows.Forms.Button();
            this.bt_ThuBa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_ThuSau = new System.Windows.Forms.Button();
            this.bt_ThuNam = new System.Windows.Forms.Button();
            this.bt_ThuHai = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Maxtrix = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_HopDong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_Maxtrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 437);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.bt_HomNay);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(30, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 48);
            this.panel3.TabIndex = 1;
            // 
            // bt_HomNay
            // 
            this.bt_HomNay.Location = new System.Drawing.Point(613, 7);
            this.bt_HomNay.Name = "bt_HomNay";
            this.bt_HomNay.Size = new System.Drawing.Size(75, 23);
            this.bt_HomNay.TabIndex = 2;
            this.bt_HomNay.Text = "Hôm nay";
            this.bt_HomNay.UseVisualStyleBackColor = true;
            this.bt_HomNay.Click += new System.EventHandler(this.bt_HomNay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.CustomFormat = "dd-MM-yyyy";
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDate.Location = new System.Drawing.Point(407, 7);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkDate.TabIndex = 1;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(404, 312);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPreviours);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pnl_Maxtrix);
            this.panel2.Location = new System.Drawing.Point(30, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 360);
            this.panel2.TabIndex = 1;
            // 
            // btnPreviours
            // 
            this.btnPreviours.Location = new System.Drawing.Point(26, 9);
            this.btnPreviours.Name = "btnPreviours";
            this.btnPreviours.Size = new System.Drawing.Size(75, 32);
            this.btnPreviours.TabIndex = 7;
            this.btnPreviours.Text = "Tháng trước";
            this.btnPreviours.UseVisualStyleBackColor = true;
            this.btnPreviours.Click += new System.EventHandler(this.btnPreviours_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(721, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Tháng sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bt_ChuNhat);
            this.panel4.Controls.Add(this.bt_ThuBay);
            this.panel4.Controls.Add(this.bt_ThuBa);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.bt_ThuSau);
            this.panel4.Controls.Add(this.bt_ThuNam);
            this.panel4.Controls.Add(this.bt_ThuHai);
            this.panel4.Controls.Add(this.flowLayoutPanel3);
            this.panel4.Location = new System.Drawing.Point(122, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 38);
            this.panel4.TabIndex = 2;
            // 
            // bt_ChuNhat
            // 
            this.bt_ChuNhat.Location = new System.Drawing.Point(495, 3);
            this.bt_ChuNhat.Name = "bt_ChuNhat";
            this.bt_ChuNhat.Size = new System.Drawing.Size(75, 32);
            this.bt_ChuNhat.TabIndex = 6;
            this.bt_ChuNhat.Text = "Chủ Nhật";
            this.bt_ChuNhat.UseVisualStyleBackColor = true;
            // 
            // bt_ThuBay
            // 
            this.bt_ThuBay.Location = new System.Drawing.Point(414, 3);
            this.bt_ThuBay.Name = "bt_ThuBay";
            this.bt_ThuBay.Size = new System.Drawing.Size(75, 32);
            this.bt_ThuBay.TabIndex = 2;
            this.bt_ThuBay.Text = "Thứ Bảy";
            this.bt_ThuBay.UseVisualStyleBackColor = true;
            // 
            // bt_ThuBa
            // 
            this.bt_ThuBa.Location = new System.Drawing.Point(90, 3);
            this.bt_ThuBa.Name = "bt_ThuBa";
            this.bt_ThuBa.Size = new System.Drawing.Size(75, 32);
            this.bt_ThuBa.TabIndex = 5;
            this.bt_ThuBa.Text = "Thứ Ba";
            this.bt_ThuBa.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Thứ Tư";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bt_ThuSau
            // 
            this.bt_ThuSau.Location = new System.Drawing.Point(333, 3);
            this.bt_ThuSau.Name = "bt_ThuSau";
            this.bt_ThuSau.Size = new System.Drawing.Size(75, 32);
            this.bt_ThuSau.TabIndex = 3;
            this.bt_ThuSau.Text = "Thứ Sáu";
            this.bt_ThuSau.UseVisualStyleBackColor = true;
            // 
            // bt_ThuNam
            // 
            this.bt_ThuNam.Location = new System.Drawing.Point(252, 3);
            this.bt_ThuNam.Name = "bt_ThuNam";
            this.bt_ThuNam.Size = new System.Drawing.Size(75, 32);
            this.bt_ThuNam.TabIndex = 2;
            this.bt_ThuNam.Text = "Thứ Năm";
            this.bt_ThuNam.UseVisualStyleBackColor = true;
            // 
            // bt_ThuHai
            // 
            this.bt_ThuHai.Location = new System.Drawing.Point(9, 3);
            this.bt_ThuHai.Name = "bt_ThuHai";
            this.bt_ThuHai.Size = new System.Drawing.Size(75, 32);
            this.bt_ThuHai.TabIndex = 1;
            this.bt_ThuHai.Text = "Thứ Hai";
            this.bt_ThuHai.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(404, 312);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // pnl_Maxtrix
            // 
            this.pnl_Maxtrix.Controls.Add(this.flowLayoutPanel4);
            this.pnl_Maxtrix.Location = new System.Drawing.Point(131, 44);
            this.pnl_Maxtrix.Name = "pnl_Maxtrix";
            this.pnl_Maxtrix.Size = new System.Drawing.Size(561, 313);
            this.pnl_Maxtrix.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(404, 312);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // lb_HopDong
            // 
            this.lb_HopDong.AutoSize = true;
            this.lb_HopDong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_HopDong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_HopDong.Location = new System.Drawing.Point(331, 24);
            this.lb_HopDong.Name = "lb_HopDong";
            this.lb_HopDong.Size = new System.Drawing.Size(287, 24);
            this.lb_HopDong.TabIndex = 1;
            this.lb_HopDong.Text = "LỊCH THỜI HẠN HỢP ĐỒNG";
            // 
            // MHLichHetHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 519);
            this.Controls.Add(this.lb_HopDong);
            this.Controls.Add(this.panel1);
            this.Name = "MHLichHetHan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MHLichHetHanHopDong";
            this.Load += new System.EventHandler(this.MHLichHetHan_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnl_Maxtrix.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Maxtrix;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button bt_HomNay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button btnPreviours;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button bt_ChuNhat;
        private System.Windows.Forms.Button bt_ThuBay;
        private System.Windows.Forms.Button bt_ThuBa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_ThuSau;
        private System.Windows.Forms.Button bt_ThuNam;
        private System.Windows.Forms.Button bt_ThuHai;
        private System.Windows.Forms.Label lb_HopDong;
    }
}