namespace Do_An_PLB03.GUI
{
    partial class FormXemChiTietDatSan
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
            this.btnctDong = new System.Windows.Forms.Button();
            this.btnHuySan = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtctSDT = new System.Windows.Forms.TextBox();
            this.txtctTenKhachHang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtctNgayTra = new System.Windows.Forms.TextBox();
            this.txtctNgayNhan = new System.Windows.Forms.TextBox();
            this.txtctTenSan = new System.Windows.Forms.TextBox();
            this.txtctTenLoaiSan = new System.Windows.Forms.TextBox();
            this.txtctMaDonHang = new System.Windows.Forms.TextBox();
            this.txtctMaTrangThai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnctDong);
            this.panel1.Controls.Add(this.btnHuySan);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 470);
            this.panel1.TabIndex = 0;
            // 
            // btnctDong
            // 
            this.btnctDong.BackColor = System.Drawing.Color.LightCyan;
            this.btnctDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnctDong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnctDong.Location = new System.Drawing.Point(591, 348);
            this.btnctDong.Name = "btnctDong";
            this.btnctDong.Size = new System.Drawing.Size(132, 49);
            this.btnctDong.TabIndex = 3;
            this.btnctDong.Text = "Đóng";
            this.btnctDong.UseVisualStyleBackColor = false;
            this.btnctDong.Click += new System.EventHandler(this.btnctDong_Click);
            // 
            // btnHuySan
            // 
            this.btnHuySan.BackColor = System.Drawing.Color.LightCyan;
            this.btnHuySan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuySan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHuySan.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnHuySan.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnHuySan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuySan.IconSize = 40;
            this.btnHuySan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuySan.Location = new System.Drawing.Point(20, 341);
            this.btnHuySan.Name = "btnHuySan";
            this.btnHuySan.Size = new System.Drawing.Size(132, 56);
            this.btnHuySan.TabIndex = 2;
            this.btnHuySan.Text = "Hủy Sân";
            this.btnHuySan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuySan.UseVisualStyleBackColor = false;
            this.btnHuySan.Click += new System.EventHandler(this.btnHuySan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtctSDT);
            this.groupBox2.Controls.Add(this.txtctTenKhachHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(469, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(17, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "SDT Khách Hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(17, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Khách Hàng:";
            // 
            // txtctSDT
            // 
            this.txtctSDT.Location = new System.Drawing.Point(20, 106);
            this.txtctSDT.Name = "txtctSDT";
            this.txtctSDT.Size = new System.Drawing.Size(122, 27);
            this.txtctSDT.TabIndex = 1;
            // 
            // txtctTenKhachHang
            // 
            this.txtctTenKhachHang.Location = new System.Drawing.Point(20, 60);
            this.txtctTenKhachHang.Name = "txtctTenKhachHang";
            this.txtctTenKhachHang.Size = new System.Drawing.Size(122, 27);
            this.txtctTenKhachHang.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txtctNgayTra);
            this.groupBox1.Controls.Add(this.txtctNgayNhan);
            this.groupBox1.Controls.Add(this.txtctTenSan);
            this.groupBox1.Controls.Add(this.txtctTenLoaiSan);
            this.groupBox1.Controls.Add(this.txtctMaDonHang);
            this.groupBox1.Controls.Add(this.txtctMaTrangThai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhận sân";
            // 
            // txtctNgayTra
            // 
            this.txtctNgayTra.Location = new System.Drawing.Point(220, 162);
            this.txtctNgayTra.Name = "txtctNgayTra";
            this.txtctNgayTra.Size = new System.Drawing.Size(122, 27);
            this.txtctNgayTra.TabIndex = 1;
            // 
            // txtctNgayNhan
            // 
            this.txtctNgayNhan.Location = new System.Drawing.Point(220, 106);
            this.txtctNgayNhan.Name = "txtctNgayNhan";
            this.txtctNgayNhan.Size = new System.Drawing.Size(122, 27);
            this.txtctNgayNhan.TabIndex = 1;
            // 
            // txtctTenSan
            // 
            this.txtctTenSan.Location = new System.Drawing.Point(223, 50);
            this.txtctTenSan.Name = "txtctTenSan";
            this.txtctTenSan.Size = new System.Drawing.Size(122, 27);
            this.txtctTenSan.TabIndex = 1;
            // 
            // txtctTenLoaiSan
            // 
            this.txtctTenLoaiSan.Location = new System.Drawing.Point(9, 162);
            this.txtctTenLoaiSan.Name = "txtctTenLoaiSan";
            this.txtctTenLoaiSan.Size = new System.Drawing.Size(122, 27);
            this.txtctTenLoaiSan.TabIndex = 1;
            // 
            // txtctMaDonHang
            // 
            this.txtctMaDonHang.Location = new System.Drawing.Point(9, 50);
            this.txtctMaDonHang.Name = "txtctMaDonHang";
            this.txtctMaDonHang.Size = new System.Drawing.Size(122, 27);
            this.txtctMaDonHang.TabIndex = 1;
            // 
            // txtctMaTrangThai
            // 
            this.txtctMaTrangThai.Location = new System.Drawing.Point(9, 116);
            this.txtctMaTrangThai.Name = "txtctMaTrangThai";
            this.txtctMaTrangThai.Size = new System.Drawing.Size(122, 27);
            this.txtctMaTrangThai.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(220, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày giờ trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(220, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày giờ nhận:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(220, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Sân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Loại Sân:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(5, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Đơn Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Trạng Thái Sân:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Đặt Sân";
            // 
            // FormXemChiTietDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormXemChiTietDatSan";
            this.Text = "FormXemChiTietDatSan";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtctNgayTra;
        private System.Windows.Forms.TextBox txtctTenSan;
        private System.Windows.Forms.TextBox txtctTenLoaiSan;
        private System.Windows.Forms.TextBox txtctMaTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnctDong;
        private FontAwesome.Sharp.IconButton btnHuySan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtctSDT;
        private System.Windows.Forms.TextBox txtctTenKhachHang;
        private System.Windows.Forms.TextBox txtctMaDonHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtctNgayNhan;
    }
}