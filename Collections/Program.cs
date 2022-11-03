using System;
using System.Collections.Generic;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "mehmet", "asli", "yavuz", "talan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];//burada isimlere yeni bir adress tanımlandığı için tüm elemanlar yeniden tanımlanmalı yoksa mehmet,asli,yavuz,talan isimlerini algılamayacak çünkü bunlar eski adreste kaldı yeni adreste yok
            //isimler[4] = "alim";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            List<string> isimler2 = new List<string> { "mehmet", "asli", "yavuz", "talan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("alim");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
