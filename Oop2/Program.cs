using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1235;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Veli";
            musteri1.TcNo = "12345678901";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1234;
            musteri2.VergiNo = "1234567";
            musteri2.MusteriNo = "12356";
            musteri2.SirketAdi = "Vın Turizm";
            

            //GErçek Müsşteri - Tüzel Müsşteri
            // Solid
            //İnheritance ı niye yapıyoruz müdür? Musteri burada gercek ve tuzel musterinin referansını tutuyor miras yoluyla

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
