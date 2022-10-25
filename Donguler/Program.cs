using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Kurs1 = "Yazılım GYK";
            string Kurs2 = "Programlamaya baslangıc";
            string Kurs3 = "java";
            //array-diziler
            string[] kurslar=new string[] { "Yazılım GYK", "Programlamaya baslangıc", "java", "python", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");    
            }

        }
    
}
