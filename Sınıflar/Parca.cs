using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcaMuhasebe.Sınıflar
{
    public class Parca
    {
        public int ParcaID { get; set; }
        public int AracID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string ParcaAd { get; set; }
        public string ParcaMarka { get; set; }
        public int Stok { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public decimal KdvOrani { get; set; }
        public DateTime EklemeTarihi { get; set; }

        public decimal KdvTutari
        {
            get
            {
                return SatisFiyati * KdvOrani / 100;
            }
        }
    }
}
