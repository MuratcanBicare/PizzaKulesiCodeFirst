using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesi2.Models
{
    public class PizzaKulesiContext : DbContext
    {
        public PizzaKulesiContext() : base("name=MyConnectionString")
        {
            Database.SetInitializer(new MyInitializationStrategy());
        }

        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Pizza> Pizzalar { get; set; }

        public DbSet<Siparis> Siparisler { get; set; }

        public DbSet<EkstraMalzeme> EkstraMalzemeler { get; set; }
    }
}
