using System;
using System.Collections.Generic;
using System.Text;

namespace _1_hafta
{
    class KitleEndeksi
    {
        public static void VucutKitle()
        {
            double kilo,boy,sonuc;

            Console.Write("Kilonuzu giriniz: ");
            kilo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Boyunuzu giriniz: ");
            boy = Convert.ToDouble(Console.ReadLine());
            sonuc = kilo / Math.Pow(boy/100,2);
            Console.WriteLine("Vücut kitle indeksiniz: {0}", sonuc);

            if (sonuc <= 18.9)
            {
                Console.WriteLine("ZAYIF");
            }
            else if (sonuc <= 24.9 && sonuc>=19)
            {
                Console.WriteLine("NORMAL");
            }
            else if (sonuc <= 29.9 && sonuc >= 25)
            {
                Console.WriteLine("TOPLU (Hafif Şişman)");
            }
            else if (sonuc <= 34.9 && sonuc >= 30)
            {
                Console.WriteLine("OBEZ (Sağlık Açısından Riskli)");
            }
        }
    }
}
