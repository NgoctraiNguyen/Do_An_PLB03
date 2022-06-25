using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_PLB03.DTO;
using FontAwesome.Sharp;

namespace Do_An_PLB03.GUI
{
    public partial class FormChinh : Form
    {
        private IconButton btnClick;
        private Panel borderbtn;
        private bool admin;
        private Form chillform;

        public DTONguoiDung _user;
        public FormChinh(DTONguoiDung user)
        {
            InitializeComponent();
            borderbtn = new Panel();
            borderbtn.Size = new Size(7, 50);
            pnlMenu.Controls.Add(borderbtn);
            _user = user;
            if (user.Quyen == 1) admin = true;
            lblTenNguoiDung.Text = _user.HoTen;
            displayviewadmin();
        }

        private void clickbutton(object sender)
        {
            disablebutton();
            if(sender != null)
            {
                btnClick = (IconButton)sender;
                btnClick.ForeColor = System.Drawing.SystemColors.MenuHighlight;
                btnClick.IconColor = System.Drawing.SystemColors.MenuHighlight;
                btnClick.BackColor = Color.PaleTurquoise;
                lblChucnang.Text = btnClick.Text;

                borderbtn.Location = new Point(0,btnClick.Location.Y);
                borderbtn.Visible = true;
                borderbtn.BringToFront();

            }
        }

        private void disablebutton()
        {
            if(btnClick != null)
            {
                btnClick.ForeColor = SystemColors.AppWorkspace;
                btnClick.IconColor = System.Drawing.SystemColors.AppWorkspace;
                btnClick.BackColor = Color.Snow;
            }
        }

        private void displayviewadmin()
        {
            btnQuanLyNhanVien.Visible = admin;
            btnQuanLyDichVu.Visible = admin;
            btnQuanLyKhachHang.Visible = admin;
            btnHoaDon.Visible = admin;
            btnThongKe.Visible = admin;
            iconButton1.Visible = admin;
            timer1.Enabled = true;
        }

        public void Openchillform(Form formsender)
        {
            if(chillform != null)
            {
                chillform.Close();
            }
            chillform = formsender;
            chillform.TopLevel = false;
            chillform.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(chillform);
            pnlBody.Tag = chillform;
            chillform.BringToFront();
            chillform.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormNhanSan(this._user));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormDatSan(this));
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormSudungdichvuvaThanhtoan(_user));
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormSudungdichvuvaThanhtoan(_user));
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormConGiaSan());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormConNhanVien());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormConDichVu());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormHienThiKhachHang());
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Openchillform(new FormConTaiKhoan(_user,this));
            lblChucnang.Text = "Tài khoản cá nhân";
            disablebutton();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNgayGio.Text = DateTime.Now.ToString();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (chillform != null)
            {
                chillform.Close();
            }
            picturewelcome.Visible = true;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormQuanLiHoaDon());
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new Formthongke());
        }
    }
}
