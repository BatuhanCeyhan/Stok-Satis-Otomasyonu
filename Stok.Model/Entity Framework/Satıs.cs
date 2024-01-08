using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Model.Entity_Framework
{
    public class Satıs:BaseEntity,IBaseDomain
    {
        public int ID { get; set; }
        public DateTime? Tarih  { get; set; }
        public string FaturaKodu { get; set; }
        public string SatısYerleri { get; set; }
        public decimal ToplamSatıs { get; set; }
        public string SatisUrunAdi { get; set; }
        public decimal SatisUrunFiyati { get; set; }
        public int SatisUrunAdedi { get; set; }



    }
}
