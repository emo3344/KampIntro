using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı= "emre";
            int yas = 24;

            Kurs kurs1 = new Kurs();       ///// önemli öğren burayı
            kurs1.Kursadı = "C#";
            kurs1.KursunEgitmeni = "Engin demirog";
            kurs1.Kursunizlenmeoranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadı = "java";
            kurs2.KursunEgitmeni = "Kerem varış";
            kurs2.Kursunizlenmeoranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadı = "python";
            kurs3.KursunEgitmeni = "berkay bilgin";
            kurs3.Kursunizlenmeoranı = 80;

            //Console.WriteLine(kurs1.Kursadı + " " + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar )
            {
                Console.WriteLine(kurs.Kursadı + " " + kurs.KursunEgitmeni );
            }
            
            

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string Kursadı { get; set; }         // get = elde etmek
        public string KursunEgitmeni { get; set; }  // set = ayarlar
        public int Kursunizlenmeoranı { get; set; } //prop=özellikler

    }

}
