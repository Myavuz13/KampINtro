using System;

namespace KampINtro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //kategoriEtiketi değer tutucu, takma ad
            string kategoriEtiketi = "kategoriler";
            int OgrenciSayisi = 100;
            double FaizOrani = 1.45;
            bool SistemeGirisYapmisMi = true;
            double DolarDun = 7.45;
            double DolarBugun = 7.45;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            if (SistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
       
        }
    }
}
