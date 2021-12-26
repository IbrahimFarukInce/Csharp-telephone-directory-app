using System;
using System.Collections.Generic;

namespace telefon_rehberi
{
    class Kisi
    {
        private string isim;
        private string soyisim;
        private string numara;

        public static List<Kisi> KisiListesi = new List<Kisi>();
        


        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Numara { get => numara; set => numara = value; }

        public Kisi(string ısim, string soyisim = null, string numara = null)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Numara = numara;
        }
        
        public Kisi(){}

        public static void Kaydet()
        {    
            Console.WriteLine("İsim :");    
            string isim = Console.ReadLine();
            Console.WriteLine("Soyisim  :");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Numara  :");
            string numara = Console.ReadLine();
            KisiListesi.Add(new Kisi(isim,soyisim,numara));
            Console.WriteLine("Başarıyla Kaydedildi");            
        }

        public static void Kaydet(string isim,string soyisim,string numara)
        {
            KisiListesi.Add(new Kisi(isim,soyisim,numara));
            Console.WriteLine("Başarıyla Kaydedildi"); 
        }

        public static void Sil()
        {
            Console.WriteLine("Silmek istediğiniz Kişinin İsim veya Soy İsmini Giriniz");
            string silinecek = Console.ReadLine();
            int index = IndexArama(silinecek);
            if (index!=-1)
            {
                Console.WriteLine("isim: {0} Soyisim: {1} Numara: {2}\nKayıt Silinecek Onaylıyormusunuz(e/h)",KisiListesi[index].isim,KisiListesi[index].soyisim,KisiListesi[index].numara);
                    string cevap=Console.ReadLine();
                    switch (cevap)
                    {
                        case "e":
                            KisiListesi.RemoveAt(index);
                            Console.WriteLine("Başarıyla Silindi"); 
                            break;
                        case "h":
                            break;
                        default:
                            Console.WriteLine("Yanlış Bir karakter girdiniz");
                            break;
                    }  
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
                string reader = Console.ReadLine();
                switch (reader)
                {        
                    case "1":
                        break;
                    case "2":
                        Kisi.Sil();
                        break;
                    default:
                    Console.WriteLine("Yanlış Bir karakter girdiniz");
                    break;
                }
            }
            
        }

        public static void Guncelle()
        {
            Console.WriteLine("Guncellemek istediğiniz Kişinin İsim veya Soy İsmini Giriniz");
            string guncellenecek = Console.ReadLine();
            int index = IndexArama(guncellenecek);
            if (index!=-1)
            {
                Console.WriteLine("Güncel Telefon Numarasını Grininiz");
                KisiListesi[index].numara = Console.ReadLine();
                Console.WriteLine("Başarıyla Güncellendi");   
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
                string reader = Console.ReadLine();
                switch (reader)
                {        
                    case "1":
                        break;
                    case "2":
                        Kisi.Guncelle();
                        break;
                    default:
                    Console.WriteLine("Yanlış Bir karakter girdiniz");
                    break;
                }
            }
            
        }
        

        private static int IndexArama(string aranan)
        {
            int counter = 0;
            foreach (var item in KisiListesi)
            {
                if (item.isim.ToLower().StartsWith(aranan.ToLower()) || item.soyisim.ToLower().StartsWith(aranan.ToLower()))
                {
                    
                 return counter;   
                }
                counter++;    
            }
            return -1;
        }

        public static void Yazdır()
        {
            
            foreach (var kisi in KisiListesi)
            {
                Console.WriteLine("İsim     :"+kisi.Isim);
                Console.WriteLine("Soyisim  :"+kisi.Soyisim);
                Console.WriteLine("Numara   :"+kisi.Numara);
                Console.WriteLine("-");
            }
        }

        
    }
    
}
