namespace Do_An_PLB03
{
    partial class FormConNhanVien
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clhSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTuoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhSdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCccd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhUername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView1.BackColor = System.Drawing.Color.Snow;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhSTT,
            this.clhTen,
            this.clmTuoi,
            this.clhGioiTinh,
            this.clhSdt,
            this.clhDiaChi,
            this.clhCccd,
            this.clhCa,
            this.clhLuong,
            this.clhUername,
            this.clhPassword,
            this.clhChucVu});
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1189, 532);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clhSTT
            // 
            this.clhSTT.Text = "STT";
            this.clhSTT.Width = 48;
            // 
            // clhTen
            // 
            this.clhTen.Text = "Tên";
            this.clhTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTen.Width = 149;
            // 
            // clmTuoi
            // 
            this.clmTuoi.Text = "Tuổi";
            this.clmTuoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmTuoi.Width = 70;
            // 
            // clhGioiTinh
            // 
            this.clhGioiTinh.Text = "Giới Tính";
            this.clhGioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhGioiTinh.Width = 89;
            // 
            // clhSdt
            // 
            this.clhSdt.Text = "SĐT";
            this.clhSdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhSdt.Width = 110;
            // 
            // clhDiaChi
            // 
            this.clhDiaChi.Text = "Địa Chỉ";
            this.clhDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhDiaChi.Width = 184;
            // 
            // clhCccd
            // 
            this.clhCccd.Text = "CCCD";
            this.clhCccd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhCccd.Width = 127;
            // 
            // clhCa
            // 
            this.clhCa.Text = "Ca làm";
            // 
            // clhLuong
            // 
            this.clhLuong.Text = "Lương";
            this.clhLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhLuong.Width = 77;
            // 
            // clhUername
            // 
            this.clhUername.Text = "User name";
            this.clhUername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clhUername.Width = 102;
            // 
            // clhPassword
            // 
            this.clhPassword.Text = "Password";
            this.clhPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhPassword.Width = 90;
            // 
            // clhChucVu
            // 
            this.clhChucVu.Text = "Chức Vụ";
            this.clhChucVu.Width = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.iconButton9);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(33, 578);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.iconButton3);
            this.groupBox2.Controls.Add(this.iconButton2);
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Location = new System.Drawing.Point(592, 578);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtUser.Location = new System.Drawing.Point(16, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUser.Size = new System.Drawing.Size(264, 30);
            this.txtUser.TabIndex = 14;
            // 
            // iconButton3
            // 
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.iconButton3.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(393, 44);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(137, 45);
            this.iconButton3.TabIndex = 14;
            this.iconButton3.Text = "Xóa";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.iconButton2.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(227, 44);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(133, 45);
            this.iconButton2.TabIndex = 14;
            this.iconButton2.Text = "sửa";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CommentMedical;
            this.iconButton1.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(51, 44);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(142, 45);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.Text = "Thêm";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton9
            // 
            this.iconButton9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton9.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(186, 71);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton9.Size = new System.Drawing.Size(177, 45);
            this.iconButton9.TabIndex = 13;
            this.iconButton9.Text = "Tìm kiếm";
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton9.UseVisualStyleBackColor = true;
            // 
            // FormConNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1229, 754);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConNhanVien";
            this.Text = "FormConNhanVienDichVu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clhSTT;
        private System.Windows.Forms.ColumnHeader clhTen;
        private System.Windows.Forms.ColumnHeader clmTuoi;
        private System.Windows.Forms.ColumnHeader clhGioiTinh;
        private System.Windows.Forms.ColumnHeader clhSdt;
        private System.Windows.Forms.ColumnHeader clhDiaChi;
        private System.Windows.Forms.ColumnHeader clhCccd;
        private System.Windows.Forms.ColumnHeader clhCa;
        private System.Windows.Forms.ColumnHeader clhLuong;
        private System.Windows.Forms.ColumnHeader clhUername;
        private System.Windows.Forms.ColumnHeader clhPassword;
        private System.Windows.Forms.ColumnHeader clhChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtUser;
    }
}