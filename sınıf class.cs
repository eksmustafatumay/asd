using System;
using System.Collections.Generic;

namespace OgrenciOtomasyonu
{
    public class Sinif
    {
        public string SinifAdi { get; set; }
        public Dictionary<string, string> DersProgrami { get; set; }

        public Sinif(string sinifAdi, Dictionary<string, string> dersProgrami)
        {
            SinifAdi = sinifAdi;
            DersProgrami = dersProgrami;
        }

        public void DersPrograminiYazdir()
        {
            Console.WriteLine($"Sınıf: {SinifAdi}");
            Console.WriteLine("Ders Programı:");
            foreach (var ders in DersProgrami)
            {
                Console.WriteLine($"{ders.Key} - {ders.Value}");
            }
        }
    }
}
