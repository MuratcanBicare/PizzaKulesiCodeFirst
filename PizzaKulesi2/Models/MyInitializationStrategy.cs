using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesi2.Models
{
    public class MyInitializationStrategy : CreateDatabaseIfNotExists<PizzaKulesiContext>
    {
        protected override void Seed(PizzaKulesiContext context)
        {
            Musteri musteri1 = new Musteri()
            {
                AdSoyad = "Muratcan Biçare",
                Adres = "Yenimahalle"
            };

            Musteri musteri2 = new Musteri()
            {
                AdSoyad = "Akın Ekinci",
                Adres = "Demetevler"
            };

            Pizza pizza1 = new Pizza() { Cesit = "Bol Malzemos" };
            Pizza pizza2 = new Pizza() { Cesit = "Karışık" };
            Pizza pizza3 = new Pizza() { Cesit = "Vejeteryan" };
            Pizza pizza4 = new Pizza() { Cesit = "Kavurmalı" };

            EkstraMalzeme ekstraMalzeme1 = new EkstraMalzeme() { MalzemeAd = "Mantar" };
            EkstraMalzeme ekstraMalzeme2 = new EkstraMalzeme() { MalzemeAd = "Mozarella" };
            EkstraMalzeme ekstraMalzeme3 = new EkstraMalzeme() { MalzemeAd = "Küp Sucuk" };
            EkstraMalzeme ekstraMalzeme4 = new EkstraMalzeme() { MalzemeAd = "Biber" };

            Siparis siparis1 = new Siparis()
            {
                MusteriId = 1,
                PizzaId = 2,
                TeslimDurumu = true,
                EkstraMalzemeler = new List<EkstraMalzeme> { ekstraMalzeme1, ekstraMalzeme3 },

            };

            Siparis siparis2 = new Siparis()
            {
                MusteriId = 2,
                PizzaId = 4,
                TeslimDurumu = false,
                EkstraMalzemeler = new List<EkstraMalzeme> { ekstraMalzeme2, ekstraMalzeme4 },

            };

            context.EkstraMalzemeler.AddRange(new EkstraMalzeme[] { ekstraMalzeme2, ekstraMalzeme1, ekstraMalzeme3, ekstraMalzeme4 });
            context.Pizzalar.AddRange(new Pizza[] { pizza1, pizza2, pizza3, pizza4 });
            context.Musteriler.AddRange(new Musteri[] { musteri1, musteri2 });
            context.Siparisler.AddRange(new Siparis[] { siparis1, siparis2 });

        }
    }
}
