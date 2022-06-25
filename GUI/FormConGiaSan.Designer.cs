namespace Do_An_PLB03.GUI
{
    partial class FormConGiaSan
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
            this.dtGiaSan = new System.Windows.Forms.DataGridView();
            this.txtLoaiSan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTGBD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTGKT = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGiaSan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGiaSan
            // 
            this.dtGiaSan.AllowUserToAddRows = false;
            this.dtGiaSan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGiaSan.BackgroundColor = System.Drawing.Color.Snow;
            this.dtGiaSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGiaSan.Location = new System.Drawing.Point(48, 28);
            this.dtGiaSan.MultiSelect = false;
            this.dtGiaSan.Name = "dtGiaSan";
            this.dtGiaSan.ReadOnly = true;
            this.dtGiaSan.RowHeadersWidth = 51;
            this.dtGiaSan.RowTemplate.Height = 24;
            this.dtGiaSan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGiaSan.Size = new System.Drawing.Size(885, 419);
            this.dtGiaSan.TabIndex = 4;
            this.dtGiaSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGiaSan_CellClick);
            // 
            // txtLoaiSan
            // 
            this.txtLoaiSan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoaiSan.Enabled = false;
            this.txtLoaiSan.Location = new System.Drawing.Point(1116, 59);
            this.txtLoaiSan.Name = "txtLoaiSan";
            this.txtLoaiSan.Size = new System.Drawing.Size(172, 22);
            this.txtLoaiSan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(953, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giá : ";
            // 
            // txtGia
            // 
            this.txtGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGia.Location = new System.Drawing.Point(1116, 318);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(172, 22);
            this.txtGia.TabIndex = 7;
            this.txtGia.MouseLeave += new System.EventHandler(this.txtGia_MouseLeave);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.LightCyan;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSua.Location = new System.Drawing.Point(1151, 412);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 35);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lbTenKH
            // 
            this.lbTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(953, 61);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(64, 16);
            this.lbTenKH.TabIndex = 10;
            this.lbTenKH.Text = "Loại sân: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(953, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thời gian bắt đầu: ";
            // 
            // txtTGBD
            // 
            this.txtTGBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTGBD.Enabled = false;
            this.txtTGBD.Location = new System.Drawing.Point(1116, 137);
            this.txtTGBD.Name = "txtTGBD";
            this.txtTGBD.Size = new System.Drawing.Size(172, 22);
            this.txtTGBD.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(953, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Thời gian kết thúc: ";
            // 
            // txtTGKT
            // 
            this.txtTGKT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTGKT.Enabled = false;
            this.txtTGKT.Location = new System.Drawing.Point(1116, 224);
            this.txtTGKT.Name = "txtTGKT";
            this.txtTGKT.Size = new System.Drawing.Size(172, 22);
            this.txtTGKT.TabIndex = 13;
            // 
            // lblGia
            // 
            this.lblGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.Red;
            this.lblGia.Location = new System.Drawing.Point(1091, 355);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(0, 16);
            this.lblGia.TabIndex = 15;
            // 
            // FormConGiaSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 521);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTGKT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTGBD);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtLoaiSan);
            this.Controls.Add(this.dtGiaSan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConGiaSan";
            this.Text = "Quản lí giá sân";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormConGiaSan_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtGiaSan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGiaSan;
        private System.Windows.Forms.TextBox txtLoaiSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTGBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTGKT;
        private System.Windows.Forms.Label lblGia;
    }
}