using System;
using System.Collections.Generic;

class Araba
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    private int kapıSayisi;

    public int KapıSayısı
    {
        get { return kapıSayisi; }
        set
        {
            if (value != 2 && value != 4)
            {
                Console.WriteLine("Kapı sayısı yalnızca 2 veya 4 olabilir. Lütfen geçerli bir değer girin.");
                throw new ArgumentException("Geçersiz kapı sayısı");
            }
            kapıSayisi = value;
        }
    }

    public Araba()
    {
        UretimTarihi = DateTime.Now;
    }
}

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>();
        string devam; // devam değişkeni burada tanımlandı

        do
        {
            Console.Write("Araba üretmek ister misiniz? (E/H): ");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap != "E" && cevap != "H")
            {
                Console.WriteLine("Geçersiz cevap! Lütfen 'E' veya 'H' girin.");
                continue;
            }

            if (cevap == "H")
            {
                break;
            }

            // Yeni Araba nesnesi oluştur
            Araba yeniAraba = new Araba();

            // Kullanıcıdan araba bilgilerini al
            Console.Write("Seri Numarası: ");
            yeniAraba.SeriNumarasi = Console.ReadLine();

            Console.Write("Marka: ");
            yeniAraba.Marka = Console.ReadLine();

            Console.Write("Model: ");
            yeniAraba.Model = Console.ReadLine();

            Console.Write("Renk: ");
            yeniAraba.Renk = Console.ReadLine();

            // Kapı sayısını alırken hata kontrolü
            bool validKapıSayisi = false;
            while (!validKapıSayisi)
            {
                try
                {
                    Console.Write("Kapı Sayısı (2 veya 4): ");
                    yeniAraba.KapıSayısı = Convert.ToInt32(Console.ReadLine());
                    validKapıSayisi = true; // Geçerli bir kapı sayısı alındı
                }
                catch (Exception)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
                }
            }

            // Araba nesnesini listeye ekle
            arabalar.Add(yeniAraba);

            // Kullanıcıya başka araba oluşturmak isteyip istemediğini sor
            Console.Write("Başka bir araba üretmek ister misiniz? (E/H): ");
            devam = Console.ReadLine().ToUpper();

        } while (devam == "E");

        // Araba listesini yazdır
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }
    }
}
