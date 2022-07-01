using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_PLB03.BUS;


namespace Do_An_PLB03.GUI
{
    public partial class FormThemSan : Form
    {
        public delegate void them(string loai,string txt);
        public them t { get; set; }

        public delegate void load();
        public load d { get; set; }
        public FormThemSan()
        {
            InitializeComponent();
        }
        List<string> loaisan=new List<string>();
        List<string> san5= new List<string>();
        List<string> san7= new List<string>();

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormThemSan_Load(object sender, EventArgs e)
        {
            loaisan.Add("5");
            loaisan.Add("7");
            List<char> chucai5 = BUSSan.chucai("5");
            List<char> chucai7 = BUSSan.chucai("7");
            char[] az = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (Char)i).ToArray();
            foreach (var c in az)
            {
                if(!chucai5.Contains(c))
                {
                    san5.Add("5" + c);
                }
                if (!chucai7.Contains(c))
                {
                    san7.Add("7" + c);
                }
            }
            cbloai.DataSource = loaisan;
        }

        private void cbloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbloai.SelectedIndex != -1)
            {
                if (cbloai.Text == "5")
                {
                    cbten.DataSource = san5;
                }
                if (cbloai.Text == "7")
                {
                    cbten.DataSource= san7;
                }
            }

        }
        string loais;
        string tensan;
        private void tbnThemSanMoi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn có chắc muốn thêm sân mới này ", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                loais = cbloai.Text;
                tensan = cbten.Text;
                t(loais, tensan);
                d();
            }
        }

        private void cbten_SelectedIndexChanged(object sender, EventArgs e)
        {
            tensan=cbten.Text;
        }
    }
}
