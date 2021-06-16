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
    public partial class InputCatatanForm : Form
    {
        Catatan catatan;
        public enum Mode { Insert, Edit }
        Mode mode;
        public InputCatatanForm()
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnAksi.Text = "Catat";
        }

        public InputCatatanForm(string nama, decimal income, decimal outcome)
        {
            InitializeComponent();
            mode = Mode.Edit;
            catatan = new Catatan
            {
                Nama = nama,
                Penghasilan = income,
                Pengeluaran = outcome
            };
            tbNama.Text = nama;
            tbPenghasilan.Text = income.ToString();
            tbPengeluaran.Text = outcome.ToString();
            btnAksi.Text = "Ubah";
        }

        private void TambahData()
        {
            if (tbNama.Text != "" && tbPenghasilan.Text != "" && tbPengeluaran.Text != "")
            {
                using (var db = new CatatanModel())
                {
                    catatan = new Catatan
                    {
                        Nama = tbNama.Text,
                        Penghasilan = decimal.Parse(tbPenghasilan.Text),
                        Pengeluaran = decimal.Parse(tbPengeluaran.Text),
                        DanaDarurat = hitungDanaDarurat(),
                        DanaInvestasi = hitungDanaInv(),
                    };
                    db.Catatans.Add(catatan);
                    db.SaveChanges();
                    MessageBox.Show("Catatan Berhasil Dibuat");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Nama, Penghasilan, dan Pengeluaran harus diisi semua.");
            }
        }

        private void EditData()
        {
            using (var db = new CatatanModel())
            {
                var result = db.Catatans.SingleOrDefault(k => k.Nama == catatan.Nama);
                if (result != null)
                {
                    result.Nama = tbNama.Text;
                    result.Penghasilan = decimal.Parse(tbPenghasilan.Text);
                    result.Pengeluaran = decimal.Parse(tbPengeluaran.Text);
                    result.DanaDarurat = hitungDanaDarurat();
                    result.DanaInvestasi = hitungDanaInv();
                    db.SaveChanges();
                    MessageBox.Show("Catatan Berhasil Diubah");
                    Close();
                }
                else
                {
                    MessageBox.Show("Nama dan Penghasilan harus diisi");
                }
            }
        }

        private void btnAksi_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                TambahData();
            else if (mode == Mode.Edit)
                EditData();
        }

        protected decimal danaDarurat;
        protected decimal cicilDanrat;
        public decimal jangkaDanrat;
        protected decimal investasi;

        public decimal hitungDanaDarurat()
        {
            if (rbA.Checked)
            {
                danaDarurat = Convert.ToDecimal(6) * decimal.Parse(tbPengeluaran.Text);
                cicilDanrat = (decimal.Parse(tbPenghasilan.Text)) / 5;
            }
            else if (rbB.Checked)
            {
                danaDarurat = Convert.ToDecimal(9) * decimal.Parse(tbPengeluaran.Text);
                cicilDanrat = (decimal.Parse(tbPenghasilan.Text)) / 5;
            }
            else if (rbC.Checked)
            {
                danaDarurat = Convert.ToDecimal(12) * decimal.Parse(tbPengeluaran.Text);
                cicilDanrat = (decimal.Parse(tbPenghasilan.Text)) / 5;
            }

            return cicilDanrat;
        }

        public decimal hitungDanaInv()
        {
            investasi = ((decimal.Parse(tbPenghasilan.Text) - decimal.Parse(tbPengeluaran.Text)
                        - cicilDanrat)) / 2;
            return investasi;
        }
    }
}
