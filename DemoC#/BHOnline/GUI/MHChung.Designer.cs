namespace GUI
{
    partial class MHChung
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
            this.bt_KhachHang = new System.Windows.Forms.Button();
            this.bt_NhanVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_KhachHang
            // 
            this.bt_KhachHang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bt_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_KhachHang.Location = new System.Drawing.Point(82, 88);
            this.bt_KhachHang.Name = "bt_KhachHang";
            this.bt_KhachHang.Size = new System.Drawing.Size(149, 63);
            this.bt_KhachHang.TabIndex = 0;
            this.bt_KhachHang.Text = "Khách hàng";
            this.bt_KhachHang.UseVisualStyleBackColor = false;
            this.bt_KhachHang.Click += new System.EventHandler(this.bt_KhachHang_Click);
            // 
            // bt_NhanVien
            // 
            this.bt_NhanVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bt_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NhanVien.Location = new System.Drawing.Point(280, 88);
            this.bt_NhanVien.Name = "bt_NhanVien";
            this.bt_NhanVien.Size = new System.Drawing.Size(148, 63);
            this.bt_NhanVien.TabIndex = 1;
            this.bt_NhanVien.Text = "Nhân viên";
            this.bt_NhanVien.UseVisualStyleBackColor = false;
            this.bt_NhanVien.Click += new System.EventHandler(this.bt_NhanVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "HỆ THỐNG BÁN HÀNG ONLINE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MHChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_NhanVien);
            this.Controls.Add(this.bt_KhachHang);
            this.Name = "MHChung";
            this.Text = "MHChung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_KhachHang;
        private System.Windows.Forms.Button bt_NhanVien;
        private System.Windows.Forms.Label label1;
    }
}