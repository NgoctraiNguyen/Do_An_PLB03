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
using Do_An_PLB03.DTO;

namespace Do_An_PLB03.GUI
{
    public partial class FormDatSan : Form
    {
        BUSTrangThaiSan trangthaisan= new BUSTrangThaiSan();
        DTOSan san= new DTOSan();
        public static List<string> loaisan=new List<string>();
        public static List<string> tensan= new List<string>();
        string tenloaisan;

        public FormDatSan()
        {
            InitializeComponent();
        }

      

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        private void FormDatSan_Load(object sender, EventArgs e)
        {
            cbbLoaiSan.Items.Clear();
            loaisan = BUSSan.san(san);

            cbbLoaiSan.DataSource = loaisan;



        }

        private void cbbLoaiSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiSan.SelectedIndex != null)
            {

                txtMaLoaiSan.Text = cbbLoaiSan.Text;
                tenloaisan = cbbLoaiSan.Text;

                tensan = BUSSan.tensandat(san, tenloaisan);
                cbbTenSan.Items.Clear();
                cbbTenSan.DataSource = tensan;


            }

        }



        private void cbbLoaiSan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

       

        private void txtSoGio_Leave(object sender, EventArgs e)
        {

        }

        private void txtSoGio_MouseLeave(object sender, EventArgs e)
        {
            if (txtSoGio.Text == "")
            {
                txtSoGio.Text = "0";
                
            }
            else
            {
                int hthem = Convert.ToInt32(txtSoGio.Text);
                dtpNgayGioTra.Value = dtpNgayGioNhan.Value.AddHours(hthem);
            }
                

           
        }

        private void txtSoGio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoGio_MouseClick(object sender, MouseEventArgs e)
        {
            txtSoGio.Text = "";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           //MessageBox.Show(tenloaisan);

            


        }

        private void cbbTenSan_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }
    }
}
