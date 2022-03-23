using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // string kategoriEtiketi-- "Kategori";
            // do not repeat your self--Kendini tekrarlama

            string kategoriEtiketi = "Kategori";
            int oğrenciSayisi = 32000;
            double FaizOrani = 1.45;
            bool SistemeGirişYapmısmı = true;
            double Dolardun = 7.45;
            double Dolarbugun = 7.45;


            if (Dolardun>Dolarbugun)
            {
                Console.WriteLine("Dolar azalmıştır"); // Simülatör butonu :D
            }
            else if(Dolardun==Dolarbugun)
            {
                Console.WriteLine("dolar değişmemiştir"); // Simülatör butonu
            }
            else
            {
                Console.WriteLine("Dolar artmıştır");
            }


            if (SistemeGirişYapmısmı == true)
            {
                Console.WriteLine("kullanıcı ayarı butonu"); // simülatör buton
            }
            else
            {
                Console.WriteLine("Lütfen giriş yapınız"); // simülatör buton
            }



            

            

            
        }

    }
}
