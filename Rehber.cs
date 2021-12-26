using System;

namespace telefon_rehberi
{
    class Rehber:Kisi
    {
        
        public static string Menu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(q) Çıkış Yapmak");
            string cevap = Console.ReadLine().ToLower();
            return cevap;
            
        }
        public static void RehberListele()
        {
            Console.WriteLine("  Telefon Rehberi\n**********************************************");
            Yazdır();

        }
        public static void KisiArama()
        {
            Console.WriteLine("Aranan Kişilerin İsim veya Soyismini giriniz");
            string aranan = Console.ReadLine();
            foreach (var kisi in KisiListesi)
            {
                if (kisi.Isim.ToLower().StartsWith(aranan.ToLower()) || kisi.Soyisim.ToLower().StartsWith(aranan.ToLower()))
                {
                    Console.WriteLine("İsim     :"+kisi.Isim);
                    Console.WriteLine("Soyisim  :"+kisi.Soyisim);
                    Console.WriteLine("Numara   :"+kisi.Numara);
                    Console.WriteLine("-");
                }
            }
        }
        
    }
}    