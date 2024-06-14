using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcaMuhasebe.Sınıflar
{
    public class Arac
    {
        public int AracID { get; set; }
        public string AracMarka { get; set; }
        public string AracModel { get; set; }
        public int AracUretimYili { get; set; }
        public string AracKasa { get; set; }
        public string AracMotor { get; set; }
        public DateTime EklemeTarihi { get; set; }
    }
}
