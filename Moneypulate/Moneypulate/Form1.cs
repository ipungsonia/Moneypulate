using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moneypulate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            using (var db = new CatatanModel())
            {
                var query = from catatan in db.Catatans where catatan.Nama == tbCariNama.Text select catatan;
                foreach (var item in query)
                {
                    lblNama.Text = item.Nama;
                    lblPenghasilan.Text = (item.Penghasilan).ToString();
                    lblPengeluaran.Text = (item.Pengeluaran).ToString();
                    lblDanaDarurat.Text = (item.DanaDarurat).ToString();
                    lblDanaInvestasi.Text = (item.DanaInvestasi).ToString();
                    btnBuat.Enabled = true;
                    btnUbah.Enabled = true;
                }
            }
        }

        private void btnBuat_Click_1(object sender, EventArgs e)
        {
            InputCatatanForm catatanForm = new InputCatatanForm();
            catatanForm.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            InputCatatanForm catatanForm = new InputCatatanForm(lblNama.Text, 
                                                                decimal.Parse(lblPenghasilan.Text), 
                                                                decimal.Parse(lblPengeluaran.Text));
            catatanForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
