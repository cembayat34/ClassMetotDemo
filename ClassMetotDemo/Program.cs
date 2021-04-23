using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.AdiSoyadi = "Cem Bayat";
            musteri1.MusteriTc = 10234785942;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.AdiSoyadi = "Sema Genc";
            musteri2.MusteriTc = 2014741596958;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriLislete();
        }
    }
}
