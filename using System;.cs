using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks
class Program
{
    // Öğrenci bilgilerini tutan metot
    static void Ogrenci(out string adSoyad, out int sinav1, out int sinav2)
    {
        Console.Write("Öğrencinin adını ve soyadını girin: ");
        adSoyad = Console.ReadLine();

        Console.Write("1. sınav notunu girin: ");
        sinav1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. sınav notunu girin: ");
        sinav2 = Convert.ToInt32(Console.ReadLine());
    }

    // Ortalamayı hesaplayan metot
    static double Hesapla(int sinav1, int sinav2)
    {
        return (sinav1 + sinav2) / 2.0;
    }

    static void Main(string[] args)
    {
        // Öğrenci bilgilerini al
        Ogrenci(out string adSoyad, out int sinav1, out int sinav2);

        // Ortalamayı hesapla
        double ortalama = Hesapla(sinav1, sinav2);

        // Sonucu yazdır
        Console.WriteLine($"{adSoyad} öğrencisinin ortalaması: {ortalama}");
    }
}
