using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunluk.ConsoleApp
{
    public class Kullanici
    {
        public string KullaniciAdi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public string SifreHash { get; set; } // Şifrelerin güvenli bir şekilde saklanması için hash kullanılmalıdır.

      
        public static void TxtKaydet(List<Kullanici> kullanicilar)
        {


            using (StreamWriter writer = new StreamWriter("C:\\kullanicilar\\kullanicilar.txt", true))
            {
                foreach (var kullanici in kullanicilar)
                {
                    writer.Write($"*AdSoyad: {kullanici.KullaniciAdi}*, *Tarih: {kullanici.OlusturulmaTarihi}*, Sifre: {kullanici.SifreHash}");

                }
            }

            Console.WriteLine("Günlük başarıyla dosyaya kaydedildi.");
            Thread.Sleep(1500);
            Console.Clear();

        }



        public static void KullaniciMenu(List<Kullanici> kullanicilar, List<Gunluk> gunlukler)
        {
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin\n1.Kayıt Ol\n2.Giriş Yap\n3.Çıkış\n");
            ConsoleKeyInfo secim = Console.ReadKey();
            Console.Clear();

            if (secim.Key == ConsoleKey.D1)
            {
                KayitOl(kullanicilar, gunlukler);
                TxtKaydet(kullanicilar);
               
            }
            else if (secim.Key == ConsoleKey.D2)
            {
                GirisYap(kullanicilar, gunlukler);
              
            }
            else if (secim.Key == ConsoleKey.D3)
            {
                Console.WriteLine("Çıkış Yapılıyor...");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            
        }

               
        public static void KayitOl(List<Kullanici> kullanicilar, List<Gunluk> gunlukler)
        {
            Console.WriteLine("Kullanıcı Adı Giriniz:");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz:");
            string sifre = Console.ReadLine(); // Şifreyi güvenli bir şekilde saklamak için hash işlemi uygulanmalıdır.

            Kullanici kullanici = new Kullanici
            {
                KullaniciAdi = kullaniciAdi,
                SifreHash = HashSifre(sifre),
                OlusturulmaTarihi = DateTime.Now,
            };

            kullanicilar.Add(kullanici);

            Console.WriteLine("Kullanıcı Bilgileriniz Başarıyla Kaydedildi");
            Thread.Sleep(2000);
            Console.Clear();
            KullaniciMenu(kullanicilar,gunlukler);
        }

        public static void GirisYap(List<Kullanici> kullanicilar, List<Gunluk> gunlukler)
        {
            Console.WriteLine("Kullanıcı Adı Giriniz:");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz:");
            string sifre = Console.ReadLine();

            Kullanici girisYapanKullanici = kullanicilar.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi && k.SifreHash == HashSifre(sifre));

            if (girisYapanKullanici != null)
            {
                Console.WriteLine("Giriş Başarılı");

               
            }
            else
            {
                Console.WriteLine("Hatalı Kullanıcı Adı veya Şifre");
            }

            Thread.Sleep(2000);
            Console.Clear();
            Metot.GunlukMenu(gunlukler);
            
        }

        private static string HashSifre(string sifre)
        {
            
            return sifre;
        }
    }
}

