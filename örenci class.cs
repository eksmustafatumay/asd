using System;
using System.Collections.Generic;

namespace OgrenciOtomasyonu
{
    public class Ogrenci
    {
        public string AdSoyad { get; set; }
        public List<string> AldigiDersler { get; set; }

        public Ogrenci(string adSoyad, List<string> aldigiDersler)
        {
            AdSoyad = adSoyad;
            AldigiDersler = aldigiDersler;
        }

        public void OgrenciBilgileriniYazdir()
        {
            Console.WriteLine($"Öğrenci: {AdSoyad}");
            Console.WriteLine("Aldığı Dersler:");
            foreach (var ders in AldigiDersler)
            {
                Console.WriteLine($"- {ders}");
            }
        }
    }
}
