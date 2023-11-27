namespace Gunluk.ConsoleApp

{
    internal class Program
    {
       
        static void Main(string[] args)
        {
          



            List<Kullanici> kullanicilar = new List<Kullanici>();
            List<Gunluk> gunlukler = new List<Gunluk>();

            Console.WriteLine("Günlük Uygulamasına Hoşgeldiniz.\n");
            Thread.Sleep(1500);
            Console.Clear();

            Kullanici.KullaniciMenu(kullanicilar, gunlukler);
            while (true)
            {
                Thread.Sleep(3000);
                Console.Clear();

                
                Metot.GunlukMenu(gunlukler);


            }

            
        }


    }
}


