using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim_Belirleyiciler_ve_Kurucu_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        { //Söz Dizimi
            //Class SinifAdi
            //{
            //    [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi(Parametre Listesi)
            //    }  
            //      // Metot Komutları
            //    }
            //}


            // Erişim Belirliyicileri
            //public
            //private
            //internal
            //protected

            Console.WriteLine("-----Çalışan 1-----");
            Calisan calisan1 = new Calisan("Ali", "Uygun", 1234256, "Bilişim");
        
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Çağrı ";
            calisan2.Soyad = "Dönmez";
            calisan2.No = 6543210;
            calisan2.Departman = "Yönetim";

            Console.WriteLine("-----Çalışan 2-----");

            calisan2.CalisanBilgileri();

            Console.WriteLine("*****Çalışan 3*****");
            Calisan calisan3 = new Calisan("Veli", "Özdemir");
            calisan3.CalisanBilgileri();
            Console.ReadLine();
        }
        class Calisan
        {
            public string Ad;

            public string Soyad;

            public int No;

            public string Departman;
            public Calisan(string ad, string soyad, int no, string departman)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }
            public Calisan(string ad, string soyad)
            {
                this.Ad = ad;
                this.Soyad = soyad;
            }
            public Calisan() { }
            public void CalisanBilgileri()
            {
                Console.WriteLine();
                Console.WriteLine("Çalışanın Adı: {0}", Ad);
                Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
                Console.WriteLine("Çalışanın Numarası: {0}", No);
                Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
            }

        }


    }
}
