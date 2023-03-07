using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMakarnos
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAd { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}
