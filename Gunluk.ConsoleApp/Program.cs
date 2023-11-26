namespace Gunluk.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Kullanici> kullanici = new List<Kullanici>();
           List<Gunluk> gunlukler = new List<Gunluk>();

            Console.WriteLine("Günlük Uygulaması\n");
            Console.Clear();
            while (true)
            {
                Menu(gunlukler);
              
            }
           
            
        }

     
        static void KayitEkle(List<Gunluk> gunlukler)
        {
            Console.WriteLine("Günlük uygulamasına hoşgeldiniz. Girmek istediğiniz metni girin:");
            string metin = Console.ReadLine();
            Gunluk yeniGunluk = new Gunluk
            {
                Metin = metin,
                Tarih = DateTime.Now
            };
            gunlukler.Add(yeniGunluk);

            Console.WriteLine($"Günlük başarıyla kaydedildi \n");



        }
        static void KayitlariListele(List<Gunluk> gunlukler)
        {
            Console.WriteLine("\nGünlükleri Listele:");

            foreach (var gunluk in gunlukler)
            {
                Console.WriteLine($"Metin: {gunluk.Metin} Tarih:{gunluk.Tarih}");
            }
            Console.WriteLine();
        }

        public static void Menu(List<Gunluk> gunlukler)
        {
            Console.WriteLine("1.Kayıt ekle\n2. Kayıtları Listele\n3.Kayıtları Sil\n4.Tüm kayıtları Sil\n5. Çıkış");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                KayitEkle(gunlukler);
            }
            else if (secim == 2)
            {
                KayitlariListele(gunlukler);
            }
        }
    }
}

/*1. versiyon
Tek bir kullanıcı için günlük uygulaması yapıyoruz. 
Kullanıcı uygulamayı açtığında bir takım seçenekler göstereceğiz. Seçenekler; yeni kayıt ekle, kayıtları listele, tüm kayıtları sil ve çıkış olmalı
Yeni kayıt eklendiğinde datetime.now kullanmalısınız. veritabanındaki tablolarımızda girdi tarihi ve güncellenme tarihi verilerini saklamak iyi bir pratik olduğu için mutlaka yer vermelisiniz.
Eğer kullanıcı tüm kayıtları sil derse mutlaka emin olup olmadığını sormalıyız :)
Kayıtları listelerken aralarına çizgi çekerek birbirinden ayıralım. Kayıt tarihini de günlük üstünde belirtmemiz lazım. 
Örneğin
19 Ağustos 2023
Orhan hoca bugün değişik bir ödev verdi. Yaparken çok keyif aldım.
*/
