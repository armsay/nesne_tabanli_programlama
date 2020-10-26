using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace _1_hafta
{
    class BuyukSayi
    {
        public static void KucukBuyuk()
        {
            Console.Write("Bir sayı giriniz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Bir sayı giriniz:");
            int b = int.Parse(Console.ReadLine());


            if (a < b)
            {
                Console.WriteLine("b sayısı büyüktür.");
            }else
            {
                Console.WriteLine("a saygısı büyüktür.");
            }
        }
    }
}
