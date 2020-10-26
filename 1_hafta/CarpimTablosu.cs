using System;
using System.Collections.Generic;
using System.Text;

namespace _1_hafta
{
    class CarpimTablosu
    {
        public static void Carpim()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j  <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} ={2}",i,j,(i*j));
                   
                }
                Console.WriteLine("----------------");
            }
        }
    }
}
