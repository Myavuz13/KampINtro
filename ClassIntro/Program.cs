using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "mehmet";
            int yasi = 29;

            Kurs kurs1= new Kurs();
            kurs1.kursadi = "C#";     
            kurs1.Egitmen = "mehmet yavuz";
            kurs1.IzlenmeOrani = 68;
            Kurs kurs2 = new Kurs();
            kurs2.kursadi = "pyhton";
            kurs2.Egitmen = "yavuz";
            kurs2.IzlenmeOrani = 70;
            Kurs kurs3 = new Kurs();
            kurs3.kursadi = "java";
            kurs3.Egitmen = "mehmet-yavuz";
            kurs3.IzlenmeOrani = 13;
            // Console.WriteLine(kurs1.kursadi + ":" + kurs1.Egitmen + ":" + kurs1.IzlenmeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs1.kursadi + ":" + kurs1.Egitmen + ":" + kurs1.IzlenmeOrani);
            }

        }

    }
    class Kurs
    {
        public string kursadi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
