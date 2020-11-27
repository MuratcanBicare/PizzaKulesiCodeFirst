using PizzaKulesi2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaKulesi2
{
    public partial class Form1 : Form
    {
        PizzaKulesiContext db = new PizzaKulesiContext();
        public Form1()
        {
            InitializeComponent();
            dgvSiparis.AutoGenerateColumns = false;
            SiparisleriListele();
            PizzalariListele();
            MalzemeleriListele();
            MusterileriListele();
        }

        private void MusterileriListele()
        {

            var filtreMusteri = db.Musteriler.OrderBy(x => x.AdSoyad).ToList();

            filtreMusteri.Insert(0, new Musteri { AdSoyad = "-- Seç --" });
            cboMusteri.DataSource = filtreMusteri;
        }

        private void MalzemeleriListele()
        {
            clbMalzeme.DataSource = db.EkstraMalzemeler.OrderBy(x => x.MalzemeAd).ToList();

        }

        private void PizzalariListele()
        {

            var filtrePizza = db.Pizzalar.OrderBy(x => x.Cesit).ToList();

            filtrePizza.Insert(0, new Pizza { Cesit = "-- Seç --" });
            cboPizzaCesidi.DataSource = filtrePizza;
        }

        private void SiparisleriListele()
        {

            IQueryable<Siparis> siparisler = db.Siparisler;
            if (chkTeslimEdileleriGizle.Checked == true)
            {
                siparisler = siparisler.Where(x => x.TeslimDurumu == false);
            }

            dgvSiparis.DataSource = siparisler.ToList();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (txtAdres.Text == "" || txtMusteriAdSoyad.Text == "")
            {
                MessageBox.Show("Bilgileri gir.");
                return;
            }
            var adSoyad = txtMusteriAdSoyad.Text;
            var adres = txtAdres.Text;
            if (btnMusteriEkle.Text == "Kaydet")
            {
                var secilenMusteri = (Musteri)cboMusteri.SelectedItem;
                secilenMusteri.AdSoyad = adSoyad;
                secilenMusteri.Adres = adres;
                MusteriFormuResetle();
                return;
            }

            db.Musteriler.Add(new Musteri
            {
                AdSoyad = adSoyad,
                Adres = adres
            });
            db.SaveChanges();
            txtAdres.Clear();
            txtMusteriAdSoyad.Clear();
            MusterileriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cboMusteri.SelectedIndex == 0 || cboPizzaCesidi.SelectedIndex == 0)
            {
                MessageBox.Show("Pizza ve müşteri seç");
                return;
            }

            if (btnEkle.Text == "Kaydet")
            {
                int seciliSiparisId = Convert.ToInt32(dgvSiparis.SelectedRows[0].Cells[0].Value);
                Siparis seciliSiparis = db.Siparisler.FirstOrDefault(x => x.Id == seciliSiparisId);
                seciliSiparis.Musteri = (Musteri)cboMusteri.SelectedItem;
                seciliSiparis.Pizza = (Pizza)cboPizzaCesidi.SelectedItem;
                seciliSiparis.EkstraMalzemeler = clbMalzeme.CheckedItems.OfType<EkstraMalzeme>().ToList();
                seciliSiparis.TeslimDurumu = chkTeslim.Checked;
                db.SaveChanges();
                SiparisleriListele();
                FormuResetle();
                return;
            }

            List<EkstraMalzeme> seciliMalzemeler = clbMalzeme.CheckedItems.OfType<EkstraMalzeme>().ToList();

            Siparis siparis = new Siparis()
            {
                Musteri = (Musteri)cboMusteri.SelectedItem,
                Pizza = (Pizza)cboPizzaCesidi.SelectedItem,
                EkstraMalzemeler = seciliMalzemeler,
                TeslimDurumu = chkTeslim.Checked == true ? true : false
            };
            db.Siparisler.Add(siparis);
            FormuResetle();
            db.SaveChanges();
            SiparisleriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvSiparis.SelectedRows.Count <= 0)
            {
                return;
            }
            int seciliSiparisId = Convert.ToInt32(dgvSiparis.SelectedRows[0].Cells[0].Value);
            Siparis seciliSiparis = db.Siparisler.FirstOrDefault(x => x.Id == seciliSiparisId);
            db.Siparisler.Remove(seciliSiparis);
            db.SaveChanges();
            SiparisleriListele();
        }
        private void MusteriFormuResetle()
        {
            btnMusteriSil.Enabled = false;
            db.SaveChanges();
            btnMusteriEkle.Text = "Ekle";
            txtAdres.Clear();
            txtMusteriAdSoyad.Clear();
            SiparisleriListele();
            MusterileriListele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvSiparis.SelectedRows.Count <= 0) return;


            for (int i = 0; i < clbMalzeme.Items.Count; i++)
            {
                clbMalzeme.SetItemChecked(i, false);
            }
            int seciliSiparisId = Convert.ToInt32(dgvSiparis.SelectedRows[0].Cells[0].Value);
            Siparis seciliSiparis = db.Siparisler.FirstOrDefault(x => x.Id == seciliSiparisId);
            cboMusteri.SelectedItem = seciliSiparis.Musteri;
            cboPizzaCesidi.SelectedItem = seciliSiparis.Pizza;
            for (int i = 0; i < clbMalzeme.Items.Count; i++)
            {
                var ekstraMalzeme = (EkstraMalzeme)clbMalzeme.Items[i];
                if (seciliSiparis.EkstraMalzemeler.Any(x => x.Id == ekstraMalzeme.Id))
                {
                    clbMalzeme.SetItemChecked(i, true);
                }
            }
            chkTeslim.Checked = seciliSiparis.TeslimDurumu;
            //Düzenlenin Moduna Geç
            btnEkle.Text = "Kaydet";
            btnIptal.Visible = true;
            dgvSiparis.Enabled = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }

        private void FormuResetle()
        {
            for (int i = 0; i < clbMalzeme.Items.Count; i++)
            {
                clbMalzeme.SetItemChecked(i, false);
            }
            btnEkle.Text = "Sipariş Oluştur";
            btnIptal.Visible = false;
            dgvSiparis.Enabled = true;
            chkTeslim.Checked = false;
            MusterileriListele();
            PizzalariListele();
        }

        private void chkTeslimEdileleriGizle_CheckedChanged(object sender, EventArgs e)
        {
            SiparisleriListele();
        }

        private void btnPizzaCesidi_Click(object sender, EventArgs e)
        {
            DuzenleForm frmPizzaCesidiDuzenle = new DuzenleForm(db);
            frmPizzaCesidiDuzenle.DegisiklikYapildi += FrmPizzaCesidiDuzenle_DegisiklikYapildi;
            frmPizzaCesidiDuzenle.ShowDialog();
        }

        private void btnEkstraMalzeme_Click(object sender, EventArgs e)
        {
            DuzenleForm frmPizzaCesidiDuzenle = new DuzenleForm(db);
            frmPizzaCesidiDuzenle.DegisiklikYapildi += FrmPizzaCesidiDuzenle_DegisiklikYapildi;
            frmPizzaCesidiDuzenle.ShowDialog();
        }

        private void FrmPizzaCesidiDuzenle_DegisiklikYapildi(object sender, EventArgs e)
        {
            PizzalariListele();
            MalzemeleriListele();
            SiparisleriListele();
        }

        private void btnMusteriSil_Click_1(object sender, EventArgs e)
        {
            var secilenMusteri = (Musteri)cboMusteri.SelectedItem;
            db.Musteriler.Remove(secilenMusteri);
            MusteriFormuResetle();
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            if (cboMusteri.SelectedIndex <= 0)
                return;
            btnMusteriEkle.Text = "Kaydet";
            btnMusteriSil.Enabled = true;
            var secilenMusteri = (Musteri)cboMusteri.SelectedItem;
            txtAdres.Text = secilenMusteri.Adres;
            txtMusteriAdSoyad.Text = secilenMusteri.AdSoyad;
        }
    }
}
