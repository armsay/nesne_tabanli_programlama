using System;
using System.Collections.Generic;
using System.Text;

namespace _1_hafta
{
    class CarpimToplama
    {
        public static void CarpTopla()
        {
            Console.Write("Bir sayı giriniz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Bir sayı giriniz:");
            int b = int.Parse(Console.ReadLine());
            int top = 0;

            for (int i = 1; i <= a; i++)
            {
                top += b;
            }

            Console.WriteLine("Sonuç: {0}", top);



        }
    }
}
