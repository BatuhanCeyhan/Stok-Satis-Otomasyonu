using Microsoft.EntityFrameworkCore;
using Stok.Model.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.DataAccsess.Concrete.Entity_Framework.Context
{
    public class Stok_OtomasyonuDbContext:DbContext
    {
        public DbSet<Giris> Giris { get; set; }
        public DbSet<Satıs> Satıs { get; set; }
        public DbSet<Urun> Urun { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BATU-DESKTOP;database=Stok_Otomasyonu;trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
