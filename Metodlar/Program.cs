using System;

namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            int urunFiyati = 15;
            string urunAciklamasi = "amasya elmasi";
            string[] meyveler = new string[] {};
            Urun urun1 = new Urun();//class da değişken tanımlama
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();//class da değişken tanımlama
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };
            foreach (Urun urun in urunler)//type safe--tip güvenli, Urun(veri tipi)
            {
                Console.WriteLine(urun.Adi);//yazılımcının kendisini kontrol etmesini sağlar(CW tap tap)
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------");

            }

            Console.WriteLine("---metodlar----");
            //instance--class örneği oluşturma
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("armut", 19, "sarı armut", 100);
            sepetManager.Ekle2("karpuz", 13, "diyarbakır karpuzu",200);
        }

    }
    //Tekrar tekrar kullunımı sağlayan bloklar
}
