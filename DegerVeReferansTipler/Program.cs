using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30; 
            sayi1= sayi2;//sadece değer atanır sayi1 in sayi2 ile ilişkisi yok
            sayi2 = 65;
            //sayi1=?---30
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;//Sayilar1 in referans numarası sayilar2 nin numarasına eşitleniyor
            sayilar2[0] =999;    
            //sayilar1[0]=?---999

            }

        }

    }


