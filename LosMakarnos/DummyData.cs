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
        public List<Urun> Urunler { get; set; }


        public DummyData()
        {
            Kategoriler = new List<Kategori>();
            Kategori k1 = new Kategori();
            k1.KategoriAd = "Makarna";
            Kategori k2 = new Kategori();
            Kategori k3 = new Kategori();
            Kategori k4 = new Kategori();
            k2.KategoriAd = "İçecek"; k3.KategoriAd = "Ekstra"; k4.KategoriAd = "Ekstra2";
            k1.KategoriID = 1;
            k2.KategoriID = 2;
            k3.KategoriID = 3;
            k4.KategoriID = 4;

            Kategoriler.Add(k1);
            Kategoriler.Add(k2);

            Kategoriler.Add(k3);
            Kategoriler.Add(k4);

            Urunler = new List<Urun>();

            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();
            Urun urun4 = new Urun();
            Urun urun5 = new Urun();
            Urun urun6 = new Urun();
            Urun urun7 = new Urun();
            Urun urun8 = new Urun();
            Urun urun9 = new Urun();
            Urun urun10 = new Urun();
            Urun urun11 = new Urun();
            Urun urun12 = new Urun();
            Urun urun13 = new Urun();
            Urun urun14 = new Urun();
            Urun urun15 = new Urun();
            Urun urun16 = new Urun();
            Urun urun17 = new Urun();
            Urun urun18 = new Urun();
            Urun urun19 = new Urun();
            Urun urun20 = new Urun();


            urun1.UrunAd = "Mak1";
            urun1.KategoriID = 1;

            urun2.UrunAd = "Mak1";
            urun2.KategoriID = 1;

            urun3.UrunAd = "Mak1";
            urun4.KategoriID = 1;

            urun4.UrunAd = "Mak1";
            urun4.KategoriID = 1;

            urun5.UrunAd = "Mak1";
            urun5.KategoriID = 1;

            urun6.UrunAd = "Mak1";
            urun6.KategoriID = 1;

            urun7.UrunAd = "Mak1";
            urun7.KategoriID = 1;

            urun8.UrunAd = "Mak1";
            urun8.KategoriID = 1;

            urun9.UrunAd = "Mak1";
            urun9.KategoriID = 1;

            urun10.UrunAd = "Mak1";
            urun10.KategoriID = 1;

            urun11.UrunAd = "Mak1";
            urun11.KategoriID = 1;

            urun12.UrunAd = "Mak1";
            urun12.KategoriID = 2;

            urun13.UrunAd = "Mak1";
            urun13.KategoriID = 2;

            urun14.UrunAd = "Mak1";
            urun14.KategoriID = 1;

            urun15.UrunAd = "Mak1";
            urun15.KategoriID = 1;

            urun16.UrunAd = "Mak1";
            urun16.KategoriID = 1;

            urun1.UrunAd = "Mak1";
            urun1.KategoriID = 1;

            urun17.UrunAd = "Mak1";
            urun17.KategoriID = 1;

            urun18.UrunAd = "Mak1";
            urun18.KategoriID = 1;

            urun19.UrunAd = "Mak1";
            urun19.KategoriID = 1;

            urun20.UrunAd = "Mak1";
            urun20.KategoriID = 1;

            Urunler.Add(urun1);
            Urunler.Add(urun2);
            Urunler.Add(urun3);
            Urunler.Add(urun4);
            Urunler.Add(urun5);
            Urunler.Add(urun6);
            Urunler.Add(urun7);
            Urunler.Add(urun8);
            Urunler.Add(urun9);
            Urunler.Add(urun10);
            Urunler.Add(urun11);
            Urunler.Add(urun12);
            Urunler.Add(urun13);
            Urunler.Add(urun14);
            Urunler.Add(urun15);
            Urunler.Add(urun16);
            Urunler.Add(urun17);
            Urunler.Add(urun18);
            Urunler.Add(urun19);
            Urunler.Add(urun20);
           










        }
    }
}
