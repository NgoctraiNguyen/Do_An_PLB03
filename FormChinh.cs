using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Do_An_PLB03
{
    public partial class FormChinh : Form
    {
        private IconButton btnClick;
        private Panel borderbtn;
        private bool admin;
        private Form chillform;
        public FormChinh()
        {
            InitializeComponent();
            borderbtn = new Panel();
            borderbtn.Size = new Size(7, 50);
            pnlMenu.Controls.Add(borderbtn);
            admin = true;
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
                lblChucnang.Text = btnClick.Name;

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
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            clickbutton(sender);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Openchillform(new FormConTaiKhoan());
            lblChucnang.Text = "user Profile";
        }
    }
}
