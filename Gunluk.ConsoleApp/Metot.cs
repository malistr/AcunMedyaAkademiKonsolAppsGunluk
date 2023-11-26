using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunluk.ConsoleApp
{
    public class Metot
    {

        public static void KayitEkle(List<Gunluk> gunlukler)
        {
           
            Console.WriteLine("Günlük uygulamasına hoşgeldiniz. Girmek istediğiniz metni girin:");
            string metin = Console.ReadLine();
            Gunluk yeniGunluk = new Gunluk
            {
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

        public static void Menu(List<Gunluk> gunlukler)
        {
           
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin\n1.Kayıt ekle\n2.Kayıtları Listele\n3.Kayıtları Sil\n4.Tüm kayıtları Sil\n5. Çıkış");
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
            else if (secim.Key == ConsoleKey.D5)
            {
                Console.WriteLine("Çıkış Yapılıyor...");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
    }
}
