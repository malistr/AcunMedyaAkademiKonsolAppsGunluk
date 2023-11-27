using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunluk.ConsoleApp
{
    public class Metot
    {
        static void Txtoku(List<Gunluk> gunlukler)
        {
            Console.Clear();
            StreamReader reader = new StreamReader("C:\\günlük\\günlük.txt");
            string satir = reader.ReadLine();

            while (satir != null)
            {
                Console.WriteLine(satir);
                satir = reader.ReadLine();
            }
        }

        static void TxtKaydet(List<Gunluk> gunlukler)
        {


            using (StreamWriter writer = new StreamWriter("C:\\günlük\\günlük.txt", true))
            {
                foreach (var gunluk in gunlukler)
                {                    
                    writer.Write($"*Başlık: {gunluk.Baslik}*, *Tarih: {gunluk.Tarih}*, Metin: {gunluk.Metin}");

                }
            }

            Console.WriteLine("Günlük başarıyla dosyaya kaydedildi.");
            Thread.Sleep(1500);
            Console.Clear();

        }

 
            public static void KayitEkle(List<Gunluk> gunlukler)
        {
            Console.WriteLine("\nGünlük Başlığı:");
            string baslik = Console.ReadLine();
            Console.WriteLine("Girmek istediğiniz metni girin:");
            string metin = Console.ReadLine();
            Gunluk yeniGunluk = new Gunluk
            {
                Baslik = baslik,
                Metin = metin,
                Tarih = DateTime.Now
            };
            gunlukler.Add(yeniGunluk);

            Console.WriteLine($"Günlük başarıyla kaydedildi! \n");
            Thread.Sleep(2000);
            Console.Clear();


        }
        public static void KayitlariListele(List<Gunluk> gunlukler)
        {            
            Console.WriteLine("\nGünlükleri Listele:");
            foreach (var gunluk in gunlukler)
            {
                Console.WriteLine($"Metin:{gunluk.Metin}\n--------------------------\nTarih: {gunluk.Tarih}  ");
            }
            Console.WriteLine();
        }

        public static void KayıtlarıSil(List<Gunluk> gunlukler)
        {
            Console.WriteLine("Silmek istediğiniz kaydın başlığını giriniz:");
            string silmekIstenenGunlukBasligi = Console.ReadLine();
            Gunluk silmekIstenilenGunlukBasligi = gunlukler.Find(gunluk => gunluk.Baslik == silmekIstenenGunlukBasligi);

            if (silmekIstenenGunlukBasligi != null)
            {
                Console.WriteLine("Silmek İstediğinize Emin Misiniz? E||e/H||h");
                string cevap =Console.ReadLine();
                if (cevap == "E" || cevap == "e" )
                {
                    gunlukler.Remove(silmekIstenilenGunlukBasligi);
                    Console.WriteLine("Kayıt Başarıyla Silindi!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                     GunlukMenu(gunlukler);
                     Console.Clear();
                }
               
            }


        }
       
        public static void GunlukMenu(List<Gunluk> gunlukler)
        {
          
           
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin\n1.Kayıt ekle\n2.Kayıtları Listele\n3.Kayıtları Sil\n4.Txt Kaydet\n5.Txt OKu\n6.Çıkış\n");
            ConsoleKeyInfo secim = Console.ReadKey();
            Console.Clear();
            if (secim.Key == ConsoleKey.D1)
            {
                KayitEkle(gunlukler);
            }
            else if (secim.Key == ConsoleKey.D2)
            {
                KayitlariListele(gunlukler);
            }
            else if (secim.Key == ConsoleKey.D3)
            {
                KayıtlarıSil(gunlukler);
            }
            else if (secim.Key == ConsoleKey.D4)
            {
                TxtKaydet(gunlukler);
            }
            else if (secim.Key == ConsoleKey.D5)
            {
                Txtoku(gunlukler);
            }
            else if (secim.Key == ConsoleKey.D6)
            {
               
                Console.WriteLine("Çıkış Yapılıyor...");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
    }
}
