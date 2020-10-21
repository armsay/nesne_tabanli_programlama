using System;

namespace _1_hafta
{
    class Program
    {
        static void Main(string[] args)
        {
            KullaniciGirisi.Kullanici();
            Console.WriteLine("");
            
            Ortalama.OrtalamaHesabi();
            Console.WriteLine("");
            
            KitleEndeksi.VucutKitle();
            Console.WriteLine("");


            Console.ReadKey();
        }

       
    }
}
