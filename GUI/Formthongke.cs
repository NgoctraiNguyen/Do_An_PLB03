using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Do_An_PLB03.BUS;

namespace Do_An_PLB03.GUI
{
    public partial class Formthongke : Form
    {
        public Formthongke()
        {
            InitializeComponent();
        }

        private void Formthongke_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chrThang_Click(object sender, EventArgs e)
        {

        }

    

        private void cbyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sumThang = new DataTable();
            chrThang.Series["DoanhThuThang"].Points.Clear();
            chrThang.Series["columm"].Points.Clear();


            BUSThongke.thongkethang(int.Parse(cbyear.Text));
            sumThang = BUSThongke.sumthang;
            for (int i = 0; i < sumThang.Rows.Count; i++)
            {
                chrThang.Series["DoanhThuThang"].Points.AddXY(sumThang.Rows[i]["Thang"], sumThang.Rows[i]["TongTien"]);
                chrThang.Series["columm"].Points.AddXY(sumThang.Rows[i]["Thang"], sumThang.Rows[i]["TongTien"]);

            }
            sumThang.Rows.Clear();
        }

    
        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try { bieudotheosan(); }
            catch { }
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {

            try { bieudotheosan(); }
            catch { }

        }
        public static DataTable sumsan = new DataTable();
        private void bieudotheosan()
        {
            sumsan.Rows.Clear();
            chrSan.Series["San"].Points.Clear();
            BUSThongke.thongkesan(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
            sumsan = BUSThongke.sumsan;
            for (int i = 0; i < sumsan.Rows.Count; i++)
            {
                chrSan.Series["San"].Points.AddXY(sumsan.Rows[i][0], sumsan.Rows[i][1]);
            }


            try
            {
                //DataTable sum = new DataTable();
                //BUSThongke.thongkesan(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
                //sum = BUSThongke.sumsan;
                dataGridView1.DataSource = sumsan;
            }
            catch { }

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
        }
    }
}
