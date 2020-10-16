namespace GUI
{
    partial class MHThemComment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TenSanPham1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_NoiDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Sao = new System.Windows.Forms.ComboBox();
            this.bt_TroVe = new System.Windows.Forms.Button();
            this.bt_ThemComment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sao";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_TenSanPham1
            // 
            this.tb_TenSanPham1.Location = new System.Drawing.Point(95, 6);
            this.tb_TenSanPham1.Name = "tb_TenSanPham1";
            this.tb_TenSanPham1.Size = new System.Drawing.Size(215, 20);
            this.tb_TenSanPham1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.tb_NoiDung);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_Sao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung Đánh giá";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Location = new System.Drawing.Point(9, 62);
            this.tb_NoiDung.Multiline = true;
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_NoiDung.Size = new System.Drawing.Size(758, 117);
            this.tb_NoiDung.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nội dung";
            // 
            // cb_Sao
            // 
            this.cb_Sao.FormattingEnabled = true;
            this.cb_Sao.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_Sao.Location = new System.Drawing.Point(38, 22);
            this.cb_Sao.Name = "cb_Sao";
            this.cb_Sao.Size = new System.Drawing.Size(51, 21);
            this.cb_Sao.TabIndex = 2;
            this.cb_Sao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_TroVe
            // 
            this.bt_TroVe.Location = new System.Drawing.Point(15, 235);
            this.bt_TroVe.Name = "bt_TroVe";
            this.bt_TroVe.Size = new System.Drawing.Size(75, 23);
            this.bt_TroVe.TabIndex = 4;
            this.bt_TroVe.Text = "Trở về";
            this.bt_TroVe.UseVisualStyleBackColor = true;
            this.bt_TroVe.Click += new System.EventHandler(this.bt_TroVe_Click);
            // 
            // bt_ThemComment
            // 
            this.bt_ThemComment.Location = new System.Drawing.Point(707, 235);
            this.bt_ThemComment.Name = "bt_ThemComment";
            this.bt_ThemComment.Size = new System.Drawing.Size(75, 23);
            this.bt_ThemComment.TabIndex = 5;
            this.bt_ThemComment.Text = "Thêm";
            this.bt_ThemComment.UseVisualStyleBackColor = true;
            this.bt_ThemComment.Click += new System.EventHandler(this.bt_ThemComment_Click);
            // 
            // MHThemComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.bt_ThemComment);
            this.Controls.Add(this.bt_TroVe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_TenSanPham1);
            this.Controls.Add(this.label1);
            this.Name = "MHThemComment";
            this.Text = "MHThemComment";
            this.Load += new System.EventHandler(this.MHThemComment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TenSanPham1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Sao;
        private System.Windows.Forms.TextBox tb_NoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_TroVe;
        private System.Windows.Forms.Button bt_ThemComment;
    }
}