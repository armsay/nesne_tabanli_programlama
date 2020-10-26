using System;
using System.Collections.Generic;
using System.Text;

namespace _1_hafta
{
    class HarfUzunlugu
    {
        public static void Uzunluk()
        {
            Console.Write("Kelime giriniz: ");
            string kelime = Console.ReadLine();
            int uzunluk = kelime.Length;

            Console.WriteLine("Kelime uzunluğu: {0}",uzunluk);


        }
    }
}
