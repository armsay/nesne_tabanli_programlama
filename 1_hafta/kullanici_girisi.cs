using System;


namespace _1_hafta
{
    class KullaniciGirisi
    {
        public static void Kullanici()
        {

            for (int i = 0; i < 1;)
            {
                Console.Write("Kullanıcı Adı:");
                string kullanici_adi = Console.ReadLine();
                Console.Write("Şifre: ");
                string sifre = Console.ReadLine();

                if (kullanici_adi == "armsay" && sifre == "12345")
                {
                    Console.WriteLine("Giriş Başarılı");
                    i++;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre geçersiz.");
                }
            }
            


        }
    }
}
