using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMakarnos
{
    public class DummyData
    {
        public List<Kategori> Kategoriler { get; set; }
        public DummyData()
        {
            Kategoriler = new List<Kategori>();
            Kategori k1 = new Kategori();
            k1.KategoriAd = "sad";
            k1.KategoriID = 1;
            Kategori k2 = new Kategori();
            Kategori k3 = new Kategori();
            Kategori k4 = new Kategori();
            k2.KategoriAd = "asd"; k3.KategoriAd = "343"; k4.KategoriAd = "123";
            Kategoriler.Add(k1);
            Kategoriler.Add(k2);

            Kategoriler.Add(k3);
            Kategoriler.Add(k4);
        }
    }
}
