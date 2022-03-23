using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadı1 = "Elma";
            double urunfıyatı1 = 15;
            string urunacıklama1 = "Amasya Elması";
            
            //Yukardaki ile alakası yok aşşanın

            Urun urun1 = new Urun();            // Bu Kesin yapılcak dizi tanımlıyorsan eğer.

            urun1.Adi = "Elma";
            urun1.Açıklama = "Amasya Elması";
            urun1.Fiyatı = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Açıklama = "Çilek gibi çilek";
            urun2.Fiyatı = 80;

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Açıklama);
                Console.WriteLine("-----------");
            }


            Console.WriteLine("Metotlarrrrrrrrrrrr");

            SepetManager sepetManager = new SepetManager();        // mecburi yapacaksın bunu.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            

            
            
              

            
        }
    }
}
// dont repeat your self---Clean Code--- Best Practice
