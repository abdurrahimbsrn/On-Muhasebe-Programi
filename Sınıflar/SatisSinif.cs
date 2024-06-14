using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcaMuhasebe.Sınıflar
{
    public class SatisSinif
    {
        public decimal SatisFiyati { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal KdvOrani { get; set; }

        public SatisSinif(decimal satisFiyati, decimal alisFiyati, decimal kdvOrani)
        {
            SatisFiyati = satisFiyati;
            AlisFiyati = alisFiyati;
            KdvOrani = kdvOrani;
        }
        public int SatisID { get; set; }
        public int FaturaID { get; set; }
        public string ParcaID { get; set; }
        public int SatilanAdet { get; set; }
        public decimal Hasilat
        {
            get
            {
                return SatisFiyati * SatilanAdet;
            }
        }
        public decimal Maliyet 
        {
            get
            {
                return AlisFiyati * SatilanAdet;
            }
        }
        public decimal KdvTutari
        {
            get
            {
                return SatilanAdet*SatisFiyati * KdvOrani / 100;

            }
        }
        public decimal Kar
        {
            get
            {
                return Hasilat - Maliyet - KdvTutari;
            }
        }

        
    }
}
