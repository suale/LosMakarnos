using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMakarnos
{
    public class Masa
    {
        public int MasaNo { get; set; }
        public string MasaAd { get; set; }
        public List<Urun> Urunler { get; set; }
        public bool MasaDurum { get; set; } 
    }
}
