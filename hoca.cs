using System;
using System.Collections.Generic;

namespace OgrenciOtomasyonu
{
    public class Hoca
    {
        public string AdSoyad { get; set; }
        public List<string> VerdigiDersler { get; set; }

        public Hoca(string adSoyad, List<string> verdigiDersler)
        {
            AdSoyad = adSoyad;
            VerdigiDersler = verdigiDersler;
        }

        public void HocaBilgileriniYazdir()
        {
            Console.WriteLine($"Hoca: {AdSoyad}");
            Console.WriteLine("Verdiği Dersler:");
            foreach (var ders in VerdigiDersler)
            {
                Console.WriteLine($"- {ders}");
            }
        }
    }
}
