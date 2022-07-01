namespace Do_An_PLB03.GUI
{
    partial class FormThemSan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbloai = new System.Windows.Forms.ComboBox();
            this.cbten = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbnThemSanMoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(50, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Sân";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(50, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sân";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbloai
            // 
            this.cbloai.FormattingEnabled = true;
            this.cbloai.Location = new System.Drawing.Point(192, 49);
            this.cbloai.Name = "cbloai";
            this.cbloai.Size = new System.Drawing.Size(133, 28);
            this.cbloai.TabIndex = 3;
            this.cbloai.SelectedIndexChanged += new System.EventHandler(this.cbloai_SelectedIndexChanged);
            // 
            // cbten
            // 
            this.cbten.FormattingEnabled = true;
            this.cbten.Location = new System.Drawing.Point(192, 121);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(133, 28);
            this.cbten.TabIndex = 3;
            this.cbten.SelectedIndexChanged += new System.EventHandler(this.cbten_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbloai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(69, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sân";
            // 
            // tbnThemSanMoi
            // 
            this.tbnThemSanMoi.BackColor = System.Drawing.Color.LightCyan;
            this.tbnThemSanMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnThemSanMoi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbnThemSanMoi.Location = new System.Drawing.Point(69, 242);
            this.tbnThemSanMoi.Name = "tbnThemSanMoi";
            this.tbnThemSanMoi.Size = new System.Drawing.Size(151, 50);
            this.tbnThemSanMoi.TabIndex = 5;
            this.tbnThemSanMoi.Text = "Thêm Sân Mới";
            this.tbnThemSanMoi.UseVisualStyleBackColor = false;
            this.tbnThemSanMoi.Click += new System.EventHandler(this.tbnThemSanMoi_Click);
            // 
            // FormThemSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 314);
            this.Controls.Add(this.tbnThemSanMoi);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThemSan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormThemSan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbloai;
        private System.Windows.Forms.ComboBox cbten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tbnThemSanMoi;
    }
}