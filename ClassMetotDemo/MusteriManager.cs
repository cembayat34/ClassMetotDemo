using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> Musteriler = new List<Musteri>();
        public void MusteriEkle(Musteri musteri)
        {

            Console.WriteLine("Musteri Ekleme Isleminiz Basariyla Gerceklestirildi");
            Console.WriteLine("Eklenen Musteri : " + musteri.AdiSoyadi);

            Musteriler.Add(musteri);
        }

        public void MusteriLislete()
        {
            int sayac = 0;
            Console.WriteLine("Mevcut Musteriler Listesi ");
            foreach (Musteri musteri in Musteriler)
            {
                sayac++;
                Console.WriteLine(sayac + "." + musteri.AdiSoyadi);
            }
        }
    }
}
