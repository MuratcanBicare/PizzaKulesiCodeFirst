using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesi2.Models
{
    [Table("Siparisler")]
    public class Siparis
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int PizzaId { get; set; }
        public bool TeslimDurumu { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Pizza Pizza { get; set; }
        public virtual ICollection<EkstraMalzeme> EkstraMalzemeler { get; set; }

        public string VirgulluMalzeme { get { return $"({EkstraMalzemeler.Select(x=> x.MalzemeAd).Virgulle()})"; } }

        public string AdresiYaz { get { return Musteri.Adres; } }
    }
}
