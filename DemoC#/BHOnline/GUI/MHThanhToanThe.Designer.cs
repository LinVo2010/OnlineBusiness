namespace GUI
{
    partial class MHThanhToanThe
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
            this.datatime_NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.lb_NgayHetHan = new System.Windows.Forms.Label();
            this.cbx_LoaiThe = new System.Windows.Forms.ComboBox();
            this.lb_LoaiThe = new System.Windows.Forms.Label();
            this.txb_SoThe = new System.Windows.Forms.TextBox();
            this.lb_SoThe = new System.Windows.Forms.Label();
            this.txb_ChuThe = new System.Windows.Forms.TextBox();
            this.lb_ChuThe = new System.Windows.Forms.Label();
            this.lb_TTThe = new System.Windows.Forms.Label();
            this.lb_ThanhToanThe = new System.Windows.Forms.Label();
            this.btn_DongY = new System.Windows.Forms.Button();
            this.lbNguoiDung = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datatime_NgayHetHan);
            this.panel1.Controls.Add(this.lb_NgayHetHan);
            this.panel1.Controls.Add(this.cbx_LoaiThe);
            this.panel1.Controls.Add(this.lb_LoaiThe);
            this.panel1.Controls.Add(this.txb_SoThe);
            this.panel1.Controls.Add(this.lb_SoThe);
            this.panel1.Controls.Add(this.txb_ChuThe);
            this.panel1.Controls.Add(this.lb_ChuThe);
            this.panel1.Location = new System.Drawing.Point(33, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 187);
            this.panel1.TabIndex = 20;
            // 
            // datatime_NgayHetHan
            // 
            this.datatime_NgayHetHan.CalendarFont = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datatime_NgayHetHan.CustomFormat = "dd-mm-yyyy";
            this.datatime_NgayHetHan.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datatime_NgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datatime_NgayHetHan.Location = new System.Drawing.Point(193, 128);
            this.datatime_NgayHetHan.Name = "datatime_NgayHetHan";
            this.datatime_NgayHetHan.Size = new System.Drawing.Size(322, 28);
            this.datatime_NgayHetHan.TabIndex = 7;
            // 
            // lb_NgayHetHan
            // 
            this.lb_NgayHetHan.AutoSize = true;
            this.lb_NgayHetHan.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayHetHan.Location = new System.Drawing.Point(3, 125);
            this.lb_NgayHetHan.Name = "lb_NgayHetHan";
            this.lb_NgayHetHan.Size = new System.Drawing.Size(117, 21);
            this.lb_NgayHetHan.TabIndex = 6;
            this.lb_NgayHetHan.Text = "Ngày hết hạn";
            // 
            // cbx_LoaiThe
            // 
            this.cbx_LoaiThe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LoaiThe.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_LoaiThe.FormattingEnabled = true;
            this.cbx_LoaiThe.Items.AddRange(new object[] {
            "TechComBank",
            "ViettinBank",
            "AgriBank",
            "Vietcombank"});
            this.cbx_LoaiThe.Location = new System.Drawing.Point(755, 65);
            this.cbx_LoaiThe.Name = "cbx_LoaiThe";
            this.cbx_LoaiThe.Size = new System.Drawing.Size(196, 29);
            this.cbx_LoaiThe.TabIndex = 5;
            // 
            // lb_LoaiThe
            // 
            this.lb_LoaiThe.AutoSize = true;
            this.lb_LoaiThe.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiThe.Location = new System.Drawing.Point(610, 72);
            this.lb_LoaiThe.Name = "lb_LoaiThe";
            this.lb_LoaiThe.Size = new System.Drawing.Size(74, 21);
            this.lb_LoaiThe.TabIndex = 4;
            this.lb_LoaiThe.Text = "Loại thẻ";
            // 
            // txb_SoThe
            // 
            this.txb_SoThe.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SoThe.Location = new System.Drawing.Point(193, 69);
            this.txb_SoThe.Name = "txb_SoThe";
            this.txb_SoThe.Size = new System.Drawing.Size(322, 28);
            this.txb_SoThe.TabIndex = 3;
            // 
            // lb_SoThe
            // 
            this.lb_SoThe.AutoSize = true;
            this.lb_SoThe.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoThe.Location = new System.Drawing.Point(3, 72);
            this.lb_SoThe.Name = "lb_SoThe";
            this.lb_SoThe.Size = new System.Drawing.Size(62, 21);
            this.lb_SoThe.TabIndex = 2;
            this.lb_SoThe.Text = "Số thẻ";
            // 
            // txb_ChuThe
            // 
            this.txb_ChuThe.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ChuThe.Location = new System.Drawing.Point(193, 17);
            this.txb_ChuThe.Name = "txb_ChuThe";
            this.txb_ChuThe.Size = new System.Drawing.Size(322, 28);
            this.txb_ChuThe.TabIndex = 1;
            // 
            // lb_ChuThe
            // 
            this.lb_ChuThe.AutoSize = true;
            this.lb_ChuThe.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChuThe.Location = new System.Drawing.Point(3, 20);
            this.lb_ChuThe.Name = "lb_ChuThe";
            this.lb_ChuThe.Size = new System.Drawing.Size(73, 21);
            this.lb_ChuThe.TabIndex = 0;
            this.lb_ChuThe.Text = "Chủ thẻ";
            // 
            // lb_TTThe
            // 
            this.lb_TTThe.AutoSize = true;
            this.lb_TTThe.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TTThe.Location = new System.Drawing.Point(28, 118);
            this.lb_TTThe.Name = "lb_TTThe";
            this.lb_TTThe.Size = new System.Drawing.Size(151, 21);
            this.lb_TTThe.TabIndex = 19;
            this.lb_TTThe.Text = "Điền thông tin thẻ";
            // 
            // lb_ThanhToanThe
            // 
            this.lb_ThanhToanThe.AutoSize = true;
            this.lb_ThanhToanThe.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhToanThe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_ThanhToanThe.Location = new System.Drawing.Point(374, 51);
            this.lb_ThanhToanThe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ThanhToanThe.Name = "lb_ThanhToanThe";
            this.lb_ThanhToanThe.Size = new System.Drawing.Size(211, 32);
            this.lb_ThanhToanThe.TabIndex = 18;
            this.lb_ThanhToanThe.Text = "Thanh Toán Thẻ";
            // 
            // btn_DongY
            // 
            this.btn_DongY.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DongY.Location = new System.Drawing.Point(822, 358);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(162, 42);
            this.btn_DongY.TabIndex = 17;
            this.btn_DongY.Text = "Đồng ý";
            this.btn_DongY.UseVisualStyleBackColor = true;
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click_1);
            // 
            // lbNguoiDung
            // 
            this.lbNguoiDung.AutoSize = true;
            this.lbNguoiDung.Location = new System.Drawing.Point(876, 37);
            this.lbNguoiDung.Name = "lbNguoiDung";
            this.lbNguoiDung.Size = new System.Drawing.Size(35, 13);
            this.lbNguoiDung.TabIndex = 21;
            this.lbNguoiDung.Text = "label1";
            // 
            // MHThanhToanThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.lbNguoiDung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_TTThe);
            this.Controls.Add(this.lb_ThanhToanThe);
            this.Controls.Add(this.btn_DongY);
            this.Name = "MHThanhToanThe";
            this.Text = "MHThanhToanThe";
            this.Load += new System.EventHandler(this.MHThanhToanThe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datatime_NgayHetHan;
        private System.Windows.Forms.Label lb_NgayHetHan;
        private System.Windows.Forms.ComboBox cbx_LoaiThe;
        private System.Windows.Forms.Label lb_LoaiThe;
        private System.Windows.Forms.TextBox txb_SoThe;
        private System.Windows.Forms.Label lb_SoThe;
        private System.Windows.Forms.TextBox txb_ChuThe;
        private System.Windows.Forms.Label lb_ChuThe;
        private System.Windows.Forms.Label lb_TTThe;
        private System.Windows.Forms.Label lb_ThanhToanThe;
        private System.Windows.Forms.Button btn_DongY;
        private System.Windows.Forms.Label lbNguoiDung;
    }
}