using Core.Model;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Model.Entity_Framework
{
    public class Giris:BaseEntity,IBaseDomain
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int? RolID { get; set; }
        public string Dogrulama { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
