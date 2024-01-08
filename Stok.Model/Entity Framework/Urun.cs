using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Model.Entity_Framework
{
    public  class Urun:BaseEntity,IBaseDomain
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public int UrunAdedi { get; set; }
        public decimal UrunFiyati { get; set; }
        public string UrunNotu  { get; set; }
        public string Aktif { get; set; }
        public string Resim { get; set; }

    }
}
