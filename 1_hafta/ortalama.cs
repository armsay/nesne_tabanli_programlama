using System;

namespace _1_hafta
{
    class Ortalama
    {
        public static void OrtalamaHesabi()
        {

            for (int i = 0; i < 1;)
            {
                Console.Write("Vize Notunuz:");
                int vize = Convert.ToInt32(Console.ReadLine());
                Console.Write("Final Notunuz:");
                int final = Convert.ToInt32(Console.ReadLine());

                double ortalama = vize * 0.4 + final * 0.6;



                if (vize <= 100 && final <= 100 && vize >= 0 && final >= 0)
                {
                    if (ortalama >= 50 && ortalama <= 100)
                    {
                        Console.WriteLine("Geçtiniz.");
                    }
                    else if (ortalama < 50 && ortalama >= 0)
                    {
                        Console.WriteLine("Kaldınız.");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış veri girildi.");
                    }

                    i++;
                }
                else
                {
                    Console.WriteLine("Vize ve Final notunu 0-100 arasında giriniz.");

                }

            }

        }
    }
}
