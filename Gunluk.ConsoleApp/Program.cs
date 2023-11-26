namespace Gunluk.ConsoleApp
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Kullanici> kullanici = new List<Kullanici>();
           List<Gunluk> gunlukler = new List<Gunluk>();
            
            Console.WriteLine("Günlük Uygulamasına Hoşgeldiniz.\n");
            Thread.Sleep(1500);
            Console.Clear();
            while (true)
            {
                Metot.Menu(gunlukler);
              
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
