namespace GUI
{
    partial class MHLoaiSP
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
            this.lo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTenLoai = new System.Windows.Forms.TextBox();
            this.tbMaLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lo
            // 
            this.lo.AutoSize = true;
            this.lo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lo.Location = new System.Drawing.Point(196, 19);
            this.lo.Name = "lo";
            this.lo.Size = new System.Drawing.Size(169, 24);
            this.lo.TabIndex = 1;
            this.lo.Text = "LOẠI SẢN PHẨM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.tbTenLoai);
            this.panel1.Controls.Add(this.tbMaLoai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(335, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 178);
            this.panel1.TabIndex = 2;
            // 
            // tbTenLoai
            // 
            this.tbTenLoai.Location = new System.Drawing.Point(38, 87);
            this.tbTenLoai.Multiline = true;
            this.tbTenLoai.Name = "tbTenLoai";
            this.tbTenLoai.Size = new System.Drawing.Size(185, 26);
            this.tbTenLoai.TabIndex = 3;
            // 
            // tbMaLoai
            // 
            this.tbMaLoai.Location = new System.Drawing.Point(38, 32);
            this.tbMaLoai.Multiline = true;
            this.tbMaLoai.Name = "tbMaLoai";
            this.tbMaLoai.Size = new System.Drawing.Size(185, 26);
            this.tbMaLoai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sản phẩm:";
            // 
            // dtgvLoaiSP
            // 
            this.dtgvLoaiSP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiSP.Location = new System.Drawing.Point(22, 78);
            this.dtgvLoaiSP.Name = "dtgvLoaiSP";
            this.dtgvLoaiSP.Size = new System.Drawing.Size(307, 178);
            this.dtgvLoaiSP.TabIndex = 3;
            this.dtgvLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiSP_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(87, 279);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 29);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(222, 279);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 29);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // MHLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 341);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvLoaiSP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lo);
            this.Name = "MHLoaiSP";
            this.Text = "MHLoaiSP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MHLoaiSP_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MHLoaiSP_FormClosed);
            this.Load += new System.EventHandler(this.MHLoaiSP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvLoaiSP;
        private System.Windows.Forms.TextBox tbTenLoai;
        private System.Windows.Forms.TextBox tbMaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
    }
}