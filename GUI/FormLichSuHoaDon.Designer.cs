namespace Do_An_PLB03.GUI
{
    partial class FormQuanLiHoaDon
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
            this.dtHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTong = new System.Windows.Forms.Label();
            this.txtTongSoHoaDon = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lbTenNguoiDung = new System.Windows.Forms.Label();
            this.txtTenSan = new System.Windows.Forms.TextBox();
            this.lbTenSan = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lbSDTKH = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtHoaDon
            // 
            this.dtHoaDon.AllowUserToAddRows = false;
            this.dtHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHoaDon.Location = new System.Drawing.Point(0, 21);
            this.dtHoaDon.Name = "dtHoaDon";
            this.dtHoaDon.ReadOnly = true;
            this.dtHoaDon.RowHeadersWidth = 51;
            this.dtHoaDon.RowTemplate.Height = 24;
            this.dtHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtHoaDon.Size = new System.Drawing.Size(944, 412);
            this.dtHoaDon.TabIndex = 0;
            this.dtHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHoaDon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(962, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ đã dùng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(13, 553);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(109, 16);
            this.lbTong.TabIndex = 2;
            this.lbTong.Text = "Tổng số hóa đơn";
            // 
            // txtTongSoHoaDon
            // 
            this.txtTongSoHoaDon.Location = new System.Drawing.Point(146, 550);
            this.txtTongSoHoaDon.Name = "txtTongSoHoaDon";
            this.txtTongSoHoaDon.Size = new System.Drawing.Size(118, 22);
            this.txtTongSoHoaDon.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpKetThuc);
            this.groupBox2.Controls.Add(this.lbDenNgay);
            this.groupBox2.Controls.Add(this.dtpBatDau);
            this.groupBox2.Controls.Add(this.lbTuNgay);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.lbTenNguoiDung);
            this.groupBox2.Controls.Add(this.txtTenSan);
            this.groupBox2.Controls.Add(this.lbTenSan);
            this.groupBox2.Controls.Add(this.txtSDTKH);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.lbSDTKH);
            this.groupBox2.Controls.Add(this.lbTenKH);
            this.groupBox2.Location = new System.Drawing.Point(26, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1054, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc hóa đơn";
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Location = new System.Drawing.Point(839, 64);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpKetThuc.TabIndex = 14;
            this.dtpKetThuc.ValueChanged += new System.EventHandler(this.Text_Changed);
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Location = new System.Drawing.Point(746, 66);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(64, 16);
            this.lbDenNgay.TabIndex = 13;
            this.lbDenNgay.Text = "Đến ngày";
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Location = new System.Drawing.Point(839, 25);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpBatDau.TabIndex = 12;
            this.dtpBatDau.ValueChanged += new System.EventHandler(this.Text_Changed);
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Location = new System.Drawing.Point(754, 27);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(56, 16);
            this.lbTuNgay.TabIndex = 11;
            this.lbTuNgay.Text = "Từ ngày";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(531, 63);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(168, 22);
            this.txtTenNV.TabIndex = 10;
            this.txtTenNV.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // lbTenNguoiDung
            // 
            this.lbTenNguoiDung.AutoSize = true;
            this.lbTenNguoiDung.Location = new System.Drawing.Point(395, 66);
            this.lbTenNguoiDung.Name = "lbTenNguoiDung";
            this.lbTenNguoiDung.Size = new System.Drawing.Size(96, 16);
            this.lbTenNguoiDung.TabIndex = 9;
            this.lbTenNguoiDung.Text = "Tên Nhân Viên";
            // 
            // txtTenSan
            // 
            this.txtTenSan.Location = new System.Drawing.Point(531, 27);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.Size = new System.Drawing.Size(168, 22);
            this.txtTenSan.TabIndex = 8;
            this.txtTenSan.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // lbTenSan
            // 
            this.lbTenSan.AutoSize = true;
            this.lbTenSan.Location = new System.Drawing.Point(414, 27);
            this.lbTenSan.Name = "lbTenSan";
            this.lbTenSan.Size = new System.Drawing.Size(58, 16);
            this.lbTenSan.TabIndex = 7;
            this.lbTenSan.Text = "Tên Sân";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(175, 64);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(168, 22);
            this.txtSDTKH.TabIndex = 6;
            this.txtSDTKH.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(175, 25);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(168, 22);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // lbSDTKH
            // 
            this.lbSDTKH.AutoSize = true;
            this.lbSDTKH.Location = new System.Drawing.Point(15, 66);
            this.lbSDTKH.Name = "lbSDTKH";
            this.lbSDTKH.Size = new System.Drawing.Size(110, 16);
            this.lbSDTKH.TabIndex = 5;
            this.lbSDTKH.Text = "SĐT Khách Hàng";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(15, 27);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(107, 16);
            this.lbTenKH.TabIndex = 0;
            this.lbTenKH.Text = "Tên Khách Hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtHoaDon);
            this.groupBox3.Location = new System.Drawing.Point(12, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(950, 412);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lịch sử hóa đơn";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1121, 53);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 42);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormQuanLiHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 795);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTongSoHoaDon);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLiHoaDon";
            this.Text = "FormQuanLiHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dtHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.TextBox txtTongSoHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lbTenNguoiDung;
        private System.Windows.Forms.TextBox txtTenSan;
        private System.Windows.Forms.Label lbTenSan;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lbSDTKH;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
    }
}