using System;

namespace telefon_rehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1) Yeni Numara Kaydetmek
            // (2) Varolan Numarayı Silmek
            // (3) Varolan Numarayı Güncelleme
            // (4) Rehberi Listelemek
            // (5) Rehberde Arama Yapmak
            // (q) Çıkış Yapmak
            Kisi.KisiListesi.Add(new Kisi("Ali","İnce","05222541487"));
            Kisi.KisiListesi.Add(new Kisi("Ahmet","Durmaz","05222541487"));
            Kisi.KisiListesi.Add(new Kisi("Zeki","Çelik","05222541487"));
            Kisi.KisiListesi.Add(new Kisi("Mustafa","Ak","05222541487"));
            Kisi.KisiListesi.Add(new Kisi("Esat","Kayacı","05222541487"));
            Kisi.KisiListesi.Add(new Kisi("Fatih","Güven","05222541487"));
            //Boş Gözükmesin diye önden kişi ekledim
            while (true)
            {
                string cevap = Rehber.Menu();
                if (cevap=="1"){
                    Rehber.Kaydet();
                }
                else if (cevap=="2"){
                    Rehber.Sil();
                }
                else if (cevap=="3"){
                    Rehber.Guncelle();
                }
                else if (cevap=="4"){
                    Rehber.RehberListele();
                }
                else if (cevap=="5"){
                    Rehber.KisiArama();
                }
                else if(cevap=="q"){
                    break;
                }
                else{
                    continue;
                }                
            }
                 
        }
    }
}

