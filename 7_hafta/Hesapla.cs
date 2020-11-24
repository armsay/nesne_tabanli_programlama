using System;
using System.Collections.Generic;
using System.Text;

namespace Hesapla
{

    class Dikdortgen
    {
        public int b;
        public int h;


        public static int alanHesapla(int b, int h)
        {
            int alan = b * h;
            Console.WriteLine("Dikdörtgen alanı: " + alan);
            return alan;

        }

        public static int cevreHesapla(int b, int h)
        {
            int cevre = 2 * b + 2 * h;
            Console.WriteLine("Dikdörtgen çevresi: " + cevre);
            return cevre;
        }
    }
}
