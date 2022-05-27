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
        public FormChinh(string tendangnhap)
        {
            InitializeComponent();
            borderbtn = new Panel();
            borderbtn.Size = new Size(7, 50);
            pnlMenu.Controls.Add(borderbtn);
<<<<<<< Updated upstream
            admin = true;
            lblTenNguoiDung.Text = tendangnhap;
=======
            _user = user;
            if (user.Quyen == 1)
            {
                admin = true;
                lblTenNguoiDung.Text = "Admin ";
            }
            else
            {
                lblTenNguoiDung.Text = "Nhân viên ";
            }
            lblTenNguoiDung.Text = lblTenNguoiDung.Text + _user.HoTen ;
>>>>>>> Stashed changes
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
            iconButton7.Visible = admin;
            iconButton8.Visible = admin;
            iconButton9.Visible = admin;
            timer1.Enabled = true;
        }

        private void Openchillform(Form formsender)
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
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormDatSan());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
            Openchillform(new FormSudungdichvuvaThanhtoan());
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
<<<<<<< Updated upstream
            DTONguoiDung a = new DTONguoiDung();
            Openchillform(new FormConTaiKhoan(a, lblTenNguoiDung.Text));
            lblChucnang.Text = "Tài khoản cá nhân";
=======
            Openchillform(new FormConTaiKhoan(_user,this));
            lblChucnang.Text = "Tài khoảng cá nhân";
>>>>>>> Stashed changes
            disablebutton();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNgayGio.Text = DateTime.Now.ToString();
        }
    }
}
