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
    public partial class DuzenleForm : Form
    {
        public event EventHandler DegisiklikYapildi;
        private readonly PizzaKulesiContext db;
        public DuzenleForm(PizzaKulesiContext db)
        {
            this.db = db;
            InitializeComponent();
            PizzalariListele();
            MalzemeleriListele();
        }

        private void MalzemeleriListele()
        {
            lstEkstraMalzemeler.DataSource = db.EkstraMalzemeler.ToList();
        }

        private void PizzalariListele()
        {
            lstPizzalar.DataSource = db.Pizzalar.ToList();
        }

        private void btnPizzaEkle_Click(object sender, EventArgs e)
        {
            if (btnPizzaEkle.Text == "KAYDET")
            {
                var secilenPizza = (Pizza)lstPizzalar.SelectedItem;
                secilenPizza.Cesit = txtCesit.Text;
                db.SaveChanges();
                PizzalariListele();
                PizzaFormuResestle();
                DegisiklikYapildiginda(EventArgs.Empty);
                return;
            }
            if (txtCesit.Text == "") 
            {
                MessageBox.Show("Pizza adı giriniz");
                return;
            }
            var cesitAdi = txtCesit.Text.Trim();
            db.Pizzalar.Add(new Pizza() { Cesit = cesitAdi });
            db.SaveChanges();
            txtCesit.Clear();
            PizzalariListele();
            DegisiklikYapildiginda(EventArgs.Empty);
        }
        protected virtual void DegisiklikYapildiginda(EventArgs args)
        {
            DegisiklikYapildi?.Invoke(this, args);
        }
        private void btnEksMalEkle_Click(object sender, EventArgs e)
        {
            if (btnEksMalEkle.Text == "KAYDET")
            {
                var secilenMalzeme = (EkstraMalzeme)lstEkstraMalzemeler.SelectedItem;
                secilenMalzeme.MalzemeAd = txtEksMalAdi.Text;
                db.SaveChanges();
                MalzemeleriListele();
                EkstraMalzemeFormuResetle();
                DegisiklikYapildiginda(EventArgs.Empty);
                return;
            }
            if (txtEksMalAdi.Text == "")
            {
                MessageBox.Show("Ekstra malzeme adı giriniz");
                return;
            }
            var eksMalAdi = txtEksMalAdi.Text.Trim();
            db.EkstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = eksMalAdi });
            db.SaveChanges();
            txtEksMalAdi.Clear();
            MalzemeleriListele();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void btnPizzaSil_Click(object sender, EventArgs e)
        {
            if (lstPizzalar.SelectedIndex < 0) return;

            var secilenPizza = (Pizza)lstPizzalar.SelectedItem;
            db.Pizzalar.Remove(secilenPizza);
            db.SaveChanges();
            PizzalariListele();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void btnEksMalSil_Click(object sender, EventArgs e)
        {
            if (lstEkstraMalzemeler.SelectedIndex < 0) return;

            var secilenMalzeme = (EkstraMalzeme)lstEkstraMalzemeler.SelectedItem;
            db.EkstraMalzemeler.Remove(secilenMalzeme);
            db.SaveChanges();
            MalzemeleriListele();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void btnPizzaDuzenle_Click(object sender, EventArgs e)
        {
            if (lstPizzalar.SelectedIndex < 0) return;
            //Düzenle Moduna Geç
            btnPizzaEkle.Text = "KAYDET";
            btnPizzaDuzenle.Enabled = btnPizzaSil.Enabled = false;
            lstPizzalar.Enabled = false;
            var secilenPizza = (Pizza)lstPizzalar.SelectedItem;
            txtCesit.Text = secilenPizza.Cesit;
        }

        private void btnIPizzaIptal_Click(object sender, EventArgs e)
        {
            PizzaFormuResestle();
        }

        private void PizzaFormuResestle()
        {
            PizzalariListele();
            txtCesit.Clear();
            lstPizzalar.Enabled = true;
            btnPizzaEkle.Text = "EKLE";
            btnPizzaDuzenle.Enabled = btnPizzaSil.Enabled = true;
        }

        private void btnEksMalIptal_Click(object sender, EventArgs e)
        {
            EkstraMalzemeFormuResetle();
        }

        private void EkstraMalzemeFormuResetle()
        {
            MalzemeleriListele();
            txtEksMalAdi.Clear();
            lstEkstraMalzemeler.Enabled = true;
            btnEksMalEkle.Text = "EKLE";
            btnEksMalDuzenle.Enabled = btnEksMalSil.Enabled = true;
        }

        private void btnEksMalDuzenle_Click(object sender, EventArgs e)
        {
            if (lstEkstraMalzemeler.SelectedIndex < 0) return;
            //Düzenle Moduna Geç
            btnEksMalEkle.Text = "KAYDET";
            btnEksMalDuzenle.Enabled = btnEksMalSil.Enabled = false;
            lstEkstraMalzemeler.Enabled = false;
            var secilenMalzeme = (EkstraMalzeme)lstEkstraMalzemeler.SelectedItem;
            txtEksMalAdi.Text = secilenMalzeme.MalzemeAd;
        }
    }
}
