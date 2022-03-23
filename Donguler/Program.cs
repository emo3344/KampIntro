using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // array-dizi
            string[] kurslar = new string[]
            {
            "Yazılım geliştirici yerleştirme kampı",
            "Programlamaya başlangıç temel kurslar",
            "Java","Python","C++"
            };

            for(int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti...");

            foreach (string kurs in kurslar)   // KURSLARI TEK DOLAŞ
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu---Footer");
            

           
        }
    }
}
