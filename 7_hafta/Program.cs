using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {

            Hesapla.Dikdortgen.alanHesapla(5, 4);
            Hesapla.Dikdortgen.cevreHesapla(5, 4);


            Console.WriteLine("Öğrenci mi?");
            string ogrenci = (Console.ReadLine()).ToLower();


            if (ogrenci == "e")
            {
                Musteri student = new Musteri();

                Console.Write("Adı: ");
                student.ad = Console.ReadLine();
                Console.Write("Soyadı: ");
                student.soyad = Console.ReadLine();
                Console.Write("Yaşı: ");
                student.yas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Öğrenci No: ");
                student.ogrenci_no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Adı: {0}", student.ad);
                Console.WriteLine("Soyadı: {0}", student.soyad);
                Console.WriteLine("Yaşı: {0}", student.yas);
                Console.WriteLine("Öğrenci No: {0}", student.ogrenci_no);
            }
            else if (ogrenci == "h")
            {
                Musteri person = new Musteri();
                Console.Write("Adı: ");
                person.ad = Console.ReadLine();
                Console.Write("Soyadı: ");
                person.soyad = Console.ReadLine();
                Console.Write("Yaşı: ");
                person.yas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mesleği: ");
                person.meslek = Console.ReadLine();
                Console.Write("Maaşı: ");
                person.maas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Adı: {0}", person.ad);
                Console.WriteLine("Soyadı: {0}", person.soyad);
                Console.WriteLine("Yaşı: {0}", person.yas);
                Console.WriteLine("Meslek: {0}", person.meslek);
                Console.WriteLine("Maaşı: {0}", person.maas);

            }
            else
            {
                Console.WriteLine("Yanlış değer girdiniz.");
            }


            Console.ReadKey();
        }
    }
    
}
