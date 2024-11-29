using System;
using System.Collections.Generic;
using OgrenciOtomasyonu; // Diğer dosyalardaki sınıfları kullanabilmek için bu namespace eklenir

class Program
{
    static void Main(string[] args)
    {
        // Hoca örneği
        List<string> hocaDersleri = new List<string> { "Matematik", "Fizik" };
        Hoca hoca1 = new Hoca("Ahmet Yılmaz", hocaDersleri);

        // Öğrenci örneği
        List<string> ogrenciDersleri = new List<string> { "Matematik", "Kimya" };
        Ogrenci ogrenci1 = new Ogrenci("Mehmet Demir", ogrenciDersleri);

        // Sınıf örneği (Ders ve hoca eşleşmesi)
        Dictionary<string, string> dersProgrami = new Dictionary<string, string>
        {
            { "Pazartesi", "Matematik - Ahmet Yılmaz" },
            { "Salı", "Fizik - Ahmet Yılmaz" },
            { "Çarşamba", "Kimya - Ayşe Kaya" },
            { "Perşembe", "Biyoloji - Fatma Kılıç" },
            { "Cuma", "Tarih - Ali Korkmaz" }
        };
        Sinif sinif1 = new Sinif("12A", dersProgrami);

        // Kullanıcıya seçim yaptır
        Console.WriteLine("Seçim yapın: \n1- Hoca Bilgileri \n2- Öğrenci Bilgileri \n3- Sınıf Ders Programı");
        int secim = Convert.ToInt32(Console.ReadLine());

        switch (secim)
        {
            case 1:
                hoca1.HocaBilgileriniYazdir();
                break;
            case 2:
                ogrenci1.OgrenciBilgileriniYazdir();
                break;
            case 3:
                sinif1.DersPrograminiYazdir();
                break;
            default:
                Console.WriteLine("Geçersiz seçim!");
                break;
        }
    }
}
